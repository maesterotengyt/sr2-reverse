# CharacterBase state machine

Each folder is a state. A state has default behaviours (run every frame of the state) and inherited groups (event-driven condition -> behaviour lists).

## Air Jump
- state asset: `Air Jump State.txt` (name: Air Jump)
  - default behaviours (14): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `Go To Idle AirChangeState Behaviour 1`, `SpeedRunnerMovement Behaviour`, `SpeedRunnersJump Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `PlayAnimation Behaviour`, `Detect LandDetectLand Behaviour`, `PlaySFX Behaviour`, `PlayVFX Behaviour`, `NotifyGeneralCharacterVOEvent Behaviour`
- behaviour files (14): Detect LandDetectLand Behaviour, Go To Idle AirChangeState Behaviour 1, InputCheck Behaviour, ItemUseCheck Behaviour, NotifyGeneralCharacterVOEvent Behaviour, PlayAnimation Behaviour, PlaySFX Behaviour, PlayVFX Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, SpeedRunnersJump Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Back Flip
- state asset: `Back Flip State.txt` (name: Back Flip)
  - default behaviours (10): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `Detect LandDetectLand Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `SpeedRunnerMovement Behaviour`, `PlayAnimation Behaviour`, `Go To Idle AirChangeState Behaviour`
- behaviour files (10): Detect LandDetectLand Behaviour, Go To Idle AirChangeState Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Down
- state asset: `Down State.txt` (name: Down)
  - default behaviours (11): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `UseGroundRotation Behaviour`, `Stunned Behaviour 1`, `UseGroundRotation Behaviour 1`, `PlayAnimation Behaviour 2`, `Go To Idle_ChangeState Behaviour`, `PlayAnimation Behaviour`, `PlayVFX Behaviour`, `PlayVFX Behaviour 1`, `StopVFX Behaviour`
- behaviour files (11): Go To Idle_ChangeState Behaviour, PlayAnimation Behaviour 2, PlayAnimation Behaviour, PlayVFX Behaviour 1, PlayVFX Behaviour, SetupHurtBoxes Behaviour, StopVFX Behaviour, Stunned Behaviour 1, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour 1, UseGroundRotation Behaviour

## Entrance
- state asset: `Entrance State.txt` (name: Entrance)
  - default behaviours (9): `UpdateEnvironmentCollisionBox Behaviour`, `SpeedRunnersEntrance Behaviour`, `PlayAnimation Behaviour`, `UseGroundRotation Behaviour`, `Reset States_AdvancedOperation Behaviour`, `Reset VelocityAdvancedOperation Behaviour`, `Reset VelocityAdvancedOperation Behaviour 1`, `StopTint Behaviour`, `StopAllVFX Behaviour`
- behaviour files (9): PlayAnimation Behaviour, Reset States_AdvancedOperation Behaviour, Reset VelocityAdvancedOperation Behaviour 1, Reset VelocityAdvancedOperation Behaviour, SpeedRunnersEntrance Behaviour, StopAllVFX Behaviour, StopTint Behaviour, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour

