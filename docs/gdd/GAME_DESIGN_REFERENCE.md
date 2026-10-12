# Game design reference (derived from the build's code/data names)

Purpose: everything a developer needs *beyond mechanics* to scope and build a game of this type. Names are descriptive identifiers from the build; rename for any original product.

## 1. Product shape
- 2.5D side-view racing platformer; 1-4 local/online players + bots (difficulties: Easy / Normal / Hard / Unfair — from achievements), team support (`Teams` component), CPU difficulty menu in character select.
- Platforms: Xbox/PC (GDK), Steam (Steamworks.NET), Photon Quantum netcode (rollback), brainCloud backend (accounts, friends, groups, lobbies, tournaments, matchmaking, ranked/ratings, virtual currency/items, achievements, leaderboards, chat, cloud files/user data).
- Languages (9): English, French, German, Spanish, Portuguese (Brazil), Russian, Japanese, Korean, Chinese (Simplified). Unity Localization tables: `MenuStrings`, `Dialogues` (+ others); keys per table, one value per locale.

## 2. Screen / flow map (UI screen classes)
Boot: LogoParade → Title → EULA popup → MainMenuHub.
Main menu "worlds" (each a 3D menu scene with camera moves): MainMenuHub, LocalHub, OnlineHub, Extras, Settings, Practice, Credits.
- **Local**: LevelSelect (stage + layout A/B + mode), CharacterSelect (Join → Runner → Costume → Edit/Controls → CPU difficulty → Ready), PlaygroundRules (rounds, items), MatchLoading → Match HUD → Result/Winner screens.
- **Online**: OnlineModeSelect, LobbyList, CreateLobby, JoinPrivateLobby, LobbyMenu, Tournaments list / Join / Tournament bracket / Finding / Match result / Bracket winner, Ranked (`PLAY_RANKED`), Quickplay.
- **Campaign**: CampaignMenu, chapters (race / laps / hazards / escape room / boss fights / endless boss), dialogue + cutscene HUDs, chapter-completed + best-time saving.
- **Practice**: Training (free play), Mechanic tutorials (basic + advanced), Item tutorials, Race tutorial, Item glossary.
- **Profile/meta**: PlayerProfile, Badges, LevelUp, RankUp, RewardUnlocked popups, Customization (costumes: 9 per character incl. a template), Character data panel, Achievements.
- **Settings**: Game, Audio, Graphics, Online, Input profiles/controls, Feedback.
- Popups: Alert, Confirmation, Loading, Custom exit, UIPopup base. Pause menu in match.
- In-match HUD: character HUD (health/boost bar, item slot + item bubble, name indicators, off-screen indicators), match HUD per mode (Race, Laps, Hazards, Collectors, Boss HP, Tutorial goals), countdown banner, intro cards, round-end banners, announcer VO.

## 3. Progression / meta [names only]
Player level + rank (LevelUp/RankUp popups), rewards (RewardUnlocked) → cosmetics (costumes), badges, virtual currency/items via backend, achievements (15): First Race, Quickplay, Play Ranked, Win Online Race, Airborne, Basic Tutorial, Advanced Tutorials, Bots Easy/Normal/Hard/Unfair, three stage-secret achievements (secret rooms), Completionist. Tournaments: bracket, claim reward.

## 4. Audio (FMOD) event categories
Music: MainMenuTheme, TournamentBracket, per-stage `StageMusic` (+ `Part2` event, `BossMusic`, `TutorialMusic`, `RedZoneMusic`). SFX: UI (Back, BackHold, Select, NavigationB, Error, Connecting, Equip, CostumeChange, CharSelectStart, PlayerReady, TimerCountdown, Lap, LapFinal, MatchFinish, BracketMatchFinish, CharacterKO, RewardAll, MenuCam1, Dialogue_Next/_SFX), CharactersSFX (per-character + SuperSpeed), Items (e.g. hook hit, tongue hit), StageElements (trap-door activation, sudden-death activate), Ambience, Dialogue/VO (character VO events + announcer VO events: `GameplayCharacterVOEvent`, `GameplayAnnouncerVOEvent`). Footsteps, slide, wall-slide loops with start/stop events.

## 5. Gameplay systems checklist
Run/jump/air-jump/wall-slide/wall-jump/ledge/slide/ride-down/roll-land/back-flip • grapple hook (+reverse grapple, caterpillar tech) • boost/super-speed • items (10 + hazards) • knockback/hit-stun/tumble/trip/freeze • blastzone (shrinking) & respawn • checkpoints/laps/placement/wrong-way • sudden death • stage elements (see roblox/ITEMS_AND_HAZARDS.md) • accolade popups • NPC/bot AI with AI volumes • bosses (3 in build; boss HUD, phases, tongue/projectile attacks) • secret rooms/treasure • endless room chaining • stage layouts A/B • camera zoom/follow • slow-mo on round win • frame-by-frame debug.

## 6. Technical stack (for reference)
Unity 6 (URP, HBAO, post-processing, Shapes, Spine for 2D, Cinemachine, Splines, Timeline, VFX/particle effects, UIEffect/UIParticle, soft masks, TextMeshPro, Addressables), FMOD audio, Photon Quantum 2 (deterministic ECS, 60 Hz, rollback window 60, input delay 0-60 by ping), Steamworks, brainCloud, Newtonsoft JSON.

## 7. Content inventory (counts)
12 characters × 9 costumes · 3 bosses · ~16 stage folders (+ 19-lesson tutorial stage) × layouts A/B · 10 pickup items + 4 hazard types · ~30 stage-element types · ~30 game-mode assets · 9 languages.
Per-stage / per-character / per-mode detail: `docs/maps`, `docs/characters`, `docs/modes`, `docs/items`, `docs/states`, and full decoded gameplay data in `data/decoded_quantumdb/`.
