# ITEMS AND HAZARDS (behaviour spec — give them original names/art)

Item flow [M]: pick up from an **Item Box** → one equipped item (`EquipedItemID`, `ItemUses`) → use with the Use button (buffered 10f). **Use cooldown 30f after pickup**, 50f at round start. Some items auto-use when the item-power meter fills (`AutoUseItemOnFullCharge`). Using an item can be tap (instant) or hold (aim/charge) [`ItemButtonUseMode`]. Events fire on pickup/use/drop.

Behaviour classes (names in the reference are descriptive; rename them):
| Reference item | Behaviour to implement | Notes |
|---|---|---|
| Crate / Triple Crate | Drops an obstacle crate behind/ahead that blocks/knocks over racers; triple = 3 | slide invulnerability applies to bombs |
| Fire ball | Projectile that bounces/travels along ground, knockback on hit | gravity-affected |
| Freeze ray | Beam/shot that freezes a target for a duration (Freeze state, mashing frees) | `FreezeFrames` |
| Golden hook | Grabs the leader/target and pulls them back or pulls user forward | uses Grab component |
| Invincible drill | Short invulnerable drilling charge through hazards | `InviciDrillFrames` |
| Lightning-watch | Global slowdown/zap effect on opponents ahead of the user | start-animation state |
| Plasma blaster | Rapid projectile bullets | |
| Remote bomb | Placeable bomb detonated on re-press; knockback radius | slide = bomb invul |
| Rocket / Triple rocket | Homing/straight rocket; knockback **15.6 u/s** [M] | rocket launchers also exist as stage elements |
| Shockwave | Radial knockback burst around user | |
Combat result: knockback vector + decay (MECHANICS §10); hit-stun state; "Hurt/Tumble/Trip" states.

## Stage elements (behaviour)
- **Item Box**: respawning pickup. **Boost Filler**: refills boost at 200/s while overlapped. **Super Boost Volume**: forces super-speed while inside. **Jump Pad**: fixed launch impulse. **Spike / Saw / Laser**: instant hurt/KO or knockback; lasers toggle in a timed pattern. **Trap Door (+ Switch)**: floor that opens when a switch is hit (switch activation SFX/VFX). **Breakable Glass**: breaks at speed/when hit. **Rocket Launcher**: periodic projectile with warning. **Checkpoint**: sets respawn; tracks forward/backward crossing. **Blastzone trigger**: KO volume. **Secret room trigger**, **Treasure**, **Obstacle**, **Moving/Endless platforms**, **AI volumes** (bot hints), **Layout manager** (A/B layouts).
Sizes/pacing guidance in `MAP_AUTHORING.md`; raw per-item data (non-default fields) in `docs/items/*.md` for exact timings if needed.
