# MECHANICS SPEC

> ## CORRECTION (supersedes §1 below where they differ): the real movement constants
> The numbers in §1 came from the per-character `PhysicsData` asset. Later recon found the game's *actual* movement tuning in `SpeedRunnersSettingsData` (full dump: `docs/modes/SpeedRunnersSettingsData.md`, decoded file `data/decoded_quantumdb/DataFiles/SpeedRunnersSettingsData.txt`). **Use these as the authority.** Units: u/s, u/s², frames @60 Hz. [M] = read directly from game data.
>
> | Param | Value | Param | Value |
> |---|---|---|---|
> | Gravity | **31.5** | MaxFallSpeed / TerminalVelocity | **40.35 / 46.875** |
> | MaxWalkVelocity | **10.375** | MaxRunVelocity | **19.75** |
> | MaxBoostVelocity | **29.125** | MaxSuperBoostVelocity | **38.5** |
> | VelocityForSuperSpeed (accolade/state) | **25** | MaxHookVelocity (speed cap after hook attach) | **24.737** |
> | MaxSwingSpeed | **24.938** | SwingDeceleration | 2.125 |
> | WalkAcceleration | 29.125 | RunAcceleration | 8.8125 |
> | AirAcceleration | 5.6875 | AirAccelerationAfterWallJump | 20.75 |
> | BoostWalkAcceleration / BoostRunAcceleration / BoostAcceleration | 76.35 / 38.85 / 26.7 | SuperBoostAcceleration / Deceleration | 18.75 / 18.75 |
> | GroundDeceleration | 18.75 | AirDeceleration | 6.25 |
> | BrakeDeceleration | 37.5 | BoostDeceleration | 9.025 |
> | SlideDeceleration | 8.5938 | SlideDecelerationPostBoosting / ForBoost | 12.5 / 3.125 |
> | MinVelocityToSlide | 9.375 | MinVelocityForRunTurn | 3 |
> | MinVelocityForDrag / Trip / Min | 10.375 / 2 / 1 | Stunned: accel / turn accel / decel / maxVel | 0.9375 / 4.6875 / 2.8125 / 8.25 |
> | JumpFrames | **15** | JumpPower | **89.875** |
> | DoubleJumpPower (air jump) | **6.25** | WallJumpPower | **46.875** |
> | WallJumpAngle | **77.5°** | WallJumpUpwardMotionRetainer | 0.5 |
> | CaterpillarSpeedBoost | **22** | Caterpillar window | 8 frames |
> | Boost range | 0..100 | Boost drain / fill | 42 / 200 per s (x1.1 fill single-player) |
> | Slope up / down multiplier | 1 / 1 | Slope velocity inheritance | 1 |
> | Step-up distance | 0.8 (linecast start (1,1.2), length 4) | Above-wall check | start (0,1.6), len 1.5 |
> | SlopeSurf cooldown / vertical threshold | 90 f / 0.5 | Big-air frames / allowed swings | 240 f / 2 |
> | Hook: extend rate / angle / start point | 93.75 u/s / 45° / (0.78, 1.4) | MaxSwingAngle | 17.99 |
> | Hook / slide / wall-slide cooldown | 15 / 30 / 10 frames | Reverse-grapple window | 6 frames |
>
> **How to read them [I, from decompiled code structure]:** these are the *speed caps and accelerations* of the model "accelerate toward the cap for the current mode, decelerate above it": walk cap 10.4, run cap 19.75, boost cap 29.1, super-boost cap 38.5, hook-release cap 24.7. The slow character PhysicsData values (run 8 etc.) in §1 are a legacy/secondary layer — build the controller around **MaxRun 19.75 / MaxBoost 29.125** and the accelerations above.
> **Jump [I]:** `JumpPower 89.875` is an *acceleration-like* power integrated over `JumpFrames = 15` (0.25 s) along an eased profile (the native `IntegrateJumping` interpolates a velocity curve across the jump frames), not an instant velocity; with gravity 31.5 the net upward speed peaks around 14-15 u/s and apex ≈ 5 u (tune). Short jump = stop adding power early. Air jump adds `6.25`-scale upward impulse; wall jump uses power 46.875 launched at **77.5° from horizontal** away from the wall, keeping 50% of existing upward motion, with temporarily higher air accel (20.75).
> Scale: at 1 unit = 3 studs, MaxRun 19.75 u/s = ~59 studs/s; if that feels too fast for Roblox, use 1 unit = 2 studs (~40 studs/s) and scale everything uniformly.
> Native-code findings (docs/research/README.md §7): jump = eased velocity ramp over JumpFrames (curve assets not recoverable → tune apex ≈ 4-5 u); hook rope length = distance at attach time, no max-length constant exists in the game data (cap it yourself, ~16-20 u); swing cap 24.938, MaxSwingAngle 17.99. Remaining unknown: exact jump-curve shape and swing pump force — tune by playtest.

