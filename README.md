# sr2-reverse — SpeedRunners 2: King of Speed (v1.5.1.0)

Personal-study documentation of the game's structure, generated from the owner's own install.
No game binaries, assets or raw dumps are stored here (see `.gitignore`); only derived notes + the scripts that regenerate them.

## Layout
| Path | Contents |
|---|---|
| `docs/ANALYSIS_NOTES.md` | architecture, tooling, key numbers (start here) |
| `docs/maps/` | per-stage breakdown: layouts, scenes, object/prefab/script census, static-collision stats (19 stage folders) |
| `docs/characters/` | 12 characters, each diffed against `CharacterBase` (physics, combat, entity, moveset) |
| `docs/states/` | CharacterBase state machine: states, default behaviours, event groups |
| `docs/items/` | pickup/hazard usage data (non-default fields) |
| `docs/modes/` | every game mode + global tuning (settings, input, simulation, deterministic config) |
| `docs/code/` | Quantum components/systems/assets/events/enums, Unity client index, engine indexes, full type index |
| `roblox/` | **Agent build spec for an original Roblox game with the same mechanics/feel**: start at `roblox/AGENT_BRIEF.md` |
| `tools/` | scripts that regenerate all docs |

## Regenerating (needs the raw data, kept locally)
1. Il2CppDumper on `GameAssembly.dll` + `global-metadata.dat` -> `raw/`
2. AssetRipper on the `*_Data` folder -> `assets_export/`
3. `python -I tools/split_dump.py` -> `code/`;  `analyze.py` -> `docs/code`;  `decode_fp.py` -> `decoded_quantumdb/`
4. `python -I tools/gen_maps.py`, `tools/gen_game.py` -> maps/characters/states/items/modes
(Script paths are hard-coded to this machine; edit the constants at the top.)