## Freeze
- state asset: `Freeze State.txt` (name: Freeze)
  - default behaviours (20): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `AdvancedOperation Behaviour`, `PlayAnimation Behaviour`, `PlayVFX Behaviour 2`, `PlaySFX Behaviour 1`, `Freeze Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `Reduce Freeze Frames_AdvancedOperation Behaviour`, `Button Mash Check_ExecuteGroup Behaviour`, `StartShake Behaviour`, `PlaySFX Behaviour`, `PlayVFX Behaviour`, `PlayVFX Behaviour 1`, `Stop Ice_StopVFX Behaviour`, `PlayVFX Behaviour 3`, `Stop IceStopVFX Behaviour`, `NotifyGoalID Behaviour`, `Go To Idle_ChangeState Behaviour`, `Stop SlideStopSFX Behaviour`
- behaviour files (20): AdvancedOperation Behaviour, Button Mash Check_ExecuteGroup Behaviour, Freeze Behaviour, Go To Idle_ChangeState Behaviour, NotifyGoalID Behaviour, PlayAnimation Behaviour, PlaySFX Behaviour 1, PlaySFX Behaviour, PlayVFX Behaviour 1, PlayVFX Behaviour 2, PlayVFX Behaviour 3, PlayVFX Behaviour, Reduce Freeze Frames_AdvancedOperation Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, StartShake Behaviour, Stop IceStopVFX Behaviour, Stop Ice_StopVFX Behaviour, Stop SlideStopSFX Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Hook Launch
- state asset: `Hook Launch State.txt` (name: Hook Launch)
  - default behaviours (30): `Initial Facing Direction_AdvancedOperation Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SFX Hook Miss_PlaySFX Behaviour`, `PlayVFX Behaviour 2`, `Go To Idle AirChangeState Behaviour`, `SetupHurtBoxes Behaviour`, `Decrement Air Jump Uses_AdvancedOperation Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `HandleHookLaunchAnimations Behaviour`, `PlaySFX Behaviour`, `PlayVFX Behaviour 1`, `Air Jump_SpeedRunnersJump Behaviour`, `Ground Jump_SpeedRunnersJump Behaviour`, `SetRunAnimationSpeed_SetAnimationSpeed Behaviour`, `HookLaunch Behaviour`, `SpeedRunnerMovement Behaviour`, `Grounded InputCheck Behaviour`, `SFX Hook Hit_PlaySFX Behaviour`, `PlayVFX Behaviour`, `Go To Swing_ChangeState Behaviour`, `Check For Hook Cancel_ExecuteGroup Behaviour`, `Go To Idle Air_ChangeState Behaviour`, `Go To Idle_ChangeState Behaviour`, `Go To Run_ChangeState Behaviour`, `Go To IdleChangeState Behaviour`, `Go To RunChangeState Behaviour`, `PlayVFX Behaviour 3`, `ItemUseCheck Behaviour`, `FootstepSFX Behaviour`
