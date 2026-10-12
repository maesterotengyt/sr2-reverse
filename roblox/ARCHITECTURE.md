# ARCHITECTURE (Roblox)

## Key decisions
1. **Custom character controller, not Humanoid.** Momentum, hooks, wall slides and frame-tight techs need deterministic, fixed-step kinematics. Use an anchored/primitive `HumanoidRootPart` (or a simple `Part`) moved by your own integrator; resolve collisions with `workspace:Blockcast`/`Raycast`/`GetPartBoundsInBox` against a Stage collision folder (use `CollisionGroups`).
2. **Fixed 60 Hz step** (accumulator on `RunService.PreSimulation`), identical code on client (prediction) and server (authority). Pure functions: `step(state, input, dt) -> state`.
3. **2D plane**: keep all gameplay in X/Y; lock Z. Stage geometry can have depth for art, collision is thin 2D-extruded boxes/wedges.
4. **Server-authoritative** state with client prediction + reconciliation: client sends input frames (frame#, stick, buttons bitmask) at 60 Hz in a single unreliable-ish batched remote; server replays and sends snapshots (pos, vel, stateId, boost, facing) ~20 Hz; client smooths remote players with interpolation (~100 ms buffer) and re-simulates own character on correction. Validate every field (type, range, rate limit). See `roblox-dev:roblox-security`.
5. **Data-driven**: tuning in `Tuning.luau`; characters = tuning table + original model; stages = Folder with tagged parts (CollectionService tags for elements).

## Rojo layout
```
src/
  Shared/
    Config/Tuning.luau          -- every number from MECHANICS_SPEC
    Sim/Step.luau               -- pure step function
    Sim/Collision.luau          -- 2D sweep vs stage
    Sim/States/*.luau           -- Idle, Run, Jump, WallSlide, Slide, Hook...
    Sim/Input.luau              -- buffers (10f), flick, cones
    Types.luau
    Net/Protocol.luau           -- remote names, encode/decode (buffer lib)
  Server/
    Match/MatchService.luau     -- mode rules, rounds, checkpoints, blastzone, results
    Match/Modes/{Race,Laps,Hazards,Fight,Collectors,Boss}.luau
    Items/ItemService.luau, Items/*.luau
    Stage/StageLoader.luau      -- reads tags, spawns elements
    Net/InputReceiver.luau
    Data/ProfileService.luau    -- DataStore (cosmetics, best times)
  Client/
    Controller/LocalPlayer.luau -- predict, reconcile
    Camera/GroupCamera.luau     -- zoom/smoothing rules (MECHANICS 11)
    UI/*.luau                   -- HUD, boost bar, countdown, results (roblox-dev:roblox-ui)
    Fx/*.luau                   -- trails, VFX, SFX
```

## Stage element tags (CollectionService)
`Solid, ThinPlatform, Wall, Ceiling(hookable), TrapDoor, TrapDoorSwitch, BreakableGlass, Checkpoint, ItemBox, BoostFiller, SuperBoostVolume, JumpPad, Spike, Saw, Laser, RocketLauncher, Blastzone, SpawnPoint, RespawnPoint, Finish, Treasure, SecretRoomTrigger`. Collision layers mirror the reference: Character, Stage, ThinPlatform, Wall, Ceiling, TrapDoor.

## Testing
Unit-test `Sim/Step` headless (TestEZ/Jest-lua): determinism (same inputs → same state), jump apex heights, wall-slide entry, hook pendulum energy, boost drain/fill rates (42/s, 200/s), blastzone timers (25f/115f), buffers (10f). See `roblox-dev:roblox-testing`.

## Performance
Few entities (≤ 8 players + items). Avoid per-frame allocations in `step`; use `table.create`, numeric vectors as separate numbers on hot paths, `Vector3` only at the render boundary. See `roblox-dev:roblox-performance`.
