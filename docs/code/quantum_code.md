# quantum.code.dll - deterministic gameplay simulation

1100 types.

## Namespaces

- `(global)`: 27 class, 35 struct, 10 enum
- `Microsoft.CodeAnalysis`: 1 class
- `Quantum`: 119 enum, 256 struct, 429 class, 22 interface
- `Quantum.Core`: 7 class
- `Quantum.Prototypes`: 44 struct, 146 class
- `Quantum.SpeedRunners.Classes`: 1 class
- `System.Runtime.CompilerServices`: 3 class


## Enums (full value lists)

### Quantum.AnimationEvent
None=0, ExecuteGroup=1, ChangeState=2

### Quantum.AttackVictimDirection
FaceTowards=0, FaceAway=1

### Quantum.BossFightState
Undefined=0, BannerShow=1, Countdown=2, Playing=3, RoundWait=4, FightFinished=5, PlayerWon=6, PlayerLost=7

### Quantum.CharacterActivationType
None=0, FullActivation=1, TemporalActivation=2

### Quantum.CharacterMatchState
Undefined=0, Intro=1, Playing=2, Death=3, Respawning=4, Eliminated=5, Unavailable=6, Preload=7

### Quantum.CombatInteractionPolicy
Neutral=0, Ignore=1, Seek=2

### Quantum.Difficulties
Easy=1, Normal=2, Hard=4, Unfair=8

### Quantum.ECBOffsetOperation
None=0, Add=1, Set=2

### Quantum.EdgeGrabCondition
None=0, Always=1, OnGoingUp=2, OnGoingDown=3

### Quantum.EdgeSide
Left=0, Right=1

### Quantum.GameEntityType
None=0, Character=1, Projectile=2, Item=3, Stage=4, Hazard=5

### Quantum.GameplayAnnouncerVOEvent
None=0, MidMatchComment=1, FirstKO=2, KO=3, SuddenDeathStart=4, FirstPlaceDisplaced=5, MatchFinished=6, CharacterFreeze=7, CharacterBurn=8, CharacterRocket=9, CharacterHooked=10, CharacterTackled=11, CharacterInSuperSpeed=12, CharacterBackfired=13, CharacterBigAir=14, CharacterRevenge=15, CharacterStillAlive=16, CharacterDeflected=17

### Quantum.GameplayCharacterVOEvent
None=0, RoundVictory=1, MatchVictory=2, Tumble=3, Trip=4, EnterSuperSpeed=5, Jump=6, GetItem=7, Freeze=8, Burn=9, Taunt=10, IdleAlt=11

### Quantum.GrabDirection
FaceTowardsGrabber=0, FaceAgainstGrabber=1

### Quantum.GrabMode
None=0, InPlace=1, Carriable=2

### Quantum.GrabState
None=0, Grabbing=1, Grabbed=2

### Quantum.GrabbedAction
None=0, Throw=1, Swing=2, Shoot=3

### Quantum.HazardSpawnDirection
LeftToRight=0, RightToLeft=1, TopToBottom=2

### Quantum.HitBoxPriority
Low=0, Medium=1, High=2

### Quantum.HitBoxSpecialBehaviour
None=0, Attract=1, Repel=2

### Quantum.HitBoxType
Default=0, Reflect=1, Redirect=2, Grab=3, HitGrab=4

### Quantum.HitType
Hook=0, RemoteBomb=1, Missile=2, Fireball=3, Tackle=4, Crate=5, Freeze=6, ShockWave=7

### Quantum.InitialWaitTimerState
Inactive=0, InCountdown=1, Finished=2

### Quantum.InputDirection
None=0, Up=1, Down=2, Left=3, Right=4

### Quantum.InputFlag
None=0, Jump=1, Slide=2, GrappleHook=4, UsePickup=8, Boost=16, Taunt=32, Last=64

### Quantum.ItemButtonUseMode
OnButtonPress=0, OnButtonRelease=1

### Quantum.ItemsSpawnFrecuency
None=0, Low=1, Medium=2, High=3

### Quantum.JumpType
None=0, Ground=1, GroundShort=2, Air=3, Wall=4

### Quantum.LaserDirection
Left=0, Right=1

### Quantum.LoopMode
Continous=0, PingPong=1, Once=2

### Quantum.MathOperationMethod
None=0, Set=1, Add=2, Substract=3, Multiply=4

### Quantum.MovesetLimiterResetContext
FromLand=0, FromHurt=1

### Quantum.PlatformFightState
Undefined=0, BannerShow=1, Countdown=2, Playing=3, RoundWait=4, RaceFinished=5

### Quantum.RaceState
Undefined=0, BannerShow=1, Countdown=2, Playing=3, RoundWait=4, RaceFinished=5

### Quantum.RespawnDirection
Left=0, Right=1

### Quantum.RunningDirection
Left=0, Right=1, Stop=2

### Quantum.SimpleLineEndRotationMode
Static=0, FaceTowards=1, FaceAway=2

### Quantum.SlideDirection
Up=0, Down=1

### Quantum.SpawnPointDirection
Right=0, Left=1

### Quantum.SpikeDirection
Up=0, Down=1, Left=2, Right=3

### Quantum.StageExecutionMode
None=0, PlayOnEnter=1, PlayOnExit=2, Both=3

### Quantum.StageType
Undefined=0, Versus=1

### Quantum.StateGroupExecutionMode
None=0, AllAtOnce=1, IncludeInUpdate=2, Scheduled=3

### Quantum.StatusEffectModifierOperation
Multiply=0, Add=1, Subtract=2, Set=3

### Quantum.SuperBoostDirection
Up=0, UpRight=1, Right=2, DownRight=3, Down=4, DownLeft=5, Left=6, UpLeft=7

### Quantum.SurfaceType
Default=0, Wood=1, Sand=2, Stone=3, Ice=4, SolidMetal=5, HollowMetal=6

### Quantum.TargetSlot
None=0, LeftHandSlot=1, RightHandSlot=2, ExtraHandSlot=3, ItemSlot=4, GrabSlot=5

### Quantum.TintCategories
None=0, Gameplay=1, Status=2, Entity=3, Overall=4

### Quantum.TrapDoorSwitchActivationMode
Open=0, Close=1

### Quantum.VelocityModifierCondition
None=0, Any=1, Positive=2, Negative=3

### Quantum.VelocityOperation
Add=0, Set=1, Multiply=2

### Quantum.VelocityType
InitialOnEnter=0, InitialOnExit=1, Constant=2

### Quantum.VolumeDirection
Left=0, Right=1

### Quantum.VolumeMode
Override=0, Stack=1

### Quantum.VolumeType
Undefined=0, Jump=1, Slide=2, Grapple=3, Boost=4, RunLeft=5, RunRight=6, Stop=7

### Quantum.WallSnapDirection
None=0, Left=1, Right=2

### Quantum.InputButtons


### Quantum.RecordingFlags
None=0, Input=1, Checksums=2, Default=3, All=255

### SimulationConfig.AutoLoadSceneFromMapMode
Disabled=0, Legacy=1, UnloadPreviousSceneThenLoad=2, LoadThenUnloadPreviousScene=3

### Quantum.SimulationConfigChecksumErrorDumpOptions
SendAssetDBChecksums=1, ReadableDynamicDB=2, RawFPValues=4, ComponentChecksums=8

### Quantum.SimulationUpdateTime
Default=0, EngineDeltaTime=1, EngineUnscaledDeltaTime=2

### Quantum.PlayerStatEventType
Reflect=0, Block=1, Taunt=2, Treasure=3, Combo=4

### Quantum.FacingDirectionUpdateMode
None=0, FromVelocity=1, FromInput=2

### Quantum.PickupItemAction
SpawnEntity=0, ChangeStateInOwner=1, ChangeStateInLastSpawnedEntity=2

### Quantum.TargetDirection
Front=1, Back=2

### Quantum.GameSpecificComponentSource
SpeedRunnersCharacter=100

### Quantum.SpeedRunnersCharacterVariable
Alive=0, HookHitPointX=1, HookHitPointY=2, HookHitDistance=4, EquipedItemID=5, ItemUses=6, Boost=7, IsBoostActive=8, IsSliding=9, InviciDrillFrames=10, FreezeFrames=11, HookCooldownFrames=12, SlideCooldownFrames=13, IsJumping=15, JumpPower=16, IgnoreSlideMinVelocity=17, Rank=18, TriggeredInstantJump=19, ItemPowerCharged=20, ItemPowerIncrease=21, PulledByHook=22, LastItemUsed=23, IsItemUseActive=24, FacingDirectionOnItemUse=25, LastValidDirectionForItemX=26, LastValidDirectionForItemY=27

### Quantum.OnTimerCompletion
CompleteCourse=0, FailCourse=1

### Quantum.ActionOnTimerCompletion
CompleteSection=0, FailSection=1

### Quantum.AnimationChannel
Channel1=0, Channel2=1, Channel3=3, Channel4=4, Channel5=5

### Quantum.AttackDataOperation
Set=0, Multiply=1

### Quantum.CombatCapsulePointSetupType
FollowJoint=0, ManualPosition=1

### InputBufferEventChecker.ButtonState
NotPressed=0, JustPressed=1, JustReleased=2, Hold=3

### InputBufferEventChecker.InputActionTypes
Button=0, Direction=1

### InputBufferEventChecker.DirectionOverride
None=0, DetectionThreshold=1, Angle=2

### Quantum.AudioContextStopMode
All=0, GameplayOnly=1, NonGameplayOnly=2

### Quantum.BlastzoneEdge
Undefined=0, Top=1, Bottom=2, Left=3, Right=4

### Quantum.VFXVectorSource
Vector=0, EntityVariable=1

### Quantum.StateNotificationMode
None=0, ChangeState=1, ExecuteState=2

### Quantum.SpecialAnglePreset
None=0, Sakurai_361=361, Autolink_366=366, Autolink_367=367, Bumper=400, InverseBumper=401

### Quantum.GrabJoint
None=0, GrabSlot=1, ItemSlot=2, Custom=3, ManualPosition=4

### Quantum.ImpulseStickInfluence
None=0, Sign=1, Full=2, PositiveOnly=3, NegativeOnly=4, CustomVariable=5

### Quantum.BehaviourTargetEntity
Self=0, FindByIndex=1, LastSpawned=2, Owner=10, OriginalOwner=11, LastInstigator=20, LastVictim=21, Grabbing=30, Grabber=31, TriggerEnterEntity=40, TriggerExitEntity=41

### Quantum.AnimationSpeedUpdateMode
None=0, Simple=1, MapRange=2

### Quantum.SFXParameterType
String=0, Float=1

### Quantum.RedirectionMode
LocalSpeed=0, GlobalSpeed=1

### Quantum.ReflectionMode
LocalSpeed=0, GlobalSpeed=1

### SetupHurtBoxes_Behaviour.HurtBoxUpdateMode
FromPreset=0, Manual=1

### StopStatusEffect_Behaviour.statusEffectRemoveEnum
ByNameId=0, ByOriginId=1, ByType=2

### PrintMessage_Behaviour.MessageOutput
None=0, ConsoleDefault=1, ConsoleError=2

### Quantum.MessagePartType
Text=0, Variable=1

### ExecuteGroupOnLinecastHit_Behaviour.LinecastConditions
OnCollisionDetected=0, OnCollisionNotDetected=1

### ExecuteGroup_Behaviour.ExecuteGroupRepeatMode
None=0, Interval=1

### Quantum.ThrowDirection
Up=0, Down=1, Forward=2

### Quantum.InputAction
None=0, ExecuteGroup=1, ChangeState=2

### Quantum.JumpBehaviourType
Ground=0, Air=1, Wall=2

### Quantum.VelocityAxisInfluence
Horizontal=0, Vertical=1, Both=2

### Quantum.GroundNormal
Current=0, Previous=1

### UpdateEnvironmentCollisionBox_Behaviour.ECBUpdateMode
FromPreset=0, Manual=1

### Quantum.ComponentSource
Float=0, Math=1, GameEntity=2, PhysicsBody=3, KinematicBody=4, StateMachineVariable=5, Input=6, Combat=8, LastReceivedHit=9, LastInflictedHit=10, Grab=11, StateMachine=12, Text=13, Boolean=14, CombatDamage=15, CombatStamina=16, CombatStocks=17, CombatBlock=18, CombatTech=19, CombatCharge=20, CombatArmor=21, CombatDI=22, Transform=23, Trigger=24, MovesetLimiter=25, EntityType=26, PhysicsCollider=27, CameraTarget=28, StatusEffects=29, VisibilitySource=30, GameSpecific=99

### Quantum.AdvancedOperationAction
Set=0, Add=1, Subtract=2, Multiply=3, Divide=4

### Quantum.AdvancedConditionComparer
Equals=0, NotEquals=1, Greater=2, GreaterOrEquals=3, Less=4, LessOrEquals=5

### Quantum.AdvancedConditionLogicalOperator
And=0, Or=1

### Quantum.MathOperation
Add=0, Subtract=1, Multiply=2, Divide=3, Sqrt=4, Abs=5, Min=6, Max=7, Mod=8, Clamp=9, Repeat=10, Floor=11, Ceiling=12, Round=13, Sign=14, SignZero=15, Exp=16, Sin=17, Cos=18, Tan=19, Atan=20, Atan2=21, Log=22, Log10=23, Log2=24, Lerp=25, LerpRadians=26, InverseLerp=27, InverseLerpUnclamped=28, MoveToward=29, MoveTowardAngle=30, SmoothStep=31, Rad2Deg=32, Deg2Rad=33, Select=34, Equals=35, NotEquals=36, Greater=37, GreaterOrEquals=38, Less=39, LessOrEquals=40, Random=41

### Quantum.VisibilitySourceVariable
Active=0

### Quantum.GameEntityVariable
Visible=0, CostumeIndex=1, FacingDirection=2, SmoothRotationStart=3, Rotation=4, RootRotation=5, Scale=6, RotationPivotX=7, RotationPivotY=8, NameID=9, EntityType=10, Index=11, OwnerIndex=12, OriginalOwnerIndex=13, LastSpawnedEntityIndex=14

### Quantum.TransformVariable
PositionX=0, PositionY=1, Rotation=2, RotationDegrees=3

### Quantum.PhysicsBodyVariable
Active=0, CorrectionEnabled=1, BounceEnabled=2, TargetVelocityX=3, TargetVelocityY=4, VelocityX=5, VelocityY=6, ForceSnapToGround=7, CanLeaveEdges=8, CanFallThrough=9, IgnoreThinPlatforms=10, IgnoreThinPlatformFrames=11, Grounded=12, OnFloor=13, OnCeiling=14, OnLeftWall=15, OnRightWall=16, FramesInAir=17, Gravity=18, GravityMultiplier=19, FallSpeed=20, AirSpeed=21, AirAcceleration=22, AirFriction=23, AirExtraFrictionThresholdMax=24, AirExtraFrictionThresholdMin=25, AirExtraFrictionFactor=26, WalkSlowSpeed=27, WalkFastSpeed=28, RunSpeed=29, GroundAcceleration=30, GroundFriction=31, GroundExtraFrictionThresholdMax=32, GroundExtraFrictionThresholdMin=33, GroundExtraFrictionFactor=34, FloorRotationInfluence=35, FloorRotationSpeed=36, KnockbackDecay=37, TargetGroundFriction=38, CrowdPushEnabled=39, CrowdPushRadius=40, CrowdPushMinForce=41, CrowdPushMaxForce=42, IsOverThinPlatform=43, TotalVelocityX=44, TotalVelocityY=45, DetectBlastzones=46, DetectTopBlastzone=47, GroundNormalX=48, GroundNormalY=49, CeilingNormalX=50, CeilingNormalY=51, LeftWallNormalX=52, LeftWallNormalY=53, RightWallNormalX=54, RightWallNormalY=55, IsGoingDownSlope=56, IsGoingUpSlope=57, VelocityLength=58, TotalVelocityLength=59

### Quantum.KinematicBodyVariable
Active=0, VelocityX=1, VelocityY=2

### Quantum.TriggerVariable
Active=0

### Quantum.PhysicsColliderVariable
Active=0

### Quantum.InputVariable
LeftStickX=0, LeftStickY=1, BufferCheck=2, NormalizedLeftStickX=3, NormalizedLeftStickY=4, LeftStickForward=5, LeftStickBack=6

### Quantum.CombatVariable
Active=0, IsDown=5, HitLagFrames=8, HitStunFrames=9, WeightForKnockback=10, CharacterIndexTeam=12, IsIntangible=15, IntangibilityFrames=16, IsInvincible=17, InvincibilityFrames=18, RedirectedByAnything=19, CanBeRedirected=20, CanBeReflected=21, IsInHitLag=22, IsHitStunned=23, HasIntangibility=24, HasInvincibility=25, RedirectAngle=26

### Quantum.CombatDamageVariable
Damage=0

### Quantum.CombatStaminaVariable
Stamina=0, ExtraDamageForKnockback=1, ExtraDamageForKnockbackFrames=2

### Quantum.CombatStocksVariable
Stocks=0

### Quantum.CameraTargetVariable
Active=0, Visible=1

### Quantum.StatusEffectsVariable
HasType=0

### Quantum.CombatBlockVariable
Blocking=0, BlockFrames=1, BlockStamina=2, PerfectBlockLockFrames=3, PerfectBlockBufferFrames=4

### Quantum.CombatTechVariable
DetectTechLock=0, TechLockFrames=1, TechBufferFrames=2

### Quantum.CombatChargeVariable
UseChargeMultiplier=0, ChargeAttackMultiplierID=1, ChargeAttackPower=2

### Quantum.CombatArmorVariable
Armor=0, SuperArmor=1

### Quantum.CombatDIVariable
CalculateDI=0, DIAngle=1, SDI_X=2, SDI_Y=3, TriggeredSDIs=4

### Quantum.HitInfoVariable
AttackData=0, Flinchless=1, JabLock=2, IsVictimInvisible=3, Blocked=4, Knockback=5, Push=6, HitStun=7, DIMultiplier=8, SDIMultiplier=9, HitLag=10, BlockHitLag=11, Damage=12, BlockDamage=13, Angle=14, InstigatorAdvantageOnHit=15, InstigatorAdvantageOnBlock=16, DirectionX=17, DirectionY=18, HitBoxPositionX=19, HitBoxPositionY=20, InstigatorPushBack=21, Trade=22, PerfectBlock=23, BlockStun=24

### Quantum.GrabVariable
Active=0, CanBeGrabbed=1, CanEscapeGrab=2, GrabbableOnlyByOwner=3, RemainingFramesToEscape=4, Grabbing=5, Grabbed=6, ThrowDirectionX=7, ThrowDirectionY=8, StrongThrow=9, StrongUse=10, HasItem=11

### Quantum.StateMachineVariable
Active=0, CurrentState=1, PreviousState=2, SpeedMultiplier=3, StateTime=4

### Quantum.InputPrerequisiteMode
All=0, Any=1, AnyOrMain=2

### Quantum.StateGroupEvent
None=0, OnEnterState=1, OnExitState=2, OnUpdateState=3, OnHit=10, OnHurt=11, OnBlocked=12, OnBlock=13, OnGrabInPlace=14, OnGrabbed=15, OnGrabCarriable=16, OnTouchFloor=20, OnTouchCeiling=21, OnTouchLeftWall=22, OnTouchRightWall=23, OnLeaveFloor=24, OnReachLedge=25, OnBounce=26, OnFloorBounceFailed=27, OnEntityEnter=28, OnEntityExit=29, OnLeaveCeiling=30, OnLeaveLeftWall=31, OnLeaveRightWall=32, OnStartUpSlope=33, OnEndUpSlope=34, OnStartDownSlope=35, OnEndDownSlope=36

### Quantum.StatusEffectEvent
None=0, OnHit=1, OnHurt=2, OnBlocked=3, OnBlock=4, OnGrabInPlace=5, OnGrabbed=6, OnGrabCarriable=7, OnRespawn=10


## ECS Components (108)

### Quantum.AIVolume  (bases: IComponent; TypeDefIndex 9951)
Fields:
```
public int BoostAmount;  // 0x4
private Ptr ConditionalEntitiesPtr;  // 0x3C
public QBoolean ConditionalState;  // 0x20
public QBoolean Directional;  // 0x24
public QBoolean Disabled;  // 0x28
public int EasyChance;  // 0x8
public EntityRef Entity;  // 0x50
public int FrameDelay;  // 0xC
public int Frames;  // 0x10
public int HardChance;  // 0x14
public QString64 ItemID;  // 0x58
public QBoolean NeedsBoost;  // 0x2C
public QBoolean NeedsItem;  // 0x30
public int NormalChance;  // 0x18
public QBoolean PreventDestroyOnStart;  // 0x34
public QBoolean Temporary;  // 0x38
public int UnfairChance;  // 0x1C
public Difficulties VolumeDifficulty;  // 0x0
public VolumeDirection VolumeDirection;  // 0x40
public VolumeMode VolumeMode;  // 0x44
public VolumeType VolumeType;  // 0x48
```
Methods:
```
public QListPtr<EntityRef> get_ConditionalEntities()   // RVA 0x20C6B60
public void set_ConditionalEntities(QListPtr<EntityRef> value)   // RVA 0x8757C0
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20C5DC0
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20C67C0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6840
public void OnBodyEnter(Frame frame, EntityRef other)   // RVA 0x20C5F10
```

### Quantum.BaseGameModeManager  (bases: IComponent; TypeDefIndex 9952)
Fields:
```
public QBoolean MatchEnded;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C8250
```

### Quantum.Blastzone  (bases: IComponent; TypeDefIndex 9953)
Fields:
```
public FPVector2 BottomRight;  // 0x8
public FPVector2 TopLeft;  // 0x18
public QBoolean TriggerEnabled;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C8670
public static bool TryFind(Frame frame, out Blastzone* blastzone)   // RVA 0x20C86C0
```

### Quantum.BlastzoneTrigger  (bases: IComponent; TypeDefIndex 9954)
Fields:
```
public EntityRef RespawnPoint;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C8600
```

### Quantum.BossFightGameModeManager  (bases: IComponent; TypeDefIndex 9955)
Fields:
```
public FP CurrentCountdown;  // 0x10
public FP CurrentMatchTimer;  // 0x18
public BossFightState CurrentState;  // 0x0
public QBoolean HasDialogue;  // 0x4
public QBoolean IsDialogue;  // 0x8
public FP PlayerStaminaBeforeHit;  // 0x20
public QBoolean StartedTimer;  // 0xC
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C8880
```

### Quantum.BreakableGlass  (bases: IComponent; TypeDefIndex 9956)
Fields:
```
public int FramesToRestore;  // 0x0
public QString64 GoalOnBreak;  // 0x10
public QBoolean IsRestorable;  // 0x4
public FP VelocityToBreak;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C89E0
```

### Quantum.CameraManager  (bases: IComponent; TypeDefIndex 9957)
Fields:
```
public QBoolean Active;  // 0x0
public AssetRefCameraManagerData CameraManagerData;  // 0x8
public SimpleAABB CameraRect;  // 0x38
public EntityRef Entity;  // 0x18
public QBoolean ExcludeAsVisibilitySource;  // 0x4
public AssetRefGlobalCameraSettingsData GlobalSettingsData;  // 0x10
public FPVector2 LookAhead;  // 0x28
public FP Zoom;  // 0x20
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C94F0
public static bool TryFind(Frame frame, out CameraManager* cameraManager)   // RVA 0x20C9600
public void CheckInitialSettings(Frame frame)   // RVA 0x20C8F90
public void Update(Frame frame)   // RVA 0x20C9750
public void ForceUpdate(Frame frame)   // RVA 0x20C90C0
public FPVector2 WorldToViewport(FPVector2 vector)   // RVA 0x20C99E0
public FPVector2 ViewportToWorld(FPVector2 vector)   // RVA 0x20C9930
```

### Quantum.CameraTarget  (bases: IComponent; TypeDefIndex 9958)
Fields:
```
public QBoolean Active;  // 0x0
public SimpleAABB BaseFocusRect;  // 0x38
public EntityRef Entity;  // 0x10
public SimpleAABB FocusRect;  // 0x58
public FP ForwardDistance;  // 0x18
public FP ForwardInterpolationSpeed;  // 0x20
public QBoolean InterpolatePosition;  // 0x4
public FP Scale;  // 0x28
public FP VerticalOffset;  // 0x30
private Ptr ViewerIndexesPtr;  // 0xC
public QBoolean Visible;  // 0x8
private static ColorRGBA CameraTargetColor;  // 0x0
```
Methods:
```
public QListPtr<int> get_ViewerIndexes()   // RVA 0x20CA720
public void set_ViewerIndexes(QListPtr<int> value)   // RVA 0x1ED2120
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20C9B80
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20C9DA0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C9E40
public void OnInit(Frame frame, EntityRef entity)   // RVA 0x20C9CE0
public void Update(Frame frame)   // RVA 0x20CA200
public FPVector2 ClampWithinAABB(FPVector2 position)   // RVA 0x20C9AB0
public void UpdateFocusPosition(Frame frame, FPVector2 InterpolatedCenterPosition, FP scale)   // RVA 0x20CA0B0
public FP GetValue(Frame frame, CameraTargetVariable variable)   // RVA 0x20C9C90
public void SetValue(Frame frame, CameraTargetVariable variable, FP value)   // RVA 0x20C9FF0
private static void .cctor()   // RVA 0x20CA6D0
```

### Quantum.CampaignBoss  (bases: IComponent; TypeDefIndex 9959)
Fields:
```
public QString64 BossID;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CA7C0
```

### Quantum.CampaignRaceGameModeManager  (bases: IComponent; TypeDefIndex 9960)
Fields:
```
public FP CurrentMatchTimer;  // 0x10
public QBoolean HasDialogue;  // 0x0
public QBoolean MatchCompleted;  // 0x4
public QBoolean StartedTimer;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CA8A0
```

### Quantum.Checkpoint  (bases: IComponent; TypeDefIndex 9961)
Fields:
```
public QBoolean Active;  // 0x0
public FP DistanceToFinish;  // 0x10
public EntityRef RespawnPoint;  // 0x8
public QBoolean StartPoint;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CCD20
public void OnBodyEnter(Frame frame, EntityRef triggerEntity, EntityRef otherEntity)   // RVA 0x20CCBA0
public void OnBodyExit(Frame frame, EntityRef triggerEntity, EntityRef otherEntity)   // RVA 0x20CCC70
```

### Quantum.CheckpointManager  (bases: IComponent; TypeDefIndex 9962)
Fields:
```
private Ptr CheckpointListPtr;  // 0x4
public EntityRef CurrentWinningPlayer;  // 0x10
public EntityRef LastRespawnPoint;  // 0x18
public int LastSpawnDirection;  // 0x0
private Ptr RankingPtr;  // 0x8
public FP TotalLapDistance;  // 0x20
public static ColorRGBA PlayerDistanceColor;  // 0x0
public static ColorRGBA WinningPlayerDistanceColor;  // 0x4
```
Methods:
```
public QListPtr<EntityRef> get_CheckpointList()   // RVA 0x20CCAD0
public void set_CheckpointList(QListPtr<EntityRef> value)   // RVA 0x526D50
public QListPtr<EntityRef> get_Ranking()   // RVA 0x20CCB10
public void set_Ranking(QListPtr<EntityRef> value)   // RVA 0x1ED2130
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20CA940
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20CB7B0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CB850
public void OnInit(Frame frame)   // RVA 0x20CB2B0
public void Update(Frame frame)   // RVA 0x20CC9D0
public void UpdateCheckpointDebugLines(Frame frame)   // RVA 0x20CBB10
private void CalculateStepsToReachCheckpoint(int totalCheckpoints, int target, int start, int direction, out int steps, out bool overflow)   // RVA 0x20CA900
public void UpdateCheckpoint(Frame frame, EntityRef checkpointEntity, EntityRef playerEntity, EntityRef respawnPointEntity)   // RVA 0x20CBE70
public void EvaluateCheckpointDirection(Frame frame, EntityRef checkpointEntity, EntityRef characterEntity)   // RVA 0x20CAC70
public void DisableCheckpoints(Frame frame)   // RVA 0x20CA950
public void EnableCheckpoints(Frame frame)   // RVA 0x20CAAE0
public void UpdateRanking(Frame frame)   // RVA 0x20CC120
public static bool TryFind(Frame frame, out CheckpointManager* checkpointManager)   // RVA 0x20CB9C0
private static void .cctor()   // RVA 0x20CCA70
```

### Quantum.CollectorCharacter  (bases: IComponent; TypeDefIndex 9963)
Fields:
```
public EntityRef Entity;  // 0x8
public int Score;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CCE20
```

### Quantum.CollectorTreasure  (bases: IComponent; TypeDefIndex 9964)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CCEC0
```

### Quantum.CollectorsGameModeManager  (bases: IComponent; TypeDefIndex 9965)
Fields:
```
public QBoolean MatchFinished;  // 0x0
public FP NextTreasureSpawnTimer;  // 0x8
public FP RemainingMatchTime;  // 0x10
private Ptr SpawnAreasUsedPtr;  // 0x4
```
Methods:
```
public QHashSetPtr<int> get_SpawnAreasUsed()   // RVA 0x20CD100
public void set_SpawnAreasUsed(QHashSetPtr<int> value)   // RVA 0x526D50
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20CCF30
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20CCF90
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CD010
```

### Quantum.CollectorsTreasureSpawnArea  (bases: IComponent; TypeDefIndex 9966)
Fields:
```
public FPVector2 BottomRight;  // 0x0
public FPVector2 TopLeft;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CD180
```

### Quantum.Combat  (bases: IComponent; TypeDefIndex 9967)
Fields:
```
public QBoolean Active;  // 0x4
public QBoolean AffectedByFlinchlessHits;  // 0x8
public QBoolean CanBeRedirected;  // 0xC
public QBoolean CanBeReflected;  // 0x10
public AssetRefCombatData CombatData;  // 0x38
private Ptr EntitiesHitPtr;  // 0x28
public EntityRef Entity;  // 0x40
private Ptr HitBoxesPtr;  // 0x2C
public SimpleAABB HitBoxesRect;  // 0x90
public EntityHitFilter HitFilter;  // 0xF0
public FP HitLagFrames;  // 0x60
public FP HitStunFrames;  // 0x68
public int HitlagFramesOverride;  // 0x0
private Ptr HurtBoxesPtr;  // 0x30
public SimpleAABB HurtBoxesRect;  // 0xB0
public FP IntangibilityFrames;  // 0x70
public FP InvincibilityFrames;  // 0x78
public QBoolean IsDown;  // 0x14
public QBoolean IsIntangible;  // 0x18
public QBoolean IsInvincible;  // 0x1C
public QBoolean KnockedOut;  // 0x20
public HitInfo LastInflictedHit;  // 0x138
public HitInfo LastReceivedHit;  // 0x210
public EntityRef LastRedirector;  // 0x48
public EntityRef LastReflector;  // 0x50
public EntityRef OwnerOverride;  // 0x58
public SimpleAABB RedirectAndReflectRect;  // 0xD0
public FP RedirectAngle;  // 0x80
public QBoolean RedirectedByAnything;  // 0x24
public FP WeightForKnockback;  // 0x88
private static ColorRGBA DIAngleColor;  // 0x0
private static ColorRGBA LaunchAngleColor;  // 0x4
```
Methods:
```
public QListPtr<EntityRef> get_EntitiesHit()   // RVA 0x20DB7C0
public void set_EntitiesHit(QListPtr<EntityRef> value)   // RVA 0x51AE50
public QListPtr<HitBox> get_HitBoxes()   // RVA 0x20DB800
public void set_HitBoxes(QListPtr<HitBox> value)   // RVA 0x11DAC00
public QListPtr<HurtBox> get_HurtBoxes()   // RVA 0x20DB840
public void set_HurtBoxes(QListPtr<HurtBox> value)   // RVA 0x5C5B70
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0xE1ECA0
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20D8320
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D8500
internal void Initialize(Frame frame, EntityRef entity, AssetRefCombatData combatData)   // RVA 0x20D6250
internal void Reset(Frame frame)   // RVA 0x20D83C0
internal FP GetValue(Frame frame, CombatVariable variable)   // RVA 0x20D5F20
internal void SetValue(Frame frame, CombatVariable variable, FP value)   // RVA 0x20D8860
internal void Update(Frame frame, CombatSettingsData combatSettingsData, Transform2D* transform)   // RVA 0x20D9E20
internal void ApplyDamage(Frame frame, FP damage, out bool knockedOut)   // RVA 0x20D4C80
internal void NotifyKnockOut(Frame frame)   // RVA 0x20D6770
internal void NotifyRespawn(Frame frame)   // RVA 0x20D68F0
internal void OnHurt(Frame frame, CombatSettingsData combatSettingsData, CombatData combatData, HitInfo hitInfo)   // RVA 0x20D70C0
internal void OnHit(Frame frame, CombatSettingsData combatSettingsData, CombatData combatData, HitInfo hitInfo)   // RVA 0x20D6A80
internal void OnRebound(Frame frame, CombatData combatData, FP hitLagFrames, bool trample = False)   // RVA 0x20D7FA0
internal void OnRedirected(Frame frame, Combat* redirector, FP redirectAngle)   // RVA 0x20D80C0
internal void OnReflected(Frame frame, Combat* reflector)   // RVA 0x20D81F0
internal void AddEntityToHitList(Frame frame, EntityRef entity)   // RVA 0x20D4870
internal void AddHitLag(FP hitLagFrames)   // RVA 0x20D4970
internal void AddHitStun(FP hitStun)   // RVA 0x16D9840
internal void SetupHitBoxes(Frame frame, HitBoxData[] hitBoxesData, FP scale, bool clearEntitiesHit = True)   // RVA 0x20D8C60
internal void UpdateHitBoxes(Frame frame, HitBoxData[] hitBoxesData, int currentFrame, FP scale)   // RVA 0x20D98C0
internal void ClearHitBoxes(Frame frame)   // RVA 0x20D5730
internal void SetupHurtBoxes(Frame frame, HurtBoxData[] hurtBoxesData, FP scale)   // RVA 0x20D9480
internal void UpdateHurtBoxes(Frame frame, HurtBoxData[] hurtBoxesData, int currentFrame, FP scale)   // RVA 0x20D9B70
internal void ClearHurtBoxes(Frame frame)   // RVA 0x20D58D0
internal void ClearEntitiesHit(Frame frame)   // RVA 0x20D5670
public bool HasIntangibility()   // RVA 0x20D61D0
public bool HasInvincibility()   // RVA 0x20D6210
internal bool IsInHitLag()   // RVA 0x20D6750
internal bool IsHitStunned()   // RVA 0x20D6730
internal FP GetHitStunnedFrames()   // RVA 0x20D5E30
internal bool IsEntityAlreadyHit(Frame frame, EntityRef entity)   // RVA 0x20D6600
private FPVector2 CalculateCombatCapsulePoint(Frame frame, int jointID, bool foundKeyFrame, JointKeyFrame keyFrame, Transform2D* transform, FPVector2 cachePoint, FPVector3 localOffset, FPVector2 globalOffset)   // RVA 0x20D5390
private void SetupDI(Frame frame, CombatSettingsData combatSettingsData, InputBuffer* inputBuffer, CombatDI* combatDI)   // RVA 0x20D8B30
private void ApplyDI(Frame frame, PhysicsBody* physicsBody, CombatDI* combatDI)   // RVA 0x20D4B90
public void ApplyASDI(Frame frame, CombatSettingsData combatSettingsData, InputBuffer* inputBuffer, PhysicsBody* physicsBody, Transform2D* transform, CombatDI* combatDI)   // RVA 0x20D4990
public void ApplySDI(Frame frame, CombatSettingsData combatSettingsData, InputBuffer* inputBuffer, PhysicsBody* physicsBody, Transform2D* transform, CombatDI* combatDI)   // RVA 0x20D4FB0
internal EntityRef GetOwnerEntity(Frame frame)   // RVA 0x20D5E50
internal EntityRef GetCharacterOwnerEntity(Frame frame)   // RVA 0x20D5990
internal void OnChangeOwner(Frame frame, EntityRef newOwner)   // RVA 0x20D6A00
private static void .cctor()   // RVA 0x20DB760
```

### Quantum.CombatArmor  (bases: IComponent; TypeDefIndex 9968)
Fields:
```
public FP Armor;  // 0x10
public EntityRef Entity;  // 0x8
public QBoolean SuperArmor;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D3A20
public FP GetValue(Frame frame, CombatArmorVariable variable)   // RVA 0x20D39E0
public void SetValue(Frame frame, CombatArmorVariable variable, FP value)   // RVA 0x20D3A70
```

### Quantum.CombatBlock  (bases: IComponent; TypeDefIndex 9969)
Fields:
```
public FP BlockFrames;  // 0x10
public FP BlockStamina;  // 0x18
public QBoolean Blocking;  // 0x0
public EntityRef Entity;  // 0x8
public FP PerfectBlockBufferFrames;  // 0x20
public FP PerfectBlockLockFrames;  // 0x28
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D3BF0
public FP GetValue(Frame frame, CombatBlockVariable variable)   // RVA 0x20D3B80
public void SetValue(Frame frame, CombatBlockVariable variable, FP value)   // RVA 0x20D3C70
```

### Quantum.CombatCharge  (bases: IComponent; TypeDefIndex 9970)
Fields:
```
public int ChargeAttackMultiplierID;  // 0x0
public FP ChargeAttackPower;  // 0x10
public EntityRef Entity;  // 0x8
public QBoolean UseChargeMultiplier;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D3E00
public FP GetValue(Frame frame, CombatChargeVariable variable)   // RVA 0x20D3DB0
public void SetValue(Frame frame, CombatChargeVariable variable, FP value)   // RVA 0x20D3E90
```

### Quantum.CombatDI  (bases: IComponent; TypeDefIndex 9971)
Fields:
```
public QBoolean CalculateDI;  // 0x4
public FP DIAngle;  // 0x10
public EntityRef Entity;  // 0x8
public FPVector2 SDI;  // 0x18
public int TriggeredSDIs;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D4020
public FP GetValue(Frame frame, CombatDIVariable variable)   // RVA 0x20D3FB0
public void SetValue(Frame frame, CombatDIVariable variable, FP value)   // RVA 0x20D40C0
```

### Quantum.CombatDamage  (bases: IComponent; TypeDefIndex 9972)
Fields:
```
public FP Damage;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D41D0
public void UpdateDamage(Frame frame, EntityRef entity, FP newDamageValue, bool notifyGameMode = True)   // RVA 0x20D42B0
public FP GetValue(Frame frame, CombatDamageVariable variable)   // RVA 0x20D41C0
public void SetValue(Frame frame, EntityRef entity, CombatDamageVariable variable, FP value)   // RVA 0x20D41F0
```

### Quantum.CombatPoints  (bases: IComponent; TypeDefIndex 9973)
Fields:
```
public int Points;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D4370
```

### Quantum.CombatStamina  (bases: IComponent; TypeDefIndex 9974)
Fields:
```
public FP ExtraDamageForKnockback;  // 0x0
public FP ExtraDamageForKnockbackFrames;  // 0x8
public FP Stamina;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20AA1B0
public void UpdateStamina(Frame frame, EntityRef entity, FP newStaminaValue, bool notifyGameMode = True)   // RVA 0x20D4500
public FP GetValue(Frame frame, CombatStaminaVariable variable)   // RVA 0x20D4430
public void SetValue(Frame frame, EntityRef entity, CombatStaminaVariable variable, FP value)   // RVA 0x20D4440
```

### Quantum.CombatStocks  (bases: IComponent; TypeDefIndex 9975)
Fields:
```
public int Stocks;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D45D0
public void UpdateStocks(Frame frame, EntityRef entity, int newStocksValue)   // RVA 0x20D4680
public FP GetValue(Frame frame, CombatStocksVariable variable)   // RVA 0x20D45C0
public void SetValue(Frame frame, EntityRef entity, CombatStocksVariable variable, FP value)   // RVA 0x20D4640
```

### Quantum.CombatTech  (bases: IComponent; TypeDefIndex 9976)
Fields:
```
public QBoolean DetectTechLock;  // 0x0
public EntityRef Entity;  // 0x8
public FP TechBufferFrames;  // 0x10
public FP TechLockFrames;  // 0x18
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D4760
public FP GetValue(Frame frame, CombatTechVariable variable)   // RVA 0x20D4710
public void SetValue(Frame frame, CombatTechVariable variable, FP value)   // RVA 0x20D47C0
```

### Quantum.ContinuousRotation  (bases: IComponent; TypeDefIndex 9977)
Fields:
```
public QBoolean Active;  // 0x0
public FP InitialRotation;  // 0x8
public FP RotationSpeed;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20DB8C0
public void Update(Frame frame, EntityRef entity)   // RVA 0x20DB910
```

### Quantum.CustomAnimator  (bases: IComponent; TypeDefIndex 9980)
Fields:
```
public QBoolean Active;  // 0x4
public AssetRefAnimationsPoolData AnimationsPool;  // 0x48
public AssetRefAnimationBakedJointsData BakedJointsData;  // 0x40
public QBoolean Blend1DActive;  // 0x8
public QBoolean Blend2DActive;  // 0xC
public FP CurrentBlendX;  // 0x58
public FP CurrentBlendY;  // 0x60
private CustomAnimator.<_CurrentClips_>e__FixedBuffer _CurrentClips_;  // 0x88
private Ptr CurrentSpeedData0Ptr;  // 0x10
private Ptr CurrentSpeedData1Ptr;  // 0x14
private Ptr CurrentSpeedData2Ptr;  // 0x18
private Ptr CurrentSpeedData3Ptr;  // 0x1C
private Ptr CurrentSpeedData4Ptr;  // 0x20
public EntityRef Entity;  // 0x50
public int HighestWeightClipIndex;  // 0x0
public FP HighestWeightClipTime;  // 0x68
private CustomAnimator.<_PreviousClips_>e__FixedBuffer _PreviousClips_;  // 0x1F0
private Ptr PreviousSpeedData0Ptr;  // 0x24
private Ptr PreviousSpeedData1Ptr;  // 0x28
private Ptr PreviousSpeedData2Ptr;  // 0x2C
private Ptr PreviousSpeedData3Ptr;  // 0x30
private Ptr PreviousSpeedData4Ptr;  // 0x34
public FP Speed;  // 0x70
private Ptr SubAnimatorClipPtr;  // 0x38
public FP TransitionDuration;  // 0x78
public FP TransitionTime;  // 0x80
```
Methods:
```
public FixedArray<CustomAnimatorPlayableClipInfo> get_CurrentClips()   // RVA 0x20E0060
public QListPtr<AnimationSpeedElement> get_CurrentSpeedData0()   // RVA 0x20E00D0
public void set_CurrentSpeedData0(QListPtr<AnimationSpeedElement> value)   // RVA 0x520750
public QListPtr<AnimationSpeedElement> get_CurrentSpeedData1()   // RVA 0x20E0110
public void set_CurrentSpeedData1(QListPtr<AnimationSpeedElement> value)   // RVA 0x873D00
public QListPtr<AnimationSpeedElement> get_CurrentSpeedData2()   // RVA 0x20E0150
public void set_CurrentSpeedData2(QListPtr<AnimationSpeedElement> value)   // RVA 0x6A4F50
public QListPtr<AnimationSpeedElement> get_CurrentSpeedData3()   // RVA 0x20E0190
public void set_CurrentSpeedData3(QListPtr<AnimationSpeedElement> value)   // RVA 0x667A40
public QListPtr<AnimationSpeedElement> get_CurrentSpeedData4()   // RVA 0x20E01D0
public void set_CurrentSpeedData4(QListPtr<AnimationSpeedElement> value)   // RVA 0x667A20
public FixedArray<CustomAnimatorPlayableClipInfo> get_PreviousClips()   // RVA 0x20E0240
public QListPtr<AnimationSpeedElement> get_PreviousSpeedData0()   // RVA 0x20E02B0
public void set_PreviousSpeedData0(QListPtr<AnimationSpeedElement> value)   // RVA 0x847EC0
public QListPtr<AnimationSpeedElement> get_PreviousSpeedData1()   // RVA 0x20E02F0
public void set_PreviousSpeedData1(QListPtr<AnimationSpeedElement> value)   // RVA 0x51AE50
public QListPtr<AnimationSpeedElement> get_PreviousSpeedData2()   // RVA 0x20E0330
public void set_PreviousSpeedData2(QListPtr<AnimationSpeedElement> value)   // RVA 0x11DAC00
public QListPtr<AnimationSpeedElement> get_PreviousSpeedData3()   // RVA 0x20E0370
public void set_PreviousSpeedData3(QListPtr<AnimationSpeedElement> value)   // RVA 0x5C5B70
public QListPtr<AnimationSpeedElement> get_PreviousSpeedData4()   // RVA 0x20E03B0
public void set_PreviousSpeedData4(QListPtr<AnimationSpeedElement> value)   // RVA 0x5061F0
public QDictionaryPtr<int, CustomSubAnimatorPlayableClipInfo> get_SubAnimatorClip()   // RVA 0x20E03F0
public void set_SubAnimatorClip(QDictionaryPtr<int, CustomSubAnimatorPlayableClipInfo> value)   // RVA 0x8757D0
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20DC1A0
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20DD760
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20DDE00
public int get_ActiveClipsNumber()   // RVA 0x20DFE30
public int get_HighestWeightClipFrame()   // RVA 0x20E0210
public void Initialize(Frame frame, EntityRef entity, AssetRefAnimationsPoolData animationsPoolData, AssetRefAnimationBakedJointsData bakedJointsData)   // RVA 0x20DD3D0
public void ForceUpdate(Frame frame)   // RVA 0x20DC590
public void Update(Frame frame, FP deltaTime)   // RVA 0x20DEDD0
public void PlayClip(Frame frame, int clipHash, int channel, int startFrame, int endFrame, FP speed, FP weight, bool loop, int groupToExecute, StateGroupExecutionMode groupExecutionMode)   // RVA 0x20DD7F0
public void PlaySubAnimationClip(Frame frame, int subAnimatorHash, int clipHash, int startFrame, int endFrame, FP speed, FP weight, bool loop)   // RVA 0x20DDA90
internal void SetClipSpeed(int channel, FP speed)   // RVA 0x20DE5E0
public void SetClipWeight(int channel, FP weight)   // RVA 0x20DE700
public CustomAnimatorPlayableClipInfo GetHighestWeightClip(out int channelIndex)   // RVA 0x20DCB70
public void SetAnimationSpeedData(Frame frame, AnimationSpeedElement[] newAnimationSpeedData, int channel)   // RVA 0x20DE420
public void AddAnimationSpeedData(Frame frame, AnimationSpeedElement animationSpeedData, int channel)   // RVA 0x20DBA00
public bool TryGetCurrentJointsKeyFrame(Frame frame, out JointKeyFrame keyFrame)   // RVA 0x20DEBE0
public bool TryGetKinematicMotion(Frame frame, out FPVector2 kinematicMotionDiff)   // RVA 0x20DECD0
public void StartTransitionBlend(Frame frame, FP transitionFrames)   // RVA 0x20DE830
public void ClearTransitionBlend()   // RVA 0x20DC1C0
public void ClearClipChannel(int channel)   // RVA 0x20DBF20
public void ClearAllClips()   // RVA 0x20DBBA0
public void InitCurrentModifiers(Frame frame, int channel)   // RVA 0x20DCDB0
public void InitPreviousModifiers(Frame frame, int channel)   // RVA 0x20DD0C0
public void DestroyModifiers(Frame frame)   // RVA 0x20DC330
private FP GetAnimationSpeedModifier(Frame frame, int channel, int currentFrame, bool previous = False)   // RVA 0x20DC5A0
private void ClearModifiers(Frame frame, int channel)   // RVA 0x20DC020
private void MigrateModifiers(Frame frame, int channel)   // RVA 0x20DD410
private void CheckForHighestWeight(FP runtimeWeight, int clipIndex, FP clipTime, ref FP highestWeight, ref int highestWeightClipIndex, ref FP highestWeightClipTime)   // RVA 0x20DBB80
internal void ClearAnimationFinishEvents(Frame frame)   // RVA 0x20DBDE0
```

### Quantum.DestroyEntitiesManager  (bases: IComponent; TypeDefIndex 9981)
Fields:
```
private Ptr EntitiesToDestroyPtr;  // 0x0
```
Methods:
```
public QListPtr<EntityRef> get_EntitiesToDestroy()   // RVA 0x20E0570
public void set_EntitiesToDestroy(QListPtr<EntityRef> value)   // RVA 0x93A640
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E0430
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20E0450
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E04D0
```

### Quantum.DynamicStageElement  (bases: IComponent; TypeDefIndex 9982)
Fields:
```
public QBoolean Active;  // 0x4
public QBoolean BackwardsMode;  // 0x8
public FP CurrentFrame;  // 0x18
public LoopMode LoopMode;  // 0x0
public AssetRefTransformKeyFramesData TransformKeyFramesData;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E08E0
public void OnInit(Frame frame, EntityRef entity)   // RVA 0x20E07A0
public void Update(Frame frame, EntityRef entity)   // RVA 0x20E0EC0
public void UpdateTrasfromKeyframeLoopMode(Frame frame, EntityRef entity, FP CurrentFrame, TransformKeyFramesData transformKeyFrames, KinematicBody* kinematicBody)   // RVA 0x20E0C30
public void UpdateCurrentFrame(Frame frame)   // RVA 0x20E0980
public void UpdateDynamicElementVelocity(Frame frame, int currentframe, TransformKeyFramesData transformKeyFrames, KinematicBody* kinematicBody, EntityRef entity)   // RVA 0x20E09F0
public static DynamicStageElement* GetComponent(Frame frame, CachedEntityData entityData)   // RVA 0x20E05B0
```

### Quantum.EdgeGrab  (bases: IComponent; TypeDefIndex 9983)
Fields:
```
public QBoolean Active;  // 0x4
public SimpleAABB CurrentRect;  // 0x40
public EntityRef EdgeEntity;  // 0x10
public EdgeGrabCondition EdgeGrabCondition;  // 0x0
public FP EdgeGrabCooldown;  // 0x20
public FPVector2 EdgeHook;  // 0x30
public EntityRef Entity;  // 0x18
public FP GrabConditionVelocity;  // 0x28
public QBoolean Interpolate;  // 0x8
public SimpleAABB PreviousRect;  // 0x60
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E16A0
internal void Initialize(Frame frame, EntityRef entity)   // RVA 0x20E1670
internal void StartEdgeGrab(Frame frame, EdgeGrabRequest edgeGrabRequest)   // RVA 0x20E17C0
internal void StopEdgeGrab(Frame frame)   // RVA 0x20E1940
internal FPVector2 GrabbedEdgePosition(Frame frame)   // RVA 0x20E1530
internal EdgeSide GrabbedEdgeSide(Frame frame)   // RVA 0x20E15E0
```

### Quantum.EndlessGameModeManager  (bases: IComponent; TypeDefIndex 9984)
Fields:
```
public FP DistanceRunned;  // 0x8
public QBoolean HasDialogue;  // 0x0
private Ptr PlataformsPtr;  // 0x4
public FP RandomPlataformIndex;  // 0x10
public FP SpawnedPlataforms;  // 0x18
```
Methods:
```
public QListPtr<EntityRef> get_Plataforms()   // RVA 0x20E1C50
public void set_Plataforms(QListPtr<EntityRef> value)   // RVA 0x526D50
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20CCF30
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20E1AF0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E1B70
```

### Quantum.EnergyBar  (bases: IComponent; TypeDefIndex 9985)
Fields:
```
public FP CurrentEnergy;  // 0x0
public FP MaxEnergy;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20A9200
public void AddEnergy(Frame frame, EntityRef entity, FP EnergyAmountToChange)   // RVA 0x20E1C90
```

### Quantum.EntityModifier  (bases: IComponent; TypeDefIndex 9986)
Fields:
```
public EntityRef Entity;  // 0x0
public EntityModifierInfo ModifierInfo;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CCDB0
```

### Quantum.EntityModifierTarget  (bases: IComponent; TypeDefIndex 9987)
Fields:
```
public EntityRef Entity;  // 0x8
public EntityModifierInfo EntityModifier;  // 0x10
private Ptr EntityModifiersPtr;  // 0x0
public PhysicsModifierInfo PhysicsModifier;  // 0x20
private Ptr PhysicsModifiersPtr;  // 0x4
```
Methods:
```
public QListPtr<EntityRef> get_EntityModifiers()   // RVA 0x20E2560
public void set_EntityModifiers(QListPtr<EntityRef> value)   // RVA 0x93A640
public QListPtr<EntityRef> get_PhysicsModifiers()   // RVA 0x20E25A0
public void set_PhysicsModifiers(QListPtr<EntityRef> value)   // RVA 0x526D50
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E1F00
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20E1F70
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E21D0
public void AddEntityModifier(Frame frame, EntityRef entityModifierEntity)   // RVA 0x20E1D20
public void RemoveEntityModifier(Frame frame, EntityRef entityModifierEntity)   // RVA 0x20E1FF0
public void AddPhysicsModifier(Frame frame, EntityRef physicsModifierEntity)   // RVA 0x20E1E10
public void RemovePhysicsModifier(Frame frame, EntityRef physicsModifierEntity)   // RVA 0x20E20E0
public void UpdateEntityModifierMultipliers(Frame frame, ref QList<EntityRef> entityModifiers)   // RVA 0x20E22E0
public void UpdatePhysicsMultipliers(Frame frame, ref QList<EntityRef> physicsModifiers)   // RVA 0x20E2410
```

### Quantum.EntityReferencesHandler  (bases: IComponent; TypeDefIndex 9988)
Fields:
```
private Ptr EntitiesPtr;  // 0x0
```
Methods:
```
public QListPtr<GameEntityReference> get_Entities()   // RVA 0x20E2740
public void set_Entities(QListPtr<GameEntityReference> value)   // RVA 0x93A640
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E0430
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20E2620
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E26A0
```

### Quantum.EscapeRoomGameModeManager  (bases: IComponent; TypeDefIndex 9989)
Fields:
```
public QBoolean CourseCompleted;  // 0x0
public FP CurrentCountdown;  // 0x10
public QString64 CurrentCourseID;  // 0x38
public FP CurrentMatchTimer;  // 0x18
public RaceState CurrentState;  // 0x8
public QBoolean HasDialogue;  // 0x4
public FP InitialDelayFrames;  // 0x20
public FP RemainingTimerFrames;  // 0x28
public FP TotalTimerFrames;  // 0x30
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E2810
```

### Quantum.EscapeRoomGoalTrigger  (bases: IComponent; TypeDefIndex 9990)
Fields:
```
public QString64 GoalID;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E2A60
public void OnBodyEnter(Frame frame, EntityRef otherEntity)   // RVA 0x20E2920
```

### Quantum.FrameByFrame  (bases: IComponent; TypeDefIndex 9991)
Fields:
```
public FP AdvanceFrameDelta;  // 0x8
public QBoolean AdvancingFrame;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E2AB0
```

### Quantum.FrogmanBossTongue  (bases: IComponent; TypeDefIndex 9992)
Fields:
```
public EntityRef Entity;  // 0x8
public FP FramesWithoutTarget;  // 0x18
public QBoolean Hooked;  // 0x0
public FPVector2 LastDirection;  // 0x28
public FP PullFramesCountdown;  // 0x20
public EntityRef TargetEntity;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E2B60
```

### Quantum.GameEntity  (bases: IComponent; TypeDefIndex 9993)
Fields:
```
public int ActiveEntityTint;  // 0x4
public int ActiveGameplayTint;  // 0x8
public int ActiveOverallTint;  // 0xC
public int ActiveStatusTint;  // 0x10
public int CostumeIndex;  // 0x14
public EntityRef Entity;  // 0x38
public GameEntityType EntityType;  // 0x0
public int FacingDirection;  // 0x18
public AssetRefGameEntityData GameEntityData;  // 0x30
public int ID;  // 0x1C
public EntityRef LastSpawned;  // 0x40
private Ptr ObjectsVisibilityPtr;  // 0x28
public EntityRef OriginalOwner;  // 0x48
public EntityRef Owner;  // 0x50
public FPVector3 Position3D;  // 0x88
public FP RootRotation;  // 0x58
public FP Rotation;  // 0x60
public FPQuaternion Rotation3D;  // 0xA0
public FPVector2 RotationPivot;  // 0x78
public FP Scale;  // 0x68
private Ptr SlotAttachmentsPtr;  // 0x2C
public FP SmoothRotationStart;  // 0x70
public QBoolean UseTransform3D;  // 0x20
public QBoolean Visible;  // 0x24
```
Methods:
```
public QListPtr<ObjectVisibilityData> get_ObjectsVisibility()   // RVA 0x20E3C10
public void set_ObjectsVisibility(QListPtr<ObjectVisibilityData> value)   // RVA 0x51AE50
public QListPtr<SlotAttachmentData> get_SlotAttachments()   // RVA 0x20E3C50
public void set_SlotAttachments(QListPtr<SlotAttachmentData> value)   // RVA 0x11DAC00
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E2BE0
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x20E32E0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E3360
public void Initialize(GameEntityData gameEntityData, EntityRef entity, GameEntityType entityType, HashString entityName)   // RVA 0x20E3150
public void Enable(Frame frame)   // RVA 0x20E2EA0
public void Disable(Frame frame)   // RVA 0x20E2E90
public void Update(Frame frame)   // RVA 0x20E3B90
private void UpdateActiveState(Frame frame, bool active)   // RVA 0x20E3870
public FP GetValue(GameEntityVariable variable)   // RVA 0x20E3030
public void SetValue(Frame frame, GameEntityVariable variable, FP value)   // RVA 0x20E3650
public void UpdateVisibility(Frame frame, bool visible)   // RVA 0x20E3B40
public void UpdateFacingDirection(Frame frame, GameEntity* gameEntity, int facingDirection)   // RVA 0x20E3AE0
public void InvertFacingDirection(Frame frame, GameEntity* gameEntity)   // RVA 0x20E31C0
public FPVector2 LocalToWorldPoint(FPVector2 position, FPVector2 point, bool ignoreScale = False)   // RVA 0x20E3230
public FPVector2 ConvertToRelativePoint(FPVector2 point, bool ignoreScale = False)   // RVA 0x20E2BF0
```

### Quantum.GameModeItemAutoTrigger  (bases: IComponent; TypeDefIndex 9994)
Fields:
```
public EntityRef Entity;  // 0x0
public QString64 ItemToUse;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E5310
public void Init(Frame frame, EntityRef entity)   // RVA 0x20E52A0
public void Activate(Frame frame)   // RVA 0x20E3EC0
public void ActivateHazardsRace(Frame frame, HazardSpawnDirection direction, HashString hazard)   // RVA 0x20E3C90
private bool FindVerticalSpawn(Frame frame, FPVector2 playerPosition, FPVector2 directionVector)   // RVA 0x20E4E40
private bool FindHorizontalSpawn(Frame frame, FPVector2 playerPosition, FPVector2 directionVector)   // RVA 0x20E4A10
private bool FindHazardSpawn(Frame frame, HazardSpawnDirection spawnSide, out EntityRef targetEntity)   // RVA 0x20E4390
```

### Quantum.GameTimeManager  (bases: IComponent; TypeDefIndex 9995)
Fields:
```
public FP GameSpeed;  // 0x8
public QBoolean Paused;  // 0x0
private Ptr SpeedModifiersPtr;  // 0x4
```
Methods:
```
public QListPtr<RuntimeGameSpeedModifier> get_SpeedModifiers()   // RVA 0x211A810
public void set_SpeedModifiers(QListPtr<RuntimeGameSpeedModifier> value)   // RVA 0x526D50
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20CCF30
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2119F90
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211A160
public static bool TryFind(Frame frame, out GameTimeManager* gameTimeManager)   // RVA 0x211A620
public static FP DeltaTime(Frame frame)   // RVA 0x2119EC0
public static FP UnscaledDeltaTime(Frame frame)   // RVA 0x211A7E0
public static void AddSpeedModifier(Frame frame, GameSpeedModifier speedModifier)   // RVA 0x21199F0
public static void RemoveSpeedModifier(Frame frame, int speedModifierID)   // RVA 0x211A010
private void CalculateGameSpeed(Frame frame)   // RVA 0x2119D60
public static void StartFrameByFrame(Frame frame)   // RVA 0x211A220
public static void StopFrameByFrame(Frame frame)   // RVA 0x211A470
public static void AdvanceFrameByFrame(Frame frame)   // RVA 0x2119BA0
```

### Quantum.GoldenHook  (bases: IComponent; TypeDefIndex 9996)
Fields:
```
public EntityRef Entity;  // 0x8
public FP FramesWithoutTarget;  // 0x18
public QBoolean Hooked;  // 0x0
public FPVector2 LastDirection;  // 0x28
public FP PullFramesCountdown;  // 0x20
public EntityRef TargetEntity;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E2B60
```

### Quantum.Grab  (bases: IComponent; TypeDefIndex 9997)
Fields:
```
public QBoolean Active;  // 0x14
public QBoolean CanBeGrabbed;  // 0x18
public QBoolean CanEscapeGrab;  // 0x1C
public EntityRef Entity;  // 0x38
public AssetRefGrabData GrabData;  // 0x30
public GrabDirection GrabDirection;  // 0x4
public FPVector3 GrabJointPosition;  // 0x68
public FPVector3 GrabJointRotation;  // 0x80
public GrabMode GrabMode;  // 0x8
public GrabState GrabState;  // 0xC
public QBoolean GrabbableOnlyByOwner;  // 0x20
public GrabbedAction GrabbedAction;  // 0x0
public EntityRef GrabbedEntity;  // 0x40
public EntityRef GrabberEntity;  // 0x48
public int JointID;  // 0x10
public FP RemainingFramesToEscape;  // 0x50
public QBoolean StrongThrow;  // 0x24
public QBoolean StrongUse;  // 0x28
public FPVector2 ThrowDirection;  // 0x58
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211AEC0
internal void Initialize(Frame frame, EntityRef entity, AssetRefGrabData grabData)   // RVA 0x211AD80
internal void Reset(Frame frame)   // RVA 0x211ADC0
internal FP GetValue(Frame frame, GrabVariable variable)   // RVA 0x211AC10
internal void SetValue(Frame frame, GrabVariable variable, FP value)   // RVA 0x211B090
internal void Update(Frame frame)   // RVA 0x211BAA0
internal void StartGrab(Frame frame, CombatSettingsData combatSettingsData, Grab* target)   // RVA 0x211B2B0
internal void StopGrab(Frame frame, bool doRebound = True)   // RVA 0x211B700
internal bool CanGrabEntity(Frame frame, CombatEntity target)   // RVA 0x211A8C0
```

### Quantum.HazardsRaceGameModeManager  (bases: IComponent; TypeDefIndex 9998)
Fields:
```
public FP AmountOfHazardsToSpawn;  // 0x10
public FP CurrentHazardsTimer;  // 0x18
private Ptr HazardSpawnAreaListPtr;  // 0xC
public QBoolean HazardsWarningActive;  // 0x4
public FP HazardsWarningTimer;  // 0x20
public FP ItemSpawnCooldown;  // 0x28
public FP RandomHazardIndex;  // 0x30
public HazardSpawnDirection SpawnDirection;  // 0x0
public QBoolean SpawnDirectionSet;  // 0x8
```
Methods:
```
public QListPtr<EntityRef> get_HazardSpawnAreaList()   // RVA 0x211C6D0
public void set_HazardSpawnAreaList(QListPtr<EntityRef> value)   // RVA 0x1ED2120
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20C9B80
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x211C510
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211C590
```

### Quantum.InitialWaitTimer  (bases: IComponent; TypeDefIndex 9999)
Fields:
```
public FP RemainingTimerFrames;  // 0x8
public InitialWaitTimerState State;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211C740
```

### Quantum.InputBuffer  (bases: IComponent; TypeDefIndex 10001)
Fields:
```
public QBoolean Active;  // 0x10
private InputBuffer.<_BufferHistory_>e__FixedBuffer _BufferHistory_;  // 0x48
public int BufferHistorySize;  // 0x8
public ButtonTimersContainer ButtonTimersContainer;  // 0x7C8
public InputFlag CurrentInput;  // 0x0
public AssetRefInputCheck_Behaviour CurrentInputCheckbehaviour;  // 0x18
public FP CurrentLeftStickX;  // 0x28
public FP CurrentLeftStickY;  // 0x30
public EntityRef Entity;  // 0x20
public int LastHistoryElementIndex;  // 0xC
public InputFlag PreviousInput;  // 0x4
public FP PreviousLeftStickX;  // 0x38
public FP PreviousLeftStickY;  // 0x40
```
Methods:
```
public FixedArray<InputValue> get_BufferHistory()   // RVA 0x211EFB0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211D840
internal void Enable()   // RVA 0x211CA20
internal void Disable()   // RVA 0x211C9E0
internal FP NormalizedLeftStickX(Frame frame)   // RVA 0x211D530
internal FP NormalizedLeftStickY(Frame frame)   // RVA 0x211D5F0
internal FP NormalizedLeftStickForward(Frame frame)   // RVA 0x211D410
internal FP NormalizedLeftStickBack(Frame frame)   // RVA 0x211D2F0
internal FP LeftStickBack(Frame frame)   // RVA 0x211D0F0
internal FP CalculateReferenceStickValue(ImpulseStickInfluence influenceType, FP referenceValue)   // RVA 0x211C7C0
internal bool IsButtonJustPressed(InputFlag inputFlag)   // RVA 0x211D010
internal bool IsButtonJustReleased(InputFlag inputFlag)   // RVA 0x211D050
internal bool IsButtonHold(InputFlag inputFlag)   // RVA 0x211CFD0
internal bool IsDirectionJustPressed(InputDirection direction, bool invertX)   // RVA 0x211D090
internal bool WasButtonJustPressed(InputFlag inputFlag, out int outEventIndex, int startFrame = -1, int framesToCheck = 1, bool spendAction = True)   // RVA 0x211E4D0
internal bool WasButtonJustReleased(InputFlag inputFlag, out int outEventIndex, int startFrame = -1, int framesToCheck = 1, bool spendAction = True)   // RVA 0x211E630
internal bool WasButtonHeld(InputFlag inputFlag, out int outEventIndex, int startFrame = -1, int framesToCheck = 1)   // RVA 0x211E410
internal bool WasDirectionJustPressed(InputDirection direction, out int outEventIndex, FP deadzone, FP detectionThreshold, FP minAngle, FP maxAngle, bool invertX, int startFrame = -1, int framesToCheck = 1, bool spendAction = True)   // RVA 0x211E950
internal bool WasDirectionJustReleased(InputDirection direction, out int outEventIndex, FP deadzone, FP detectionThreshold, FP minAngle, FP maxAngle, bool invertX, int startFrame = -1, int framesToCheck = 1, bool spendAction = True)   // RVA 0x211ECE0
internal bool WasDirectionHold(InputDirection direction, FP deadzone, FP detectionThreshold, FP minAngle, FP maxAngle, bool invertX, int startFrame = -1, int framesToCheck = 1)   // RVA 0x211E790
internal void UpdateCurrentInput(InputFlag inputFlag, FP leftStickX, FP leftStickY, FPVector2 stickMinValues, FPVector2 stickMaxValues)   // RVA 0x211DE10
internal void SaveCurrentInputInBuffer()   // RVA 0x211D700
internal void SpendAction(InputFlag inputFlag, int index)   // RVA 0x211DB70
internal void SpendDirection(InputDirection direction, int index)   // RVA 0x211DBF0
internal bool TryGetFromBuffer(int elementIndex, out InputValue* inputValue)   // RVA 0x211DD20
internal void SetInBuffer(int elementIndex, InputValue inputValue)   // RVA 0x211DA90
internal void ClearBuffer()   // RVA 0x211C7F0
private int NormalizedIndex(int elementIndex)   // RVA 0x211D180
private FP StickFromByteToFloat(FP stickValue, FP stickMinValue, FP stickMaxValue)   // RVA 0x211DCA0
private FP NormalizedStick(FP stickValue, FP stickMinValue, FP stickMaxValue)   // RVA 0x211D6B0
private int GetFramesSinceButtonPress(InputFlag input)   // RVA 0x211CA40
private int GetFramesSinceButtonRelease(InputFlag input)   // RVA 0x211CAF0
private int GetFramesSinceDirectionPress(InputDirection direction, bool invertX)   // RVA 0x211CBA0
private int GetFramesSinceDirectionRelease(InputDirection direction, bool invertX)   // RVA 0x211CCE0
```

### Quantum.ItemAutoTrigger  (bases: IComponent; TypeDefIndex 10002)
Fields:
```
public EntityRef Entity;  // 0x8
public QString64 ItemToUse;  // 0x18
public FP RemainingFramesToUseItem;  // 0x10
public int UseFramesInterval;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211F100
public void Init(Frame frame, EntityRef entity)   // RVA 0x211F080
public void Update(Frame frame)   // RVA 0x211F190
```

### Quantum.ItemBox  (bases: IComponent; TypeDefIndex 10003)
Fields:
```
public QString64 ForcedItem;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E2A60
```

### Quantum.Jump  (bases: IComponent; TypeDefIndex 10004)
Fields:
```
public JumpType ActiveJump;  // 0x4
public QBoolean DoShortJump;  // 0x8
public EntityRef Entity;  // 0x20
public int JumpAnticipationFrames;  // 0x0
public AssetRefJumpSettingsData JumpData;  // 0x18
public FP JumpImpulseFrames;  // 0x28
public FPVector2 JumpImpulseVelocity;  // 0x30
public QBoolean OnWallSlide;  // 0xC
public FPVector2 ReferenceLeftStick;  // 0x40
public QBoolean TouchingBackWall;  // 0x10
public QBoolean TouchingFrontWall;  // 0x14
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211F5B0
public void Reset(Frame frame)   // RVA 0x211F500
public FP GetGravityMultiplier(Frame frame)   // RVA 0x211F350
public void StartJump(Frame frame, CachedEntityData entityData, JumpType jumpType)   // RVA 0x211F6D0
public void UpdateJump(Frame frame, CachedEntityData entityData, FP velocityMultiplier)   // RVA 0x211FD50
public void StopJump(Frame frame, PhysicsBody* physicsBody, bool preventVelocityInheritance = False)   // RVA 0x211FB20
```

### Quantum.KinematicBody  (bases: IComponent; TypeDefIndex 10005)
Fields:
```
public QBoolean Active;  // 0x0
public FPVector2 Velocity;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x211FFC0
public FP GetValue(KinematicBodyVariable variable)   // RVA 0x211FF80
public void SetValue(KinematicBodyVariable variable, FP value)   // RVA 0x2120000
```

### Quantum.Laser  (bases: IComponent; TypeDefIndex 10006)
Fields:
```
public FP InitialRotation;  // 0x8
public LaserDirection RotationDirection;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x21200E0
```

### Quantum.LayoutManager  (bases: IComponent; TypeDefIndex 10007)
Fields:
```
private Ptr StageEntitiesPtr;  // 0x0
```
Methods:
```
public QListPtr<StageEntity> get_StageEntities()   // RVA 0x2120530
public void set_StageEntities(QListPtr<StageEntity> value)   // RVA 0x93A640
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E0430
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2120410
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2120490
public void OnInit(Frame frame, EntityRef entity)   // RVA 0x2120170
```

### Quantum.MatchTimer  (bases: IComponent; TypeDefIndex 10008)
Fields:
```
public QBoolean Active;  // 0x0
public FP CurrentTime;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20E2AB0
public static bool TryFind(Frame frame, out MatchTimer* matchTimer)   // RVA 0x21205A0
public void Update(Frame frame)   // RVA 0x21206F0
```

### Quantum.MechanicTutorialGameModeManager  (bases: IComponent; TypeDefIndex 10009)
Fields:
```
private Ptr GoalsPtr;  // 0x8
public FP RemainingTimerFrames;  // 0x10
public QBoolean SectionCompleted;  // 0x4
public int SectionIndex;  // 0x0
public FP TotalTimerFrames;  // 0x18
```
Methods:
```
public QListPtr<RuntimeMechanicTutorialGoal> get_Goals()   // RVA 0x21209C0
public void set_Goals(QListPtr<RuntimeMechanicTutorialGoal> value)   // RVA 0x1ED2130
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x21207D0
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2120840
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x21208C0
```

### Quantum.MechanicTutorialGoalTrigger  (bases: IComponent; TypeDefIndex 10010)
Fields:
```
public QString64 GoalID;  // 0x20
public FP RequiredHorizontalVelocity;  // 0x8
public QString64 RequiredPreviousState;  // 0x60
public QString64 RequiredState;  // 0xA0
public FP RequiredTotalVelocity;  // 0x10
public FP RequiredVerticalVelocity;  // 0x18
public QBoolean UseAbsoluteHorizontal;  // 0x0
public QBoolean UseAbsoluteVertical;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2120E00
public void OnBodyEnter(Frame frame, EntityRef otherEntity)   // RVA 0x2120A90
```

### Quantum.Movable  (bases: IComponent; TypeDefIndex 10011)
Fields:
```
public FPVector2 PreviousPosition;  // 0x8
public QBoolean Teleported;  // 0x0
public QBoolean TeleportedFlag;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2120ED0
```

### Quantum.MovesetLimiter  (bases: IComponent; TypeDefIndex 10012)
Fields:
```
private Ptr AvailableMovesPtr;  // 0x0
public AssetRefMovesetLimiterData MovesetLimiterData;  // 0x8
```
Methods:
```
public QDictionaryPtr<int, MoveLimit> get_AvailableMoves()   // RVA 0x2121400
public void set_AvailableMoves(QDictionaryPtr<int, MoveLimit> value)   // RVA 0x93A640
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E0430
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2121030
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2121270
public void Reset(Frame frame, MovesetLimiterResetContext resetContext = 0)   // RVA 0x21210B0
public void UpdateMoveUses(Frame frame, int moveHash, int value)   // RVA 0x2121330
public int GetMoveUses(Frame frame, int moveHash)   // RVA 0x2120F50
```

### Quantum.NonDeterministicAnimation  (bases: IComponent; TypeDefIndex 10013)
Fields:
```
public QString128 AnimationTrigger;  // 0x4
public StageExecutionMode ExecutionMode;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x21214F0
public void PlayAnimation(Frame frame, EntityRef entityRef)   // RVA 0x2121470
```

### Quantum.ParentObject  (bases: IComponent; TypeDefIndex 10014)
Fields:
```
private Ptr ChildEntitiesPtr;  // 0x0
public EntityRef ParentEntity;  // 0x8
```
Methods:
```
public QListPtr<ChildEntity> get_ChildEntities()   // RVA 0x2121AD0
public void set_ChildEntities(QListPtr<ChildEntity> value)   // RVA 0x93A640
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E0430
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2121710
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2121790
public void OnInit(Frame frame, EntityRef entity)   // RVA 0x2121590
public void Update(Frame frame, EntityRef entity)   // RVA 0x2121840
```

### Quantum.PartnersManager  (bases: IComponent; TypeDefIndex 10015)
Fields:
```
private Ptr CharacterEntitiesPtr;  // 0x8
public QBoolean CharacterSwapAllowed;  // 0x4
public FP CharacterSwapCooldown;  // 0x10
public int CurrentCharacterIndex;  // 0x0
```
Methods:
```
public QListPtr<EntityRef> get_CharacterEntities()   // RVA 0x2121DC0
public void set_CharacterEntities(QListPtr<EntityRef> value)   // RVA 0x1ED2130
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x21207D0
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2121B60
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2121BE0
public static bool TryFind(Frame frame, EntityRef characterEntityRef, out PartnersManager* partnersManager, out EntityRef entityRef)   // RVA 0x2121CD0
public void Update(Frame frame)   // RVA 0x2121D60
```

### Quantum.PersistentEntity  (bases: IComponent; TypeDefIndex 10017)
Fields:
```
private PersistentEntity.<_alignment_padding_>e__FixedBuffer _alignment_padding_;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x4F3940
```

### Quantum.PhysicsBody  (bases: IComponent; TypeDefIndex 10018)
Fields:
```
public QBoolean Active;  // 0x10
public QBoolean BounceEnabled;  // 0x14
public FPVector2 BounceNormal;  // 0xC8
public QBoolean CanEnterGroundedState;  // 0x18
public QBoolean CanFallThrough;  // 0x1C
public QBoolean CanLeaveEdges;  // 0x20
public QBoolean CapKnockbackVelocity;  // 0x24
public EntityRef CeilingEntity;  // 0x88
public int CeilingLayerIndex;  // 0x0
public FPVector2 CeilingNormal;  // 0xD8
public SlideDirection CeilingSlideDirection;  // 0x68
public QBoolean CorrectionEnabled;  // 0x28
public AssetRefApplyImpulse_Behaviour CurrentImpulseBehaviour;  // 0x78
public AssetRefPhysicsData DefaultPhysicsData;  // 0x80
public QBoolean DetectBlastzones;  // 0x2C
public QBoolean DetectTopBlastzone;  // 0x30
public EnvironmentCollisionBox ECB;  // 0x1A8
public EntityRef Entity;  // 0x90
public FPVector2 ExternalVelocity;  // 0xE8
public QBoolean ForceSnapToGround;  // 0x34
public FP FramesInAir;  // 0xB0
public FPVector2 GlobalVelocity;  // 0xF8
public EntityRef GroundEntity;  // 0x98
public int GroundLayerIndex;  // 0x4
public FPVector2 GroundNormal;  // 0x108
public QBoolean Grounded;  // 0x38
public FP IgnoreThinPlatformFrames;  // 0xB8
public QBoolean IgnoreThinPlatforms;  // 0x3C
public FP ImpulseFrames;  // 0xC0
public FPVector2 ImpulseVelocity;  // 0x118
public QBoolean InBlastzone;  // 0x40
public WallSnapDirection InitialWallSnapDirection;  // 0x70
public FPVector2 InitialWallSnapPoint;  // 0x128
public FPVector2 KnockbackVelocity;  // 0x138
public EntityRef LeftWallEntity;  // 0xA0
public int LeftWallLayerIndex;  // 0x8
public FPVector2 LeftWallNormal;  // 0x148
public QBoolean OnCeiling;  // 0x44
public QBoolean OnFloor;  // 0x48
public QBoolean OnLeftWall;  // 0x4C
public QBoolean OnRightWall;  // 0x50
public FPVector2 PreviousGroundNormal;  // 0x158
public FPVector2 ReferenceLeftStick;  // 0x168
public EntityRef RightWallEntity;  // 0xA8
public int RightWallLayerIndex;  // 0xC
public FPVector2 RightWallNormal;  // 0x178
public RuntimePhysics RuntimePhysics;  // 0x280
public QBoolean SetGroundedOnlyWhenGoingDown;  // 0x54
public QBoolean SlideOnCeiling;  // 0x58
public QBoolean SlideOnGround;  // 0x5C
public QBoolean SlideOnWalls;  // 0x60
public QBoolean SnapToWall;  // 0x64
public FPVector2 TargetVelocity;  // 0x188
public FPVector2 Velocity;  // 0x198
public SlideDirection WallSlideDirection;  // 0x6C
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x21258B0
internal FPVector2 GetUnnormalizedSurfaceNormal(Frame frame, FPVector2 surfaceNormal)   // RVA 0x2122990
internal void Initialize(Frame frame, EntityRef entity, AssetRefPhysicsData physicsData)   // RVA 0x2123070
internal void Enable()   // RVA 0x2122550
internal void Disable()   // RVA 0x21223C0
internal FPVector2 GetVelocity()   // RVA 0x2123060
internal void AddVelocity(Frame frame, FPVector2 velocityToAdd)   // RVA 0x2121E90
internal void AddVelocityX(Frame frame, FP velocityToAdd)   // RVA 0x2121E30
internal void AddVelocityY(Frame frame, FP velocityToAdd)   // RVA 0x2121E40
internal void MultiplyVelocity(Frame frame, FP velocityMultiplier)   // RVA 0x21231B0
internal void MultiplyVelocityX(Frame frame, FP velocityMultiplier)   // RVA 0x2123130
internal void MultiplyVelocityY(Frame frame, FP velocityMultiplier)   // RVA 0x2123150
internal void SetVelocity(Frame frame, FPVector2 newVelocity)   // RVA 0x2126770
internal void SetVelocityX(Frame frame, FP newVelocityX)   // RVA 0x2126710
internal void SetVelocityY(Frame frame, FP newVelocityY)   // RVA 0x2126720
internal void ClampVelocityX(FP maxVelocity)   // RVA 0x2122360
internal void ClampVelocityY(FP maxVelocity)   // RVA 0x2122390
internal FPVector2 GetKnockbackVelocity()   // RVA 0x6A39E0
internal void SetKnockbackVelocity(Frame frame, FPVector2 newKnockbackVelocity)   // RVA 0x2125FA0
internal void SetKnockbackVelocityX(Frame frame, FP newVelocityX)   // RVA 0x2125F40
internal void SetKnockbackVelocityY(Frame frame, FP newVelocityY)   // RVA 0x2125F50
internal void ClampKnockbackVelocityX(FP maxVelocity)   // RVA 0x2122300
internal void ClampKnockbackVelocityY(FP maxVelocity)   // RVA 0x2122330
internal void AddExternalForceX(Frame frame, FP xForce)   // RVA 0x2121E10
internal void AddExternalForceY(Frame frame, FP xForce)   // RVA 0x2121E20
internal FPVector2 GetImpulseVelocity()   // RVA 0x21228A0
internal FP GetValue(Frame frame, PhysicsBodyVariable variable)   // RVA 0x2122A90
internal void SetValue(Frame frame, PhysicsBodyVariable variable, FP value)   // RVA 0x21260A0
internal void StartWallSnap(Frame frame, FPVector2 currentPosition)   // RVA 0x2126BE0
public bool IsOverThinPlatform(Frame frame)   // RVA 0x21230E0
internal void StartLaunch(Frame frame, PhysicsBody* physicsBody, FPVector2 direction)   // RVA 0x2126A40
internal bool TryGetFloorSurfaceType(Frame frame, out SurfaceType surfaceType)   // RVA 0x21270A0
internal void Bounce(Frame frame, FP restitution, LinecastHitInfo linecastHitInfo)   // RVA 0x2121F00
internal void StartImpulse(Frame frame, AssetRefApplyImpulse_Behaviour impulseBehaviour, CachedEntityData entityData)   // RVA 0x21267D0
internal void UpdateImpulse(Frame frame, CachedEntityData entityData, FP velocityMultiplier)   // RVA 0x2127140
internal void StopImpulse(Frame frame, bool preventVelocityInheritance = False)   // RVA 0x2126EE0
internal void UpdateImpulses(Frame frame, FP velocityMultiplier)   // RVA 0x2127310
internal void StopImpulses(Frame frame, PhysicsBody* physicsBody, bool preventVelocityInheritance = False)   // RVA 0x2127030
internal void LeaveGround(Frame frame)   // RVA 0x2123100
internal void UseGroundRotation(Frame frame, GameEntity* gameEntity, bool force = False)   // RVA 0x21274C0
internal bool CanApplyMovement(Frame frame)   // RVA 0x2122190
internal bool CanStandOnThinPlatform(PhysicsData physicsData, Transform2D* transform, FP hitPointY)   // RVA 0x2122230
public FPVector2 GetTotalVelocity(Frame frame)   // RVA 0x21228B0
internal void SetGroundNormal(Frame frame, FPVector2 normal)   // RVA 0x2125D40
private void OnSetGroundNormal(Frame frame, FPVector2 previousNormal)   // RVA 0x2124730
internal void SetCeilingNormal(Frame frame, FPVector2 normal)   // RVA 0x2125D10
private void OnSetCeilingNormal(Frame frame, FPVector2 previousNormal)   // RVA 0x2124040
internal void SetLeftWallNormal(Frame frame, FPVector2 normal)   // RVA 0x2126000
private void OnSetLeftWallNormal(Frame frame, FPVector2 previousNormal)   // RVA 0x2124B20
internal void SetRightWallNormal(Frame frame, FPVector2 normal)   // RVA 0x2126050
private void OnSetRightWallNormal(Frame frame, FPVector2 previousNormal)   // RVA 0x2124B70
internal void OnLeaveFloor(Frame frame)   // RVA 0x2123C80
private void OnLeaveFloorEvent(Frame frame)   // RVA 0x4F3940
internal void OnLeaveCeiling(Frame frame)   // RVA 0x2123BC0
internal void OnLeaveLeftWall(Frame frame)   // RVA 0x2123E50
internal void OnLeaveRightWall(Frame frame)   // RVA 0x2123F20
internal void OnTouchFloor(Frame frame, Transform2D* transform, LinecastHitInfo linecastHitInfo, bool fromBounceFailed = False)   // RVA 0x2124E20
private void OnTouchFloorEvent(Frame frame, Transform2D* transform, LinecastHitInfo linecastHitInfo)   // RVA 0x2124DB0
private void OnEnterGroundedState(Frame frame)   // RVA 0x21233F0
internal void OnTouchCeiling(Frame frame, LinecastHitInfo linecastHitInfo)   // RVA 0x2124BC0
internal void OnTouchLeftWall(Frame frame, LinecastHitInfo linecastHitInfo)   // RVA 0x2125230
internal void OnTouchRightWall(Frame frame, LinecastHitInfo linecastHitInfo)   // RVA 0x2125420
internal void OnReachLedge(Frame frame)   // RVA 0x2123FF0
internal void OnEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, bool forced = False)   // RVA 0x2123220
internal void ResetRuntimePhysics(Frame frame)   // RVA 0x2125670
private void ResetGroundVariables(Frame frame)   // RVA 0x2125610
```

### Quantum.PhysicsModifier  (bases: IComponent; TypeDefIndex 10019)
Fields:
```
public EntityRef Entity;  // 0x0
public PhysicsModifierInfo ModifierInfo;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2127670
```

### Quantum.PlatformFightGameModeManager  (bases: IComponent; TypeDefIndex 10020)
Fields:
```
public FP CurrentCountdown;  // 0x8
public PlatformFightState CurrentState;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x21276E0
```

### Quantum.PlayerManager  (bases: IComponent; TypeDefIndex 10021)
Fields:
```
public QBoolean IsNPC;  // 0x8
public int NPCID;  // 0x0
public PlayerRef PlayerRef;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2127950
public static void Create(Frame frame, PlayerRef playerRef)   // RVA 0x2127760
public static void Create(Frame frame, int npcID)   // RVA 0x21277F0
public static bool TryFind(Frame frame, string playerID, out PlayerManager* playerManager, out EntityRef entityRef)   // RVA 0x2127FB0
public static bool TryFind(Frame frame, PlayerRef playerRef, out PlayerManager* playerManager, out EntityRef entityRef)   // RVA 0x2127E00
public static bool TryFind(Frame frame, int npcID, out PlayerManager* playerManager, out EntityRef entityRef)   // RVA 0x21279E0
public static bool TryFind(Frame frame, EntityRef characterEntity, out PlayerManager* playerManager, out EntityRef entityRef)   // RVA 0x2127B80
public string GetPlayerID()   // RVA 0x21278D0
```

### Quantum.PlayerStats  (bases: IComponent; TypeDefIndex 10023)
Fields:
```
public FP AliveTimer;  // 0x48
public FP BigAirCooldownFrames;  // 0x50
public FP BigAirFrames;  // 0x58
public int BombsHit;  // 0x0
public int CratesHit;  // 0x4
public EntityRef Entity;  // 0x40
private Ptr ExperienceEventDataListPtr;  // 0x34
public int FireBallsHit;  // 0x8
public int FreezeRaysHit;  // 0xC
public int GoldenHooksHit;  // 0x10
private Ptr HitHistoryPtr;  // 0x38
public int InvinciDrillsHit;  // 0x14
public QBoolean IsNPC;  // 0x28
public int RegisteredGrappleSwingsInAir;  // 0x18
public int RocketsHit;  // 0x1C
public int RoundsWon;  // 0x20
public int ShockWavesHit;  // 0x24
public FP StillAliveCurrentTimer;  // 0x60
public FP StillAliveMargin;  // 0x68
public FP StillAliveTimer;  // 0x70
public FP SuperSpeedCooldownFrames;  // 0x78
public QBoolean TriggeredBigAir;  // 0x2C
public QBoolean TriggeredFloorIsLava;  // 0x30
```
Methods:
```
public QListPtr<ExperienceEventData> get_ExperienceEventDataList()   // RVA 0x212B250
public void set_ExperienceEventDataList(QListPtr<ExperienceEventData> value)   // RVA 0x5061F0
public QListPtr<HitEvent> get_HitHistory()   // RVA 0x212B290
public void set_HitHistory(QListPtr<HitEvent> value)   // RVA 0x8757D0
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x2128A70
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2129930
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2129D00
public void Update(Frame frame)   // RVA 0x212B180
public void NotifyAcoladeVFX(Frame frame, int vfxID)   // RVA 0x21298B0
public void AliveCounter(Frame frame)   // RVA 0x21284B0
public void DodgeEvent(Frame frame)   // RVA 0x2128D40
public void SuperSpeedEvent(Frame frame)   // RVA 0x212A9A0
public void AddHurtEvent(Frame frame, HitType hitType, EntityRef attackOwner)   // RVA 0x21281C0
public void RevengeEvent(Frame frame, HitType hitType, EntityRef damagedEntity)   // RVA 0x21299B0
public void HitEvent(Frame frame, HitType hitType, EntityRef damagedEntity)   // RVA 0x2129500
public void DoubleCombo(Frame frame)   // RVA 0x2128F00
public void TripleCombo(Frame frame)   // RVA 0x212AF20
public void DeflectedEvent(Frame frame)   // RVA 0x2128A80
public void BlockEvent(Frame frame)   // RVA 0x2128520
public void TauntEvent(Frame frame)   // RVA 0x212ABA0
public void TreasureEvent(Frame frame)   // RVA 0x212AD00
public void CheckAirAccolades(Frame frame)   // RVA 0x21286E0
public int GetExperienceEventIndex(Frame frame, int ID)   // RVA 0x21290C0
public void StayAliveEvent(Frame frame)   // RVA 0x212A010
private FP DistanceToLine(FPVector2 point, FPVector2 lineStart, FPVector2 lineEnd)   // RVA 0x2128C50
```

### Quantum.RaceGameModeManager  (bases: IComponent; TypeDefIndex 10024)
Fields:
```
public FP CurrentCountdown;  // 0x8
public FP CurrentMatchTimer;  // 0x10
public RaceState CurrentState;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B320
```

### Quantum.RaceTutorialGameModeManager  (bases: IComponent; TypeDefIndex 10025)
Fields:
```
public QBoolean DisplayedSuddenDeathPrompt;  // 0x4
public int HighestLap;  // 0x0
public QBoolean IsInitialSection;  // 0x8
public QBoolean IsSuddenDeathPromptVisible;  // 0xC
public QBoolean StartedFirstLap;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B400
```

### Quantum.RespawnPoint  (bases: IComponent; TypeDefIndex 10026)
Fields:
```
public RespawnDirection Direction;  // 0x4
public QBoolean IsInitial;  // 0x0
public EntityRef NextCheckPoint;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B4C0
```

### Quantum.Rocket  (bases: IComponent; TypeDefIndex 10027)
Fields:
```
public EntityRef Entity;  // 0x0
public FP InterpolationSpeed;  // 0x10
public FP ReCheckTargetFrames;  // 0x18
public EntityRef Target;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B620
```

### Quantum.RocketLauncher  (bases: IComponent; TypeDefIndex 10028)
Fields:
```
public FP ShootCooldownFrames;  // 0x8
public EntityRef Target;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B580
```

### Quantum.RoomMember  (bases: IComponent; TypeDefIndex 10029)
Fields:
```
public EntityRef ParentRoom;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C8600
```

### Quantum.SecretRoomTrigger  (bases: IComponent; TypeDefIndex 10031)
Fields:
```
private SecretRoomTrigger.<_alignment_padding_>e__FixedBuffer _alignment_padding_;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x4F3940
```

### Quantum.Shockwave  (bases: IComponent; TypeDefIndex 10032)
Fields:
```
public EntityRef Entity;  // 0x0
public FPVector2 InitialPosition;  // 0x10
public FP Power;  // 0x8
public FPVector2 TargetPosition;  // 0x20
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B710
```

### Quantum.SimpleLineRenderer  (bases: IComponent; TypeDefIndex 10033)
Fields:
```
public EntityRef Entity;  // 0x10
public FPVector2 PointA;  // 0x18
public SimpleLineEndRotationMode PointARotationMode;  // 0x4
public FPVector2 PointB;  // 0x28
public SimpleLineEndRotationMode PointBRotationMode;  // 0x8
public QBoolean Visible;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B7D0
```

### Quantum.SpawnPoint  (bases: IComponent; TypeDefIndex 10034)
Fields:
```
public SpawnPointDirection FacingDirection;  // 0x4
public QString128 ID;  // 0x18
public int Order;  // 0x0
public FPVector2 Position;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212B8F0
```

### Quantum.SpeedRunnersBlastzone  (bases: IComponent; TypeDefIndex 10035)
Fields:
```
public QBoolean Active;  // 0x0
public QBoolean IsInSuddenDeath;  // 0x4
public FP SuddenDeathMultiplier;  // 0x10
public FP TimeToStartSuddenDeath;  // 0x18
public QBoolean TimerSuddenDeath;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212BFC0
public static bool TryFind(Frame frame, out SpeedRunnersBlastzone* speedRunnersBlastzone)   // RVA 0x212C170
public void Initialize(Frame frame)   // RVA 0x212BAC0
public void UpdateBlastzone(Frame frame)   // RVA 0x212C2C0
private void ReduceBlastzone(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData, CameraManager* cameraManager)   // RVA 0x212BBE0
public void UpdateSuddenDeathMultiplier(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData)   // RVA 0x212C640
public FP GetSuddenDeathMultiplier(Frame frame)   // RVA 0x212BA60
public void ResetBlastzone(Frame frame)   // RVA 0x212BD60
private void ResetData(Frame frame)   // RVA 0x212BF40
public void StartSuddenDeath(Frame frame, bool fromTime = False)   // RVA 0x212C030
public void Disable(Frame frame)   // RVA 0x212B990
```

### Quantum.SpeedRunnersCharacter  (bases: IComponent; TypeDefIndex 10036)
Fields:
```
public QBoolean Alive;  // 0x1C
public QBoolean AutoUseItemOnFullCharge;  // 0x20
public FP Boost;  // 0x98
public FP BoostCountdownFrames;  // 0xA0
public FP CaterpillarWindowFrames;  // 0xA8
public QBoolean ClearAirJump;  // 0x24
public FP CurrentJumpFrames;  // 0xB0
public FP DistanceToFinish;  // 0xB8
public FP DistanceTraveled;  // 0xC0
public QBoolean EnteredCheckpointGoingBackward;  // 0x28
public QBoolean EnteredCheckpointGoingForward;  // 0x2C
public EntityRef Entity;  // 0x80
public int EquipedItemID;  // 0x0
public int FacingDirectionOnItemUse;  // 0x4
public QBoolean FlyModeEnabled;  // 0x30
public FP FramesInBlastzone;  // 0xC8
public FP FreezeFrames;  // 0xD0
public QBoolean HasInfiniteBoost;  // 0x34
public QBoolean HasPowerfulTackle;  // 0x38
public QBoolean HasSuperSpeed;  // 0x3C
public FP HookCooldownFrames;  // 0xD8
public FP HookHitDistance;  // 0xE0
public FPVector2 HookHitPoint;  // 0x160
public QBoolean IgnoreSlideMinVelocity;  // 0x40
public FP InviciDrillFrames;  // 0xE8
public QBoolean IsBoostActive;  // 0x44
public QBoolean IsBoostAlwaysActive;  // 0x48
public QBoolean IsInSuperBoost;  // 0x4C
public QBoolean IsInWallSlide;  // 0x50
public QBoolean IsJumping;  // 0x54
public QBoolean IsRunningBackwards;  // 0x58
public QBoolean IsSliding;  // 0x5C
public QBoolean IsSteppingOverLedge;  // 0x60
public FP ItemPowerCharged;  // 0xF0
public FP ItemPowerIncrease;  // 0xF8
public FP ItemUseActiveFrames;  // 0x100
public FP ItemUseCooldownFrames;  // 0x108
public ItemButtonUseMode ItemUseMode;  // 0x18
public int ItemUses;  // 0x8
public FPVector2 JumpDirection;  // 0x170
public FP JumpDuration;  // 0x110
public FP JumpPower;  // 0x118
public FPVector2 JumpVelocity;  // 0x180
public FPVector2 JumpVelocityBonus;  // 0x190
public int Laps;  // 0xC
public FPVector2 LastHookPosition;  // 0x1A0
public QBoolean LastIntangibility;  // 0x64
public int LastItemUsed;  // 0x10
public EntityRef LastSuperBoostEntity;  // 0x88
public FPVector2 LastValidDirectionForItem;  // 0x1B0
public QBoolean PulledByHook;  // 0x68
public int Rank;  // 0x14
public FP RunningBackwardsTime;  // 0x120
public FP SlideCooldownFrames;  // 0x128
public QBoolean SlideLocked;  // 0x6C
public FP SlopeSurfNotificationCooldown;  // 0x130
public FP SteppingOverLedgeFrames;  // 0x138
public FPVector2 SteppingTargetPosition;  // 0x1C0
public FP SuperBoostCountdownFrames;  // 0x140
public SuperBoostDirection SuperBoostDirection;  // 0x78
public EntityRef TargetCheckpoint;  // 0x90
public FP TimeSinceDeath;  // 0x148
public QBoolean TriggeredInstantJump;  // 0x70
public QBoolean UsingSR1Physics;  // 0x74
public FP WallHangCountdownFrames;  // 0x150
public FP WallSlideCooldownFrames;  // 0x158
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212D720
public bool get_WasJustBoosting()   // RVA 0x212EA70
public void set_WasJustBoosting(bool value)   // RVA 0x212EAB0
public bool get_WasJustHanging()   // RVA 0x212EA90
public void set_WasJustHanging(bool value)   // RVA 0x212EAD0
internal bool IsFrozen(Frame frame)   // RVA 0x212D250
internal FP GetValue(Frame frame, SpeedRunnersCharacterVariable variable)   // RVA 0x212CD80
internal void SetValue(Frame frame, SpeedRunnersCharacterVariable variable, FP value)   // RVA 0x212DCD0
internal void Update(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData)   // RVA 0x212E250
internal void IntegrateJumping(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData, CachedEntityData targetEntityData)   // RVA 0x212CFB0
internal void OnTrip(Frame frame, CachedEntityData targetEntityData)   // RVA 0x212D270
internal void SetBoost(Frame frame, FP boost)   // RVA 0x212DC50
internal void AddBoost(Frame frame, FP boostToAdd)   // RVA 0x212C6A0
internal void EquipItem(Frame frame, int itemHash, bool force = False)   // RVA 0x212C770
internal void UnequipItem(Frame frame)   // RVA 0x212E210
internal void UseItem(Frame frame)   // RVA 0x212E950
internal void StartInvinciDrill(Frame frame, FP invicidrillFramesDuration)   // RVA 0x212E010
internal void StopInviciDrill(Frame frame)   // RVA 0x212E130
internal void ReleaseGoldenHook(Frame frame, bool forceRelease = False)   // RVA 0x212D4C0
internal FPVector2 GetSuperBoostDirectionVector()   // RVA 0x212CC80
public bool CheckIfRunningBackwards()   // RVA 0x212C760
public void SetDistanceToFinish(FP distance)   // RVA 0x212DC90
```

### Quantum.SpeedRunnersItem  (bases: IComponent; TypeDefIndex 10037)
Fields:
```
public QBoolean DestroyOnRoundEnd;  // 0x0
public EntityRef Entity;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212EB10
```

### Quantum.SpeedRunnersNPC  (bases: IComponent; TypeDefIndex 10039)
Fields:
```
private Ptr ActionDataPtr;  // 0x10
public FP ChangeDirectionDelay;  // 0x28
public RunningDirection DelayDirection;  // 0x14
public int DodgeChance;  // 0x0
public EntityRef Entity;  // 0x20
public FPVector2 ItemPosition;  // 0x80
public int ItemUses;  // 0x4
public QBoolean JumpDodge;  // 0x8
public FP MaxSpeed;  // 0x30
public RunningDirection RunningDirection;  // 0x18
public FP SlideDodgeFrames;  // 0x38
public FP SlideDodgeTriggerCooldownFrames;  // 0x40
public FP TackleChance;  // 0x48
public FP TackleCooldown;  // 0x50
public FP TackleRunningCooldown;  // 0x58
public RunningDirection TemporaryDirection;  // 0x1C
public FP TemporaryDirectionFrames;  // 0x60
public FP UnFreezeCooldown;  // 0x68
public FP UnFreezeSpeed;  // 0x70
public QBoolean UnfreezeToggle;  // 0xC
public FP UseCooldown;  // 0x78
```
Methods:
```
public QListPtr<ActionData> get_ActionData()   // RVA 0x2130440
public void set_ActionData(QListPtr<ActionData> value)   // RVA 0x520750
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x212EB50
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x212F610
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x212FC20
public void Initialize(Frame frame, EntityRef entity, int facingDirection)   // RVA 0x212F4C0
public void Update(Frame frame, EntityRef entity)   // RVA 0x2130390
public void SendInputs(Frame frame, Input input)   // RVA 0x212F7C0
public void TacklePlayer(Frame frame)   // RVA 0x212FFD0
public void TriggerSlideDodge(Frame frame, int framesDuration)   // RVA 0x2130330
public void ClearSlidingDodge()   // RVA 0x212EB60
public void JumpingDodge(Frame frame, bool active)   // RVA 0x212F5C0
public bool EquipmentLogic(Frame frame, int Equipment)   // RVA 0x212EB70
public void Reset(Frame frame)   // RVA 0x212F690
public void ToggleDirection(RunningDirection direction, int delay)   // RVA 0x2130320
public void StartAction(Frame frame, int numberFrames, InputFlag action, VolumeMode volumeMode, int delay)   // RVA 0x212FE60
```

### Quantum.Spike  (bases: IComponent; TypeDefIndex 10040)
Fields:
```
public SpikeDirection Direction;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2130490
```

### Quantum.StageBounds  (bases: IComponent; TypeDefIndex 10041)
Fields:
```
public FPVector2 BottomRight;  // 0x0
public FPVector2 TopLeft;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CD180
```

### Quantum.StageEdge  (bases: IComponent; TypeDefIndex 10042)
Fields:
```
public QBoolean Active;  // 0x4
public EdgeSide EdgeSide;  // 0x0
public EntityRef GrabbedEntity;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2130560
```

### Quantum.StageHazardSpawnArea  (bases: IComponent; TypeDefIndex 10043)
Fields:
```
public FPVector2 BottomRight;  // 0x8
public HazardSpawnDirection SpawnDirection;  // 0x0
public FPVector2 TopLeft;  // 0x18
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2130630
```

### Quantum.StageSFX  (bases: IComponent; TypeDefIndex 10044)
Fields:
```
private Ptr EventIDListPtr;  // 0x8
public StageExecutionMode ExecutionMode;  // 0xC
public QBoolean PlayOnStart;  // 0x0
public QBoolean UpdateSoundPosition;  // 0x4
```
Methods:
```
public QListPtr<SFXToExecute> get_EventIDList()   // RVA 0x2130B50
public void set_EventIDList(QListPtr<SFXToExecute> value)   // RVA 0x1ED2130
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x21207D0
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2130730
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2130A60
public void OnInit(Frame frame, EntityRef entity)   // RVA 0x21306E0
public void PlaySFX(Frame frame, EntityRef entityRef)   // RVA 0x21307B0
```

### Quantum.StageTimeline  (bases: IComponent; TypeDefIndex 10045)
Fields:
```
public FP FrameCheckInterval;  // 0x0
public FP StageFrameTime;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20A9200
public void Update(Frame frame, EntityRef entity)   // RVA 0x2130D20
public static bool TryFind(Frame frame, out StageTimeline* stageTimeline)   // RVA 0x2130BD0
```

### Quantum.StateMachine  (bases: IComponent; TypeDefIndex 10046)
Fields:
```
public QBoolean Active;  // 0x14
public int CurrentStateHash;  // 0x0
public int CurrentStateHashOverride;  // 0x4
public QString64 CurrentStateName;  // 0x60
public EntityRef Entity;  // 0x38
private Ptr ExecutedBehavioursPtr;  // 0x18
private Ptr FinishedBehavioursPtr;  // 0x1C
public int NextStateHash;  // 0x8
public int PreviousStateHash;  // 0xC
private Ptr ScheduledBehavioursPtr;  // 0x20
public FP SpeedMultiplier;  // 0x40
public int StateChangesInFrame;  // 0x10
public AssetRefStateMachineData StateMachineData;  // 0x30
public FP StateTime;  // 0x48
public FP TimeSinceLastUpdate;  // 0x50
public FP UpdateCooldown;  // 0x58
private Ptr UpdateExtraGroupsPtr;  // 0x24
private Ptr ValuesPtr;  // 0x28
```
Methods:
```
public QHashSetPtr<AssetGuid> get_ExecutedBehaviours()   // RVA 0x2132FB0
public void set_ExecutedBehaviours(QHashSetPtr<AssetGuid> value)   // RVA 0x6A4F50
public QHashSetPtr<AssetGuid> get_FinishedBehaviours()   // RVA 0x2132FF0
public void set_FinishedBehaviours(QHashSetPtr<AssetGuid> value)   // RVA 0x667A40
public QListPtr<ScheduledBehaviour> get_ScheduledBehaviours()   // RVA 0x2133030
public void set_ScheduledBehaviours(QListPtr<ScheduledBehaviour> value)   // RVA 0x667A20
public QListPtr<int> get_UpdateExtraGroups()   // RVA 0x2133070
public void set_UpdateExtraGroups(QListPtr<int> value)   // RVA 0x847EC0
public QDictionaryPtr<QString128, FP> get_Values()   // RVA 0x21330B0
public void set_Values(QDictionaryPtr<QString128, FP> value)   // RVA 0x51AE50
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x2131530
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2132580
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2132600
public void Initialize(Frame frame, EntityRef entity, AssetRefStateMachineData stateMachineDataRef)   // RVA 0x2132300
public void Update(Frame frame)   // RVA 0x2132B40
public void ChangeState(Frame frame, int stateHash, bool changeImmediately = False)   // RVA 0x2131410
private void EvaluateStateChange(Frame frame)   // RVA 0x2131540
private void ChangeStateInternal(Frame frame, int nextStateHash)   // RVA 0x2130DA0
public bool IsStateAvailable(Frame frame, int nextStateHash)   // RVA 0x2132380
public FP GetVariable(Frame frame, string valueName)   // RVA 0x21321B0
public void SetVariable(Frame frame, string valueName, FP value)   // RVA 0x2132A00
public FP GetValue(Frame frame, StateMachineVariable variable)   // RVA 0x2132140
public void SetValue(Frame frame, StateMachineVariable variable, FP value)   // RVA 0x2132970
public void ExecuteEventGroup(Frame frame, StateGroupEvent groupEvent)   // RVA 0x2131560
public void ExecuteGroup(Frame frame, HashString groupName, StateGroupExecutionMode executionMode)   // RVA 0x2131990
public void ExecuteGroup(Frame frame, int groupHash, StateGroupExecutionMode executionMode)   // RVA 0x2131A60
public void ExecuteGroup(Frame frame, CachedEntityData cachedEntityData, HashString groupName, StateGroupExecutionMode executionMode)   // RVA 0x21317B0
public void NotifyStateEvent(Frame frame, StateNotificationMode notificationMode, int stateHash, out bool changedState, out bool executedState)   // RVA 0x2132510
public void ExecuteStateFromHash(Frame frame, int stateHash)   // RVA 0x2131D00
private void ExecuteStateFromHash(Frame frame, int stateHash, StateMachineData stateMachineData, CachedEntityData entityData)   // RVA 0x2131B50
public int GetCurrentStateHash()   // RVA 0x2132010
public int GetStateFrame()   // RVA 0x2132130
public bool IsStateActive(int stateIndex)   // RVA 0x2132350
```

### Quantum.Static  (bases: IComponent; TypeDefIndex 10048)
Fields:
```
private Static.<_alignment_padding_>e__FixedBuffer _alignment_padding_;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x4F3940
```

### Quantum.StaticRotation  (bases: IComponent; TypeDefIndex 10049)
Fields:
```
public FP Rotation;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D41D0
```

### Quantum.StatusEffectsHolder  (bases: IComponent; TypeDefIndex 10050)
Fields:
```
private Ptr ActiveStatusEffectsPtr;  // 0x0
public EntityRef Entity;  // 0x8
```
Methods:
```
public QListPtr<RuntimeStatusEffect> get_ActiveStatusEffects()   // RVA 0x21345F0
public void set_ActiveStatusEffects(QListPtr<RuntimeStatusEffect> value)   // RVA 0x93A640
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E0430
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2133B70
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2134160
public void Init(Frame frame)   // RVA 0x2133950
public void AddStatusEffect(Frame frame, HashString nameId, HashString originId, EntityRef originEntity)   // RVA 0x2133120
public void RemoveStatusEffect(Frame frame, HashString nameId)   // RVA 0x2133F90
public void RemoveStatusEffectByOrigin(Frame frame, HashString originId)   // RVA 0x2133BF0
public void RemoveStatusEffectByType(Frame frame, HashString typeId)   // RVA 0x2133DC0
public void Update(Frame frame)   // RVA 0x21343F0
public void NotifyEvent(Frame frame, StatusEffectEvent eventType)   // RVA 0x2133990
public bool CheckIfStatusEffectsTypeIsActive(Frame frame, HashString[] types)   // RVA 0x21335E0
private bool TryCreateStatusEffectById(Frame frame, HashString nameId, out AssetRefStatusEffectBase newStatusEffect)   // RVA 0x2134210
private bool CheckHasStatusEffectByType(Frame frame, HashString typeId, EntityRef originEntity)   // RVA 0x21334A0
public FP GetValue(Frame frame, StatusEffectsVariable variable, CachedEntityData entityData, EntityVariableBase entityVariable)   // RVA 0x2133770
public void SetValue(Frame frame, StatusEffectsVariable variable, FP value)   // RVA 0x4F3940
```

### Quantum.StatusEffectsModifiers  (bases: IComponent; TypeDefIndex 10051)
Fields:
```
public StatusEffectAttribute DamageAttribute;  // 0x20
private Ptr DamageModifiersPtr;  // 0x0
public EntityRef Entity;  // 0x10
public StatusEffectAttribute KnockbackAttribute;  // 0x38
private Ptr KnockbackModifiersPtr;  // 0x4
public FP OriginalScale;  // 0x18
public StatusEffectAttribute ScaleAttribute;  // 0x50
private Ptr ScaleModifiersPtr;  // 0x8
```
Methods:
```
public QListPtr<StatusEffectAttributeModifier> get_DamageModifiers()   // RVA 0x2134930
public void set_DamageModifiers(QListPtr<StatusEffectAttributeModifier> value)   // RVA 0x93A640
public QListPtr<StatusEffectAttributeModifier> get_KnockbackModifiers()   // RVA 0x2134970
public void set_KnockbackModifiers(QListPtr<StatusEffectAttributeModifier> value)   // RVA 0x526D50
public QListPtr<StatusEffectAttributeModifier> get_ScaleModifiers()   // RVA 0x21349B0
public void set_ScaleModifiers(QListPtr<StatusEffectAttributeModifier> value)   // RVA 0x1ED2130
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x2134630
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2134730
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x21347B0
public void Init(Frame frame, EntityRef entity)   // RVA 0x21346D0
```

### Quantum.StellarCharacter  (bases: IComponent; TypeDefIndex 10052)
Fields:
```
public QBoolean Active;  // 0x10
public int CharacterID;  // 0x0
public EntityRef Entity;  // 0x18
public QStringUtf8_64 Nickname;  // 0x60
public int PartnerCharacterIndex;  // 0x4
public QString64 PlayerID;  // 0x20
public PlayerRef PlayerRef;  // 0xC
public int SpawnOrder;  // 0x8
public QBoolean StartDisabled;  // 0x14
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2134B00
public void InitializeCharacter(Frame frame)   // RVA 0x4F3940
public void EnableCharacter(Frame frame, CharacterActivationType activationtype = 1)   // RVA 0x2134A30
public void DisableCharacter(Frame frame)   // RVA 0x21349F0
```

### Quantum.StellarNPC  (bases: IComponent; TypeDefIndex 10053)
Fields:
```
public QBoolean Active;  // 0x4
public int Difficulty;  // 0x0
public EntityRef Entity;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2134CA0
public void Initialize(Frame frame, EntityRef entity, int difficulty)   // RVA 0x2134C90
internal void Enable()   // RVA 0x2134C30
internal void Disable()   // RVA 0x2134C10
```

### Quantum.SuperBoostVolume  (bases: IComponent; TypeDefIndex 10054)
Fields:
```
public SuperBoostDirection Direction;  // 0x0
public EntityRef Entity;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2134ED0
public void OnBodyEnter(Frame frame, EntityRef other)   // RVA 0x2134D50
public void OnBodyExit(Frame frame, EntityRef other)   // RVA 0x2134E20
```

### Quantum.Teams  (bases: IComponent; TypeDefIndex 10055)
Fields:
```
public int TeamIndex;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2134F70
```

### Quantum.TournamentGameModeManager  (bases: IComponent; TypeDefIndex 10056)
Fields:
```
public FP CurrentRocketsTimer;  // 0x0
public FP ItemSpawnCooldown;  // 0x8
public FP RocketsWarningTimer;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20AA1B0
```

### Quantum.TrainingGameModeManager  (bases: IComponent; TypeDefIndex 10057)
Fields:
```
public int HighestLap;  // 0x0
public FP LapTime;  // 0x8
public QBoolean StartedFirstLap;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2135070
```

### Quantum.TrapDoor  (bases: IComponent; TypeDefIndex 10058)
Fields:
```
public EntityRef Entity;  // 0x8
public QBoolean IsOn;  // 0x4
public FP OffRotation;  // 0x10
public FP OnRotation;  // 0x18
public FP RotationSpeed;  // 0x20
public QString64 SwitchIDToReact;  // 0x28
public int SwitchIDToReactHash;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2135F40
public void Update(Frame frame)   // RVA 0x2136010
public void Activate(Frame frame)   // RVA 0x2135CE0
public void Deactivate(Frame frame)   // RVA 0x2135D20
private void PlayActivationVFX(Frame frame)   // RVA 0x2135DE0
```

### Quantum.TrapDoorSwitch  (bases: IComponent; TypeDefIndex 10059)
Fields:
```
public TrapDoorSwitchActivationMode ActivationMode;  // 0x8
public EntityRef Entity;  // 0x10
public FP FramesToDeactivate;  // 0x18
public QBoolean IsOn;  // 0x4
public FP RuntimeFramesToDeactivate;  // 0x20
public QString64 SwitchID;  // 0x28
public int SwitchIDHash;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2135B50
public void Init(Frame frame)   // RVA 0x2135820
public void Update(Frame frame)   // RVA 0x2135C30
public void OnBodyEnter(Frame frame)   // RVA 0x2135860
public void Activate(Frame frame, bool notifyOthers = False)   // RVA 0x2135100
public void Deactivate(Frame frame, bool notifyOthers = False)   // RVA 0x2135450
private void PlayActivationFX(Frame frame, bool notifyOthers)   // RVA 0x2135890
```

### Quantum.Trigger  (bases: IComponent; TypeDefIndex 10060)
Fields:
```
public QBoolean Active;  // 0x0
private Ptr BodiesInTriggerPtr;  // 0x4
public EntityRef Entity;  // 0x8
public EntityRef TriggerEnterEntity;  // 0x10
public EntityRef TriggerExitEntity;  // 0x18
```
Methods:
```
public QListPtr<EntityRef> get_BodiesInTrigger()   // RVA 0x2137AA0
public void set_BodiesInTrigger(QListPtr<EntityRef> value)   // RVA 0x526D50
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20CCF30
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x2137740
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x21377C0
internal FP GetValue(Frame frame, TriggerVariable variable)   // RVA 0x2137310
internal void SetValue(Frame frame, TriggerVariable variable, FP value)   // RVA 0x21378A0
internal void Enable(Frame frame)   // RVA 0x2136610
internal void Disable(Frame frame)   // RVA 0x2136560
public void Update(Frame frame, EntityRef triggerEntity, List<PhysicsBodyEntity> activeBodies)   // RVA 0x2137930
private void EvaluateSphereCollision(Frame frame, EntityRef triggerEntity, TriggerSphereShape* sphereShape, FPVector2 position, FP rotation, List<PhysicsBodyEntity> activeBodies)   // RVA 0x2136DA0
private void EvaluatePolygonCollision(Frame frame, EntityRef triggerEntity, TriggerPolygonShape* polygonShape, FPVector2 position, FP rotation, List<PhysicsBodyEntity> activeBodies)   // RVA 0x2136630
private void BodyEntered(Frame frame, EntityRef triggerEntity, EntityRef otherEntity)   // RVA 0x21360E0
private void OnBodyEnter(Frame frame, EntityRef triggerEntity, EntityRef otherEntity)   // RVA 0x2137340
private void BodyExited(Frame frame, EntityRef triggerEntity, EntityRef otherEntity)   // RVA 0x21362D0
private void OnBodyExit(Frame frame, EntityRef triggerEntity, EntityRef otherEntity)   // RVA 0x21376A0
internal void ClearBodies(Frame frame)   // RVA 0x21364C0
```

### Quantum.TriggerPolygonShape  (bases: IComponent; TypeDefIndex 10061)
Fields:
```
public FPVector2 Center;  // 0x8
private Ptr PolygonVerticesPtr;  // 0x0
```
Methods:
```
public QListPtr<FPVector2> get_PolygonVertices()   // RVA 0x21487E0
public void set_PolygonVertices(QListPtr<FPVector2> value)   // RVA 0x93A640
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20E0430
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x21486B0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2148730
```

### Quantum.TriggerSphereShape  (bases: IComponent; TypeDefIndex 10062)
Fields:
```
public FPVector2 Center;  // 0x8
public FP Radius;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x2148860
```

### Quantum.VelocityModifier  (bases: IComponent; TypeDefIndex 10063)
Fields:
```
public QBoolean Active;  // 0x0
public VelocityModifierCondition ApplyXVelocityCondition;  // 0x10
public VelocityModifierCondition ApplyYVelocityCondition;  // 0x14
public QBoolean ChangeState;  // 0x4
public EntityRef Entity;  // 0x20
public FP MaxYClamp;  // 0x28
public VelocityOperation OperationType;  // 0x18
public QBoolean ResetMovesetLimiter;  // 0x8
private Ptr TargetStatePerEntityPtr;  // 0xC
public VelocityType Type;  // 0x1C
public FP XVelocityModifier;  // 0x30
public FP YVelocityModifier;  // 0x38
```
Methods:
```
public QListPtr<TargetStatePerEntity> get_TargetStatePerEntity()   // RVA 0x214E1C0
public void set_TargetStatePerEntity(QListPtr<TargetStatePerEntity> value)   // RVA 0x1ED2120
public void ClearPointers(Frame f, EntityRef entity)   // RVA 0x20C9B80
public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr)   // RVA 0x214DDD0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x214DE50
public void Update(Frame frame, EntityRef entity)   // RVA 0x214DFF0
public void ApplyVelocity(Frame frame, EntityRef otherEntity, bool impulse = False)   // RVA 0x214DAD0
```

### Quantum.VisibilitySource  (bases: IComponent; TypeDefIndex 10064)
Fields:
```
public QBoolean Active;  // 0x0
public SimpleAABB Bounds;  // 0x10
public EntityRef Entity;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x214E280
public FP GetValue(Frame frame, VisibilitySourceVariable variable)   // RVA 0x2137310
public void SetValue(Frame frame, VisibilitySourceVariable variable, FP value)   // RVA 0x214E310
```

### Quantum.VisibilityTarget  (bases: IComponent; TypeDefIndex 10065)
Fields:
```
public QBoolean AlterCombat;  // 0x4
public QBoolean AlterKinematicBody;  // 0x8
public QBoolean AlterPhysicsBody;  // 0xC
public QBoolean AlterStateMachine;  // 0x10
public QBoolean AlterTrigger;  // 0x14
public SimpleAABB Bounds;  // 0x30
public QBoolean BoundsInitialized;  // 0x18
public EntityRef Entity;  // 0x28
public int StateMachineUpdateCooldown;  // 0x0
public QBoolean UseTriggerAsBounds;  // 0x1C
public QBoolean Visible;  // 0x20
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x214E440
```

### Quantum.VisualShake  (bases: IComponent; TypeDefIndex 10066)
Fields:
```
public EntityRef Entity;  // 0x8
public FP ShakeFrames;  // 0x10
public QBoolean ShakeHorizontally;  // 0x0
public FP ShakePower;  // 0x18
public QBoolean ShakeVertically;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x214E5D0
```


## Systems (20)

### SystemBase.<get_Hierarchy>d__12  (bases: IEnumerable<SystemBase>, IEnumerable, IEnumerator<SystemBase>, IDisposable, IEnumerator; TypeDefIndex 10286)
Fields:
```
private int <>1__state;  // 0x10
private SystemBase <>2__current;  // 0x18
private int <>l__initialThreadId;  // 0x20
public SystemBase <>4__this;  // 0x28
private IEnumerator<SystemBase> <>7__wrap1;  // 0x30
private IEnumerator<SystemBase> <>7__wrap2;  // 0x38
```
Methods:
```
public void .ctor(int <>1__state)   // RVA 0x808EA0
private void <>m__Finally1()   // RVA 0x217B4B0
private void <>m__Finally2()   // RVA 0x217B500
```

### Quantum.SystemMainThread  (bases: SystemBase; TypeDefIndex 10288)
Fields:
```
private TaskDelegateHandle _updateHandle;  // 0x28
private string _update;  // 0x30
```
Methods:
```
public void .ctor()   // RVA 0x217AB10
protected TaskHandle ScheduleUpdate(Frame f, TaskHandle taskHandle)   // RVA 0x217A900
private void TaskCallback(FrameThreadSafe frame, int start, int count, void* arg)   // RVA 0x217AA40
```

### Quantum.SystemSignalsOnly  (bases: SystemBase; TypeDefIndex 10289)
Methods:
```
public void .ctor()   // RVA 0x21012E0
```

### Quantum.DestroyObjectsSystem  (bases: SystemMainThread, ISignalOnComponentRemoved<CheckpointManager>, ISignalOnComponentRemoved<SpeedRunnersNPC>, ISignalOnComponentRemoved<MechanicTutorialGameModeManager>, ISignalOnComponentRemoved<PlayerStats>, ISignalOnComponentRemoved<AIVolume>, ISignalOnComponentRemoved<CollectorsGameModeManager>, ISignalOnComponentRemoved<EndlessGameModeManager>, ISignalOnComponentRemoved<GameTimeManager>, ISignalOnComponentRemoved<DestroyEntitiesManager>, ISignalOnComponentRemoved<GameEntity>, ISignalOnComponentRemoved<Trigger>, ISignalOnComponentRemoved<TriggerPolygonShape>, ISignalOnComponentRemoved<EntityModifierTarget>, ISignalOnComponentRemoved<StateMachine>, ISignalOnComponentRemoved<CustomAnimator>, ISignalOnComponentRemoved<MovesetLimiter>, ISignalOnComponentRemoved<Combat>, ISignalOnComponentRemoved<LayoutManager>, ISignalOnComponentRemoved<ParentObject>, ISignalOnComponentRemoved<PartnersManager>, ISignalOnComponentRemoved<StageSFX>, ISignalOnComponentRemoved<CameraTarget>, ISignalOnComponentRemoved<StatusEffectsHolder>, ISignalOnComponentRemoved<StatusEffectsModifiers>; TypeDefIndex 10408)
Methods:
```
public void .ctor()   // RVA 0x20EA200
```

### Quantum.InitObjectsSystem  (bases: SystemMainThread, ISignalOnComponentAdded<CheckpointManager>, ISignalOnComponentAdded<SuperBoostVolume>, ISignalOnComponentAdded<TrapDoor>, ISignalOnComponentAdded<TrapDoorSwitch>, ISignalOnComponentAdded<AIVolume>, ISignalOnComponentAdded<SpeedRunnersNPC>, ISignalOnComponentAdded<MechanicTutorialGameModeManager>, ISignalOnComponentAdded<ItemAutoTrigger>, ISignalOnComponentAdded<GameModeItemAutoTrigger>, ISignalOnComponentAdded<PlayerStats>, ISignalOnComponentAdded<CollectorsGameModeManager>, ISignalOnComponentAdded<EndlessGameModeManager>, ISignalOnComponentAdded<GameTimeManager>, ISignalOnComponentAdded<DestroyEntitiesManager>, ISignalOnComponentAdded<VisibilitySource>, ISignalOnComponentAdded<VisibilityTarget>, ISignalOnComponentAdded<GameEntity>, ISignalOnComponentAdded<PhysicsBody>, ISignalOnComponentAdded<KinematicBody>, ISignalOnComponentAdded<Trigger>, ISignalOnComponentAdded<TriggerPolygonShape>, ISignalOnComponentAdded<EntityModifierTarget>, ISignalOnComponentAdded<StateMachine>, ISignalOnComponentAdded<CustomAnimator>, ISignalOnComponentAdded<MovesetLimiter>, ISignalOnComponentAdded<Combat>, ISignalOnComponentAdded<CombatBlock>, ISignalOnComponentAdded<CombatTech>, ISignalOnComponentAdded<CombatCharge>, ISignalOnComponentAdded<CombatArmor>, ISignalOnComponentAdded<CombatDI>, ISignalOnComponentAdded<ContinuousRotation>, ISignalOnComponentAdded<LayoutManager>, ISignalOnComponentAdded<ParentObject>, ISignalOnComponentAdded<CameraManager>, ISignalOnComponentAdded<PartnersManager>, ISignalOnComponentAdded<StellarNPC>, ISignalOnComponentAdded<StageSFX>, ISignalOnComponentAdded<CameraTarget>, ISignalOnComponentAdded<StatusEffectsHolder>, ISignalOnComponentAdded<StatusEffectsModifiers>; TypeDefIndex 10409)
Methods:
```
public void .ctor()   // RVA 0x20EA200
```

### Quantum.UpdateSystem  (bases: SystemMainThread; TypeDefIndex 10410)
Methods:
```
private void OnUpdate(Frame frame)   // RVA 0x21AD910
public void .ctor()   // RVA 0x20EA200
```

### Quantum.CombatSystem  (bases: SystemMainThread; TypeDefIndex 10676)
Methods:
```
private void EvaluateRedirectsAndReflects(Frame frame, CombatSettingsData combatSettingsData, CombatEntity check, CombatEntity target)   // RVA 0x20E7A80
private void EvaluateHitBoxes(Frame frame, CombatSettingsData combatSettingsData, CombatEntity check, CombatEntity target, bool hittingOwner, bool hitFromOwner, bool sameTeam, int facingDirection)   // RVA 0x20E6A10
private void EvaluateHurtBoxes(Frame frame, CombatEntity check, CombatEntity target, bool hittingOwner, bool hitFromOwner, bool sameTeam, int facingDirection, ref List<HitResult> registeredHits, ref List<GrabResult> registeredGrabs)   // RVA 0x20E7260
private void EvaluateRegisteredHitsAndGrabs(Frame frame, CombatSettingsData combatSettingsData, ref List<HitResult> registeredHits, ref List<GrabResult> registeredGrabs)   // RVA 0x20E7F50
private void RegisterHit(ref List<HitResult> registeredHits, HitResult newHitResult)   // RVA 0x20E8F40
private void RegisterGrab(ref List<GrabResult> registeredGrabs, GrabResult newGrabResult)   // RVA 0x20E8D50
private bool CanEntityClank(Frame frame, AttackData attackData, CombatEntity entity)   // RVA 0x20E6950
public void .ctor()   // RVA 0x20EA200
```

### Quantum.CustomAnimatorSystem  (bases: SystemMainThread; TypeDefIndex 10677)
Methods:
```
public void .ctor()   // RVA 0x20EA200
```

### Quantum.InitSystem  (bases: SystemMainThread; TypeDefIndex 10678)
Methods:
```
public void .ctor()   // RVA 0x20EA200
```

### Quantum.InputBufferSystem  (bases: SystemMainThread; TypeDefIndex 10679)
Methods:
```
public void .ctor()   // RVA 0x20EA200
```

### Quantum.MatchSystem  (bases: SystemMainThread, ISignalOnPlayerDataSet; TypeDefIndex 10680)
Methods:
```
public void CheckCommands(Frame frame)   // RVA 0x20ED1B0
public void FrameByFrameUpdate(Frame frame)   // RVA 0x20ED3B0
public void .ctor()   // RVA 0x20EA200
```

### Quantum.PhysicsSystem  (bases: SystemMainThread; TypeDefIndex 10682)
Fields:
```
public static readonly FP DefaultMaxVelocity;  // 0x0
public static readonly FP ECBLinecastStartOffset;  // 0x8
public static readonly FP ECBHorizontalDetectionOffset;  // 0x10
public static readonly FPVector2 MinECBSize;  // 0x18
public static readonly FP MinCollisionDistance;  // 0x28
public static readonly FP PerpendicularCollisionCrossValue;  // 0x30
```
Methods:
```
private void MoveAndCollide(Frame frame, FP deltaTime, EntityRef entity, GameEntity* gameEntity, PhysicsBody* physicsBody, Transform2D* transform, bool canApplyMovement, FP velocityMultiplier)   // RVA 0x20F29E0
public static void TeleportEntity(Frame frame, EntityRef entity, FPVector2 newPosition, bool clearRelativeMovement = True)   // RVA 0x20F6500
public static void MoveEntity(Frame frame, EntityRef entity, FPVector2 newPosition, FPVector2 referencePoint, bool ignoreThinPlatforms = True)   // RVA 0x20F5950
public static LinecastHitInfo ComplexLinecast(Frame frame, EntityRef entity, FPVector2 startPoint, FPVector2 endPoint, FPVector2 referencePoint, int layerMask, bool predictThinPlatformCorrection = False, PhysicsBody* physicsBody, Transform2D* transform)   // RVA 0x20F0AB0
private bool IsOnLedge(Frame frame, FP deltaTime, EntityRef entity, Transform2D* transform, FPVector2 frameVelocity, FPVector2 groundNormal, PhysicsData physicsData, int floorLayerMask)   // RVA 0x20F2720
private void MoveToClosestLedge(Frame frame, FP deltaTime, EntityRef entity, Transform2D* transform, FPVector2 frameVelocity, FPVector2 groundNormal, PhysicsData physicsData, int floorLayerMask)   // RVA 0x20F5CA0
private LinecastHitInfo CheckCollisionFromCenter(Frame frame, FP deltaTime, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 frameVelocity, int layerMask, bool predictThinPlatformCorrection)   // RVA 0x20EF790
private LinecastHitInfo CheckFloorCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask)   // RVA 0x20F0370
private LinecastHitInfo CheckCeilingCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask)   // RVA 0x20EF490
private LinecastHitInfo CheckLeftWallCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask)   // RVA 0x20F06B0
private LinecastHitInfo CheckRightWallCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask)   // RVA 0x20F08B0
private void WallJumpChecks(Frame frame, EntityRef entity, PhysicsData physicsData, PhysicsBody* physicsBody, Jump* jump, Transform2D* transform, int facingDirection, int defaultLayerMask)   // RVA 0x20F87F0
private void CheckEdgeGrabs(Frame frame, List<PhysicsBodyEntity> activeBodies)   // RVA 0x20EF9F0
private bool SimpleEdgeCheck(Frame frame, PhysicsBodyEntity bodyEntity, EdgeGrab* edgeGrab, FP leftStickXValue, FP framesToIgnoreEdge, out EdgeGrabRequest edgeGrabRequest)   // RVA 0x20F6020
private bool InterpolatedEdgeCheck(Frame frame, PhysicsBodyEntity bodyEntity, EdgeGrab* edgeGrab, FP leftStickXValue, FP framesToIgnoreEdge, out EdgeGrabRequest edgeGrabRequest)   // RVA 0x20F1270
private void UpdateCrowdPush(Frame frame, List<PhysicsBodyEntity> activeBodies)   // RVA 0x20F67C0
private void UpdateTriggers(Frame frame, List<PhysicsBodyEntity> activeBodies)   // RVA 0x20F6B30
private void UpdateBlastzones(Frame frame, List<PhysicsBodyEntity> activeBodies, FPVector2 blastzoneTopLeft, FPVector2 blastzoneBottomRight)   // RVA 0x20F65B0
public void .ctor()   // RVA 0x20EA200
private static void .cctor()   // RVA 0x20F8B80
```

### Quantum.StageSystem  (bases: SystemMainThread; TypeDefIndex 10683)
Methods:
```
public void .ctor()   // RVA 0x20EA200
```

### Quantum.StateMachineSystem  (bases: SystemMainThread; TypeDefIndex 10684)
Methods:
```
public void .ctor()   // RVA 0x20EA200
```

### Quantum.Core.NavigationSystem  (bases: SystemBase; TypeDefIndex 10699)
Fields:
```
private Frame _f;  // 0x28
```

### Quantum.Core.EntityPrototypeSystem  (bases: SystemSignalsOnly, ISignalOnMapChanged; TypeDefIndex 10700)
Methods:
```
public void .ctor()   // RVA 0x2104670
```

### Quantum.Core.CullingSystem2D  (bases: SystemBase; TypeDefIndex 10701)

### Quantum.Core.CullingSystem3D  (bases: SystemBase; TypeDefIndex 10702)
Methods:
```
public void .ctor()   // RVA 0x21012E0
```

### Quantum.Core.PhysicsSystem2D  (bases: SystemBase, ICollisionCallbacks2D; TypeDefIndex 10703)
Methods:
```
public void .ctor()   // RVA 0x21012E0
```

### Quantum.Core.PhysicsSystem3D  (bases: SystemBase; TypeDefIndex 10704)


## Assets (config/data objects) (30)

### Quantum.SpeedRunnersSettingsData  (bases: AssetObject; TypeDefIndex 10181)
Fields:
```
public SimpleAABB DefaultViewPort;  // 0x20
public FP MinZoom;  // 0x40
public FP MaxZoom;  // 0x48
public FP ZoomInSpeed;  // 0x50
public FP ZoomOutSpeed;  // 0x58
public FP MovementSmoothing;  // 0x60
public FPVector2 CameraOffset;  // 0x68
public FPVector2 MaxDistanceToCenter;  // 0x78
public FP MaxSuddenDeathZoom;  // 0x88
public FP SinglePlayerMovementSmoothing;  // 0x90
public FPVector2 SinglePlayerCameraOffset;  // 0x98
public FP RoundWonSlowdownMultiplier;  // 0xA8
public HashString InviciDrillActiveVFX_ID;  // 0xB0
public HashString InviciDrillGroundedVFX_ID;  // 0xC0
public HashString SwitchActivationVFX_ID;  // 0xD0
public int SuperSpeedAccoladeCooldownFrames;  // 0xE0
public int BigAirAccoladeCooldownFrames;  // 0xE4
public int FloorIsLavaAccoladeRequiredFrames;  // 0xE8
public HashString SuperSpeedVFX_ID;  // 0xF0
public HashString DoubleHitVFX_ID;  // 0x100
public HashString TripleHitVFX_ID;  // 0x110
public HashString BackfiredVFX_ID;  // 0x120
public HashString BigAirVFX_ID;  // 0x130
public HashString TackleVFX_ID;  // 0x140
public HashString GotchaVFX_ID;  // 0x150
public HashString RevengeVFX_ID;  // 0x160
public HashString StillAliveVFX_ID;  // 0x170
public HashString DodgedVFX_ID;  // 0x180
public HashString TheDistanceVFX_ID;  // 0x190
public HashString FreezeVFX_ID;  // 0x1A0
public HashString DeflectedVFX_ID;  // 0x1B0
public HashString BlockedVFX_ID;  // 0x1C0
public HashString TreasureVFX_ID;  // 0x1D0
public string SwitchActivationSFX_ID;  // 0x1E0
public string SuddenDeathActivationSFX_ID;  // 0x1E8
public string BoostSFX_ID;  // 0x1F0
public HashString SlopeSurfGoalID;  // 0x1F8
public HashString ReverseGrappleGoalID;  // 0x208
public FP BlastzoneMinimalSizePercent;  // 0x218
public FP BlastzoneReduceSpeed;  // 0x220
public FP BlastzoneTimeToForceReduction;  // 0x228
public FP BlastzoneTimeToShowTimer;  // 0x230
public FP LastPlayerFramesInBlastzoneToKO;  // 0x238
public FP NonLastPlayerFramesInBlastzoneToKO;  // 0x240
public FP RocketKnockback;  // 0x248
public FP DefaultAttackKnockback;  // 0x250
public int HookCooldownFrames;  // 0x258
public int SlideCooldownFrames;  // 0x25C
public int WallSlideCooldownFrames;  // 0x260
public int ObstacleCooldownTime;  // 0x264
public int RoundStartItemUseCooldownFrames;  // 0x268
public int ItemUseCooldownFramesOnPickup;  // 0x26C
public int ReverseGrappleWindowFrames;  // 0x270
public int CaterpillarWindowFrames;  // 0x274
public FP MinBoost;  // 0x278
public FP MaxBoost;  // 0x280
public FP BoostDepletionRate;  // 0x288
public FP BoostFillRate;  // 0x290
public FP SinglePlayerBoostFillMultiplier;  // 0x298
public FP JumpFrames;  // 0x2A0
public FP JumpPower;  // 0x2A8
public FP DoubleJumpPower;  // 0x2B0
public FP WallJumpPower;  // 0x2B8
public FP WallJumpUpwardMotionRetainer;  // 0x2C0
public FP WallJumpAngle;  // 0x2C8
public FP CaterpillarSpeedBoost;  // 0x2D0
public FPVector2 AboveWallCheckLinecastStart;  // 0x2D8
public FP AboveWallCheckLinecastDistance;  // 0x2E8
public FP DistanceToStepUp;  // 0x2F0
public FPVector2 StepUpLinecastStart;  // 0x2F8
public FP StepUpLinecastDistance;  // 0x308
public ColorRGBA StepUpLinecastColor;  // 0x310
public FP SlopeVelocityInheritanceMultiplier;  // 0x318
public FP UpSlopeMultiplier;  // 0x320
public FP DownSlopeMultiplier;  // 0x328
public FP MaxWalkVelocity;  // 0x330
public FP MaxRunVelocity;  // 0x338
public FP MaxBoostVelocity;  // 0x340
public FP MaxHookVelocity;  // 0x348
public FP MinVelocityToSlide;  // 0x350
public FP MinVelocityForRunTurn;  // 0x358
public FP VelocityForSuperSpeed;  // 0x360
public FP Gravity;  // 0x368
public FP MaxFallSpeed;  // 0x370
public FP MinVelocity;  // 0x378
public FP MinVelocityForTrip;  // 0x380
public FP MinVelocityForDrag;  // 0x388
public FP TerminalVelocity;  // 0x390
public FP BrakeDeceleration;  // 0x398
public FP SlideDeceleration;  // 0x3A0
public FP SlideDecelerationPostBoosting;  // 0x3A8
public FP SlideDecelerationForBoost;  // 0x3B0
public FP BoostDeceleration;  // 0x3B8
public FP WalkAcceleration;  // 0x3C0
public FP RunAcceleration;  // 0x3C8
public FP AirAcceleration;  // 0x3D0
public FP AirAccelerationAfterWallJump;  // 0x3D8
public FP BoostWalkAcceleration;  // 0x3E0
public FP BoostRunAcceleration;  // 0x3E8
public FP BoostAcceleration;  // 0x3F0
public FP GroundDeceleration;  // 0x3F8
public FP AirDeceleration;  // 0x400
public FP MaxSwingSpeed;  // 0x408
public FP SwingDeceleration;  // 0x410
public FP MaxSuperBoostVelocity;  // 0x418
public FP SuperBoostAcceleration;  // 0x420
public FP SuperBoostDeceleration;  // 0x428
public FP StunnedAcceleration;  // 0x430
public FP StunnedTurnAcceleration;  // 0x438
public FP StunnedDeceleration;  // 0x440
public FP StunnedMaxVelocity;  // 0x448
public HashString SlopeSurfActivationVFX_ID;  // 0x450
public HashString SlopeSurfActivationSFX_ID;  // 0x460
public FP SlopeSurfVerticalVelocityThreshold;  // 0x470
public int SlopeSurfCooldown;  // 0x478
public int FramesToGetBigAir;  // 0x47C
public int AllowedGrappleSwingForBigAir;  // 0x480
```
Methods:
```
public void .ctor()   // RVA 0x21482B0
```

### Quantum.PickupItemUsageData  (bases: AssetObject; TypeDefIndex 10182)
Fields:
```
public PickupItemUsage[] Usages;  // 0x20
public ItemButtonUseMode ButtonUseMode;  // 0x28
public FP ChargePowerIncreaseSpeed;  // 0x30
public bool AutoUseOnFullCharge;  // 0x38
public bool HasInfiniteUses;  // 0x39
```
Methods:
```
public void Use(Frame frame, EntityRef fromEntity)   // RVA 0x2148190
public void .ctor()   // RVA 0x2148250
```

### Quantum.NPCSettingsData  (bases: AssetObject; TypeDefIndex 10183)
Fields:
```
public List<NPCDifficultyData> DifficultyData;  // 0x20
public List<NPCItemUseData> ItemUsageData;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.RoomConfig  (bases: AssetObject; TypeDefIndex 10184)
Fields:
```
public RoomInternalEntity[] Entities;  // 0x20
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.PlayerSettings  (bases: AssetObject; TypeDefIndex 10185)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.GameplayInputSettingsData  (bases: AssetObject; TypeDefIndex 10186)
Fields:
```
public FPVector2 StickMinValues;  // 0x20
public FPVector2 StickMaxValues;  // 0x30
public int GeneralDirectionHoldBufferFrames;  // 0x40
public FP GeneralAxisDeadzone;  // 0x48
public FP GeneralAxisThreshold;  // 0x50
public int FlickDirectionBufferFrames;  // 0x58
public FP FlickAxisDeadzone;  // 0x60
public FP FlickAxisThreshold;  // 0x68
public InputDirectionDetectionSettings GroundedDirectionSettings;  // 0x70
public InputDirectionDetectionSettings AirDirectionSettings;  // 0xA0
public GameSpecificInputSettings GameSpecificButtonSettings;  // 0xD0
```
Methods:
```
public InputDirectionSettings GenerateDirectionSettings(InputDirection direction, bool flick, bool grounded)   // RVA 0x2148010
public void .ctor()   // RVA 0x50D320
```

### Quantum.ItemsData  (bases: AssetObject; TypeDefIndex 10188)
Fields:
```
public ItemsData.ItemDataFile[] Items;  // 0x20
public HashString SpawnPointsDefaultID;  // 0x28
public int MaxItemsOnScreen;  // 0x38
public FP DefaultDisappearingTime;  // 0x40
public FP LowFrecuencyMinSpawnTime;  // 0x48
public FP LowFrecuencyMaxISpawnTime;  // 0x50
public FP MedFrecuencyMinSpawnTime;  // 0x58
public FP MedFrecuencyMaxSpawnTime;  // 0x60
public FP HighFrecuencyMinSpawnTime;  // 0x68
public FP HighFrecuencyMaxSpawnTime;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x2148120
```

### Quantum.BaseGameMode  (bases: AssetObject; TypeDefIndex 10189)
Methods:
```
public void DisablePlayersInput(Frame frame)   // RVA 0x2137E00
public void FocusCamera(Frame frame)   // RVA 0x21382D0
public void EnableNPCs(Frame frame)   // RVA 0x21380D0
public void DisableNPCs(Frame frame)   // RVA 0x2137D40
public static bool TryFindBaseGameModeManager(Frame frame, out BaseGameModeManager* baseGameModeManager)   // RVA 0x21387D0
protected void .ctor()   // RVA 0x50D320
```

### Quantum.GameEntityData  (bases: AssetObject; TypeDefIndex 10190)
Fields:
```
public HashString EntityName;  // 0x20
public GameEntityType EntityType;  // 0x30
public AssetRefEntityPrototype[] EntityPrototypeCostumes;  // 0x38
public FPVector2 RotationPivot;  // 0x40
public bool HasEntityModifier;  // 0x50
public bool HasStateMachine;  // 0x51
public AssetRefStateMachineData StateMachineData;  // 0x58
public bool HasCustomAnimator;  // 0x60
public AssetRefAnimationsPoolData AnimationsPoolData;  // 0x68
public AssetRefAnimationBakedJointsData BakedJointsData;  // 0x70
public bool HasCombat;  // 0x78
public AssetRefCombatData CombatData;  // 0x80
public bool HasGrab;  // 0x88
public AssetRefGrabData GrabData;  // 0x90
public bool HasPhysicsBody;  // 0x98
public AssetRefPhysicsData PhysicsData;  // 0xA0
public bool HasEdgeGrab;  // 0xA8
public FPVector2 EdgeHook;  // 0xB0
public SimpleAABB EdgeGrabBox;  // 0xC0
public int FramesToIgnoreEdgeGrab;  // 0xE0
public int EdgeGrabCooldownFrames;  // 0xE4
public StateNotificationMode EdgeGrabNotificationMode;  // 0xE8
public HashString EdgeGrabState;  // 0xF0
public bool HasJumps;  // 0x100
public AssetRefJumpSettingsData JumpSettings;  // 0x108
public bool HasMovesetLimiter;  // 0x110
public AssetRefMovesetLimiterData MovesetLimiterData;  // 0x118
```
Methods:
```
public EntityRef Spawn(Frame frame, int costumeIndex = 0)   // RVA 0x2153870
public void Initialize(Frame frame, EntityRef entity)   // RVA 0x2152B50
private AssetRefEntityPrototype GetEntityPrototypeCostume(int index)   // RVA 0x2152B00
public void .ctor()   // RVA 0x21538D0
```

### Quantum.MovesetLimiterData  (bases: AssetObject; TypeDefIndex 10191)
Fields:
```
public MoveLimitData[] CustomMovesetLimiters;  // 0x20
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.GameSpeedModifiersData  (bases: AssetObject; TypeDefIndex 10192)
Fields:
```
public GameSpeedModifier FrameByFrameModifier;  // 0x20
```
Methods:
```
public void .ctor()   // RVA 0x2153940
```

### Quantum.PhysicsData  (bases: AssetObject; TypeDefIndex 10193)
Fields:
```
public ECBPreset[] ECBPresets;  // 0x20
public FP Gravity;  // 0x28
public FP FallSpeed;  // 0x30
public FP AirSpeed;  // 0x38
public FP AirAcceleration;  // 0x40
public FP AirFriction;  // 0x48
public FP AirExtraFrictionThresholdMax;  // 0x50
public FP AirExtraFrictionThresholdMin;  // 0x58
public FP AirExtraFrictionFactor;  // 0x60
public FP WalkSlowSpeed;  // 0x68
public FP WalkFastSpeed;  // 0x70
public FP RunSpeed;  // 0x78
public FP GroundAcceleration;  // 0x80
public FP GroundFriction;  // 0x88
public FP GroundExtraFrictionThresholdMax;  // 0x90
public FP GroundExtraFrictionThresholdMin;  // 0x98
public FP GroundExtraFrictionFactor;  // 0xA0
public FP MinWallNormal;  // 0xA8
public FP MinSlopeNormal;  // 0xB0
public FP CrowdPushRadius;  // 0xB8
public FP CrowdPushMaxForce;  // 0xC0
public FP CrowdPushMinForce;  // 0xC8
public bool IgnoreThinPlatformCompletely;  // 0xD0
public FP MinDistanceToStandOnThinPlatform;  // 0xD8
public FP KnockbackDecay;  // 0xE0
public FP Restitution;  // 0xE8
public FP MinMagnitudeForBounce;  // 0xF0
public FP HitStunGravity;  // 0xF8
public FP HitStunFallSpeed;  // 0x100
public FP HitStunAirFriction;  // 0x108
public FP HitStunGroundFriction;  // 0x110
public StateNotificationMode OnTouchFloorNotificationMode;  // 0x118
public HashString OnTouchFloorState;  // 0x120
public StateNotificationMode OnLeaveFloorNotificationMode;  // 0x130
public HashString OnLeaveFloorState;  // 0x138
public StateNotificationMode OnTouchLeftWallNotificationMode;  // 0x148
public HashString OnTouchLeftWallState;  // 0x150
public StateNotificationMode OnTouchRightWallNotificationMode;  // 0x160
public HashString OnTouchRightWallState;  // 0x168
public StateNotificationMode OnTouchCeilingNotificationMode;  // 0x178
public HashString OnTouchCeilingState;  // 0x180
public StateNotificationMode OnEnterBlastzoneNotificationMode;  // 0x190
public HashString OnEnterBlastzoneState;  // 0x198
```
Methods:
```
public bool TryGetECBPreset(int identifier, out ECBPreset preset)   // RVA 0x2153E20
public void .ctor()   // RVA 0x2153EC0
```

### Quantum.JumpSettingsData  (bases: AssetObject; TypeDefIndex 10194)
Fields:
```
public int JumpAnticipationFrames;  // 0x20
public JumpData GroundJump;  // 0x28
public JumpData GroundShortJump;  // 0x30
public JumpData AirJump;  // 0x38
public JumpData WallJump;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2153E10
```

### Quantum.CombatData  (bases: AssetObject; TypeDefIndex 10195)
Fields:
```
public EntityHitFilter HitFilter;  // 0x20
public FP MaxKnockbackForFlinch;  // 0x68
public FP MaxKnockbackForFlop;  // 0x70
public FP Weight;  // 0x78
public bool RedirectedByAnything;  // 0x80
public bool CanBeRedirected;  // 0x81
public bool CanBeReflected;  // 0x82
public HurtBoxPreset[] HurtBoxPresets;  // 0x88
public AssetRefAttackDatasPool[] AttackDataPools;  // 0x90
public bool CanBlock;  // 0x98
public bool CanTech;  // 0x99
public bool CanChargeAttacks;  // 0x9A
public bool CanUseArmor;  // 0x9B
public bool CanUseDI;  // 0x9C
public bool CanStatusEffectsModifiersBeApplied;  // 0x9D
public StateNotificationMode ReboundNotificationMode;  // 0xA0
public HashString ReboundState;  // 0xA8
public StateNotificationMode DownFlinchNotificationMode;  // 0xB8
public HashString DownFlinchState;  // 0xC0
public StateNotificationMode FlinchNotificationMode;  // 0xD0
public HashString FlinchState;  // 0xD8
public StateNotificationMode FlopNotificationMode;  // 0xE8
public HashString FlopState;  // 0xF0
public StateNotificationMode LaunchedNotificationMode;  // 0x100
public HashString LaunchedState;  // 0x108
public StateNotificationMode RedirectedNotificationMode;  // 0x118
public HashString RedirectedState;  // 0x120
public StateNotificationMode ReflectedNotificationMode;  // 0x130
public HashString ReflectedState;  // 0x138
public StateNotificationMode HitNotificationMode;  // 0x148
public HashString HitState;  // 0x150
public StateNotificationMode HurtNotificationMode;  // 0x160
public HashString HurtState;  // 0x168
public StateNotificationMode BlockBreakNotificationMode;  // 0x178
public HashString BlockBreakState;  // 0x180
public StateNotificationMode StaminaDepletedNotificationMode;  // 0x190
public HashString StaminaDepletedState;  // 0x198
public StateNotificationMode KnockedOutNotificationMode;  // 0x1A8
public HashString KnockedOutState;  // 0x1B0
public StateNotificationMode RespawnNotificationMode;  // 0x1C0
public HashString RespawnState;  // 0x1C8
```
Methods:
```
public bool TryGetHurtBoxPreset(int identifier, out HurtBoxPreset preset)   // RVA 0x2150940
public bool TryGetAttackData(Frame frame, int attackDataID, out AttackData attackData)   // RVA 0x21507C0
public void .ctor()   // RVA 0x21509E0
```

### Quantum.GrabData  (bases: AssetObject; TypeDefIndex 10196)
Fields:
```
public GrabJoint InPlaceGrabJoint;  // 0x20
public HashString InPlaceGrabJointID;  // 0x28
public FPVector3 InPlaceGrabPosition;  // 0x38
public FPVector3 InPlaceGrabRotation;  // 0x50
public GrabJoint CarryGrabJoint;  // 0x68
public bool GrabberIsOwner;  // 0x6C
public HashString CarryGrabJointID;  // 0x70
public FPVector3 CarryGrabPosition;  // 0x80
public FPVector3 CarryGrabRotation;  // 0x98
public GrabDirection GrabDirection;  // 0xB0
public GrabMode GrabMode;  // 0xB4
public GrabbedAction GrabbedAction;  // 0xB8
public bool CanBeGrabbed;  // 0xBC
public bool GrabbableOnlyByOwner;  // 0xBD
public bool BlockGrabberFromBeingGrabbed;  // 0xBE
public int HitStopGrabProbability;  // 0xC0
public FPVector3 GrabPositionOffset;  // 0xC8
public FPVector3 GrabJointPositionOffset;  // 0xE0
public FPVector3 GrabJointRotationOffset;  // 0xF8
public bool UseGrabFixedRotation;  // 0x110
public EntityGrabOffsetInfo[] EntitySpecificGrabOffsets;  // 0x118
public StateNotificationMode GrabReleaseNotificationMode;  // 0x120
public HashString GrabReleaseState;  // 0x128
public StateNotificationMode GrabbedNotificationMode;  // 0x138
public HashString GrabbedState;  // 0x140
public StateNotificationMode GrabbedHurtNotificationMode;  // 0x150
public HashString GrabbedHurtState;  // 0x158
public StateNotificationMode DroppedNotificationMode;  // 0x168
public HashString DroppedState;  // 0x170
public StateNotificationMode DroppedOnHurtNotificationMode;  // 0x180
public HashString DroppedOnHurtState;  // 0x188
public StateNotificationMode ThrownNotificationMode;  // 0x198
public HashString ThrownState;  // 0x1A0
public StateNotificationMode UsedNotificationMode;  // 0x1B0
public HashString UsedState;  // 0x1B8
```
Methods:
```
public void GetGrabOffset(int entityID, out FPVector3 globalOffset, out FPVector3 localOffset, out FPVector3 rotationOffset, out bool useFixedRotation)   // RVA 0x2153A10
public void .ctor()   // RVA 0x2153B60
```

### Quantum.CombatSettingsData  (bases: AssetObject; TypeDefIndex 10197)
Fields:
```
public static readonly HashString GrabSlotID;  // 0x0
public static readonly HashString ItemSlotID;  // 0x10
public AttackDataValues DefaultAttackValues;  // 0x20
public AttackMultiplier[] AttackValueMultipliers;  // 0x110
public FP HitStunFramesMultiplier;  // 0x118
public FP HitStunFramesAdd;  // 0x120
public FP MaxKnockbackForJabLock;  // 0x128
public int PercentageDifferenceToClank;  // 0x130
public FP RedirectBiasAngleStep;  // 0x138
public FP MaxDamage;  // 0x140
public FP SakuraiMinKnockbackThreshold;  // 0x148
public FP SakuraiMaxKnockbackThreshold;  // 0x150
public FP AutoLinkGroundedAngle;  // 0x158
public FP AutoLinkSpeedCapFrameCheck;  // 0x160
public FP AutoLinkSpeedCap;  // 0x168
public FP DefaultDIAngle;  // 0x170
public DIForKnockback[] DIAngles;  // 0x178
public FP SDIThreshold;  // 0x180
public FP SDIMinAngleDifference;  // 0x188
public FP[] SDIDistances;  // 0x190
public FP ASDIDistance;  // 0x198
public FP KnockbackStackMultiplierThreshold;  // 0x1A0
public FP KnockbackStackIgnoreThreshold;  // 0x1A8
public FP BaseDamageForKnockback;  // 0x1B0
public FP ExtraDamageForKnockbackIncreaseRate;  // 0x1B8
public FP MaxExtraDamageForKnockback;  // 0x1C0
public int ExtraDamageForKnockbackResetFrames;  // 0x1C8
public FP DefaultStaminaGrabFrames;  // 0x1D0
public FP DefaultGrabFrames;  // 0x1D8
public FP GrabFramesDamageMultiplier;  // 0x1E0
public FP GrabReboundHitLagFrames;  // 0x1E8
public InputFlag GrabEscapeButton;  // 0x1F0
public FP GrabEscapeMinFrames;  // 0x1F8
public FP GrabButtonMashReducedFrames;  // 0x200
public FP DirectionMashReducedFrames;  // 0x208
public FP RespawnWaitFrames;  // 0x210
public InputFlag BlockButton;  // 0x218
public int TechBufferFrames;  // 0x21C
public int TechLockFrames;  // 0x220
public int PerfectBlockFramesRange;  // 0x224
public int PerfectBlockLockFrames;  // 0x228
public int PerfectBlockStunFrames;  // 0x22C
public int PerfectBlockInstigatorHitLagFrames;  // 0x230
public int PerfectBlockVictimHitLagFrames;  // 0x234
public int BlockBreakHitLagFrames;  // 0x238
public int BlockBreakMinimumStun;  // 0x23C
public FP BlockBreakExtraStunMultiplier;  // 0x240
public FP MaxBlockStamina;  // 0x248
public FP BlockStaminaDecreaseRate;  // 0x250
public FP BlockStaminaRecoveryRate;  // 0x258
public int GroundAttackMaxChargeFrames;  // 0x260
public int FramesToReleaseChargeGroundAttack;  // 0x264
public int AirAttackMaxChargeFrames;  // 0x268
public int FramesToReleaseChargeAirAttack;  // 0x26C
```
Methods:
```
internal FP GetHitLagMultiplier(Frame frame)   // RVA 0x20AAC60
public FP CalculateDIAngle(FP knockback)   // RVA 0x2150B20
public FP GetRedirectAngle(FP originalAngle)   // RVA 0x2150B90
public bool TryGetAttackMultiplier(int identifierHash, out AttackDataValues attackValues)   // RVA 0x2150BE0
public void .ctor()   // RVA 0x2150E90
private static void .cctor()   // RVA 0x2150DC0
```

### Quantum.AttackDatasPool  (bases: AssetObject; TypeDefIndex 10198)
Fields:
```
public AttackData[] AttackDatas;  // 0x20
```
Methods:
```
public void .ctor()   // RVA 0x214F2D0
```

### Quantum.StateMachineData  (bases: AssetObject; TypeDefIndex 10199)
Fields:
```
public AssetRefStateMachineData ParentStateMachine;  // 0x20
public StateMachineDataVariable[] Variables;  // 0x28
public AssetRefState[] States;  // 0x30
public HashString InitialState;  // 0x38
public HashString OnUpdateState;  // 0x48
public StateNotificationMode OnDestroyNotificationMode;  // 0x58
public HashString OnDestroyState;  // 0x60
private Dictionary<int, State> <StateHashDict>k__BackingField;  // 0x70
private bool <Initialized>k__BackingField;  // 0x78
```
Methods:
```
public Dictionary<int, State> get_StateHashDict()   // RVA 0x5DC820
public void set_StateHashDict(Dictionary<int, State> value)   // RVA 0x5DC940
public bool get_Initialized()   // RVA 0x5BAA00
public void set_Initialized(bool value)   // RVA 0x5BAB60
public void Init(Frame frame, bool force = False)   // RVA 0x215C530
private void CacheStates(Frame frame, bool force = False)   // RVA 0x215C480
public void RetrieveVariables(Frame frame, ref List<StateMachineDataVariable> variablesList)   // RVA 0x215C760
public void RetrieveStates(Frame frame, ref Dictionary<int, State> statesDict)   // RVA 0x215C540
public bool TryGetState(Frame frame, int stateHash, out State state)   // RVA 0x215C920
public void .ctor()   // RVA 0x215CA40
```

### Quantum.State  (bases: AssetObject; TypeDefIndex 10200)
Fields:
```
public HashString Name;  // 0x20
public HashString MoveName;  // 0x30
public HashString[] AdditionalExecutedMoves;  // 0x40
public StateLogicChacheData LogicCacheData;  // 0x48
private StateBehaviour[] <Behaviours>k__BackingField;  // 0x58
private Dictionary<AssetGuid, StateBehaviour> <BehavioursDict>k__BackingField;  // 0x60
private Dictionary<int, List<StateBehaviour>> <GroupsDict>k__BackingField;  // 0x68
private Dictionary<int, int> <GroupIndexes>k__BackingField;  // 0x70
private bool <Initialized>k__BackingField;  // 0x78
```
Methods:
```
public StateBehaviour[] get_Behaviours()   // RVA 0x5B45B0
public void set_Behaviours(StateBehaviour[] value)   // RVA 0x5B45D0
public Dictionary<AssetGuid, StateBehaviour> get_BehavioursDict()   // RVA 0x5818A0
public void set_BehavioursDict(Dictionary<AssetGuid, StateBehaviour> value)   // RVA 0x5B45C0
public Dictionary<int, List<StateBehaviour>> get_GroupsDict()   // RVA 0x5A5150
public void set_GroupsDict(Dictionary<int, List<StateBehaviour>> value)   // RVA 0x54C4A0
public Dictionary<int, int> get_GroupIndexes()   // RVA 0x5DC820
public void set_GroupIndexes(Dictionary<int, int> value)   // RVA 0x5DC940
public bool get_Initialized()   // RVA 0x5BAA00
public void set_Initialized(bool value)   // RVA 0x5BAB60
public void Init(Frame frame)   // RVA 0x215E660
public void Enter(Frame frame, CachedEntityData entityData)   // RVA 0x215CAC0
public void Update(Frame frame, CachedEntityData entityData, int stateFrame)   // RVA 0x215EB10
public void Exit(Frame frame, CachedEntityData entityData)   // RVA 0x215E5E0
public void ExecuteStateGroup(Frame frame, CachedEntityData entityData, HashString groupName, StateGroupExecutionMode executionMode = 1)   // RVA 0x215DE10
public void ExecuteEventGroup(Frame frame, CachedEntityData entityData, StateGroupEvent groupEvent)   // RVA 0x215D900
private void ExecuteBehavioursEnter(Frame frame, CachedEntityData entityData)   // RVA 0x215CDB0
private void ExecuteBehavioursUpdate(Frame frame, CachedEntityData entityData, int currentFrame)   // RVA 0x215D510
private void ExecuteScheduledBehaviours(Frame frame, CachedEntityData entityData, int currentFrame)   // RVA 0x215DA20
private void ExecuteBehavioursExit(Frame frame, CachedEntityData entityData)   // RVA 0x215D1A0
public void .ctor()   // RVA 0x215EC20
```

### Quantum.StateBehaviour  (bases: AssetObject; TypeDefIndex 10201)
Fields:
```
public bool Enabled;  // 0x20
public bool HasConditions;  // 0x21
public AdvancedConditionLogicalOperator LogicalOperator;  // 0x24
public AdvancedCondition[] Conditions;  // 0x28
public HashString GroupName;  // 0x30
public BehaviourTargetEntity TargetEntity;  // 0x40
public HashString TargetIndexParameterID;  // 0x48
public int StartFrame;  // 0x58
protected bool HasUpdateLogic;  // 0x5C
```
Methods:
```
public void Enter(Frame frame, CachedEntityData entityData)   // RVA 0x215ACD0
public void Execute(Frame frame, CachedEntityData stateMachineOwner)   // RVA 0x215B200
public void Update(Frame frame, CachedEntityData entityData, int currentFrame)   // RVA 0x215BCA0
public void Exit(Frame frame, CachedEntityData entityData)   // RVA 0x215B530
private bool EvaluateCondition(Frame frame, CachedEntityData targetEntityData)   // RVA 0x215B050
private bool HasReachedEndFrame(int currentFrame)   // RVA 0x215BA00
protected void MarkAsExecuted(Frame frame, CachedEntityData entityData)   // RVA 0x215BB00
private bool HasBeenExecuted(Frame frame, CachedEntityData entityData)   // RVA 0x215B930
protected void MarkAsFinished(Frame frame, CachedEntityData entityData)   // RVA 0x215BBD0
private bool IsFinished(Frame frame, CachedEntityData entityData)   // RVA 0x215BA30
protected void ExecuteGroup(Frame frame, CachedEntityData targetEntityData, ExecuteGroupEvent GroupToExecute)   // RVA 0x215B100
protected void .ctor()   // RVA 0x215C420
```

### Quantum.AnimationsPoolData  (bases: AssetObject; TypeDefIndex 10202)
Fields:
```
public AssetRefAnimationClipData[] ClipsDataRefs;  // 0x20
public SubAnimatorClipsInfo[] ClipsDataRefsSubAnimFullSync;  // 0x28
public SubAnimatorClipsInfo[] ClipsDataRefsSubAnimNoFullSync;  // 0x30
private Dictionary<int, AnimationClipData> <ClipsDict>k__BackingField;  // 0x38
private Dictionary<int, Dictionary<int, AnimationClipData>> <ClipsDictSubAnimFullSync>k__BackingField;  // 0x40
private Dictionary<int, Dictionary<int, AnimationClipData>> <ClipsDictSubAnimNoFullSync>k__BackingField;  // 0x48
```
Methods:
```
public Dictionary<int, AnimationClipData> get_ClipsDict()   // RVA 0x5C5B40
public void set_ClipsDict(Dictionary<int, AnimationClipData> value)   // RVA 0x5C5B90
public Dictionary<int, Dictionary<int, AnimationClipData>> get_ClipsDictSubAnimFullSync()   // RVA 0x5C5B30
public void set_ClipsDictSubAnimFullSync(Dictionary<int, Dictionary<int, AnimationClipData>> value)   // RVA 0x5C5B80
public Dictionary<int, Dictionary<int, AnimationClipData>> get_ClipsDictSubAnimNoFullSync()   // RVA 0x5C9FA0
public void set_ClipsDictSubAnimNoFullSync(Dictionary<int, Dictionary<int, AnimationClipData>> value)   // RVA 0x58D130
public bool TryGetClipFromHash(Frame frame, int clipHash, out AnimationClipData clipData)   // RVA 0x214E960
public bool TryGetClipFromIndex(Frame frame, int clipIndex, out AnimationClipData clipData)   // RVA 0x214EB10
public bool TryGetSubAnimClipFromHash(Frame frame, int subAnimatorHash, int clipHash, out AnimationClipData clipData, bool fullSync)   // RVA 0x214EBD0
public bool TryGetSubAnimationsClipDatas(Frame frame, int subAnimatorHash, bool fullSync, out AssetRefAnimationClipData[] animationAnimClipData)   // RVA 0x214F050
public void .ctor()   // RVA 0x214F190
```

### Quantum.AnimationClipData  (bases: AssetObject; TypeDefIndex 10203)
Fields:
```
public int ClipIndex;  // 0x20
public HashString ClipName;  // 0x28
public FP Duration;  // 0x38
public VisibilityFrame[] BakedVisibilityData;  // 0x40
public BlendShapeFrame[] BakedBlendShapeData;  // 0x48
```
Methods:
```
public int GetClosestBakedVisibilityFrame(int animationFrame)   // RVA 0x214E880
public int GetClosestBakedBlendShapeFrame(int animationFrame)   // RVA 0x214E820
public void .ctor()   // RVA 0x214E8E0
```

### Quantum.AnimationBakedJointsData  (bases: AssetObject; TypeDefIndex 10204)
Fields:
```
public AnimationJointsData[] AnimationsJointData;  // 0x20
```
Methods:
```
public bool TryGetAnimationKeyFrameData(int clipIndex, int frame, out JointKeyFrame keyFrame)   // RVA 0x214E6E0
public bool TryGetAnimationKinematicMotion(int clipIndex, int frame, out FPVector2 kinematicMotionDiff)   // RVA 0x214E740
public void .ctor()   // RVA 0x214E7C0
```

### Quantum.TransformKeyFramesData  (bases: AssetObject; TypeDefIndex 10205)
Fields:
```
public List<TransformKeyFrame> TransformKeyFrames;  // 0x20
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CameraManagerData  (bases: AssetObject; TypeDefIndex 10206)
Fields:
```
public SimpleAABB StageCameraBounds;  // 0x20
public SimpleAABB DefaultViewPort;  // 0x40
public FP MaxHUDMultiplier;  // 0x60
public FP VerticalOffset;  // 0x68
public FP HorizontalOffset;  // 0x70
public FP ProjectionOffset;  // 0x78
public FP ZoomInMultiplier;  // 0x80
public FP ZoomOutMultiplier;  // 0x88
public bool ApplyInterpolation;  // 0x90
public FP PositionInterpolationSpeed;  // 0x98
public FP ZoomInterpolationSpeed;  // 0xA0
public bool TiltCamera;  // 0xA8
public float TiltXAngle;  // 0xAC
public float TiltMaxAngle;  // 0xB0
public float TiltSpeed;  // 0xB4
public float TiltFactor;  // 0xB8
```
Methods:
```
public FP GetSaveHUDSpaceMultiplier(FPVector2 maxPoint, GlobalCameraSettingsData globalData)   // RVA 0x214FC40
public static SimpleAABB GetCameraTargetsBounds(Frame frame, GlobalCameraSettingsData GlobalData, CameraManagerData cameraData, bool excludeCharacter = False)   // RVA 0x214F820
public SimpleAABB UpdateFocusPosition(FPVector2 CenterPosition, SimpleAABB BaseRect)   // RVA 0x63B230
public static bool CheckIfCameraTargetIsInsideStageBounds(CameraTarget* target, SimpleAABB StageCameraBounds)   // RVA 0x214F7B0
public SimpleAABB AdjustCameraRectInStageBounds(SimpleAABB cameraTargetRect)   // RVA 0x214F690
public void .ctor()   // RVA 0x214FDB0
```

### Quantum.GlobalCameraSettingsData  (bases: AssetObject; TypeDefIndex 10207)
Fields:
```
public FP FOV;  // 0x20
public FP EntityMarginOffset;  // 0x28
public FP HUDSaveSpaceMultiplier;  // 0x30
```
Methods:
```
public void .ctor()   // RVA 0x21539F0
```

### Quantum.StatusEffectBase  (bases: AssetObject; TypeDefIndex 10208)
Fields:
```
public HashString[] StatusEffectToRemoveByType;  // 0x20
public HashString[] BlockedByStatusEffectsByType;  // 0x28
public HashString OnApplyVFXID;  // 0x30
public VFXPlayAttributes OnApplyPlayAttributes;  // 0x40
public HashString OnRemoveVFXID;  // 0xD8
public VFXPlayAttributes OnRemovePlayAttributes;  // 0xE8
public HashString NameId;  // 0x180
public bool IsTimeBased;  // 0x190
public FP BaseFrameDuration;  // 0x198
public bool MashToReduceDuration;  // 0x1A0
public bool PreserveOnCharacterSwap;  // 0x1A1
public bool RemoveOnRespawn;  // 0x1A2
public EntityRef originEntity;  // 0x1A8
```
Methods:
```
public void Apply(Frame frame, EntityRef targetEntity, EntityRef originEntity)   // RVA 0x2160160
public void Remove(Frame frame, EntityRef targetEntity)   // RVA 0x21602D0
protected void .ctor()   // RVA 0x21603D0
```

### Quantum.StatusEffectsData  (bases: AssetObject; TypeDefIndex 10209)
Fields:
```
public AssetRefStatusEffectBase[] StatusEffectsAvailable;  // 0x20
private bool <Initialized>k__BackingField;  // 0x28
private Dictionary<HashString, StatusEffectBase> <StatusEffectsDict>k__BackingField;  // 0x30
```
Methods:
```
public bool get_Initialized()   // RVA 0x5BA5A0
public void set_Initialized(bool value)   // RVA 0x5BA5B0
public Dictionary<HashString, StatusEffectBase> get_StatusEffectsDict()   // RVA 0x503090
public void set_StatusEffectsDict(Dictionary<HashString, StatusEffectBase> value)   // RVA 0x52CEF0
public void Init(Frame frame)   // RVA 0x2160410
public void .ctor()   // RVA 0x50D320
```

### Quantum.SimulationConfig  (bases: AssetObject; TypeDefIndex 10245)
Fields:
```
public Navigation.Config Navigation;  // 0x20
public PhysicsCommon.Config Physics;  // 0x28
public FrameBase.EntitiesConfig Entities;  // 0x30
public SimulationConfig.AutoLoadSceneFromMapMode AutoLoadSceneFromMap;  // 0x38
public SimulationUpdateTime DeltaTimeType;  // 0x3C
public int ThreadCount;  // 0x40
public FP ChecksumSnapshotHistoryLengthSeconds;  // 0x48
public SimulationConfigChecksumErrorDumpOptions ChecksumErrorDumpOptions;  // 0x50
public HeapTrackingMode HeapTrackingMode;  // 0x54
public int HeapPageShift;  // 0x58
public int HeapPageCount;  // 0x5C
public int HeapExtraCount;  // 0x60
public AssetRefSpeedRunnersSettingsData SpeedRunnerSettings;  // 0x68
public PickupItemUsageDataFile[] PickupItemUsageDatas;  // 0x70
public AssetRefNPCSettingsData NPCSettingsData;  // 0x78
public CharacterDataFile[] CharacterDatas;  // 0x80
public GameModeFile[] GameModes;  // 0x88
public CollisionLayer[] GroundLayers;  // 0x90
public CollisionLayer[] ThinPlatformLayers;  // 0x98
public CollisionLayer[] DefaultCollisionLayer;  // 0xA0
public CollisionLayer[] DynamicObjectLayers;  // 0xA8
public PhysicsDataSurfaceType[] SurfaceTypes;  // 0xB0
public bool ComputeRedirectsAndReflects;  // 0xB8
public bool ComputeHitBoxAgainstHitBox;  // 0xB9
public AssetRefGameplayInputSettingsData GameplayInputSettingsData;  // 0xC0
public AssetRefCombatSettingsData CombatSettingsData;  // 0xC8
public AssetRefPlayerSettings DefaultNPCPlayerSettings;  // 0xD0
public AssetRefGameSpeedModifiersData GameSpeedModifiersData;  // 0xD8
public AssetRefStatusEffectsData StatusEffectsData;  // 0xE0
```
Methods:
```
public SpeedRunnersSettingsData GetSpeedRunnersSettingsData(Frame frame)   // RVA 0x215A990
public NPCSettingsData GetNPCSettingsData(Frame frame)   // RVA 0x215A850
public PickupItemUsageData GetPickupItemUsageData(Frame frame, int identifier)   // RVA 0x215A880
public GameEntityData GetCharacterGameEntityData(Frame frame, HashString characterID)   // RVA 0x215A600
public bool TryGetGameMode(Frame frame, out BaseGameMode gameMode)   // RVA 0x215AAA0
public GameplayInputSettingsData GetGameplayInputSettingsData(Frame frame)   // RVA 0x215A820
public CombatSettingsData GetCombatSettingsData(Frame frame)   // RVA 0x215A790
public SurfaceType GetSurfaceType(AssetRefPhysicsMaterial physicsMaterial)   // RVA 0x215A9F0
public PlayerSettings GetDefaultNPCPlayerSettings(Frame frame)   // RVA 0x215A7C0
public GameSpeedModifiersData GetGameSpeedModifiersData(Frame frame)   // RVA 0x215A7F0
public StatusEffectsData GetStatusEffectsData(Frame frame)   // RVA 0x215A9C0
public void .ctor()   // RVA 0x215AC50
```

### JsonAssetSerializerBase.AssetVisitor  (bases: IAssetObjectVisitor; TypeDefIndex 10277)
Fields:
```
public JsonAssetSerializerBase.FlatDatabaseFile Storage;  // 0x10
public JsonAssetSerializerBase Serializer;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```


## Events (101)

### Quantum.EventCharacterBoostUpdated  (bases: EventBase; TypeDefIndex 10079)
Fields:
```
public EntityRef Entity;  // 0x40
public FP Boost;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x21392B0
```

### Quantum.EventNotifyVOCharacterEvent  (bases: EventBase; TypeDefIndex 10080)
Fields:
```
public EntityRef Entity;  // 0x40
public GameplayCharacterVOEvent VOEvent;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139940
```

### Quantum.EventNotifyVOAnnouncerEvent  (bases: EventBase; TypeDefIndex 10081)
Fields:
```
public GameplayAnnouncerVOEvent VOEvent;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x21398F0
```

### Quantum.EventOnPickupItem  (bases: EventBase; TypeDefIndex 10082)
Fields:
```
public EntityRef Entity;  // 0x40
public int ItemID;  // 0x48
public QBoolean IsNewItem;  // 0x4C
public int CurrentUse;  // 0x50
```
Methods:
```
public void .ctor()   // RVA 0x2139E20
```

### Quantum.EventOnUseItem  (bases: EventBase; TypeDefIndex 10083)
Fields:
```
public EntityRef Entity;  // 0x40
public int ItemID;  // 0x48
public int CurrentUse;  // 0x4C
```
Methods:
```
public void .ctor()   // RVA 0x2139F70
```

### Quantum.EventOnDropItem  (bases: EventBase; TypeDefIndex 10084)
Fields:
```
public EntityRef Entity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139C40
```

### Quantum.EventShowTutorialStagePrompts  (bases: EventBase; TypeDefIndex 10085)
Methods:
```
public void .ctor()   // RVA 0x213A880
```

### Quantum.EventShowDialogue  (bases: EventBase; TypeDefIndex 10086)
Fields:
```
public QString64 DialogueID;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213A7E0
```

### Quantum.EventRaceTutorialLoadedAndReady  (bases: EventBase; TypeDefIndex 10087)
Methods:
```
public void .ctor()   // RVA 0x213A3D0
```

### Quantum.EventSetupCampaignLevelInfo  (bases: EventBase; TypeDefIndex 10088)

### Quantum.EventSaveChapterBestTime  (bases: EventBase; TypeDefIndex 10089)
Fields:
```
public FP ChapterTime;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213A660
```

### Quantum.EventCampaignMatchLoadedAndReady  (bases: EventBase; TypeDefIndex 10090)
Methods:
```
public void .ctor()   // RVA 0x2139260
```

### Quantum.EventPlayCampaignDialogue  (bases: EventBase; TypeDefIndex 10091)
Methods:
```
public void .ctor()   // RVA 0x213A020
```

### Quantum.EventRestartCampaignMatch  (bases: EventBase; TypeDefIndex 10092)
Methods:
```
public void .ctor()   // RVA 0x213A4C0
```

### Quantum.EventCampaignChapterCompleted  (bases: EventBase; TypeDefIndex 10093)
Methods:
```
public void .ctor()   // RVA 0x2139230
```

### Quantum.EventPlayerWrongDirection  (bases: EventBase; TypeDefIndex 10094)
Fields:
```
public EntityRef CharacterEntity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213A3A0
```

### Quantum.EventPlayerNearDeath  (bases: EventBase; TypeDefIndex 10095)
Fields:
```
public EntityRef CharacterEntity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213A360
```

### Quantum.EventEscapeRoomStarted  (bases: EventBase; TypeDefIndex 10096)
Methods:
```
public void .ctor()   // RVA 0x2139600
```

### Quantum.EventEscapeRoomCompleted  (bases: EventBase; TypeDefIndex 10097)
Methods:
```
public void .ctor()   // RVA 0x21395D0
```

### Quantum.EventEscapeRoomCourseFinished  (bases: EventBase; TypeDefIndex 10098)

### Quantum.EventRestartEscapeRoomCourse  (bases: EventBase; TypeDefIndex 10099)
Methods:
```
public void .ctor()   // RVA 0x213A4F0
```

### Quantum.EventBossFightStarted  (bases: EventBase; TypeDefIndex 10100)
Methods:
```
public void .ctor()   // RVA 0x2139200
```

### Quantum.EventBossFightCompleted  (bases: EventBase; TypeDefIndex 10101)
Methods:
```
public void .ctor()   // RVA 0x21391D0
```

### Quantum.EventRestartBossFight  (bases: EventBase; TypeDefIndex 10102)
Methods:
```
public void .ctor()   // RVA 0x213A490
```

### Quantum.EventUpdateBossHealthPointsHUD  (bases: EventBase; TypeDefIndex 10103)
Fields:
```
public QBoolean ReduceHealth;  // 0x40
public FP NewStamina;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x213ABF0
```

### Quantum.EventUpdatePlayerHealthPointsHUD  (bases: EventBase; TypeDefIndex 10104)
Fields:
```
public QBoolean ReduceHealth;  // 0x40
public FP NewStamina;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x213AC40
```

### Quantum.EventResetPlayerHealthPointsHUD  (bases: EventBase; TypeDefIndex 10105)
Methods:
```
public void .ctor()   // RVA 0x213A430
```

### Quantum.EventResetBossHealthPointsHUD  (bases: EventBase; TypeDefIndex 10106)
Methods:
```
public void .ctor()   // RVA 0x213A400
```

### Quantum.EventDisableBossHealthHUD  (bases: EventBase; TypeDefIndex 10107)
Methods:
```
public void .ctor()   // RVA 0x2139430
```

### Quantum.EventSetInitialBossHUDInfo  (bases: EventBase; TypeDefIndex 10108)
Fields:
```
public FP InitialHealthPoints;  // 0x40
public QString64 BossID;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x213A6C0
```

### Quantum.EventLapsRaceCompleted  (bases: EventBase; TypeDefIndex 10109)

### Quantum.EventRestartLapsRace  (bases: EventBase; TypeDefIndex 10110)
Methods:
```
public void .ctor()   // RVA 0x213A550
```

### Quantum.EventRestartHazardsRace  (bases: EventBase; TypeDefIndex 10111)
Methods:
```
public void .ctor()   // RVA 0x213A520
```

### Quantum.EventMechanicTutorialGoalsUpdated  (bases: EventBase; TypeDefIndex 10112)
Methods:
```
public void .ctor()   // RVA 0x21397A0
```

### Quantum.EventMechanicTutorialStarted  (bases: EventBase; TypeDefIndex 10113)
Methods:
```
public void .ctor()   // RVA 0x21397D0
```

### Quantum.EventMechanicTutorialCompleted  (bases: EventBase; TypeDefIndex 10114)
Methods:
```
public void .ctor()   // RVA 0x2139770
```

### Quantum.EventTutorialSectionFinished  (bases: EventBase; TypeDefIndex 10115)
Methods:
```
public void .ctor()   // RVA 0x213AAE0
```

### Quantum.EventRestartTutorialSection  (bases: EventBase; TypeDefIndex 10116)
Methods:
```
public void .ctor()   // RVA 0x213A5B0
```

### Quantum.EventRestartTrainingMatch  (bases: EventBase; TypeDefIndex 10117)
Methods:
```
public void .ctor()   // RVA 0x213A580
```

### Quantum.EventHazardsIncoming  (bases: EventBase; TypeDefIndex 10118)
Fields:
```
public HashString HazardType;  // 0x40
public int Direction;  // 0x50
```
Methods:
```
public void .ctor()   // RVA 0x21396A0
```

### Quantum.EventHideHazardsIndicators  (bases: EventBase; TypeDefIndex 10119)
Methods:
```
public void .ctor()   // RVA 0x21396D0
```

### Quantum.EventOnCollectorScoreUpdate  (bases: EventBase; TypeDefIndex 10120)
Fields:
```
public EntityRef Entity;  // 0x40
public int Score;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139C00
```

### Quantum.EventOnLapFinished  (bases: EventBase; TypeDefIndex 10121)
Fields:
```
public FP LapTime;  // 0x40
public EntityRef CharacterEntity;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139D60
```

### Quantum.EventMatchStarted  (bases: EventBase; TypeDefIndex 10122)
Methods:
```
public void .ctor()   // RVA 0x2139700
```

### Quantum.EventShowIntroAnimation  (bases: EventBase; TypeDefIndex 10123)
Methods:
```
public void .ctor()   // RVA 0x213A800
```

### Quantum.EventShowCountdownBannerAnimation  (bases: EventBase; TypeDefIndex 10124)
Methods:
```
public void .ctor()   // RVA 0x213A7A0
```

### Quantum.EventPlayStageMusicPart2  (bases: EventBase; TypeDefIndex 10125)
Methods:
```
public void .ctor()   // RVA 0x213A1C0
```

### Quantum.EventCountdownFinished  (bases: EventBase; TypeDefIndex 10126)
Methods:
```
public void .ctor()   // RVA 0x2139360
```

### Quantum.EventUpdateBlastzone  (bases: EventBase; TypeDefIndex 10127)
Fields:
```
public SimpleAABB BlastzoneRect;  // 0x40
public QBoolean Reset;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x213ABA0
```

### Quantum.EventCharacterKnockout  (bases: EventBase; TypeDefIndex 10128)
Fields:
```
public FPVector2 KnockedCharacterPosition;  // 0x40
public QBoolean ScreenExplosion;  // 0x50
```
Methods:
```
public void .ctor()   // RVA 0x21392F0
```

### Quantum.EventShowRaceRoundEndMessage  (bases: EventBase; TypeDefIndex 10129)
Fields:
```
public EntityRef WinnerEntity;  // 0x40
public int RoundsWon;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x213A850
```

### Quantum.EventRoundStart  (bases: EventBase; TypeDefIndex 10130)
Methods:
```
public void .ctor()   // RVA 0x213A620
```

### Quantum.EventTimeRaceTimer  (bases: EventBase; TypeDefIndex 10131)
Fields:
```
public FP Time;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213AA80
```

### Quantum.EventResetRaceTimer  (bases: EventBase; TypeDefIndex 10132)
Methods:
```
public void .ctor()   // RVA 0x213A460
```

### Quantum.EventNotifyRaceEnd  (bases: EventBase; TypeDefIndex 10133)
Fields:
```
public Frame Frame;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x21398B0
```

### Quantum.EventOnResetRaceRound  (bases: EventBase; TypeDefIndex 10134)
Methods:
```
public void .ctor()   // RVA 0x2139E80
```

### Quantum.EventUpdateBlastzoneTimer  (bases: EventBase; TypeDefIndex 10135)
Fields:
```
public FP Countdown;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213AB20
```

### Quantum.EventRocketsIncoming  (bases: EventBase; TypeDefIndex 10136)
Fields:
```
public FP Time;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213A5F0
```

### Quantum.EventStayInTheAir  (bases: EventBase; TypeDefIndex 10137)
Fields:
```
public PlayerRef PlayerRef;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213A8B0
```

### Quantum.EventOnSecretRoomDiscovered  (bases: EventBase; TypeDefIndex 10138)
Fields:
```
public EntityRef TriggerEntity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139EC0
```

### Quantum.EventTreasurePickedUp  (bases: EventBase; TypeDefIndex 10139)
Fields:
```
public PlayerRef PlayerRef;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213AAB0
```

### Quantum.EventNotifyBlockState  (bases: EventBase; TypeDefIndex 10140)
Fields:
```
public EntityRef Entity;  // 0x40
public QBoolean Blocking;  // 0x48
public FP BlockStamina;  // 0x50
```
Methods:
```
public void .ctor()   // RVA 0x2139830
```

### Quantum.EventDrawDebugLine  (bases: EventBase; TypeDefIndex 10141)
Fields:
```
public FPVector2 Start;  // 0x40
public FPVector2 End;  // 0x50
public ColorRGBA Color;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x21395A0
```

### Quantum.EventDrawDebugCircle  (bases: EventBase; TypeDefIndex 10142)
Fields:
```
public FPVector2 Position;  // 0x40
public FP Radius;  // 0x50
public ColorRGBA Color;  // 0x58
```
Methods:
```
public void .ctor()   // RVA 0x2139530
```

### Quantum.EventDrawDebugAABB  (bases: EventBase; TypeDefIndex 10143)
Fields:
```
public SimpleAABB AABB;  // 0x40
public ColorRGBA Color;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x21394C0
```

### Quantum.EventPringDebugMessage  (bases: EventBase; TypeDefIndex 10144)
Fields:
```
public QString128 Message;  // 0x40
```

### Quantum.EventDebugAlert  (bases: EventBase; TypeDefIndex 10145)
Fields:
```
public string Message;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139400
```

### Quantum.EventCustomLogMessage  (bases: EventBase; TypeDefIndex 10146)
Fields:
```
public string Message;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x21393B0
```

### Quantum.EventOnCharacterActivation  (bases: EventBase; TypeDefIndex 10147)
Fields:
```
public EntityRef Entity;  // 0x40
public CharacterActivationType ActivationType;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139A00
```

### Quantum.EventOnCharacterDeactivation  (bases: EventBase; TypeDefIndex 10148)
Fields:
```
public EntityRef Entity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139A90
```

### Quantum.EventOnCharacterLoaded  (bases: EventBase; TypeDefIndex 10149)
Fields:
```
public EntityRef Entity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139B10
```

### Quantum.EventPlayCharacterFootstepSFX  (bases: EventBase; TypeDefIndex 10150)
Fields:
```
public EntityRef Entity;  // 0x40
public int EventID;  // 0x48
public SurfaceType SurfaceType;  // 0x4C
```
Methods:
```
public void .ctor()   // RVA 0x213A090
```

### Quantum.EventOnCharacterKnockOut  (bases: EventBase; TypeDefIndex 10151)
Fields:
```
public EntityRef Entity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139AD0
```

### Quantum.EventOnCharacterDamageUpdate  (bases: EventBase; TypeDefIndex 10152)
Fields:
```
public EntityRef CharacterEntity;  // 0x40
public FP Damage;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139A50
```

### Quantum.EventOnCharacterStocksUpdate  (bases: EventBase; TypeDefIndex 10153)
Fields:
```
public EntityRef CharacterEntity;  // 0x40
public int Stocks;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139BB0
```

### Quantum.EventOnCharacterStaminaUpdate  (bases: EventBase; TypeDefIndex 10154)
Fields:
```
public EntityRef CharacterEntity;  // 0x40
public FP Stamina;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139B60
```

### Quantum.EventOnCharacterPointsUpdate  (bases: EventBase; TypeDefIndex 10155)

### Quantum.EventPlayStageMusic  (bases: EventBase; TypeDefIndex 10156)
Methods:
```
public void .ctor()   // RVA 0x213A1F0
```

### Quantum.EventPlaySFX  (bases: EventBase; TypeDefIndex 10157)
Fields:
```
public QString256 EventID;  // 0x40
public FPVector2 Location;  // 0x140
public FP Delay;  // 0x150
public QBoolean UpdateSoundPosition;  // 0x158
public EntityRef EntityRef;  // 0x160
```
Methods:
```
public void .ctor()   // RVA 0x213A190
```

### Quantum.EventSetSFXParameter  (bases: EventBase; TypeDefIndex 10158)
Fields:
```
public QString128 EventID;  // 0x40
public QString128 ParameterID;  // 0xC0
public QString128 ParameterStringValue;  // 0x140
public FP ParameterFloatValue;  // 0x1C0
public EntityRef EntityRef;  // 0x1C8
public QBoolean StringParameter;  // 0x1D0
public QBoolean GlobalParameters;  // 0x1D4
```
Methods:
```
public void .ctor()   // RVA 0x213A770
```

### Quantum.EventStopSFX  (bases: EventBase; TypeDefIndex 10159)
Fields:
```
public QString256 EventID;  // 0x40
public EntityRef EntityRef;  // 0x140
```
Methods:
```
public void .ctor()   // RVA 0x213A950
```

### Quantum.EventPlayNonDeterministicAnimation  (bases: EventBase; TypeDefIndex 10160)
Fields:
```
public QString128 TriggerID;  // 0x40
public EntityRef EntityRef;  // 0xC0
```
Methods:
```
public void .ctor()   // RVA 0x213A0F0
```

### Quantum.EventSyncTimeline  (bases: EventBase; TypeDefIndex 10161)
Fields:
```
public FP SyncValue;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213AA40
```

### Quantum.EventSetEventVolume  (bases: EventBase; TypeDefIndex 10162)
Fields:
```
public QString128 EventID;  // 0x40
public EntityRef EntityRef;  // 0xC0
public FP VolumeMultiplier;  // 0xC8
```

### Quantum.EventSetInstanceVolume  (bases: EventBase; TypeDefIndex 10163)
Fields:
```
public EntityRef GameEntity;  // 0x40
public FP VolumeMultiplier;  // 0x48
```

### Quantum.EventGameEntityVisibilityChanged  (bases: EventBase; TypeDefIndex 10164)
Fields:
```
public EntityRef GameEntity;  // 0x40
public QBoolean Visible;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139640
```

### Quantum.EventClearSlots  (bases: EventBase; TypeDefIndex 10165)
Fields:
```
public int EntityIndex;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139330
```

### Quantum.EventPlayVFX  (bases: EventBase; TypeDefIndex 10166)
Fields:
```
public int VFXID;  // 0x40
public EntityRef Entity;  // 0x48
public VFXPlayAttributes PlayAttributes;  // 0x50
```
Methods:
```
public void .ctor()   // RVA 0x213A320
```

### Quantum.EventStopVFX  (bases: EventBase; TypeDefIndex 10167)
Fields:
```
public int VFXID;  // 0x40
public int EntityIndex;  // 0x44
public VFXStopAttributes StopAttributes;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x213AA00
```

### Quantum.EventStopAllVFX  (bases: EventBase; TypeDefIndex 10168)
Fields:
```
public int EntityIndex;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x213A8F0
```

### Quantum.EventOnLoadingFinished  (bases: EventBase; TypeDefIndex 10169)
Fields:
```
public Frame Frame;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139DB0
```

### Quantum.EventOnPlayersInputEnabled  (bases: EventBase; TypeDefIndex 10170)
Methods:
```
public void .ctor()   // RVA 0x2139E50
```

### Quantum.EventNotifyMatchFinished  (bases: EventBase; TypeDefIndex 10171)
Methods:
```
public void .ctor()   // RVA 0x2139860
```

### Quantum.EventOnUpdateTimeScale  (bases: EventBase; TypeDefIndex 10172)
Fields:
```
public FP TimeScale;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139F00
```

### Quantum.EventPlayCameraShake  (bases: EventBase; TypeDefIndex 10173)
Fields:
```
public int PresetID;  // 0x40
public QBoolean OverrideForce;  // 0x44
public FP Force;  // 0x48
public QBoolean OverrideVelocity;  // 0x50
public FPVector3 Velocity;  // 0x58
```
Methods:
```
public void .ctor()   // RVA 0x2139FF0
```

### Quantum.EventOnCameraUpdateForced  (bases: EventBase; TypeDefIndex 10174)
Fields:
```
public SimpleAABB CameraRect;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x21399B0
```

### Quantum.EventOnEntityStartGrab  (bases: EventBase; TypeDefIndex 10175)
Fields:
```
public EntityRef Entity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139CD0
```

### Quantum.EventOnEntityStopGrab  (bases: EventBase; TypeDefIndex 10176)
Fields:
```
public EntityRef Entity;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139D10
```

### Quantum.EventOnEnergyBarUpdate  (bases: EventBase; TypeDefIndex 10177)
Fields:
```
public EntityRef Entity;  // 0x40
public FP EnergyAmount;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x2139C90
```

### Quantum.EventMatchTimerCreated  (bases: EventBase; TypeDefIndex 10178)

### Quantum.EventMatchTimerUpdate  (bases: EventBase; TypeDefIndex 10179)
Fields:
```
public FP CurrentTime;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x2139740
```


## Commands (2)

### Quantum.BaseCommand  (bases: DeterministicCommand; TypeDefIndex 10426)
Methods:
```
protected void .ctor()   // RVA 0x50D320
```

### DebugCommand.InternalCommand  (bases: DeterministicCommand; TypeDefIndex 10697)
Methods:
```
public void .ctor()   // RVA 0x50D320
```


## Everything else (structs, classes, interfaces) (686)

### <Module>  (bases: ; TypeDefIndex 9796)

### Quantum.BitSet1024  (bases: ; TypeDefIndex 9859)
Fields:
```
private BitSet1024.<bits>e__FixedBuffer bits;  // 0x0
```
Methods:
```
public void Set(int bit)   // RVA 0x20C8360
public bool IsSet(int bit)   // RVA 0x20C82C0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C82F0
```

### Quantum.BitSet12  (bases: ; TypeDefIndex 9861)
Fields:
```
private BitSet12.<bits>e__FixedBuffer bits;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C8430
```

### Quantum.BitSet128  (bases: ; TypeDefIndex 9863)
Fields:
```
private BitSet128.<bits>e__FixedBuffer bits;  // 0x0
```

### Quantum.BitSet2048  (bases: ; TypeDefIndex 9865)
Fields:
```
private BitSet2048.<bits>e__FixedBuffer bits;  // 0x0
```

### Quantum.BitSet256  (bases: ; TypeDefIndex 9867)
Fields:
```
private BitSet256.<bits>e__FixedBuffer bits;  // 0x0
```

### Quantum.BitSet4096  (bases: ; TypeDefIndex 9869)
Fields:
```
private BitSet4096.<bits>e__FixedBuffer bits;  // 0x0
```

### Quantum.BitSet512  (bases: ; TypeDefIndex 9871)
Fields:
```
private BitSet512.<bits>e__FixedBuffer bits;  // 0x0
```

### Quantum.QString128  (bases: IQString, IEquatable<QString128>; TypeDefIndex 9873)
Fields:
```
public ushort ByteCount;  // 0x0
public QString128.<Bytes>e__FixedBuffer Bytes;  // 0x2
```
Methods:
```
public void .ctor(string str)   // RVA 0x20D0AF0
public static QString128 op_Implicit(string str)   // RVA 0x20D0B40
public static string op_Implicit(QString128 str)   // RVA 0x20D0A90
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D09F0
```

### Quantum.QString256  (bases: IQString, IEquatable<QString256>; TypeDefIndex 9875)
Fields:
```
public ushort ByteCount;  // 0x0
public QString256.<Bytes>e__FixedBuffer Bytes;  // 0x2
```
Methods:
```
public void .ctor(string str)   // RVA 0x20D0EA0
public static QString256 op_Implicit(string str)   // RVA 0x20D0EF0
public static string op_Implicit(QString256 str)   // RVA 0x20D0E40
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D0DA0
```

### Quantum.QString64  (bases: IQString, IEquatable<QString64>; TypeDefIndex 9877)
Fields:
```
public ushort ByteCount;  // 0x0
public QString64.<Bytes>e__FixedBuffer Bytes;  // 0x2
```
Methods:
```
public void .ctor(string str)   // RVA 0x20D11C0
public static QString64 op_Implicit(string str)   // RVA 0x20D1210
public static string op_Implicit(QString64 str)   // RVA 0x20D1160
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D10C0
```

### Quantum.QStringUtf8_64  (bases: IQStringUtf8, IEquatable<QStringUtf8_64>; TypeDefIndex 9879)
Fields:
```
public ushort ByteCount;  // 0x0
public QStringUtf8_64.<Bytes>e__FixedBuffer Bytes;  // 0x2
```
Methods:
```
public void .ctor(string str)   // RVA 0x20D1510
public static QStringUtf8_64 op_Implicit(string str)   // RVA 0x20D15E0
public static string op_Implicit(QStringUtf8_64 str)   // RVA 0x20D1560
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D13F0
```

### Quantum.AssetRefAnimationBakedJointsData  (bases: IEquatable<AssetRefAnimationBakedJointsData>, IAssetRef<AnimationBakedJointsData>; TypeDefIndex 9880)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefAnimationClipData  (bases: IEquatable<AssetRefAnimationClipData>, IAssetRef<AnimationClipData>; TypeDefIndex 9881)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefAnimationsPoolData  (bases: IEquatable<AssetRefAnimationsPoolData>, IAssetRef<AnimationsPoolData>; TypeDefIndex 9882)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefApplyImpulse_Behaviour  (bases: IEquatable<AssetRefApplyImpulse_Behaviour>, IAssetRef<ApplyImpulse_Behaviour>; TypeDefIndex 9883)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static AssetRefApplyImpulse_Behaviour op_Implicit(ApplyImpulse_Behaviour value)   // RVA 0x20C7040
public static bool op_Equality(AssetRefApplyImpulse_Behaviour a, AssetRefApplyImpulse_Behaviour b)   // RVA 0x1E5C0E0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefAttackDatasPool  (bases: IEquatable<AssetRefAttackDatasPool>, IAssetRef<AttackDatasPool>; TypeDefIndex 9884)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefBaseGameMode  (bases: IEquatable<AssetRefBaseGameMode>, IAssetRef<BaseGameMode>; TypeDefIndex 9885)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefCameraManagerData  (bases: IEquatable<AssetRefCameraManagerData>, IAssetRef<CameraManagerData>; TypeDefIndex 9886)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefCombatData  (bases: IEquatable<AssetRefCombatData>, IAssetRef<CombatData>; TypeDefIndex 9887)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefCombatSettingsData  (bases: IEquatable<AssetRefCombatSettingsData>, IAssetRef<CombatSettingsData>; TypeDefIndex 9888)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefGameEntityData  (bases: IEquatable<AssetRefGameEntityData>, IAssetRef<GameEntityData>; TypeDefIndex 9889)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefGameSpeedModifiersData  (bases: IEquatable<AssetRefGameSpeedModifiersData>, IAssetRef<GameSpeedModifiersData>; TypeDefIndex 9890)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefGameplayInputSettingsData  (bases: IEquatable<AssetRefGameplayInputSettingsData>, IAssetRef<GameplayInputSettingsData>; TypeDefIndex 9891)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefGlobalCameraSettingsData  (bases: IEquatable<AssetRefGlobalCameraSettingsData>, IAssetRef<GlobalCameraSettingsData>; TypeDefIndex 9892)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefGrabData  (bases: IEquatable<AssetRefGrabData>, IAssetRef<GrabData>; TypeDefIndex 9893)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefInputCheck_Behaviour  (bases: IEquatable<AssetRefInputCheck_Behaviour>, IAssetRef<InputCheck_Behaviour>; TypeDefIndex 9894)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static AssetRefInputCheck_Behaviour op_Implicit(InputCheck_Behaviour value)   // RVA 0x20C7040
public static bool op_Equality(AssetRefInputCheck_Behaviour a, AssetRefInputCheck_Behaviour b)   // RVA 0x1E5C0E0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefItemsData  (bases: IEquatable<AssetRefItemsData>, IAssetRef<ItemsData>; TypeDefIndex 9895)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefJumpSettingsData  (bases: IEquatable<AssetRefJumpSettingsData>, IAssetRef<JumpSettingsData>; TypeDefIndex 9896)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefMovesetLimiterData  (bases: IEquatable<AssetRefMovesetLimiterData>, IAssetRef<MovesetLimiterData>; TypeDefIndex 9897)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefNPCSettingsData  (bases: IEquatable<AssetRefNPCSettingsData>, IAssetRef<NPCSettingsData>; TypeDefIndex 9898)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefPhysicsData  (bases: IEquatable<AssetRefPhysicsData>, IAssetRef<PhysicsData>; TypeDefIndex 9899)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefPickupItemUsageData  (bases: IEquatable<AssetRefPickupItemUsageData>, IAssetRef<PickupItemUsageData>; TypeDefIndex 9900)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefPlayerSettings  (bases: IEquatable<AssetRefPlayerSettings>, IAssetRef<PlayerSettings>; TypeDefIndex 9901)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefRoomConfig  (bases: IEquatable<AssetRefRoomConfig>, IAssetRef<RoomConfig>; TypeDefIndex 9902)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefSpeedRunnersSettingsData  (bases: IEquatable<AssetRefSpeedRunnersSettingsData>, IAssetRef<SpeedRunnersSettingsData>; TypeDefIndex 9903)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefState  (bases: IEquatable<AssetRefState>, IAssetRef<State>; TypeDefIndex 9904)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefStateBehaviour  (bases: IEquatable<AssetRefStateBehaviour>, IAssetRef<StateBehaviour>; TypeDefIndex 9905)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefStateMachineData  (bases: IEquatable<AssetRefStateMachineData>, IAssetRef<StateMachineData>; TypeDefIndex 9906)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static bool op_Inequality(AssetRefStateMachineData a, AssetRefStateMachineData b)   // RVA 0x20C7F70
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefStatusEffectBase  (bases: IEquatable<AssetRefStatusEffectBase>, IAssetRef<StatusEffectBase>; TypeDefIndex 9907)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static AssetRefStatusEffectBase op_Implicit(StatusEffectBase value)   // RVA 0x20C7040
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.AssetRefStatusEffectsData  (bases: IEquatable<AssetRefStatusEffectsData>, IAssetRef<StatusEffectsData>; TypeDefIndex 9908)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.AssetRefTransformKeyFramesData  (bases: IEquatable<AssetRefTransformKeyFramesData>, IAssetRef<TransformKeyFramesData>; TypeDefIndex 9909)
Fields:
```
public AssetGuid Id;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6E00
```

### Quantum.ActionData  (bases: ; TypeDefIndex 9910)
Fields:
```
public InputFlag Flag;  // 0x0
public FP FrameDelay;  // 0x8
public FP Frames;  // 0x10
public QBoolean Overriden;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6BF0
```

### Quantum.AnimationSpeedElement  (bases: ; TypeDefIndex 9911)
Fields:
```
public int Frame;  // 0x0
public FP Speed;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C6CC0
```

### Quantum.ButtonTimersContainer  (bases: ; TypeDefIndex 9914)
Fields:
```
private ButtonTimersContainer.<_InputButtonTimers_>e__FixedBuffer _InputButtonTimers_;  // 0x0
private ButtonTimersContainer.<_InputDirectionTimers_>e__FixedBuffer _InputDirectionTimers_;  // 0x30
```
Methods:
```
public FixedArray<InputTimer> get_InputButtonTimers()   // RVA 0x20C8EB0
public FixedArray<InputTimer> get_InputDirectionTimers()   // RVA 0x20C8F20
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20C8CD0
```

### Quantum.ChildEntity  (bases: ; TypeDefIndex 9915)
Fields:
```
public EntityRef Entity;  // 0x0
public FPVector2 InitialPosition;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CCDB0
```

### Quantum.CustomAnimatorPlayableClipInfo  (bases: IEquatable<CustomAnimatorPlayableClipInfo>; TypeDefIndex 9916)
Fields:
```
public int ClipIndex;  // 0x0
public FP EndTime;  // 0x18
public StateGroupExecutionMode GroupExecutionMode;  // 0x10
public int GroupHash;  // 0x4
public QBoolean IsLooping;  // 0x8
public FP RuntimeWeight;  // 0x20
public FP Speed;  // 0x28
public FP StartTime;  // 0x30
public FP Time;  // 0x38
public QBoolean TriggeredEndEvent;  // 0xC
public FP Weight;  // 0x40
private static readonly CustomAnimatorPlayableClipInfo <None>k__BackingField;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CD5B0
public static CustomAnimatorPlayableClipInfo get_None()   // RVA 0x20CD830
public FP get_ClipDuration()   // RVA 0x20CD810
public void Update(FP deltaTime, FP totalWeight, FP transitionWeight, out bool notifyFinishEvent)   // RVA 0x20CD6E0
public bool Finished(bool ignoreLoop = True)   // RVA 0x20CD4B0
public static bool op_Equality(CustomAnimatorPlayableClipInfo a, CustomAnimatorPlayableClipInfo b)   // RVA 0x20CD8A0
public static bool op_Inequality(CustomAnimatorPlayableClipInfo a, CustomAnimatorPlayableClipInfo b)   // RVA 0x20CD8F0
```

### Quantum.CustomSubAnimatorPlayableClipInfo  (bases: ; TypeDefIndex 9917)
Fields:
```
public CustomAnimatorPlayableClipInfo ClipInfo;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CD960
public void Update(Frame frame, FP deltaTime)   // RVA 0x20CDB10
public void StopAnimation()   // RVA 0x20CDA90
```

### Quantum.DamageOverride  (bases: ; TypeDefIndex 9918)
Fields:
```
public int EnemySetDamage;  // 0x0
public int OwnerSetDamage;  // 0x4
public int TeamSetDamage;  // 0x8
public QBoolean UseSetDamageFromEnemy;  // 0xC
public QBoolean UseSetDamageFromOwner;  // 0x10
public QBoolean UseSetDamageFromTeam;  // 0x14
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CDBD0
```

### Quantum.EntityHitFilter  (bases: ; TypeDefIndex 9919)
Fields:
```
public QBoolean AlwaysIfTeam;  // 0x18
public CombatInteractionPolicy CharacterInteractionPolicy;  // 0x0
public DamageOverride DamageOverrideInfo;  // 0x2C
public QBoolean DamageOwner;  // 0x1C
public QBoolean DamagedByOwner;  // 0x20
public CombatInteractionPolicy HazardInteractionPolicy;  // 0x4
public QBoolean IgnoreEnemy;  // 0x24
public QBoolean IsAlwaysEnemy;  // 0x28
public CombatInteractionPolicy ItemInteractionPolicy;  // 0x8
public CombatInteractionPolicy ProjectileInteractionPolicy;  // 0xC
public CombatInteractionPolicy SameOwnerInteractionPolicy;  // 0x10
public CombatInteractionPolicy StageInteractionPolicy;  // 0x14
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CDD80
```

### Quantum.EntityModifierInfo  (bases: ; TypeDefIndex 9920)
Fields:
```
public FP ScaleMultiplier;  // 0x0
public FP SpeedMultiplier;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20A9200
```

### Quantum.EnvironmentCollisionBox  (bases: ; TypeDefIndex 9921)
Fields:
```
public FPVector2 Bottom;  // 0x8
public RuntimeECBOffset BottomOffset;  // 0x98
public FPVector2 CacheBottom;  // 0x18
public FPVector2 CacheLeft;  // 0x28
public FPVector2 CacheRight;  // 0x38
public FPVector2 CacheTop;  // 0x48
public FPVector2 Left;  // 0x58
public RuntimeECBOffset LeftOffset;  // 0xA8
public int PresetID;  // 0x0
public FPVector2 PreviousGlobalCenter;  // 0x68
public FPVector2 Right;  // 0x78
public RuntimeECBOffset RightOffset;  // 0xB8
public QBoolean RootAsBottom;  // 0x4
public FPVector2 Top;  // 0x88
public RuntimeECBOffset TopOffset;  // 0xC8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CEB20
public void Update(Frame frame, PhysicsData physicsData, GameEntity* gameEntity, PhysicsBody* physicsBody)   // RVA 0x20CEE00
public void ClearCache()   // RVA 0x20CE060
public FPVector2 Center()   // RVA 0x20CE020
public FPVector2 GlobalCenter(Transform2D* transform)   // RVA 0x20CE9C0
public FPVector2 GlobalTop(Transform2D* transform)   // RVA 0x20CEAD0
public FPVector2 GlobalBottom(Transform2D* transform)   // RVA 0x20CE980
public FPVector2 GlobalLeft(Transform2D* transform)   // RVA 0x20CEA50
public FPVector2 GlobalRight(Transform2D* transform)   // RVA 0x20CEA90
public FPVector2 Size()   // RVA 0x20CEDA0
private void ECBFromCache(GameEntity* gameEntity, bool rootAsBottom)   // RVA 0x20CE0D0
private void ECBFromPreset(Frame frame, PhysicsData physicsData, GameEntity* gameEntity, bool rootAsBottom)   // RVA 0x20CE2F0
public void GenerateECB(int facingDirection, bool rootAsBottom, FP highestX, FP highestY, FP lowestX, FP lowestY)   // RVA 0x20CE510
private FP CalculateECBOffset(FP point, RuntimeECBOffset offset, bool inverted = False)   // RVA 0x20CDFE0
```

### Quantum.ExperienceEventData  (bases: ; TypeDefIndex 9922)
Fields:
```
public int Count;  // 0x0
public QString64 ID;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CEF10
```

### Quantum.GameEntityReference  (bases: ; TypeDefIndex 9923)
Fields:
```
public EntityRef Entity;  // 0x0
public QString64 OutputVariableID;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CF070
```

### Quantum.HitBox  (bases: ; TypeDefIndex 9924)
Fields:
```
public QBoolean Active;  // 0x10
private Ptr AttackDatasPtr;  // 0x18
public FPVector2 CacheGlobalOffset;  // 0x28
public FPVector3 CacheLocalOffset;  // 0x68
public FPVector2 CachePoint;  // 0x38
public FPVector2 CurrentPosition;  // 0x48
public HitBoxType HitBoxType;  // 0x4
public int ID;  // 0x8
public QBoolean Interpolate;  // 0x14
public int JointID;  // 0xC
public FPVector2 PreviousPosition;  // 0x58
public HitBoxPriority Priority;  // 0x0
public FP Radius;  // 0x20
public SimpleAABB RectArea;  // 0x80
```
Methods:
```
public QListPtr<int> get_AttackDatas()   // RVA 0x20CF800
public void set_AttackDatas(QListPtr<int> value)   // RVA 0x6A4F50
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CF290
public bool TryGetAttackData(Frame frame, CombatEntity check, CombatEntity target, out AttackData attackData)   // RVA 0x20CF4A0
public bool IsDefault()   // RVA 0x20CF250
public bool IsReflectOrRedirect()   // RVA 0x20CF270
```

### Quantum.HitEvent  (bases: ; TypeDefIndex 9925)
Fields:
```
public HitType HitType;  // 0x0
public EntityRef PlayerOwner;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CF860
```

### Quantum.HitInfo  (bases: ; TypeDefIndex 9926)
Fields:
```
public FP Angle;  // 0x48
public int AttackDataID;  // 0x8
public FP BlockDamage;  // 0x50
public FP BlockHitLag;  // 0x58
public FP BlockPushDistance;  // 0x60
public FP BlockStun;  // 0x68
public QBoolean Blocked;  // 0xC
public FP DIMultiplier;  // 0x70
public FP Damage;  // 0x78
public FPVector2 Direction;  // 0xB8
public QBoolean Flinchless;  // 0x10
public HitBoxSpecialBehaviour HitBoxHorizontalBehaviour;  // 0x4
public FPVector2 HitBoxPosition;  // 0xC8
public FP HitLag;  // 0x80
public FP HitStun;  // 0x88
public EntityRef Instigator;  // 0x28
public FP InstigatorAdvantageOnBlock;  // 0x90
public FP InstigatorAdvantageOnHit;  // 0x98
public EntityRef InstigatorCharacterEntity;  // 0x30
public FP InstigatorPushBack;  // 0xA0
public QBoolean IsVictimInvincible;  // 0x14
public QBoolean JabLock;  // 0x18
public FP Knockback;  // 0xA8
public QBoolean PerfectBlock;  // 0x1C
public FP SDIMultiplier;  // 0xB0
public QBoolean Trade;  // 0x20
public QBoolean Untechable;  // 0x24
public EntityRef Victim;  // 0x38
public EntityRef VictimCharacterEntity;  // 0x40
public AttackVictimDirection VictimDirection;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CFCA0
public FP GetValue(HitInfoVariable variable)   // RVA 0x20CFAB0
```

### Quantum.HurtBox  (bases: ; TypeDefIndex 9927)
Fields:
```
public FPVector2 CacheGlobalOffsetA;  // 0x20
public FPVector2 CacheGlobalOffsetB;  // 0x30
public FPVector3 CacheLocalOffsetA;  // 0x80
public FPVector3 CacheLocalOffsetB;  // 0x98
public FPVector2 CachePointA;  // 0x40
public FPVector2 CachePointB;  // 0x50
public int ID;  // 0x0
public QBoolean IsIntangible;  // 0xC
public QBoolean IsInvincible;  // 0x10
public int JointA;  // 0x4
public int JointB;  // 0x8
public FPVector2 PointA;  // 0x60
public FPVector2 PointB;  // 0x70
public FP Radius;  // 0x18
public SimpleAABB RectArea;  // 0xB0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D0060
```

### Quantum.Input  (bases: ; TypeDefIndex 9928)
Fields:
```
public InputFlag InputFlag;  // 0x4
public sbyte LeftStickX;  // 0x0
public sbyte LeftStickY;  // 0x1
```
Methods:
```
public static Input Read(FrameSerializer serializer)   // RVA 0x20D0460
public static void Write(FrameSerializer serializer, Input i)   // RVA 0x20D05B0
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D0510
```

### Quantum.InputTimer  (bases: ; TypeDefIndex 9929)
Fields:
```
public int FramesSinceButtonPress;  // 0x0
public int FramesSinceButtonRelease;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D0260
```

### Quantum.InputValue  (bases: ; TypeDefIndex 9930)
Fields:
```
public InputFlag IgnoreFlag;  // 0x0
public InputFlag InputFlag;  // 0x4
public FP LeftStickX;  // 0x10
public QBoolean LeftStickXSpent;  // 0x8
public FP LeftStickY;  // 0x18
public QBoolean LeftStickYSpent;  // 0xC
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D0350
```

### Quantum.MoveLimit  (bases: ; TypeDefIndex 9931)
Fields:
```
public int MaxUses;  // 0x0
public QBoolean ResetOnHurt;  // 0x8
public QBoolean SpendGrounded;  // 0xC
public QBoolean SpendInAir;  // 0x10
public int UsesAvailable;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D06A0
```

### Quantum.ObjectVisibilityData  (bases: ; TypeDefIndex 9932)
Fields:
```
public int ObjectIDHash;  // 0x0
public int RigIDHash;  // 0x4
public QBoolean Visibility;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D0790
```

### Quantum.PhysicsModifierInfo  (bases: ; TypeDefIndex 9933)
Fields:
```
public FP AccelerationMultiplier;  // 0x0
public FP DecelerationMultiplier;  // 0x8
public FP GravityMultiplier;  // 0x10
public FP VelocityMultiplier;  // 0x18
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20A71D0
```

### Quantum.RuntimeECBOffset  (bases: ; TypeDefIndex 9934)
Fields:
```
public ECBOffsetOperation Operation;  // 0x0
public FP Value;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D1680
public void .ctor(FP value, ECBOffsetOperation operation)   // RVA 0x20D1700
```

### Quantum.RuntimeEscapeRoomGoal  (bases: ; TypeDefIndex 9935)
Fields:
```
public int ID;  // 0x0
public int RequiredNotificationsToComplete;  // 0x4
```

### Quantum.RuntimeGameSpeedModifier  (bases: ; TypeDefIndex 9936)
Fields:
```
public QBoolean AlterEngine;  // 0x4
public QBoolean AlterSimulation;  // 0x8
public int ID;  // 0x0
public FP Multiplier;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D17A0
```

### Quantum.RuntimeMechanicTutorialGoal  (bases: ; TypeDefIndex 9937)
Fields:
```
public int ID;  // 0x0
public int RequiredNotificationsToComplete;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D1870
```

### Quantum.RuntimePhysics  (bases: ; TypeDefIndex 9938)
Fields:
```
public FP AirAcceleration;  // 0x8
public FP AirExtraFrictionFactor;  // 0x10
public FP AirExtraFrictionThresholdMax;  // 0x18
public FP AirExtraFrictionThresholdMin;  // 0x20
public FP AirFriction;  // 0x28
public FP AirSpeed;  // 0x30
public QBoolean CrowdPushEnabled;  // 0x0
public FP CrowdPushMaxForce;  // 0x38
public FP CrowdPushMinForce;  // 0x40
public FP CrowdPushRadius;  // 0x48
public FP FallSpeed;  // 0x50
public FP FloorRotationInfluence;  // 0x58
public FP FloorRotationSpeed;  // 0x60
public FP Gravity;  // 0x68
public FP GravityMultiplier;  // 0x70
public FP GroundAcceleration;  // 0x78
public FP GroundExtraFrictionFactor;  // 0x80
public FP GroundExtraFrictionThresholdMax;  // 0x88
public FP GroundExtraFrictionThresholdMin;  // 0x90
public FP GroundFriction;  // 0x98
public FP GroundFrictionStep;  // 0xA0
public FP HitStunAirFriction;  // 0xA8
public FP HitStunFallSpeed;  // 0xB0
public FP HitStunGravity;  // 0xB8
public FP HitStunGroundFriction;  // 0xC0
public FP KnockbackDecay;  // 0xC8
public FP RunSpeed;  // 0xD0
public FP TargetGroundFriction;  // 0xD8
public FP WalkFastSpeed;  // 0xE0
public FP WalkSlowSpeed;  // 0xE8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D2090
public FP CalculateGravity(Frame frame, EntityRef entity, PhysicsBody* physicsBody, bool hitStunned)   // RVA 0x20D1D50
public FP CalculateAcceleration(Frame frame, EntityRef entity, PhysicsBody* physicsBody)   // RVA 0x20D1900
public FP CalculateDeceleration(Frame frame, EntityRef entity, PhysicsBody* physicsBody, bool hitStunned)   // RVA 0x20D1A70
public FP CalculateFallSpeed(Frame frame, EntityRef entity, PhysicsBody* physicsBody, bool hitStunned)   // RVA 0x20D1D30
public FP CalculateVelocityMultiplier(Frame frame, EntityRef entity, PhysicsBody* physicsBody)   // RVA 0x20D1E10
```

### Quantum.RuntimeStatusEffect  (bases: ; TypeDefIndex 9939)
Fields:
```
public int NameId;  // 0x0
public EntityRef OriginEntity;  // 0x18
public int OriginId;  // 0x4
public FP RemainingFrames;  // 0x20
public AssetRefStatusEffectBase StatusEffectData;  // 0x10
public int Type;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D2320
```

### Quantum.SFXToExecute  (bases: ; TypeDefIndex 9940)
Fields:
```
public FP Delay;  // 0x0
public QString256 EventID;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D2470
```

### Quantum.ScheduledBehaviour  (bases: ; TypeDefIndex 9941)
Fields:
```
public AssetGuid Behaviour;  // 0x8
public int Frame;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D2570
```

### Quantum.SimpleAABB  (bases: IEquatable<SimpleAABB>; TypeDefIndex 9942)
Fields:
```
public FPVector2 BottomRight;  // 0x0
public FPVector2 TopLeft;  // 0x10
public static readonly SimpleAABB Default;  // 0x0
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20CD180
public FPVector2 get_TopRight()   // RVA 0x20D2C70
public FPVector2 get_BottomLeft()   // RVA 0x20D2A90
public FP get_Width()   // RVA 0x20D2D50
public FP get_Height()   // RVA 0x20D2B00
public FPVector2 get_Center()   // RVA 0x20D2AC0
public FPVector2 get_Top()   // RVA 0x20D2CA0
public FPVector2 get_Right()   // RVA 0x20D2BC0
public FPVector2 get_Left()   // RVA 0x20D2B10
public static bool op_Equality(SimpleAABB lhs, SimpleAABB rhs)   // RVA 0x20D2D60
public void .ctor(FP toply, FP botry, FP toplx, FP botrx)   // RVA 0x20D2A60
public void .ctor(FPVector2 toplv, FPVector2 botrv)   // RVA 0x20D2A80
public void Include(FPVector2 pt)   // RVA 0x20D2840
public bool Intersects(SimpleAABB other)   // RVA 0x20D28C0
public bool Inside(FPVector2 pt)   // RVA 0x20D2890
private static void .cctor()   // RVA 0x20D2A00
```

### Quantum.SlotAttachmentData  (bases: ; TypeDefIndex 9943)
Fields:
```
public int PropIDHash;  // 0x0
public int RigIDHash;  // 0x4
public TargetSlot Slot;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D2E70
```

### Quantum.StageEntity  (bases: ; TypeDefIndex 9944)
Fields:
```
public EntityRef Entity;  // 0x0
public QString128 Id;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D2F80
```

### Quantum.StatusEffectAttribute  (bases: ; TypeDefIndex 9945)
Fields:
```
public FP AddBaseValue;  // 0x0
public FP FixedValue;  // 0x8
public FP MultiplierBaseValue;  // 0x10
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20AA1B0
```

### Quantum.StatusEffectAttributeModifier  (bases: ; TypeDefIndex 9946)
Fields:
```
public StatusEffectModifierOperation Operation;  // 0x4
public int OriginId;  // 0x0
public FP Value;  // 0x8
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D3080
```

### Quantum.TargetStatePerEntity  (bases: ; TypeDefIndex 9947)
Fields:
```
public GameEntityType EntityType;  // 0x0
public QString64 TargetState;  // 0x4
```
Methods:
```
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D31D0
```

### Quantum.TransformKeyFrame  (bases: ; TypeDefIndex 9948)
Fields:
```
public FPVector2 Position;  // 0x8
public FP Rotation;  // 0x0
```

### Quantum._globals_  (bases: ; TypeDefIndex 9950)
Fields:
```
public FP DeltaTime;  // 0x20
public QBoolean FrameByFrameActive;  // 0x0
public FrameMetaData FrameMetaData;  // 0xC0
public QBoolean LoadingFinished;  // 0x4
public EntityRef ManagersEntity;  // 0x18
public AssetRefMap Map;  // 0x8
public NavMeshRegionMask NavMeshRegions;  // 0x88
public PhysicsSceneSettings PhysicsSettings;  // 0x168
public PhysicsEngineState PhysicsState2D;  // 0x90
public PhysicsEngineState PhysicsState3D;  // 0xA0
public BitSet12 PlayerLastConnectionState;  // 0x10
public RNGSession RngSession;  // 0xB0
public BitSet1024 Systems;  // 0xE8
private _globals_.<_input_>e__FixedBuffer _input_;  // 0x28
```
Methods:
```
public FixedArray<Input> get_input()   // RVA 0x20D3930
public static void Serialize(void* ptr, FrameSerializer serializer)   // RVA 0x20D3690
```

### PlayerStats.<>c__DisplayClass41_0  (bases: ; TypeDefIndex 10022)
Fields:
```
public EntityRef damagedEntity;  // 0x10
public HitType hitType;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
internal bool <RevengeEvent>b__0(HitEvent x)   // RVA 0x2137B00
```

### SpeedRunnersNPC.<>c__DisplayClass38_0  (bases: ; TypeDefIndex 10038)
Fields:
```
public int Equipment;  // 0x10
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
internal bool <EquipmentLogic>b__0(NPCItemUseData x)   // RVA 0x2137AE0
```

### Frame.FrameSignals  (bases: ; TypeDefIndex 10067)
Fields:
```
private Frame _f;  // 0x0
```
Methods:
```
public void .ctor(Frame f)   // RVA 0x6AB620
public void OnPlayerDataSet(PlayerRef player)   // RVA 0x2141580
public void OnEntityPrototypeMaterialized(EntityRef entity, EntityPrototypeRef prototypeRef)   // RVA 0x21413D0
public void OnCollision2D(CollisionInfo2D info)   // RVA 0x2140E80
public void OnCollisionEnter2D(CollisionInfo2D info)   // RVA 0x2141050
public void OnCollisionExit2D(ExitInfo2D info)   // RVA 0x2141220
public void OnTrigger2D(TriggerInfo2D info)   // RVA 0x2141710
public void OnTriggerEnter2D(TriggerInfo2D info)   // RVA 0x21418E0
public void OnTriggerExit2D(ExitInfo2D info)   // RVA 0x2141AB0
```

### Frame.FrameEvents  (bases: ; TypeDefIndex 10068)
Fields:
```
private Frame _f;  // 0x0
```
Methods:
```
public static int GetParentEventID(int eventID)   // RVA 0x1E629D0
public static Type GetEventType(int eventID)   // RVA 0x213BFA0
public EventCharacterBoostUpdated CharacterBoostUpdated(EntityRef Entity, FP Boost)   // RVA 0x213B260
public EventNotifyVOCharacterEvent NotifyVOCharacterEvent(EntityRef Entity, GameplayCharacterVOEvent VOEvent)   // RVA 0x213D410
public EventNotifyVOAnnouncerEvent NotifyVOAnnouncerEvent(GameplayAnnouncerVOEvent VOEvent)   // RVA 0x213D2B0
public EventOnPickupItem OnPickupItem(EntityRef Entity, int ItemID, QBoolean IsNewItem, int CurrentUse)   // RVA 0x213E2B0
public EventOnUseItem OnUseItem(EntityRef Entity, int ItemID, int CurrentUse)   // RVA 0x213E6E0
public EventOnDropItem OnDropItem(EntityRef Entity)   // RVA 0x213DC40
public EventShowTutorialStagePrompts ShowTutorialStagePrompts()   // RVA 0x21402B0
public EventShowDialogue ShowDialogue(QString64 DialogueID)   // RVA 0x2140070
public EventRaceTutorialLoadedAndReady RaceTutorialLoadedAndReady()   // RVA 0x213F360
public EventSaveChapterBestTime SaveChapterBestTime(FP ChapterTime)   // RVA 0x213FBA0
public EventCampaignMatchLoadedAndReady CampaignMatchLoadedAndReady()   // RVA 0x213B1C0
public EventPlayCampaignDialogue PlayCampaignDialogue()   // RVA 0x213E9C0
public EventRestartCampaignMatch RestartCampaignMatch()   // RVA 0x213F680
public EventCampaignChapterCompleted CampaignChapterCompleted()   // RVA 0x213B120
public EventPlayerWrongDirection PlayerWrongDirection(EntityRef CharacterEntity)   // RVA 0x213F2A0
public EventPlayerNearDeath PlayerNearDeath(EntityRef CharacterEntity)   // RVA 0x213F1E0
public EventEscapeRoomStarted EscapeRoomStarted()   // RVA 0x213BDA0
public EventEscapeRoomCompleted EscapeRoomCompleted()   // RVA 0x213BD00
public EventRestartEscapeRoomCourse RestartEscapeRoomCourse()   // RVA 0x213F720
public EventBossFightStarted BossFightStarted()   // RVA 0x213B080
public EventBossFightCompleted BossFightCompleted()   // RVA 0x213AFE0
public EventRestartBossFight RestartBossFight()   // RVA 0x213F5E0
public EventUpdateBossHealthPointsHUD UpdateBossHealthPointsHUD(QBoolean ReduceHealth, FP NewStamina)   // RVA 0x2140D00
public EventUpdatePlayerHealthPointsHUD UpdatePlayerHealthPointsHUD(QBoolean ReduceHealth, FP NewStamina)   // RVA 0x2140DC0
public EventResetPlayerHealthPointsHUD ResetPlayerHealthPointsHUD()   // RVA 0x213F4A0
public EventResetBossHealthPointsHUD ResetBossHealthPointsHUD()   // RVA 0x213F400
public EventDisableBossHealthHUD DisableBossHealthHUD()   // RVA 0x213B820
public EventSetInitialBossHUDInfo SetInitialBossHUDInfo(FP InitialHealthPoints, QString64 BossID)   // RVA 0x213FC60
public EventRestartLapsRace RestartLapsRace()   // RVA 0x213F860
public EventRestartHazardsRace RestartHazardsRace()   // RVA 0x213F7C0
public EventMechanicTutorialGoalsUpdated MechanicTutorialGoalsUpdated()   // RVA 0x213CEA0
public EventMechanicTutorialStarted MechanicTutorialStarted()   // RVA 0x213CF40
public EventMechanicTutorialCompleted MechanicTutorialCompleted()   // RVA 0x213CE00
public EventTutorialSectionFinished TutorialSectionFinished()   // RVA 0x2140A40
public EventRestartTutorialSection RestartTutorialSection()   // RVA 0x213F9A0
public EventRestartTrainingMatch RestartTrainingMatch()   // RVA 0x213F900
public EventHazardsIncoming HazardsIncoming(HashString HazardType, int Direction)   // RVA 0x213CB30
public EventHideHazardsIndicators HideHazardsIndicators()   // RVA 0x213CC00
public EventOnCollectorScoreUpdate OnCollectorScoreUpdate(EntityRef Entity, int Score)   // RVA 0x213DB80
public EventOnLapFinished OnLapFinished(FP LapTime, EntityRef CharacterEntity)   // RVA 0x213E120
public EventMatchStarted MatchStarted()   // RVA 0x213CCA0
public EventShowIntroAnimation ShowIntroAnimation()   // RVA 0x2140150
public EventShowCountdownBannerAnimation ShowCountdownBannerAnimation()   // RVA 0x213FFD0
public EventPlayStageMusicPart2 PlayStageMusicPart2()   // RVA 0x213EF50
public EventCountdownFinished CountdownFinished()   // RVA 0x213B5E0
public EventUpdateBlastzone UpdateBlastzone(SimpleAABB BlastzoneRect, QBoolean Reset)   // RVA 0x2140BA0
public EventCharacterKnockout CharacterKnockout(FPVector2 KnockedCharacterPosition, QBoolean ScreenExplosion)   // RVA 0x213B3C0
public EventShowRaceRoundEndMessage ShowRaceRoundEndMessage(EntityRef WinnerEntity, int RoundsWon)   // RVA 0x21401F0
public EventRoundStart RoundStart()   // RVA 0x213FB00
public EventTimeRaceTimer TimeRaceTimer(FP Time)   // RVA 0x21408C0
public EventResetRaceTimer ResetRaceTimer()   // RVA 0x213F540
public EventNotifyRaceEnd NotifyRaceEnd(Frame Frame)   // RVA 0x213D1E0
public EventOnResetRaceRound OnResetRaceRound()   // RVA 0x213E4C0
public EventUpdateBlastzoneTimer UpdateBlastzoneTimer(FP Countdown)   // RVA 0x2140AE0
public EventRocketsIncoming RocketsIncoming(FP Time)   // RVA 0x213FA40
public EventStayInTheAir StayInTheAir(PlayerRef PlayerRef)   // RVA 0x2140350
public EventOnSecretRoomDiscovered OnSecretRoomDiscovered(EntityRef TriggerEntity)   // RVA 0x213E560
public EventTreasurePickedUp TreasurePickedUp(PlayerRef PlayerRef)   // RVA 0x2140980
public EventNotifyBlockState NotifyBlockState(EntityRef Entity, QBoolean Blocking, FP BlockStamina)   // RVA 0x213CFE0
public EventDrawDebugLine DrawDebugLine(FPVector2 Start, FPVector2 End, ColorRGBA Color)   // RVA 0x213BB90
public EventDrawDebugCircle DrawDebugCircle(FPVector2 Position, FP Radius, ColorRGBA Color)   // RVA 0x213BA20
public EventDrawDebugAABB DrawDebugAABB(SimpleAABB AABB, ColorRGBA Color)   // RVA 0x213B8C0
public EventDebugAlert DebugAlert(string Message)   // RVA 0x213B750
public EventCustomLogMessage CustomLogMessage(string Message)   // RVA 0x213B680
public EventOnCharacterActivation OnCharacterActivation(EntityRef Entity, CharacterActivationType ActivationType)   // RVA 0x213D640
public EventOnCharacterDeactivation OnCharacterDeactivation(EntityRef Entity)   // RVA 0x213D7C0
public EventOnCharacterLoaded OnCharacterLoaded(EntityRef Entity)   // RVA 0x213D940
public EventPlayCharacterFootstepSFX PlayCharacterFootstepSFX(EntityRef Entity, int EventID, SurfaceType SurfaceType)   // RVA 0x213EA60
public EventOnCharacterKnockOut OnCharacterKnockOut(EntityRef Entity)   // RVA 0x213D880
public EventOnCharacterDamageUpdate OnCharacterDamageUpdate(EntityRef CharacterEntity, FP Damage)   // RVA 0x213D700
public EventOnCharacterStocksUpdate OnCharacterStocksUpdate(EntityRef CharacterEntity, int Stocks)   // RVA 0x213DAC0
public EventOnCharacterStaminaUpdate OnCharacterStaminaUpdate(EntityRef CharacterEntity, FP Stamina)   // RVA 0x213DA00
public EventPlayStageMusic PlayStageMusic()   // RVA 0x213EFF0
public EventPlaySFX PlaySFX(QString256 EventID, FPVector2 Location, FP Delay, QBoolean UpdateSoundPosition, EntityRef EntityRef)   // RVA 0x213ED70
public EventSetSFXParameter SetSFXParameter(QString128 EventID, QString128 ParameterID, QString128 ParameterStringValue, FP ParameterFloatValue, EntityRef EntityRef, QBoolean StringParameter, QBoolean GlobalParameters)   // RVA 0x213FD40
public EventStopSFX StopSFX(QString256 EventID, EntityRef EntityRef)   // RVA 0x21404D0
public EventPlayNonDeterministicAnimation PlayNonDeterministicAnimation(QString128 TriggerID, EntityRef EntityRef)   // RVA 0x213EBC0
public EventSyncTimeline SyncTimeline(FP SyncValue)   // RVA 0x2140760
public EventGameEntityVisibilityChanged GameEntityVisibilityChanged(EntityRef GameEntity, QBoolean Visible)   // RVA 0x213BE40
public EventClearSlots ClearSlots(int EntityIndex)   // RVA 0x213B480
public EventPlayVFX PlayVFX(int VFXID, EntityRef Entity, VFXPlayAttributes PlayAttributes)   // RVA 0x213F090
public EventStopVFX StopVFX(int VFXID, int EntityIndex, VFXStopAttributes StopAttributes)   // RVA 0x2140690
public EventStopAllVFX StopAllVFX(int EntityIndex)   // RVA 0x2140410
public EventOnLoadingFinished OnLoadingFinished(Frame Frame)   // RVA 0x213E1E0
public EventOnPlayersInputEnabled OnPlayersInputEnabled()   // RVA 0x213E420
public EventNotifyMatchFinished NotifyMatchFinished()   // RVA 0x213D140
public EventOnUpdateTimeScale OnUpdateTimeScale(FP TimeScale)   // RVA 0x213E620
public EventPlayCameraShake PlayCameraShake(int PresetID, QBoolean OverrideForce, FP Force, QBoolean OverrideVelocity, FPVector3 Velocity)   // RVA 0x213E840
public EventOnCameraUpdateForced OnCameraUpdateForced(SimpleAABB CameraRect)   // RVA 0x213D570
public EventOnEntityStartGrab OnEntityStartGrab(EntityRef Entity)   // RVA 0x213DE60
public EventOnEntityStopGrab OnEntityStopGrab(EntityRef Entity)   // RVA 0x213DFC0
public EventOnEnergyBarUpdate OnEnergyBarUpdate(EntityRef Entity, FP EnergyAmount)   // RVA 0x213DDA0
public EventMatchTimerUpdate MatchTimerUpdate(FP CurrentTime)   // RVA 0x213CD40
public void .ctor(Frame f)   // RVA 0x6AB620
```

### Frame.FrameAssets  (bases: ; TypeDefIndex 10069)
Fields:
```
private Frame _f;  // 0x0
```
Methods:
```
public SpeedRunnersSettingsData SpeedRunnersSettingsData(AssetRefSpeedRunnersSettingsData assetRef)   // RVA 0x213AEE0
public NPCSettingsData NPCSettingsData(AssetRefNPCSettingsData assetRef)   // RVA 0x213ADE0
public PlayerSettings PlayerSettings(AssetRefPlayerSettings assetRef)   // RVA 0x213AE60
public GameplayInputSettingsData GameplayInputSettingsData(AssetRefGameplayInputSettingsData assetRef)   // RVA 0x213AD60
public GameSpeedModifiersData GameSpeedModifiersData(AssetRefGameSpeedModifiersData assetRef)   // RVA 0x213ACE0
public CombatSettingsData CombatSettingsData(AssetRefCombatSettingsData assetRef)   // RVA 0x213AC60
public StatusEffectsData StatusEffectsData(AssetRefStatusEffectsData assetRef)   // RVA 0x213AF60
public void .ctor(Frame f)   // RVA 0x6AB620
```

### Frame.RuntimePlayerData  (bases: ; TypeDefIndex 10070)
Fields:
```
public PlayerRef PlayerRef;  // 0x0
public int Tick;  // 0x4
public int ActorId;  // 0x8
public byte[] Data;  // 0x10
public RuntimePlayer Player;  // 0x18
```

### Frame.<>O  (bases: ; TypeDefIndex 10071)
Fields:
```
public static ComponentSerializeDelegate <0>__Serialize;  // 0x0
public static ComponentChangedDelegate <1>__OnRemoved;  // 0x8
public static ComponentSerializeDelegate <2>__Serialize;  // 0x10
public static ComponentSerializeDelegate <3>__Serialize;  // 0x18
public static ComponentSerializeDelegate <4>__Serialize;  // 0x20
public static ComponentSerializeDelegate <5>__Serialize;  // 0x28
public static ComponentSerializeDelegate <6>__Serialize;  // 0x30
public static ComponentSerializeDelegate <7>__Serialize;  // 0x38
public static ComponentSerializeDelegate <8>__Serialize;  // 0x40
public static ComponentChangedDelegate <9>__OnRemoved;  // 0x48
public static ComponentSerializeDelegate <10>__Serialize;  // 0x50
public static ComponentSerializeDelegate <11>__Serialize;  // 0x58
public static ComponentSerializeDelegate <12>__Serialize;  // 0x60
public static ComponentSerializeDelegate <13>__Serialize;  // 0x68
public static ComponentChangedDelegate <14>__OnRemoved;  // 0x70
public static ComponentSerializeDelegate <15>__Serialize;  // 0x78
public static ComponentSerializeDelegate <16>__Serialize;  // 0x80
public static ComponentSerializeDelegate <17>__Serialize;  // 0x88
public static ComponentChangedDelegate <18>__OnRemoved;  // 0x90
public static ComponentSerializeDelegate <19>__Serialize;  // 0x98
public static ComponentSerializeDelegate <20>__Serialize;  // 0xA0
public static ComponentChangedDelegate <21>__OnRemoved;  // 0xA8
public static ComponentSerializeDelegate <22>__Serialize;  // 0xB0
public static ComponentSerializeDelegate <23>__Serialize;  // 0xB8
public static ComponentSerializeDelegate <24>__Serialize;  // 0xC0
public static ComponentSerializeDelegate <25>__Serialize;  // 0xC8
public static ComponentSerializeDelegate <26>__Serialize;  // 0xD0
public static ComponentSerializeDelegate <27>__Serialize;  // 0xD8
public static ComponentSerializeDelegate <28>__Serialize;  // 0xE0
public static ComponentSerializeDelegate <29>__Serialize;  // 0xE8
public static ComponentSerializeDelegate <30>__Serialize;  // 0xF0
public static ComponentSerializeDelegate <31>__Serialize;  // 0xF8
public static ComponentSerializeDelegate <32>__Serialize;  // 0x100
public static ComponentChangedDelegate <33>__OnRemoved;  // 0x108
public static ComponentSerializeDelegate <34>__Serialize;  // 0x110
public static ComponentChangedDelegate <35>__OnRemoved;  // 0x118
public static ComponentSerializeDelegate <36>__Serialize;  // 0x120
public static ComponentSerializeDelegate <37>__Serialize;  // 0x128
public static ComponentSerializeDelegate <38>__Serialize;  // 0x130
public static ComponentChangedDelegate <39>__OnRemoved;  // 0x138
public static ComponentSerializeDelegate <40>__Serialize;  // 0x140
public static ComponentSerializeDelegate <41>__Serialize;  // 0x148
public static ComponentSerializeDelegate <42>__Serialize;  // 0x150
public static ComponentChangedDelegate <43>__OnRemoved;  // 0x158
public static ComponentSerializeDelegate <44>__Serialize;  // 0x160
public static ComponentChangedDelegate <45>__OnRemoved;  // 0x168
public static ComponentSerializeDelegate <46>__Serialize;  // 0x170
public static ComponentSerializeDelegate <47>__Serialize;  // 0x178
public static ComponentSerializeDelegate <48>__Serialize;  // 0x180
public static ComponentSerializeDelegate <49>__Serialize;  // 0x188
public static ComponentSerializeDelegate <50>__Serialize;  // 0x190
public static ComponentChangedDelegate <51>__OnRemoved;  // 0x198
public static ComponentSerializeDelegate <52>__Serialize;  // 0x1A0
public static ComponentSerializeDelegate <53>__Serialize;  // 0x1A8
public static ComponentChangedDelegate <54>__OnRemoved;  // 0x1B0
public static ComponentSerializeDelegate <55>__Serialize;  // 0x1B8
public static ComponentSerializeDelegate <56>__Serialize;  // 0x1C0
public static ComponentSerializeDelegate <57>__Serialize;  // 0x1C8
public static ComponentChangedDelegate <58>__OnRemoved;  // 0x1D0
public static ComponentSerializeDelegate <59>__Serialize;  // 0x1D8
public static ComponentSerializeDelegate <60>__Serialize;  // 0x1E0
public static ComponentSerializeDelegate <61>__Serialize;  // 0x1E8
public static ComponentSerializeDelegate <62>__Serialize;  // 0x1F0
public static ComponentSerializeDelegate <63>__Serialize;  // 0x1F8
public static ComponentSerializeDelegate <64>__Serialize;  // 0x200
public static ComponentSerializeDelegate <65>__Serialize;  // 0x208
public static ComponentSerializeDelegate <66>__Serialize;  // 0x210
public static ComponentChangedDelegate <67>__OnRemoved;  // 0x218
public static ComponentSerializeDelegate <68>__Serialize;  // 0x220
public static ComponentSerializeDelegate <69>__Serialize;  // 0x228
public static ComponentChangedDelegate <70>__OnRemoved;  // 0x230
public static ComponentSerializeDelegate <71>__Serialize;  // 0x238
public static ComponentSerializeDelegate <72>__Serialize;  // 0x240
public static ComponentSerializeDelegate <73>__Serialize;  // 0x248
public static ComponentChangedDelegate <74>__OnRemoved;  // 0x250
public static ComponentSerializeDelegate <75>__Serialize;  // 0x258
public static ComponentSerializeDelegate <76>__Serialize;  // 0x260
public static ComponentChangedDelegate <77>__OnRemoved;  // 0x268
public static ComponentSerializeDelegate <78>__Serialize;  // 0x270
public static ComponentChangedDelegate <79>__OnRemoved;  // 0x278
public static ComponentSerializeDelegate <80>__Serialize;  // 0x280
public static ComponentSerializeDelegate <81>__Serialize;  // 0x288
public static ComponentSerializeDelegate <82>__Serialize;  // 0x290
public static ComponentSerializeDelegate <83>__Serialize;  // 0x298
public static ComponentSerializeDelegate <84>__Serialize;  // 0x2A0
public static ComponentSerializeDelegate <85>__Serialize;  // 0x2A8
public static ComponentChangedDelegate <86>__OnRemoved;  // 0x2B0
public static ComponentSerializeDelegate <87>__Serialize;  // 0x2B8
public static ComponentSerializeDelegate <88>__Serialize;  // 0x2C0
public static ComponentSerializeDelegate <89>__Serialize;  // 0x2C8
public static ComponentSerializeDelegate <90>__Serialize;  // 0x2D0
public static ComponentSerializeDelegate <91>__Serialize;  // 0x2D8
public static ComponentSerializeDelegate <92>__Serialize;  // 0x2E0
public static ComponentSerializeDelegate <93>__Serialize;  // 0x2E8
public static ComponentSerializeDelegate <94>__Serialize;  // 0x2F0
public static ComponentSerializeDelegate <95>__Serialize;  // 0x2F8
public static ComponentSerializeDelegate <96>__Serialize;  // 0x300
public static ComponentSerializeDelegate <97>__Serialize;  // 0x308
public static ComponentSerializeDelegate <98>__Serialize;  // 0x310
public static ComponentSerializeDelegate <99>__Serialize;  // 0x318
public static ComponentSerializeDelegate <100>__Serialize;  // 0x320
public static ComponentChangedDelegate <101>__OnRemoved;  // 0x328
public static ComponentSerializeDelegate <102>__Serialize;  // 0x330
public static ComponentSerializeDelegate <103>__Serialize;  // 0x338
public static ComponentSerializeDelegate <104>__Serialize;  // 0x340
public static ComponentSerializeDelegate <105>__Serialize;  // 0x348
public static ComponentSerializeDelegate <106>__Serialize;  // 0x350
public static ComponentChangedDelegate <107>__OnRemoved;  // 0x358
public static ComponentSerializeDelegate <108>__Serialize;  // 0x360
public static ComponentSerializeDelegate <109>__Serialize;  // 0x368
public static ComponentChangedDelegate <110>__OnRemoved;  // 0x370
public static ComponentSerializeDelegate <111>__Serialize;  // 0x378
public static ComponentSerializeDelegate <112>__Serialize;  // 0x380
public static ComponentSerializeDelegate <113>__Serialize;  // 0x388
public static ComponentChangedDelegate <114>__OnRemoved;  // 0x390
public static ComponentSerializeDelegate <115>__Serialize;  // 0x398
public static ComponentChangedDelegate <116>__OnRemoved;  // 0x3A0
public static ComponentSerializeDelegate <117>__Serialize;  // 0x3A8
public static ComponentSerializeDelegate <118>__Serialize;  // 0x3B0
public static ComponentSerializeDelegate <119>__Serialize;  // 0x3B8
public static ComponentSerializeDelegate <120>__Serialize;  // 0x3C0
public static ComponentSerializeDelegate <121>__Serialize;  // 0x3C8
public static ComponentSerializeDelegate <122>__Serialize;  // 0x3D0
public static ComponentSerializeDelegate <123>__Serialize;  // 0x3D8
public static ComponentSerializeDelegate <124>__Serialize;  // 0x3E0
public static ComponentSerializeDelegate <125>__Serialize;  // 0x3E8
public static ComponentChangedDelegate <126>__OnRemoved;  // 0x3F0
public static ComponentSerializeDelegate <127>__Serialize;  // 0x3F8
public static ComponentChangedDelegate <128>__OnRemoved;  // 0x400
public static ComponentSerializeDelegate <129>__Serialize;  // 0x408
public static ComponentSerializeDelegate <130>__Serialize;  // 0x410
public static ComponentChangedDelegate <131>__OnRemoved;  // 0x418
public static ComponentSerializeDelegate <132>__Serialize;  // 0x420
public static ComponentSerializeDelegate <133>__Serialize;  // 0x428
public static ComponentSerializeDelegate <134>__Serialize;  // 0x430
```

### Frame.<>c  (bases: ; TypeDefIndex 10072)
Fields:
```
public static readonly Frame.<>c <>9;  // 0x0
public static Func<AssetObject, AssetGuid> <>9__103_0;  // 0x8
public static Action <>9__129_0;  // 0x10
public static Comparison<Frame.RuntimePlayerData> <>9__146_0;  // 0x18
```
Methods:
```
private static void .cctor()   // RVA 0x214DA60
public void .ctor()   // RVA 0x4FA6F0
internal AssetGuid <DumpFrame>b__103_0(AssetObject x)   // RVA 0x21488A0
internal void <InitStaticGen>b__129_0()   // RVA 0x21488C0
internal int <UpdatePlayerData>b__146_0(Frame.RuntimePlayerData a, Frame.RuntimePlayerData b)   // RVA 0x214DA40
```

### Frame.<>c__124<T>  (bases: ; TypeDefIndex 10073)
Fields:
```
public static readonly Frame.<>c__124<T> <>9;  // 0x0
public static Func<SystemBase, bool> <>9__124_0;  // 0x0
```

### Frame.<>c__125<T>  (bases: ; TypeDefIndex 10074)
Fields:
```
public static readonly Frame.<>c__125<T> <>9;  // 0x0
public static Func<SystemBase, bool> <>9__125_0;  // 0x0
```

### Frame.<>c__126<T>  (bases: ; TypeDefIndex 10075)
Fields:
```
public static readonly Frame.<>c__126<T> <>9;  // 0x0
public static Func<SystemBase, bool> <>9__126_0;  // 0x0
```

### Frame.<>c__DisplayClass125_0<T>  (bases: ; TypeDefIndex 10076)
Fields:
```
public Frame <>4__this;  // 0x0
public ISignalOnComponentAdded<T>[] array;  // 0x0
```

### Frame.<>c__DisplayClass126_0<T>  (bases: ; TypeDefIndex 10077)
Fields:
```
public Frame <>4__this;  // 0x0
public ISignalOnComponentRemoved<T>[] array;  // 0x0
```

### Quantum.Frame  (bases: FrameBase; TypeDefIndex 10078)
Fields:
```
private _globals_* _globals;  // 0xC8
private RuntimeConfig _runtimeConfig;  // 0xD0
private SimulationConfig _simulationConfig;  // 0xD8
private DeterministicSessionConfig _sessionConfig;  // 0xE0
private SystemBase[] _systemsAll;  // 0xE8
private SystemBase[] _systemsRoots;  // 0xF0
private Dictionary<Type, int> _systemIndexByType;  // 0xF8
private PersistentMap<int, Frame.RuntimePlayerData> _playerData;  // 0x100
private List<Frame.RuntimePlayerData> _oldPlayerData;  // 0x108
private ISignalOnPlayerDataSet[] _ISignalOnPlayerDataSet;  // 0x110
private ISignalOnCollision2D[] _ISignalOnCollision2DSystems;  // 0x118
private ISignalOnCollisionEnter2D[] _ISignalOnCollisionEnter2DSystems;  // 0x120
private ISignalOnCollisionExit2D[] _ISignalOnCollisionExit2DSystems;  // 0x128
private ISignalOnTrigger2D[] _ISignalOnTrigger2DSystems;  // 0x130
private ISignalOnTriggerEnter2D[] _ISignalOnTriggerEnter2DSystems;  // 0x138
private ISignalOnTriggerExit2D[] _ISignalOnTriggerExit2DSystems;  // 0x140
private ISignalOnCollision3D[] _ISignalOnCollision3DSystems;  // 0x148
private ISignalOnCollisionEnter3D[] _ISignalOnCollisionEnter3DSystems;  // 0x150
private ISignalOnCollisionExit3D[] _ISignalOnCollisionExit3DSystems;  // 0x158
private ISignalOnTrigger3D[] _ISignalOnTrigger3DSystems;  // 0x160
private ISignalOnTriggerEnter3D[] _ISignalOnTriggerEnter3DSystems;  // 0x168
private ISignalOnTriggerExit3D[] _ISignalOnTriggerExit3DSystems;  // 0x170
private ISignalOnNavMeshWaypointReached[] _ISignalOnNavMeshWaypointReachedSystems;  // 0x178
private ISignalOnNavMeshSearchFailed[] _ISignalOnNavMeshSearchFailedSystems;  // 0x180
private ISignalOnNavMeshMoveAgent[] _ISignalOnNavMeshMoveAgentSystems;  // 0x188
private ISignalOnMapChanged[] _ISignalOnMapChangedSystems;  // 0x190
private ISignalOnEntityPrototypeMaterialized[] _ISignalOnEntityPrototypeMaterializedSystems;  // 0x198
private ISignalOnPlayerConnected[] _ISignalOnPlayerConnectedSystems;  // 0x1A0
private ISignalOnPlayerDisconnected[] _ISignalOnPlayerDisconnectedSystems;  // 0x1A8
public Frame.FrameSignals Signals;  // 0x1B0
public Frame.FrameEvents Events;  // 0x1B8
public Frame.FrameAssets Assets;  // 0x1C0
```
Methods:
```
public void SetPlayerInput(int player, Input input)   // RVA 0x2146910
public Input* GetPlayerInput(int player)   // RVA 0x2143F00
public _globals_* get_Global()   // RVA 0x73FE10
public RNGSession* get_RNG()   // RVA 0x2147F80
public int get_PlayerCount()   // RVA 0x2147F60
public FrameContextUser get_Context()   // RVA 0x2147DC0
public RuntimeConfig get_RuntimeConfig()   // RVA 0x6230C0
internal void set_RuntimeConfig(RuntimeConfig value)   // RVA 0x6230D0
public SimulationConfig get_SimulationConfig()   // RVA 0x502330
internal void set_SimulationConfig(SimulationConfig value)   // RVA 0x1CB31E0
public DeterministicSessionConfig get_SessionConfig()   // RVA 0x7A80E0
internal void set_SessionConfig(DeterministicSessionConfig value)   // RVA 0x818FF0
public void .ctor(FrameContext context, SystemBase[] systemsAll, SystemBase[] systemsRoots, DeterministicSessionConfig sessionConfig, RuntimeConfig runtimeConfig, SimulationConfig simulationConfig, FP deltaTime)   // RVA 0x2147210
public ArraySegment<byte> Serialize(DeterministicFrameSerializeMode mode, byte[] buffer, int offset = 0, bool allocOutput = False)   // RVA 0x21461B0
public ArraySegment<byte> Serialize(DeterministicFrameSerializeMode mode, byte[] buffer, out FrameSerializer serializer, int offset = 0, bool allocOutput = False)   // RVA 0x21462C0
private void SerializeState(FrameSerializer serializer)   // RVA 0x2146170
private void SerializeRuntimePlayers(BitStream stream)   // RVA 0x2145C90
private void DeserializeRuntimePlayers(byte[] bytes)   // RVA 0x2142740
private void DeserializeDynamicAssetDB(byte[] bytes)   // RVA 0x2142480
public ulong CalculateChecksum(bool useSharedSerializer)   // RVA 0x21420F0
internal ulong CalculateChecksumInternal(FrameSerializer serializer)   // RVA 0x2141D90
public bool SystemIsEnabledSelf(SystemBase s)   // RVA 0x2146AC0
public bool SystemIsEnabledInHierarchy(SystemBase system)   // RVA 0x2146A10
private void AddEvent(EventBase evnt)   // RVA 0x2141C60
public static void InitStatic()   // RVA 0x2145B90
private static void InitStaticGen()   // RVA 0x2145AA0
private void InitGen()   // RVA 0x2143FD0
private void FreeGen()   // RVA 0x2143D80
private void AllocGen()   // RVA 0x2141D00
private void CopyFromGen(Frame frame)   // RVA 0x21421B0
public RuntimePlayer GetPlayerData(PlayerRef player)   // RVA 0x2143EC0
private bool TryGetPlayerData(PlayerRef player, out Frame.RuntimePlayerData playerData)   // RVA 0x2146B30
public void UpdatePlayerData()   // RVA 0x2146CF0
private void <.ctor>b__89_0(EntityRef entity, EntityPrototypeRef prototype)   // RVA 0x2146CC0
```

### Quantum.BitStreamExtensions  (bases: ; TypeDefIndex 10180)
Methods:
```
public static void Serialize(IBitStream stream, ref AssetRefGameEntityData value)   // RVA 0x2139100
public static void Serialize(IBitStream stream, ref AssetRefStateMachineData value)   // RVA 0x2139160
```

### ItemsData.ItemDataFile  (bases: ; TypeDefIndex 10187)
Fields:
```
public HashString ItemID;  // 0x0
public AssetRefGameEntityData Data;  // 0x10
```

### Quantum.ComponentPrototypeVisitor  (bases: ComponentPrototypeVisitorBase; TypeDefIndex 10210)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### StaticDelegates.Tag  (bases: ; TypeDefIndex 10211)

### StaticDelegates.<>O  (bases: ; TypeDefIndex 10212)
Fields:
```
public static FrameSerializer.Delegate <0>__Serialize;  // 0x0
public static FrameSerializer.Delegate <1>__Serialize;  // 0x8
public static FrameSerializer.Delegate <2>__Serialize;  // 0x10
public static FrameSerializer.Delegate <3>__Serialize;  // 0x18
public static FrameSerializer.Delegate <4>__Serialize;  // 0x20
public static FrameSerializer.Delegate <5>__Serialize;  // 0x28
public static FrameSerializer.Delegate <6>__Serialize;  // 0x30
public static FrameSerializer.Delegate <7>__Serialize;  // 0x38
public static FrameSerializer.Delegate <8>__Serialize;  // 0x40
public static FrameSerializer.Delegate <9>__Serialize;  // 0x48
public static FrameSerializer.Delegate <10>__Serialize;  // 0x50
public static FrameSerializer.Delegate <11>__Serialize;  // 0x58
public static FrameSerializer.Delegate <12>__Serialize;  // 0x60
public static FrameSerializer.Delegate <13>__Serialize;  // 0x68
public static FrameSerializer.Delegate <14>__Serialize;  // 0x70
public static FrameSerializer.Delegate <15>__Serialize;  // 0x78
public static FrameSerializer.Delegate <16>__Serialize;  // 0x80
public static FrameSerializer.Delegate <17>__Serialize;  // 0x88
public static FrameSerializer.Delegate <18>__Serialize;  // 0x90
public static FrameSerializer.Delegate <19>__Serialize;  // 0x98
public static FrameSerializer.Delegate <20>__Serialize;  // 0xA0
public static FrameSerializer.Delegate <21>__Serialize;  // 0xA8
public static FrameSerializer.Delegate <22>__Serialize;  // 0xB0
public static FrameSerializer.Delegate <23>__Serialize;  // 0xB8
public static FrameSerializer.Delegate <24>__Serialize;  // 0xC0
public static FrameSerializer.Delegate <25>__Serialize;  // 0xC8
public static FrameSerializer.Delegate <26>__Serialize;  // 0xD0
public static FrameSerializer.Delegate <27>__Serialize;  // 0xD8
public static FrameSerializer.Delegate <28>__Serialize;  // 0xE0
```

### StaticDelegates.<>c  (bases: ; TypeDefIndex 10213)
Fields:
```
public static readonly StaticDelegates.<>c <>9;  // 0x0
public static Action <>9__31_0;  // 0x8
public static FrameSerializer.Delegate <>9__32_0;  // 0x10
```
Methods:
```
private static void .cctor()   // RVA 0x21646A0
public void .ctor()   // RVA 0x4FA6F0
internal void <Init>b__31_0()   // RVA 0x2164690
internal void <InitGen>b__32_0(void* v, FrameSerializer s)   // RVA 0x21645C0
```

### Quantum.StaticDelegates  (bases: ; TypeDefIndex 10214)
Fields:
```
public static FrameSerializer.Delegate SerializeEntityRef;  // 0x0
public static FrameSerializer.Delegate SerializeInputTimer;  // 0x8
public static FrameSerializer.Delegate SerializeInt32;  // 0x10
public static FrameSerializer.Delegate SerializeHitBox;  // 0x18
public static FrameSerializer.Delegate SerializeHurtBox;  // 0x20
public static FrameSerializer.Delegate SerializeCustomAnimatorPlayableClipInfo;  // 0x28
public static FrameSerializer.Delegate SerializeAnimationSpeedElement;  // 0x30
public static FrameSerializer.Delegate SerializeCustomSubAnimatorPlayableClipInfo;  // 0x38
public static FrameSerializer.Delegate SerializeGameEntityReference;  // 0x40
public static FrameSerializer.Delegate SerializeObjectVisibilityData;  // 0x48
public static FrameSerializer.Delegate SerializeSlotAttachmentData;  // 0x50
public static FrameSerializer.Delegate SerializeRuntimeGameSpeedModifier;  // 0x58
public static FrameSerializer.Delegate SerializeInputValue;  // 0x60
public static FrameSerializer.Delegate SerializeStageEntity;  // 0x68
public static FrameSerializer.Delegate SerializeRuntimeMechanicTutorialGoal;  // 0x70
public static FrameSerializer.Delegate SerializeMoveLimit;  // 0x78
public static FrameSerializer.Delegate SerializeChildEntity;  // 0x80
public static FrameSerializer.Delegate SerializeExperienceEventData;  // 0x88
public static FrameSerializer.Delegate SerializeHitEvent;  // 0x90
public static FrameSerializer.Delegate SerializeActionData;  // 0x98
public static FrameSerializer.Delegate SerializeSFXToExecute;  // 0xA0
public static FrameSerializer.Delegate SerializeAssetGuid;  // 0xA8
public static FrameSerializer.Delegate SerializeScheduledBehaviour;  // 0xB0
public static FrameSerializer.Delegate SerializeQString128;  // 0xB8
public static FrameSerializer.Delegate SerializeFP;  // 0xC0
public static FrameSerializer.Delegate SerializeRuntimeStatusEffect;  // 0xC8
public static FrameSerializer.Delegate SerializeStatusEffectAttributeModifier;  // 0xD0
public static FrameSerializer.Delegate SerializeFPVector2;  // 0xD8
public static FrameSerializer.Delegate SerializeTargetStatePerEntity;  // 0xE0
public static FrameSerializer.Delegate SerializeInput;  // 0xE8
```
Methods:
```
public static void Init()   // RVA 0x2160060
private static void InitGen()   // RVA 0x215EC90
```

### Quantum.TypeRegistry  (bases: ; TypeDefIndex 10215)
Fields:
```
private readonly Dictionary<Type, int> _types;  // 0x10
```
Methods:
```
public ReadOnlyDictionary<Type, int> get_Types()   // RVA 0x2164550
public void .ctor()   // RVA 0x21644C0
private void Register(Type type, int size)   // RVA 0x2164430
private void AddBuiltIns()   // RVA 0x21605A0
private void AddGenerated()   // RVA 0x2160C10
```

### Quantum.FramePrinterGen  (bases: ; TypeDefIndex 10216)
Methods:
```
public static void EnsureNotStripped()   // RVA 0x2152250
```

### Quantum.DeterministicCommandSetup  (bases: ; TypeDefIndex 10217)
Methods:
```
public static IDeterministicCommandFactory[] GetCommandFactories(RuntimeConfig gameConfig, SimulationConfig simulationConfig)   // RVA 0x2151C90
private static void AddCommandFactoriesUser(ICollection<IDeterministicCommandFactory> factories, RuntimeConfig gameConfig, SimulationConfig simulationConfig)   // RVA 0x2151280
private static void AdditionalCommandsSetup(ICollection<IDeterministicCommandFactory> factories, RuntimeConfig gameConfig, SimulationConfig simulationConfig)   // RVA 0x21517D0
```

### Quantum.ISignalOnCollision2D  (bases: ; TypeDefIndex 10218)

### Quantum.ISignalOnCollisionEnter2D  (bases: ; TypeDefIndex 10219)

### Quantum.ISignalOnCollisionExit2D  (bases: ; TypeDefIndex 10220)

### Quantum.ISignalOnTrigger2D  (bases: ; TypeDefIndex 10221)

### Quantum.ISignalOnTriggerEnter2D  (bases: ; TypeDefIndex 10222)

### Quantum.ISignalOnTriggerExit2D  (bases: ; TypeDefIndex 10223)

### Quantum.ISignalOnCollision3D  (bases: ; TypeDefIndex 10224)

### Quantum.ISignalOnCollisionEnter3D  (bases: ; TypeDefIndex 10225)

### Quantum.ISignalOnCollisionExit3D  (bases: ; TypeDefIndex 10226)

### Quantum.ISignalOnTrigger3D  (bases: ; TypeDefIndex 10227)

### Quantum.ISignalOnTriggerEnter3D  (bases: ; TypeDefIndex 10228)

### Quantum.ISignalOnTriggerExit3D  (bases: ; TypeDefIndex 10229)

### Quantum.FrameContextUser  (bases: FrameContext; TypeDefIndex 10230)
Methods:
```
public void .ctor(FrameContext.Args args)   // RVA 0x21521F0
```

### Quantum.ISignalOnComponentAdded<T>  (bases: ; TypeDefIndex 10231)

### Quantum.ISignalOnComponentRemoved<T>  (bases: ; TypeDefIndex 10232)

### Quantum.ISignalOnMapChanged  (bases: ; TypeDefIndex 10233)

### Quantum.ISignalOnEntityPrototypeMaterialized  (bases: ; TypeDefIndex 10234)

### Quantum.ISignalOnPlayerConnected  (bases: ; TypeDefIndex 10235)

### Quantum.ISignalOnPlayerDisconnected  (bases: ; TypeDefIndex 10236)

### Quantum.ISignalOnNavMeshWaypointReached  (bases: ; TypeDefIndex 10237)

### Quantum.ISignalOnNavMeshSearchFailed  (bases: ; TypeDefIndex 10238)

### Quantum.ISignalOnNavMeshMoveAgent  (bases: ; TypeDefIndex 10239)

### Quantum.RuntimeConfig  (bases: ; TypeDefIndex 10241)
Fields:
```
public int Seed;  // 0x10
public AssetRefMap Map;  // 0x18
public AssetRefSimulationConfig SimulationConfig;  // 0x20
public FP IntroAnimationDuration;  // 0x28
public bool IsEditor;  // 0x30
public bool OnlineActive;  // 0x31
public string StageID;  // 0x38
public string DefaultSpawnPointID;  // 0x40
public MatchRules MatchRules;  // 0x48
```
Methods:
```
public void Serialize(BitStream stream)   // RVA 0x215A130
private void SerializeUserData(BitStream stream)   // RVA 0x215A020
public static byte[] ToByteArray(RuntimeConfig config, int arrayCapacity = 8192)   // RVA 0x215A260
public static RuntimeConfig FromByteArray(byte[] data)   // RVA 0x2159F40
private void OnSerializeUserData(BitStream stream)   // RVA 0x2159FF0
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.ISignalOnPlayerDataSet  (bases: ; TypeDefIndex 10242)

### Quantum.RuntimePlayer  (bases: ; TypeDefIndex 10243)
Fields:
```
public int PlayerIndex;  // 0x10
public PlayerSettings PlayerSettings;  // 0x18
```
Methods:
```
public void Serialize(BitStream stream)   // RVA 0x215A410
private void SerializeUserData(BitStream stream)   // RVA 0x215A410
public static byte[] ToByteArray(RuntimePlayer player, int arrayCapacity = 8192)   // RVA 0x215A4E0
public static RuntimePlayer FromByteArray(byte[] data)   // RVA 0x215A310
public void .ctor()   // RVA 0x215A590
```

### Quantum.AssetRefSimulationConfig  (bases: IEquatable<AssetRefSimulationConfig>; TypeDefIndex 10246)
Fields:
```
public AssetGuid Id;  // 0x0
```

### Quantum.CallbackDispatcher  (bases: DispatcherBase, ICallbackDispatcher; TypeDefIndex 10249)
Methods:
```
protected static Dictionary<Type, int> GetBuiltInTypes()   // RVA 0x214F330
protected void .ctor(Dictionary<Type, int> callbackTypes)   // RVA 0x214F680
```

### ChecksumErrorFrameDumpContext.<>c  (bases: ; TypeDefIndex 10250)
Fields:
```
public static readonly ChecksumErrorFrameDumpContext.<>c <>9;  // 0x0
public static Comparison<AssetObject> <>9__3_0;  // 0x8
```
Methods:
```
private static void .cctor()   // RVA 0x2164710
public void .ctor()   // RVA 0x4FA6F0
internal int <.ctor>b__3_0(AssetObject a, AssetObject b)   // RVA 0xCFFB90
```

### Quantum.ChecksumErrorFrameDumpContext  (bases: ; TypeDefIndex 10251)
Fields:
```
public SimulationConfig SimulationConfig;  // 0x10
public QTuple<AssetGuid, ulong>[] AssetDBChecksums;  // 0x18
```
Methods:
```
private void .ctor()   // RVA 0x4FA6F0
public void .ctor(QuantumGame game, Frame frame)   // RVA 0x2150390
public void Serialize(QuantumGame game, BinaryWriter writer)   // RVA 0x21501B0
public static ChecksumErrorFrameDumpContext Deserialize(QuantumGame game, BinaryReader reader)   // RVA 0x214FF40
```

### Quantum.EventDispatcher  (bases: DispatcherBase, IEventDispatcher; TypeDefIndex 10252)
Methods:
```
private static Dictionary<Type, int> GetEventTypes()   // RVA 0x2151ED0
public void .ctor()   // RVA 0x21520E0
```

### Quantum.InstantReplaySettings  (bases: ; TypeDefIndex 10253)
Fields:
```
public int SnapshotsPerSecond;  // 0x0
public FP LenghtSeconds;  // 0x8
```
Methods:
```
public static InstantReplaySettings get_Default()   // RVA 0x2153DF0
```

### QuantumGame.StartParameters  (bases: ; TypeDefIndex 10254)
Fields:
```
public IResourceManager ResourceManager;  // 0x0
public IAssetSerializer AssetSerializer;  // 0x8
public ICallbackDispatcher CallbackDispatcher;  // 0x10
public IEventDispatcher EventDispatcher;  // 0x18
public InstantReplaySettings InstantReplaySettings;  // 0x20
public int HeapExtraCount;  // 0x30
public DynamicAssetDB InitialDynamicAssets;  // 0x38
public int GameFlags;  // 0x40
```

### QuantumGame.FramesContainer  (bases: ; TypeDefIndex 10255)
Fields:
```
public Frame Verified;  // 0x10
public Frame Predicted;  // 0x18
public Frame PredictedPrevious;  // 0x20
public Frame PreviousUpdatePredicted;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### QuantumGame.ConfigurationsContainer  (bases: ; TypeDefIndex 10256)
Fields:
```
public RuntimeConfig Runtime;  // 0x10
public SimulationConfig Simulation;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### QuantumGame.CallbackBase  (bases: CallbackBase; TypeDefIndex 10257)
Methods:
```
public QuantumGame get_Game()   // RVA 0x21662B0
public void .ctor(int id, QuantumGame game)   // RVA 0x21662A0
```

### QuantumGame.<>c  (bases: ; TypeDefIndex 10258)
Fields:
```
public static readonly QuantumGame.<>c <>9;  // 0x0
public static Func<SystemBase, bool> <>9__71_0;  // 0x8
public static Func<SystemBase, IEnumerable<SystemBase>> <>9__71_1;  // 0x10
public static Func<SystemBase, bool> <>9__71_2;  // 0x18
public static Func<SystemBase, bool> <>9__71_3;  // 0x20
public static Func<SystemBase, bool> <>9__71_4;  // 0x28
public static Func<SystemBase, bool> <>9__71_5;  // 0x30
public static Func<SystemBase, bool> <>9__71_6;  // 0x38
```
Methods:
```
private static void .cctor()   // RVA 0x217AE50
public void .ctor()   // RVA 0x4FA6F0
internal bool <CreateFrameContext>b__71_0(SystemBase x)   // RVA 0x217ABA0
internal IEnumerable<SystemBase> <CreateFrameContext>b__71_1(SystemBase x)   // RVA 0x217ABB0
internal bool <CreateFrameContext>b__71_2(SystemBase x)   // RVA 0x217ABD0
internal bool <CreateFrameContext>b__71_3(SystemBase x)   // RVA 0x217AC50
internal bool <CreateFrameContext>b__71_4(SystemBase x)   // RVA 0x217ACD0
internal bool <CreateFrameContext>b__71_5(SystemBase x)   // RVA 0x217AD50
internal bool <CreateFrameContext>b__71_6(SystemBase x)   // RVA 0x217ADD0
```

### Quantum.QuantumGame  (bases: IDeterministicGame; TypeDefIndex 10259)
Fields:
```
private DeterministicFrameRingBuffer _checksumSnapshotBuffer;  // 0x10
private DeterministicFrameRingBuffer _instantReplaySnapshotBuffer;  // 0x18
private bool _instantReplaySnapshotsRecording;  // 0x20
private int _commonSnapshotInterval;  // 0x24
private int _instantReplaySnapshotInterval;  // 0x28
private Action<ProfilerContextData> ProfilerSampleGenerated;  // 0x30
private readonly QuantumGame.FramesContainer <Frames>k__BackingField;  // 0x38
private readonly QuantumGame.ConfigurationsContainer <Configurations>k__BackingField;  // 0x40
private DeterministicSession <Session>k__BackingField;  // 0x48
private float <InterpolationFactor>k__BackingField;  // 0x50
private InstantReplaySettings <InstantReplayConfig>k__BackingField;  // 0x58
private readonly IAssetSerializer <AssetSerializer>k__BackingField;  // 0x68
private readonly int <HeapExtraCount>k__BackingField;  // 0x70
private byte[] _inputStreamReadZeroArray;  // 0x78
private IResourceManager _resourceManager;  // 0x80
private ICallbackDispatcher _callbackDispatcher;  // 0x88
private IEventDispatcher _eventDispatcher;  // 0x90
private FrameSerializer _inputSerializerRead;  // 0x98
private FrameSerializer _inputSerializerWrite;  // 0xA0
private SystemBase[] _systemsRoot;  // 0xA8
private SystemBase[] _systemsAll;  // 0xB0
private FrameContext _context;  // 0xB8
private TypeRegistry _typeRegistry;  // 0xC0
private bool _polledInputInThisSimulation;  // 0xC8
private DynamicAssetDB _initialDynamicAssets;  // 0xD0
private int _flags;  // 0xD8
private InputProvider <RecordedInputs>k__BackingField;  // 0xE0
private ChecksumFile <RecordedChecksums>k__BackingField;  // 0xE8
private ChecksumFile _checksumsToVerify;  // 0xF0
private Dictionary<EventKey, bool> _eventsTriggered;  // 0xF8
private Queue<EventKey> _eventsConfirmationQueue;  // 0x100
private CallbackChecksumComputed _callbackChecksumComputed;  // 0x108
private CallbackChecksumError _callbackChecksumError;  // 0x110
private CallbackChecksumErrorFrameDump _callbackChecksumErrorFrameDump;  // 0x118
private CallbackEventCanceled _callbackEventCanceled;  // 0x120
private CallbackEventConfirmed _callbackEventConfirmed;  // 0x128
private CallbackGameDestroyed _callbackGameDestroyed;  // 0x130
private CallbackGameStarted _callbackGameStarted;  // 0x138
private CallbackGameResynced _callbackGameResynced;  // 0x140
private CallbackInputConfirmed _callbackInputConfirmed;  // 0x148
private CallbackPollInput _callbackPollInput;  // 0x150
private CallbackSimulateFinished _callbackSimulateFinished;  // 0x158
private CallbackUpdateView _callbackUpdateView;  // 0x160
private CallbackPluginDisconnect _callbackPluginDisconnect;  // 0x168
```
Methods:
```
private void SnapshotsOnDestroy()   // RVA 0x2159810
private void SnapshotsOnSimulateFinished(DeterministicFrame state)   // RVA 0x2159870
private int SnapshotsCreateBuffers(int simulationRate, int checksumInterval, FP checksumTimeWindow, int replayInterval, FP replayTimeWindow)   // RVA 0x21595F0
public QuantumGame.FramesContainer get_Frames()   // RVA 0x5C5B40
public QuantumGame.ConfigurationsContainer get_Configurations()   // RVA 0x5C5B30
private void set_Session(DeterministicSession value)   // RVA 0x58D130
public float get_InterpolationFactor()   // RVA 0x1C9EE40
private void set_InterpolationFactor(float value)   // RVA 0x2159F30
public InstantReplaySettings get_InstantReplayConfig()   // RVA 0x2159F10
private void set_InstantReplayConfig(InstantReplaySettings value)   // RVA 0x2159F20
public IAssetSerializer get_AssetSerializer()   // RVA 0x5A5150
public int get_HeapExtraCount()   // RVA 0x70CE10
public void .ctor(in QuantumGame.StartParameters startParams)   // RVA 0x2159CF0
public int[] GetLocalPlayers()   // RVA 0x7C2770
public void SendCommand(DeterministicCommand command)   // RVA 0x2159480
public void SendPlayerData(int player, RuntimePlayer data)   // RVA 0x2159530
public Frame CreateFrame()   // RVA 0x2155410
private void InitSystems(DeterministicFrame df)   // RVA 0x21563F0
private void ApplyInputs(Frame f)   // RVA 0x2154030
private void LogSimulationException(Exception exn)   // RVA 0x2157870
public void CheckTrackedHeapAllocations()   // RVA 0x2154550
public InputProvider get_RecordedInputs()   // RVA 0x7A80E0
private void set_RecordedInputs(InputProvider value)   // RVA 0x818FF0
public ChecksumFile get_RecordedChecksums()   // RVA 0x7A8080
private void set_RecordedChecksums(ChecksumFile value)   // RVA 0x1CB3160
public Frame GetInstantReplaySnapshot(int frame)   // RVA 0x2155A50
public void GetInstantReplaySnapshots(int startFrame, int endFrame, List<Frame> frames)   // RVA 0x2155D50
private void ReplayToolsOnInputConfirmed(DeterministicFrameInputTemp input)   // RVA 0x2159430
private void ReplayToolsOnGameResync()   // RVA 0x21593C0
private void ReplayToolsOnChecksumComputed(int frame, ulong checksum)   // RVA 0x2159340
public void StartRecordingInput(Nullable<int> startFrame)   // RVA 0x2159A20
public void StartRecordingChecksums()   // RVA 0x2159970
public void StartVerifyingChecksums(ChecksumFile checksums)   // RVA 0x2159C60
public void StartRecordingInstantReplaySnapshots()   // RVA 0x2159BB0
private void InitEventInvoker(int size)   // RVA 0x2156310
private void RaiseEvent(EventBase evnt)   // RVA 0x2159210
private void CancelPendingEvents()   // RVA 0x2154430
private void InvokeEvents()   // RVA 0x2156720
public void InitCallbacks()   // RVA 0x2155FB0
public void InvokeOnDestroy()   // RVA 0x2157160
private void InvokeOnGameStart()   // RVA 0x2157330
private void InvokeOnGameResync()   // RVA 0x21572D0
private QTuple<Input, DeterministicInputFlags> InvokeOnPollInput(int frame, int player, bool isFirstInThisUpdate)   // RVA 0x2157520
private void InvokeOnUpdateView()   // RVA 0x21577F0
public void InvokeOnSimulateFinished(DeterministicFrame state)   // RVA 0x2157680
public void InvokeOnChecksumError(DeterministicTickChecksumError error, DeterministicFrame[] frames)   // RVA 0x2157030
public void InvokeOnChecksumComputed(int frame, ulong checksum)   // RVA 0x2156C40
public void InvokeOnInputConfirmed(DeterministicFrameInputTemp input)   // RVA 0x2157390
public void InvokeOnChecksumErrorFrameDump(int actorId, int frameNumber, DeterministicSessionConfig sessionConfig, byte[] runtimeConfig, byte[] frameData, byte[] extraData)   // RVA 0x2156CE0
private void InvokeOnEvent(EventKey key, bool confirmed)   // RVA 0x21571C0
public void InvokeOnPluginDisconnect(string reason)   // RVA 0x2157490
```

### Quantum.CallbackPollInput  (bases: QuantumGame.CallbackBase; TypeDefIndex 10260)
Fields:
```
public int Frame;  // 0x20
public int Player;  // 0x24
private bool <IsFirstInThisUpdate>k__BackingField;  // 0x28
private bool <IsInputSet>k__BackingField;  // 0x29
private Input <Input>k__BackingField;  // 0x2C
private DeterministicInputFlags <Flags>k__BackingField;  // 0x34
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2167050
public void SetInput(Input input, DeterministicInputFlags flags)   // RVA 0x2167040
internal void set_IsFirstInThisUpdate(bool value)   // RVA 0x5BA5B0
public bool get_IsInputSet()   // RVA 0x619830
internal void set_IsInputSet(bool value)   // RVA 0x61A6E0
public Input get_Input()   // RVA 0x2167060
private void set_Input(Input value)   // RVA 0x2167070
public DeterministicInputFlags get_Flags()   // RVA 0x881B20
private void set_Flags(DeterministicInputFlags value)   // RVA 0x881B30
```

### Quantum.CallbackGameStarted  (bases: QuantumGame.CallbackBase; TypeDefIndex 10261)
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2167010
```

### Quantum.CallbackGameResynced  (bases: QuantumGame.CallbackBase; TypeDefIndex 10262)
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2167000
```

### Quantum.CallbackGameDestroyed  (bases: QuantumGame.CallbackBase; TypeDefIndex 10263)
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2166FF0
```

### Quantum.CallbackUpdateView  (bases: QuantumGame.CallbackBase; TypeDefIndex 10264)
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2167090
```

### Quantum.CallbackSimulateFinished  (bases: QuantumGame.CallbackBase; TypeDefIndex 10265)
Fields:
```
public Frame Frame;  // 0x20
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2167080
```

### Quantum.CallbackEventCanceled  (bases: QuantumGame.CallbackBase; TypeDefIndex 10266)
Fields:
```
public EventKey EventKey;  // 0x20
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2166FD0
```

### Quantum.CallbackEventConfirmed  (bases: QuantumGame.CallbackBase; TypeDefIndex 10267)
Fields:
```
public EventKey EventKey;  // 0x20
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2166FE0
```

### Quantum.CallbackChecksumError  (bases: QuantumGame.CallbackBase; TypeDefIndex 10268)
Fields:
```
public DeterministicTickChecksumError Error;  // 0x20
internal DeterministicFrame[] _rawFrames;  // 0x28
internal Frame[] _convertedFrame;  // 0x30
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2166E00
public Frame[] get_Frames()   // RVA 0x2166E10
```

### Quantum.CallbackChecksumErrorFrameDump  (bases: QuantumGame.CallbackBase; TypeDefIndex 10269)
Fields:
```
public int ActorId;  // 0x20
public int FrameNumber;  // 0x24
public byte[] FrameData;  // 0x28
public byte[] RuntimeConfigBytes;  // 0x30
public byte[] ExtraBytes;  // 0x38
public DeterministicSessionConfig SessionConfig;  // 0x40
private Frame _frameToOverride;  // 0x48
private byte[] _overridenFrameData;  // 0x50
private SimulationConfig _overridenSimulationConfig;  // 0x58
private DeterministicSessionConfig _overridenSessionConfig;  // 0x60
private RuntimeConfig _overridenRuntimeConfig;  // 0x68
private QTuple<bool, string> _frameDump;  // 0x70
private QTuple<bool, Frame> _frame;  // 0x80
private QTuple<bool, RuntimeConfig> _runtimeConfig;  // 0x90
private QTuple<bool, ChecksumErrorFrameDumpContext> _context;  // 0xA0
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2166450
internal void Clear()   // RVA 0x2166330
public Frame get_Frame()   // RVA 0x2166A80
public string get_FrameDump()   // RVA 0x2166630
public RuntimeConfig get_RuntimeConfig()   // RVA 0x2166D10
public SimulationConfig get_SimulationConfig()   // RVA 0x2166DE0
internal void Init(Frame frame)   // RVA 0x58D130
public ChecksumErrorFrameDumpContext get_Context()   // RVA 0x2166460
```

### Quantum.CallbackInputConfirmed  (bases: QuantumGame.CallbackBase; TypeDefIndex 10270)
Fields:
```
public DeterministicFrameInputTemp Input;  // 0x20
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2167020
```

### Quantum.CallbackChecksumComputed  (bases: QuantumGame.CallbackBase; TypeDefIndex 10271)
Fields:
```
public int Frame;  // 0x20
public ulong Checksum;  // 0x28
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2166320
```

### Quantum.CallbackPluginDisconnect  (bases: QuantumGame.CallbackBase; TypeDefIndex 10272)
Fields:
```
public string Reason;  // 0x20
```
Methods:
```
internal void .ctor(QuantumGame game)   // RVA 0x2167030
```

### JsonAssetSerializerBase.EntityPrototypeSurrogate  (bases: ; TypeDefIndex 10273)
Fields:
```
public FlatEntityPrototypeContainer Container;  // 0x10
public AssetObjectIdentifier Identifier;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### JsonAssetSerializerBase.MapSurrogate  (bases: ; TypeDefIndex 10274)
Fields:
```
public Map Map;  // 0x10
public FlatEntityPrototypeContainer[] MapEntities;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### JsonAssetSerializerBase.UserAssetSurrogate  (bases: ; TypeDefIndex 10275)
Fields:
```
public string Json;  // 0x10
public string Type;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### JsonAssetSerializerBase.BinaryDataSurrogate  (bases: ; TypeDefIndex 10276)
Fields:
```
public AssetObjectIdentifier Identifier;  // 0x10
public bool IsCompressed;  // 0x20
public string Base64Data;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### JsonAssetSerializerBase.FlatDatabaseFile  (bases: ; TypeDefIndex 10278)
Fields:
```
public List<CharacterController2DConfig> CharacterController2DConfig;  // 0x10
public List<CharacterController3DConfig> CharacterController3DConfig;  // 0x18
public List<JsonAssetSerializerBase.EntityPrototypeSurrogate> EntityPrototype;  // 0x20
public List<EntityView> EntityView;  // 0x28
public List<JsonAssetSerializerBase.MapSurrogate> Map;  // 0x30
public List<NavMesh> NavMesh;  // 0x38
public List<NavMeshAgentConfig> NavMeshAgentConfig;  // 0x40
public List<PhysicsMaterial> PhysicsMaterial;  // 0x48
public List<PolygonCollider> PolygonCollider;  // 0x50
public List<TerrainCollider> TerrainCollider;  // 0x58
public List<JsonAssetSerializerBase.UserAssetSurrogate> UserAssets;  // 0x60
public List<JsonAssetSerializerBase.BinaryDataSurrogate> BinaryData;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x216AEE0
```

### Quantum.JsonAssetSerializerBase  (bases: IAssetSerializer; TypeDefIndex 10279)
Fields:
```
private List<ComponentPrototype> _prototypeBuffer;  // 0x10
private bool <IsPrettyPrintEnabled>k__BackingField;  // 0x18
private int <CompressBinaryDataOnSerializationThreshold>k__BackingField;  // 0x1C
private bool <DecompressBinaryDataOnDeserialization>k__BackingField;  // 0x20
```
Methods:
```
public bool get_IsPrettyPrintEnabled()   // RVA 0x676D40
public int get_CompressBinaryDataOnSerializationThreshold()   // RVA 0x6678B0
public bool get_DecompressBinaryDataOnDeserialization()   // RVA 0x627880
public Encoding get_Encoding()   // RVA 0x854950
public ReplayFile DeserializeReplay(byte[] data)   // RVA 0x2175720
public ChecksumFile DeserializeChecksum(byte[] data)   // RVA 0x2175620
public IEnumerable<AssetObject> DeserializeAssets(byte[] data)   // RVA 0x2174BE0
private static JsonAssetSerializerBase.EntityPrototypeSurrogate CreateSurrogate(EntityPrototype asset)   // RVA 0x2174840
private static JsonAssetSerializerBase.MapSurrogate CreateSurrogate(Map asset)   // RVA 0x21749A0
private EntityPrototype CreateFromSurrogate(JsonAssetSerializerBase.EntityPrototypeSurrogate surrogate)   // RVA 0x2174530
private Map CreateFromSurrogate(JsonAssetSerializerBase.MapSurrogate surrogate)   // RVA 0x21742F0
private JsonAssetSerializerBase.BinaryDataSurrogate CreateSurrogate(BinaryData asset)   // RVA 0x21746E0
private BinaryData CreateFromSurrogate(JsonAssetSerializerBase.BinaryDataSurrogate surrogate)   // RVA 0x2174220
protected void .ctor()   // RVA 0x2175D90
```

### ChecksumFile.ChecksumEntry  (bases: ; TypeDefIndex 10280)
Fields:
```
public int Frame;  // 0x0
public long ChecksumAsLong;  // 0x8
```

### Quantum.ChecksumFile  (bases: ; TypeDefIndex 10281)
Fields:
```
public ChecksumFile.ChecksumEntry[] Checksums;  // 0x10
private int writeIndex;  // 0x18
```
Methods:
```
internal void RecordChecksum(QuantumGame game, int frame, ulong checksum)   // RVA 0x2168F10
internal void VerifyChecksum(QuantumGame game, int frame, ulong checksum)   // RVA 0x2169000
internal void Clear()   // RVA 0x2168EA0
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.ChecksumFileHelper  (bases: ; TypeDefIndex 10282)
Methods:
```
public static long UlongToLong(ulong value)   // RVA 0x62D6F0
```

### Quantum.InputProvider  (bases: IDeterministicReplayProvider, IDeterministicRpcProvider, IDeterministicInputProvider; TypeDefIndex 10283)
Fields:
```
private int _playerCount;  // 0x10
private int _growSize;  // 0x14
private int _startFrame;  // 0x18
private DeterministicTickInputSet[] _inputs;  // 0x20
```
Methods:
```
private int get_MaxFrame()   // RVA 0x2173D40
public void .ctor(DeterministicSessionConfig config, int capacity = 3600, int growSize = 0)   // RVA 0x2173BA0
public void .ctor(DeterministicTickInputSet[] inputList)   // RVA 0x2173C70
public void .ctor(int playerCount, int startFrame, int capacity, int growSize)   // RVA 0x2173C20
public void Clear(int startFrame)   // RVA 0x21736A0
public void ImportFromList(DeterministicTickInputSet[] inputList)   // RVA 0x2173950
public void OnInputConfirmed(QuantumGame game, DeterministicFrameInputTemp input)   // RVA 0x2173A20
private int ToIndex(int frame)   // RVA 0x2173B90
private void Allocate(int size)   // RVA 0x2173430
```

### Quantum.InputProviderExtensions  (bases: ; TypeDefIndex 10284)
Methods:
```
public static void Clear(DeterministicTickInput input)   // RVA 0x2173310
public static void Set(DeterministicTickInput input, DeterministicFrameInputTemp temp)   // RVA 0x21733C0
public static bool IsComplete(DeterministicTickInputSet set)   // RVA 0x2173360
```

### Quantum.ReplayFile  (bases: ; TypeDefIndex 10285)
Fields:
```
public RuntimeConfig RuntimeConfig;  // 0x10
public DeterministicSessionConfig DeterministicConfig;  // 0x18
public DeterministicTickInputSet[] InputHistory;  // 0x20
public int Length;  // 0x28
public byte[] Frame;  // 0x30
public int InitialFrame;  // 0x38
public byte[] InitialFrameData;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.SystemBase  (bases: ; TypeDefIndex 10287)
Fields:
```
private Nullable<int> _runtimeIndex;  // 0x10
private string _scheduleSample;  // 0x18
private SystemBase _parentSystem;  // 0x20
```
Methods:
```
public void set_RuntimeIndex(int value)   // RVA 0x217A850
public SystemBase get_ParentSystem()   // RVA 0x504300
public IEnumerable<SystemBase> get_Hierarchy()   // RVA 0x217A790
public void .ctor()   // RVA 0x217A6D0
public TaskHandle OnSchedule(Frame f, TaskHandle taskHandle)   // RVA 0x217A680
```

### Quantum.AudioInstanceCategoryID  (bases: ; TypeDefIndex 10290)
Fields:
```
public static HashString Announcer;  // 0x0
public static HashString General;  // 0x10
public static HashString CharacterVoiceOver;  // 0x20
public static HashString UI;  // 0x30
```
Methods:
```
public static List<HashString> GetAllCategories()   // RVA 0x2165570
private static void PopulateCategories(List<HashString> categories)   // RVA 0x2165850
public static bool AllowsMultipleInstancesPerSource(HashString category)   // RVA 0x2165330
private static void AllowsMultipleInstancesPerSource(HashString category, ref bool result)   // RVA 0x21654E0
private static void .cctor()   // RVA 0x2165930
```

### Quantum.GeneralCharacterEvents  (bases: ; TypeDefIndex 10291)
Methods:
```
public static void OnRoundVictory(Frame frame, EntityRef characterEntity)   // RVA 0x216EC50
public static void OnMatchVictory(Frame frame, EntityRef characterEntity)   // RVA 0x216EBF0
public static void OnEnterSuperSpeed(Frame frame, EntityRef characterEntity)   // RVA 0x216EAC0
public static void OnGetItem(Frame frame, EntityRef characterEntity)   // RVA 0x216EB90
public static void OnFreeze(Frame frame, EntityRef characterEntity)   // RVA 0x216EB10
public static void OnBurn(Frame frame, EntityRef characterEntity)   // RVA 0x216E9E0
public static void OnHitByRocket(Frame frame, EntityRef characterEntity)   // RVA 0x216EBC0
public static void OnCharacterHooked(Frame frame, EntityRef characterEntity)   // RVA 0x216EA30
public static void OnCharacterTackled(Frame frame, EntityRef characterEntity)   // RVA 0x216EA60
public static void OnRevenge(Frame frame)   // RVA 0x216EC20
public static void OnDeflected(Frame frame)   // RVA 0x216EA90
public static void OnGetBigAir(Frame frame)   // RVA 0x216EB60
public static void OnStillAlive(Frame frame)   // RVA 0x216EC80
```

### Quantum.CharacterID  (bases: ; TypeDefIndex 10292)
Fields:
```
public static HashString SpeedRunner;  // 0x0
public static HashString Hothead;  // 0x10
public static HashString Moonraker;  // 0x20
public static HashString Unic;  // 0x30
public static HashString Cosmonaut;  // 0x40
public static HashString Falcon;  // 0x50
public static HashString Frogman;  // 0x60
public static HashString ManekiNeko;  // 0x70
public static HashString Salem;  // 0x80
public static HashString Skull;  // 0x90
public static HashString Vamp;  // 0xA0
public static HashString Secret;  // 0xB0
public static HashString Starlight;  // 0xC0
public static HashString Undefined;  // 0xD0
public static HashString CharacterBase;  // 0xE0
```
Methods:
```
public static List<HashString> GetAllCharacterIDs()   // RVA 0x21670A0
private static void PopulateCharacterIDs(List<HashString> list)   // RVA 0x2167320
public static string GetValue(int hash)   // RVA 0x21672C0
public static HashString GetHashString(int hash)   // RVA 0x2167250
private static void .cctor()   // RVA 0x2167A80
```

### Quantum.GameModeID  (bases: ; TypeDefIndex 10293)
Fields:
```
public static HashString Race;  // 0x0
public static HashString Training;  // 0x10
public static HashString RaceTutorial;  // 0x20
public static HashString PlatformFight;  // 0x30
public static HashString LapsRace;  // 0x40
public static HashString Collectors;  // 0x50
public static HashString HazardsRace;  // 0x60
public static HashString TimedRace;  // 0x70
public static HashString TournamentMode;  // 0x80
public static HashString BuildingSpeedTutorial;  // 0x90
public static HashString MaintainingSpeedTutorial;  // 0xA0
public static HashString SwitchingDirectionsTutorial;  // 0xB0
public static HashString ClimbingWallsTutorial;  // 0xC0
public static HashString CratesAndBombsTutorial;  // 0xD0
public static HashString GoldenHookTutorial;  // 0xE0
public static HashString FreezeRayTutorial;  // 0xF0
public static HashString RocketTutorial;  // 0x100
public static HashString FireBallTutorial;  // 0x110
public static HashString ShockwaveTutorial;  // 0x120
public static HashString CampaignRace;  // 0x130
public static HashString BossFight;  // 0x140
public static HashString EscapeRoom;  // 0x150
public static HashString EndlessFalcon;  // 0x160
public static HashString EndlessFrog;  // 0x170
public static HashString CampaignLapsRace;  // 0x180
public static HashString CampaignHazardsRace;  // 0x190
public static HashString Undefined;  // 0x1A0
public static HashString Testing;  // 0x1B0
```
Methods:
```
public static List<HashString> GetAllGameModes()   // RVA 0x216CF80
private static void PopulateGameModes(List<HashString> list)   // RVA 0x216D1A0
public static HashString GetHashString(int hash)   // RVA 0x216D130
private static void .cctor()   // RVA 0x216DFA0
```

### Quantum.MatchNPC  (bases: ; TypeDefIndex 10294)
Fields:
```
public List<CharacterSpawnData> StartNPC;  // 0x10
```
Methods:
```
public void .ctor()   // RVA 0x2175E10
```

### Quantum.CommandEquipItem  (bases: BaseCommand; TypeDefIndex 10295)
Fields:
```
public int ItemHash;  // 0x28
public EntityRef EntityRef;  // 0x30
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandToggleFlyMode  (bases: BaseCommand; TypeDefIndex 10296)
Fields:
```
public bool Active;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandAddSpeedBoost  (bases: BaseCommand; TypeDefIndex 10297)
Fields:
```
public FP Amount;  // 0x28
public EntityRef EntityRef;  // 0x30
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandToggleNPCs  (bases: BaseCommand; TypeDefIndex 10298)
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandClearSpeedBoost  (bases: BaseCommand; TypeDefIndex 10299)
Fields:
```
public EntityRef EntityRef;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandDialogueFinished  (bases: BaseCommand; TypeDefIndex 10300)
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandSetupRaceTutorialInfo  (bases: BaseCommand; TypeDefIndex 10301)
Fields:
```
public bool IsInitialSection;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandCampaignChapterFinished  (bases: BaseCommand; TypeDefIndex 10302)
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandCampaignDialogueFinished  (bases: BaseCommand; TypeDefIndex 10303)
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandCampaignForceWin  (bases: BaseCommand; TypeDefIndex 10304)
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandSetupCampaignRaceLevelInfo  (bases: BaseCommand; TypeDefIndex 10305)
Fields:
```
public bool HasDialogue;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandCampaignRestartMatch  (bases: BaseCommand; TypeDefIndex 10306)
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandSetupMechanicTutorialSection  (bases: BaseCommand; TypeDefIndex 10307)
Fields:
```
public int SectionIndex;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandSetupEscapeRoomCourse  (bases: BaseCommand; TypeDefIndex 10308)
Fields:
```
public string SectionID;  // 0x28
public bool HasDialogue;  // 0x30
public int Difficulty;  // 0x34
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandSetupBossFightInfo  (bases: BaseCommand; TypeDefIndex 10309)
Fields:
```
public bool HasDialogue;  // 0x28
public int Difficulty;  // 0x2C
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandSpawnNPC  (bases: BaseCommand; TypeDefIndex 10310)
Fields:
```
public int NPCID;  // 0x28
public FPVector2 SpawnPosition;  // 0x30
public int FacingDirection;  // 0x40
public bool StartDisabled;  // 0x44
public CharacterSpawnData CharacterSpawnData;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x216A9E0
```

### Quantum.CommandToggleBlastzone  (bases: BaseCommand; TypeDefIndex 10311)
Fields:
```
public bool BlastzoneActive;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandDeletePlayerEntity  (bases: BaseCommand; TypeDefIndex 10312)
Fields:
```
public EntityRef Entity;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.CommandApplyGameModifierOptions  (bases: BaseCommand; TypeDefIndex 10313)
Fields:
```
public FP GameSpeed;  // 0x28
public bool IsInfiniteBoostActive;  // 0x30
public bool IsPersonalBestGhostActive;  // 0x31
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.SpawnTargetCandidate  (bases: ; TypeDefIndex 10314)
Fields:
```
public EntityRef Entity;  // 0x0
public FPVector2 Position;  // 0x8
```
Methods:
```
public void .ctor(EntityRef entity, FPVector2 position)   // RVA 0x21776A0
```

### Quantum.DisableAIVolume_Behaviour  (bases: StateBehaviour; TypeDefIndex 10315)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.NotifyFreezeRayAIDodge_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10316)
Methods:
```
public void .ctor()   // RVA 0x2176340
```

### Quantum.HandleHookLaunchAnimations_Behaviour  (bases: StateBehaviour; TypeDefIndex 10317)
Fields:
```
public AnimationPlayableInfo IdleAnimation;  // 0x60
public AnimationPlayableInfo IdleAirAnimation;  // 0xB8
public AnimationPlayableInfo RunAnimation;  // 0x110
public bool UseSeparateAnimationForRunBack;  // 0x168
public AnimationPlayableInfo RunBackAnimation;  // 0x170
public FP MinVelocity;  // 0x1C8
```
Methods:
```
private void PlayClip(Frame frame, int channel, CachedEntityData targetEntityData, AnimationPlayableInfo clip)   // RVA 0x2171360
private void UpdateWeights(Frame frame, CachedEntityData targetEntityData)   // RVA 0x2171500
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.HookLaunch_Behaviour  (bases: StateBehaviour; TypeDefIndex 10318)
Fields:
```
public ExecuteGroupEvent HookHitGroup;  // 0x60
public ExecuteGroupEvent HookFailedGroup;  // 0x78
public FPVector2 HookStartPoint;  // 0x90
public FP HookLengthIncreaseRate;  // 0xA0
public FP HookAngle;  // 0xA8
public CollisionLayer[] CeilingLayers;  // 0xB0
```
Methods:
```
private void CheckForHookCollision(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnerCharacter)   // RVA 0x21716A0
public void .ctor()   // RVA 0x2172100
```

### Quantum.HookSwing_Behaviour  (bases: StateBehaviour; TypeDefIndex 10319)
Fields:
```
public ExecuteGroupEvent MaxAngleReachGroup;  // 0x60
public ExecuteGroupEvent HookCancelGroup;  // 0x78
public FPVector2 HookStartPoint;  // 0x90
public FP MaxSwingAngle;  // 0xA0
```
Methods:
```
protected void UpdateVelocity(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame)   // RVA 0x2172420
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.InputCheck_Behaviour  (bases: StateBehaviour; TypeDefIndex 10320)
Fields:
```
public InputTransition Jump;  // 0x60
public InputTransition Hook;  // 0x98
public InputTransition Slide;  // 0xD0
```
Methods:
```
private void EvaluateInput(Frame frame, CachedEntityData targetEntityData)   // RVA 0x2173090
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.BossRocket_Behaviour  (bases: StateBehaviour; TypeDefIndex 10321)
Fields:
```
public FP HomingCooldown;  // 0x60
public FP InitialInterpolationSpeed;  // 0x68
public FP InterpolationSpeedIncrease;  // 0x70
public FP InitialSpeed;  // 0x78
public FP TargetVerticalOffset;  // 0x80
public int FramesForNewTargetCheck;  // 0x88
```
Methods:
```
private void FindTarget(Frame frame, CachedEntityData rocketEntityData, Rocket* rocket, int currentFrame)   // RVA 0x2165AB0
public void .ctor()   // RVA 0x2166260
```

### Quantum.FrogmanBossTongue_Behaviour  (bases: StateBehaviour; TypeDefIndex 10322)
Fields:
```
public HashString AttackDataID;  // 0x60
public FP MovementVelocity;  // 0x70
public FP HookRadius;  // 0x78
public FP AttractVelocity;  // 0x80
public FP FrozenAttractVelocity;  // 0x88
public FP MinAttractDistance;  // 0x90
public FP TargetTimeoutFrames;  // 0x98
public FP PullTimeoutFrames;  // 0xA0
public FP HookTargetMaxOutputVelocity;  // 0xA8
public ChangeStateEvent PulledByHookState;  // 0xB0
```
Methods:
```
private void MoveCharacterTowardsCenter(Frame frame, EntityRef entity, Transform2D* transform, PhysicsBody* physicsBody, FPVector2 middlePoint)   // RVA 0x216B650
private void FindTarget(Frame frame, CachedEntityData targetEntityData, FrogmanBossTongue* frogmanBossTongue, bool firstTime = False)   // RVA 0x216B260
public void .ctor()   // RVA 0x216CEE0
```

### Quantum.GoldenHook_Behaviour  (bases: StateBehaviour; TypeDefIndex 10323)
Fields:
```
public HashString AttackDataID;  // 0x60
public ExecuteGroupEvent CollisionDetectedGroup;  // 0x70
public ExecuteGroupEvent AttractStartedGroup;  // 0x88
public ExecuteGroupEvent AttractFinishedGroup;  // 0xA0
public ExecuteGroupEvent TimeoutGroup;  // 0xB8
public ExecuteGroupEvent DetectedSlideTargetGroup;  // 0xD0
public ExecuteGroupEvent DetectedWallSlideTargetGroup;  // 0xE8
public FP MovementVelocity;  // 0x100
public FP HookRadius;  // 0x108
public FP AttractVelocity;  // 0x110
public FP FrozenAttractVelocity;  // 0x118
public FP MinAttractDistance;  // 0x120
public FP TargetTimeoutFrames;  // 0x128
public FP PullTimeoutFrames;  // 0x130
public FP HookOwnerMaxOutputVelocity;  // 0x138
public FP HookTargetMaxOutputVelocity;  // 0x140
public ChangeStateEvent PulledByHookState;  // 0x148
```
Methods:
```
private void MoveCharacterTowardsCenter(Frame frame, EntityRef entity, Transform2D* transform, PhysicsBody* physicsBody, FPVector2 middlePoint)   // RVA 0x216F070
private void FindTarget(Frame frame, CachedEntityData targetEntityData, GoldenHook* goldenHook)   // RVA 0x216ECB0
public void .ctor()   // RVA 0x2170D90
```

### Quantum.Rocket_Behaviour  (bases: StateBehaviour; TypeDefIndex 10324)
Fields:
```
public FP InitialInterpolationSpeed;  // 0x60
public FP InterpolationSpeedIncrease;  // 0x68
public FP InitialSpeed;  // 0x70
public FP TargetVerticalOffset;  // 0x78
public int FramesForNewTargetCheck;  // 0x80
```
Methods:
```
private void FindTarget(Frame frame, CachedEntityData rocketEntityData, Rocket* rocket, int currentFrame)   // RVA 0x21766C0
public void .ctor()   // RVA 0x21771B0
```

### Quantum.ShockwavePower_Behaviour  (bases: StateBehaviour; TypeDefIndex 10325)
Fields:
```
public FP InitialPower;  // 0x60
public FP DefaultPower;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Shockwave_Behaviour  (bases: StateBehaviour; TypeDefIndex 10326)
Fields:
```
public FP ShockwaveDelay;  // 0x60
public int InterpolationFramesDuration;  // 0x68
public FPAnimationCurve InterpolationCurve;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x2177680
```

### Quantum.CheckForLedgeClimb_Behaviour  (bases: StateBehaviour; TypeDefIndex 10327)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.CheckSlopeSurfSetup_Behaviour  (bases: StateBehaviour; TypeDefIndex 10328)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ItemUseCheck_Behaviour  (bases: StateBehaviour; TypeDefIndex 10329)
Fields:
```
public ExecuteGroupEvent ItemUsedGroup;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.NotifyGeneralCharacterVOEvent_Behaviour  (bases: StateBehaviour; TypeDefIndex 10330)
Fields:
```
public GameplayCharacterVOEvent CharacterVOEvent;  // 0x60
public GameplayAnnouncerVOEvent AnnouncerVOEvent;  // 0x64
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.PlayerStat_Behaviour  (bases: StateBehaviour; TypeDefIndex 10331)
Fields:
```
public PlayerStatEventType EventType;  // 0x60
public HitType hitType;  // 0x64
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ResetVelocityOnWallDetection_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10333)
Methods:
```
public void .ctor()   // RVA 0x2176340
```

### Quantum.SpeedRunnerMovement_Behaviour  (bases: StateBehaviour; TypeDefIndex 10334)
Fields:
```
public bool Sliding;  // 0x60
public bool Swinging;  // 0x61
public FacingDirectionUpdateMode FacingDirectionMode;  // 0x64
```
Methods:
```
private void UpdateVelocity(Frame frame, CachedEntityData targetEntityData, int currentFrame)   // RVA 0x2178610
private void UseBoost(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnerCharacter, SpeedRunnersSettingsData speedRunnersSettingsData, FP delta)   // RVA 0x21795B0
private FP SlopeMaxVelocityCorrection(FPVector2 movDirection, int facingDirection)   // RVA 0x2178560
private void CalculateAcceleration(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnersCharacter, SpeedRunnersSettingsData speedRunnersSettingsData, FP delta)   // RVA 0x21776B0
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SpeedRunnersDetectWallSlide_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10336)
Fields:
```
public FP MinWallNormal;  // 0x68
public ChangeStateEvent WallSlideState;  // 0x70
public EntityVariable LinecastHeight;  // 0x88
public EntityVariable LinecastLength;  // 0x90
public CollisionLayer[] DefaultLinecastLayers;  // 0x98
public CollisionLayer[] OnGoingDownLinecastLayers;  // 0xA0
public ColorRGBA DebugColor;  // 0xA8
```
Methods:
```
public void .ctor()   // RVA 0x217A570
```

### Quantum.SpeedRunnersJump_Behaviour  (bases: StateBehaviour; TypeDefIndex 10337)
Fields:
```
public JumpBehaviourType JumpType;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SpeedRunnersKnockedOut_Behaviour  (bases: StateBehaviour; TypeDefIndex 10338)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SpeedRunnersWallSlide_Behaviour  (bases: StateBehaviour; TypeDefIndex 10339)
Fields:
```
public FP MinWallNormal;  // 0x60
public ChangeStateEvent IdleAirState;  // 0x68
public ExecuteGroupEvent OnLeaveWallGroup;  // 0x80
public CollisionLayer[] WallLayers;  // 0x98
```
Methods:
```
public void .ctor()   // RVA 0x2195EE0
```

### Quantum.StartInviciDrill_Behaviour  (bases: StateBehaviour; TypeDefIndex 10340)
Fields:
```
public EntityVariable InviciDrillFrames;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.BoostFillerUpdate_Behaviour  (bases: StateBehaviour; TypeDefIndex 10341)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.BreakableGlassImpact_Behaviour  (bases: StateBehaviour; TypeDefIndex 10342)
Fields:
```
public ExecuteGroupEvent OnBreakGroup;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.BreakableGlassInactive_Behaviour  (bases: StateBehaviour; TypeDefIndex 10343)
Fields:
```
public ExecuteGroupEvent OnRestoreReadyGroup;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.CollectorTreasureTriggered_Behaviour  (bases: StateBehaviour; TypeDefIndex 10344)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### ItemBoxTriggered_Behaviour.ItemWeightInfo  (bases: ; TypeDefIndex 10345)
Fields:
```
public HashString ID;  // 0x0
public int OnePlayerWeight;  // 0x10
public int TwoPlayersWeight;  // 0x14
public int ThreePlayersWeight;  // 0x18
public int FourPlayersWeight;  // 0x1C
```

### ItemBoxTriggered_Behaviour.GameModeItemBlacklist  (bases: ; TypeDefIndex 10346)
Fields:
```
public HashString GameModeID;  // 0x0
public HashString[] BlacklistedItems;  // 0x10
```

### ItemBoxTriggered_Behaviour.SingleItemWeightInfo  (bases: ; TypeDefIndex 10347)
Fields:
```
public HashString ID;  // 0x0
public int Weight;  // 0x10
```
Methods:
```
public void .ctor(HashString id, int weight)   // RVA 0xE07060
```

### Quantum.ItemBoxTriggered_Behaviour  (bases: StateBehaviour; TypeDefIndex 10348)
Fields:
```
public ItemBoxTriggered_Behaviour.GameModeItemBlacklist[] GameModeBlacklists;  // 0x60
public ItemBoxTriggered_Behaviour.ItemWeightInfo[] FirstPlayerProbabilities;  // 0x68
public ItemBoxTriggered_Behaviour.ItemWeightInfo[] SecondPlayerProbabilities;  // 0x70
public ItemBoxTriggered_Behaviour.ItemWeightInfo[] ThirdPlayerProbabilities;  // 0x78
public ItemBoxTriggered_Behaviour.ItemWeightInfo[] FourthPlayerProbabilities;  // 0x80
```
Methods:
```
private ItemBoxTriggered_Behaviour.SingleItemWeightInfo[] GenerateSingleItemWeightArray(HashSet<int> blacklist, int totalPlayers, ItemBoxTriggered_Behaviour.ItemWeightInfo[] originalArray)   // RVA 0x218FBF0
private int PickRandomItem(Frame frame, int totalPlayers, int rank)   // RVA 0x2190480
private HashSet<int> GetBlacklistByGameMode(HashString gameModeID)   // RVA 0x218FEA0
public void .ctor()   // RVA 0x21906C0
```

### Quantum.Laser_Behaviour  (bases: StateBehaviour; TypeDefIndex 10349)
Fields:
```
public FP RotationSpeed;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x2190900
```

### Quantum.NotifyItemRefresh_Behaviour  (bases: StateBehaviour; TypeDefIndex 10350)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.RocketLauncher_Behaviour  (bases: StateBehaviour; TypeDefIndex 10351)
Fields:
```
public AssetRefGameEntityData RocketGameEntity;  // 0x60
public int ShootCooldownFrames;  // 0x68
public FPVector2 SpawnPosition;  // 0x70
public CollisionLayer[] LinecastLayers;  // 0x80
```
Methods:
```
private bool HasLineOfSight(Frame frame, EntityRef entity, FPVector2 startPoint, FPVector2 endPoint, int layerMask)   // RVA 0x2191870
public void .ctor()   // RVA 0x2192190
```

### Quantum.BossFightCameraManagerData  (bases: CameraManagerData; TypeDefIndex 10352)
Fields:
```
public FPVector2 ViewportPosition;  // 0xC0
```
Methods:
```
public void .ctor()   // RVA 0x217BAB0
```

### Quantum.EndlessCameraManager  (bases: CameraManagerData; TypeDefIndex 10353)
Methods:
```
public SimpleAABB CalculateCameraRect(Frame frame, CameraManager* cameraManager, SpeedRunnersSettingsData speedRunnersSettingsData, GlobalCameraSettingsData globalData, bool forceUpdate = False)   // RVA 0x217E950
public static FPVector2 InterpolateCameraToPosition(Frame frame, FPVector2 desiredViewTarget, FPVector2 currentViewTarget, FP interpolationStep)   // RVA 0x217EEA0
public void .ctor()   // RVA 0x217BAB0
```

### Quantum.RoomInternalEntity  (bases: ; TypeDefIndex 10354)
Fields:
```
public AssetRefEntityPrototype Prototype;  // 0x0
public FPVector3 RelativePosition;  // 0x8
```

### Quantum.Freeze_Behaviour  (bases: StateBehaviour; TypeDefIndex 10355)
Fields:
```
public ExecuteGroupEvent FreezeEndGroup;  // 0x60
```
Methods:
```
private void UpdateVelocity(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnersCharacter)   // RVA 0x218C360
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Hurt_Behaviour  (bases: StateBehaviour; TypeDefIndex 10356)
Fields:
```
private FP STUN_TIME_LETHALS;  // 0x60
private FP STUN_TIME_FIREBALL;  // 0x68
private FP STUN_TIME_ROCKET;  // 0x70
public ExecuteGroupEvent TripGroup;  // 0x78
public HashString[] TripAttackDatas;  // 0x90
public ExecuteGroupEvent TumbleGroup;  // 0x98
public HashString[] TumbleAttackDatas;  // 0xB0
public ExecuteGroupEvent FreezeGroup;  // 0xB8
public HashString[] FreezeAttackDatas;  // 0xD0
public EntityVariable FreezeFrames;  // 0xD8
public EntityVariable OutIsOnFire;  // 0xE0
public HashString TackleAttackData;  // 0xE8
public HashString LethalObstacleAttackData;  // 0xF8
public HashString RocketAttackData;  // 0x108
public HashString RocketSelfExplosionAttackData;  // 0x118
public HashString FireballAttackData;  // 0x128
public HashString ShockwaveAttackData;  // 0x138
public HashString RemoteBombAttackData;  // 0x148
public HashString CrateAttackData;  // 0x158
public HashString InvinciDrillAttackData;  // 0x168
public HashString PlasmaBlasterAttackData;  // 0x178
public HashString[] PushbackAttackDatas;  // 0x188
```
Methods:
```
public void .ctor()   // RVA 0x218EB30
```

### Quantum.Idle_Behaviour  (bases: StateBehaviour; TypeDefIndex 10357)
Fields:
```
public ChangeStateEvent RunState;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.RunTurn_Behaviour  (bases: StateBehaviour; TypeDefIndex 10358)
Fields:
```
public ChangeStateEvent RunState;  // 0x60
public ChangeStateEvent IdleState;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Run_Behaviour  (bases: StateBehaviour; TypeDefIndex 10359)
Fields:
```
public ChangeStateEvent IdleState;  // 0x60
public ChangeStateEvent RunTurnState;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SimpleHurt_Behaviour  (bases: StateBehaviour; TypeDefIndex 10360)
Fields:
```
public ExecuteGroupEvent GroupForSuccessfulHit;  // 0x60
public HashString[] AttackDatasToReact;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x21926A0
```

### Quantum.Slide_Behaviour  (bases: StateBehaviour; TypeDefIndex 10361)
Fields:
```
public ChangeStateEvent IdleState;  // 0x60
public ChangeStateEvent IdleAirState;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SpeedRunnersEntrance_Behaviour  (bases: StateBehaviour; TypeDefIndex 10362)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Stunned_Behaviour  (bases: StateBehaviour; TypeDefIndex 10363)
Fields:
```
public ExecuteGroupEvent HitStunEndGroup;  // 0x60
```
Methods:
```
private void UpdateVelocity(Frame frame, CachedEntityData targetEntityData, int currentFrame)   // RVA 0x21963D0
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.NotifyGoalID_Behaviour  (bases: StateBehaviour; TypeDefIndex 10364)
Fields:
```
public HashString[] GoalIDs;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x2190B10
```

### Quantum.SpeedRunnersCameraManagerData  (bases: CameraManagerData; TypeDefIndex 10365)
Methods:
```
public SimpleAABB CalculateMultiplayerCameraRect(Frame frame, CameraManager* cameraManager, SpeedRunnersSettingsData speedRunnersSettingsData, GlobalCameraSettingsData globalData, bool forceUpdate = False)   // RVA 0x2192930
public SimpleAABB CalculateSinglePlayerCameraRect(Frame frame, CameraManager* cameraManager, SpeedRunnersSettingsData speedRunnersSettingsData, GlobalCameraSettingsData globalData, bool forceUpdate = False)   // RVA 0x2193770
public static FPVector2 InterpolateCameraToPosition(Frame frame, FPVector2 desiredViewTarget, FPVector2 currentViewTarget, FP interpolationStep)   // RVA 0x217EEA0
public void .ctor()   // RVA 0x217BAB0
```

### Quantum.SuperSpeedBrosCameraManagerData  (bases: CameraManagerData; TypeDefIndex 10366)
Fields:
```
public FP MaxZoom;  // 0xC0
public FP MinZoom;  // 0xC8
public FP ZoomScale;  // 0xD0
public FP MovementSmoothing;  // 0xD8
```
Methods:
```
public static FPVector2 InterpolateCameraToPosition(Frame frame, FPVector2 desiredViewTarget, FPVector2 currentViewTarget, FP interpolationStep)   // RVA 0x21965C0
public void .ctor()   // RVA 0x2197080
```

### Quantum.PickupItemUsage  (bases: ; TypeDefIndex 10368)
Fields:
```
public PickupItemAction Action;  // 0x0
public int ItemUseActiveFrames;  // 0x4
public string[] SFXToPlay;  // 0x8
public HashString TargetState;  // 0x10
public AssetRefGameEntityData GameEntity;  // 0x20
public bool CheckCollisionsInBetween;  // 0x28
public EntityVariable XPosition;  // 0x30
public EntityVariable YPosition;  // 0x38
public bool PositionRelativeToSpawner;  // 0x40
public bool UseSpawnerFacingDirection;  // 0x41
```
Methods:
```
public void Execute(Frame frame, EntityRef fromEntity)   // RVA 0x2190CB0
```

### Quantum.NPCDifficultyData  (bases: ; TypeDefIndex 10370)
Fields:
```
public int ID;  // 0x10
public int DodgeChance;  // 0x14
public int UnfreezeSpeed;  // 0x18
public int TackleChance;  // 0x1C
public int TackleCooldown;  // 0x20
public int MaxSpeed;  // 0x24
```
Methods:
```
public void .ctor()   // RVA 0x2190990
```

### Quantum.NPCItemUseData  (bases: ; TypeDefIndex 10371)
Fields:
```
public HashString ID;  // 0x10
public FP UseCooldownFrame;  // 0x20
public int MinGeneralDistance;  // 0x28
public int MaxGeneralDistance;  // 0x2C
public int MaxXUseDistance;  // 0x30
public int MinXUseDistance;  // 0x34
public int MaxYUseDistance;  // 0x38
public int MinYUseDistance;  // 0x3C
public bool NeedsLineOfSight;  // 0x40
public bool NeedsSpaceToFire;  // 0x41
public int SpaceAmount;  // 0x44
public TargetDirection TargetDirectionUse;  // 0x48
```
Methods:
```
public void .ctor()   // RVA 0x21909B0
```

### Quantum.EntityUtils  (bases: ; TypeDefIndex 10372)
Methods:
```
public static bool TryGetSpeedRunnersCharacter(Frame frame, EntityRef entity, out SpeedRunnersCharacter* speedRunnerCharacter)   // RVA 0x2184AD0
public static bool TryGetGoldenHook(Frame frame, EntityRef entity, out GoldenHook* goldenHook)   // RVA 0x2182620
public static bool TryGetFrogmanBossTongue(Frame frame, EntityRef entity, out FrogmanBossTongue* frogmanBossTongue)   // RVA 0x2182300
public static bool TryGetRocket(Frame frame, EntityRef entity, out Rocket* rocket)   // RVA 0x2184490
public static bool TryGetShockwave(Frame frame, EntityRef entity, out Shockwave* shockwave)   // RVA 0x21847B0
public static bool TryGetCheckpoint(Frame frame, EntityRef entity, out Checkpoint* checkpoint)   // RVA 0x21803A0
public static bool TryGetStageHazardSpawnArea(Frame frame, EntityRef entity, out StageHazardSpawnArea* stageHazardSpawnArea)   // RVA 0x2185110
public static bool TryGetSuperBoostVolume(Frame frame, EntityRef entity, out SuperBoostVolume* superBoostVolume)   // RVA 0x2185F20
public static bool TryGetSpike(Frame frame, EntityRef entity, out Spike* spike)   // RVA 0x2184DF0
public static bool TryGetAIVolume(Frame frame, EntityRef entity, out AIVolume* aiVolume)   // RVA 0x217FD60
public static bool TryGetTrapDoorSwitch(Frame frame, EntityRef entity, out TrapDoorSwitch* trapDoorSwitch)   // RVA 0x21871E0
public static bool TryGetLaser(Frame frame, EntityRef entity, out Laser* laser)   // RVA 0x2182F80
public static bool TryGetRocketLauncher(Frame frame, EntityRef entity, out RocketLauncher* rocketLauncher)   // RVA 0x2184300
public static bool TryGetItemBox(Frame frame, EntityRef entity, out ItemBox* itemBox)   // RVA 0x2182AD0
public static bool TryGetSpeedRunnersNPC(Frame frame, EntityRef entity, out SpeedRunnersNPC* npc)   // RVA 0x2184C60
public static bool IsCharacterSpeedRunnersNPC(Frame frame, EntityRef entity)   // RVA 0x217F920
public static bool TryGetMechanicTutorialGoalTrigger(Frame frame, EntityRef entity, out MechanicTutorialGoalTrigger* goalTrigger)   // RVA 0x2183110
public static bool TryGetEscapeRoomGoalTrigger(Frame frame, EntityRef entity, out EscapeRoomGoalTrigger* escapeRoomgoalTrigger)   // RVA 0x2182170
public static bool TryGetSecretRoomTrigger(Frame frame, EntityRef entity, out SecretRoomTrigger* secretRoomTrigger)   // RVA 0x2184620
public static bool TryGetBreakableGlass(Frame frame, EntityRef entity, out BreakableGlass* breakableGlass)   // RVA 0x2180080
internal static bool TryGetRespawnPoint(Frame frame, EntityRef entity, out RespawnPoint* respawnPoint)   // RVA 0x2184170
public static bool TryGetPlayerStats(Frame frame, EntityRef characterEntity, out PlayerStats* playerStats)   // RVA 0x2183FE0
public static bool TryGetCollectorsTreasureSpawnArea(Frame frame, EntityRef entity, out CollectorsTreasureSpawnArea* spawnArea)   // RVA 0x2180850
public static bool TryGetCollectorTreasure(Frame frame, EntityRef entity, out CollectorTreasure* collectorTreasure)   // RVA 0x21806C0
public static bool TryGetCollectorCharacter(Frame frame, EntityRef entity, out CollectorCharacter* collectorCharacter)   // RVA 0x2180530
public static bool TryGetBlastzoneTrigger(Frame frame, EntityRef entity, out BlastzoneTrigger* blastzoneTrigger)   // RVA 0x217FEF0
public static bool TryGetTargetEntity(Frame frame, CachedEntityData entityData, BehaviourTargetEntity targetEntityToCheck, HashString targetIndexParameterID, out CachedEntityData targetEntity)   // RVA 0x21860B0
public static bool TryFindFromIndex(Frame frame, int index, out EntityRef entityFound)   // RVA 0x217FC50
public static bool TryGetGameEntity(Frame frame, EntityRef entity, out GameEntity* gameEntity)   // RVA 0x2182490
public static bool TryGetEntityReferencesHandler(Frame frame, EntityRef entity, out EntityReferencesHandler* entityReferencesHandler)   // RVA 0x2181FE0
public static bool TryGetPartnersManager(Frame frame, EntityRef entity, out PartnersManager* partnersManager)   // RVA 0x21839A0
public static bool TryGetEntityModifier(Frame frame, EntityRef entity, out EntityModifier* entityModifier)   // RVA 0x2181E50
public static bool TryGetEntityModifierTarget(Frame frame, EntityRef entity, out EntityModifierTarget* entityModifierTarget)   // RVA 0x2181CC0
public static bool TryGetTransform(Frame frame, EntityRef entity, out Transform2D* transform2D)   // RVA 0x2187050
public static bool TryGetStatic(Frame frame, EntityRef entity, out Static* _static)   // RVA 0x2185750
public static bool TryGetVelocityModifier(Frame frame, EntityRef entity, out VelocityModifier* velocityModifier)   // RVA 0x2187820
public static bool TryGetPhysicsModifier(Frame frame, EntityRef entity, out PhysicsModifier* physicsModifier)   // RVA 0x2183E50
public static bool TryGetStageSFX(Frame frame, EntityRef entity, out StageSFX* stageSFX)   // RVA 0x21852A0
public static bool TryGetNonDeterministicAniamtion(Frame frame, EntityRef entity, out NonDeterministicAnimation* nonDeterministic)   // RVA 0x2183680
public static bool TryGetVisibilityTarget(Frame frame, EntityRef entity, out VisibilityTarget* visibilityTarget)   // RVA 0x2187B40
public static bool TryGetVisibilitySource(Frame frame, EntityRef entity, out VisibilitySource* visibilitySource)   // RVA 0x21879B0
public static bool TryGetVisualShake(Frame frame, EntityRef entity, out VisualShake* visualShake)   // RVA 0x2187CD0
public static bool TryGetParentObject(Frame frame, EntityRef entity, out ParentObject* parentObject)   // RVA 0x2183810
public static bool TryGetStaticRotation(Frame frame, EntityRef entity, out StaticRotation* staticRotation)   // RVA 0x21855C0
public static bool TryGetStellarCharacter(Frame frame, EntityRef entity, out StellarCharacter* character)   // RVA 0x2185C00
public static bool TryGetMovesetLimiter(Frame frame, EntityRef entity, out MovesetLimiter* movesetLimiter)   // RVA 0x21834F0
public static bool TryGetInputBuffer(Frame frame, EntityRef entity, out InputBuffer* inputBuffer)   // RVA 0x2182940
public static bool TryGetStateMachine(Frame frame, EntityRef entity, out StateMachine* stateMachine)   // RVA 0x2185430
public static bool TryGetCustomAnimator(Frame frame, EntityRef entity, out CustomAnimator* customAnimator)   // RVA 0x2181740
public static bool TryGetSimpleLineRenderer(Frame frame, EntityRef entity, out SimpleLineRenderer* simpleLineRenderer)   // RVA 0x2184940
public static bool TryGetPhysicsBody(Frame frame, EntityRef entity, out PhysicsBody* physicsBody)   // RVA 0x2183B30
public static bool TryGetTrigger(Frame frame, EntityRef entity, out Trigger* trigger)   // RVA 0x2187690
public static bool TryGetPhysicsCollider(Frame frame, EntityRef entity, out PhysicsCollider2D* collider)   // RVA 0x2183CC0
public static bool TryGetTriggerSphereShape(Frame frame, EntityRef entity, out TriggerSphereShape* shape)   // RVA 0x2187500
public static bool TryGetTriggerPolygonShape(Frame frame, EntityRef entity, out TriggerPolygonShape* shape)   // RVA 0x2187370
public static bool TryGetEdgeGrab(Frame frame, EntityRef entity, out EdgeGrab* edgeGrab)   // RVA 0x2181A60
public static bool TryGetStageEdge(Frame frame, EntityRef entity, out StageEdge* stageEdge)   // RVA 0x2184F80
public static bool TryGetDynamicStageElement(Frame frame, EntityRef entity, out DynamicStageElement* dynamicStageElement)   // RVA 0x21818D0
public static bool TryGetCombat(Frame frame, EntityRef entity, out Combat* combat)   // RVA 0x2181420
public static bool TryGetCombatDamage(Frame frame, EntityRef entity, out CombatDamage* combatDamage)   // RVA 0x2181020
public static bool TryGetCombatStamina(Frame frame, EntityRef entity, out CombatStamina* combatStamina)   // RVA 0x21810F0
public static bool TryGetCombatStocks(Frame frame, EntityRef entity, out CombatStocks* combatStocks)   // RVA 0x21811C0
public static bool TryGetCombatBlock(Frame frame, EntityRef entity, out CombatBlock* combatBlock)   // RVA 0x2180B70
public static bool TryGetCombatTech(Frame frame, EntityRef entity, out CombatTech* combatTech)   // RVA 0x2181290
public static bool TryGetCombatCharge(Frame frame, EntityRef entity, out CombatCharge* combatCharge)   // RVA 0x2180D00
public static bool TryGetCombatArmor(Frame frame, EntityRef entity, out CombatArmor* combatArmor)   // RVA 0x21809E0
public static bool TryGetCombatDI(Frame frame, EntityRef entity, out CombatDI* combatDI)   // RVA 0x2180E90
public static bool TryGetTeams(Frame frame, EntityRef entity, out Teams* teams)   // RVA 0x2186EC0
public static bool TryGetGrab(Frame frame, EntityRef entity, out Grab* grab)   // RVA 0x21827B0
public static bool TryGetKinematicBody(Frame frame, EntityRef entity, out KinematicBody* kinematicBody)   // RVA 0x2182DF0
public static bool TryGetContinuousRotation(Frame frame, EntityRef entity, out ContinuousRotation* continuousRotation)   // RVA 0x21815B0
public static bool TryGetCameraTarget(Frame frame, EntityRef entity, out CameraTarget* cameraTarget)   // RVA 0x2180210
public static bool TryGetStellarNPC(Frame frame, EntityRef entity, out StellarNPC* npc)   // RVA 0x2185D90
public static bool IsCharacterNPC(Frame frame, EntityRef entity)   // RVA 0x217F7B0
public static bool TryGetJump(Frame frame, EntityRef entity, out Jump* jump)   // RVA 0x2182C60
public static bool TryGetEnergyBar(Frame frame, EntityRef entity, out EnergyBar* energyBar)   // RVA 0x2181BF0
public static bool TryGetMovable(Frame frame, EntityRef entity, out Movable* movable, bool addComponent = False)   // RVA 0x21832A0
public static bool TryGetStatusEffectsHolder(Frame frame, EntityRef entity, out StatusEffectsHolder* statusEffectsHolder)   // RVA 0x21858E0
public static bool TryGetStatusEffectsModifiers(Frame frame, EntityRef entity, out StatusEffectsModifiers* statusEffectsModifiers)   // RVA 0x2185A70
public static void DestroyEntity(Frame frame, EntityRef entity)   // RVA 0x217F590
public static bool IsEntityInDestroyQueue(Frame frame, EntityRef entity)   // RVA 0x217FA90
```

### Quantum.EntityVariableBase  (bases: ; TypeDefIndex 10373)
Fields:
```
public BehaviourTargetEntity TargetEntity;  // 0x10
public HashString TargetIndexParameterID;  // 0x18
public int Source;  // 0x28
public int SourceVariableIndex;  // 0x2C
public FP FloatValue;  // 0x30
public HashString ParameterID;  // 0x38
public InputPrerequisiteMode PrerequisiteEvaluation;  // 0x48
public InputBufferEventChecker[] InputActions;  // 0x50
public InputBufferEventChecker[] InputPrerequisites;  // 0x58
public static HashString[] StatusEffectsTypes;  // 0x0
public int SelectedStatusEffectType;  // 0x60
public bool IgnoreOriginEntity;  // 0x64
public BehaviourTargetEntity OriginEntity;  // 0x68
public HashString OriginIndexParameterID;  // 0x70
```
Methods:
```
public void SetValue(Frame frame, CachedEntityData entityData, FP value)   // RVA 0x218B490
public FP GetValue(Frame frame, CachedEntityData entityData)   // RVA 0x2187F60
private void ExtendedSetValue(Frame frame, CachedEntityData entityData, FP value)   // RVA 0x2187EE0
private void ExtendedGetValue(Frame frame, CachedEntityData entityData, ref FP value)   // RVA 0x2187E60
protected void .ctor()   // RVA 0x218BD10
private static void .cctor()   // RVA 0x218BC70
```

### Quantum.GameSpecificInputSettings  (bases: ; TypeDefIndex 10374)
Fields:
```
public int HookBufferFrames;  // 0x0
public int JumpBufferFrames;  // 0x4
public int UseItemBufferFrames;  // 0x8
```

### Quantum.InputUtils  (bases: ; TypeDefIndex 10375)
Methods:
```
private static bool CheckJump(Frame frame, EntityRef entity, GameplayInputSettingsData gameplayInputSettingsData, SpeedRunnersSettingsData speedRunnersSettingsData, InputTransition inputTransition, InputBuffer* inputBuffer, bool grounded, bool invertX)   // RVA 0x218EF50
private static bool CheckHook(Frame frame, EntityRef entity, GameplayInputSettingsData gameplayInputSettingsData, SpeedRunnersSettingsData speedRunnersSettingsData, InputTransition inputTransition, InputBuffer* inputBuffer, bool grounded, bool invertX)   // RVA 0x218ECD0
private static bool CheckSlide(Frame frame, EntityRef entity, GameplayInputSettingsData gameplayInputSettingsData, SpeedRunnersSettingsData speedRunnersSettingsData, InputTransition inputTransition, InputBuffer* inputBuffer, bool grounded, bool invertX)   // RVA 0x218F0F0
public static void EvaluateDefault(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, InputCheck_Behaviour inputCheckData, EntityRef entity, bool grounded = True)   // RVA 0x218F2F0
public static void EvaluateEntityThrow(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, DetectEntityThrow_Behaviour entityThrowBehaviour, EntityRef entity, Grab* grab, EntityRef grabbedEntity, bool grounded)   // RVA 0x4F3940
private static void OnEvaluateDefault(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, InputCheck_Behaviour inputCheckData, EntityRef entity, bool grounded = True)   // RVA 0x218F580
private static void OnEvaluateEntityThrow(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, DetectEntityThrow_Behaviour entityThrowBehaviour, EntityRef entity, Grab* grab, EntityRef grabbedEntity, bool grounded)   // RVA 0x4F3940
public static bool ShouldInvertDirection(GameEntity* gameEntity)   // RVA 0x218FBD0
private static void EvaluateInputAction(Frame frame, EntityRef entity, InputAction action, ExecuteGroupEvent executeGroupEvent, ChangeStateEvent changeStateEvent, bool forceTurn = False)   // RVA 0x218F310
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.MatchRules  (bases: ; TypeDefIndex 10376)
Fields:
```
public List<int> ActiveItems;  // 0x10
public int RoundsAmount;  // 0x18
public int MatchTimer;  // 0x1C
public int KnockDownsDelay;  // 0x20
public int StageItemUseDelay;  // 0x24
public HashString GameMode;  // 0x28
public bool TeamsActive;  // 0x38
public bool FriendlyFire;  // 0x39
```
Methods:
```
public void .ctor()   // RVA 0x2190910
```

### Quantum.PlayerUtils  (bases: ; TypeDefIndex 10377)
Methods:
```
public static bool TryGetPlayerSettings(Frame frame, EntityRef entity, out PlayerSettings playerSettings)   // RVA 0x2191550
private static void OnTryGetPlayerSettings(Frame frame, EntityRef entity, ref PlayerSettings playerSettings)   // RVA 0x21913C0
```

### Quantum.PickupItemUsageDataFile  (bases: ; TypeDefIndex 10378)
Fields:
```
public HashString ID;  // 0x0
public AssetRefPickupItemUsageData Data;  // 0x10
```

### Quantum.CampaignRaceGameMode  (bases: RaceGameMode; TypeDefIndex 10381)
Fields:
```
public GameSpeedModifier DialogueSpeedModifier;  // 0xA0
```
Methods:
```
public static bool TryFindManager(Frame frame, out CampaignRaceGameModeManager* campaignManager)   // RVA 0x217CDB0
public void RestartMatch(Frame frame)   // RVA 0x217CD20
public void OnCampaignDialogueFinished(Frame frame)   // RVA 0x217C0A0
public void OnCampaignChapterFinished(Frame frame)   // RVA 0x217C050
internal void OnInfoSetup(Frame frame, bool hasDialogue)   // RVA 0x217C480
public void OnCampaignForceWin(Frame frame)   // RVA 0x217C100
public void .ctor()   // RVA 0x217CF70
```

### Quantum.CollectorsGameMode  (bases: RaceGameMode; TypeDefIndex 10382)
Fields:
```
public FP MatchTime;  // 0xA0
public FP TreasureSpawnRate;  // 0xA8
public int MaxTreasures;  // 0xB0
public TreasureWeightElement[] Treasures;  // 0xB8
public CollectorAttackData[] AttackDatasToDropTreasures;  // 0xC0
```
Methods:
```
public static bool TryFindCollectorsModeManager(Frame frame, out CollectorsGameModeManager* collectorsManager)   // RVA 0x217E750
public void .ctor()   // RVA 0x217E8A0
```

### Quantum.TreasureWeightElement  (bases: ; TypeDefIndex 10383)
Fields:
```
public int Weight;  // 0x0
public AssetRefGameEntityData GameEntityData;  // 0x8
public int CostumeIndex;  // 0x10
public int Value;  // 0x14
```

### Quantum.CollectorAttackData  (bases: ; TypeDefIndex 10384)
Fields:
```
public HashString AttackData;  // 0x0
public bool FlipScores;  // 0x10
public int ScoreToLoseOnVictim;  // 0x14
public int ScoreToEarnOnInstigator;  // 0x18
```

### Quantum.CollectorCharacterPlacementEntry  (bases: ; TypeDefIndex 10385)
Fields:
```
public EntityRef Entity;  // 0x0
public int Score;  // 0x8
public FP DistanceTraveled;  // 0x10
```
Methods:
```
public void .ctor(EntityRef entity, int score, FP distanceTraveled)   // RVA 0x219C8F0
```

### Quantum.EndlessBossFightGameMode  (bases: BossFightGameMode; TypeDefIndex 10386)
Fields:
```
public List<AssetRefRoomConfig> RoomConfigs;  // 0xF8
public int MaxPlataforms;  // 0x100
public FP PlataformDistance;  // 0x108
public FP SpawnThreshold;  // 0x110
public FP TopBlastzoneBouncePower;  // 0x118
public FP RightBlastzoneBouncePower;  // 0x120
private FPVector2 FirstSpawnPosition;  // 0x128
```
Methods:
```
private void SpawnNextPlatform(Frame frame, EndlessGameModeManager* endlessManager)   // RVA 0x219F4D0
public static bool TryFindManager(Frame frame, out EndlessGameModeManager* endlessManager)   // RVA 0x219FE60
private void DestroyRoom(Frame frame, EntityRef anchorToDestroy)   // RVA 0x219DF10
public void OnCampaignForceWin(Frame frame)   // RVA 0x2199A20
public void .ctor()   // RVA 0x219FFB0
```

### Quantum.EscapeRoomGameMode  (bases: SpeedRunnersBaseGameMode; TypeDefIndex 10387)
Fields:
```
public FP WaitTimeBetweenRounds;  // 0x68
public FP WaitTimeToReturnToMainMenu;  // 0x70
public FP WaitTimeToShowBanners;  // 0x78
public EscapeRoomCourse[] Courses;  // 0x80
public GameSpeedModifier DialogueSpeedModifier;  // 0x88
public GameSpeedModifier EndSlowDownSpeedModifier;  // 0xA8
```
Methods:
```
public static bool TryFindManager(Frame frame, out EscapeRoomGameModeManager* escapeRoomManager)   // RVA 0x21A11F0
public void OnPlayingUpdate(Frame frame, EscapeRoomGameModeManager* escapeRoomManager)   // RVA 0x21A0A70
protected bool IsCountdownOver(Frame frame, EscapeRoomGameModeManager* escapeRoomGameModeManager)   // RVA 0x21994F0
public void OnCourseInfoSetup(Frame frame, string currentCourseID, bool hasDialogue, int difficulty)   // RVA 0x21A06F0
public void CompleteCourse(Frame frame, EscapeRoomGameModeManager* escapeRoomManager)   // RVA 0x21A0190
protected void RestartCourse(Frame frame, EscapeRoomGameModeManager* escapeRoomManager)   // RVA 0x21A1110
public void OnCampaignDialogueFinished(Frame frame)   // RVA 0x21A0450
public void OnCampaignForceWin(Frame frame)   // RVA 0x21A04B0
public void .ctor()   // RVA 0x21A13D0
```

### Quantum.EscapeRoomCourse  (bases: ; TypeDefIndex 10388)
Fields:
```
public string ID;  // 0x0
public HashString LevelToLoad;  // 0x8
public string LayoutToLoad;  // 0x18
public bool HasTimer;  // 0x20
public FP[] TimerSeconds;  // 0x28
public OnTimerCompletion OnTimerCompletion;  // 0x30
```

### Quantum.CampaignHazardsRaceGameMode  (bases: CampaignRaceGameMode; TypeDefIndex 10390)
Fields:
```
public AssetRefGameEntityData ItemSpawner;  // 0xC0
public FP ItemSpawnCooldown;  // 0xC8
public FP StartHazardsTimer;  // 0xD0
public FP HazardsIncomingTimer;  // 0xD8
public FP AmountOfHazardsToSpawn;  // 0xE0
public List<HashString> HazardsList;  // 0xE8
private bool HazardsWarningActive;  // 0xF0
private bool SpawnDirectionSet;  // 0xF1
```
Methods:
```
public void ResetRoundTimers(Frame frame)   // RVA 0x219BC90
public bool IsInside(FPVector2 pt, FPVector2 TopLeft, FPVector2 BottomRight)   // RVA 0x219AFE0
public static bool TryFindManager(Frame frame, out HazardsRaceGameModeManager* hazardsRaceManager)   // RVA 0x219C0C0
public static bool TryFindGameModeItemAutoTrigger(Frame frame, out GameModeItemAutoTrigger* autoTrigger)   // RVA 0x219BF70
public void .ctor()   // RVA 0x219C290
```

### Quantum.HazardsRaceGameMode  (bases: RaceGameMode; TypeDefIndex 10391)
Fields:
```
public AssetRefGameEntityData ItemSpawner;  // 0xA0
public FP ItemSpawnCooldown;  // 0xA8
public FP StartHazardsTimer;  // 0xB0
public FP HazardsIncomingTimer;  // 0xB8
public FP AmountOfHazardsToSpawn;  // 0xC0
public List<HashString> HazardsList;  // 0xC8
private bool HazardsWarningActive;  // 0xD0
private bool SpawnDirectionSet;  // 0xD1
```
Methods:
```
public void ResetRoundTimers(Frame frame)   // RVA 0x21A1CA0
public bool IsInside(FPVector2 pt, FPVector2 TopLeft, FPVector2 BottomRight)   // RVA 0x219AFE0
public static bool TryFindManager(Frame frame, out HazardsRaceGameModeManager* hazardsRaceManager)   // RVA 0x21A2160
public static bool TryFindGameModeItemAutoTrigger(Frame frame, out GameModeItemAutoTrigger* autoTrigger)   // RVA 0x21A2010
public void .ctor()   // RVA 0x21A2330
```

### Quantum.CampaignLapsRaceGameMode  (bases: CampaignRaceGameMode; TypeDefIndex 10392)
Fields:
```
public int LapsToFinish;  // 0xC0
```
Methods:
```
public void .ctor()   // RVA 0x219C8D0
```

### Quantum.LapsRaceGameMode  (bases: RaceGameMode; TypeDefIndex 10393)
Fields:
```
public int LapsToFinish;  // 0xA0
```
Methods:
```
public void .ctor()   // RVA 0x21A5450
```

### Quantum.MechanicTutorialGameMode  (bases: SpeedRunnersBaseGameMode; TypeDefIndex 10394)
Fields:
```
public static HashString FreezeAttackData;  // 0x0
public static HashString LethalObstacleAttackData;  // 0x10
public static HashString GoldenHookAttackData;  // 0x20
public HashString LevelToLoad;  // 0x68
public MechanicTutorialSection[] Sections;  // 0x78
public GameSpeedModifier InitialMessageSpeedModifier;  // 0x80
public GameSpeedModifier EndSlowDownSpeedModifier;  // 0xA0
```
Methods:
```
public static bool TryFindManager(Frame frame, out MechanicTutorialGameModeManager* tutorialManager)   // RVA 0x21A6120
public void OnSectionInfoSetup(Frame frame, int currentSectionIndex)   // RVA 0x21A5AC0
public void OnDialogueFinished(Frame frame)   // RVA 0x21A5980
public void ClearGoal(Frame frame, int goalID)   // RVA 0x21A5470
protected void StartMatch(Frame frame)   // RVA 0x21A6080
protected void CompleteSection(Frame frame, MechanicTutorialGameModeManager* tutorialManager)   // RVA 0x21A56B0
protected void RestartSection(Frame frame, MechanicTutorialGameModeManager* tutorialManager)   // RVA 0x21A6020
public void .ctor()   // RVA 0x21A6420
private static void .cctor()   // RVA 0x21A62F0
```

### Quantum.MechanicTutorialSection  (bases: ; TypeDefIndex 10395)
Fields:
```
public string ID;  // 0x0
public string LayoutToLoad;  // 0x8
public MechanicTutorialGoal[] GoalIDs;  // 0x10
public HurtEvents HurtEvents;  // 0x18
public bool HasTimer;  // 0x1B
public FP TimerSeconds;  // 0x20
public ActionOnTimerCompletion ActionOnTimerCompletion;  // 0x28
public string InitialMessage;  // 0x30
```

### Quantum.MechanicTutorialGoal  (bases: ; TypeDefIndex 10396)
Fields:
```
public HashString ID;  // 0x0
public string LocalizationID;  // 0x10
public int RequiredNotificationsToComplete;  // 0x18
```

### Quantum.HurtEvents  (bases: ; TypeDefIndex 10397)
Fields:
```
public bool RestartOnFreeze;  // 0x0
public bool RestartOnLethalObstacleHit;  // 0x1
public bool RestartOnGoldenHookHit;  // 0x2
```

### Quantum.BossFightGameMode  (bases: SpeedRunnersBaseGameMode; TypeDefIndex 10399)
Fields:
```
public FP WaitTimeBetweenRounds;  // 0x68
public FP WaitTimeToReturnToMainMenu;  // 0x70
public FP WaitTimeToShowBanners;  // 0x78
public FP PlayerStamina;  // 0x80
public FP[] BossStamina;  // 0x88
public FP BlastzonePercentage;  // 0x90
public FP BlastzoneDamage;  // 0x98
public FP IntagibilityFrames;  // 0xA0
public bool RoundLost;  // 0xA8
public int PlayerIntangibilityFramesOnHurt;  // 0xAC
public string BossDifficultyVariableID;  // 0xB0
public GameSpeedModifier SlowdownTimeModifier;  // 0xB8
public GameSpeedModifier DialogueSpeedModifier;  // 0xD8
```
Methods:
```
public static bool TryFindBossFightModeManager(Frame frame, out BossFightGameModeManager* bossFightGameModeManager)   // RVA 0x219ACD0
protected bool IsCountdownOver(Frame frame, BossFightGameModeManager* bossFightGameModeManager)   // RVA 0x21994F0
public void OnCampaignForceWin(Frame frame)   // RVA 0x2199A20
public void .ctor()   // RVA 0x219AE20
```

### Quantum.RaceGameMode  (bases: SpeedRunnersBaseGameMode; TypeDefIndex 10400)
Fields:
```
public FP WaitTimeBetweenRounds;  // 0x68
public FP WaitTimeToReturnToMainMenu;  // 0x70
public FP WaitTimeToShowBanners;  // 0x78
public GameSpeedModifier SlowdownTimeModifier;  // 0x80
```
Methods:
```
public static bool TryFindRaceModeManager(Frame frame, out RaceGameModeManager* raceGameModeManager)   // RVA 0x21A9A10
protected bool IsCountdownOver(Frame frame, RaceGameModeManager* raceGameModeManager)   // RVA 0x21A68D0
public void KnockOutLastPlayer(Frame frame)   // RVA 0x21A8630
public void .ctor()   // RVA 0x21A9B60
```

### Quantum.RaceTutorialGameMode  (bases: RaceGameMode; TypeDefIndex 10401)
Fields:
```
public string InitialMessage;  // 0xA0
public string SuddenDeathMessageID;  // 0xA8
public GameSpeedModifier DialogueSpeedModifier;  // 0xB0
```
Methods:
```
public static bool TryFindManager(Frame frame, out RaceTutorialGameModeManager* tutorialManager)   // RVA 0x21AA280
public void OnDialogueFinished(Frame frame)   // RVA 0x21A9D90
internal void OnInfoSetup(Frame frame, bool isInitialSection)   // RVA 0x21A9E50
public void .ctor()   // RVA 0x21AA440
```

### Quantum.SpeedRunnersBaseGameMode  (bases: BaseGameMode; TypeDefIndex 10402)
Fields:
```
public bool BlastzoneActive;  // 0x20
public bool CheckpointsActive;  // 0x21
public bool UseInitialTimer;  // 0x22
public int InitialTimerFrames;  // 0x24
public FP TotalRespawnLength;  // 0x28
public FP MinRespawnSpacing;  // 0x30
public HashString EntranceState;  // 0x38
public HashString IdleState;  // 0x48
public HashString RespawnState;  // 0x58
```
Methods:
```
public static bool TryFindInitialWaitTimer(Frame frame, out InitialWaitTimer* initialWaitTimer)   // RVA 0x21ABD60
public void StartInitialTimer(Frame frame)   // RVA 0x21ABD10
public bool IsInitialCountdownFinished(Frame frame)   // RVA 0x21AA7E0
public void UpdateInitialCountdown(Frame frame, out bool justFinished)   // RVA 0x21AC410
public void CreateBlastzone(Frame frame)   // RVA 0x21AA5B0
public void OnCharacterHurt(Frame frame, EntityRef characterEntity, HashString attackDataID)   // RVA 0x21AB250
protected void StartCharactersEntrance(Frame frame)   // RVA 0x21ABC40
protected void EndCharactersEntrance(Frame frame)   // RVA 0x21AA6C0
public void UpdateBlastzone(Frame frame)   // RVA 0x21AC3C0
protected FP CalculateRespawnSpacing(Frame frame)   // RVA 0x21AA520
public void .ctor()   // RVA 0x21AC4B0
```

### Quantum.SpeedRunnersTestingGameMode  (bases: SpeedRunnersBaseGameMode; TypeDefIndex 10403)
Methods:
```
public void .ctor()   // RVA 0x21AC610
```

### Quantum.PlatformFightGameMode  (bases: SpeedRunnersBaseGameMode; TypeDefIndex 10404)
Fields:
```
public FP WaitTimeBetweenRounds;  // 0x68
public FP WaitTimeToReturnToMainMenu;  // 0x70
public FP WaitTimeToShowBanners;  // 0x78
public GameSpeedModifier SlowdownTimeModifier;  // 0x80
```
Methods:
```
public static bool TryFindGameModeManager(Frame frame, out PlatformFightGameModeManager* speedBrosGameModeManager)   // RVA 0x21A8290
protected void ResetRound(Frame frame)   // RVA 0x21A7E00
private bool IsCountdownOver(Frame frame, PlatformFightGameModeManager* gameModeManager)   // RVA 0x21A68D0
private int GetNewLoserRank(Frame frame)   // RVA 0x21A6570
public void .ctor()   // RVA 0x21A83E0
```

### Quantum.TournamentGameMode  (bases: RaceGameMode; TypeDefIndex 10405)
Fields:
```
public AssetRefGameEntityData ItemSpawner;  // 0xA0
public FP ItemSpawnCooldown;  // 0xA8
public FP StartRocketsTimer;  // 0xB0
public FP RocketsIncomingTimer;  // 0xB8
```
Methods:
```
public static bool TryFindGameModeItemAutoTrigger(Frame frame, out GameModeItemAutoTrigger* autoTrigger)   // RVA 0x21AD070
public static bool TryFindManager(Frame frame, out TournamentGameModeManager* tournamentManager)   // RVA 0x21AD1C0
public void .ctor()   // RVA 0x21A2330
```

### Quantum.TimedRaceGameMode  (bases: RaceGameMode; TypeDefIndex 10406)
Methods:
```
private bool IsRaceCountdownOver(Frame frame, RaceGameModeManager* raceGameModeManager)   // RVA 0x21AC620
public void .ctor()   // RVA 0x21A2330
```

### Quantum.TrainingGameMode  (bases: RaceGameMode; TypeDefIndex 10407)
Methods:
```
public static bool TryFindTrainingModeManager(Frame frame, out TrainingGameModeManager* trainingManager)   // RVA 0x21AD7C0
public void .ctor()   // RVA 0x21A2330
```

### Quantum.AnimationPlayableInfo  (bases: ; TypeDefIndex 10411)
Fields:
```
public AnimationChannel TargetChannel;  // 0x0
public HashString Animation;  // 0x8
public EntityVariable Speed;  // 0x18
public EntityVariable Weight;  // 0x20
public bool Loop;  // 0x28
public int StartFrame;  // 0x2C
public int EndFrame;  // 0x30
public AnimationSpeedElement[] AnimationSpeedData;  // 0x38
public ExecuteGroupEvent AnimationFinishedGroupEvent;  // 0x40
```

### Quantum.SubAnimationPlayableInfo  (bases: ; TypeDefIndex 10413)
Fields:
```
public HashString SubanimatorName;  // 0x0
public HashString Animation;  // 0x10
public EntityVariable Speed;  // 0x20
public EntityVariable Weight;  // 0x28
public bool Loop;  // 0x30
public int StartFrame;  // 0x34
public int EndFrame;  // 0x38
public ExecuteGroupEvent AnimationFinishedGroupEvent;  // 0x40
```

### Quantum.AttackDataValues  (bases: ; TypeDefIndex 10414)
Fields:
```
public AttackDataValue Damage;  // 0x0
public AttackDataValue BlockDamage;  // 0x10
public AttackDataValue BaseKnockback;  // 0x20
public AttackDataValue BlockPush;  // 0x30
public AttackDataValue BlockStun;  // 0x40
public AttackDataValue DIMultiplier;  // 0x50
public AttackDataValue FixedKnockback;  // 0x60
public AttackDataValue HitStunMinimum;  // 0x70
public AttackDataValue HitStunMultiplier;  // 0x80
public AttackDataValue HitLagBaseOnBlock;  // 0x90
public AttackDataValue HitLagBaseOnHit;  // 0xA0
public AttackDataValue InstigatorAdvantageOnBlock;  // 0xB0
public AttackDataValue InstigatorAdvantageOnHit;  // 0xC0
public AttackDataValue KnockbackGain;  // 0xD0
public AttackDataValue SDIMultiplier;  // 0xE0
```
Methods:
```
public HitInfo GenerateHitInfo(Frame frame, AttackData attackData, CombatSettingsData combatSettingsData, HitResult hitResult)   // RVA 0x2197670
internal FP CalculateAngle(Frame frame, AttackData attackData, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FPVector2 hitBoxPosition, int facingDirection)   // RVA 0x21970C0
private FPVector2 CalculateLaunchDirection(Frame frame, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FPVector2 hitBoxPosition, SpecialAnglePreset specialAngle, FP angle, FP knockback, int facingDirection, bool reversible)   // RVA 0x2197250
```

### Quantum.AttackDataValue  (bases: ; TypeDefIndex 10415)
Fields:
```
public AttackDataOperation Operation;  // 0x0
public FP Value;  // 0x8
```
Methods:
```
public FP Combine(FP originalValue)   // RVA 0x21B0870
```

### Quantum.AttackDataValuesResult  (bases: ; TypeDefIndex 10416)
Fields:
```
public FP Damage;  // 0x0
public FP BlockDamage;  // 0x8
public FP BaseKnockback;  // 0x10
public FP BlockPush;  // 0x18
public FP BlockStun;  // 0x20
public FP DI_Multiplier;  // 0x28
public FP FixedKnockback;  // 0x30
public FP HitStunMinimum;  // 0x38
public FP HitStunMultiplier;  // 0x40
public FP HitLagBaseOnBlock;  // 0x48
public FP HitLagBaseOnHit;  // 0x50
public FP InstigatorAdvantageOnBlock;  // 0x58
public FP InstigatorAdvantageOnHit;  // 0x60
public FP KnockbackGain;  // 0x68
public FP SDI_Multiplier;  // 0x70
```
Methods:
```
public static AttackDataValuesResult FromAttackDataValues(AttackDataValues values)   // RVA 0x21B0EB0
public void Combine(AttackDataValues values)   // RVA 0x21B0C20
public void CombineWithLerp(AttackDataValues values, FP lerpValue)   // RVA 0x21B0890
```

### Quantum.CombatEntity  (bases: ; TypeDefIndex 10418)
Fields:
```
public CombatData CombatData;  // 0x0
public EntityRef Entity;  // 0x8
public GameEntity* GameEntity;  // 0x10
public Combat* Combat;  // 0x18
public Grab* Grab;  // 0x20
public PhysicsBody* PhysicsBody;  // 0x28
public Transform2D* Transform;  // 0x30
```
Methods:
```
public static CombatEntity Create(Frame frame, EntityRef entity)   // RVA 0x21B25F0
```

### Quantum.GrabResult  (bases: ; TypeDefIndex 10419)
Fields:
```
public CombatEntity Instigator;  // 0x0
public CombatEntity Victim;  // 0x38
public FP Distance;  // 0x70
public bool IsHitGrab;  // 0x78
```
Methods:
```
public void .ctor(CombatEntity instigator, CombatEntity victim, FP distance, bool isHitGrab)   // RVA 0x21B7890
```

### Quantum.HitResult  (bases: ; TypeDefIndex 10420)
Fields:
```
public GameEntityType InstigatorType;  // 0x0
public CombatEntity Instigator;  // 0x8
public CombatEntity Victim;  // 0x40
public HitBox* HitBox;  // 0x78
public HurtBox* HurtBox;  // 0x80
public int AttackDataID;  // 0x88
public bool HittingOwner;  // 0x8C
public bool HitFromOwner;  // 0x8D
public bool SameTeam;  // 0x8E
public int FacingDirection;  // 0x90
public FP Distance;  // 0x98
public HitInfo HitInfo;  // 0xA0
```
Methods:
```
public void .ctor(GameEntityType instigatorType, CombatEntity instigator, CombatEntity victim, HitBox* hitBox, HurtBox* hurtBox, int attackDataID, bool hittingOwner, bool hitFromOwner, bool sameTeam, int facingDirection, FP distance)   // RVA 0x21B8670
public void GenerateHitInfo(Frame frame, CombatSettingsData combatSettingsData)   // RVA 0x21B8360
```

### Quantum.CombatCapsulePositionKeyFrame  (bases: ; TypeDefIndex 10421)
Fields:
```
public int Frame;  // 0x0
public FPVector2 Position;  // 0x8
```

### Quantum.CombatCapsuleOffsetKeyFrame  (bases: ; TypeDefIndex 10422)
Fields:
```
public int Frame;  // 0x0
public FPVector3 LocalOffset;  // 0x8
public FPVector2 GlobalOffset;  // 0x20
```

### Quantum.HitBoxData  (bases: ; TypeDefIndex 10424)
Fields:
```
public HashString ID;  // 0x0
public int StartFrame;  // 0x10
public int EndFrame;  // 0x14
public FP Radius;  // 0x18
public HitBoxType HitBoxType;  // 0x20
public HitBoxPriority Priority;  // 0x24
public CombatCapsulePointSetupType HitBoxPositionType;  // 0x28
public HashString JointID;  // 0x30
public HashString[] AttackDatas;  // 0x40
public CombatCapsulePositionKeyFrame[] PointPositions;  // 0x48
public CombatCapsuleOffsetKeyFrame[] PointOffsets;  // 0x50
```
Methods:
```
public bool IsActive(int currentFrame)   // RVA 0x21B8190
public FPVector2 GetPositionForFrame(int currentFrame)   // RVA 0x21B8010
public void OffsetForFrame(int currentFrame, out FPVector3 localOffset, out FPVector2 globalOffset)   // RVA 0x21B81B0
```

### Quantum.HurtBoxData  (bases: ; TypeDefIndex 10425)
Fields:
```
public HashString ID;  // 0x0
public FP Radius;  // 0x10
public HashString JointAIdentifier;  // 0x18
public HashString JointBIdentifier;  // 0x28
public CombatCapsulePositionKeyFrame[] PointAPositions;  // 0x38
public CombatCapsulePositionKeyFrame[] PointBPositions;  // 0x40
public CombatCapsuleOffsetKeyFrame[] PointAOffsets;  // 0x48
public CombatCapsuleOffsetKeyFrame[] PointBOffsets;  // 0x50
```
Methods:
```
public FPVector2 GetAPositionForFrame(int currentFrame)   // RVA 0x21B8790
public FPVector2 GetBPositionForFrame(int currentFrame)   // RVA 0x21B87F0
private FPVector2 PositionForFrame(int currentFrame, ref CombatCapsulePositionKeyFrame[] positions)   // RVA 0x21B8910
public void GetAOffsetForFrame(int currentFrame, out FPVector3 localOffset, out FPVector2 globalOffset)   // RVA 0x21B8760
public void GetBOffsetForFrame(int currentFrame, out FPVector3 localOffset, out FPVector2 globalOffset)   // RVA 0x21B87C0
public void OffsetForFrame(int currentFrame, ref CombatCapsuleOffsetKeyFrame[] offsets, out FPVector3 localOffset, out FPVector2 globalOffset)   // RVA 0x21B8820
```

### Quantum.CommandChangeCharacterState  (bases: BaseCommand; TypeDefIndex 10427)
Fields:
```
public int StateHash;  // 0x28
public EntityRef EntityRef;  // 0x30
public bool InmediateChange;  // 0x38
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandDespawnEntity  (bases: BaseCommand; TypeDefIndex 10428)
Fields:
```
public EntityRef EntityRef;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandSpawnGameEntity  (bases: BaseCommand; TypeDefIndex 10429)
Fields:
```
public AssetRefGameEntityData GameEntityDataRef;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandAttackEntity  (bases: BaseCommand; TypeDefIndex 10430)
Fields:
```
public int AttackHash;  // 0x28
public EntityRef TargetRef;  // 0x30
public EntityRef InstigatorRef;  // 0x38
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandResetEntityStatus  (bases: BaseCommand; TypeDefIndex 10431)
Fields:
```
public EntityRef EntityRef;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandApplyPosition  (bases: BaseCommand; TypeDefIndex 10432)
Fields:
```
public EntityRef EntityRef;  // 0x28
public FPVector2 Position;  // 0x30
public FPVector2 Velocity;  // 0x40
public int Direction;  // 0x50
public bool DeactivatePhysics;  // 0x54
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandUpdateCameraPosition  (bases: BaseCommand; TypeDefIndex 10433)
Fields:
```
public EntityRef EntityRef;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandForceReloadStateMachine  (bases: BaseCommand; TypeDefIndex 10434)
Fields:
```
public AssetRefStateMachineData StateMachineData;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandAddGameSpeedModifier  (bases: BaseCommand; TypeDefIndex 10435)
Fields:
```
public GameSpeedModifier GameSpeedModifier;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandRemoveGameSpeedModifier  (bases: BaseCommand; TypeDefIndex 10436)
Fields:
```
public int ModifierID;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandModifyPlayerDamage  (bases: BaseCommand; TypeDefIndex 10437)
Fields:
```
public EntityRef Entity;  // 0x28
public FP DamageAmountToChange;  // 0x30
public MathOperationMethod Operation;  // 0x38
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandStartFrameByFrame  (bases: BaseCommand; TypeDefIndex 10438)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandStopFrameByFrame  (bases: BaseCommand; TypeDefIndex 10439)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandAdvanceFrameByFrame  (bases: BaseCommand; TypeDefIndex 10440)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandNotifyCharacterLoaded  (bases: BaseCommand; TypeDefIndex 10441)
Fields:
```
public EntityRef CharacterEntity;  // 0x28
public int CharacterID;  // 0x30
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandFinishCharacterLoading  (bases: BaseCommand; TypeDefIndex 10442)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandTogglePause  (bases: BaseCommand; TypeDefIndex 10443)
Fields:
```
public bool PauseActive;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandStopMatch  (bases: BaseCommand; TypeDefIndex 10444)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandDestroyEntity  (bases: BaseCommand; TypeDefIndex 10445)
Fields:
```
public EntityRef Entity;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.CommandSpawnPlayerCharacter  (bases: BaseCommand; TypeDefIndex 10446)
Fields:
```
public PlayerRef PlayerRef;  // 0x28
public FPVector2 SpawnPosition;  // 0x30
public int FacingDirection;  // 0x40
public bool StartDisabled;  // 0x44
public int PartnerCharacterIndex;  // 0x48
public CharacterSpawnData CharacterSpawnData;  // 0x50
```
Methods:
```
public void .ctor()   // RVA 0x21B38A0
```

### Quantum.CharacterSpawnData  (bases: ; TypeDefIndex 10447)
Fields:
```
public HashString CharacterID;  // 0x10
public int Costume;  // 0x20
public int SpawnOrder;  // 0x24
public int TeamIndex;  // 0x28
public bool RandomSelection;  // 0x2C
public string Nickname;  // 0x30
public int Difficulty;  // 0x38
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.HashString  (bases: ; TypeDefIndex 10448)
Fields:
```
public string Value;  // 0x0
public int Hash;  // 0x8
```
Methods:
```
public void .ctor(string value)   // RVA 0x21B7F10
public void GenerateHash()   // RVA 0x21B79B0
public static bool op_Equality(HashString hashString1, HashString hashString2)   // RVA 0x21B7F40
public static bool op_Equality(int intValue, HashString hashString)   // RVA 0x21B7F80
public static bool op_Equality(HashString hashString, int intValue)   // RVA 0x21B7F90
public static bool op_Equality(string stringtValue, HashString hashString)   // RVA 0x21B7F50
public static bool op_Equality(HashString hashString, string stringtValue)   // RVA 0x21B7F60
public static bool op_Inequality(HashString hashString1, HashString hashString2)   // RVA 0x21B8000
public static bool op_Inequality(int intValue, HashString hashString)   // RVA 0x21B7FF0
public static bool op_Inequality(HashString hashString, int intValue)   // RVA 0x21B7FA0
public static bool op_Inequality(string stringtValue, HashString hashString)   // RVA 0x21B7FB0
public static bool op_Inequality(HashString hashString, string stringtValue)   // RVA 0x21B7FD0
public bool IsEmpty()   // RVA 0x1349850
public static HashString GetHashStringFromList(List<HashString> list, int hash)   // RVA 0x21B7AD0
public static string GetValueFromList(List<HashString> list, int hash)   // RVA 0x21B7CB0
public static int StringToHash(string key, uint seed = 0)   // RVA 0x21B7E60
```

### Quantum.AxisSettings  (bases: ; TypeDefIndex 10449)
Fields:
```
public int DirectionFrames;  // 0x0
public FP AxisDeadzone;  // 0x8
public FP AxisDetectionThreshold;  // 0x10
public FP UpMinAngle;  // 0x18
public FP UpMaxAngle;  // 0x20
public FP ForwardMinAngle;  // 0x28
public FP ForwardMaxAngle;  // 0x30
public FP DownMinAngle;  // 0x38
public FP DownMaxAngle;  // 0x40
```
Methods:
```
public void Initialize(GameplayInputSettingsData gameplayInputSettingsData, bool grounded)   // RVA 0x21B1690
```

### Quantum.InputBufferEventChecker  (bases: ; TypeDefIndex 10453)
Fields:
```
public int Frames;  // 0x10
public InputBufferEventChecker.InputActionTypes ActionType;  // 0x14
public InputBufferEventChecker.ButtonState State;  // 0x18
public InputFlag Button;  // 0x1C
public InputDirection Direction;  // 0x20
public bool UseFacingDirection;  // 0x24
public InputBufferEventChecker.DirectionOverride DirectionOverrides;  // 0x28
public FP Deadzone;  // 0x30
public FP DetectionThreshold;  // 0x38
public FP MinAngle;  // 0x40
public FP MaxAngle;  // 0x48
public FP OutputValue;  // 0x50
```
Methods:
```
public bool Check(GameplayInputSettingsData gameplayInputSettingsData, InputBuffer* inputBuffer, out int eventIndex, int startFrame = -1, bool grounded = True, bool invertX = False, bool spendAction = True)   // RVA 0x21B9470
public void .ctor()   // RVA 0x21B97E0
```

### Quantum.StatusEffectType  (bases: ; TypeDefIndex 10455)
Fields:
```
public static HashString Undefined;  // 0x0
```
Methods:
```
public static List<HashString> GetAllStatusEffects()   // RVA 0x21C1DA0
private static void .cctor()   // RVA 0x21C1EC0
```

### Quantum.CollisionLayer  (bases: ; TypeDefIndex 10457)
Fields:
```
public int LayerIndex;  // 0x0
```

### Quantum.LinecastHitInfo  (bases: ; TypeDefIndex 10458)
Fields:
```
public Nullable<Hit> Hit;  // 0x0
public bool Intersects;  // 0x48
public FP DistanceToIntersect;  // 0x50
public bool ForceStandOnThinPlatform;  // 0x58
public int HitLayer;  // 0x5C
```

### Quantum.PhysicsBodyEntity  (bases: ; TypeDefIndex 10459)
Fields:
```
public EntityRef Entity;  // 0x0
public GameEntity* GameEntity;  // 0x8
public PhysicsBody* PhysicsBody;  // 0x10
public Transform2D* Transform;  // 0x18
```
Methods:
```
public void .ctor(EntityRef entity, GameEntity* gameEntity, PhysicsBody* physicsBody, Transform2D* transform)   // RVA 0x900DF0
```

### Quantum.PolygonVertex  (bases: ; TypeDefIndex 10460)
Fields:
```
public FPVector2 position;  // 0x0
public FP angle;  // 0x10
```

### Quantum.EdgeGrabRequest  (bases: ; TypeDefIndex 10461)
Fields:
```
public EntityRef GrabberEntity;  // 0x0
public EdgeGrab* Grabber;  // 0x8
public EntityRef EdgeEntity;  // 0x10
public StageEdge* Edge;  // 0x18
public FP Distance;  // 0x20
```
Methods:
```
public void .ctor(EntityRef grabberEntity, EdgeGrab* grabber, EntityRef edgeEntity, StageEdge* edge, FP distance)   // RVA 0x21B5370
```

### Quantum.ECBOffset  (bases: ; TypeDefIndex 10462)
Fields:
```
public ECBOffsetOperation Operation;  // 0x0
public EntityVariable Value;  // 0x8
```

### Quantum.VFXPlayAttributes  (bases: ; TypeDefIndex 10463)
Fields:
```
public bool KeepFinalPosition;  // 0x0
public bool OverridePosition;  // 0x1
public VFXVectorSource PositionSource;  // 0x4
public bool IsGlobalPosition;  // 0x8
public bool AddEntityTransformToPosition;  // 0x9
public FPVector3 Position;  // 0x10
public EntityVariable PositionX;  // 0x28
public EntityVariable PositionY;  // 0x30
public EntityVariable PositionZ;  // 0x38
public bool OverrideRotation;  // 0x40
public VFXVectorSource RotationSource;  // 0x44
public FPVector3 Rotation;  // 0x48
public EntityVariable RotationX;  // 0x60
public EntityVariable RotationY;  // 0x68
public EntityVariable RotationZ;  // 0x70
public bool UseGroundNormalRotation;  // 0x78
public bool LookAtWorldCenter;  // 0x79
public bool LookAtCamera;  // 0x7A
public bool OverrideScale;  // 0x7B
public FPVector3 Scale;  // 0x80
```

### Quantum.VFXStopAttributes  (bases: ; TypeDefIndex 10465)
Fields:
```
public bool StopParticles;  // 0x0
public bool DeactivateGameObject;  // 0x1
public bool KeepFinalPosition;  // 0x2
```

### Quantum.CommandChangeEnergyBarAmount  (bases: BaseCommand; TypeDefIndex 10466)
Fields:
```
public EntityRef Entity;  // 0x28
public FP EnergyAmountToChange;  // 0x30
public MathOperationMethod Operation;  // 0x38
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.GameSpeedModifier  (bases: ; TypeDefIndex 10467)
Fields:
```
public HashString ID;  // 0x0
public FP Multiplier;  // 0x10
public bool AlterSimulation;  // 0x18
public bool AlterEngine;  // 0x19
```
Methods:
```
public void .ctor(HashString id, FP multiplier, bool alterSimulation, bool alterEngine)   // RVA 0x21B7360
public RuntimeGameSpeedModifier AsRuntimeModifier()   // RVA 0x21B72F0
```

### Quantum.CachedEntityData  (bases: ; TypeDefIndex 10468)
Fields:
```
public EntityRef Entity;  // 0x0
public GameEntity* GameEntity;  // 0x8
public EntityModifierTarget* EntityModifierTarget;  // 0x10
public StellarCharacter* Character;  // 0x18
public Transform2D* Transform;  // 0x20
public InputBuffer* InputBuffer;  // 0x28
public StateMachine* StateMachine;  // 0x30
public CustomAnimator* CustomAnimator;  // 0x38
public PhysicsBody* PhysicsBody;  // 0x40
public KinematicBody* KinematicBody;  // 0x48
public Combat* Combat;  // 0x50
public Grab* Grab;  // 0x58
public bool HasCachedHashSets;  // 0x60
public QHashSet<AssetGuid> ExecutedBehaviours;  // 0x68
public QHashSet<AssetGuid> FinishedBehaviours;  // 0x78
```
Methods:
```
public static CachedEntityData Create(Frame frame, EntityRef entity, bool generateBehaviourHashSets = False)   // RVA 0x21B1740
```

### Quantum.AnimationJointsData  (bases: ; TypeDefIndex 10470)
Fields:
```
public int ClipIndex;  // 0x0
public JointKeyFrame[] KeyFrames;  // 0x8
public FPVector2[] KinematicMotion;  // 0x10
```
Methods:
```
public bool TryGetKeyFrame(int frame, out JointKeyFrame keyFrame)   // RVA 0x21AFF20
public bool TryGetKinematicMotion(int frame, out FPVector2 kinematicMotionDiff)   // RVA 0x21AFFB0
```

### Quantum.JointKeyFrame  (bases: ; TypeDefIndex 10471)
Fields:
```
public JointData[] JointsData;  // 0x0
```
Methods:
```
public bool TryGetJointFrameTransform(int jointIDHash, out FPVector3 position, out FPVector3 rotation)   // RVA 0x21B9820
```

### Quantum.JointData  (bases: ; TypeDefIndex 10472)
Fields:
```
public int ID;  // 0x0
public FPVector3 Position;  // 0x8
public FPVector3 Rotation;  // 0x20
```
Methods:
```
public void GetTransform(out FPVector3 position, out FPVector3 rotation)   // RVA 0x21B97F0
```

### Quantum.VisibilityFrame  (bases: ; TypeDefIndex 10473)
Fields:
```
public int Frame;  // 0x0
public BakedObjectVisibilityData[] ObjectsVisibilityData;  // 0x8
```

### Quantum.BlendShapeFrame  (bases: ; TypeDefIndex 10474)
Fields:
```
public int Frame;  // 0x0
public BakedBlendShapesData[] ObjectsBlendShapesData;  // 0x8
```

### Quantum.BakedObjectVisibilityData  (bases: ; TypeDefIndex 10475)
Fields:
```
public int MeshHash;  // 0x0
public bool Value;  // 0x4
```

### Quantum.BakedBlendShapesData  (bases: ; TypeDefIndex 10476)
Fields:
```
public int MeshHash;  // 0x0
public int BlendShapesHash;  // 0x4
public float Value;  // 0x8
```

### Quantum.SubAnimatorClipsInfo  (bases: ; TypeDefIndex 10477)
Fields:
```
public HashString SubAnimatorId;  // 0x0
public AssetRefAnimationClipData[] ClipsDataRefs;  // 0x10
```

### Quantum.SimplePlatformCameraManagerData  (bases: CameraManagerData; TypeDefIndex 10478)
Methods:
```
public void .ctor()   // RVA 0x217BAB0
```

### Quantum.AttackData  (bases: ; TypeDefIndex 10479)
Fields:
```
public HashString ID;  // 0x10
public AttackDataValues AttackDataValues;  // 0x20
public AttackVictimDirection VictimDirection;  // 0x110
public HitBoxSpecialBehaviour HitBoxHorizontalBehaviour;  // 0x114
public SpecialAnglePreset SpecialAngle;  // 0x118
public FP Angle;  // 0x120
public FP InstigatorPushBack;  // 0x128
public bool Flinchless;  // 0x130
public bool Unblockable;  // 0x131
public bool Reversible;  // 0x132
public bool CannotRebound;  // 0x133
public bool Trascendence;  // 0x134
public bool Trample;  // 0x135
public bool UntechableIfGrounded;  // 0x136
public bool OnlyHitGroundedTargets;  // 0x137
public bool OnlyHitAirborneTargets;  // 0x138
public bool OnlyHitOwner;  // 0x139
public bool OnlyHitOwned;  // 0x13A
public HashString VFXID;  // 0x140
public VFXPlayAttributes PlayAttributes;  // 0x150
public HashString SFXEventName;  // 0x1E8
public bool UpdateSoundPosition;  // 0x1F8
public bool HasConditions;  // 0x1F9
public AdvancedConditionLogicalOperator LogicalOperator;  // 0x1FC
public AdvancedCondition[] Conditions;  // 0x200
```
Methods:
```
public HitInfo GenerateHitInfo(Frame frame, CombatSettingsData combatSettingsData, HitResult hitResult)   // RVA 0x21B13F0
internal FP GetHitLagFrames(CombatSettingsData combatSettingsData)   // RVA 0x21B15E0
internal FP GetAngle(Frame frame, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FPVector2 hitBoxPosition, int facingDirection)   // RVA 0x21B1580
public void .ctor()   // RVA 0x21B1630
```

### Quantum.HurtBoxPreset  (bases: ; TypeDefIndex 10481)
Fields:
```
public HashString ID;  // 0x0
public HurtBoxData[] HurtBoxes;  // 0x10
```

### Quantum.DIForKnockback  (bases: ; TypeDefIndex 10482)
Fields:
```
public FP Angle;  // 0x0
public FP MaxKnockback;  // 0x8
```

### Quantum.AttackMultiplier  (bases: ; TypeDefIndex 10483)
Fields:
```
public HashString ID;  // 0x0
public AttackDataValues AttackValues;  // 0x10
```

### Quantum.MoveLimitData  (bases: ; TypeDefIndex 10484)
Fields:
```
public HashString MoveName;  // 0x0
public MoveLimit LimitData;  // 0x10
```

### Quantum.TestingGameMode  (bases: BaseGameMode; TypeDefIndex 10485)
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.EntityGrabOffsetInfo  (bases: ; TypeDefIndex 10487)
Fields:
```
public HashString GrabberID;  // 0x0
public FPVector3 GrabPositionOffset;  // 0x10
public FPVector3 GrabJointPositionOffset;  // 0x28
public FPVector3 GrabJointRotationOffset;  // 0x40
public bool UseGrabFixedRotation;  // 0x58
```

### Quantum.InputDirectionSettings  (bases: ; TypeDefIndex 10488)
Fields:
```
public int BufferFrames;  // 0x0
public FP Deadzone;  // 0x8
public FP Threshold;  // 0x10
public FP MinAngle;  // 0x18
public FP MaxAngle;  // 0x20
```

### Quantum.InputDirectionDetectionSettings  (bases: ; TypeDefIndex 10489)
Fields:
```
public FP UpDetectionMinAngle;  // 0x0
public FP UpDetectionMaxAngle;  // 0x8
public FP ForwardDetectionMinAngle;  // 0x10
public FP ForwardDetectionMaxAngle;  // 0x18
public FP DownDetectionMinAngle;  // 0x20
public FP DownDetectionMaxAngle;  // 0x28
```

### Quantum.ImpulseData  (bases: ; TypeDefIndex 10490)
Fields:
```
public int FramesDuration;  // 0x10
public bool UseLocalCoordinates;  // 0x14
public bool InheritVelocityOnStop;  // 0x15
public ImpulseVelocitySettings XVelocitySettings;  // 0x18
public ImpulseVelocitySettings YVelocitySettings;  // 0x88
```
Methods:
```
public FPVector2 CalculateLeftStickInfluence(Frame frame, EntityRef entity, int facingDirection)   // RVA 0x21B8A90
public bool Update(Frame frame, CachedEntityData entityData, ref FP impulseFrames, FPVector2 referenceLeftStick, FP velocityMultiplier, ref FPVector2 impulseVelocity)   // RVA 0x21B9160
private FP EvaluateVelocity(Frame frame, CachedEntityData entityData, ImpulseVelocitySettings velocitySettings, FP currentFrame)   // RVA 0x21B8D60
public void .ctor()   // RVA 0x21B9460
```

### Quantum.ImpulseVelocitySettings  (bases: ; TypeDefIndex 10491)
Fields:
```
public ImpulseStickInfluence LeftStickInfluence;  // 0x0
public EntityVariable LeftStickInfluenceFactor;  // 0x8
public bool ApplyInterpolation;  // 0x10
public bool Loop;  // 0x11
public EntityVariable StartVelocity;  // 0x18
public EntityVariable TargetVelocity;  // 0x20
public FPAnimationCurve InterpolationCurve;  // 0x28
public EntityVariable InterpolationStartFrame;  // 0x60
public EntityVariable InterpolationEndFrame;  // 0x68
```

### Quantum.JumpData  (bases: ; TypeDefIndex 10493)
Fields:
```
public FP GravityMultiplier;  // 0x10
public FP HorizontalForce;  // 0x18
public FP HorizontalMaxVelocity;  // 0x20
public ImpulseData ImpulseData;  // 0x28
```
Methods:
```
public void .ctor()   // RVA 0x21B9CA0
```

### Quantum.ECBPreset  (bases: ; TypeDefIndex 10494)
Fields:
```
public HashString ID;  // 0x0
public HashString[] Joints;  // 0x10
```

### Quantum.StateBehaviourWithEndFrame  (bases: StateBehaviour; TypeDefIndex 10496)
Fields:
```
public int EndFrame;  // 0x60
```
Methods:
```
protected void .ctor()   // RVA 0x21AFF10
```

### Quantum.Play1DBlendspace_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10497)
Fields:
```
public AnimationPlayableInfo[] Animations;  // 0x68
public bool ApplyBlendToCurrent;  // 0x70
public FP BlendFrames;  // 0x78
public EntityVariable MinInputValue;  // 0x80
public EntityVariable MaxInputValue;  // 0x88
public EntityVariable InputValue;  // 0x90
```
Methods:
```
public void .ctor()   // RVA 0x21BB9E0
```

### Quantum.PlayAnimation_Behaviour  (bases: StateBehaviour; TypeDefIndex 10498)
Fields:
```
public AnimationPlayableInfo[] Animations;  // 0x60
public bool ApplyBlendToCurrent;  // 0x68
public FP BlendFrames;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x21BBE50
```

### Quantum.PlaySubAnimation_Behaviour  (bases: StateBehaviour; TypeDefIndex 10499)
Fields:
```
public SubAnimationPlayableInfo Animation;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SetAnimationSpeed_Behaviour  (bases: StateBehaviour; TypeDefIndex 10500)
Fields:
```
public AnimationSpeedUpdater[] AnimationSpeeds;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x21BEF60
```

### Quantum.AnimationSpeedUpdater  (bases: ; TypeDefIndex 10501)
Fields:
```
public AnimationChannel TargetChannel;  // 0x0
public AnimationSpeedUpdateMode UpdateMode;  // 0x4
public EntityVariable Speed;  // 0x8
public EntityVariable MinAnimationSpeed;  // 0x10
public EntityVariable MaxAnimationSpeed;  // 0x18
public EntityVariable MinInputValue;  // 0x20
public EntityVariable MaxInputValue;  // 0x28
public EntityVariable InputValue;  // 0x30
```
Methods:
```
public FP CalculateSpeed(Frame frame, CachedEntityData entityData)   // RVA 0x21B0070
```

### Quantum.SetAnimationWeight_Behaviour  (bases: StateBehaviour; TypeDefIndex 10503)
Fields:
```
public AnimationWeightUpdater[] AnimationWeights;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x21BF140
```

### Quantum.AnimationWeightUpdater  (bases: ; TypeDefIndex 10504)
Fields:
```
public AnimationChannel TargetChannel;  // 0x0
public EntityVariable Weight;  // 0x8
```

### Quantum.FootstepSFX_Behaviour  (bases: StateBehaviour; TypeDefIndex 10505)
Fields:
```
public EntityVariable OutLastStepIndex;  // 0x60
public bool UseExplicitChannelTargeting;  // 0x68
public AnimationChannel TargetChannel;  // 0x6C
public BehaviourFootStepInfo[] Footsteps;  // 0x70
public int LoopFrame;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x21B7190
```

### Quantum.BehaviourFootStepInfo  (bases: ; TypeDefIndex 10506)
Fields:
```
public int Frame;  // 0x0
public HashString FootstepSFXEventID;  // 0x8
```

### Quantum.PlaySFX_Behaviour  (bases: StateBehaviour; TypeDefIndex 10507)
Fields:
```
public string SFXEventName;  // 0x60
public bool UpdateSoundPosition;  // 0x68
public FP Delay;  // 0x70
public bool SetParameters;  // 0x78
public string ParameterName;  // 0x80
public SFXParameterType ParameterType;  // 0x88
public string ParameterStringValue;  // 0x90
public FP ParameterFloatValue;  // 0x98
```
Methods:
```
public void .ctor()   // RVA 0x21BC750
```

### Quantum.SetParameterSFX_Behaviour  (bases: StateBehaviour; TypeDefIndex 10508)
Fields:
```
public SFXParameterType ParameterType;  // 0x60
public string EventID;  // 0x68
public string ParameterName;  // 0x70
public bool GlobalParamter;  // 0x78
public string ParameterStringValue;  // 0x80
public FP ParameterFloatValue;  // 0x88
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StopSFX_Behaviour  (bases: StateBehaviour; TypeDefIndex 10510)
Fields:
```
public string SFXEventName;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ForceCameraTargetPosition_Behaviour  (bases: StateBehaviour; TypeDefIndex 10511)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.AddHitLag_Behaviour  (bases: StateBehaviour; TypeDefIndex 10512)
Fields:
```
public EntityVariable HitLagFrames;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.AddStatusEffect_Behaviour  (bases: StateBehaviour; TypeDefIndex 10513)
Fields:
```
public HashString StatusEffectId;  // 0x60
public HashString OriginId;  // 0x70
public bool AffectOriginEntity;  // 0x80
public BehaviourTargetEntity OriginEntity;  // 0x84
public HashString OriginIndexParameterID;  // 0x88
```
Methods:
```
private bool IsOriginEntity(Frame frame, CachedEntityData originEntity, CachedEntityData targetEntityData)   // RVA 0x21AF0A0
public void .ctor()   // RVA 0x21AF580
```

### Quantum.ClearAttackCharge_Behaviour  (bases: StateBehaviour; TypeDefIndex 10514)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Flinch_Behaviour  (bases: StateBehaviour; TypeDefIndex 10515)
Fields:
```
public ExecuteGroupEvent HitStunEndGroup;  // 0x60
public int FrameToExtendAnimation;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x20EC6E0
```

### Quantum.HitLagOverride_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10516)
Fields:
```
public EntityVariable HitlagOverrideFrames;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.KnockedOut_Behaviour  (bases: StateBehaviour; TypeDefIndex 10517)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.KnockOut_Behaviour  (bases: StateBehaviour; TypeDefIndex 10518)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Launched_Behaviour  (bases: StateBehaviour; TypeDefIndex 10519)
Fields:
```
public ExecuteGroupEvent HitStunEndGroup;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Redirect_Behaviour  (bases: StateBehaviour; TypeDefIndex 10520)
Fields:
```
public EntityVariable Redirections;  // 0x60
public EntityVariable InitialSpeed;  // 0x68
public EntityVariable RedirectionSpeedIncrease;  // 0x70
public EntityVariable MaxSpeed;  // 0x78
public RedirectionMode RedirectMode;  // 0x80
public EntityVariable OutRedirectedFlag;  // 0x88
public EntityVariable OutRedirectionSpeed;  // 0x90
public EntityVariable OutRedirectionX;  // 0x98
public EntityVariable OutRedirectionY;  // 0xA0
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.Reflect_Behaviour  (bases: StateBehaviour; TypeDefIndex 10522)
Fields:
```
public EntityVariable ReflectionVectorX;  // 0x60
public EntityVariable ReflectionVectorY;  // 0x68
public ReflectionMode ReflectMode;  // 0x70
public EntityVariable OutReflectedFlag;  // 0x78
public EntityVariable OutReflectionSpeed;  // 0x80
public EntityVariable OutReflectionSpeedX;  // 0x88
public EntityVariable OutReflectionSpeedY;  // 0x90
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.RefreshAttack_Behaviour  (bases: StateBehaviour; TypeDefIndex 10524)
Fields:
```
public int[] FramesToRefreshAttack;  // 0x60
public bool ClearOnExecute;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x21BDE10
```

### Quantum.Respawn_Behaviour  (bases: StateBehaviour; TypeDefIndex 10525)
Fields:
```
public ExecuteGroupEvent OnRespawnEndGroup;  // 0x60
public bool UseCustomRespawnPosition;  // 0x78
public HashString RespawnSpawnPointID;  // 0x80
```
Methods:
```
private void CheckRespawnEnd(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame)   // RVA 0x21BDF50
public void .ctor()   // RVA 0x21BE6D0
```

### Quantum.SetupArmor_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10526)
Fields:
```
public bool SuperArmor;  // 0x68
public bool CumulativeDamageBased;  // 0x69
public int ArmorPoints;  // 0x6C
```
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.SetupHitBoxesFromLinecast_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10527)
Fields:
```
public EntityVariable XPosition;  // 0x68
public EntityVariable YPosition;  // 0x70
public bool PositionRelativeToEntity;  // 0x78
public bool OutputToLineRenderer;  // 0x79
public CollisionLayer[] LinecastLayers;  // 0x80
public EntityVariable CastAngle;  // 0x88
public bool AngleRelativeToEntity;  // 0x90
public EntityVariable CastDistance;  // 0x98
public EntityVariable HitBoxesRadius;  // 0xA0
public HashString[] AttackDatas;  // 0xA8
```
Methods:
```
private void GenerateHitBoxes(Frame frame, CachedEntityData targetEntityData)   // RVA 0x21BFA00
public void .ctor()   // RVA 0x21C0790
```

### Quantum.SetupHitBoxes_Behaviour  (bases: StateBehaviour; TypeDefIndex 10528)
Fields:
```
public HitBoxData[] HitBoxes;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SetupHurtBoxes_Behaviour  (bases: StateBehaviour; TypeDefIndex 10530)
Fields:
```
public SetupHurtBoxes_Behaviour.HurtBoxUpdateMode UpdateMode;  // 0x60
public HashString PresetID;  // 0x68
public HurtBoxData[] HurtBoxes;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x21C0DA0
```

### Quantum.SetupIntangibility_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10531)
Fields:
```
public bool FullIntangibility;  // 0x68
public int IntangibilityFrames;  // 0x6C
public HashString[] IntangibleHurtBoxes;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x21C10C0
```

### Quantum.SetupInvincibility_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10532)
Fields:
```
public bool FullInvincibility;  // 0x68
public int InvincibilityFrames;  // 0x6C
public HashString[] InvincibleHurtBoxes;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x21C13E0
```

### Quantum.StartAttackCharge_Behaviour  (bases: StateBehaviour; TypeDefIndex 10533)
Fields:
```
public HashString ChargeAttackMultiplierID;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x21C1D20
```

### Quantum.StopStatusEffect_Behaviour  (bases: StateBehaviour; TypeDefIndex 10535)
Fields:
```
public StopStatusEffect_Behaviour.statusEffectRemoveEnum RemoveType;  // 0x60
public HashString IdToRemove;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.UpdateAttackCharge_Behaviour  (bases: StateBehaviour; TypeDefIndex 10536)
Fields:
```
public ExecuteGroupEvent ChargeFinishedGroup;  // 0x60
public bool OverrideGroundAttackMaxChargeFrames;  // 0x78
public int GroundAttackMaxChargeFrames;  // 0x7C
public bool OverrideFramesToReleaseChargeGroundAttack;  // 0x80
public int FramesToReleaseChargeGroundAttack;  // 0x84
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.UpdateEntityHitFilter_Behaviour  (bases: StateBehaviour; TypeDefIndex 10537)
Fields:
```
public bool ResetToDefault;  // 0x60
public EntityHitFilter HitFilter;  // 0x64
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.CreatePlayerCopy_Behaviour  (bases: StateBehaviour; TypeDefIndex 10538)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.PrintMessage_Behaviour  (bases: StateBehaviour; TypeDefIndex 10540)
Fields:
```
public MessagePart[] MessageParts;  // 0x60
public PrintMessage_Behaviour.MessageOutput Output;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x21BCC10
```

### Quantum.MessagePart  (bases: ; TypeDefIndex 10541)
Fields:
```
public MessagePartType MessagePartType;  // 0x0
public string Text;  // 0x8
public EntityVariable Variable;  // 0x10
```

### Quantum.MoveToEdge_Behaviour  (bases: StateBehaviour; TypeDefIndex 10543)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StopEdgeGrab_Behaviour  (bases: StateBehaviour; TypeDefIndex 10544)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.UpdateEdgeGrabBox_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10545)
Fields:
```
public EdgeGrabBoxDataObject[] EdgeGrabBoxDatas;  // 0x68
```
Methods:
```
private void CheckEdgeGrabDatas(Frame frame, CachedEntityData entityData, int currentFrame)   // RVA 0x21C2C60
public void .ctor()   // RVA 0x21C30D0
```

### Quantum.EdgeGrabBoxDataObject  (bases: ; TypeDefIndex 10546)
Fields:
```
public int Frame;  // 0x0
public EdgeGrabCondition EdgeGrabCondition;  // 0x4
public bool OverrideRect;  // 0x8
public SimpleAABB Rect;  // 0x10
public FP GrabVelocityThreshold;  // 0x30
```

### Quantum.AdvancedOperation_Behaviour  (bases: StateBehaviour; TypeDefIndex 10547)
Fields:
```
public AdvancedOperation[] Operations;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x21AF6F0
```

### CalculateRandomFromWeights_Behaviour.WeightElement  (bases: ; TypeDefIndex 10548)
Fields:
```
public HashString ID;  // 0x0
public int Weight;  // 0x10
public int OutputValue;  // 0x14
```

### Quantum.CalculateRandomFromWeights_Behaviour  (bases: StateBehaviour; TypeDefIndex 10549)
Fields:
```
public CalculateRandomFromWeights_Behaviour.WeightElement[] WeightElements;  // 0x60
public HashString ParameterID;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x21B19F0
```

### ChangeStateConditionally_Behaviour.ConditionalState  (bases: ; TypeDefIndex 10550)
Fields:
```
public ChangeStateEvent TargetState;  // 0x0
public AdvancedConditionLogicalOperator LogicalOperator;  // 0x18
public AdvancedCondition[] Conditions;  // 0x20
```

### Quantum.ChangeStateConditionally_Behaviour  (bases: StateBehaviour; TypeDefIndex 10551)
Fields:
```
public ChangeStateConditionally_Behaviour.ConditionalState[] ConditionalStates;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ChangeState_Behaviour  (bases: StateBehaviour; TypeDefIndex 10552)
Fields:
```
public ChangeStateEvent TargetState;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.DestroyEntity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10553)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.DisableEntity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10554)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### ExecuteGroupConditionally_Behaviour.ConditionalGroup  (bases: ; TypeDefIndex 10555)
Fields:
```
public ExecuteGroupEvent GroupToExecute;  // 0x0
public AdvancedConditionLogicalOperator LogicalOperator;  // 0x18
public AdvancedCondition[] Conditions;  // 0x20
```

### Quantum.ExecuteGroupConditionally_Behaviour  (bases: StateBehaviour; TypeDefIndex 10556)
Fields:
```
public ExecuteGroupConditionally_Behaviour.ConditionalGroup[] ConditionalGroups;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ExecuteGroupOnLinecastHit_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10558)
Fields:
```
public ExecuteGroupEvent GroupToExecute;  // 0x68
public ExecuteGroupOnLinecastHit_Behaviour.LinecastConditions LinecastCondition;  // 0x80
public bool LinecastStartUsesFacingDirection;  // 0x84
public bool LinecastStartRelativeToCharacter;  // 0x85
public FPVector2 LinecastStart;  // 0x88
public bool LinecastEndUsesFacingDirection;  // 0x98
public bool LinecastEndRelativeToCharacter;  // 0x99
public FPVector2 LinecastEnd;  // 0xA0
public CollisionLayer[] LinecastLayers;  // 0xB0
public EntityVariable OutXPosition;  // 0xB8
public EntityVariable OutYPosition;  // 0xC0
public ColorRGBA LinecastColor;  // 0xC8
```
Methods:
```
public void .ctor()   // RVA 0x21B5D80
```

### Quantum.ExecuteGroup_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10560)
Fields:
```
public ExecuteGroupEvent GroupToExecute;  // 0x68
public ExecuteGroup_Behaviour.ExecuteGroupRepeatMode RepeatMode;  // 0x80
public int FramesInterval;  // 0x84
public int RepeatNumber;  // 0x88
```
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.FindClosestEntity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10561)
Fields:
```
public EntityVariable OutEntityIndex;  // 0x60
public EntityVariable Radius;  // 0x68
public bool IgnoreOriginalOwner;  // 0x70
public bool IgnoreOwner;  // 0x71
public bool CheckForCharacters;  // 0x72
public bool CheckForProjectiles;  // 0x73
public bool CheckForItems;  // 0x74
public bool CheckForHazards;  // 0x75
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.PlayCameraShake_Behaviour  (bases: StateBehaviour; TypeDefIndex 10562)
Fields:
```
public HashString PresetID;  // 0x60
public bool OverrideForce;  // 0x70
public FP Force;  // 0x78
public bool OverrideVelocity;  // 0x80
public FPVector3 Velocity;  // 0x88
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ResetMovesetLimiters_Behaviour  (bases: StateBehaviour; TypeDefIndex 10563)
Fields:
```
public MovesetLimiterResetContext ResetContext;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SpawnEntity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10564)
Fields:
```
public AssetRefGameEntityData GameEntity;  // 0x60
public EntityVariable SpawnedEntityIndexOutput;  // 0x68
public EntityVariable CostumeIndex;  // 0x70
public EntityVariable XPosition;  // 0x78
public EntityVariable YPosition;  // 0x80
public bool PositionRelativeToSpawner;  // 0x88
```
Methods:
```
public void .ctor()   // RVA 0x21C1C10
```

### Quantum.CheckGrabbableEntities_Behaviour  (bases: StateBehaviour; TypeDefIndex 10565)
Fields:
```
public bool CheckForGrab;  // 0x60
public ChangeStateEvent PickupState;  // 0x68
public bool ChangeState;  // 0x80
public bool InvertFacingDirection;  // 0x81
public bool ForceStrongThrow;  // 0x82
public bool ForceStrongUse;  // 0x83
public ChangeStateEvent ThrowState;  // 0x88
public ChangeStateEvent SwingState;  // 0xA0
public ChangeStateEvent ShootState;  // 0xB8
```
Methods:
```
public void .ctor()   // RVA 0x21B2540
```

### Quantum.DropEntity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10566)
Fields:
```
public bool OverrideStartPosition;  // 0x60
public FPVector2 StartPosition;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.GrabLaunch_Behaviour  (bases: StateBehaviour; TypeDefIndex 10567)
Fields:
```
public HashString AttackData;  // 0x60
public bool OverrideVictimPosition;  // 0x70
public FPVector2 VictimPositionOnLaunch;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.GrabPummel_Behaviour  (bases: StateBehaviour; TypeDefIndex 10568)
Fields:
```
public FP Damage;  // 0x60
public bool TriggerPummelStateOnVictim;  // 0x68
public int HitlagFrames;  // 0x6C
```
Methods:
```
public void .ctor()   // RVA 0x21B7870
```

### Quantum.ThrowEntity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10569)
Fields:
```
public ThrowDirection ThrowDirection;  // 0x60
public bool OverrideStartPosition;  // 0x64
public FPVector2 StartPosition;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.UseEntity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10571)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.InputTransition  (bases: ; TypeDefIndex 10573)
Fields:
```
public InputAction Action;  // 0x0
public ExecuteGroupEvent GroupToExecute;  // 0x8
public ChangeStateEvent TargetState;  // 0x20
```

### Quantum.JumpAnticipation_Behaviour  (bases: StateBehaviour; TypeDefIndex 10574)
Fields:
```
public InputFlag JumpButton;  // 0x60
public ChangeStateEvent JumpState;  // 0x68
public ChangeStateEvent JumpBackState;  // 0x80
```
Methods:
```
public void .ctor()   // RVA 0x21B9B50
```

### Quantum.Jump_Behaviour  (bases: StateBehaviour; TypeDefIndex 10576)
Fields:
```
public JumpBehaviourType JumpToExecute;  // 0x60
public bool StopActiveImpulse;  // 0x64
public bool OverrideXVelocity;  // 0x65
public EntityVariable XVelocity;  // 0x68
public bool OverrideYVelocity;  // 0x70
public EntityVariable YVelocity;  // 0x78
public bool StopJumpOnExit;  // 0x80
```
Methods:
```
private void ExecuteJump(Frame frame, CachedEntityData targetEntityData, Jump* jump, JumpData JumpData, JumpType jumpType)   // RVA 0x21B9CC0
private void ExecuteWallJump(Frame frame, CachedEntityData targetEntityData, Jump* jump, JumpData JumpData)   // RVA 0x21B9E80
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StopJump_Behaviour  (bases: StateBehaviour; TypeDefIndex 10577)
Fields:
```
public bool PreventVelocityInheritance;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.AirHorizontalControl_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10578)
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.ApplyImpulse_Behaviour  (bases: StateBehaviour; TypeDefIndex 10579)
Fields:
```
public ImpulseData ImpulseData;  // 0x60
public bool StopImpulseOnExit;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ApplyKinematicMotion_Behaviour  (bases: StateBehaviour; TypeDefIndex 10580)
Fields:
```
public bool SnapToGround;  // 0x60
public bool PhysicsCorrectionDisabled;  // 0x61
public bool EnablePhysicsCorrectionManually;  // 0x62
public int FrameToEnableCorrection;  // 0x64
```
Methods:
```
private void ApplyKinematicMotion(Frame frame, CachedEntityData targetEntityData, int currentFrame)   // RVA 0x21B0480
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.FollowEntity_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10581)
Fields:
```
public BehaviourTargetEntity EntityToFollow;  // 0x68
public HashString EntityToFollowParameterID;  // 0x70
public EntityVariable XOffset;  // 0x80
public EntityVariable YOffset;  // 0x88
public bool UseEntityFacingDirection;  // 0x90
```
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.ResetRuntimePhysics_Behaviour  (bases: StateBehaviour; TypeDefIndex 10582)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.RotateBasedOnVelocity_Behaviour  (bases: StateBehaviour; TypeDefIndex 10583)
Fields:
```
public VelocityAxisInfluence AxisInfluence;  // 0x60
public EntityVariable RotationOffset;  // 0x68
public FP MinVelocity;  // 0x70
public FP MaxVelocity;  // 0x78
public FP MinRotation;  // 0x80
public FP MaxRotation;  // 0x88
public bool ResetRotationOnExit;  // 0x90
```
Methods:
```
private void SetRotation(Frame frame, CachedEntityData targetEntityData)   // RVA 0x21BE810
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.RotateSmooth_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10585)
Fields:
```
public EntityVariable StartRotation;  // 0x68
public EntityVariable TargetRotation;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.Rotate_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10586)
Fields:
```
public EntityVariable RotationSpeed;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.SetVelocityFromGroundSlopeNormal_Behaviour  (bases: StateBehaviour; TypeDefIndex 10587)
Fields:
```
public GroundNormal GroundNormalToUse;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.SlideOnDownSlope_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10589)
Fields:
```
public FP MaxVelocity;  // 0x68
public FP Acceleration;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.StopImpulse_Behaviour  (bases: StateBehaviour; TypeDefIndex 10590)
Fields:
```
public bool PreventVelocityInheritance;  // 0x60
public bool ResetVelocity;  // 0x61
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.UpdateEnvironmentCollisionBox_Behaviour  (bases: StateBehaviour; TypeDefIndex 10592)
Fields:
```
public UpdateEnvironmentCollisionBox_Behaviour.ECBUpdateMode UpdateMode;  // 0x60
public bool UseRootAsBottom;  // 0x64
public HashString PresetID;  // 0x68
public EntityVariable Top;  // 0x78
public EntityVariable Bottom;  // 0x80
public EntityVariable Left;  // 0x88
public EntityVariable Right;  // 0x90
public ECBOffset TopOffset;  // 0x98
public ECBOffset BottomOffset;  // 0xA8
public ECBOffset LeftOffset;  // 0xB8
public ECBOffset RightOffset;  // 0xC8
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.UseGroundRotation_Behaviour  (bases: StateBehaviour; TypeDefIndex 10593)
Fields:
```
public FP FloorRotationInfluence;  // 0x60
public FP InterpolationSpeed;  // 0x68
public bool ForceRotation;  // 0x70
public bool ResetOnExit;  // 0x71
```
Methods:
```
public void .ctor()   // RVA 0x21C3F90
```

### Quantum.ModifyBlastzone_Behaviour  (bases: StateBehaviour; TypeDefIndex 10594)
Fields:
```
public FPVector2 TopLeft;  // 0x60
public FPVector2 RightDown;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ModifyCameraManagerData_Behaviour  (bases: StateBehaviour; TypeDefIndex 10595)
Fields:
```
public bool UpdateCameraManagerData;  // 0x60
public AssetRefCameraManagerData NewCameraManagerData;  // 0x68
public bool Active;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x21BAEB0
```

### Quantum.ModifyContinuousRotation_Behaviour  (bases: StateBehaviour; TypeDefIndex 10596)
Fields:
```
public bool Active;  // 0x60
public bool ModifySpeed;  // 0x61
public FP Speed;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ModifyStageEdge_Behaviour  (bases: StateBehaviour; TypeDefIndex 10597)
Fields:
```
public bool Active;  // 0x60
public HashString TargetStateGrabbedEntity;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ModifyStageElementAnimation_Behaviour  (bases: StateBehaviour; TypeDefIndex 10598)
Fields:
```
public bool Active;  // 0x60
public bool UpdateData;  // 0x61
public AssetRefTransformKeyFramesData NewTransformKeyFramesData;  // 0x68
public bool UpdateLoopMode;  // 0x70
public LoopMode NewMode;  // 0x74
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.ResetTimeline_Behaviour  (bases: StateBehaviour; TypeDefIndex 10599)
Fields:
```
public FP NewResetTimelineValue;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x21BDF40
```

### Quantum.CheckForTech_Behaviour  (bases: StateBehaviour; TypeDefIndex 10600)
Fields:
```
public ChangeStateEvent TechLandState;  // 0x60
public ChangeStateEvent TechWallState;  // 0x78
public ChangeStateEvent TechCeilingState;  // 0x90
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.DetectEntityThrow_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10601)
Fields:
```
public InputTransition ThrowUp;  // 0x68
public InputTransition ThrowDown;  // 0xA0
public InputTransition ThrowBack;  // 0xD8
public InputTransition ThrowForward;  // 0x110
```
Methods:
```
private void EvaluateInput(Frame frame, CachedEntityData targetEntityData)   // RVA 0x21B4000
public void .ctor()   // RVA 0x21AFF10
```

### Quantum.DetectIdleAir_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10602)
Fields:
```
public ChangeStateEvent IdleAirState;  // 0x68
```
Methods:
```
public void .ctor()   // RVA 0x21B4210
```

### Quantum.DetectLand_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10603)
Fields:
```
public ChangeStateEvent LandState;  // 0x68
public EntityVariable LandLagFrames;  // 0x80
public EntityVariable OutLandLagFrames;  // 0x88
```
Methods:
```
private void CheckForGround(Frame frame, CachedEntityData targetEntityData)   // RVA 0x21B42D0
public void .ctor()   // RVA 0x21B44C0
```

### Quantum.DetectWallSlide_Behaviour  (bases: StateBehaviourWithEndFrame; TypeDefIndex 10604)
Fields:
```
public FP MinWallNormal;  // 0x68
public ChangeStateEvent WallSlideState;  // 0x70
public EntityVariable LinecastHeight;  // 0x88
public EntityVariable LinecastLength;  // 0x90
public CollisionLayer[] LinecastLayers;  // 0x98
public ColorRGBA DebugColor;  // 0xA0
```
Methods:
```
public void .ctor()   // RVA 0x21B4EF0
```

### Quantum.AirDodge_Behaviour  (bases: StateBehaviour; TypeDefIndex 10605)
Fields:
```
public int FramesToDetectAirDodgeLand;  // 0x60
public FP LandDistanceCheck;  // 0x68
public ColorRGBA AirDodgeLandDebugColor;  // 0x70
public EntityVariable OutAirDodges;  // 0x78
```
Methods:
```
public void .ctor()   // RVA 0x21AFE80
```

### Quantum.Dash_Behaviour  (bases: StateBehaviour; TypeDefIndex 10606)
Fields:
```
public bool StopCurrentForces;  // 0x60
public FP InitialForce;  // 0x68
public FP MinimumAcceleration;  // 0x70
public FP MaxAcceleration;  // 0x78
```
Methods:
```
private void StartDash(Frame frame, CachedEntityData targetEntityData)   // RVA 0x21B3F20
public void .ctor()   // RVA 0x21B3FD0
```

### Quantum.FastFall_Behaviour  (bases: StateBehaviour; TypeDefIndex 10607)
Fields:
```
public EntityVariable FastFallSpeed;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.LandLag_Behaviour  (bases: StateBehaviour; TypeDefIndex 10608)
Fields:
```
public ExecuteGroupEvent LandLagEndGroup;  // 0x60
public int FrameToExtendAnimation;  // 0x78
public EntityVariable OutLandLagFrames;  // 0x80
```
Methods:
```
public void .ctor()   // RVA 0x20EC6E0
```

### Quantum.StopFastFall_Behaviour  (bases: StateBehaviour; TypeDefIndex 10609)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.WallSlide_Behaviour  (bases: StateBehaviour; TypeDefIndex 10610)
Fields:
```
public ChangeStateEvent IdleAirState;  // 0x60
public ExecuteGroupEvent OnLeaveWallGroup;  // 0x78
public FP FallSpeed;  // 0x90
public FP BrakeFallSpeed;  // 0x98
public bool LeaveWallWithStickMove;  // 0xA0
public FP StickValueToLeaveWall;  // 0xA8
```
Methods:
```
public void .ctor()   // RVA 0x20FC1A0
```

### Quantum.PlayTint_Behaviour  (bases: StateBehaviour; TypeDefIndex 10611)
Fields:
```
public RuntimeTintData TintData;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.RuntimeTintData  (bases: ; TypeDefIndex 10612)
Fields:
```
public HashString TindID;  // 0x10
public TintCategories Category;  // 0x20
public bool StopOnExit;  // 0x24
```
Methods:
```
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.PlayVFX_Behaviour  (bases: StateBehaviour; TypeDefIndex 10613)
Fields:
```
public HashString VFXID;  // 0x60
public VFXPlayAttributes PlayAttributes;  // 0x70
public bool StopOnExit;  // 0x108
public VFXStopAttributes StopAttributes;  // 0x109
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StartShake_Behaviour  (bases: StateBehaviour; TypeDefIndex 10614)
Fields:
```
public FP ShakeDuration;  // 0x60
public FP ShakePower;  // 0x68
public bool ShakeHorizontally;  // 0x70
public bool ShakeVertically;  // 0x71
public bool StopOnExit;  // 0x72
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StopAllVFX_Behaviour  (bases: StateBehaviour; TypeDefIndex 10615)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StopShake_Behaviour  (bases: StateBehaviour; TypeDefIndex 10616)
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StopTint_Behaviour  (bases: StateBehaviour; TypeDefIndex 10617)
Fields:
```
public TintCategories CatetoryToStop;  // 0x60
public bool StopAllTints;  // 0x64
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.StopVFX_Behaviour  (bases: StateBehaviour; TypeDefIndex 10618)
Fields:
```
public HashString VFXID;  // 0x60
public VFXStopAttributes StopAttributes;  // 0x70
```
Methods:
```
public void .ctor()   // RVA 0x20EBB30
```

### Quantum.UpdateObjectsVisibility_Behaviour  (bases: StateBehaviour; TypeDefIndex 10619)
Fields:
```
public RuntimeObjectVisibilityData[] ObjectsVisibilityData;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20FB6B0
```

### Quantum.RuntimeObjectVisibilityData  (bases: ; TypeDefIndex 10620)
Fields:
```
public HashString RigID;  // 0x10
public HashString ObjectID;  // 0x20
public bool Visibility;  // 0x30
public bool HasConditions;  // 0x31
public AdvancedConditionLogicalOperator LogicalOperator;  // 0x34
public AdvancedCondition[] Conditions;  // 0x38
```
Methods:
```
public void .ctor()   // RVA 0x20F9630
```

### Quantum.UpdateSlotsAttachment_Behaviour  (bases: StateBehaviour; TypeDefIndex 10621)
Fields:
```
public RuntimeSlotAttachmentData[] SlotAttachmentsData;  // 0x60
```
Methods:
```
public void .ctor()   // RVA 0x20FBA80
```

### Quantum.RuntimeSlotAttachmentData  (bases: ; TypeDefIndex 10622)
Fields:
```
public HashString RigID;  // 0x10
public HashString PropID;  // 0x20
public TargetSlot Slot;  // 0x30
public bool HasConditions;  // 0x34
public AdvancedConditionLogicalOperator LogicalOperator;  // 0x38
public AdvancedCondition[] Conditions;  // 0x40
```
Methods:
```
public void .ctor()   // RVA 0x20F9690
```

### Quantum.AdvancedCondition  (bases: ; TypeDefIndex 10623)
Fields:
```
public EntityVariable Target;  // 0x10
public EntityVariable Value;  // 0x18
public AdvancedConditionComparer Comparer;  // 0x20
```
Methods:
```
public bool Evaluate(Frame frame, CachedEntityData entityData)   // RVA 0x20E5960
public static bool EvaluateMultiple(Frame frame, CachedEntityData entityData, AdvancedConditionLogicalOperator logicalOperator, AdvancedCondition[] conditions)   // RVA 0x20E5830
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.AdvancedOperation  (bases: ; TypeDefIndex 10624)
Fields:
```
public EntityVariable Target;  // 0x10
public EntityVariable Value;  // 0x18
public AdvancedOperationAction Action;  // 0x20
```
Methods:
```
public void Execute(Frame frame, CachedEntityData entityData)   // RVA 0x20E5F60
public void .ctor()   // RVA 0x4FA6F0
```

### Quantum.EntityVariable  (bases: EntityVariableBase; TypeDefIndex 10625)
Fields:
```
public SubEntityVariable1[] Inputs;  // 0x80
```
Methods:
```
public void .ctor()   // RVA 0x20EB920
```

### Quantum.SubEntityVariable1  (bases: EntityVariableBase; TypeDefIndex 10626)
Fields:
```
public SubEntityVariable2[] Inputs;  // 0x80
```
Methods:
```
public void .ctor()   // RVA 0x20FAA80
```

### Quantum.SubEntityVariable2  (bases: EntityVariableBase; TypeDefIndex 10627)
Fields:
```
public SubEntityVariable3[] Inputs;  // 0x80
```
Methods:
```
public void .ctor()   // RVA 0x20FAB00
```

### Quantum.SubEntityVariable3  (bases: EntityVariableBase; TypeDefIndex 10628)
Fields:
```
public SubEntityVariable4[] Inputs;  // 0x80
```
Methods:
```
public void .ctor()   // RVA 0x20FAB80
```

### Quantum.SubEntityVariable4  (bases: EntityVariableBase; TypeDefIndex 10629)
Methods:
```
public void .ctor()   // RVA 0x20FAC00
```

### Quantum.VariableTarget  (bases: Attribute; TypeDefIndex 10630)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.DisplayTwoInputs  (bases: Attribute; TypeDefIndex 10631)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.DisplayThreeInputs  (bases: Attribute; TypeDefIndex 10632)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.EnableReadOnly  (bases: Attribute; TypeDefIndex 10633)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.DrawWithLabel  (bases: Attribute; TypeDefIndex 10634)
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.StateLogicChacheData  (bases: ; TypeDefIndex 10663)
Fields:
```
public AssetRefStateBehaviour[] DefaultBehaviours;  // 0x0
public StateGroup[] StateInheritedGroups;  // 0x8
```
Methods:
```
public static StateLogicChacheData Default()   // RVA 0x20FA290
```

### Quantum.StateGroup  (bases: ; TypeDefIndex 10664)
Fields:
```
public HashString Name;  // 0x0
public StateGroupEvent EventToReact;  // 0x10
public bool HasConditions;  // 0x14
public AdvancedConditionLogicalOperator LogicalOperator;  // 0x18
public AdvancedCondition[] Conditions;  // 0x20
```

### Quantum.ExecuteGroupEvent  (bases: ; TypeDefIndex 10665)
Fields:
```
public HashString GroupName;  // 0x0
public StateGroupExecutionMode ExecutionMode;  // 0x10
```

### Quantum.ChangeStateEvent  (bases: ; TypeDefIndex 10666)
Fields:
```
public HashString StateName;  // 0x0
public int TransitionFrames;  // 0x10
```
Methods:
```
public void .ctor(HashString stateName, int transitionFrames)   // RVA 0xE07060
```

### Quantum.StateMachineDataVariable  (bases: ; TypeDefIndex 10668)
Fields:
```
public HashString Name;  // 0x0
public FP Value;  // 0x10
public string Notes;  // 0x18
```

### Quantum.StatusEffectDamageOverTime  (bases: StatusEffectBase; TypeDefIndex 10669)
Fields:
```
public FP Damage;  // 0x1B0
public FP FrameFrecuency;  // 0x1B8
protected FP FrameCountToNextDamage;  // 0x1C0
```
Methods:
```
public void .ctor()   // RVA 0x20FA770
```

### Quantum.CommandSetup  (bases: ; TypeDefIndex 10671)
Methods:
```
public static DeterministicCommand[] CreateCommands(RuntimeConfig gameConfig, SimulationConfig simulationConfig)   // RVA 0x81E2E0
```

### Quantum.CharacterDataFile  (bases: ; TypeDefIndex 10672)
Fields:
```
public HashString CharacterID;  // 0x0
public AssetRefGameEntityData Data;  // 0x10
```

### Quantum.GameModeFile  (bases: ; TypeDefIndex 10673)
Fields:
```
public HashString GameModeID;  // 0x0
public AssetRefBaseGameMode GameModeAsset;  // 0x10
```

### Quantum.PhysicsDataSurfaceType  (bases: ; TypeDefIndex 10674)
Fields:
```
public SurfaceType SurfaceType;  // 0x0
public AssetRefPhysicsMaterial PhysicsMaterialAsset;  // 0x8
```

### Quantum.SystemSetup  (bases: ; TypeDefIndex 10675)
Methods:
```
public static SystemBase[] CreateSystems(RuntimeConfig gameConfig, SimulationConfig simulationConfig)   // RVA 0x20FAC50
```

### PhysicsSystem.<>c  (bases: ; TypeDefIndex 10681)
Fields:
```
public static readonly PhysicsSystem.<>c <>9;  // 0x0
public static Comparison<PolygonVertex> <>9__24_0;  // 0x8
```
Methods:
```
private static void .cctor()   // RVA 0x20FB2D0
public void .ctor()   // RVA 0x4FA6F0
internal int <InterpolatedEdgeCheck>b__24_0(PolygonVertex a, PolygonVertex b)   // RVA 0x20FB2B0
```

### Quantum.CharacterUtils  (bases: ; TypeDefIndex 10685)
Methods:
```
public static List<EntityRef> GetAllPlayableCharacters(Frame frame)   // RVA 0x20E64E0
public static List<EntityRef> GetAllPlayableMainCharacters(Frame frame)   // RVA 0x20E6710
```

### Quantum.CombatUtils  (bases: ; TypeDefIndex 10686)
Methods:
```
public static void CalculateAttackDamage(Frame frame, Combat* instigator, Combat* victim, AttackData attackData, bool checkForDamageOverride, bool hitFromOwner, bool sameTeam, out FP damage, out FP blockDamage)   // RVA 0x20EA210
public static FP CalculateAttackKnockback(Frame frame, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FP baseKnockback, FP knockbackGain, FP ratio)   // RVA 0x20EA3A0
public static FP CalculateHitStun(FP knockback, FP hitStunMultiplier, FP hitStunMinimum, FP globalhitStunMultiplier, FP hitStunFramesAdd)   // RVA 0x20EA5E0
public static FP CalculateMaxClankHitlagFrames(CombatSettingsData combatSettingsData, AttackData attackData1, AttackData attackData2)   // RVA 0x20EA6B0
public static FP CalculateMinClankHitlagFrames(CombatSettingsData combatSettingsData, AttackData attackData1, AttackData attackData2)   // RVA 0x20EA720
public static void ExecuteSimpleAttack(Frame frame, int attackDataHash, EntityRef instigatorEntity, EntityRef victimEntity)   // RVA 0x20EAD80
public static bool CanEntitiesInteract(Frame frame, CombatEntity check, CombatEntity target, out bool hittingOwner, out bool hitFromOwner, out bool sameTeam, out int facingDirection)   // RVA 0x20EA790
private static bool CanInteractBasedOnPolicy(CombatInteractionPolicy checkInteractionPolicy, CombatInteractionPolicy targetInteractionPolicy)   // RVA 0x20EAD50
private static CombatInteractionPolicy GetInteractionPolicy(Frame frame, Combat* combat, GameEntityType entityType)   // RVA 0x20EB5B0
public static int GetHitPriorityForEntityType(GameEntityType entityType)   // RVA 0x20EB550
public static int GetHitBoxTypePriority(HitBoxType hitBoxType)   // RVA 0x20EB510
public static FP CalculateHorizontalHitDirection(Frame frame, HitBoxSpecialBehaviour hitBoxHorizontalBehaviour, FPVector2 hitBoxPosition, EntityRef victim)   // RVA 0x20EA620
public static FP CalculateDIAngle(FPVector2 launchVector, FPVector2 inputVector, FP maxDIAngle)   // RVA 0x20EA510
```

### Quantum.FrameCountUtils  (bases: ; TypeDefIndex 10687)
Methods:
```
public static FP FrameTime(Frame frame)   // RVA 0x20EBB40
public static FP UpdateFrameCounter(Frame frame, FP currentValue)   // RVA 0x20EBD60
public static FP UpdateFrameCounter(Frame frame, FP currentValue, FP speedMultiplier)   // RVA 0x20EBDB0
public static FP UpdateFrameCountdown(Frame frame, FP currentValue)   // RVA 0x20EBCB0
public static FP UpdateFrameCountdown(Frame frame, FP currentValue, FP speedMultiplier)   // RVA 0x20EBD00
public static bool IsFrameCounterComplete(FP currentFrame, FP target)   // RVA 0x20EBBB0
public static bool IsFrameCountDownComplete(FP currentFrame)   // RVA 0x20EBB80
public static FP Progress(FP start, FP end, FP current, bool loop = False)   // RVA 0x20EBBF0
public static int RoundFrame(FP frame)   // RVA 0x20EBCA0
```

### LoadDebugger.BreakPoint  (bases: ; TypeDefIndex 10688)
Fields:
```
public string Name;  // 0x0
public DateTime StartTime;  // 0x8
public DateTime EndTime;  // 0x10
public bool Completed;  // 0x18
```
Methods:
```
public void .ctor(string name, DateTime startTime)   // RVA 0x20E6450
```

### Quantum.LoadDebugger  (bases: ; TypeDefIndex 10689)
Fields:
```
private static Dictionary<string, LoadDebugger.BreakPoint> breakpoints;  // 0x0
private static DateTime initialTime;  // 0x8
```
Methods:
```
public static void StartTracking()   // RVA 0x20ED070
public static void RegisterBreakpoint(string breackpointName, bool stopPreviousBreackpoints = False)   // RVA 0x20ECD30
public static void MarkBreackpointEnd(string breackpointName)   // RVA 0x20ECB90
public static void FinishTrackingAndPrintResult()   // RVA 0x20EC6F0
private static void .cctor()   // RVA 0x20ED120
```

### Quantum.VectorUtility  (bases: ; TypeDefIndex 10690)
Methods:
```
public static FPVector2 ToFPVector2(FPVector3 vector3)   // RVA 0x20FBB70
public static bool Approximately(FPVector2 vectorA, FPVector2 vectorB)   // RVA 0x20FBAE0
public static FPVector3 ToFPVector3(FPVector2 vector2)   // RVA 0x20FBBA0
```

### Quantum.FPUtility  (bases: ; TypeDefIndex 10691)
Fields:
```
private static FP fpUncertainty;  // 0x0
```
Methods:
```
public static bool ToBoolean(FP fp)   // RVA 0x1E9F670
public static bool Approximately(FP a, FP b)   // RVA 0x20EB9A0
private static void .cctor()   // RVA 0x20EBA20
```

### Quantum.MathUtils  (bases: ; TypeDefIndex 10692)
Methods:
```
public static FP get_SecondsToFrame()   // RVA 0x20EF480
public static FP get_FrameToSeconds()   // RVA 0x20EF470
public static int Random(Frame frame, int minInclusive, int maxInclusive)   // RVA 0x20EF160
public static FP Random(Frame frame, FP minInclusive, FP maxInclusive)   // RVA 0x20EF1A0
public static FPVector2 Ortho(FPVector2 vector)   // RVA 0x20EEF30
public static FPVector2 ReflectAway(FPVector2 vector, FPVector2 normal)   // RVA 0x20EF1E0
public static FPVector2 ProjectPointOnSegment(FPVector2 segmentStart, FPVector2 segmentEnd, FPVector2 point, bool clamp = False)   // RVA 0x20EEFA0
public static FPVector3 GlobalPoint(FPVector3 point, FPVector3 transformPosition, FPQuaternion transformRotation, FPVector3 transformScale)   // RVA 0x20EE0F0
public static FPVector2 LocalToWorldPoint(Frame frame, EntityRef entity, Transform2D* transform, FPVector2 point, bool ignoreScale = False)   // RVA 0x20EEB90
public static FPVector2 RotatePointAroundPivot(FPVector2 point, FPVector2 pivot, FP angle)   // RVA 0x20EF340
public static FP NormalizedAngle(FP angle)   // RVA 0x20EEED0
public static FP ClosestAngleDifference(FP angle1, FP angle2)   // RVA 0x20EDF70
public static FP AngleLinearInterpolation(FP angle1, FP angle2, FP t)   // RVA 0x20EDC20
public static FPVector2 GetDirectionFromAngle(FP angle)   // RVA 0x20EE090
public static FP MoveTowards(FP current, FP target, FP maxDelta)   // RVA 0x20EED70
public static FP MoveTowardsAngle(FP current, FP target, FP maxDelta)   // RVA 0x20EECD0
public static FP DeltaAngle(FP current, FP target)   // RVA 0x20EE030
public static FP AngleBetweenPoints(FPVector2 from, FPVector2 to)   // RVA 0x20EDBA0
public static bool BetweenVectors(FPVector2 vectorToCheck, FPVector2 limitA, FPVector2 limitB)   // RVA 0x20EDD80
public static bool IsAngleInRange(FP angle, FP start, FP end, bool invertX)   // RVA 0x20EE300
public static FP TruncFP(FP fp)   // RVA 0x20EF430
public static FP MapRange(FP value, FP from1, FP from2, FP to1, FP to2)   // RVA 0x20EEC90
public static SimpleAABB MultiplyRect(SimpleAABB originalRect, FP multiplier)   // RVA 0x20EEDC0
public static bool CapsulesIntersect(FPVector2 capsule1PointA, FPVector2 capsule1PointB, FP capsule1Radius, FPVector2 capsule2PointA, FPVector2 capsule2PointB, FP capsule2Radius)   // RVA 0x20EDE60
public static FPVector2 ClampVector(FPVector2 vector, FP length)   // RVA 0x20EDED0
private static FP LineDistance(FPVector2 a0, FPVector2 a1, FPVector2 b0, FPVector2 b1)   // RVA 0x20EE5B0
public static FP LineToPointDistance(FPVector2 a0, FPVector2 b0, FPVector2 b1)   // RVA 0x20EE9D0
public static FP PointToPointDistance(FPVector2 a0, FPVector2 b0)   // RVA 0x20EEF60
public static bool IntersectsExclusive(FPVector2 topLeft, FPVector2 bottomRight, FPVector2 point)   // RVA 0x20EE2D0
public static bool IsPowerOfTwo(int num)   // RVA 0x20EE5A0
public static int FindSetBitPosition(int num)   // RVA 0x20EE060
```

### Quantum.PhysicsUtils  (bases: ; TypeDefIndex 10693)
Methods:
```
public static int LayerFromIndex(int layerIndex)   // RVA 0x210C010
public static int LayerMaskFromCollisionLayersGroup(CollisionLayer[] layersGroup)   // RVA 0x210C020
public static bool IsLayerIndexInCollisionLayersGroup(int layerIndex, CollisionLayer[] layersGroup)   // RVA 0x210BE30
public static bool IsThinPlatformLayer(Frame frame, int layerIndex)   // RVA 0x210BEB0
public static int GetFloorLayerMask(Frame frame, bool ignoreThinPlatforms)   // RVA 0x210BC90
public static int GetDefaultLayerMask(Frame frame)   // RVA 0x210BC10
public static bool LinecastIntersectsSurface(FPVector2 hitPoint, FPVector2 endPoint, FPVector2 surfaceNormal)   // RVA 0x210C090
public static bool IsValidGround(FPVector2 groundNormal, PhysicsData physicsData)   // RVA 0x210BF50
public static bool IsGoingDownSlope(FP xVelocitySign, FPVector2 groundNormal)   // RVA 0x210BD90
public static bool IsGoingUpSlope(FP xVelocitySign, FPVector2 groundNormal)   // RVA 0x210BDE0
public static bool IsValidWall(FPVector2 wallNormal, PhysicsData physicsData, bool WallJumpCheck = False)   // RVA 0x210BFA0
public static bool IsValidWall(FPVector2 wallNormal, FP minWallNormal)   // RVA 0x210BF80
public static FPVector2 CalculateSurfaceSlideVector(FPVector2 surfaceNormal, FPVector2 slideDirection)   // RVA 0x210BAF0
public static bool TryGetCollisionLayer(Frame frame, EntityRef entity, out int layer)   // RVA 0x210C3B0
public static bool TryGetCollisionLayer(Frame frame, Nullable<Hit> hit, out int layer)   // RVA 0x210C210
public static bool TryGetPhysicsMaterial(Frame frame, EntityRef entity, out AssetRefPhysicsMaterial physicsMaterial)   // RVA 0x210C400
public static FPVector2 RelativeMovement(FPVector2 currentPosition, FPVector2 previousPosition)   // RVA 0x210C1E0
public static bool CirclesIntersect(FPVector2 centerA, FP radiusA, FPVector2 centerB, FP radiusB)   // RVA 0x210BB80
public static bool PointInPolygon(FPVector2 point, FPVector2[] vertices)   // RVA 0x210C0F0
public static FP GetCombinedPhysicsValue(FP physicsValueA, FP physicsValueB, PhysicsCombineFunction combineFunction)   // RVA 0x210BBC0
```

### Quantum.SpawnUtils  (bases: ; TypeDefIndex 10694)
Methods:
```
public static EntityRef SpawnCharacter(Frame frame, CharacterSpawnData characterSpawnData, PlayerRef playerRef, FPVector2 spawnPosition, int facingDirection, bool startDisabled, int partnerCharacterIndex = 0, int npcIndex = 0)   // RVA 0x210E5A0
public static EntityRef SpawnEntity(Frame frame, GameEntityData gameEntityData, GameEntity* spawnerEntity, FPVector2 position, bool positionRelativeToSpawner, int costumeIndex)   // RVA 0x210EAE0
public static EntityRef SpawnEntity(Frame frame, GameEntityData gameEntityData, GameEntity* spawnerEntity, FPVector2 position, bool positionRelativeToSpawner, int costumeIndex, EntityVariable spawnedEntityIndexOutput)   // RVA 0x210EB20
public static EntityRef SpawnEntity(Frame frame, GameEntityData gameEntityData, FPVector2 position, int costumeIndex)   // RVA 0x210ED70
public static EntityRef SpawnNPC(Frame frame, CharacterSpawnData characterSpawnData, FPVector2 spawnPosition, int facingDirection, bool startDisabled, int npcID)   // RVA 0x210EE40
public static bool TryGetSpawnPoint(Frame frame, HashString spawnPointID, bool adjustedToFloor, out FPVector2 spawnPosition, out int facingDirection)   // RVA 0x210EFA0
public static bool TryGetSpawnPoint(Frame frame, HashString spawnPointID, int spawnOrder, bool adjustedToFloor, out FPVector2 spawnPosition, out int facingDirection)   // RVA 0x210F080
```

### Quantum.Utils  (bases: ; TypeDefIndex 10695)
Methods:
```
public static bool SystemsEnabled(Frame frame)   // RVA 0x2114790
public static void PrintError(Frame frame, string errorMessage)   // RVA 0x21144F0
public static void PrintCustomLogMessage(Frame frame, string message)   // RVA 0x21144C0
```

### Quantum.SpeedRunners.Classes.CampaignUtils  (bases: ; TypeDefIndex 10696)
Methods:
```
public static void PlayCampaignDialogue(Frame frame, SpeedRunnersBaseGameMode mode, bool hasDialogue, GameSpeedModifier DialogueSpeedModifier)   // RVA 0x20FDDE0
```

### Quantum.Core.DebugCommand  (bases: ; TypeDefIndex 10698)
Methods:
```
internal static DeterministicCommand CreateCommand()   // RVA 0x2102950
```

### Quantum.Prototypes.AttackVictimDirection_Prototype  (bases: ; TypeDefIndex 10705)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static AttackVictimDirection op_Implicit(AttackVictimDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.BossFightState_Prototype  (bases: ; TypeDefIndex 10706)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static BossFightState op_Implicit(BossFightState_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.CombatInteractionPolicy_Prototype  (bases: ; TypeDefIndex 10707)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static CombatInteractionPolicy op_Implicit(CombatInteractionPolicy_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.Difficulties_Prototype  (bases: ; TypeDefIndex 10708)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static Difficulties op_Implicit(Difficulties_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.ECBOffsetOperation_Prototype  (bases: ; TypeDefIndex 10709)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static ECBOffsetOperation op_Implicit(ECBOffsetOperation_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.EdgeGrabCondition_Prototype  (bases: ; TypeDefIndex 10710)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static EdgeGrabCondition op_Implicit(EdgeGrabCondition_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.EdgeSide_Prototype  (bases: ; TypeDefIndex 10711)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static EdgeSide op_Implicit(EdgeSide_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.GameEntityType_Prototype  (bases: ; TypeDefIndex 10712)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static GameEntityType op_Implicit(GameEntityType_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.GrabDirection_Prototype  (bases: ; TypeDefIndex 10713)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static GrabDirection op_Implicit(GrabDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.GrabMode_Prototype  (bases: ; TypeDefIndex 10714)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static GrabMode op_Implicit(GrabMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.GrabState_Prototype  (bases: ; TypeDefIndex 10715)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static GrabState op_Implicit(GrabState_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.GrabbedAction_Prototype  (bases: ; TypeDefIndex 10716)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static GrabbedAction op_Implicit(GrabbedAction_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.HazardSpawnDirection_Prototype  (bases: ; TypeDefIndex 10717)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static HazardSpawnDirection op_Implicit(HazardSpawnDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.HitBoxPriority_Prototype  (bases: ; TypeDefIndex 10718)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static HitBoxPriority op_Implicit(HitBoxPriority_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.HitBoxSpecialBehaviour_Prototype  (bases: ; TypeDefIndex 10719)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static HitBoxSpecialBehaviour op_Implicit(HitBoxSpecialBehaviour_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.HitBoxType_Prototype  (bases: ; TypeDefIndex 10720)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static HitBoxType op_Implicit(HitBoxType_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.HitType_Prototype  (bases: ; TypeDefIndex 10721)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static HitType op_Implicit(HitType_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.InitialWaitTimerState_Prototype  (bases: ; TypeDefIndex 10722)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static InitialWaitTimerState op_Implicit(InitialWaitTimerState_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.InputFlag_Prototype  (bases: ; TypeDefIndex 10723)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static InputFlag op_Implicit(InputFlag_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.ItemButtonUseMode_Prototype  (bases: ; TypeDefIndex 10724)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static ItemButtonUseMode op_Implicit(ItemButtonUseMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.JumpType_Prototype  (bases: ; TypeDefIndex 10725)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static JumpType op_Implicit(JumpType_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.LaserDirection_Prototype  (bases: ; TypeDefIndex 10726)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static LaserDirection op_Implicit(LaserDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.LoopMode_Prototype  (bases: ; TypeDefIndex 10727)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static LoopMode op_Implicit(LoopMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.PlatformFightState_Prototype  (bases: ; TypeDefIndex 10728)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static PlatformFightState op_Implicit(PlatformFightState_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.RaceState_Prototype  (bases: ; TypeDefIndex 10729)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static RaceState op_Implicit(RaceState_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.RespawnDirection_Prototype  (bases: ; TypeDefIndex 10730)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static RespawnDirection op_Implicit(RespawnDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.RunningDirection_Prototype  (bases: ; TypeDefIndex 10731)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static RunningDirection op_Implicit(RunningDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.SimpleLineEndRotationMode_Prototype  (bases: ; TypeDefIndex 10732)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static SimpleLineEndRotationMode op_Implicit(SimpleLineEndRotationMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.SlideDirection_Prototype  (bases: ; TypeDefIndex 10733)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static SlideDirection op_Implicit(SlideDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.SpawnPointDirection_Prototype  (bases: ; TypeDefIndex 10734)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static SpawnPointDirection op_Implicit(SpawnPointDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.SpikeDirection_Prototype  (bases: ; TypeDefIndex 10735)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static SpikeDirection op_Implicit(SpikeDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.StageExecutionMode_Prototype  (bases: ; TypeDefIndex 10736)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static StageExecutionMode op_Implicit(StageExecutionMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.StateGroupExecutionMode_Prototype  (bases: ; TypeDefIndex 10737)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static StateGroupExecutionMode op_Implicit(StateGroupExecutionMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.StatusEffectModifierOperation_Prototype  (bases: ; TypeDefIndex 10738)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static StatusEffectModifierOperation op_Implicit(StatusEffectModifierOperation_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.SuperBoostDirection_Prototype  (bases: ; TypeDefIndex 10739)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static SuperBoostDirection op_Implicit(SuperBoostDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.TargetSlot_Prototype  (bases: ; TypeDefIndex 10740)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static TargetSlot op_Implicit(TargetSlot_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.TrapDoorSwitchActivationMode_Prototype  (bases: ; TypeDefIndex 10741)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static TrapDoorSwitchActivationMode op_Implicit(TrapDoorSwitchActivationMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.VelocityModifierCondition_Prototype  (bases: ; TypeDefIndex 10742)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static VelocityModifierCondition op_Implicit(VelocityModifierCondition_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.VelocityOperation_Prototype  (bases: ; TypeDefIndex 10743)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static VelocityOperation op_Implicit(VelocityOperation_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.VelocityType_Prototype  (bases: ; TypeDefIndex 10744)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static VelocityType op_Implicit(VelocityType_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.VolumeDirection_Prototype  (bases: ; TypeDefIndex 10745)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static VolumeDirection op_Implicit(VolumeDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.VolumeMode_Prototype  (bases: ; TypeDefIndex 10746)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static VolumeMode op_Implicit(VolumeMode_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.VolumeType_Prototype  (bases: ; TypeDefIndex 10747)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static VolumeType op_Implicit(VolumeType_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.WallSnapDirection_Prototype  (bases: ; TypeDefIndex 10748)
Fields:
```
public int Value;  // 0x0
```
Methods:
```
public static WallSnapDirection op_Implicit(WallSnapDirection_Prototype value)   // RVA 0x93A660
```

### Quantum.Prototypes.DictionaryEntry_Int32_CustomSubAnimatorPlayableClipInfo_Prototype  (bases: DictionaryEntryPrototype; TypeDefIndex 10749)
Fields:
```
public int Key;  // 0x10
public CustomSubAnimatorPlayableClipInfo_Prototype Value;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.DictionaryEntry_Int32_MoveLimit_Prototype  (bases: DictionaryEntryPrototype; TypeDefIndex 10750)
Fields:
```
public int Key;  // 0x10
public MoveLimit_Prototype Value;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.DictionaryEntry_QString128_FP_Prototype  (bases: DictionaryEntryPrototype; TypeDefIndex 10751)
Fields:
```
public string Key;  // 0x10
public FP Value;  // 0x18
```
Methods:
```
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.AIVolume_Prototype  (bases: ComponentPrototype<AIVolume>; TypeDefIndex 10752)
Fields:
```
public QBoolean PreventDestroyOnStart;  // 0x18
public QBoolean Disabled;  // 0x1C
public MapEntityId Entity;  // 0x20
public VolumeType_Prototype VolumeType;  // 0x24
public VolumeMode_Prototype VolumeMode;  // 0x28
public int Frames;  // 0x2C
public int FrameDelay;  // 0x30
public QBoolean Temporary;  // 0x34
public Difficulties_Prototype VolumeDifficulty;  // 0x38
public int EasyChance;  // 0x3C
public int NormalChance;  // 0x40
public int HardChance;  // 0x44
public int UnfairChance;  // 0x48
public MapEntityId[] ConditionalEntities;  // 0x50
public QBoolean ConditionalState;  // 0x58
public QBoolean NeedsBoost;  // 0x5C
public int BoostAmount;  // 0x60
public QBoolean NeedsItem;  // 0x64
public QString64 ItemID;  // 0x68
public QBoolean Directional;  // 0xA8
public VolumeDirection_Prototype VolumeDirection;  // 0xAC
```
Methods:
```
public void Materialize(Frame frame, ref AIVolume result, in PrototypeMaterializationContext context)   // RVA 0x20FC4C0
public void .ctor()   // RVA 0x20FC700
```

### Quantum.Prototypes.ActionData_Prototype  (bases: StructPrototype; TypeDefIndex 10753)
Fields:
```
public InputFlag_Prototype Flag;  // 0x10
public FP Frames;  // 0x18
public QBoolean Overriden;  // 0x20
public FP FrameDelay;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref ActionData result, in PrototypeMaterializationContext context)   // RVA 0x20FC770
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.AnimationSpeedElement_Prototype  (bases: StructPrototype; TypeDefIndex 10754)
Fields:
```
public int Frame;  // 0x10
public FP Speed;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref AnimationSpeedElement result, in PrototypeMaterializationContext context)   // RVA 0x20FC790
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.BaseGameModeManager_Prototype  (bases: ComponentPrototype<BaseGameModeManager>; TypeDefIndex 10755)
Fields:
```
public QBoolean MatchEnded;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref BaseGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x20FC8E0
public void .ctor()   // RVA 0x20FC8F0
```

### Quantum.Prototypes.Blastzone_Prototype  (bases: ComponentPrototype<Blastzone>; TypeDefIndex 10756)
Fields:
```
public FPVector2 TopLeft;  // 0x18
public FPVector2 BottomRight;  // 0x28
public QBoolean TriggerEnabled;  // 0x38
```
Methods:
```
public void Materialize(Frame frame, ref Blastzone result, in PrototypeMaterializationContext context)   // RVA 0x20FCC70
public void .ctor()   // RVA 0x20FCC90
```

### Quantum.Prototypes.BlastzoneTrigger_Prototype  (bases: ComponentPrototype<BlastzoneTrigger>; TypeDefIndex 10757)
Fields:
```
public MapEntityId RespawnPoint;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref BlastzoneTrigger result, in PrototypeMaterializationContext context)   // RVA 0x20FCA90
public void .ctor()   // RVA 0x20FCAA0
```

### Quantum.Prototypes.BossFightGameModeManager_Prototype  (bases: ComponentPrototype<BossFightGameModeManager>; TypeDefIndex 10758)
Fields:
```
public BossFightState_Prototype CurrentState;  // 0x18
public FP CurrentCountdown;  // 0x20
public FP CurrentMatchTimer;  // 0x28
public QBoolean IsDialogue;  // 0x30
public QBoolean HasDialogue;  // 0x34
public QBoolean StartedTimer;  // 0x38
public FP PlayerStaminaBeforeHit;  // 0x40
```
Methods:
```
public void Materialize(Frame frame, ref BossFightGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x20FCE50
public void .ctor()   // RVA 0x20FCE90
```

### Quantum.Prototypes.BreakableGlass_Prototype  (bases: ComponentPrototype<BreakableGlass>; TypeDefIndex 10759)
Fields:
```
public FP VelocityToBreak;  // 0x18
public QBoolean IsRestorable;  // 0x20
public int FramesToRestore;  // 0x24
public QString64 GoalOnBreak;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref BreakableGlass result, in PrototypeMaterializationContext context)   // RVA 0x20FD080
public void .ctor()   // RVA 0x20FD0C0
```

### Quantum.Prototypes.ButtonTimersContainer_Prototype  (bases: StructPrototype; TypeDefIndex 10760)
Fields:
```
public InputTimer_Prototype[] InputButtonTimers;  // 0x10
public InputTimer_Prototype[] InputDirectionTimers;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref ButtonTimersContainer result, in PrototypeMaterializationContext context)   // RVA 0x20FD100
public void .ctor()   // RVA 0x20FD260
```

### Quantum.Prototypes.CameraManager_Prototype  (bases: ComponentPrototype<CameraManager>; TypeDefIndex 10761)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public QBoolean ExcludeAsVisibilitySource;  // 0x20
public AssetRefCameraManagerData CameraManagerData;  // 0x28
public AssetRefGlobalCameraSettingsData GlobalSettingsData;  // 0x30
public SimpleAABB_Prototype CameraRect;  // 0x38
public FP Zoom;  // 0x40
public FPVector2 LookAhead;  // 0x48
```
Methods:
```
public void Materialize(Frame frame, ref CameraManager result, in PrototypeMaterializationContext context)   // RVA 0x20FD4E0
public void .ctor()   // RVA 0x20FD560
```

### Quantum.Prototypes.CameraTarget_Prototype  (bases: ComponentPrototype<CameraTarget>; TypeDefIndex 10762)
Fields:
```
public QBoolean Active;  // 0x18
public QBoolean Visible;  // 0x1C
public MapEntityId Entity;  // 0x20
public SimpleAABB_Prototype BaseFocusRect;  // 0x28
public SimpleAABB_Prototype FocusRect;  // 0x30
public FP Scale;  // 0x38
public QBoolean InterpolatePosition;  // 0x40
public FP VerticalOffset;  // 0x48
public FP ForwardDistance;  // 0x50
public FP ForwardInterpolationSpeed;  // 0x58
public int[] ViewerIndexes;  // 0x60
```
Methods:
```
public void Materialize(Frame frame, ref CameraTarget result, in PrototypeMaterializationContext context)   // RVA 0x20FD7B0
public void .ctor()   // RVA 0x20FD9C0
```

### Quantum.Prototypes.CampaignBoss_Prototype  (bases: ComponentPrototype<CampaignBoss>; TypeDefIndex 10763)
Fields:
```
public QString64 BossID;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref CampaignBoss result, in PrototypeMaterializationContext context)   // RVA 0x20FDB90
public void .ctor()   // RVA 0x20FDBC0
```

### Quantum.Prototypes.CampaignRaceGameModeManager_Prototype  (bases: ComponentPrototype<CampaignRaceGameModeManager>; TypeDefIndex 10764)
Fields:
```
public QBoolean MatchCompleted;  // 0x18
public QBoolean HasDialogue;  // 0x1C
public QBoolean StartedTimer;  // 0x20
public FP CurrentMatchTimer;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref CampaignRaceGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x20FDD80
public void .ctor()   // RVA 0x20FDDA0
```

### Quantum.Prototypes.Checkpoint_Prototype  (bases: ComponentPrototype<Checkpoint>; TypeDefIndex 10765)
Fields:
```
public QBoolean Active;  // 0x18
public QBoolean StartPoint;  // 0x1C
public FP DistanceToFinish;  // 0x20
public MapEntityId RespawnPoint;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref Checkpoint result, in PrototypeMaterializationContext context)   // RVA 0x20FE750
public void .ctor()   // RVA 0x20FE7A0
```

### Quantum.Prototypes.CheckpointManager_Prototype  (bases: ComponentPrototype<CheckpointManager>; TypeDefIndex 10766)
Fields:
```
public MapEntityId[] CheckpointList;  // 0x18
public MapEntityId CurrentWinningPlayer;  // 0x20
public MapEntityId[] Ranking;  // 0x28
public FP TotalLapDistance;  // 0x30
public MapEntityId LastRespawnPoint;  // 0x38
public int LastSpawnDirection;  // 0x3C
```
Methods:
```
public void Materialize(Frame frame, ref CheckpointManager result, in PrototypeMaterializationContext context)   // RVA 0x20FE1F0
public void .ctor()   // RVA 0x20FE530
```

### Quantum.Prototypes.ChildEntity_Prototype  (bases: StructPrototype; TypeDefIndex 10767)
Fields:
```
public MapEntityId Entity;  // 0x10
public FPVector2 InitialPosition;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref ChildEntity result, in PrototypeMaterializationContext context)   // RVA 0x20FE7E0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.CollectorCharacter_Prototype  (bases: ComponentPrototype<CollectorCharacter>; TypeDefIndex 10768)
Fields:
```
public MapEntityId Entity;  // 0x18
public int Score;  // 0x1C
```
Methods:
```
public void Materialize(Frame frame, ref CollectorCharacter result, in PrototypeMaterializationContext context)   // RVA 0x20FE990
public void .ctor()   // RVA 0x20FE9D0
```

### Quantum.Prototypes.CollectorTreasure_Prototype  (bases: ComponentPrototype<CollectorTreasure>; TypeDefIndex 10769)
Fields:
```
public int Value;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref CollectorTreasure result, in PrototypeMaterializationContext context)   // RVA 0x20FC8E0
public void .ctor()   // RVA 0x20FEB50
```

### Quantum.Prototypes.CollectorsGameModeManager_Prototype  (bases: ComponentPrototype<CollectorsGameModeManager>; TypeDefIndex 10770)
Fields:
```
public QBoolean MatchFinished;  // 0x18
public FP RemainingMatchTime;  // 0x20
public FP NextTreasureSpawnTimer;  // 0x28
public int[] SpawnAreasUsed;  // 0x30
```
Methods:
```
public void Materialize(Frame frame, ref CollectorsGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x20FEE70
public void .ctor()   // RVA 0x20FEFE0
```

### Quantum.Prototypes.CollectorsTreasureSpawnArea_Prototype  (bases: ComponentPrototype<CollectorsTreasureSpawnArea>; TypeDefIndex 10771)
Fields:
```
public FPVector2 TopLeft;  // 0x18
public FPVector2 BottomRight;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref CollectorsTreasureSpawnArea result, in PrototypeMaterializationContext context)   // RVA 0x20FF1B0
public void .ctor()   // RVA 0x20FF1D0
```

### Quantum.Prototypes.Combat_Prototype  (bases: ComponentPrototype<Combat>; TypeDefIndex 10772)
Fields:
```
public QBoolean Active;  // 0x18
public MapEntityId Entity;  // 0x1C
public AssetRefCombatData CombatData;  // 0x20
public EntityHitFilter_Prototype HitFilter;  // 0x28
public MapEntityId[] EntitiesHit;  // 0x30
public HitBox_Prototype[] HitBoxes;  // 0x38
public HurtBox_Prototype[] HurtBoxes;  // 0x40
public QBoolean KnockedOut;  // 0x48
public QBoolean IsDown;  // 0x4C
public FP HitLagFrames;  // 0x50
public FP HitStunFrames;  // 0x58
public FP WeightForKnockback;  // 0x60
public HitInfo_Prototype LastInflictedHit;  // 0x68
public HitInfo_Prototype LastReceivedHit;  // 0x70
public SimpleAABB_Prototype RedirectAndReflectRect;  // 0x78
public SimpleAABB_Prototype HitBoxesRect;  // 0x80
public SimpleAABB_Prototype HurtBoxesRect;  // 0x88
public QBoolean IsIntangible;  // 0x90
public FP IntangibilityFrames;  // 0x98
public QBoolean IsInvincible;  // 0xA0
public FP InvincibilityFrames;  // 0xA8
public QBoolean RedirectedByAnything;  // 0xB0
public QBoolean CanBeRedirected;  // 0xB4
public QBoolean CanBeReflected;  // 0xB8
public MapEntityId LastRedirector;  // 0xBC
public MapEntityId LastReflector;  // 0xC0
public FP RedirectAngle;  // 0xC8
public MapEntityId OwnerOverride;  // 0xD0
public QBoolean AffectedByFlinchlessHits;  // 0xD4
public int HitlagFramesOverride;  // 0xD8
```
Methods:
```
public void Materialize(Frame frame, ref Combat result, in PrototypeMaterializationContext context)   // RVA 0x2100610
public void .ctor()   // RVA 0x2100F50
```

### Quantum.Prototypes.CombatArmor_Prototype  (bases: ComponentPrototype<CombatArmor>; TypeDefIndex 10773)
Fields:
```
public MapEntityId Entity;  // 0x18
public FP Armor;  // 0x20
public QBoolean SuperArmor;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref CombatArmor result, in PrototypeMaterializationContext context)   // RVA 0x20FF390
public void .ctor()   // RVA 0x20FF3D0
```

### Quantum.Prototypes.CombatBlock_Prototype  (bases: ComponentPrototype<CombatBlock>; TypeDefIndex 10774)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Blocking;  // 0x1C
public FP BlockFrames;  // 0x20
public FP BlockStamina;  // 0x28
public FP PerfectBlockLockFrames;  // 0x30
public FP PerfectBlockBufferFrames;  // 0x38
```
Methods:
```
public void Materialize(Frame frame, ref CombatBlock result, in PrototypeMaterializationContext context)   // RVA 0x20FF5D0
public void .ctor()   // RVA 0x20FF630
```

### Quantum.Prototypes.CombatCharge_Prototype  (bases: ComponentPrototype<CombatCharge>; TypeDefIndex 10775)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean UseChargeMultiplier;  // 0x1C
public int ChargeAttackMultiplierID;  // 0x20
public FP ChargeAttackPower;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref CombatCharge result, in PrototypeMaterializationContext context)   // RVA 0x20FF800
public void .ctor()   // RVA 0x20FF850
```

### Quantum.Prototypes.CombatDI_Prototype  (bases: ComponentPrototype<CombatDI>; TypeDefIndex 10776)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean CalculateDI;  // 0x1C
public FP DIAngle;  // 0x20
public FPVector2 SDI;  // 0x28
public int TriggeredSDIs;  // 0x38
```
Methods:
```
public void Materialize(Frame frame, ref CombatDI result, in PrototypeMaterializationContext context)   // RVA 0x20FFA40
public void .ctor()   // RVA 0x20FFA90
```

### Quantum.Prototypes.CombatDamage_Prototype  (bases: ComponentPrototype<CombatDamage>; TypeDefIndex 10777)
Fields:
```
public FP Damage;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref CombatDamage result, in PrototypeMaterializationContext context)   // RVA 0x20FFC10
public void .ctor()   // RVA 0x20FFC20
```

### Quantum.Prototypes.CombatPoints_Prototype  (bases: ComponentPrototype<CombatPoints>; TypeDefIndex 10778)
Fields:
```
public int Points;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref CombatPoints result, in PrototypeMaterializationContext context)   // RVA 0x20FC8E0
public void .ctor()   // RVA 0x20FFDA0
```

### Quantum.Prototypes.CombatStamina_Prototype  (bases: ComponentPrototype<CombatStamina>; TypeDefIndex 10779)
Fields:
```
public FP Stamina;  // 0x18
public FP ExtraDamageForKnockback;  // 0x20
public FP ExtraDamageForKnockbackFrames;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref CombatStamina result, in PrototypeMaterializationContext context)   // RVA 0x20FFF40
public void .ctor()   // RVA 0x20FFF60
```

### Quantum.Prototypes.CombatStocks_Prototype  (bases: ComponentPrototype<CombatStocks>; TypeDefIndex 10780)
Fields:
```
public int Stocks;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref CombatStocks result, in PrototypeMaterializationContext context)   // RVA 0x20FC8E0
public void .ctor()   // RVA 0x21000E0
```

### Quantum.Prototypes.CombatTech_Prototype  (bases: ComponentPrototype<CombatTech>; TypeDefIndex 10781)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean DetectTechLock;  // 0x1C
public FP TechLockFrames;  // 0x20
public FP TechBufferFrames;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref CombatTech result, in PrototypeMaterializationContext context)   // RVA 0x21002B0
public void .ctor()   // RVA 0x2100300
```

### Quantum.Prototypes.ContinuousRotation_Prototype  (bases: ComponentPrototype<ContinuousRotation>; TypeDefIndex 10782)
Fields:
```
public QBoolean Active;  // 0x18
public FP InitialRotation;  // 0x20
public FP RotationSpeed;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref ContinuousRotation result, in PrototypeMaterializationContext context)   // RVA 0x2101180
public void .ctor()   // RVA 0x21011A0
```

### Quantum.Prototypes.CustomAnimator_Prototype  (bases: ComponentPrototype<CustomAnimator>; TypeDefIndex 10783)
Fields:
```
public QBoolean Active;  // 0x18
public MapEntityId Entity;  // 0x1C
public AssetRefAnimationsPoolData AnimationsPool;  // 0x20
public AssetRefAnimationBakedJointsData BakedJointsData;  // 0x28
public int HighestWeightClipIndex;  // 0x30
public FP HighestWeightClipTime;  // 0x38
public CustomAnimatorPlayableClipInfo_Prototype[] CurrentClips;  // 0x40
public CustomAnimatorPlayableClipInfo_Prototype[] PreviousClips;  // 0x48
public FP TransitionDuration;  // 0x50
public FP TransitionTime;  // 0x58
public QBoolean Blend1DActive;  // 0x60
public QBoolean Blend2DActive;  // 0x64
public FP CurrentBlendX;  // 0x68
public FP CurrentBlendY;  // 0x70
public FP Speed;  // 0x78
public AnimationSpeedElement_Prototype[] CurrentSpeedData0;  // 0x80
public AnimationSpeedElement_Prototype[] CurrentSpeedData1;  // 0x88
public AnimationSpeedElement_Prototype[] CurrentSpeedData2;  // 0x90
public AnimationSpeedElement_Prototype[] CurrentSpeedData3;  // 0x98
public AnimationSpeedElement_Prototype[] CurrentSpeedData4;  // 0xA0
public AnimationSpeedElement_Prototype[] PreviousSpeedData0;  // 0xA8
public AnimationSpeedElement_Prototype[] PreviousSpeedData1;  // 0xB0
public AnimationSpeedElement_Prototype[] PreviousSpeedData2;  // 0xB8
public AnimationSpeedElement_Prototype[] PreviousSpeedData3;  // 0xC0
public AnimationSpeedElement_Prototype[] PreviousSpeedData4;  // 0xC8
public DictionaryEntry_Int32_CustomSubAnimatorPlayableClipInfo_Prototype[] SubAnimatorClip;  // 0xD0
```
Methods:
```
public void Materialize(Frame frame, ref CustomAnimator result, in PrototypeMaterializationContext context)   // RVA 0x2101610
public void .ctor()   // RVA 0x2102680
```

### Quantum.Prototypes.CustomAnimatorPlayableClipInfo_Prototype  (bases: StructPrototype; TypeDefIndex 10784)
Fields:
```
public int ClipIndex;  // 0x10
public FP Time;  // 0x18
public FP RuntimeWeight;  // 0x20
public FP Speed;  // 0x28
public QBoolean TriggeredEndEvent;  // 0x30
public int GroupHash;  // 0x34
public StateGroupExecutionMode_Prototype GroupExecutionMode;  // 0x38
public FP StartTime;  // 0x40
public FP EndTime;  // 0x48
public QBoolean IsLooping;  // 0x50
public FP Weight;  // 0x58
```
Methods:
```
public void Materialize(Frame frame, ref CustomAnimatorPlayableClipInfo result, in PrototypeMaterializationContext context)   // RVA 0x21012F0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.CustomSubAnimatorPlayableClipInfo_Prototype  (bases: StructPrototype; TypeDefIndex 10785)
Fields:
```
public CustomAnimatorPlayableClipInfo_Prototype ClipInfo;  // 0x10
```
Methods:
```
public void Materialize(Frame frame, ref CustomSubAnimatorPlayableClipInfo result, in PrototypeMaterializationContext context)   // RVA 0x21028B0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.DamageOverride_Prototype  (bases: StructPrototype; TypeDefIndex 10786)
Fields:
```
public QBoolean UseSetDamageFromEnemy;  // 0x10
public int EnemySetDamage;  // 0x14
public QBoolean UseSetDamageFromOwner;  // 0x18
public int OwnerSetDamage;  // 0x1C
public QBoolean UseSetDamageFromTeam;  // 0x20
public int TeamSetDamage;  // 0x24
```
Methods:
```
public void Materialize(Frame frame, ref DamageOverride result, in PrototypeMaterializationContext context)   // RVA 0x2102920
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.DestroyEntitiesManager_Prototype  (bases: ComponentPrototype<DestroyEntitiesManager>; TypeDefIndex 10787)
Fields:
```
public MapEntityId[] EntitiesToDestroy;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref DestroyEntitiesManager result, in PrototypeMaterializationContext context)   // RVA 0x2102C70
public void .ctor()   // RVA 0x2102E00
```

### Quantum.Prototypes.DynamicStageElement_Prototype  (bases: ComponentPrototype<DynamicStageElement>; TypeDefIndex 10788)
Fields:
```
public QBoolean Active;  // 0x18
public LoopMode_Prototype LoopMode;  // 0x1C
public QBoolean BackwardsMode;  // 0x20
public FP CurrentFrame;  // 0x28
public AssetRefTransformKeyFramesData TransformKeyFramesData;  // 0x30
```
Methods:
```
public void Materialize(Frame frame, ref DynamicStageElement result, in PrototypeMaterializationContext context)   // RVA 0x2103000
public void .ctor()   // RVA 0x2103030
```

### Quantum.Prototypes.EdgeGrab_Prototype  (bases: ComponentPrototype<EdgeGrab>; TypeDefIndex 10789)
Fields:
```
public QBoolean Active;  // 0x18
public MapEntityId Entity;  // 0x1C
public MapEntityId EdgeEntity;  // 0x20
public FP EdgeGrabCooldown;  // 0x28
public EdgeGrabCondition_Prototype EdgeGrabCondition;  // 0x30
public FP GrabConditionVelocity;  // 0x38
public FPVector2 EdgeHook;  // 0x40
public QBoolean Interpolate;  // 0x50
public SimpleAABB_Prototype CurrentRect;  // 0x58
public SimpleAABB_Prototype PreviousRect;  // 0x60
```
Methods:
```
public void Materialize(Frame frame, ref EdgeGrab result, in PrototypeMaterializationContext context)   // RVA 0x21032E0
public void .ctor()   // RVA 0x21033A0
```

### Quantum.Prototypes.EndlessGameModeManager_Prototype  (bases: ComponentPrototype<EndlessGameModeManager>; TypeDefIndex 10790)
Fields:
```
public FP DistanceRunned;  // 0x18
public FP SpawnedPlataforms;  // 0x20
public FP RandomPlataformIndex;  // 0x28
public MapEntityId[] Plataforms;  // 0x30
public QBoolean HasDialogue;  // 0x38
```
Methods:
```
public void Materialize(Frame frame, ref EndlessGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x21036E0
public void .ctor()   // RVA 0x2103880
```

### Quantum.Prototypes.EnergyBar_Prototype  (bases: ComponentPrototype<EnergyBar>; TypeDefIndex 10791)
Fields:
```
public FP CurrentEnergy;  // 0x18
public FP MaxEnergy;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref EnergyBar result, in PrototypeMaterializationContext context)   // RVA 0x2103A40
public void .ctor()   // RVA 0x2103A50
```

### Quantum.Prototypes.EntityHitFilter_Prototype  (bases: StructPrototype; TypeDefIndex 10792)
Fields:
```
public QBoolean DamagedByOwner;  // 0x10
public QBoolean DamageOwner;  // 0x14
public QBoolean AlwaysIfTeam;  // 0x18
public QBoolean IsAlwaysEnemy;  // 0x1C
public QBoolean IgnoreEnemy;  // 0x20
public DamageOverride_Prototype DamageOverrideInfo;  // 0x28
public CombatInteractionPolicy_Prototype CharacterInteractionPolicy;  // 0x30
public CombatInteractionPolicy_Prototype ProjectileInteractionPolicy;  // 0x34
public CombatInteractionPolicy_Prototype ItemInteractionPolicy;  // 0x38
public CombatInteractionPolicy_Prototype HazardInteractionPolicy;  // 0x3C
public CombatInteractionPolicy_Prototype StageInteractionPolicy;  // 0x40
public CombatInteractionPolicy_Prototype SameOwnerInteractionPolicy;  // 0x44
```
Methods:
```
public void Materialize(Frame frame, ref EntityHitFilter result, in PrototypeMaterializationContext context)   // RVA 0x2103A90
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.EntityModifier_Prototype  (bases: ComponentPrototype<EntityModifier>; TypeDefIndex 10793)
Fields:
```
public MapEntityId Entity;  // 0x18
public EntityModifierInfo_Prototype ModifierInfo;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref EntityModifier result, in PrototypeMaterializationContext context)   // RVA 0x2104200
public void .ctor()   // RVA 0x2104250
```

### Quantum.Prototypes.EntityModifierInfo_Prototype  (bases: StructPrototype; TypeDefIndex 10794)
Fields:
```
public FP SpeedMultiplier;  // 0x10
public FP ScaleMultiplier;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref EntityModifierInfo result, in PrototypeMaterializationContext context)   // RVA 0x2103B20
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.EntityModifierTarget_Prototype  (bases: ComponentPrototype<EntityModifierTarget>; TypeDefIndex 10795)
Fields:
```
public MapEntityId Entity;  // 0x18
public MapEntityId[] EntityModifiers;  // 0x20
public MapEntityId[] PhysicsModifiers;  // 0x28
public EntityModifierInfo_Prototype EntityModifier;  // 0x30
public PhysicsModifierInfo_Prototype PhysicsModifier;  // 0x38
```
Methods:
```
public void Materialize(Frame frame, ref EntityModifierTarget result, in PrototypeMaterializationContext context)   // RVA 0x2103CF0
public void .ctor()   // RVA 0x2103FE0
```

### Quantum.Prototypes.EntityReferencesHandler_Prototype  (bases: ComponentPrototype<EntityReferencesHandler>; TypeDefIndex 10796)
Fields:
```
public GameEntityReference_Prototype[] Entities;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref EntityReferencesHandler result, in PrototypeMaterializationContext context)   // RVA 0x21047F0
public void .ctor()   // RVA 0x2104A10
```

### Quantum.Prototypes.EnvironmentCollisionBox_Prototype  (bases: StructPrototype; TypeDefIndex 10797)
Fields:
```
public int PresetID;  // 0x10
public QBoolean RootAsBottom;  // 0x14
public FPVector2 CacheTop;  // 0x18
public FPVector2 CacheBottom;  // 0x28
public FPVector2 CacheLeft;  // 0x38
public FPVector2 CacheRight;  // 0x48
public FPVector2 Top;  // 0x58
public FPVector2 Bottom;  // 0x68
public FPVector2 Left;  // 0x78
public FPVector2 Right;  // 0x88
public RuntimeECBOffset_Prototype TopOffset;  // 0x98
public RuntimeECBOffset_Prototype BottomOffset;  // 0xA0
public RuntimeECBOffset_Prototype LeftOffset;  // 0xA8
public RuntimeECBOffset_Prototype RightOffset;  // 0xB0
public FPVector2 PreviousGlobalCenter;  // 0xB8
```
Methods:
```
public void Materialize(Frame frame, ref EnvironmentCollisionBox result, in PrototypeMaterializationContext context)   // RVA 0x2104A80
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.EscapeRoomGameModeManager_Prototype  (bases: ComponentPrototype<EscapeRoomGameModeManager>; TypeDefIndex 10798)
Fields:
```
public RaceState_Prototype CurrentState;  // 0x18
public FP CurrentCountdown;  // 0x20
public FP CurrentMatchTimer;  // 0x28
public QString64 CurrentCourseID;  // 0x30
public FP RemainingTimerFrames;  // 0x70
public FP TotalTimerFrames;  // 0x78
public QBoolean CourseCompleted;  // 0x80
public QBoolean HasDialogue;  // 0x84
public FP InitialDelayFrames;  // 0x88
```
Methods:
```
public void Materialize(Frame frame, ref EscapeRoomGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x2104DD0
public void .ctor()   // RVA 0x2104E40
```

### Quantum.Prototypes.EscapeRoomGoalTrigger_Prototype  (bases: ComponentPrototype<EscapeRoomGoalTrigger>; TypeDefIndex 10799)
Fields:
```
public QString64 GoalID;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref EscapeRoomGoalTrigger result, in PrototypeMaterializationContext context)   // RVA 0x20FDB90
public void .ctor()   // RVA 0x2104FE0
```

### Quantum.Prototypes.ExperienceEventData_Prototype  (bases: StructPrototype; TypeDefIndex 10800)
Fields:
```
public QString64 ID;  // 0x10
public int Count;  // 0x50
```
Methods:
```
public void Materialize(Frame frame, ref ExperienceEventData result, in PrototypeMaterializationContext context)   // RVA 0x2105020
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.FrameByFrame_Prototype  (bases: ComponentPrototype<FrameByFrame>; TypeDefIndex 10801)
Fields:
```
public QBoolean AdvancingFrame;  // 0x18
public FP AdvanceFrameDelta;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref FrameByFrame result, in PrototypeMaterializationContext context)   // RVA 0x21051B0
public void .ctor()   // RVA 0x21051C0
```

### Quantum.Prototypes.FrogmanBossTongue_Prototype  (bases: ComponentPrototype<FrogmanBossTongue>; TypeDefIndex 10802)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Hooked;  // 0x1C
public FPVector2 LastDirection;  // 0x20
public MapEntityId TargetEntity;  // 0x30
public FP FramesWithoutTarget;  // 0x38
public FP PullFramesCountdown;  // 0x40
```
Methods:
```
public void Materialize(Frame frame, ref FrogmanBossTongue result, in PrototypeMaterializationContext context)   // RVA 0x21053E0
public void .ctor()   // RVA 0x2105450
```

### Quantum.Prototypes.GameEntity_Prototype  (bases: ComponentPrototype<GameEntity>; TypeDefIndex 10803)
Fields:
```
public GameEntityType_Prototype EntityType;  // 0x18
public int ID;  // 0x1C
public MapEntityId Entity;  // 0x20
public AssetRefGameEntityData GameEntityData;  // 0x28
public MapEntityId Owner;  // 0x30
public MapEntityId OriginalOwner;  // 0x34
public MapEntityId LastSpawned;  // 0x38
public QBoolean Visible;  // 0x3C
public int CostumeIndex;  // 0x40
public int FacingDirection;  // 0x44
public FP SmoothRotationStart;  // 0x48
public FP Rotation;  // 0x50
public FP RootRotation;  // 0x58
public FP Scale;  // 0x60
public FPVector2 RotationPivot;  // 0x68
public ObjectVisibilityData_Prototype[] ObjectsVisibility;  // 0x78
public SlotAttachmentData_Prototype[] SlotAttachments;  // 0x80
public QBoolean UseTransform3D;  // 0x88
public FPVector3 Position3D;  // 0x90
public FPVector3 Rotation3D;  // 0xA8
public int ActiveEntityTint;  // 0xC0
public int ActiveGameplayTint;  // 0xC4
public int ActiveStatusTint;  // 0xC8
public int ActiveOverallTint;  // 0xCC
```
Methods:
```
public void Materialize(Frame frame, ref GameEntity result, in PrototypeMaterializationContext context)   // RVA 0x2105760
public void .ctor()   // RVA 0x2105B70
```

### Quantum.Prototypes.GameEntityReference_Prototype  (bases: StructPrototype; TypeDefIndex 10804)
Fields:
```
public MapEntityId Entity;  // 0x10
public QString64 OutputVariableID;  // 0x14
```
Methods:
```
public void Materialize(Frame frame, ref GameEntityReference result, in PrototypeMaterializationContext context)   // RVA 0x2105490
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.GameModeItemAutoTrigger_Prototype  (bases: ComponentPrototype<GameModeItemAutoTrigger>; TypeDefIndex 10805)
Fields:
```
public MapEntityId Entity;  // 0x18
public QString64 ItemToUse;  // 0x1C
```
Methods:
```
public void Materialize(Frame frame, ref GameModeItemAutoTrigger result, in PrototypeMaterializationContext context)   // RVA 0x2105DF0
public void .ctor()   // RVA 0x2105E40
```

### Quantum.Prototypes.GameTimeManager_Prototype  (bases: ComponentPrototype<GameTimeManager>; TypeDefIndex 10806)
Fields:
```
public FP GameSpeed;  // 0x18
public QBoolean Paused;  // 0x20
public RuntimeGameSpeedModifier_Prototype[] SpeedModifiers;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref GameTimeManager result, in PrototypeMaterializationContext context)   // RVA 0x2106180
public void .ctor()   // RVA 0x2106340
```

### Quantum.Prototypes.GoldenHook_Prototype  (bases: ComponentPrototype<GoldenHook>; TypeDefIndex 10807)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Hooked;  // 0x1C
public FPVector2 LastDirection;  // 0x20
public MapEntityId TargetEntity;  // 0x30
public FP FramesWithoutTarget;  // 0x38
public FP PullFramesCountdown;  // 0x40
```
Methods:
```
public void Materialize(Frame frame, ref GoldenHook result, in PrototypeMaterializationContext context)   // RVA 0x21053E0
public void .ctor()   // RVA 0x2106590
```

### Quantum.Prototypes.Grab_Prototype  (bases: ComponentPrototype<Grab>; TypeDefIndex 10808)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public AssetRefGrabData GrabData;  // 0x20
public GrabbedAction_Prototype GrabbedAction;  // 0x28
public GrabMode_Prototype GrabMode;  // 0x2C
public GrabDirection_Prototype GrabDirection;  // 0x30
public QBoolean CanBeGrabbed;  // 0x34
public QBoolean GrabbableOnlyByOwner;  // 0x38
public GrabState_Prototype GrabState;  // 0x3C
public QBoolean CanEscapeGrab;  // 0x40
public FP RemainingFramesToEscape;  // 0x48
public MapEntityId GrabbedEntity;  // 0x50
public MapEntityId GrabberEntity;  // 0x54
public int JointID;  // 0x58
public FPVector3 GrabJointPosition;  // 0x60
public FPVector3 GrabJointRotation;  // 0x78
public FPVector2 ThrowDirection;  // 0x90
public QBoolean StrongThrow;  // 0xA0
public QBoolean StrongUse;  // 0xA4
```
Methods:
```
public void Materialize(Frame frame, ref Grab result, in PrototypeMaterializationContext context)   // RVA 0x21068D0
public void .ctor()   // RVA 0x21069C0
```

### Quantum.Prototypes.HazardsRaceGameModeManager_Prototype  (bases: ComponentPrototype<HazardsRaceGameModeManager>; TypeDefIndex 10809)
Fields:
```
public FP CurrentHazardsTimer;  // 0x18
public FP HazardsWarningTimer;  // 0x20
public FP ItemSpawnCooldown;  // 0x28
public FP AmountOfHazardsToSpawn;  // 0x30
public HazardSpawnDirection_Prototype SpawnDirection;  // 0x38
public QBoolean HazardsWarningActive;  // 0x3C
public QBoolean SpawnDirectionSet;  // 0x40
public FP RandomHazardIndex;  // 0x48
public MapEntityId[] HazardSpawnAreaList;  // 0x50
```
Methods:
```
public void Materialize(Frame frame, ref HazardsRaceGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x2106D30
public void .ctor()   // RVA 0x2106EF0
```

### Quantum.Prototypes.HitBox_Prototype  (bases: StructPrototype; TypeDefIndex 10810)
Fields:
```
public QBoolean Active;  // 0x10
public HitBoxType_Prototype HitBoxType;  // 0x14
public HitBoxPriority_Prototype Priority;  // 0x18
public int ID;  // 0x1C
public int JointID;  // 0x20
public FPVector2 CachePoint;  // 0x28
public FPVector3 CacheLocalOffset;  // 0x38
public FPVector2 CacheGlobalOffset;  // 0x50
public FP Radius;  // 0x60
public FPVector2 CurrentPosition;  // 0x68
public FPVector2 PreviousPosition;  // 0x78
public QBoolean Interpolate;  // 0x88
public SimpleAABB_Prototype RectArea;  // 0x90
public int[] AttackDatas;  // 0x98
```
Methods:
```
public void Materialize(Frame frame, ref HitBox result, in PrototypeMaterializationContext context)   // RVA 0x2106F60
public void .ctor()   // RVA 0x2107150
```

### Quantum.Prototypes.HitEvent_Prototype  (bases: StructPrototype; TypeDefIndex 10811)
Fields:
```
public HitType_Prototype HitType;  // 0x10
public MapEntityId PlayerOwner;  // 0x14
```
Methods:
```
public void Materialize(Frame frame, ref HitEvent result, in PrototypeMaterializationContext context)   // RVA 0x21071B0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.HitInfo_Prototype  (bases: StructPrototype; TypeDefIndex 10812)
Fields:
```
public int AttackDataID;  // 0x10
public MapEntityId InstigatorCharacterEntity;  // 0x14
public MapEntityId VictimCharacterEntity;  // 0x18
public MapEntityId Instigator;  // 0x1C
public MapEntityId Victim;  // 0x20
public AttackVictimDirection_Prototype VictimDirection;  // 0x24
public HitBoxSpecialBehaviour_Prototype HitBoxHorizontalBehaviour;  // 0x28
public QBoolean Flinchless;  // 0x2C
public QBoolean JabLock;  // 0x30
public QBoolean IsVictimInvincible;  // 0x34
public QBoolean Blocked;  // 0x38
public QBoolean PerfectBlock;  // 0x3C
public QBoolean Trade;  // 0x40
public QBoolean Untechable;  // 0x44
public FP Knockback;  // 0x48
public FP BlockPushDistance;  // 0x50
public FP BlockStun;  // 0x58
public FP HitStun;  // 0x60
public FP DIMultiplier;  // 0x68
public FP SDIMultiplier;  // 0x70
public FP HitLag;  // 0x78
public FP BlockHitLag;  // 0x80
public FP Damage;  // 0x88
public FP BlockDamage;  // 0x90
public FP Angle;  // 0x98
public FP InstigatorAdvantageOnHit;  // 0xA0
public FP InstigatorAdvantageOnBlock;  // 0xA8
public FP InstigatorPushBack;  // 0xB0
public FPVector2 Direction;  // 0xB8
public FPVector2 HitBoxPosition;  // 0xC8
```
Methods:
```
public void Materialize(Frame frame, ref HitInfo result, in PrototypeMaterializationContext context)   // RVA 0x21071D0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.HurtBox_Prototype  (bases: StructPrototype; TypeDefIndex 10813)
Fields:
```
public int JointA;  // 0x10
public int JointB;  // 0x14
public int ID;  // 0x18
public FPVector2 CachePointA;  // 0x20
public FPVector2 CachePointB;  // 0x30
public FP Radius;  // 0x40
public FPVector3 CacheLocalOffsetA;  // 0x48
public FPVector2 CacheGlobalOffsetA;  // 0x60
public FPVector3 CacheLocalOffsetB;  // 0x70
public FPVector2 CacheGlobalOffsetB;  // 0x88
public FPVector2 PointA;  // 0x98
public FPVector2 PointB;  // 0xA8
public SimpleAABB_Prototype RectArea;  // 0xB8
public QBoolean IsIntangible;  // 0xC0
public QBoolean IsInvincible;  // 0xC4
```
Methods:
```
public void Materialize(Frame frame, ref HurtBox result, in PrototypeMaterializationContext context)   // RVA 0x2107340
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.InitialWaitTimer_Prototype  (bases: ComponentPrototype<InitialWaitTimer>; TypeDefIndex 10814)
Fields:
```
public InitialWaitTimerState_Prototype State;  // 0x18
public FP RemainingTimerFrames;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref InitialWaitTimer result, in PrototypeMaterializationContext context)   // RVA 0x21051B0
public void .ctor()   // RVA 0x2107580
```

### Quantum.Prototypes.InputBuffer_Prototype  (bases: ComponentPrototype<InputBuffer>; TypeDefIndex 10815)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public int LastHistoryElementIndex;  // 0x20
public int BufferHistorySize;  // 0x24
public InputValue_Prototype[] BufferHistory;  // 0x28
public InputFlag_Prototype PreviousInput;  // 0x30
public FP PreviousLeftStickX;  // 0x38
public FP PreviousLeftStickY;  // 0x40
public InputFlag_Prototype CurrentInput;  // 0x48
public FP CurrentLeftStickX;  // 0x50
public FP CurrentLeftStickY;  // 0x58
public AssetRefInputCheck_Behaviour CurrentInputCheckbehaviour;  // 0x60
public ButtonTimersContainer_Prototype ButtonTimersContainer;  // 0x68
```
Methods:
```
public void Materialize(Frame frame, ref InputBuffer result, in PrototypeMaterializationContext context)   // RVA 0x2107790
public void .ctor()   // RVA 0x2107A60
```

### Quantum.Prototypes.InputTimer_Prototype  (bases: StructPrototype; TypeDefIndex 10816)
Fields:
```
public int FramesSinceButtonPress;  // 0x10
public int FramesSinceButtonRelease;  // 0x14
```
Methods:
```
public void Materialize(Frame frame, ref InputTimer result, in PrototypeMaterializationContext context)   // RVA 0x2107AD0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.InputValue_Prototype  (bases: StructPrototype; TypeDefIndex 10817)
Fields:
```
public InputFlag_Prototype InputFlag;  // 0x10
public InputFlag_Prototype IgnoreFlag;  // 0x14
public FP LeftStickX;  // 0x18
public QBoolean LeftStickXSpent;  // 0x20
public FP LeftStickY;  // 0x28
public QBoolean LeftStickYSpent;  // 0x30
```
Methods:
```
public void Materialize(Frame frame, ref InputValue result, in PrototypeMaterializationContext context)   // RVA 0x2107AE0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.ItemAutoTrigger_Prototype  (bases: ComponentPrototype<ItemAutoTrigger>; TypeDefIndex 10818)
Fields:
```
public MapEntityId Entity;  // 0x18
public QString64 ItemToUse;  // 0x1C
public int UseFramesInterval;  // 0x5C
public FP RemainingFramesToUseItem;  // 0x60
```
Methods:
```
public void Materialize(Frame frame, ref ItemAutoTrigger result, in PrototypeMaterializationContext context)   // RVA 0x2107D50
public void .ctor()   // RVA 0x2107DB0
```

### Quantum.Prototypes.ItemBox_Prototype  (bases: ComponentPrototype<ItemBox>; TypeDefIndex 10819)
Fields:
```
public QString64 ForcedItem;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref ItemBox result, in PrototypeMaterializationContext context)   // RVA 0x20FDB90
public void .ctor()   // RVA 0x2107F50
```

### Quantum.Prototypes.Jump_Prototype  (bases: ComponentPrototype<Jump>; TypeDefIndex 10820)
Fields:
```
public MapEntityId Entity;  // 0x18
public AssetRefJumpSettingsData JumpData;  // 0x20
public int JumpAnticipationFrames;  // 0x28
public QBoolean DoShortJump;  // 0x2C
public JumpType_Prototype ActiveJump;  // 0x30
public FP JumpImpulseFrames;  // 0x38
public FPVector2 JumpImpulseVelocity;  // 0x40
public FPVector2 ReferenceLeftStick;  // 0x50
public QBoolean OnWallSlide;  // 0x60
public QBoolean TouchingFrontWall;  // 0x64
public QBoolean TouchingBackWall;  // 0x68
```
Methods:
```
public void Materialize(Frame frame, ref Jump result, in PrototypeMaterializationContext context)   // RVA 0x2108170
public void .ctor()   // RVA 0x21081F0
```

### Quantum.Prototypes.KinematicBody_Prototype  (bases: ComponentPrototype<KinematicBody>; TypeDefIndex 10821)
Fields:
```
public QBoolean Active;  // 0x18
public FPVector2 Velocity;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref KinematicBody result, in PrototypeMaterializationContext context)   // RVA 0x21083A0
public void .ctor()   // RVA 0x21083B0
```

### Quantum.Prototypes.Laser_Prototype  (bases: ComponentPrototype<Laser>; TypeDefIndex 10822)
Fields:
```
public FP InitialRotation;  // 0x18
public LaserDirection_Prototype RotationDirection;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref Laser result, in PrototypeMaterializationContext context)   // RVA 0x2108550
public void .ctor()   // RVA 0x2108560
```

### Quantum.Prototypes.LayoutManager_Prototype  (bases: ComponentPrototype<LayoutManager>; TypeDefIndex 10823)
Fields:
```
public StageEntity_Prototype[] StageEntities;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref LayoutManager result, in PrototypeMaterializationContext context)   // RVA 0x2108710
public void .ctor()   // RVA 0x21089E0
```

### Quantum.Prototypes.MatchTimer_Prototype  (bases: ComponentPrototype<MatchTimer>; TypeDefIndex 10824)
Fields:
```
public QBoolean Active;  // 0x18
public FP CurrentTime;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref MatchTimer result, in PrototypeMaterializationContext context)   // RVA 0x2108BB0
public void .ctor()   // RVA 0x2108BC0
```

### Quantum.Prototypes.MechanicTutorialGameModeManager_Prototype  (bases: ComponentPrototype<MechanicTutorialGameModeManager>; TypeDefIndex 10825)
Fields:
```
public int SectionIndex;  // 0x18
public RuntimeMechanicTutorialGoal_Prototype[] Goals;  // 0x20
public FP RemainingTimerFrames;  // 0x28
public FP TotalTimerFrames;  // 0x30
public QBoolean SectionCompleted;  // 0x38
```
Methods:
```
public void Materialize(Frame frame, ref MechanicTutorialGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x2108F10
public void .ctor()   // RVA 0x21090A0
```

### Quantum.Prototypes.MechanicTutorialGoalTrigger_Prototype  (bases: ComponentPrototype<MechanicTutorialGoalTrigger>; TypeDefIndex 10826)
Fields:
```
public QString64 GoalID;  // 0x18
public FP RequiredHorizontalVelocity;  // 0x58
public QBoolean UseAbsoluteHorizontal;  // 0x60
public FP RequiredVerticalVelocity;  // 0x68
public QBoolean UseAbsoluteVertical;  // 0x70
public FP RequiredTotalVelocity;  // 0x78
public QString64 RequiredState;  // 0x80
public QString64 RequiredPreviousState;  // 0xC0
```
Methods:
```
public void Materialize(Frame frame, ref MechanicTutorialGoalTrigger result, in PrototypeMaterializationContext context)   // RVA 0x21093F0
public void .ctor()   // RVA 0x21094B0
```

### Quantum.Prototypes.Movable_Prototype  (bases: ComponentPrototype<Movable>; TypeDefIndex 10827)
Fields:
```
public FPVector2 PreviousPosition;  // 0x18
public QBoolean Teleported;  // 0x28
public QBoolean TeleportedFlag;  // 0x2C
```
Methods:
```
public void Materialize(Frame frame, ref Movable result, in PrototypeMaterializationContext context)   // RVA 0x2109670
public void .ctor()   // RVA 0x2109690
```

### Quantum.Prototypes.MoveLimit_Prototype  (bases: StructPrototype; TypeDefIndex 10828)
Fields:
```
public int UsesAvailable;  // 0x10
public int MaxUses;  // 0x14
public QBoolean SpendGrounded;  // 0x18
public QBoolean SpendInAir;  // 0x1C
public QBoolean ResetOnHurt;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref MoveLimit result, in PrototypeMaterializationContext context)   // RVA 0x21096D0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.MovesetLimiter_Prototype  (bases: ComponentPrototype<MovesetLimiter>; TypeDefIndex 10829)
Fields:
```
public AssetRefMovesetLimiterData MovesetLimiterData;  // 0x18
public DictionaryEntry_Int32_MoveLimit_Prototype[] AvailableMoves;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref MovesetLimiter result, in PrototypeMaterializationContext context)   // RVA 0x2109A10
public void .ctor()   // RVA 0x2109BD0
```

### Quantum.Prototypes.NonDeterministicAnimation_Prototype  (bases: ComponentPrototype<NonDeterministicAnimation>; TypeDefIndex 10830)
Fields:
```
public string AnimationTrigger;  // 0x18
public StageExecutionMode_Prototype ExecutionMode;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref NonDeterministicAnimation result, in PrototypeMaterializationContext context)   // RVA 0x2109F20
public void .ctor()   // RVA 0x2109F90
```

### Quantum.Prototypes.ObjectVisibilityData_Prototype  (bases: StructPrototype; TypeDefIndex 10831)
Fields:
```
public int RigIDHash;  // 0x10
public int ObjectIDHash;  // 0x14
public QBoolean Visibility;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref ObjectVisibilityData result, in PrototypeMaterializationContext context)   // RVA 0x2109FD0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.ParentObject_Prototype  (bases: ComponentPrototype<ParentObject>; TypeDefIndex 10832)
Fields:
```
public MapEntityId ParentEntity;  // 0x18
public ChildEntity_Prototype[] ChildEntities;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref ParentObject result, in PrototypeMaterializationContext context)   // RVA 0x210A170
public void .ctor()   // RVA 0x210A350
```

### Quantum.Prototypes.PartnersManager_Prototype  (bases: ComponentPrototype<PartnersManager>; TypeDefIndex 10833)
Fields:
```
public MapEntityId[] CharacterEntities;  // 0x18
public int CurrentCharacterIndex;  // 0x20
public QBoolean CharacterSwapAllowed;  // 0x24
public FP CharacterSwapCooldown;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref PartnersManager result, in PrototypeMaterializationContext context)   // RVA 0x210A6B0
public void .ctor()   // RVA 0x210A850
```

### Quantum.Prototypes.PersistentEntity_Prototype  (bases: ComponentPrototype<PersistentEntity>; TypeDefIndex 10834)
Fields:
```
public int _empty_prototype_dummy_field_;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref PersistentEntity result, in PrototypeMaterializationContext context)   // RVA 0x4F3940
public void .ctor()   // RVA 0x210A9F0
```

### Quantum.Prototypes.PhysicsBody_Prototype  (bases: ComponentPrototype<PhysicsBody>; TypeDefIndex 10835)
Fields:
```
public QBoolean Active;  // 0x18
public MapEntityId Entity;  // 0x1C
public AssetRefPhysicsData DefaultPhysicsData;  // 0x20
public QBoolean CanEnterGroundedState;  // 0x28
public QBoolean SetGroundedOnlyWhenGoingDown;  // 0x2C
public QBoolean CorrectionEnabled;  // 0x30
public QBoolean BounceEnabled;  // 0x34
public EnvironmentCollisionBox_Prototype ECB;  // 0x38
public RuntimePhysics_Prototype RuntimePhysics;  // 0x40
public FPVector2 TargetVelocity;  // 0x48
public FPVector2 Velocity;  // 0x58
public FPVector2 KnockbackVelocity;  // 0x68
public FPVector2 ImpulseVelocity;  // 0x78
public FPVector2 ExternalVelocity;  // 0x88
public FPVector2 GlobalVelocity;  // 0x98
public QBoolean CapKnockbackVelocity;  // 0xA8
public QBoolean Grounded;  // 0xAC
public QBoolean OnFloor;  // 0xB0
public QBoolean OnCeiling;  // 0xB4
public QBoolean OnLeftWall;  // 0xB8
public QBoolean OnRightWall;  // 0xBC
public MapEntityId GroundEntity;  // 0xC0
public FPVector2 GroundNormal;  // 0xC8
public int GroundLayerIndex;  // 0xD8
public FPVector2 PreviousGroundNormal;  // 0xE0
public MapEntityId CeilingEntity;  // 0xF0
public FPVector2 CeilingNormal;  // 0xF8
public int CeilingLayerIndex;  // 0x108
public MapEntityId LeftWallEntity;  // 0x10C
public FPVector2 LeftWallNormal;  // 0x110
public int LeftWallLayerIndex;  // 0x120
public MapEntityId RightWallEntity;  // 0x124
public FPVector2 RightWallNormal;  // 0x128
public int RightWallLayerIndex;  // 0x138
public FPVector2 BounceNormal;  // 0x140
public FP FramesInAir;  // 0x150
public QBoolean InBlastzone;  // 0x158
public QBoolean SnapToWall;  // 0x15C
public FPVector2 InitialWallSnapPoint;  // 0x160
public WallSnapDirection_Prototype InitialWallSnapDirection;  // 0x170
public QBoolean ForceSnapToGround;  // 0x174
public QBoolean CanLeaveEdges;  // 0x178
public QBoolean CanFallThrough;  // 0x17C
public QBoolean IgnoreThinPlatforms;  // 0x180
public FP IgnoreThinPlatformFrames;  // 0x188
public QBoolean DetectBlastzones;  // 0x190
public QBoolean DetectTopBlastzone;  // 0x194
public AssetRefApplyImpulse_Behaviour CurrentImpulseBehaviour;  // 0x198
public FP ImpulseFrames;  // 0x1A0
public FPVector2 ReferenceLeftStick;  // 0x1A8
public QBoolean SlideOnCeiling;  // 0x1B8
public QBoolean SlideOnGround;  // 0x1BC
public QBoolean SlideOnWalls;  // 0x1C0
public SlideDirection_Prototype CeilingSlideDirection;  // 0x1C4
public SlideDirection_Prototype WallSlideDirection;  // 0x1C8
```
Methods:
```
public void Materialize(Frame frame, ref PhysicsBody result, in PrototypeMaterializationContext context)   // RVA 0x210AD00
public void .ctor()   // RVA 0x210B240
```

### Quantum.Prototypes.PhysicsModifier_Prototype  (bases: ComponentPrototype<PhysicsModifier>; TypeDefIndex 10836)
Fields:
```
public MapEntityId Entity;  // 0x18
public PhysicsModifierInfo_Prototype ModifierInfo;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref PhysicsModifier result, in PrototypeMaterializationContext context)   // RVA 0x210B460
public void .ctor()   // RVA 0x210B4C0
```

### Quantum.Prototypes.PhysicsModifierInfo_Prototype  (bases: StructPrototype; TypeDefIndex 10837)
Fields:
```
public FP GravityMultiplier;  // 0x10
public FP AccelerationMultiplier;  // 0x18
public FP DecelerationMultiplier;  // 0x20
public FP VelocityMultiplier;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref PhysicsModifierInfo result, in PrototypeMaterializationContext context)   // RVA 0x210B280
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.PlatformFightGameModeManager_Prototype  (bases: ComponentPrototype<PlatformFightGameModeManager>; TypeDefIndex 10838)
Fields:
```
public PlatformFightState_Prototype CurrentState;  // 0x18
public FP CurrentCountdown;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref PlatformFightGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x21051B0
public void .ctor()   // RVA 0x210C5E0
```

### Quantum.Prototypes.PlayerManager_Prototype  (bases: ComponentPrototype<PlayerManager>; TypeDefIndex 10839)
Fields:
```
public PlayerRef PlayerRef;  // 0x18
public QBoolean IsNPC;  // 0x1C
public int NPCID;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref PlayerManager result, in PrototypeMaterializationContext context)   // RVA 0x210C780
public void .ctor()   // RVA 0x210C7A0
```

### Quantum.Prototypes.PlayerStats_Prototype  (bases: ComponentPrototype<PlayerStats>; TypeDefIndex 10840)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean IsNPC;  // 0x1C
public int RoundsWon;  // 0x20
public HitEvent_Prototype[] HitHistory;  // 0x28
public QBoolean TriggeredBigAir;  // 0x30
public QBoolean TriggeredFloorIsLava;  // 0x34
public FP BigAirFrames;  // 0x38
public int RegisteredGrappleSwingsInAir;  // 0x40
public FP StillAliveTimer;  // 0x48
public FP StillAliveMargin;  // 0x50
public FP StillAliveCurrentTimer;  // 0x58
public FP AliveTimer;  // 0x60
public FP SuperSpeedCooldownFrames;  // 0x68
public FP BigAirCooldownFrames;  // 0x70
public int RocketsHit;  // 0x78
public int BombsHit;  // 0x7C
public int FreezeRaysHit;  // 0x80
public int CratesHit;  // 0x84
public int InvinciDrillsHit;  // 0x88
public int FireBallsHit;  // 0x8C
public int ShockWavesHit;  // 0x90
public int GoldenHooksHit;  // 0x94
public ExperienceEventData_Prototype[] ExperienceEventDataList;  // 0x98
```
Methods:
```
public void Materialize(Frame frame, ref PlayerStats result, in PrototypeMaterializationContext context)   // RVA 0x210C9F0
public void .ctor()   // RVA 0x210CE20
```

### Quantum.Prototypes.RaceGameModeManager_Prototype  (bases: ComponentPrototype<RaceGameModeManager>; TypeDefIndex 10841)
Fields:
```
public RaceState_Prototype CurrentState;  // 0x18
public FP CurrentCountdown;  // 0x20
public FP CurrentMatchTimer;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref RaceGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x210D030
public void .ctor()   // RVA 0x210D050
```

### Quantum.Prototypes.RaceTutorialGameModeManager_Prototype  (bases: ComponentPrototype<RaceTutorialGameModeManager>; TypeDefIndex 10842)
Fields:
```
public QBoolean IsInitialSection;  // 0x18
public QBoolean IsSuddenDeathPromptVisible;  // 0x1C
public QBoolean DisplayedSuddenDeathPrompt;  // 0x20
public QBoolean StartedFirstLap;  // 0x24
public int HighestLap;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref RaceTutorialGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x210D200
public void .ctor()   // RVA 0x210D230
```

### Quantum.Prototypes.RespawnPoint_Prototype  (bases: ComponentPrototype<RespawnPoint>; TypeDefIndex 10843)
Fields:
```
public QBoolean IsInitial;  // 0x18
public RespawnDirection_Prototype Direction;  // 0x1C
public MapEntityId NextCheckPoint;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref RespawnPoint result, in PrototypeMaterializationContext context)   // RVA 0x210D3E0
public void .ctor()   // RVA 0x210D400
```

### Quantum.Prototypes.Rocket_Prototype  (bases: ComponentPrototype<Rocket>; TypeDefIndex 10844)
Fields:
```
public MapEntityId Entity;  // 0x18
public MapEntityId Target;  // 0x1C
public FP ReCheckTargetFrames;  // 0x20
public FP InterpolationSpeed;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref Rocket result, in PrototypeMaterializationContext context)   // RVA 0x210D7B0
public void .ctor()   // RVA 0x210D810
```

### Quantum.Prototypes.RocketLauncher_Prototype  (bases: ComponentPrototype<RocketLauncher>; TypeDefIndex 10845)
Fields:
```
public MapEntityId Target;  // 0x18
public FP ShootCooldownFrames;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref RocketLauncher result, in PrototypeMaterializationContext context)   // RVA 0x210D5B0
public void .ctor()   // RVA 0x210D5D0
```

### Quantum.Prototypes.RoomMember_Prototype  (bases: ComponentPrototype<RoomMember>; TypeDefIndex 10846)
Fields:
```
public MapEntityId ParentRoom;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref RoomMember result, in PrototypeMaterializationContext context)   // RVA 0x20FCA90
public void .ctor()   // RVA 0x210D9B0
```

### Quantum.Prototypes.RuntimeECBOffset_Prototype  (bases: StructPrototype; TypeDefIndex 10847)
Fields:
```
public FP Value;  // 0x10
public ECBOffsetOperation_Prototype Operation;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref RuntimeECBOffset result, in PrototypeMaterializationContext context)   // RVA 0x210D9F0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.RuntimeGameSpeedModifier_Prototype  (bases: StructPrototype; TypeDefIndex 10848)
Fields:
```
public int ID;  // 0x10
public FP Multiplier;  // 0x18
public QBoolean AlterSimulation;  // 0x20
public QBoolean AlterEngine;  // 0x24
```
Methods:
```
public void Materialize(Frame frame, ref RuntimeGameSpeedModifier result, in PrototypeMaterializationContext context)   // RVA 0x210DA00
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.RuntimeMechanicTutorialGoal_Prototype  (bases: StructPrototype; TypeDefIndex 10849)
Fields:
```
public int ID;  // 0x10
public int RequiredNotificationsToComplete;  // 0x14
```
Methods:
```
public void Materialize(Frame frame, ref RuntimeMechanicTutorialGoal result, in PrototypeMaterializationContext context)   // RVA 0x2107AD0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.RuntimePhysics_Prototype  (bases: StructPrototype; TypeDefIndex 10850)
Fields:
```
public FP Gravity;  // 0x10
public FP GravityMultiplier;  // 0x18
public FP FallSpeed;  // 0x20
public FP AirSpeed;  // 0x28
public FP AirAcceleration;  // 0x30
public FP AirFriction;  // 0x38
public FP AirExtraFrictionThresholdMax;  // 0x40
public FP AirExtraFrictionThresholdMin;  // 0x48
public FP AirExtraFrictionFactor;  // 0x50
public FP WalkSlowSpeed;  // 0x58
public FP WalkFastSpeed;  // 0x60
public FP RunSpeed;  // 0x68
public FP GroundAcceleration;  // 0x70
public FP GroundFriction;  // 0x78
public FP GroundExtraFrictionThresholdMax;  // 0x80
public FP GroundExtraFrictionThresholdMin;  // 0x88
public FP GroundExtraFrictionFactor;  // 0x90
public FP FloorRotationInfluence;  // 0x98
public FP FloorRotationSpeed;  // 0xA0
public FP KnockbackDecay;  // 0xA8
public FP TargetGroundFriction;  // 0xB0
public FP GroundFrictionStep;  // 0xB8
public QBoolean CrowdPushEnabled;  // 0xC0
public FP CrowdPushRadius;  // 0xC8
public FP CrowdPushMinForce;  // 0xD0
public FP CrowdPushMaxForce;  // 0xD8
public FP HitStunGravity;  // 0xE0
public FP HitStunFallSpeed;  // 0xE8
public FP HitStunGroundFriction;  // 0xF0
public FP HitStunAirFriction;  // 0xF8
```
Methods:
```
public void Materialize(Frame frame, ref RuntimePhysics result, in PrototypeMaterializationContext context)   // RVA 0x210DA20
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.RuntimeStatusEffect_Prototype  (bases: StructPrototype; TypeDefIndex 10851)
Fields:
```
public MapEntityId OriginEntity;  // 0x10
public int NameId;  // 0x14
public int Type;  // 0x18
public int OriginId;  // 0x1C
public AssetRefStatusEffectBase StatusEffectData;  // 0x20
public FP RemainingFrames;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref RuntimeStatusEffect result, in PrototypeMaterializationContext context)   // RVA 0x210DB70
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.SFXToExecute_Prototype  (bases: StructPrototype; TypeDefIndex 10852)
Fields:
```
public string EventID;  // 0x10
public FP Delay;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref SFXToExecute result, in PrototypeMaterializationContext context)   // RVA 0x210DBC0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.ScheduledBehaviour_Prototype  (bases: StructPrototype; TypeDefIndex 10853)
Fields:
```
public AssetGuid Behaviour;  // 0x10
public int Frame;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref ScheduledBehaviour result, in PrototypeMaterializationContext context)   // RVA 0x210DC30
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.SecretRoomTrigger_Prototype  (bases: ComponentPrototype<SecretRoomTrigger>; TypeDefIndex 10854)
Fields:
```
public int _empty_prototype_dummy_field_;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref SecretRoomTrigger result, in PrototypeMaterializationContext context)   // RVA 0x4F3940
public void .ctor()   // RVA 0x210DD70
```

### Quantum.Prototypes.Shockwave_Prototype  (bases: ComponentPrototype<Shockwave>; TypeDefIndex 10855)
Fields:
```
public MapEntityId Entity;  // 0x18
public FPVector2 InitialPosition;  // 0x20
public FPVector2 TargetPosition;  // 0x30
public FP Power;  // 0x40
```
Methods:
```
public void Materialize(Frame frame, ref Shockwave result, in PrototypeMaterializationContext context)   // RVA 0x210DF50
public void .ctor()   // RVA 0x210DFA0
```

### Quantum.Prototypes.SimpleAABB_Prototype  (bases: StructPrototype; TypeDefIndex 10856)
Fields:
```
public FPVector2 TopLeft;  // 0x10
public FPVector2 BottomRight;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref SimpleAABB result, in PrototypeMaterializationContext context)   // RVA 0x210DFE0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.SimpleLineRenderer_Prototype  (bases: ComponentPrototype<SimpleLineRenderer>; TypeDefIndex 10857)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Visible;  // 0x1C
public FPVector2 PointA;  // 0x20
public FPVector2 PointB;  // 0x30
public SimpleLineEndRotationMode_Prototype PointARotationMode;  // 0x40
public SimpleLineEndRotationMode_Prototype PointBRotationMode;  // 0x44
```
Methods:
```
public void Materialize(Frame frame, ref SimpleLineRenderer result, in PrototypeMaterializationContext context)   // RVA 0x210E1D0
public void .ctor()   // RVA 0x210E220
```

### Quantum.Prototypes.SlotAttachmentData_Prototype  (bases: StructPrototype; TypeDefIndex 10858)
Fields:
```
public int RigIDHash;  // 0x10
public int PropIDHash;  // 0x14
public TargetSlot_Prototype Slot;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref SlotAttachmentData result, in PrototypeMaterializationContext context)   // RVA 0x2109FD0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.SpawnPoint_Prototype  (bases: ComponentPrototype<SpawnPoint>; TypeDefIndex 10859)
Fields:
```
public string ID;  // 0x18
public int Order;  // 0x20
public SpawnPointDirection_Prototype FacingDirection;  // 0x24
public FPVector2 Position;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref SpawnPoint result, in PrototypeMaterializationContext context)   // RVA 0x210E4E0
public void .ctor()   // RVA 0x210E560
```

### Quantum.Prototypes.SpeedRunnersBlastzone_Prototype  (bases: ComponentPrototype<SpeedRunnersBlastzone>; TypeDefIndex 10860)
Fields:
```
public QBoolean Active;  // 0x18
public QBoolean TimerSuddenDeath;  // 0x1C
public QBoolean IsInSuddenDeath;  // 0x20
public FP SuddenDeathMultiplier;  // 0x28
public FP TimeToStartSuddenDeath;  // 0x30
```
Methods:
```
public void Materialize(Frame frame, ref SpeedRunnersBlastzone result, in PrototypeMaterializationContext context)   // RVA 0x210F300
public void .ctor()   // RVA 0x210F330
```

### Quantum.Prototypes.SpeedRunnersCharacter_Prototype  (bases: ComponentPrototype<SpeedRunnersCharacter>; TypeDefIndex 10861)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Alive;  // 0x1C
public QBoolean IsBoostAlwaysActive;  // 0x20
public QBoolean HasInfiniteBoost;  // 0x24
public QBoolean FlyModeEnabled;  // 0x28
public QBoolean UsingSR1Physics;  // 0x2C
public QBoolean HasSuperSpeed;  // 0x30
public QBoolean IsSliding;  // 0x34
public QBoolean IsInWallSlide;  // 0x38
public int Rank;  // 0x3C
public FP TimeSinceDeath;  // 0x40
public FP DistanceTraveled;  // 0x48
public FPVector2 HookHitPoint;  // 0x50
public FPVector2 LastHookPosition;  // 0x60
public FP HookHitDistance;  // 0x70
public FP CaterpillarWindowFrames;  // 0x78
public int EquipedItemID;  // 0x80
public int ItemUses;  // 0x84
public ItemButtonUseMode_Prototype ItemUseMode;  // 0x88
public FP ItemPowerCharged;  // 0x90
public FP ItemPowerIncrease;  // 0x98
public QBoolean AutoUseItemOnFullCharge;  // 0xA0
public int LastItemUsed;  // 0xA4
public FP ItemUseActiveFrames;  // 0xA8
public int FacingDirectionOnItemUse;  // 0xB0
public FP InviciDrillFrames;  // 0xB8
public FP FreezeFrames;  // 0xC0
public QBoolean PulledByHook;  // 0xC8
public FP ItemUseCooldownFrames;  // 0xD0
public FPVector2 LastValidDirectionForItem;  // 0xD8
public QBoolean IsBoostActive;  // 0xE8
public FP Boost;  // 0xF0
public FP BoostCountdownFrames;  // 0xF8
public FP WallHangCountdownFrames;  // 0x100
public FP HookCooldownFrames;  // 0x108
public FP SlideCooldownFrames;  // 0x110
public FP WallSlideCooldownFrames;  // 0x118
public QBoolean ClearAirJump;  // 0x120
public QBoolean IsJumping;  // 0x124
public FP CurrentJumpFrames;  // 0x128
public FP JumpDuration;  // 0x130
public FPVector2 JumpDirection;  // 0x138
public FPVector2 JumpVelocityBonus;  // 0x148
public FPVector2 JumpVelocity;  // 0x158
public FP JumpPower;  // 0x168
public QBoolean TriggeredInstantJump;  // 0x170
public QBoolean SlideLocked;  // 0x174
public QBoolean IgnoreSlideMinVelocity;  // 0x178
public QBoolean IsSteppingOverLedge;  // 0x17C
public FP SteppingOverLedgeFrames;  // 0x180
public FPVector2 SteppingTargetPosition;  // 0x188
public MapEntityId LastSuperBoostEntity;  // 0x198
public QBoolean IsInSuperBoost;  // 0x19C
public SuperBoostDirection_Prototype SuperBoostDirection;  // 0x1A0
public FP SuperBoostCountdownFrames;  // 0x1A8
public FP SlopeSurfNotificationCooldown;  // 0x1B0
public QBoolean IsRunningBackwards;  // 0x1B8
public FP RunningBackwardsTime;  // 0x1C0
public MapEntityId TargetCheckpoint;  // 0x1C8
public QBoolean EnteredCheckpointGoingForward;  // 0x1CC
public QBoolean EnteredCheckpointGoingBackward;  // 0x1D0
public FP DistanceToFinish;  // 0x1D8
public int Laps;  // 0x1E0
public FP FramesInBlastzone;  // 0x1E8
public QBoolean HasPowerfulTackle;  // 0x1F0
public QBoolean LastIntangibility;  // 0x1F4
```
Methods:
```
public void Materialize(Frame frame, ref SpeedRunnersCharacter result, in PrototypeMaterializationContext context)   // RVA 0x210F8C0
public void .ctor()   // RVA 0x210FBE0
```

### Quantum.Prototypes.SpeedRunnersItem_Prototype  (bases: ComponentPrototype<SpeedRunnersItem>; TypeDefIndex 10862)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean DestroyOnRoundEnd;  // 0x1C
```
Methods:
```
public void Materialize(Frame frame, ref SpeedRunnersItem result, in PrototypeMaterializationContext context)   // RVA 0x210FD90
public void .ctor()   // RVA 0x210FDB0
```

### Quantum.Prototypes.SpeedRunnersNPC_Prototype  (bases: ComponentPrototype<SpeedRunnersNPC>; TypeDefIndex 10863)
Fields:
```
public MapEntityId Entity;  // 0x18
public RunningDirection_Prototype RunningDirection;  // 0x1C
public ActionData_Prototype[] ActionData;  // 0x20
public FP UseCooldown;  // 0x28
public QBoolean JumpDodge;  // 0x30
public FP SlideDodgeFrames;  // 0x38
public FP SlideDodgeTriggerCooldownFrames;  // 0x40
public int DodgeChance;  // 0x48
public int ItemUses;  // 0x4C
public FPVector2 ItemPosition;  // 0x50
public FP ChangeDirectionDelay;  // 0x60
public RunningDirection_Prototype DelayDirection;  // 0x68
public RunningDirection_Prototype TemporaryDirection;  // 0x6C
public FP TemporaryDirectionFrames;  // 0x70
public FP UnFreezeSpeed;  // 0x78
public FP UnFreezeCooldown;  // 0x80
public QBoolean UnfreezeToggle;  // 0x88
public FP MaxSpeed;  // 0x90
public FP TackleChance;  // 0x98
public FP TackleCooldown;  // 0xA0
public FP TackleRunningCooldown;  // 0xA8
```
Methods:
```
public void Materialize(Frame frame, ref SpeedRunnersNPC result, in PrototypeMaterializationContext context)   // RVA 0x2110020
public void .ctor()   // RVA 0x2110250
```

### Quantum.Prototypes.Spike_Prototype  (bases: ComponentPrototype<Spike>; TypeDefIndex 10864)
Fields:
```
public SpikeDirection_Prototype Direction;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref Spike result, in PrototypeMaterializationContext context)   // RVA 0x20FC8E0
public void .ctor()   // RVA 0x2110400
```

### Quantum.Prototypes.StageBounds_Prototype  (bases: ComponentPrototype<StageBounds>; TypeDefIndex 10865)
Fields:
```
public FPVector2 TopLeft;  // 0x18
public FPVector2 BottomRight;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref StageBounds result, in PrototypeMaterializationContext context)   // RVA 0x20FF1B0
public void .ctor()   // RVA 0x21105A0
```

### Quantum.Prototypes.StageEdge_Prototype  (bases: ComponentPrototype<StageEdge>; TypeDefIndex 10866)
Fields:
```
public QBoolean Active;  // 0x18
public EdgeSide_Prototype EdgeSide;  // 0x1C
public MapEntityId GrabbedEntity;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref StageEdge result, in PrototypeMaterializationContext context)   // RVA 0x2110750
public void .ctor()   // RVA 0x2110770
```

### Quantum.Prototypes.StageEntity_Prototype  (bases: StructPrototype; TypeDefIndex 10867)
Fields:
```
public MapEntityId Entity;  // 0x10
public string Id;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref StageEntity result, in PrototypeMaterializationContext context)   // RVA 0x21107B0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.StageHazardSpawnArea_Prototype  (bases: ComponentPrototype<StageHazardSpawnArea>; TypeDefIndex 10868)
Fields:
```
public FPVector2 TopLeft;  // 0x18
public FPVector2 BottomRight;  // 0x28
public HazardSpawnDirection_Prototype SpawnDirection;  // 0x38
```
Methods:
```
public void Materialize(Frame frame, ref StageHazardSpawnArea result, in PrototypeMaterializationContext context)   // RVA 0x21109C0
public void .ctor()   // RVA 0x21109E0
```

### Quantum.Prototypes.StageSFX_Prototype  (bases: ComponentPrototype<StageSFX>; TypeDefIndex 10869)
Fields:
```
public SFXToExecute_Prototype[] EventIDList;  // 0x18
public QBoolean UpdateSoundPosition;  // 0x20
public QBoolean PlayOnStart;  // 0x24
public StageExecutionMode_Prototype ExecutionMode;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref StageSFX result, in PrototypeMaterializationContext context)   // RVA 0x2110BA0
public void .ctor()   // RVA 0x2110E80
```

### Quantum.Prototypes.StageTimeline_Prototype  (bases: ComponentPrototype<StageTimeline>; TypeDefIndex 10870)
Fields:
```
public FP StageFrameTime;  // 0x18
public FP FrameCheckInterval;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref StageTimeline result, in PrototypeMaterializationContext context)   // RVA 0x2111040
public void .ctor()   // RVA 0x2111050
```

### Quantum.Prototypes.StateMachine_Prototype  (bases: ComponentPrototype<StateMachine>; TypeDefIndex 10871)
Fields:
```
public QBoolean Active;  // 0x18
public MapEntityId Entity;  // 0x1C
public AssetRefStateMachineData StateMachineData;  // 0x20
public string CurrentStateName;  // 0x28
public int CurrentStateHash;  // 0x30
public int CurrentStateHashOverride;  // 0x34
public int PreviousStateHash;  // 0x38
public FP SpeedMultiplier;  // 0x40
public FP UpdateCooldown;  // 0x48
public FP TimeSinceLastUpdate;  // 0x50
public FP StateTime;  // 0x58
public int[] UpdateExtraGroups;  // 0x60
public AssetGuid[] ExecutedBehaviours;  // 0x68
public AssetGuid[] FinishedBehaviours;  // 0x70
public ScheduledBehaviour_Prototype[] ScheduledBehaviours;  // 0x78
public DictionaryEntry_QString128_FP_Prototype[] Values;  // 0x80
public int NextStateHash;  // 0x88
public int StateChangesInFrame;  // 0x8C
```
Methods:
```
public void Materialize(Frame frame, ref StateMachine result, in PrototypeMaterializationContext context)   // RVA 0x21112D0
public void .ctor()   // RVA 0x2111A90
```

### Quantum.Prototypes.Static_Prototype  (bases: ComponentPrototype<Static>; TypeDefIndex 10872)
Fields:
```
public int _empty_prototype_dummy_field_;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref Static result, in PrototypeMaterializationContext context)   // RVA 0x4F3940
public void .ctor()   // RVA 0x2111E50
```

### Quantum.Prototypes.StaticRotation_Prototype  (bases: ComponentPrototype<StaticRotation>; TypeDefIndex 10873)
Fields:
```
public FP Rotation;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref StaticRotation result, in PrototypeMaterializationContext context)   // RVA 0x20FFC10
public void .ctor()   // RVA 0x2111CE0
```

### Quantum.Prototypes.StatusEffectAttribute_Prototype  (bases: StructPrototype; TypeDefIndex 10874)
Fields:
```
public FP MultiplierBaseValue;  // 0x10
public FP AddBaseValue;  // 0x18
public FP FixedValue;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref StatusEffectAttribute result, in PrototypeMaterializationContext context)   // RVA 0x2111EB0
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.StatusEffectAttributeModifier_Prototype  (bases: StructPrototype; TypeDefIndex 10875)
Fields:
```
public int OriginId;  // 0x10
public FP Value;  // 0x18
public StatusEffectModifierOperation_Prototype Operation;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref StatusEffectAttributeModifier result, in PrototypeMaterializationContext context)   // RVA 0x2111E90
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.StatusEffectsHolder_Prototype  (bases: ComponentPrototype<StatusEffectsHolder>; TypeDefIndex 10876)
Fields:
```
public MapEntityId Entity;  // 0x18
public RuntimeStatusEffect_Prototype[] ActiveStatusEffects;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref StatusEffectsHolder result, in PrototypeMaterializationContext context)   // RVA 0x2112050
public void .ctor()   // RVA 0x2112260
```

### Quantum.Prototypes.StatusEffectsModifiers_Prototype  (bases: ComponentPrototype<StatusEffectsModifiers>; TypeDefIndex 10877)
Fields:
```
public MapEntityId Entity;  // 0x18
public FP OriginalScale;  // 0x20
public StatusEffectAttribute_Prototype KnockbackAttribute;  // 0x28
public StatusEffectAttribute_Prototype DamageAttribute;  // 0x30
public StatusEffectAttribute_Prototype ScaleAttribute;  // 0x38
public StatusEffectAttributeModifier_Prototype[] KnockbackModifiers;  // 0x40
public StatusEffectAttributeModifier_Prototype[] DamageModifiers;  // 0x48
public StatusEffectAttributeModifier_Prototype[] ScaleModifiers;  // 0x50
```
Methods:
```
public void Materialize(Frame frame, ref StatusEffectsModifiers result, in PrototypeMaterializationContext context)   // RVA 0x21124D0
public void .ctor()   // RVA 0x2112920
```

### Quantum.Prototypes.StellarCharacter_Prototype  (bases: ComponentPrototype<StellarCharacter>; TypeDefIndex 10878)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public int CharacterID;  // 0x20
public string PlayerID;  // 0x28
public PlayerRef PlayerRef;  // 0x30
public int PartnerCharacterIndex;  // 0x34
public int SpawnOrder;  // 0x38
public string Nickname;  // 0x40
public QBoolean StartDisabled;  // 0x48
```
Methods:
```
public void Materialize(Frame frame, ref StellarCharacter result, in PrototypeMaterializationContext context)   // RVA 0x2112C70
public void .ctor()   // RVA 0x2112D40
```

### Quantum.Prototypes.StellarNPC_Prototype  (bases: ComponentPrototype<StellarNPC>; TypeDefIndex 10879)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public int Difficulty;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref StellarNPC result, in PrototypeMaterializationContext context)   // RVA 0x2112EF0
public void .ctor()   // RVA 0x2112F10
```

### Quantum.Prototypes.SuperBoostVolume_Prototype  (bases: ComponentPrototype<SuperBoostVolume>; TypeDefIndex 10880)
Fields:
```
public MapEntityId Entity;  // 0x18
public SuperBoostDirection_Prototype Direction;  // 0x1C
```
Methods:
```
public void Materialize(Frame frame, ref SuperBoostVolume result, in PrototypeMaterializationContext context)   // RVA 0x210FD90
public void .ctor()   // RVA 0x21130C0
```

### Quantum.Prototypes.TargetStatePerEntity_Prototype  (bases: StructPrototype; TypeDefIndex 10881)
Fields:
```
public GameEntityType_Prototype EntityType;  // 0x10
public string TargetState;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref TargetStatePerEntity result, in PrototypeMaterializationContext context)   // RVA 0x2113100
public void .ctor()   // RVA 0x50D320
```

### Quantum.Prototypes.Teams_Prototype  (bases: ComponentPrototype<Teams>; TypeDefIndex 10882)
Fields:
```
public int TeamIndex;  // 0x18
```
Methods:
```
public void Materialize(Frame frame, ref Teams result, in PrototypeMaterializationContext context)   // RVA 0x20FC8E0
public void .ctor()   // RVA 0x21132B0
```

### Quantum.Prototypes.TournamentGameModeManager_Prototype  (bases: ComponentPrototype<TournamentGameModeManager>; TypeDefIndex 10883)
Fields:
```
public FP CurrentRocketsTimer;  // 0x18
public FP RocketsWarningTimer;  // 0x20
public FP ItemSpawnCooldown;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref TournamentGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x2113450
public void .ctor()   // RVA 0x2113470
```

### Quantum.Prototypes.TrainingGameModeManager_Prototype  (bases: ComponentPrototype<TrainingGameModeManager>; TypeDefIndex 10884)
Fields:
```
public QBoolean StartedFirstLap;  // 0x18
public int HighestLap;  // 0x1C
public FP LapTime;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref TrainingGameModeManager result, in PrototypeMaterializationContext context)   // RVA 0x2113610
public void .ctor()   // RVA 0x2113630
```

### Quantum.Prototypes.TrapDoor_Prototype  (bases: ComponentPrototype<TrapDoor>; TypeDefIndex 10885)
Fields:
```
public MapEntityId Entity;  // 0x18
public QString64 SwitchIDToReact;  // 0x1C
public int SwitchIDToReactHash;  // 0x5C
public QBoolean IsOn;  // 0x60
public FP OffRotation;  // 0x68
public FP OnRotation;  // 0x70
public FP RotationSpeed;  // 0x78
```
Methods:
```
public void Materialize(Frame frame, ref TrapDoor result, in PrototypeMaterializationContext context)   // RVA 0x2113B80
public void .ctor()   // RVA 0x2113BF0
```

### Quantum.Prototypes.TrapDoorSwitch_Prototype  (bases: ComponentPrototype<TrapDoorSwitch>; TypeDefIndex 10886)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean IsOn;  // 0x1C
public QString64 SwitchID;  // 0x20
public int SwitchIDHash;  // 0x60
public TrapDoorSwitchActivationMode_Prototype ActivationMode;  // 0x64
public FP FramesToDeactivate;  // 0x68
public FP RuntimeFramesToDeactivate;  // 0x70
```
Methods:
```
public void Materialize(Frame frame, ref TrapDoorSwitch result, in PrototypeMaterializationContext context)   // RVA 0x21138A0
public void .ctor()   // RVA 0x2113910
```

### Quantum.Prototypes.Trigger_Prototype  (bases: ComponentPrototype<Trigger>; TypeDefIndex 10887)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public MapEntityId[] BodiesInTrigger;  // 0x20
public MapEntityId TriggerEnterEntity;  // 0x28
public MapEntityId TriggerExitEntity;  // 0x2C
```
Methods:
```
public void Materialize(Frame frame, ref Trigger result, in PrototypeMaterializationContext context)   // RVA 0x2114280
public void .ctor()   // RVA 0x2114450
```

### Quantum.Prototypes.TriggerPolygonShape_Prototype  (bases: ComponentPrototype<TriggerPolygonShape>; TypeDefIndex 10888)
Fields:
```
public FPVector2[] PolygonVertices;  // 0x18
public FPVector2 Center;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref TriggerPolygonShape result, in PrototypeMaterializationContext context)   // RVA 0x2113F10
public void .ctor()   // RVA 0x2114080
```

### Quantum.Prototypes.TriggerSphereShape_Prototype  (bases: ComponentPrototype<TriggerSphereShape>; TypeDefIndex 10889)
Fields:
```
public FPVector2 Center;  // 0x18
public FP Radius;  // 0x28
```
Methods:
```
public void Materialize(Frame frame, ref TriggerSphereShape result, in PrototypeMaterializationContext context)   // RVA 0x2118DB0
public void .ctor()   // RVA 0x2118DD0
```

### Quantum.Prototypes.VelocityModifier_Prototype  (bases: ComponentPrototype<VelocityModifier>; TypeDefIndex 10890)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public VelocityType_Prototype Type;  // 0x20
public VelocityOperation_Prototype OperationType;  // 0x24
public FP XVelocityModifier;  // 0x28
public FP YVelocityModifier;  // 0x30
public FP MaxYClamp;  // 0x38
public VelocityModifierCondition_Prototype ApplyXVelocityCondition;  // 0x40
public VelocityModifierCondition_Prototype ApplyYVelocityCondition;  // 0x44
public QBoolean ResetMovesetLimiter;  // 0x48
public QBoolean ChangeState;  // 0x4C
public TargetStatePerEntity_Prototype[] TargetStatePerEntity;  // 0x50
```
Methods:
```
public void Materialize(Frame frame, ref VelocityModifier result, in PrototypeMaterializationContext context)   // RVA 0x2118FD0
public void .ctor()   // RVA 0x2119220
```

### Quantum.Prototypes.VisibilitySource_Prototype  (bases: ComponentPrototype<VisibilitySource>; TypeDefIndex 10891)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Active;  // 0x1C
public SimpleAABB_Prototype Bounds;  // 0x20
```
Methods:
```
public void Materialize(Frame frame, ref VisibilitySource result, in PrototypeMaterializationContext context)   // RVA 0x2119450
public void .ctor()   // RVA 0x21194B0
```

### Quantum.Prototypes.VisibilityTarget_Prototype  (bases: ComponentPrototype<VisibilityTarget>; TypeDefIndex 10892)
Fields:
```
public MapEntityId Entity;  // 0x18
public QBoolean Visible;  // 0x1C
public QBoolean BoundsInitialized;  // 0x20
public SimpleAABB_Prototype Bounds;  // 0x28
public QBoolean UseTriggerAsBounds;  // 0x30
public QBoolean AlterStateMachine;  // 0x34
public int StateMachineUpdateCooldown;  // 0x38
public QBoolean AlterPhysicsBody;  // 0x3C
public QBoolean AlterKinematicBody;  // 0x40
public QBoolean AlterTrigger;  // 0x44
public QBoolean AlterCombat;  // 0x48
```
Methods:
```
public void Materialize(Frame frame, ref VisibilityTarget result, in PrototypeMaterializationContext context)   // RVA 0x21196F0
public void .ctor()   // RVA 0x2119790
```

### Quantum.Prototypes.VisualShake_Prototype  (bases: ComponentPrototype<VisualShake>; TypeDefIndex 10893)
Fields:
```
public MapEntityId Entity;  // 0x18
public FP ShakeFrames;  // 0x20
public FP ShakePower;  // 0x28
public QBoolean ShakeHorizontally;  // 0x30
public QBoolean ShakeVertically;  // 0x34
```
Methods:
```
public void Materialize(Frame frame, ref VisualShake result, in PrototypeMaterializationContext context)   // RVA 0x2119960
public void .ctor()   // RVA 0x21199B0
```

### FlatEntityPrototypeContainer.StoreVisitor  (bases: ComponentPrototypeVisitor; TypeDefIndex 10894)
Fields:
```
public FlatEntityPrototypeContainer Storage;  // 0x10
```
Methods:
```
public void .ctor()   // RVA 0x51CCF0
```

### Quantum.Prototypes.FlatEntityPrototypeContainer  (bases: ; TypeDefIndex 10895)
Fields:
```
public List<AIVolume_Prototype> AIVolume;  // 0x10
public List<BaseGameModeManager_Prototype> BaseGameModeManager;  // 0x18
public List<Blastzone_Prototype> Blastzone;  // 0x20
public List<BlastzoneTrigger_Prototype> BlastzoneTrigger;  // 0x28
public List<BossFightGameModeManager_Prototype> BossFightGameModeManager;  // 0x30
public List<BreakableGlass_Prototype> BreakableGlass;  // 0x38
public List<CameraManager_Prototype> CameraManager;  // 0x40
public List<CameraTarget_Prototype> CameraTarget;  // 0x48
public List<CampaignBoss_Prototype> CampaignBoss;  // 0x50
public List<CampaignRaceGameModeManager_Prototype> CampaignRaceGameModeManager;  // 0x58
public List<Checkpoint_Prototype> Checkpoint;  // 0x60
public List<CheckpointManager_Prototype> CheckpointManager;  // 0x68
public List<CollectorCharacter_Prototype> CollectorCharacter;  // 0x70
public List<CollectorTreasure_Prototype> CollectorTreasure;  // 0x78
public List<CollectorsGameModeManager_Prototype> CollectorsGameModeManager;  // 0x80
public List<CollectorsTreasureSpawnArea_Prototype> CollectorsTreasureSpawnArea;  // 0x88
public List<Combat_Prototype> Combat;  // 0x90
public List<CombatArmor_Prototype> CombatArmor;  // 0x98
public List<CombatBlock_Prototype> CombatBlock;  // 0xA0
public List<CombatCharge_Prototype> CombatCharge;  // 0xA8
public List<CombatDI_Prototype> CombatDI;  // 0xB0
public List<CombatDamage_Prototype> CombatDamage;  // 0xB8
public List<CombatPoints_Prototype> CombatPoints;  // 0xC0
public List<CombatStamina_Prototype> CombatStamina;  // 0xC8
public List<CombatStocks_Prototype> CombatStocks;  // 0xD0
public List<CombatTech_Prototype> CombatTech;  // 0xD8
public List<ContinuousRotation_Prototype> ContinuousRotation;  // 0xE0
public List<CustomAnimator_Prototype> CustomAnimator;  // 0xE8
public List<DestroyEntitiesManager_Prototype> DestroyEntitiesManager;  // 0xF0
public List<DynamicStageElement_Prototype> DynamicStageElement;  // 0xF8
public List<EdgeGrab_Prototype> EdgeGrab;  // 0x100
public List<EndlessGameModeManager_Prototype> EndlessGameModeManager;  // 0x108
public List<EnergyBar_Prototype> EnergyBar;  // 0x110
public List<EntityModifier_Prototype> EntityModifier;  // 0x118
public List<EntityModifierTarget_Prototype> EntityModifierTarget;  // 0x120
public List<EntityReferencesHandler_Prototype> EntityReferencesHandler;  // 0x128
public List<EscapeRoomGameModeManager_Prototype> EscapeRoomGameModeManager;  // 0x130
public List<EscapeRoomGoalTrigger_Prototype> EscapeRoomGoalTrigger;  // 0x138
public List<FrameByFrame_Prototype> FrameByFrame;  // 0x140
public List<FrogmanBossTongue_Prototype> FrogmanBossTongue;  // 0x148
public List<GameEntity_Prototype> GameEntity;  // 0x150
public List<GameModeItemAutoTrigger_Prototype> GameModeItemAutoTrigger;  // 0x158
public List<GameTimeManager_Prototype> GameTimeManager;  // 0x160
public List<GoldenHook_Prototype> GoldenHook;  // 0x168
public List<Grab_Prototype> Grab;  // 0x170
public List<HazardsRaceGameModeManager_Prototype> HazardsRaceGameModeManager;  // 0x178
public List<InitialWaitTimer_Prototype> InitialWaitTimer;  // 0x180
public List<InputBuffer_Prototype> InputBuffer;  // 0x188
public List<ItemAutoTrigger_Prototype> ItemAutoTrigger;  // 0x190
public List<ItemBox_Prototype> ItemBox;  // 0x198
public List<Jump_Prototype> Jump;  // 0x1A0
public List<KinematicBody_Prototype> KinematicBody;  // 0x1A8
public List<Laser_Prototype> Laser;  // 0x1B0
public List<LayoutManager_Prototype> LayoutManager;  // 0x1B8
public List<MatchTimer_Prototype> MatchTimer;  // 0x1C0
public List<MechanicTutorialGameModeManager_Prototype> MechanicTutorialGameModeManager;  // 0x1C8
public List<MechanicTutorialGoalTrigger_Prototype> MechanicTutorialGoalTrigger;  // 0x1D0
public List<Movable_Prototype> Movable;  // 0x1D8
public List<MovesetLimiter_Prototype> MovesetLimiter;  // 0x1E0
public List<NonDeterministicAnimation_Prototype> NonDeterministicAnimation;  // 0x1E8
public List<ParentObject_Prototype> ParentObject;  // 0x1F0
public List<PartnersManager_Prototype> PartnersManager;  // 0x1F8
public List<PersistentEntity_Prototype> PersistentEntity;  // 0x200
public List<PhysicsBody_Prototype> PhysicsBody;  // 0x208
public List<PhysicsModifier_Prototype> PhysicsModifier;  // 0x210
public List<PlatformFightGameModeManager_Prototype> PlatformFightGameModeManager;  // 0x218
public List<PlayerManager_Prototype> PlayerManager;  // 0x220
public List<PlayerStats_Prototype> PlayerStats;  // 0x228
public List<RaceGameModeManager_Prototype> RaceGameModeManager;  // 0x230
public List<RaceTutorialGameModeManager_Prototype> RaceTutorialGameModeManager;  // 0x238
public List<RespawnPoint_Prototype> RespawnPoint;  // 0x240
public List<Rocket_Prototype> Rocket;  // 0x248
public List<RocketLauncher_Prototype> RocketLauncher;  // 0x250
public List<RoomMember_Prototype> RoomMember;  // 0x258
public List<SecretRoomTrigger_Prototype> SecretRoomTrigger;  // 0x260
public List<Shockwave_Prototype> Shockwave;  // 0x268
public List<SimpleLineRenderer_Prototype> SimpleLineRenderer;  // 0x270
public List<SpawnPoint_Prototype> SpawnPoint;  // 0x278
public List<SpeedRunnersBlastzone_Prototype> SpeedRunnersBlastzone;  // 0x280
public List<SpeedRunnersCharacter_Prototype> SpeedRunnersCharacter;  // 0x288
public List<SpeedRunnersItem_Prototype> SpeedRunnersItem;  // 0x290
public List<SpeedRunnersNPC_Prototype> SpeedRunnersNPC;  // 0x298
public List<Spike_Prototype> Spike;  // 0x2A0
public List<StageBounds_Prototype> StageBounds;  // 0x2A8
public List<StageEdge_Prototype> StageEdge;  // 0x2B0
public List<StageHazardSpawnArea_Prototype> StageHazardSpawnArea;  // 0x2B8
public List<StageSFX_Prototype> StageSFX;  // 0x2C0
public List<StageTimeline_Prototype> StageTimeline;  // 0x2C8
public List<StateMachine_Prototype> StateMachine;  // 0x2D0
public List<Static_Prototype> Static;  // 0x2D8
public List<StaticRotation_Prototype> StaticRotation;  // 0x2E0
public List<StatusEffectsHolder_Prototype> StatusEffectsHolder;  // 0x2E8
public List<StatusEffectsModifiers_Prototype> StatusEffectsModifiers;  // 0x2F0
public List<StellarCharacter_Prototype> StellarCharacter;  // 0x2F8
public List<StellarNPC_Prototype> StellarNPC;  // 0x300
public List<SuperBoostVolume_Prototype> SuperBoostVolume;  // 0x308
public List<Teams_Prototype> Teams;  // 0x310
public List<TournamentGameModeManager_Prototype> TournamentGameModeManager;  // 0x318
public List<TrainingGameModeManager_Prototype> TrainingGameModeManager;  // 0x320
public List<TrapDoor_Prototype> TrapDoor;  // 0x328
public List<TrapDoorSwitch_Prototype> TrapDoorSwitch;  // 0x330
public List<Trigger_Prototype> Trigger;  // 0x338
public List<TriggerPolygonShape_Prototype> TriggerPolygonShape;  // 0x340
public List<TriggerSphereShape_Prototype> TriggerSphereShape;  // 0x348
public List<VelocityModifier_Prototype> VelocityModifier;  // 0x350
public List<VisibilitySource_Prototype> VisibilitySource;  // 0x358
public List<VisibilityTarget_Prototype> VisibilityTarget;  // 0x360
public List<VisualShake_Prototype> VisualShake;  // 0x368
public List<CharacterController2D_Prototype> CharacterController2D;  // 0x370
public List<CharacterController3D_Prototype> CharacterController3D;  // 0x378
public List<NavMeshAvoidanceAgent_Prototype> NavMeshAvoidanceAgent;  // 0x380
public List<NavMeshAvoidanceObstacle_Prototype> NavMeshAvoidanceObstacle;  // 0x388
public List<NavMeshPathfinder_Prototype> NavMeshPathfinder;  // 0x390
public List<NavMeshSteeringAgent_Prototype> NavMeshSteeringAgent;  // 0x398
public List<PhysicsBody2D_Prototype> PhysicsBody2D;  // 0x3A0
public List<PhysicsBody3D_Prototype> PhysicsBody3D;  // 0x3A8
public List<PhysicsCollider2D_Prototype> PhysicsCollider2D;  // 0x3B0
public List<PhysicsCollider3D_Prototype> PhysicsCollider3D;  // 0x3B8
public List<PhysicsCallbacks2D_Prototype> PhysicsCallbacks2D;  // 0x3C0
public List<PhysicsCallbacks3D_Prototype> PhysicsCallbacks3D;  // 0x3C8
public List<Transform2D_Prototype> Transform2D;  // 0x3D0
public List<Transform2DVertical_Prototype> Transform2DVertical;  // 0x3D8
public List<Transform3D_Prototype> Transform3D;  // 0x3E0
public List<View_Prototype> View;  // 0x3E8
public List<PhysicsJoints2D_Prototype> PhysicsJoints2D;  // 0x3F0
public List<PhysicsJoints3D_Prototype> PhysicsJoints3D;  // 0x3F8
```
Methods:
```
public void Collect(List<ComponentPrototype> target)   // RVA 0x2115760
public void Store(IList<ComponentPrototype> prototypes)   // RVA 0x2115A40
private void CollectGen(List<ComponentPrototype> target)   // RVA 0x21147C0
public void .ctor()   // RVA 0x4FA6F0
```