Legend: **[M]** measured from reference data · **[I]** inferred from structure/names, verify by playtest · **[T]** tune by feel.

## 0. World, scale, time
- Gameplay is on a **2D plane** (X right, Y up); 3D art is rendered with a side-on camera. In Roblox: lock characters to a plane (e.g. fixed Z) with an invisible Z-constraint; all collision is 2D-style. [M]
- Simulation 60 Hz fixed step, deterministic rollback netcode in the reference. [M] In Roblox use server-authoritative + client prediction, not rollback.
- Reference units are metres. Default camera viewport = **40 x 22.5 units** (16:9) at zoom 1.0; zoom range **1.0-1.35**. [M]
- **Scale: 1 unit = 3 studs** [T] → run speed 12 u/s = 36 studs/s (Roblox default WalkSpeed is 16, so this is a *fast* game; keep camera wide). Character ≈ 2 u tall ≈ 6 studs.
- Gravity-driven custom kinematic controller. **Do not use Roblox Humanoid physics** (see ARCHITECTURE.md).

## 1. Baseline movement constants (units/s, units/s², "friction" = exponential-style decel in u/s²) [M]
| Param | Base | "Light" archetype set (all 12 chars use one of these) |
|---|---|---|
| Gravity | 32.5 | 31.25-32 |
| FallSpeed (terminal) | 9999 (uncapped) | 10 or uncapped |
| RunSpeed | 12 | **8** |
| WalkFastSpeed | 10 | 6 |
| WalkSlowSpeed | 1.6 | 3 |
| AirSpeed (horizontal cap from input) | 5.7 | 5 |
| AirAcceleration | 8 | 16 |
| AirFriction | 5 | 5 |
| GroundAcceleration | 10 | 25 |
| GroundFriction | 15 | 24 |
| Extra friction above speed threshold | thresholds 7..10, factor 1 | same |
| MinWallNormal (|nx| to count as wall) | 0.9 | 0.9 |
| MinSlopeNormal (ny to count as walkable) | 0.6 | 0.6 or 0.7 |
| KnockbackDecay | 22.19 | 22 |
| Restitution (bounce) / MinMagnitudeForBounce | 0.85 / 12 | same |
| HitStun gravity / ground friction | 31.25 / 24 | 32 / 24 |
| CrowdPush radius / force | 0.45 / 0.5-2 | same (soft push between overlapping players) |

**Archetypes for original characters** (do not copy names): build 4 original runners from these four tuning sets:
A: g=32, fall cap 10, slope 0.7 · B: g=32, fall cap 10, slope 0.6 · C: g=31.25, uncapped fall, slope 0.7 · D: g=31.25, uncapped, slope 0.6.
All share run 8 / airAcc 16 / groundAcc 25 / groundFric 24. Differences between characters in the reference are small; **speed comes from boost/hook/slide/wall tech, not base stats**. [M]

