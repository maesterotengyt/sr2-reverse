# ROADMAP (build in order; each milestone has acceptance tests)

| # | Milestone | Acceptance |
|---|---|---|
| 0 | Rojo project, Tuning.luau, strict types, headless test harness | `step()` runs 600 frames deterministically in tests |
| 1 | Flat-ground controller: run/idle/turn using the CORRECTION table in MECHANICS_SPEC (cap 19.75, accel 8.8125, ground decel 18.75, brake 37.5) | accelerates to the run cap and brakes per table |
| 2 | Jump (short/full), air control, air jump ×1, coyote/jump buffer 10f | apex heights match §4 ±5%; buffered jump works |
| 3 | Walls: wall-slide, wall-jump, ledge climb | grabs only walls with normal ≥ 0.98; 10f re-grab cooldown |
| 4 | Slide + slopes (ride-down), momentum over cap decays by friction | slide cooldown 30f; downhill gains speed |
| 5 | **Hook**: launch @45°, 93.75 u/s extension, anchor on Ceiling layer, swing, release launch; cooldown 15f | pendulum conserves energy ±3%; release gives tangential velocity |
| 6 | Boost meter (fill 200/s, drain 42/s), filler zones, HUD | numbers verified in tests |
| 7 | Camera (group zoom 1.0-1.35, smoothing 6, offset) | no jitter; zoom reacts to spread |
| 8 | Networking: input frames → server sim, snapshots, client prediction/reconcile, interpolation | stable at 150 ms ping; exploit tests (speed hacks rejected) |
| 9 | Stage elements + one original race stage, checkpoints, blastzone shrink/KO 25f/115f, respawn 4 s | full race playable by 4 players |
| 10 | Match flow: lobby, countdown, rounds, results, scoring | 3-round match completes |
| 11 | 3 original items (projectile, trap, freeze-style) + item boxes + knockback/hit-stun | knockback 12.5 default, decay 22 |
| 12 | Modes: Laps (3 laps), Hazards waves (13 per wave), Collectors (240 s), Training | each mode has a rules test |
| 13 | Polish: VFX/SFX (original), accolades, bots, cosmetics, DataStore (best times) | profile save/load safe (`roblox-dev:roblox-datastores`) |
| 14 | Mobile/gamepad input, perf pass, security review (`roblox-dev:roblox-reviewer`) | 60 fps on mid phone; no unvalidated remotes |

## Known gaps in the reference analysis (agent must tune by playtest)
- Exact jump-curve shape, hook max rope length, swing pump force, item numeric details beyond `docs/items/*` (speed caps/accelerations/boost/slide numbers are now KNOWN: see MECHANICS_SPEC correction table). The reference stores them in behaviour graphs not fully decoded here; the values given in MECHANICS_SPEC marked [T] are starting points.
- Native logic (exact integration order, collision resolution) was not decompiled; reproduce the *feel*, not bit-exactness.

## Research gaps (cannot be closed from the web; measure or playtest)
Jump apex/duration, hook max length and pump force, boost multiplier, slide friction, item numerics, round scoring and sudden-death specifics. Options: record/measure gameplay frame-by-frame, or tune in-engine against the qualitative rules in docs/research/README.md.