- behaviour files (30): Air Jump_SpeedRunnersJump Behaviour, Check For Hook Cancel_ExecuteGroup Behaviour, Decrement Air Jump Uses_AdvancedOperation Behaviour, FootstepSFX Behaviour, Go To Idle AirChangeState Behaviour, Go To Idle Air_ChangeState Behaviour, Go To IdleChangeState Behaviour, Go To Idle_ChangeState Behaviour, Go To RunChangeState Behaviour, Go To Run_ChangeState Behaviour, Go To Swing_ChangeState Behaviour, Ground Jump_SpeedRunnersJump Behaviour, Grounded InputCheck Behaviour, HandleHookLaunchAnimations Behaviour, HookLaunch Behaviour, Initial Facing Direction_AdvancedOperation Behaviour, ItemUseCheck Behaviour, PlaySFX Behaviour, PlayVFX Behaviour 1, PlayVFX Behaviour 2, PlayVFX Behaviour 3, PlayVFX Behaviour, ResetVelocityOnWallDetection Behaviour, SFX Hook Hit_PlaySFX Behaviour, SFX Hook Miss_PlaySFX Behaviour, SetRunAnimationSpeed_SetAnimationSpeed Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Hook Swing
- state asset: `Hook Swing State.txt` (name: Hook Swing)
  - default behaviours (21): `Disable Physics_AdvancedOperation Behaviour`, `ResetMovesetLimiters Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `Check Wall Cancel_ExecuteGroup Behaviour`, `SpeedRunnerMovement Behaviour`, `ItemUseCheck Behaviour`, `HookSwing Behaviour`, `Go To Back Flip_ChangeState Behaviour`, `Go To Idle AirChangeState Behaviour`, `Go To IdleChangeState Behaviour`, `Go To RunChangeState Behaviour`, `Go To RunChangeState Behaviour 2`, `Play1DBlendspace Behaviour`, `Left Wall Check_ExecuteGroup Behaviour`, `Right Wall Check_ExecuteGroup Behaviour`, `On Slope Up Check_ExecuteGroup Behaviour`, `Touch Floor Check_ExecuteGroup Behaviour`, `Simple Hurt_SimpleHurt Behaviour`, `Reflect_AdvancedOperation Behaviour`
- behaviour files (21): Check Wall Cancel_ExecuteGroup Behaviour, Disable Physics_AdvancedOperation Behaviour, Go To Back Flip_ChangeState Behaviour, Go To Idle AirChangeState Behaviour, Go To IdleChangeState Behaviour, Go To RunChangeState Behaviour 2, Go To RunChangeState Behaviour, HookSwing Behaviour, ItemUseCheck Behaviour, Left Wall Check_ExecuteGroup Behaviour, On Slope Up Check_ExecuteGroup Behaviour, Play1DBlendspace Behaviour, Reflect_AdvancedOperation Behaviour, ResetMovesetLimiters Behaviour, Right Wall Check_ExecuteGroup Behaviour, SetupHurtBoxes Behaviour, Simple Hurt_SimpleHurt Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, Touch Floor Check_ExecuteGroup Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Hurt
- state asset: `Hurt State.txt` (name: Hurt)
  - default behaviours (26): `StopVFX Behaviour`, `ExecuteUnfreeze_ExecuteGroup Behaviour`, `ExecuteUnfreezeExecuteGroup Behaviour`, `ExecuteImpulse_ExecuteGroup Behaviour`, `ExecuteImpulseExecuteGroup Behaviour`, `ExecuteImpulseExecuteGroup Behaviour 1`, `Execute tint_ExecuteGroup Behaviour`, `ExecuteGotoIdle_ExecuteGroup Behaviour`, `ExecuteGroupConditionally Behaviour`, `PlayVFX Behaviour`, `Go To Trip_ChangeState Behaviour`, `PlayVFX Behaviour 1`, `Go To Tumble_ChangeState Behaviour`, `Go To Freeze_ChangeState Behaviour`, `Hurt Behaviour 1`, `PlayVFX Behaviour 2`, `PlaySFX Behaviour`, `Add HitLag_AdvancedOperation Behaviour`, `PlayTint Behaviour`, `Impulse Up_AdvancedOperation Behaviour`, `StopVFX Behaviour 1`, `PlayVFX Behaviour 3`, `Go To Air Jump_ChangeState Behaviour`, `Apply Impulse_AdvancedOperation Behaviour`, `Stop Slide_StopSFX Behaviour`, `Go to Idle_ChangeState Behaviour`
- behaviour files (26): Add HitLag_AdvancedOperation Behaviour, Apply Impulse_AdvancedOperation Behaviour, Execute tint_ExecuteGroup Behaviour, ExecuteGotoIdle_ExecuteGroup Behaviour, ExecuteGroupConditionally Behaviour, ExecuteImpulseExecuteGroup Behaviour 1, ExecuteImpulseExecuteGroup Behaviour, ExecuteImpulse_ExecuteGroup Behaviour, ExecuteUnfreezeExecuteGroup Behaviour, ExecuteUnfreeze_ExecuteGroup Behaviour, Go To Air Jump_ChangeState Behaviour, Go To Freeze_ChangeState Behaviour, Go To Trip_ChangeState Behaviour, Go To Tumble_ChangeState Behaviour, Go to Idle_ChangeState Behaviour, Hurt Behaviour 1, Impulse Up_AdvancedOperation Behaviour, PlaySFX Behaviour, PlayTint Behaviour, PlayVFX Behaviour 1, PlayVFX Behaviour 2, PlayVFX Behaviour 3, PlayVFX Behaviour, Stop Slide_StopSFX Behaviour, StopVFX Behaviour 1, StopVFX Behaviour

## Idle
- state asset: `Idle State.txt` (name: Idle)
  - default behaviours (15): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `DetectIdleAir Behaviour`, `PlayAnimation Behaviour`, `UseGroundRotation Behaviour`, `SpeedRunnerMovement Behaviour`, `Idle Behaviour`, `Go To Taunt_ChangeState Behaviour`, `Check Idle Alt_ExecuteGroup Behaviour`, `Go To Idle Alt_ChangeState Behaviour`, `Go To Place Item_ChangeState Behaviour`, `Item Use Animation WeightSetAnimationWeight Behaviour`, `Reset Item Active Animation_PlayAnimation Behaviour`
- behaviour files (15): Check Idle Alt_ExecuteGroup Behaviour, DetectIdleAir Behaviour, Go To Idle Alt_ChangeState Behaviour, Go To Place Item_ChangeState Behaviour, Go To Taunt_ChangeState Behaviour, Idle Behaviour, InputCheck Behaviour, Item Use Animation WeightSetAnimationWeight Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, Reset Item Active Animation_PlayAnimation Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour

## Idle Air
- state asset: `Idle Air State.txt` (name: Idle Air)
  - default behaviours (17): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `Detect Land_DetectLand Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `SpeedRunnerMovement Behaviour`, `CheckSlopeSurfSetup Behaviour`, `Cancel Jump_AdvancedOperation Behaviour`, `Reset Idle Air Values_AdvancedOperation Behaviour`, `Check Forced Jump_AdvancedOperation Behaviour`, `Forward Jump Animation_PlayAnimation Behaviour`, `Jump Forward Fall Animation_PlayAnimation Behaviour 1`, `Play Idle Air Blendspace_Play1DBlendspace Behaviour`, `Check Roll Conditions_AdvancedOperation Behaviour`, `Check Not Roll Conditions_AdvancedOperation Behaviour`
