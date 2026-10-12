# AGENT BRIEF — build an original Roblox speed-racing platformer from this spec

You are an agent asked to build a Roblox game whose **mechanics and feel** follow the reference game
(a 2D-plane, momentum-based, hook-and-slide racing platformer, 1-4+ players, 60 Hz). Read this file first.

## Hard rules (legal / platform)
1. **Mechanics are the spec; content is not.** Rebuild movement, rules, tuning, item *behaviours* and mode logic.
   Do **not** recreate the reference game's characters, character names, map layouts/level geometry, art, music, SFX, logos, UI art or title.
2. Create **original** characters, maps, art, audio, names and branding. Use Roblox-owned or self-made assets only.
3. The `docs/maps` / `docs/characters` files in this repo are *analysis*, useful for sizing and pacing (e.g. "a stage is ~N colliders over ~M units wide"). Never port their geometry or stats 1:1 into recognisable copies of the originals.
4. Follow Roblox's rules: server-authoritative state, validate all RemoteEvent input, no client trust (see `roblox-dev:roblox-security`).

## What to read, in order
1. `roblox/MECHANICS_SPEC.md` — movement, jump, slide, hook, boost, blastzone, camera, input. Numbers measured from the reference data.
2. `roblox/ARCHITECTURE.md` — Rojo project layout, custom character controller, fixed timestep, networking.
3. `roblox/MODES_AND_RULES.md` — race / laps / hazards / fight / collectors / boss / training rules and timers.
4. `roblox/ITEMS_AND_HAZARDS.md` — item and stage-element behaviours (original re-skins).
5. `roblox/MAP_AUTHORING.md` — how to design original stages; element palette; sizing targets.
6. `roblox/ROADMAP.md` — milestones with acceptance tests. Build in that order.
7. `docs/research/README.md` — web research (qualitative rules, Roblox implementation techniques with formulas, what is still unknown).
8. Raw numbers if needed: `docs/modes/SpeedRunnersSettingsData.md`, `docs/modes/GameplayInputSettingsData.md`, `docs/characters/README.md`, `docs/states/CharacterBase_states.md`.

## Conventions
- Language: Luau `--!strict`; Rojo + Wally layout; ModuleScripts with typed APIs; no globals.
- Use the installed `roblox-dev:*` skills (architecture, security, performance, datastores, testing, ui, luau-strict-typing) when available.
- Every tuning number lives in one config module (`Shared/Config/Tuning.luau`), never inline.
- Units: reference game units are metres-ish. **1 reference unit = 3 studs** (see scale note in MECHANICS_SPEC). Keep the factor in one constant.
- Frames: reference sim is 60 Hz; all "frames" in specs are 1/60 s. Run your own fixed 60 Hz sim step.

## Definition of done (v1)
A 4-player race on an original stage with: responsive run/jump/wall-slide/slide/hook, boost meter, checkpoints + respawn,
blastzone KO, 3 original items, finish + results screen, server-authoritative with client-side prediction, no exploitable remotes.
