# MODES AND RULES

Common timing [M] (from the mode data): initial countdown timer 30f · respawn total length 4-6 s · min spacing between respawns 0.5-1 s · wait between rounds 2-3 s · wait before returning to menu 3-4 s · banner delay 1 s · on round win, **slow-motion x0.2** for the finish flourish.
Match flow: Lobby → Intro cards → Countdown banner → Round → Round-end message → (next round | Results) → Menu.

## Race (point race, 2-4+ players)
- Checkpoints active, blastzone active (see MECHANICS §9). First to the finish/furthest-ahead scores the round; blastzone KO'd players respawn at their checkpoint after ~4 s. `DistanceToFinish` is tracked per player for placement. Wrong-direction warning event; "near death" warning when close to being blastzoned.
- Camera follows the leader-weighted group; the shrinking blastzone forces the pack forward.
- Round score: first place gets the round point; match is first-to-N rounds (N configurable [T]).

## Laps Race
- Same as Race with `LapsToFinish = 3` [M]; per-lap events; lap/placement tracker; respawn 6 s.

## Hazards Race ("things fall from the sky")
- Blastzone + checkpoints + periodic hazard waves: start timer **6 s**, incoming warning **3 s**, **13 hazards** per wave, item spawn cooldown ~0.4 s [M]. Hazard types: fire, ice, laser, rocket (indicators shown before impact).

## Tournament
- Race rules plus **rocket barrage**: starts at 60 s, warning 5 s before [M]. Item auto-trigger stations.

## Timed Race / Time Trial
- Single-player lap time; best time saved per stage (DataStore). Ghost optional [T].

## Platform Fight (stocks/stamina)
- Blastzone active; knockout = lose a stock; combat components: damage, stocks, stamina, armor, block, tech, charge. Last standing wins. Boss variant uses **player stamina 6**, **60f intangibility after being hurt**, blastzone damage 1 [M].

## Collectors / Treasure
- Match time **240 s**; treasure spawns every **4 s** in spawn areas, **max 3 on the field** [M]; pick up and score; hit a carrier to flip/steal ("FlipScores").

## Escape Room (single-player timed puzzle course)
- Goal trigger ends the course; optional timer with completion action; secret room triggers reveal bonus (discovery event).

## Boss Fight (campaign)
- Arena with scripted boss patterns, health bar HUD for boss + player stamina, restart on defeat, dialogue intro. Build one *original* boss with 2-3 phases.

## Endless
- Procedurally chained "rooms" from a pool (flat room, platform room, pyramid, slope, pit, item room) with a start room; scroll/chase pressure; score = distance. Good first procedural mode.

## Training / Tutorials
- Free-play sandbox; mechanic tutorials (building speed, climbing walls, maintaining speed, switching directions) and item tutorials, each a short goal-trigger course with on-screen prompts. Build 4-6 original lessons.

## Match options to expose
Stage pick/random, layout A/B, items on/off, rounds-to-win, bots (NPCs: AI volumes guide a simple follower that jumps/hooks at tagged points).