- behaviour files (17): Cancel Jump_AdvancedOperation Behaviour, Check Forced Jump_AdvancedOperation Behaviour, Check Not Roll Conditions_AdvancedOperation Behaviour, Check Roll Conditions_AdvancedOperation Behaviour, CheckSlopeSurfSetup Behaviour, Detect Land_DetectLand Behaviour, Forward Jump Animation_PlayAnimation Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, Jump Forward Fall Animation_PlayAnimation Behaviour 1, Play Idle Air Blendspace_Play1DBlendspace Behaviour, Reset Idle Air Values_AdvancedOperation Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Idle Alt
- state asset: `Idle Alt State.txt` (name: Idle Alt)
  - default behaviours (17): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `DetectIdleAir Behaviour`, `PlayAnimation Behaviour`, `UseGroundRotation Behaviour`, `SpeedRunnerMovement Behaviour`, `Idle Behaviour`, `Go To Taunt_ChangeState Behaviour`, `Check Idle AltExecuteGroup Behaviour`, `Go To Idle Alt_ChangeState Behaviour`, `Go To Place Item_ChangeState Behaviour`, `Item Use Animation WeightSetAnimationWeight Behaviour`, `Reset Item Active Animation_PlayAnimation Behaviour`, `Go To Idle_ChangeState Behaviour`, `NotifyGeneralCharacterVOEvent Behaviour`
- behaviour files (4): Check Idle AltExecuteGroup Behaviour, Go To Idle_ChangeState Behaviour, NotifyGeneralCharacterVOEvent Behaviour, PlayAnimation Behaviour

