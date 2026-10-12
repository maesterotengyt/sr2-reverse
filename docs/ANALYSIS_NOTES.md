# SpeedRunners 2: King of Speed — reverse-engineering notes

Build analysed: v1.5.1.0 (Xbox/MS Store PC package), Unity 6000.0.67f1, IL2CPP x64, il2cpp metadata v31.
Source: the user's own install at `Content/`. Nothing in the install was modified (all work done on copies).
Not covered / not done: no DRM or licence bypass; native function bodies not decompiled (see "Next").

## Tools used
- Il2CppDumper v6.7.46 -> `raw/` (dump.cs, il2cpp.h, script.json, stringliteral.json, DummyDll/)
- AssetRipper 2.0.0 -> `assets_export/ExportedProject/` (full Unity project: scenes, prefabs, textures, meshes, audio, animations, QuantumDB)
- Custom scripts -> `code/`, `docs/`, `decoded_quantumdb/`

## Folder map
| Folder | What |
|---|---|
| `raw/dump.cs` | every type/field/method signature in the game (19,744 types) with RVA addresses |
| `raw/script.json` | RVA -> method name map, for labelling in Ghidra/IDA |
| `raw/DummyDll/` | 110 stub assemblies; open `Assembly-CSharp.dll` etc. in ILSpy/dnSpy |
| `code/<assembly>/<namespace>/<Type>_<idx>.cs` | dump split one-file-per-type for the 5 game-owned assemblies |
| `code/_type_index.tsv` | image / TypeDefIndex / namespace / kind / name for all types |
| `docs/quantum_code.md` | the deterministic simulation: all enums with values, 108 components, 20 systems, 30 assets, 101 events, fields + method RVAs |
| `docs/assembly_csharp_index.md` | Unity client side (UI, audio, camera, platform, etc.) |
| `docs/quantum_core_index.md`, `photon_deterministic_index.md` | engine layer |
| `decoded_quantumdb/` | all 3,094 gameplay data assets with fixed-point values converted to decimals |
| `assets_export/` | raw exported Unity project |

## Architecture
- Photon **Quantum** deterministic rollback netcode: gameplay lives in `quantum.code.dll` (ECS: components + systems), engine in `quantum.core.dll`, math in `PhotonDeterministic.dll`. Unity (`Assembly-CSharp.dll`) is the view/UI layer reading Quantum events.
- Sim config: 60 Hz, rollback window 60 frames, input redundancy 3, input delay 0-60 (ping-scaled), `ChecksumInterval` 0. Numbers are `FP` (Q16.16 fixed-point): decimal = RawValue / 65536.
- Systems (game): Init, Update, Match, Stage, Physics, Combat, StateMachine, CustomAnimator, InputBuffer, InitObjects, DestroyObjects. Engine: PhysicsSystem2D/3D, Culling, Navigation, EntityPrototype.
- Characters run a data-driven **state machine** (state assets + behaviours in `QuantumDB/.../States`). Per-character data: Physics, Jump, Combat, Moveset limiter, Game entity, animations (baked joints), attack pools.
- Backends/libs: Photon Realtime, Steamworks.NET, brainCloud, FMOD (audio), Spine, Cinemachine, Shapes, HBAO, Unity Localization, GDK (Xbox).

## Content inventory (from QuantumDB)
- Characters: Cosmonaut, Falcon, Frogman, Hothead, ManekiNeko, Moonraker, Salem, Skull, SpeedRunner, Starlight, Unic, Vamp (+ `CharacterBase` defaults)
- Bosses: FalconChickenTank, Mask, PoisonShip
- Stages: Casino, Endless (+ Frog), Forest, Genetics, ItemTest, Metro, Moon, Museum, Prototype, RedZone, SSRoyale, SuperSpeedBros, SwiftPeaks, AdvancedMechanicTutorial, BossWikiMask (+ MainMenu, Common in Unity scenes)
- Game modes (components/enums): Race, Laps race, Hazards race ("Sky Is Falling"), Platform fight (stocks/combat), Collectors/treasure, Escape room, Boss fight, Campaign race, Endless, Tournament, Training, mechanic/race tutorials
- Items: Crate/Triple Crate, FireBall, FreezeRay, GoldenHook, InviciDrill, LightningWatch, PlasmaBlaster, RemoteBomb, Rocket/Triple Rocket, Shockwave; hazards: Fire, Ice, Laser, Rocket
- Stage elements: JumpPad, Spike, Saw, Laser, TrapDoor(+Switch), BreakableGlass, Checkpoint, ItemBox, RocketLauncher, SuperBoostVolume, BoostFiller, Blastzone triggers, SecretRoom, Treasure, AI volumes

## Core movement/physics numbers (CharacterBase Physics Data; units/s, units/s^2)
Gravity 32.5 · FallSpeed 9999 (uncapped) · RunSpeed 12 · WalkFast 10 · WalkSlow 1.6 · AirSpeed 5.7 · AirAccel 8 · AirFriction 5 ·
GroundAccel 10 · GroundFriction 15 · Hit-stun gravity 31.25 · hit-stun ground friction 24 · KnockbackDecay 22.19 · Restitution 0.85 · MinMagnitudeForBounce 12 · MinWallNormal 0.9 · MinSlopeNormal 0.6.

## Global gameplay tuning (SpeedRunnersSettingsData)
Boost 0-100, depletion 42/s, fill 200/s · hook cooldown 15f · slide cooldown 30f · wall-slide cooldown 10f · reverse-grapple window 6f · caterpillar window 8f ·
rocket knockback 15.625 · default attack knockback 12.5 · blastzone KO: 25 frames (last player) / 115 frames (others) · camera zoom 1.0-1.35.
Input: jump/hook/item buffers 10f, flick buffer 7f, stick deadzone 0.2-0.9.

## Next (if wanted)
1. Per-character diffs vs CharacterBase (compare `decoded_quantumdb/Characters/*`).
2. Item/jump/combat tables written up as spreadsheets.
3. Native decompile: load `GameAssembly.dll` in Ghidra + `raw/script.json` (apply Il2CppDumper's `ghidra_with_struct.py` with `raw/il2cpp.h`) to read actual method bodies.
4. Convert extracted meshes/textures/audio for personal study only; do not redistribute.