Interpretation [I]: horizontal ground speed approaches `RunSpeed` at `GroundAcceleration`; when no input, decelerates at `GroundFriction`. Above `RunSpeed` the player is "over cap" (from boost/hook/slide) and decays by friction (extra friction between the min/max thresholds) — this is how momentum is preserved and lost. Air: input accelerates toward `AirSpeed` at `AirAcceleration`; `AirFriction` applies when no input.

## 2. Input [M]
- Stick deadzone: min 0.2, max 0.9 (rescale between). Axis threshold 0.2; "flick" threshold 0.6 within **7 frames**.
- **Input buffer: jump 10f, hook 10f, use-item 10f**; direction-hold buffer 3f.
- Direction cones (degrees from +X): grounded Up 35..145, Forward -45..35, Down -135..-45; airborne Up 29..151, Forward -45..29, Down -135..-45.
- Buttons: Jump, Hook, UseItem (+ Slide via Down, Taunt). Support keyboard, gamepad, mobile touch.

## 3. State machine [M structure / I details]
States (base character): Idle, Idle Alt, Idle Air, Run, Run Turn, Jump (anticipation→jump), Air Jump, Wall Slide, Wall Jump, Slide, Back Flip, Hook Launch, Hook Swing (up/down), Pulled By Hook (+End), Ridedown Slopes, Roll Land, Land (easy/hard), Hurt, Tumble, Trip, Freeze, Knocked Out, Respawn, Entrance, Victory, Taunt, Place Item, On Enter Blastzone, Start InviciDrill, Start LightningWatch.
Each frame a state runs a list of behaviours (input check, item-use check, movement, wall-slide detect, hurtbox/hitbox setup, ECB update, animation/VFX/SFX). Implement as a table-driven FSM: `State = { onEnter, onUpdate(dt), onExit, transitions }`. See `docs/states/CharacterBase_states.md`.

## 4. Jumping [I/T] (jump height/impulse tables were not recoverable as plain data — tune by feel)
- Anticipation frames before leaving ground (short, ~2-4f) [T]. Variable height: releasing Jump early = **short jump** (`GroundShortJump`), holding = full (`GroundJump`).
- **Air jump: 1 use per airtime** (`MaxUses 1`, spent in air, refilled on ground) [M].
- **Wall jump** from wall slide; kicks away from wall with an up+out impulse [I].
- Suggested start values [T] at scale 1u=3 studs: full jump apex ≈ 3.2 u, short ≈ 1.8 u → initial v = sqrt(2·g·h) ≈ 14 u/s (full), 10.5 u/s (short); air jump ≈ 12 u/s; wall jump ≈ (7, 13) u/s.

## 5. Wall slide & ledges [M/I]
- Wall detect needs wall normal ≥ **0.98** (very vertical walls) on layers Wall/TrapDoor [M]. Falling speed reduced while sliding; cooldown **10f** before re-grab [M].
- Ledge climb check while wall-sliding (pulls up and over a ledge) [I]. "Stepping over ledge" flag exists. Edge-grab exists for NPC/boss entities.

## 6. Slide [M/I]
- Triggered by Down on ground (and while running). Cooldown **30f** [M]. Short invulnerability to bombs while sliding ("bomb invul") [M]. Keeps momentum, lower hitbox, ridedown-slopes speeds slide on downhill, can hit/tackle. Ends into Idle/Idle Air (4f transition), can jump out of it. Resets moveset limiters (air jump) [M].