## Jump
- state asset: `Jump State.txt` (name: Jump)
  - default behaviours (16): `StopVFX Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `Go To Idle AirChangeState Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `SpeedRunnerMovement Behaviour`, `SpeedRunnersJump Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `Detect LandDetectLand Behaviour`, `Jump Forward Animation_PlayAnimation Behaviour`, `Jump In Place Animation_PlayAnimation Behaviour`, `PlaySFX Behaviour`, `PlayVFX Behaviour`, `NotifyGeneralCharacterVOEvent Behaviour`
- behaviour files (16): Detect LandDetectLand Behaviour, Go To Idle AirChangeState Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, Jump Forward Animation_PlayAnimation Behaviour, Jump In Place Animation_PlayAnimation Behaviour, NotifyGeneralCharacterVOEvent Behaviour, PlaySFX Behaviour, PlayVFX Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, SpeedRunnersJump Behaviour, StopVFX Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Knocked Out
- state asset: `Knocked Out State.txt` (name: Knocked Out)
  - default behaviours (5): `AdvancedOperation Behaviour`, `PlayCameraShake Behaviour`, `KnockedOut Behaviour`, `SpeedRunnersKnockedOut Behaviour`, `Stop SlideStopSFX Behaviour`
- behaviour files (5): AdvancedOperation Behaviour, KnockedOut Behaviour, PlayCameraShake Behaviour, SpeedRunnersKnockedOut Behaviour, Stop SlideStopSFX Behaviour

## Land
- state asset: `Land State.txt` (name: Land)
  - default behaviours (13): `Go To Roll Land_ChangeState Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `ResetMovesetLimiters Behaviour`, `AdvancedOperation Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `PlayVFX Behaviour`, `PlayAnimation Behaviour`, `SpeedRunnerMovement Behaviour`, `Go To IdleChangeState Behaviour`, `Go To Run_ChangeState Behaviour`, `Idle Behaviour`, `PlaySFX Behaviour`
- behaviour files (13): AdvancedOperation Behaviour, Go To IdleChangeState Behaviour, Go To Roll Land_ChangeState Behaviour, Go To Run_ChangeState Behaviour, Idle Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, PlaySFX Behaviour, PlayVFX Behaviour, ResetMovesetLimiters Behaviour, SpeedRunnerMovement Behaviour, UpdateEnvironmentCollisionBox Behaviour

## On Enter Blastzone
- state asset: `On Enter Blastzone State.txt` (name: On Enter Blastzone)
  - default behaviours (1): `KnockOut Behaviour`
- behaviour files (1): KnockOut Behaviour

## Place Item
- state asset: `Place Item State.txt` (name: Place Item)
  - default behaviours (10): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `InputCheck Behaviour`, `DetectIdleAir Behaviour`, `UseGroundRotation Behaviour`, `SpeedRunnerMovement Behaviour`, `Idle Behaviour`, `PlayAnimation Behaviour`, `Go To Idle_ChangeState Behaviour`, `Execute Fireball Used_ExecuteGroup Behaviour`
- behaviour files (10): DetectIdleAir Behaviour, Execute Fireball Used_ExecuteGroup Behaviour, Go To Idle_ChangeState Behaviour, Idle Behaviour, InputCheck Behaviour, PlayAnimation Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour

## Pulled By Hook
- state asset: `Pulled By Hook State.txt` (name: Pulled By Hook)
  - default behaviours (8): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `SetupInvincibility Behaviour`, `AdvancedOperation Behaviour`, `Go To Pulled By Hook End_ChangeState Behaviour`, `PlayVFX Behaviour`, `PlayAnimation Behaviour`, `Stop SlideStopSFX Behaviour`
- behaviour files (8): AdvancedOperation Behaviour, Go To Pulled By Hook End_ChangeState Behaviour, PlayAnimation Behaviour, PlayVFX Behaviour, SetupHurtBoxes Behaviour, SetupInvincibility Behaviour, Stop SlideStopSFX Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Pulled By Hook End
- state asset: `Pulled By Hook End State.txt` (name: Pulled By Hook End)
  - default behaviours (14): `UpdateEnvironmentCollisionBox Behaviour`, `StopVFX Behaviour`, `SetupHurtBoxes Behaviour`, `Detect LandDetectLand Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `SpeedRunnerMovement Behaviour`, `Reset Idle Air ValuesAdvancedOperation Behaviour`, `Play Animation_PlayAnimation Behaviour`, `Check Roll ConditionsAdvancedOperation Behaviour`, `Check Not Roll ConditionsAdvancedOperation Behaviour`, `Go To Idle Air_ChangeState Behaviour`
- behaviour files (14): Check Not Roll ConditionsAdvancedOperation Behaviour, Check Roll ConditionsAdvancedOperation Behaviour, Detect LandDetectLand Behaviour, Go To Idle Air_ChangeState Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, Play Animation_PlayAnimation Behaviour, Reset Idle Air ValuesAdvancedOperation Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, StopVFX Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Respawn
- state asset: `Respawn State.txt` (name: Respawn)
  - default behaviours (3): `AdvancedOperation Behaviour`, `Respawn Behaviour`, `Go To Entrance_ChangeState Behaviour`
- behaviour files (3): AdvancedOperation Behaviour, Go To Entrance_ChangeState Behaviour, Respawn Behaviour

## Ridedown Slopes
- state asset: `Ridedown Slopes State.txt` (name: Ridedown Slopes)
  - default behaviours (12): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `PlayAnimation Behaviour`, `Go To Idle_ChangeState Behaviour`, `Go to Idle Air_ChangeState Behaviour`, `SpeedRunnerMovement Behaviour`, `UseGroundRotation Behaviour`, `Check Ride End_ExecuteGroup Behaviour`
