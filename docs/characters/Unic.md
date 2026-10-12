# Character: Unic

- Costume prototypes: 9
- Overridden/own states (3): Run, Run Turn, Taunt
- Animation clip data files: 44: Unic AirJump, Unic AirTrip, Unic CrashLandEnter, Unic CrashLandExit, Unic CrashLandLoop, Unic FreezeRayInPlace, Unic FreezeRayWhileRunning, Unic GrabbedGoldenHookEnd, Unic GrabbedGoldenHookLoop, Unic GrabbedGoldenHookStart, Unic GrappleStartAir, Unic GrappleStartGround, Unic GrappleStartRun, Unic GrappleSwingDown, Unic GrappleSwingRelease, Unic GrappleSwingUp, Unic Idle, Unic IdleAlt, Unic JumpForward, Unic JumpForwardFall, Unic JumpInPlace, Unic JumpInPlaceFall, Unic Land, Unic MenuIdle, Unic MenuReadyIdle, Unic MenuReadyTransition, Unic RideDownSlopes, Unic RollLand, Unic Run Loop, Unic Run, Unic RunTurn, Unic SlideEnd, Unic SlideLoop, Unic SlideStart, Unic StartPose, Unic StartingPose, Unic Taunt, Unic Trip, Unic Tumble, Unic UseItem, Unic Victory, Unic VictoryBanner, Unic WallCling, Unic WallJump

## Physics Data: 13 differences vs CharacterBase

| field | CharacterBase | Unic |
|---|---|---|
| `Settings.AirAcceleration` | 8 | 16 |
| `Settings.AirSpeed` | 5.7 | 5 |
| `Settings.FallSpeed` | 9999 | 10 |
| `Settings.Gravity` | 32.5 | 32 |
| `Settings.GroundAcceleration` | 10 | 25 |
| `Settings.GroundFriction` | 15 | 24 |
| `Settings.HitStunFallSpeed` | 9999 | 10 |
| `Settings.HitStunGravity` | 31.25 | 32 |
| `Settings.KnockbackDecay` | 22.19 | 22 |
| `Settings.RunSpeed` | 12 | 8 |
| `Settings.Value` | 692597300688246924 | 1649793851958192828 |
| `Settings.WalkFastSpeed` | 10 | 6 |
| `Settings.WalkSlowSpeed` | 1.6 | 3 |

## Combat Data: 4 differences vs CharacterBase

| field | CharacterBase | Unic |
|---|---|---|
| `Settings.MaxKnockbackForFlinch` | 20 | 0 |
| `Settings.MaxKnockbackForFlop` | 10 | 0 |
| `Settings.Value` | 2982643529973749122 | 216442616359257128 |
| `Settings.Weight` | 100 | 0 |

## Game Entity Data: 11 differences vs CharacterBase

| field | CharacterBase | Unic |
|---|---|---|
| `Settings.AnimationsPoolData.Id.Value` | 4391565257411106557 | 179977529914381274 |
| `Settings.BakedJointsData.Id.Value` | 3141428852022592749 | 890007439048155573 |
| `Settings.CombatData.Id.Value` | 2982643529973749122 | 216442616359257128 |
| `Settings.EntityName.Value` | CharacterBase | Unic |
| `Settings.Id.Value` | 3081773775100452412 | 3177745993613197566 |
| `Settings.JumpSettings.Id.Value` | 2057508508100290526 | 1905947617718435884 |
| `Settings.MovesetLimiterData.Id.Value` | 1382520065875389847 | 2129051911726028121 |
| `Settings.PhysicsData.Id.Value` | 692597300688246924 | 1649793851958192828 |
| `Settings.RotationPivot.Y` | 1 | 0.5 |
| `Settings.StateMachineData.Id.Value` | 2686411458687942432 | 4122427521910512506 |
| `Settings.Value` | 252206280127534507 | 1134629947303348688 |

## Moveset Limiter Data: 1 differences vs CharacterBase

| field | CharacterBase | Unic |
|---|---|---|
| `Settings.Value` | 1382520065875389847 | 2129051911726028121 |

## State Machine Data: 6 differences vs CharacterBase

| field | CharacterBase | Unic |
|---|---|---|
| `Settings.Id.Value` | 3869718665952593495 | 1544653193112796495 |
| `Settings.Name.Notes` | Used for Burn VFX when hit by a fire attack data | None |
| `Settings.Name.Value` | 0 | None |
| `Settings.ParentStateMachine.Id.Value` | 0 | 2686411458687942432 |
| `Settings.Value` | 2686411458687942432 | 4122427521910512506 |
| `Settings.Variables` | None | [] |