## 7. Grappling hook (signature mechanic) [M/I]
- Fires from offset **(0.78, 1.4)** relative to feet at angle **45°** toward facing, extends at **93.75 u/s** until it hits a **ceiling-layer** collider (layer 9) or reaches max/fails [M]. Max length not recovered [T: ~9-12 u].
- Hit → "Hook Swing": pendulum around the anchor, rope length fixed; player can pump (hold direction) to gain speed; release (Hook or Jump) to launch with the swing's tangential velocity — this is the main speed source. Failed hook → recovery state. Hook **cooldown 15f** [M]. A "reverse grapple" tech exists with a **6f window**; "caterpillar" tech **8f window** [M] (frame-tight tricks that preserve speed; implement the windows as input leniency).
- Hook can be cancelled, can be pulled by (other players' Golden Hook item), and works with air-jump interplay (Hook Launch can chain Air Jump).
- Roblox: implement as a custom rope constraint in the controller (not RopeConstraint physics) — project velocity onto tangent each step (verlet/position-based).

## 8. Boost meter [M]
- Meter 0..**100**; **fills at 200/s** when standing in "boost filler" zones/pickups; **depletes at 42/s** while boosting [M]. Boost raises speed cap (super-speed; `HasSuperSpeed`, `IsInSuperBoost`, "SuperBoostVolume" stage zones give free boost). [I] Boost additionally grants item charge ("ItemPowerCharged/Increase"); items can auto-use on full charge.
- Tuning: boost multiplies run cap by ~1.5-1.8 and accel; show a HUD bar above the player and a trail VFX.

## 9. Blastzone / KO / respawn [M]
- Blastzone = the camera-follow region edge; leaving it starts a KO timer: **last remaining player 25f, others 115f**; blastzone **shrinks over time** (min size 35% of original, reduce speed ~0.01/s, forced reduction after **120f**, timer shown at **30f**) — this pushes players forward in races (anti-camping, "leader pulls the camera").
- Respawn: total length **4.0 s** (race), min spacing 0.5-0.9 s between respawns; respawn at last checkpoint / lead position; entrance state on spawn. Round-start wait 50f item cooldown; items have 30f cooldown after pickup.

## 10. Combat / knockback [M]
- Hits apply knockback: default **12.5 u/s**, rockets **15.625**; knockback decays at 22/s; flinch if knockback < 20, flop if < 10 (weight 100) [M]. Hit-stun uses its own gravity/friction. Block/tech states exist (`CombatBlock/Tech/DI`); stamina/stocks/armor components exist for the fight mode.
- Bounce off surfaces with restitution 0.85 if magnitude ≥ 12.

## 11. Camera [M]
- Follows the group; zoom 1.0→1.35 out as players spread (zoom-in speed 0.5, zoom-out 5), movement smoothing 6, vertical offset +4.69 u (single player: smoothing 5, offset 3.3), max distance-to-center 0.35 of view. Round-won slow-motion multiplier 0.2.

## 12. Scoring flavour ("accolades") [M names]
Super Speed, Big Air (cooldown 180f), Double/Triple Hit, Backfired, Tackle, Gotcha, Revenge, Still Alive, Dodged, The Distance, Freeze, Deflected, Blocked, Treasure, Floor-is-lava (1800f without grounding). Implement as optional toast popups with original names/art.

## 13. Research-informed additions (see docs/research/README.md; web sources are qualitative, numbers above remain from game data)
- Hook release: **late release = more height, early = more forward speed**; release near horizontal rope for forward travel; ~45° up to climb a ledge. Attaching keeps speed (set ropeLen = current distance) and **resets air-jump availability**. Cannot boost while hooked. Swing step: if |pos−anchor| > ropeLen, snap to rope length and remove outward radial velocity.
- Switchback boost: turning in midair right before firing the hook grants a small free speed bonus (our reverse-grapple 6f window) — implement as a lenient window, tune the bonus.
- Landing with a jump input in the first frames skips the roll/land state and keeps speed. Slide-jump (jump at end of slide) keeps momentum better than a plain jump. Downhill sliding adds slope-gravity acceleration; flat sliding bleeds speed.
- Boost trick: boost→jump→release boost preserves speed cheaply; hold boost in air drains the meter.
- Feel helpers (derived): coyote ≈ 5-7 frames, variable jump cut `vy *= 0.45` on release, corner correction up to 0.4 body widths, jump apex velocity `sqrt(2gH)`.