- behaviour files (12): Check Ride End_ExecuteGroup Behaviour, Go To Idle_ChangeState Behaviour, Go to Idle Air_ChangeState Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour

## Roll Land
- state asset: `Roll Land State.txt` (name: Roll Land)
  - default behaviours (14): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `ResetMovesetLimiters Behaviour`, `AdvancedOperation Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `Go To Run_ChangeState Behaviour 1`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `SpeedRunnerMovement Behaviour`, `PlayAnimation Behaviour`, `Go To Idle Air_ChangeState Behaviour`, `PlaySFX Behaviour`, `PlayVFX Behaviour 1`
- behaviour files (14): AdvancedOperation Behaviour, Go To Idle Air_ChangeState Behaviour, Go To Run_ChangeState Behaviour 1, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, PlaySFX Behaviour, PlayVFX Behaviour 1, ResetMovesetLimiters Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Run
- state asset: `Run State.txt` (name: Run)
  - default behaviours (16): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `DetectIdleAir Behaviour`, `Initial Impulse_AdvancedOperation Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `PlayAnimation Behaviour`, `UseGroundRotation Behaviour`, `SetAnimationSpeed Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `SpeedRunnerMovement Behaviour 1`, `Run Behaviour`, `Go To Ride Down Slope_ChangeState Behaviour`, `Item Use Animation Weight_SetAnimationWeight Behaviour`, `FootstepSFX Behaviour`
- behaviour files (16): DetectIdleAir Behaviour, FootstepSFX Behaviour, Go To Ride Down Slope_ChangeState Behaviour, Initial Impulse_AdvancedOperation Behaviour, InputCheck Behaviour, Item Use Animation Weight_SetAnimationWeight Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, ResetVelocityOnWallDetection Behaviour, Run Behaviour, SetAnimationSpeed Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour 1, SpeedRunnersDetectWallSlide Behaviour, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour

## Run Turn
- state asset: `Run Turn State.txt` (name: Run Turn)
  - default behaviours (14): `UpdateEnvironmentCollisionBox Behaviour`, `ChangeFacingDirection_AdvancedOperation Behaviour`, `SetupHurtBoxes Behaviour`, `DetectIdleAir Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour 1`, `PlayAnimation Behaviour`, `UseGroundRotation Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `SpeedRunnerMovement Behaviour`, `RunTurn Behaviour`, `PlaySFX Behaviour`, `PlayVFX Behaviour 1`
- behaviour files (14): ChangeFacingDirection_AdvancedOperation Behaviour, DetectIdleAir Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, PlaySFX Behaviour, PlayVFX Behaviour 1, ResetVelocityOnWallDetection Behaviour 1, RunTurn Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour

## Slide
- state asset: `Slide State.txt` (name: Slide)
  - default behaviours (29): `Bomb Invul_AdvancedOperation Behaviour`, `Bomb Invul Off_AdvancedOperation Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `SetupHitBoxes Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour`, `UseGroundRotation Behaviour`, `SpeedRunnerMovement Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `Slide Behaviour`, `Reset Bomb Invul_AdvancedOperation Behaviour`, `StopSlideSound_StopSFX Behaviour`, `AdvancedOperation Behaviour 1`, `Go To Jump_ChangeState Behaviour`, `PlaySFX Behaviour 1`, `PlayVFX Behaviour 1`, `PlayAnimation Behaviour 1`, `PlayAnimation Behaviour`, `PlaySFX Behaviour`, `PlaySFX Behaviour 2`, `PlayVFX Behaviour`, `StopSlideSoundStopSFX Behaviour`, `StopVFX Behaviour`, `PlaySFX Slide Stop_PlaySFX Behaviour`, `StopTint Behaviour`, `PlaySFX Behaviour 3`, `ResetMovesetLimiters Behaviour`
- behaviour files (29): AdvancedOperation Behaviour 1, Bomb Invul Off_AdvancedOperation Behaviour, Bomb Invul_AdvancedOperation Behaviour, Go To Jump_ChangeState Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour 1, PlayAnimation Behaviour, PlaySFX Behaviour 1, PlaySFX Behaviour 2, PlaySFX Behaviour 3, PlaySFX Behaviour, PlaySFX Slide Stop_PlaySFX Behaviour, PlayVFX Behaviour 1, PlayVFX Behaviour, Reset Bomb Invul_AdvancedOperation Behaviour, ResetMovesetLimiters Behaviour, ResetVelocityOnWallDetection Behaviour, SetupHitBoxes Behaviour, SetupHurtBoxes Behaviour, Slide Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, StopSlideSoundStopSFX Behaviour, StopSlideSound_StopSFX Behaviour, StopTint Behaviour, StopVFX Behaviour, UpdateEnvironmentCollisionBox Behaviour, UseGroundRotation Behaviour

## Start InviciDrill
- state asset: `Start InviciDrill State.txt` (name: Start InviciDrill)
  - default behaviours (6): `StartInviciDrill Behaviour`, `PlaySFX Behaviour`, `SpawnEntity Behaviour`, `Go To Idle_ChangeState Behaviour`, `Play Trail_PlayVFX Behaviour`, `Stop SlideStopSFX Behaviour`
- behaviour files (6): Go To Idle_ChangeState Behaviour, Play Trail_PlayVFX Behaviour, PlaySFX Behaviour, SpawnEntity Behaviour, StartInviciDrill Behaviour, Stop SlideStopSFX Behaviour

## Start LightningWatch
- state asset: `Start LightningWatch State.txt` (name: Start LightningWatch)
  - default behaviours (12): `UpdateEnvironmentCollisionBox Behaviour`, `StopImpulse Behaviour`, `Clear Velocity_AdvancedOperation Behaviour`, `PlayVFX Behaviour`, `SpawnEntity Behaviour 1`, `PlaySFX Behaviour`, `Initial Impulse_ApplyImpulse Behaviour`, `Second Impulse_ApplyImpulse Behaviour`, `PlayVFX Behaviour 1`, `Go to Idle Air_ChangeState Behaviour`, `Restore Values_AdvancedOperation Behaviour`, `Go To Idle_ChangeState Behaviour`
- behaviour files (12): Clear Velocity_AdvancedOperation Behaviour, Go To Idle_ChangeState Behaviour, Go to Idle Air_ChangeState Behaviour, Initial Impulse_ApplyImpulse Behaviour, PlaySFX Behaviour, PlayVFX Behaviour 1, PlayVFX Behaviour, Restore Values_AdvancedOperation Behaviour, Second Impulse_ApplyImpulse Behaviour, SpawnEntity Behaviour 1, StopImpulse Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Taunt
- state asset: `Taunt State.txt` (name: Taunt)
  - default behaviours (7): `Go To Idle_ChangeState Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `PlayAnimation Behaviour`, `AdvancedOperation Behaviour`, `TauntEvent_PlayerStat Behaviour`, `NotifyGeneralCharacterVOEvent Behaviour`
- behaviour files (8): AdvancedOperation Behaviour, Go To Idle_ChangeState Behaviour, NotifyGeneralCharacterVOEvent Behaviour, PlayAnimation Behaviour, SetupHurtBoxes Behaviour, StillAliveEvent_PlayerStat Behaviour, TauntEvent_PlayerStat Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Trip
- state asset: `Trip State.txt` (name: Trip)
  - default behaviours (10): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `SpeedRunnerMovement Behaviour`, `Ground Animation_PlayAnimation Behaviour`, `Go To IdleChangeState Behaviour`, `Air Animation_PlayAnimation Behaviour`, `Go To Idle Air_ChangeState Behaviour`, `Go To IdleChangeState Behaviour 1`, `PlaySFX Behaviour`, `NotifyGeneralCharacterVOEvent Behaviour`
- behaviour files (10): Air Animation_PlayAnimation Behaviour, Go To Idle Air_ChangeState Behaviour, Go To IdleChangeState Behaviour 1, Go To IdleChangeState Behaviour, Ground Animation_PlayAnimation Behaviour, NotifyGeneralCharacterVOEvent Behaviour, PlaySFX Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Tumble
- state asset: `Tumble State.txt` (name: Tumble)
  - default behaviours (16): `Exeute Burn_ExecuteGroup Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `PlayAnimation Behaviour`, `PlaySFX Behaviour 1`, `StopSFX Behaviour`, `Go To Idle Air_ChangeState Behaviour`, `Stunned Behaviour`, `DetectLand Behaviour`, `NotifyGeneralCharacterVOEvent Behaviour`, `PlayTint Behaviour`, `StopTint Behaviour`, `PlayVFX Behaviour`, `StopVFX Behaviour`, `Reset Values_AdvancedOperation Behaviour`, `PlaySFX Behaviour`
- behaviour files (16): DetectLand Behaviour, Exeute Burn_ExecuteGroup Behaviour, Go To Idle Air_ChangeState Behaviour, NotifyGeneralCharacterVOEvent Behaviour, PlayAnimation Behaviour, PlaySFX Behaviour 1, PlaySFX Behaviour, PlayTint Behaviour, PlayVFX Behaviour, Reset Values_AdvancedOperation Behaviour, SetupHurtBoxes Behaviour, StopSFX Behaviour, StopTint Behaviour, StopVFX Behaviour, Stunned Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Victory
- state asset: `Victory State.txt` (name: Victory)
  - default behaviours (3): `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `PlayAnimation Behaviour 1`
- behaviour files (3): PlayAnimation Behaviour 1, SetupHurtBoxes Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Wall Jump
- state asset: `Wall Jump State.txt` (name: Wall Jump)
  - default behaviours (13): `SpeedRunnerMovement Behaviour`, `SpeedRunnersJump Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `Detect LandDetectLand Behaviour`, `SpeedRunnersDetectWallSlide Behaviour`, `ResetVelocityOnWallDetection Behaviour 1`, `PlayAnimation Behaviour`, `Go To Idle AirChangeState Behaviour 1`, `PlaySFX Behaviour`, `PlayVFX Behaviour`
- behaviour files (13): Detect LandDetectLand Behaviour, Go To Idle AirChangeState Behaviour 1, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, PlaySFX Behaviour, PlayVFX Behaviour, ResetVelocityOnWallDetection Behaviour 1, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, SpeedRunnersDetectWallSlide Behaviour, SpeedRunnersJump Behaviour, UpdateEnvironmentCollisionBox Behaviour

## Wall Slide
- state asset: `Wall Slide State.txt` (name: Wall Slide)
  - default behaviours (17): `Reset Rotation_AdvancedOperation Behaviour`, `ResetMovesetLimiters Behaviour`, `UpdateEnvironmentCollisionBox Behaviour`, `SetupHurtBoxes Behaviour`, `InputCheck Behaviour`, `ItemUseCheck Behaviour`, `SpeedRunnerMovement Behaviour`, `WallSlide Behaviour`, `Detect Land_DetectLand Behaviour`, `PlayAnimation Behaviour`, `CheckForLedgeClimb Behaviour`, `PlayVFX Behaviour`, `PlaySFX WallSlide_PlaySFX Behaviour`, `StopSFX Wall Slide_StopSFX Behaviour`, `PlaySFX WallSlidePlaySFX Behaviour`, `Stop  WallSlide_PlaySFX Behaviour`, `StopSFX Wall SlideStopSFX Behaviour`
- behaviour files (17): CheckForLedgeClimb Behaviour, Detect Land_DetectLand Behaviour, InputCheck Behaviour, ItemUseCheck Behaviour, PlayAnimation Behaviour, PlaySFX WallSlidePlaySFX Behaviour, PlaySFX WallSlide_PlaySFX Behaviour, PlayVFX Behaviour, Reset Rotation_AdvancedOperation Behaviour, ResetMovesetLimiters Behaviour, SetupHurtBoxes Behaviour, SpeedRunnerMovement Behaviour, Stop  WallSlide_PlaySFX Behaviour, StopSFX Wall SlideStopSFX Behaviour, StopSFX Wall Slide_StopSFX Behaviour, UpdateEnvironmentCollisionBox Behaviour, WallSlide Behaviour
