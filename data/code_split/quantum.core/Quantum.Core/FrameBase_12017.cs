// Namespace: Quantum.Core
public abstract class FrameBase : DeterministicFrame // TypeDefIndex: 12017
{
	// Fields
	internal const int COMPONENT_START_INDEX = 1;
	internal const int CULLED_WORD_BYTE_SIZE = 8;
	internal const int CULLED_WORD_BIT_SIZE = 64;
	internal const int COMPONENT_MASK_WORD_BYTESIZE = 4;
	internal const int COMPONENT_MASK_WORD_BITSIZE = 32;
	private int _usedCount; // 0x20
	private int _freeCount; // 0x24
	private int _freeHead; // 0x28
	internal int _capacity; // 0x2C
	private int _capacityActual; // 0x30
	internal EntityInfo* _info; // 0x38
	internal long* _culled; // 0x40
	private ushort* _sparse; // 0x48
	internal ComponentSet* _componentMasks; // 0x50
	private ComponentDataBuffer* _componentBuffers; // 0x58
	private int _componentBuffersLength; // 0x60
	private FrameContext _context; // 0x68
	protected internal FrameBase.ComponentReactiveCallbackInvoker[] _ComponentSignalsOnAdded; // 0x70
	protected internal FrameBase.ComponentReactiveCallbackInvoker[] _ComponentSignalsOnRemoved; // 0x78
	protected internal FrameBase.EntityPrototypeMaterializedCallbackInvoker _SignalOnEntityPrototypeMaterialized; // 0x80
	[DebuggerBrowsable(0)]
	protected Heap* _heap; // 0x88
	private FrameHeap _trackedHeap; // 0x90
	protected internal readonly DynamicAssetDB _dynamicAssetDB; // 0x98
	public FrameBase.FrameBaseUnsafe Unsafe; // 0xA0
	public PhysicsEngine2D.Api Physics2D; // 0xB8
	public PhysicsEngine3D.Api Physics3D; // 0xC0
	public const int DefaultInitialCollectionCapacity = 8;

	// Properties
	public abstract CommitCommandsModes CommitCommandsMode { get; }
	public abstract PhysicsSceneSettings* PhysicsSceneSettings { get; }
	public abstract Map Map { get; }
	public abstract NavMeshRegionMask* NavMeshRegionMask { get; }
	public abstract FrameMetaData* FrameMetaData { get; }
	protected abstract PhysicsEngineState* _physicsState2D { get; }
	protected abstract PhysicsEngineState* _physicsState3D { get; }
	internal PhysicsEngineState* _physicsStateInternal2D { get; }
	internal PhysicsEngineState* _physicsStateInternal3D { get; }
	public Navigation Navigation { get; }
	public abstract FP DeltaTime { get; }
	public FrameContext Context { get; }
	public FrameHeap TrackedHeap { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ComponentFilter<T0> Filter<T0>(ComponentSet without, ComponentSet any) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49070 Offset: 0xB47670 VA: 0x180B49070
	|-FrameBase.Filter<AIVolume>
	|-FrameBase.Filter<BaseGameModeManager>
	|-FrameBase.Filter<Blastzone>
	|-FrameBase.Filter<BossFightGameModeManager>
	|-FrameBase.Filter<CameraManager>
	|-FrameBase.Filter<CameraTarget>
	|-FrameBase.Filter<CampaignBoss>
	|-FrameBase.Filter<CampaignRaceGameModeManager>
	|-FrameBase.Filter<CheckpointManager>
	|-FrameBase.Filter<CollectorTreasure>
	|-FrameBase.Filter<CollectorsGameModeManager>
	|-FrameBase.Filter<CollectorsTreasureSpawnArea>
	|-FrameBase.Filter<Combat>
	|-FrameBase.Filter<ContinuousRotation>
	|-FrameBase.Filter<CustomAnimator>
	|-FrameBase.Filter<DestroyEntitiesManager>
	|-FrameBase.Filter<DynamicStageElement>
	|-FrameBase.Filter<EndlessGameModeManager>
	|-FrameBase.Filter<EscapeRoomGameModeManager>
	|-FrameBase.Filter<FrameByFrame>
	|-FrameBase.Filter<GameEntity>
	|-FrameBase.Filter<GameModeItemAutoTrigger>
	|-FrameBase.Filter<GameTimeManager>
	|-FrameBase.Filter<Grab>
	|-FrameBase.Filter<HazardsRaceGameModeManager>
	|-FrameBase.Filter<InitialWaitTimer>
	|-FrameBase.Filter<ItemAutoTrigger>
	|-FrameBase.Filter<ItemBox>
	|-FrameBase.Filter<LayoutManager>
	|-FrameBase.Filter<MatchTimer>
	|-FrameBase.Filter<MechanicTutorialGameModeManager>
	|-FrameBase.Filter<ParentObject>
	|-FrameBase.Filter<PartnersManager>
	|-FrameBase.Filter<PlatformFightGameModeManager>
	|-FrameBase.Filter<PlayerManager>
	|-FrameBase.Filter<PlayerStats>
	|-FrameBase.Filter<RaceGameModeManager>
	|-FrameBase.Filter<RaceTutorialGameModeManager>
	|-FrameBase.Filter<RespawnPoint>
	|-FrameBase.Filter<RoomMember>
	|-FrameBase.Filter<SpeedRunnersBlastzone>
	|-FrameBase.Filter<SpeedRunnersCharacter>
	|-FrameBase.Filter<SpeedRunnersItem>
	|-FrameBase.Filter<SpeedRunnersNPC>
	|-FrameBase.Filter<StageSFX>
	|-FrameBase.Filter<StageTimeline>
	|-FrameBase.Filter<StateMachine>
	|-FrameBase.Filter<StatusEffectsHolder>
	|-FrameBase.Filter<StellarCharacter>
	|-FrameBase.Filter<TournamentGameModeManager>
	|-FrameBase.Filter<TrainingGameModeManager>
	|-FrameBase.Filter<TrapDoor>
	|-FrameBase.Filter<TrapDoorSwitch>
	|-FrameBase.Filter<Trigger>
	|-FrameBase.Filter<VelocityModifier>
	|
	|-RVA: 0xB49610 Offset: 0xB47C10 VA: 0x180B49610
	|-FrameBase.Filter<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public ComponentFilter<T0, T1> Filter<T0, T1>(ComponentSet without, ComponentSet any) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49160 Offset: 0xB47760 VA: 0x180B49160
	|-FrameBase.Filter<Blastzone, Transform2D>
	|-FrameBase.Filter<CameraTarget, Transform2D>
	|-FrameBase.Filter<CampaignBoss, CombatStamina>
	|-FrameBase.Filter<CollectorTreasure, Transform2D>
	|-FrameBase.Filter<Combat, Transform2D>
	|-FrameBase.Filter<GameEntity, GoldenHook>
	|-FrameBase.Filter<GameEntity, Transform2D>
	|-FrameBase.Filter<KinematicBody, Transform2D>
	|-FrameBase.Filter<Movable, Transform2D>
	|-FrameBase.Filter<PhysicsBody, Transform2D>
	|-FrameBase.Filter<RespawnPoint, Transform2D>
	|-FrameBase.Filter<SpeedRunnersCharacter, CollectorCharacter>
	|-FrameBase.Filter<SpeedRunnersCharacter, CombatStamina>
	|-FrameBase.Filter<SpeedRunnersCharacter, PhysicsBody>
	|-FrameBase.Filter<SpeedRunnersCharacter, Transform2D>
	|-FrameBase.Filter<StageBounds, Transform2D>
	|-FrameBase.Filter<StageEdge, Transform2D>
	|-FrameBase.Filter<StellarCharacter, InputBuffer>
	|-FrameBase.Filter<StellarCharacter, SpeedRunnersCharacter>
	|-FrameBase.Filter<Transform2D, SpawnPoint>
	|-FrameBase.Filter<Trigger, VisibilityTarget>
	|-FrameBase.Filter<VisibilitySource, Transform2D>
	|-FrameBase.Filter<VisibilityTarget, Transform2D>
	|
	|-RVA: 0xB49520 Offset: 0xB47B20 VA: 0x180B49520
	|-FrameBase.Filter<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public ComponentFilter<T0, T1, T2> Filter<T0, T1, T2>(ComponentSet without, ComponentSet any) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49250 Offset: 0xB47850 VA: 0x180B49250
	|-FrameBase.Filter<CampaignBoss, PhysicsBody, Transform2D>
	|-FrameBase.Filter<PhysicsBody, GameEntity, Transform2D>
	|-FrameBase.Filter<SpeedRunnersCharacter, GameEntity, Transform2D>
	|
	|-RVA: 0xB49340 Offset: 0xB47940 VA: 0x180B49340
	|-FrameBase.Filter<CampaignBoss, StateMachine, CombatStamina>
	|-FrameBase.Filter<Transform2D, Grab, Trigger>
	|
	|-RVA: 0xB49700 Offset: 0xB47D00 VA: 0x180B49700
	|-FrameBase.Filter<SpeedRunnersCharacter, Transform2D, Movable>
	|
	|-RVA: 0xB49430 Offset: 0xB47A30 VA: 0x180B49430
	|-FrameBase.Filter<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220CB70 Offset: 0x220B170 VA: 0x18220CB70
	public static void Print(FrameBase r, FramePrinter printer, bool printComponentsChecksum = False) { }

	// RVA: 0x220D160 Offset: 0x220B760 VA: 0x18220D160
	public static void Serialize(FrameBase r, FrameSerializer serializer) { }

	// RVA: 0x220B020 Offset: 0x2209620 VA: 0x18220B020
	public static void Copy(FrameBase to, FrameBase from) { }

	// RVA: 0x220C1F0 Offset: 0x220A7F0 VA: 0x18220C1F0
	protected static void Initialize(FrameBase f, FrameBase.EntitiesConfig config) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract CommitCommandsModes get_CommitCommandsMode();

	// RVA: 0x220BED0 Offset: 0x220A4D0 VA: 0x18220BED0
	public void GetAllEntityRefs(List<EntityRef> result) { }

	// RVA: 0x220A600 Offset: 0x2208C00 VA: 0x18220A600
	public void ClearCulledState() { }

	// RVA: 0x220C6B0 Offset: 0x220ACB0 VA: 0x18220C6B0
	public bool IsCulled(EntityRef entityRef) { }

	// RVA: 0x5974D0 Offset: 0x595AD0 VA: 0x1805974D0
	public bool Exists(EntityRef entityRef) { }

	// RVA: -1 Offset: -1
	public ComponentIterator<T> GetComponentIterator<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4ABC0 Offset: 0xB491C0 VA: 0x180B4ABC0
	|-FrameBase.GetComponentIterator<MapEntityLink>
	|-FrameBase.GetComponentIterator<View>
	|-FrameBase.GetComponentIterator<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal ComponentBlockIterator<T> GetComponentBlockIterator<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AB40 Offset: 0xB49140 VA: 0x180B4AB40
	|-FrameBase.GetComponentBlockIterator<NavMeshAvoidanceObstacle>
	|-FrameBase.GetComponentBlockIterator<NavMeshPathfinder>
	|-FrameBase.GetComponentBlockIterator<PhysicsCollider2D>
	|-FrameBase.GetComponentBlockIterator<PhysicsCollider3D>
	|-FrameBase.GetComponentBlockIterator<SpeedRunnersCharacter>
	|-FrameBase.GetComponentBlockIterator<Transform2D>
	|-FrameBase.GetComponentBlockIterator<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public AddResult Add<T>(EntityRef entity, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB47D00 Offset: 0xB46300 VA: 0x180B47D00
	|-FrameBase.Add<MapEntityLink>
	|
	|-RVA: 0xB47DD0 Offset: 0xB463D0 VA: 0x180B47DD0
	|-FrameBase.Add<NavMeshSteeringAgent>
	|
	|-RVA: 0xB48010 Offset: 0xB46610 VA: 0x180B48010
	|-FrameBase.Add<RoomMember>
	|
	|-RVA: 0xB48200 Offset: 0xB46800 VA: 0x180B48200
	|-FrameBase.Add<Transform2D>
	|
	|-RVA: 0xB47BB0 Offset: 0xB461B0 VA: 0x180B47BB0
	|-FrameBase.Add<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public SetResult Set<T>(EntityRef entity, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AF50 Offset: 0xB49550 VA: 0x180B4AF50
	|-FrameBase.Set<AIVolume>
	|-FrameBase.Set<Grab>
	|-FrameBase.Set<SpawnPoint>
	|
	|-RVA: 0xB4B1D0 Offset: 0xB497D0 VA: 0x180B4B1D0
	|-FrameBase.Set<BaseGameModeManager>
	|-FrameBase.Set<CollectorTreasure>
	|-FrameBase.Set<CombatPoints>
	|-FrameBase.Set<CombatStocks>
	|-FrameBase.Set<DestroyEntitiesManager>
	|-FrameBase.Set<EntityReferencesHandler>
	|-FrameBase.Set<LayoutManager>
	|-FrameBase.Set<MapEntityLink>
	|-FrameBase.Set<PersistentEntity>
	|-FrameBase.Set<SecretRoomTrigger>
	|-FrameBase.Set<Spike>
	|-FrameBase.Set<Static>
	|-FrameBase.Set<Teams>
	|
	|-RVA: 0xB4B5F0 Offset: 0xB49BF0 VA: 0x180B4B5F0
	|-FrameBase.Set<Blastzone>
	|-FrameBase.Set<BossFightGameModeManager>
	|-FrameBase.Set<CharacterController2D>
	|-FrameBase.Set<CheckpointManager>
	|-FrameBase.Set<CombatDI>
	|-FrameBase.Set<NavMeshAvoidanceAgent>
	|-FrameBase.Set<NavMeshSteeringAgent>
	|-FrameBase.Set<PhysicsModifier>
	|-FrameBase.Set<StageHazardSpawnArea>
	|
	|-RVA: 0xB4B3E0 Offset: 0xB499E0 VA: 0x180B4B3E0
	|-FrameBase.Set<BlastzoneTrigger>
	|-FrameBase.Set<CombatDamage>
	|-FrameBase.Set<PhysicsJoints2D>
	|-FrameBase.Set<PhysicsJoints3D>
	|-FrameBase.Set<RoomMember>
	|-FrameBase.Set<StaticRotation>
	|-FrameBase.Set<View>
	|
	|-RVA: 0xB4B820 Offset: 0xB49E20 VA: 0x180B4B820
	|-FrameBase.Set<BreakableGlass>
	|-FrameBase.Set<Jump>
	|-FrameBase.Set<PhysicsCollider2D>
	|-FrameBase.Set<VisibilityTarget>
	|
	|-RVA: 0xB4BA60 Offset: 0xB4A060 VA: 0x180B4BA60
	|-FrameBase.Set<CameraManager>
	|-FrameBase.Set<ItemAutoTrigger>
	|
	|-RVA: 0xB4BCB0 Offset: 0xB4A2B0 VA: 0x180B4BCB0
	|-FrameBase.Set<CameraTarget>
	|-FrameBase.Set<EscapeRoomGameModeManager>
	|-FrameBase.Set<PhysicsBody2D>
	|
	|-RVA: 0xB4BF10 Offset: 0xB4A510 VA: 0x180B4BF10
	|-FrameBase.Set<CampaignBoss>
	|-FrameBase.Set<EntityModifierTarget>
	|-FrameBase.Set<EscapeRoomGoalTrigger>
	|-FrameBase.Set<ItemBox>
	|-FrameBase.Set<VelocityModifier>
	|
	|-RVA: 0xB4C150 Offset: 0xB4A750 VA: 0x180B4C150
	|-FrameBase.Set<CampaignRaceGameModeManager>
	|-FrameBase.Set<Checkpoint>
	|-FrameBase.Set<CollectorsGameModeManager>
	|-FrameBase.Set<CombatArmor>
	|-FrameBase.Set<CombatCharge>
	|-FrameBase.Set<CombatStamina>
	|-FrameBase.Set<ContinuousRotation>
	|-FrameBase.Set<EntityModifier>
	|-FrameBase.Set<KinematicBody>
	|-FrameBase.Set<Movable>
	|-FrameBase.Set<PartnersManager>
	|-FrameBase.Set<RaceGameModeManager>
	|-FrameBase.Set<TournamentGameModeManager>
	|-FrameBase.Set<Transform2D>
	|-FrameBase.Set<TriggerPolygonShape>
	|-FrameBase.Set<TriggerSphereShape>
	|
	|-RVA: 0xB4C380 Offset: 0xB4A980 VA: 0x180B4C380
	|-FrameBase.Set<CharacterController3D>
	|-FrameBase.Set<CombatBlock>
	|-FrameBase.Set<Shockwave>
	|-FrameBase.Set<VisibilitySource>
	|
	|-RVA: 0xB4C5B0 Offset: 0xB4ABB0 VA: 0x180B4C5B0
	|-FrameBase.Set<CollectorCharacter>
	|-FrameBase.Set<EnergyBar>
	|-FrameBase.Set<FrameByFrame>
	|-FrameBase.Set<GameTimeManager>
	|-FrameBase.Set<InitialWaitTimer>
	|-FrameBase.Set<Laser>
	|-FrameBase.Set<MatchTimer>
	|-FrameBase.Set<MovesetLimiter>
	|-FrameBase.Set<ParentObject>
	|-FrameBase.Set<PhysicsCallbacks2D>
	|-FrameBase.Set<PhysicsCallbacks3D>
	|-FrameBase.Set<PlatformFightGameModeManager>
	|-FrameBase.Set<RespawnPoint>
	|-FrameBase.Set<RocketLauncher>
	|-FrameBase.Set<SpeedRunnersItem>
	|-FrameBase.Set<StageEdge>
	|-FrameBase.Set<StageSFX>
	|-FrameBase.Set<StageTimeline>
	|-FrameBase.Set<StatusEffectsHolder>
	|-FrameBase.Set<StellarNPC>
	|-FrameBase.Set<SuperBoostVolume>
	|-FrameBase.Set<TrainingGameModeManager>
	|-FrameBase.Set<Transform2DVertical>
	|
	|-RVA: 0xB4C7D0 Offset: 0xB4ADD0 VA: 0x180B4C7D0
	|-FrameBase.Set<CollectorsTreasureSpawnArea>
	|-FrameBase.Set<CombatTech>
	|-FrameBase.Set<DynamicStageElement>
	|-FrameBase.Set<EndlessGameModeManager>
	|-FrameBase.Set<MechanicTutorialGameModeManager>
	|-FrameBase.Set<NavMeshAvoidanceObstacle>
	|-FrameBase.Set<Rocket>
	|-FrameBase.Set<SpeedRunnersBlastzone>
	|-FrameBase.Set<StageBounds>
	|-FrameBase.Set<Trigger>
	|-FrameBase.Set<VisualShake>
	|
	|-RVA: 0xB4C9F0 Offset: 0xB4AFF0 VA: 0x180B4C9F0
	|-FrameBase.Set<Combat>
	|
	|-RVA: 0xB4CCA0 Offset: 0xB4B2A0 VA: 0x180B4CCA0
	|-FrameBase.Set<CustomAnimator>
	|
	|-RVA: 0xB4CF40 Offset: 0xB4B540 VA: 0x180B4CF40
	|-FrameBase.Set<EdgeGrab>
	|-FrameBase.Set<PlayerStats>
	|
	|-RVA: 0xB4D1A0 Offset: 0xB4B7A0 VA: 0x180B4D1A0
	|-FrameBase.Set<FrogmanBossTongue>
	|-FrameBase.Set<GoldenHook>
	|-FrameBase.Set<HazardsRaceGameModeManager>
	|-FrameBase.Set<SimpleLineRenderer>
	|-FrameBase.Set<Transform3D>
	|
	|-RVA: 0xB4D3E0 Offset: 0xB4B9E0 VA: 0x180B4D3E0
	|-FrameBase.Set<GameEntity>
	|
	|-RVA: 0xB4D680 Offset: 0xB4BC80 VA: 0x180B4D680
	|-FrameBase.Set<GameModeItemAutoTrigger>
	|
	|-RVA: 0xB4D8C0 Offset: 0xB4BEC0 VA: 0x180B4D8C0
	|-FrameBase.Set<InputBuffer>
	|
	|-RVA: 0xB4DAE0 Offset: 0xB4C0E0 VA: 0x180B4DAE0
	|-FrameBase.Set<MechanicTutorialGoalTrigger>
	|
	|-RVA: 0xB4E330 Offset: 0xB4C930 VA: 0x180B4E330
	|-FrameBase.Set<NavMeshPathfinder>
	|
	|-RVA: 0xB4E580 Offset: 0xB4CB80 VA: 0x180B4E580
	|-FrameBase.Set<NonDeterministicAnimation>
	|
	|-RVA: 0xB4EA90 Offset: 0xB4D090 VA: 0x180B4EA90
	|-FrameBase.Set<PhysicsBody>
	|
	|-RVA: 0xB4E7F0 Offset: 0xB4CDF0 VA: 0x180B4E7F0
	|-FrameBase.Set<PhysicsBody3D>
	|
	|-RVA: 0xB4ED40 Offset: 0xB4D340 VA: 0x180B4ED40
	|-FrameBase.Set<PhysicsCollider3D>
	|
	|-RVA: 0xB4EF90 Offset: 0xB4D590 VA: 0x180B4EF90
	|-FrameBase.Set<PlayerManager>
	|
	|-RVA: 0xB4F1B0 Offset: 0xB4D7B0 VA: 0x180B4F1B0
	|-FrameBase.Set<RaceTutorialGameModeManager>
	|
	|-RVA: 0xB4F3D0 Offset: 0xB4D9D0 VA: 0x180B4F3D0
	|-FrameBase.Set<SpeedRunnersCharacter>
	|
	|-RVA: 0xB4F670 Offset: 0xB4DC70 VA: 0x180B4F670
	|-FrameBase.Set<SpeedRunnersNPC>
	|
	|-RVA: 0xB4F8E0 Offset: 0xB4DEE0 VA: 0x180B4F8E0
	|-FrameBase.Set<StateMachine>
	|-FrameBase.Set<StellarCharacter>
	|
	|-RVA: 0xB4FB60 Offset: 0xB4E160 VA: 0x180B4FB60
	|-FrameBase.Set<StatusEffectsModifiers>
	|-FrameBase.Set<TrapDoor>
	|-FrameBase.Set<TrapDoorSwitch>
	|
	|-RVA: 0xB4E080 Offset: 0xB4C680 VA: 0x180B4E080
	|-FrameBase.Set<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal T* GetPointer<T>(EntityRef entityRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4ACA0 Offset: 0xB492A0 VA: 0x180B4ACA0
	|-FrameBase.GetPointer<CharacterController3D>
	|-FrameBase.GetPointer<GameEntity>
	|-FrameBase.GetPointer<NavMeshAvoidanceAgent>
	|-FrameBase.GetPointer<NavMeshPathfinder>
	|-FrameBase.GetPointer<NavMeshSteeringAgent>
	|-FrameBase.GetPointer<PhysicsBody2D>
	|-FrameBase.GetPointer<PhysicsBody3D>
	|-FrameBase.GetPointer<PhysicsCallbacks2D>
	|-FrameBase.GetPointer<PhysicsCallbacks3D>
	|-FrameBase.GetPointer<PhysicsCollider2D>
	|-FrameBase.GetPointer<PhysicsCollider3D>
	|-FrameBase.GetPointer<PhysicsJoints2D>
	|-FrameBase.GetPointer<PhysicsJoints3D>
	|-FrameBase.GetPointer<Transform2D>
	|-FrameBase.GetPointer<Transform2DVertical>
	|-FrameBase.GetPointer<Transform3D>
	|-FrameBase.GetPointer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetPointer<T>(EntityRef entityRef, out T* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4FFC0 Offset: 0xB4E5C0 VA: 0x180B4FFC0
	|-FrameBase.TryGetPointer<AIVolume>
	|-FrameBase.TryGetPointer<BlastzoneTrigger>
	|-FrameBase.TryGetPointer<BreakableGlass>
	|-FrameBase.TryGetPointer<CameraManager>
	|-FrameBase.TryGetPointer<CameraTarget>
	|-FrameBase.TryGetPointer<Checkpoint>
	|-FrameBase.TryGetPointer<CollectorCharacter>
	|-FrameBase.TryGetPointer<CollectorTreasure>
	|-FrameBase.TryGetPointer<CollectorsTreasureSpawnArea>
	|-FrameBase.TryGetPointer<Combat>
	|-FrameBase.TryGetPointer<CombatArmor>
	|-FrameBase.TryGetPointer<CombatBlock>
	|-FrameBase.TryGetPointer<CombatCharge>
	|-FrameBase.TryGetPointer<CombatDI>
	|-FrameBase.TryGetPointer<CombatDamage>
	|-FrameBase.TryGetPointer<CombatStamina>
	|-FrameBase.TryGetPointer<CombatStocks>
	|-FrameBase.TryGetPointer<CombatTech>
	|-FrameBase.TryGetPointer<ContinuousRotation>
	|-FrameBase.TryGetPointer<CustomAnimator>
	|-FrameBase.TryGetPointer<DynamicStageElement>
	|-FrameBase.TryGetPointer<EdgeGrab>
	|-FrameBase.TryGetPointer<EnergyBar>
	|-FrameBase.TryGetPointer<EntityModifier>
	|-FrameBase.TryGetPointer<EntityModifierTarget>
	|-FrameBase.TryGetPointer<EntityReferencesHandler>
	|-FrameBase.TryGetPointer<EscapeRoomGoalTrigger>
	|-FrameBase.TryGetPointer<FrogmanBossTongue>
	|-FrameBase.TryGetPointer<GameEntity>
	|-FrameBase.TryGetPointer<GoldenHook>
	|-FrameBase.TryGetPointer<Grab>
	|-FrameBase.TryGetPointer<InputBuffer>
	|-FrameBase.TryGetPointer<ItemBox>
	|-FrameBase.TryGetPointer<Jump>
	|-FrameBase.TryGetPointer<KinematicBody>
	|-FrameBase.TryGetPointer<Laser>
	|-FrameBase.TryGetPointer<MechanicTutorialGoalTrigger>
	|-FrameBase.TryGetPointer<Movable>
	|-FrameBase.TryGetPointer<MovesetLimiter>
	|-FrameBase.TryGetPointer<NonDeterministicAnimation>
	|-FrameBase.TryGetPointer<ParentObject>
	|-FrameBase.TryGetPointer<PartnersManager>
	|-FrameBase.TryGetPointer<PhysicsBody>
	|-FrameBase.TryGetPointer<PhysicsBody2D>
	|-FrameBase.TryGetPointer<PhysicsBody3D>
	|-FrameBase.TryGetPointer<PhysicsCallbacks2D>
	|-FrameBase.TryGetPointer<PhysicsCallbacks3D>
	|-FrameBase.TryGetPointer<PhysicsCollider2D>
	|-FrameBase.TryGetPointer<PhysicsJoints2D>
	|-FrameBase.TryGetPointer<PhysicsJoints3D>
	|-FrameBase.TryGetPointer<PhysicsModifier>
	|-FrameBase.TryGetPointer<PlayerManager>
	|-FrameBase.TryGetPointer<PlayerStats>
	|-FrameBase.TryGetPointer<RespawnPoint>
	|-FrameBase.TryGetPointer<Rocket>
	|-FrameBase.TryGetPointer<RocketLauncher>
	|-FrameBase.TryGetPointer<SecretRoomTrigger>
	|-FrameBase.TryGetPointer<Shockwave>
	|-FrameBase.TryGetPointer<SimpleLineRenderer>
	|-FrameBase.TryGetPointer<SpeedRunnersCharacter>
	|-FrameBase.TryGetPointer<SpeedRunnersNPC>
	|-FrameBase.TryGetPointer<Spike>
	|-FrameBase.TryGetPointer<StageEdge>
	|-FrameBase.TryGetPointer<StageHazardSpawnArea>
	|-FrameBase.TryGetPointer<StageSFX>
	|-FrameBase.TryGetPointer<StateMachine>
	|-FrameBase.TryGetPointer<Static>
	|-FrameBase.TryGetPointer<StaticRotation>
	|-FrameBase.TryGetPointer<StatusEffectsHolder>
	|-FrameBase.TryGetPointer<StatusEffectsModifiers>
	|-FrameBase.TryGetPointer<StellarCharacter>
	|-FrameBase.TryGetPointer<StellarNPC>
	|-FrameBase.TryGetPointer<SuperBoostVolume>
	|-FrameBase.TryGetPointer<Teams>
	|-FrameBase.TryGetPointer<Transform2D>
	|-FrameBase.TryGetPointer<Transform2DVertical>
	|-FrameBase.TryGetPointer<Transform3D>
	|-FrameBase.TryGetPointer<TrapDoorSwitch>
	|-FrameBase.TryGetPointer<Trigger>
	|-FrameBase.TryGetPointer<TriggerPolygonShape>
	|-FrameBase.TryGetPointer<TriggerSphereShape>
	|-FrameBase.TryGetPointer<VelocityModifier>
	|-FrameBase.TryGetPointer<VisibilitySource>
	|-FrameBase.TryGetPointer<VisibilityTarget>
	|-FrameBase.TryGetPointer<VisualShake>
	|-FrameBase.TryGetPointer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220C0F0 Offset: 0x220A6F0 VA: 0x18220C0F0
	public bool Has(EntityRef entityRef, int componentIndex) { }

	// RVA: -1 Offset: -1
	public bool Has<T>(EntityRef entityRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AD20 Offset: 0xB49320 VA: 0x180B4AD20
	|-FrameBase.Has<CameraManager>
	|-FrameBase.Has<CharacterController3D>
	|-FrameBase.Has<GameEntity>
	|-FrameBase.Has<NavMeshAvoidanceAgent>
	|-FrameBase.Has<NavMeshPathfinder>
	|-FrameBase.Has<NavMeshSteeringAgent>
	|-FrameBase.Has<PhysicsBody2D>
	|-FrameBase.Has<PhysicsBody3D>
	|-FrameBase.Has<PhysicsCallbacks2D>
	|-FrameBase.Has<PhysicsCallbacks3D>
	|-FrameBase.Has<SpeedRunnersCharacter>
	|-FrameBase.Has<Static>
	|-FrameBase.Has<Transform2D>
	|-FrameBase.Has<Transform2DVertical>
	|-FrameBase.Has<Transform3D>
	|-FrameBase.Has<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGet<T>(EntityRef entityRef, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB500F0 Offset: 0xB4E6F0 VA: 0x180B500F0
	|-FrameBase.TryGet<GameEntity>
	|
	|-RVA: 0xB504D0 Offset: 0xB4EAD0 VA: 0x180B504D0
	|-FrameBase.TryGet<StellarCharacter>
	|
	|-RVA: 0xB50310 Offset: 0xB4E910 VA: 0x180B50310
	|-FrameBase.TryGet<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220CFA0 Offset: 0x220B5A0 VA: 0x18220CFA0
	internal bool RemoveComponentIndexUnchecked(EntityRef entityRef, int componentIndex) { }

	// RVA: -1 Offset: -1
	public bool Remove<T>(EntityRef entityRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AD90 Offset: 0xB49390 VA: 0x180B4AD90
	|-FrameBase.Remove<PhysicsCallbacks2D>
	|-FrameBase.Remove<PhysicsCallbacks3D>
	|-FrameBase.Remove<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220A680 Offset: 0x2208C80 VA: 0x18220A680
	internal void CommitAllCommands() { }

	// RVA: 0x220B9A0 Offset: 0x2209FA0 VA: 0x18220B9A0
	public bool Destroy(EntityRef entityRef) { }

	// RVA: 0x220A100 Offset: 0x2208700 VA: 0x18220A100
	private void ChangeCapacity(int newCapacity) { }

	// RVA: 0x220B1F0 Offset: 0x22097F0 VA: 0x18220B1F0
	public EntityRef Create(AssetRefEntityPrototype prototype) { }

	// RVA: 0x220B6E0 Offset: 0x2209CE0 VA: 0x18220B6E0
	public EntityRef Create(EntityPrototype prototype) { }

	// RVA: 0x220B270 Offset: 0x2209870 VA: 0x18220B270
	public void Create(EntityPrototypeContainer[] prototypes, Map parentAsset) { }

	// RVA: 0x220C8E0 Offset: 0x220AEE0 VA: 0x18220C8E0
	private bool MaterializePrototypeInternal(EntityRef entity, EntityPrototypeContainer container, EntityPrototypeRef prototypeRef, EntityRef[] mapEntities, ComponentSet* overridenComponents) { }

	// RVA: 0x220C5F0 Offset: 0x220ABF0 VA: 0x18220C5F0
	private void InvokeEntityPrototypeMaterializedListeners(EntityRef entity, EntityPrototypeContainer container, EntityPrototypeRef prototypeRef) { }

	// RVA: 0x220B920 Offset: 0x2209F20 VA: 0x18220B920
	public EntityRef Create() { }

	// RVA: 0x220AF00 Offset: 0x2209500 VA: 0x18220AF00
	private void ComponentRemoveSignals(EntityRef entity, int componentIndex) { }

	// RVA: 0x220A6A0 Offset: 0x2208CA0 VA: 0x18220A6A0
	private void CommitDestroys() { }

	// RVA: 0x220AB20 Offset: 0x2209120 VA: 0x18220AB20
	private void CommitRemoves() { }

	// RVA: 0xB479F0 Offset: 0xB45FF0 VA: 0x180B479F0
	private void CheckExistsAndThrowIfNot(EntityRef entityRef) { }

	// RVA: -1 Offset: -1
	internal ComponentDataBuffer* GetDataBuffer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AC40 Offset: 0xB49240 VA: 0x180B4AC40
	|-FrameBase.GetDataBuffer<AIVolume>
	|-FrameBase.GetDataBuffer<BaseGameModeManager>
	|-FrameBase.GetDataBuffer<Blastzone>
	|-FrameBase.GetDataBuffer<BossFightGameModeManager>
	|-FrameBase.GetDataBuffer<CameraManager>
	|-FrameBase.GetDataBuffer<CameraTarget>
	|-FrameBase.GetDataBuffer<CampaignBoss>
	|-FrameBase.GetDataBuffer<CampaignRaceGameModeManager>
	|-FrameBase.GetDataBuffer<CheckpointManager>
	|-FrameBase.GetDataBuffer<CollectorCharacter>
	|-FrameBase.GetDataBuffer<CollectorTreasure>
	|-FrameBase.GetDataBuffer<CollectorsGameModeManager>
	|-FrameBase.GetDataBuffer<CollectorsTreasureSpawnArea>
	|-FrameBase.GetDataBuffer<Combat>
	|-FrameBase.GetDataBuffer<CombatStamina>
	|-FrameBase.GetDataBuffer<ContinuousRotation>
	|-FrameBase.GetDataBuffer<CustomAnimator>
	|-FrameBase.GetDataBuffer<DestroyEntitiesManager>
	|-FrameBase.GetDataBuffer<DynamicStageElement>
	|-FrameBase.GetDataBuffer<EndlessGameModeManager>
	|-FrameBase.GetDataBuffer<EscapeRoomGameModeManager>
	|-FrameBase.GetDataBuffer<FrameByFrame>
	|-FrameBase.GetDataBuffer<GameEntity>
	|-FrameBase.GetDataBuffer<GameModeItemAutoTrigger>
	|-FrameBase.GetDataBuffer<GameTimeManager>
	|-FrameBase.GetDataBuffer<GoldenHook>
	|-FrameBase.GetDataBuffer<Grab>
	|-FrameBase.GetDataBuffer<HazardsRaceGameModeManager>
	|-FrameBase.GetDataBuffer<InitialWaitTimer>
	|-FrameBase.GetDataBuffer<InputBuffer>
	|-FrameBase.GetDataBuffer<ItemAutoTrigger>
	|-FrameBase.GetDataBuffer<ItemBox>
	|-FrameBase.GetDataBuffer<KinematicBody>
	|-FrameBase.GetDataBuffer<LayoutManager>
	|-FrameBase.GetDataBuffer<MatchTimer>
	|-FrameBase.GetDataBuffer<MechanicTutorialGameModeManager>
	|-FrameBase.GetDataBuffer<Movable>
	|-FrameBase.GetDataBuffer<ParentObject>
	|-FrameBase.GetDataBuffer<PartnersManager>
	|-FrameBase.GetDataBuffer<PhysicsBody>
	|-FrameBase.GetDataBuffer<PlatformFightGameModeManager>
	|-FrameBase.GetDataBuffer<PlayerManager>
	|-FrameBase.GetDataBuffer<PlayerStats>
	|-FrameBase.GetDataBuffer<RaceGameModeManager>
	|-FrameBase.GetDataBuffer<RaceTutorialGameModeManager>
	|-FrameBase.GetDataBuffer<RespawnPoint>
	|-FrameBase.GetDataBuffer<RoomMember>
	|-FrameBase.GetDataBuffer<SpawnPoint>
	|-FrameBase.GetDataBuffer<SpeedRunnersBlastzone>
	|-FrameBase.GetDataBuffer<SpeedRunnersCharacter>
	|-FrameBase.GetDataBuffer<SpeedRunnersItem>
	|-FrameBase.GetDataBuffer<SpeedRunnersNPC>
	|-FrameBase.GetDataBuffer<StageBounds>
	|-FrameBase.GetDataBuffer<StageEdge>
	|-FrameBase.GetDataBuffer<StageSFX>
	|-FrameBase.GetDataBuffer<StageTimeline>
	|-FrameBase.GetDataBuffer<StateMachine>
	|-FrameBase.GetDataBuffer<StatusEffectsHolder>
	|-FrameBase.GetDataBuffer<StellarCharacter>
	|-FrameBase.GetDataBuffer<TournamentGameModeManager>
	|-FrameBase.GetDataBuffer<TrainingGameModeManager>
	|-FrameBase.GetDataBuffer<Transform2D>
	|-FrameBase.GetDataBuffer<Transform3D>
	|-FrameBase.GetDataBuffer<TrapDoor>
	|-FrameBase.GetDataBuffer<TrapDoorSwitch>
	|-FrameBase.GetDataBuffer<Trigger>
	|-FrameBase.GetDataBuffer<VelocityModifier>
	|-FrameBase.GetDataBuffer<VisibilitySource>
	|-FrameBase.GetDataBuffer<VisibilityTarget>
	|-FrameBase.GetDataBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220D140 Offset: 0x220B740 VA: 0x18220D140
	private static int RoundToCulledByteSize(int size) { }

	// RVA: 0x220D150 Offset: 0x220B750 VA: 0x18220D150
	private static int RoundToCulledWordCount(int size) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract PhysicsSceneSettings* get_PhysicsSceneSettings();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Map get_Map();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract NavMeshRegionMask* get_NavMeshRegionMask();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract FrameMetaData* get_FrameMetaData();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract PhysicsEngineState* get__physicsState2D();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract PhysicsEngineState* get__physicsState3D();

	// RVA: 0x1218690 Offset: 0x1216C90 VA: 0x181218690
	internal PhysicsEngineState* get__physicsStateInternal2D() { }

	// RVA: 0x1E6A6D0 Offset: 0x1E68CD0 VA: 0x181E6A6D0
	internal PhysicsEngineState* get__physicsStateInternal3D() { }

	// RVA: 0x220DFD0 Offset: 0x220C5D0 VA: 0x18220DFD0
	public Navigation get_Navigation() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract FP get_DeltaTime();

	// RVA: 0x5A5150 Offset: 0x5A3750 VA: 0x1805A5150
	public FrameContext get_Context() { }

	// RVA: 0x7A90E0 Offset: 0x7A76E0 VA: 0x1807A90E0
	public FrameHeap get_TrackedHeap() { }

	// RVA: 0x220DEA0 Offset: 0x220C4A0 VA: 0x18220DEA0
	protected void .ctor(FrameContext context) { }

	// RVA: 0x220BD10 Offset: 0x220A310 VA: 0x18220BD10 Slot: 6
	public override void Free() { }

	// RVA: 0x220BF80 Offset: 0x220A580 VA: 0x18220BF80
	public FrameBase.Stats GetMemoryStats() { }

	// RVA: 0x220D110 Offset: 0x220B710 VA: 0x18220D110
	internal QListInternal* ResolveList(Ptr ptr) { }

	// RVA: -1 Offset: -1
	public QList<T> ResolveList<T>(QListPtr<T> ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AEE0 Offset: 0xB494E0 VA: 0x180B4AEE0
	|-FrameBase.ResolveList<ActionData>
	|-FrameBase.ResolveList<AnimationSpeedElement>
	|-FrameBase.ResolveList<ChildEntity>
	|-FrameBase.ResolveList<EntityRef>
	|-FrameBase.ResolveList<ExperienceEventData>
	|-FrameBase.ResolveList<FPVector2>
	|-FrameBase.ResolveList<GameEntityReference>
	|-FrameBase.ResolveList<HitBox>
	|-FrameBase.ResolveList<HitEvent>
	|-FrameBase.ResolveList<HurtBox>
	|-FrameBase.ResolveList<int>
	|-FrameBase.ResolveList<ObjectVisibilityData>
	|-FrameBase.ResolveList<RuntimeGameSpeedModifier>
	|-FrameBase.ResolveList<RuntimeMechanicTutorialGoal>
	|-FrameBase.ResolveList<RuntimeStatusEffect>
	|-FrameBase.ResolveList<SFXToExecute>
	|-FrameBase.ResolveList<ScheduledBehaviour>
	|-FrameBase.ResolveList<SlotAttachmentData>
	|-FrameBase.ResolveList<StageEntity>
	|-FrameBase.ResolveList<StatusEffectAttributeModifier>
	|-FrameBase.ResolveList<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public QList<T> AllocateList<T>(int capacity = 8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB487D0 Offset: 0xB46DD0 VA: 0x180B487D0
	|-FrameBase.AllocateList<ActionData>
	|-FrameBase.AllocateList<ChildEntity>
	|-FrameBase.AllocateList<RuntimeGameSpeedModifier>
	|
	|-RVA: 0xB48890 Offset: 0xB46E90 VA: 0x180B48890
	|-FrameBase.AllocateList<AnimationSpeedElement>
	|-FrameBase.AllocateList<FPVector2>
	|-FrameBase.AllocateList<HitEvent>
	|-FrameBase.AllocateList<ScheduledBehaviour>
	|-FrameBase.AllocateList<StatusEffectAttributeModifier>
	|
	|-RVA: 0xB489B0 Offset: 0xB46FB0 VA: 0x180B489B0
	|-FrameBase.AllocateList<EntityRef>
	|-FrameBase.AllocateList<RuntimeMechanicTutorialGoal>
	|
	|-RVA: 0xB48A70 Offset: 0xB47070 VA: 0x180B48A70
	|-FrameBase.AllocateList<ExperienceEventData>
	|
	|-RVA: 0xB48B30 Offset: 0xB47130 VA: 0x180B48B30
	|-FrameBase.AllocateList<HitBox>
	|
	|-RVA: 0xB48BF0 Offset: 0xB471F0 VA: 0x180B48BF0
	|-FrameBase.AllocateList<HurtBox>
	|
	|-RVA: 0xB48CB0 Offset: 0xB472B0 VA: 0x180B48CB0
	|-FrameBase.AllocateList<int>
	|
	|-RVA: 0xB48D70 Offset: 0xB47370 VA: 0x180B48D70
	|-FrameBase.AllocateList<ObjectVisibilityData>
	|-FrameBase.AllocateList<SlotAttachmentData>
	|
	|-RVA: 0xB48E30 Offset: 0xB47430 VA: 0x180B48E30
	|-FrameBase.AllocateList<RuntimeStatusEffect>
	|
	|-RVA: 0xB48EF0 Offset: 0xB474F0 VA: 0x180B48EF0
	|-FrameBase.AllocateList<SFXToExecute>
	|
	|-RVA: 0xB48FB0 Offset: 0xB475B0 VA: 0x180B48FB0
	|-FrameBase.AllocateList<StageEntity>
	|
	|-RVA: 0xB48380 Offset: 0xB46980 VA: 0x180B48380
	|-FrameBase.AllocateList<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public QList<T> AllocateList<T>(QListPtr<T> ptr, int capacity = 8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB48830 Offset: 0xB46E30 VA: 0x180B48830
	|-FrameBase.AllocateList<ActionData>
	|-FrameBase.AllocateList<ChildEntity>
	|-FrameBase.AllocateList<RuntimeGameSpeedModifier>
	|
	|-RVA: 0xB488F0 Offset: 0xB46EF0 VA: 0x180B488F0
	|-FrameBase.AllocateList<AnimationSpeedElement>
	|-FrameBase.AllocateList<FPVector2>
	|-FrameBase.AllocateList<HitEvent>
	|-FrameBase.AllocateList<ScheduledBehaviour>
	|-FrameBase.AllocateList<StatusEffectAttributeModifier>
	|
	|-RVA: 0xB48950 Offset: 0xB46F50 VA: 0x180B48950
	|-FrameBase.AllocateList<EntityRef>
	|-FrameBase.AllocateList<RuntimeMechanicTutorialGoal>
	|
	|-RVA: 0xB48A10 Offset: 0xB47010 VA: 0x180B48A10
	|-FrameBase.AllocateList<ExperienceEventData>
	|-FrameBase.AllocateList<TargetStatePerEntity>
	|
	|-RVA: 0xB48AD0 Offset: 0xB470D0 VA: 0x180B48AD0
	|-FrameBase.AllocateList<GameEntityReference>
	|
	|-RVA: 0xB48B90 Offset: 0xB47190 VA: 0x180B48B90
	|-FrameBase.AllocateList<HitBox>
	|
	|-RVA: 0xB48C50 Offset: 0xB47250 VA: 0x180B48C50
	|-FrameBase.AllocateList<HurtBox>
	|
	|-RVA: 0xB48D10 Offset: 0xB47310 VA: 0x180B48D10
	|-FrameBase.AllocateList<int>
	|
	|-RVA: 0xB48DD0 Offset: 0xB473D0 VA: 0x180B48DD0
	|-FrameBase.AllocateList<ObjectVisibilityData>
	|-FrameBase.AllocateList<SlotAttachmentData>
	|
	|-RVA: 0xB48E90 Offset: 0xB47490 VA: 0x180B48E90
	|-FrameBase.AllocateList<RuntimeStatusEffect>
	|
	|-RVA: 0xB48F50 Offset: 0xB47550 VA: 0x180B48F50
	|-FrameBase.AllocateList<SFXToExecute>
	|
	|-RVA: 0xB49010 Offset: 0xB47610 VA: 0x180B49010
	|-FrameBase.AllocateList<StageEntity>
	|
	|-RVA: 0xB482F0 Offset: 0xB468F0 VA: 0x180B482F0
	|-FrameBase.AllocateList<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void FreeList<T>(QListPtr<T> ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49E30 Offset: 0xB48430 VA: 0x180B49E30
	|-FrameBase.FreeList<ActionData>
	|
	|-RVA: 0xB49EE0 Offset: 0xB484E0 VA: 0x180B49EE0
	|-FrameBase.FreeList<AnimationSpeedElement>
	|
	|-RVA: 0xB49F90 Offset: 0xB48590 VA: 0x180B49F90
	|-FrameBase.FreeList<ChildEntity>
	|
	|-RVA: 0xB4A040 Offset: 0xB48640 VA: 0x180B4A040
	|-FrameBase.FreeList<EntityRef>
	|
	|-RVA: 0xB4A0F0 Offset: 0xB486F0 VA: 0x180B4A0F0
	|-FrameBase.FreeList<ExperienceEventData>
	|
	|-RVA: 0xB4A1A0 Offset: 0xB487A0 VA: 0x180B4A1A0
	|-FrameBase.FreeList<FPVector2>
	|
	|-RVA: 0xB4A250 Offset: 0xB48850 VA: 0x180B4A250
	|-FrameBase.FreeList<HitBox>
	|
	|-RVA: 0xB4A300 Offset: 0xB48900 VA: 0x180B4A300
	|-FrameBase.FreeList<HitEvent>
	|
	|-RVA: 0xB4A3B0 Offset: 0xB489B0 VA: 0x180B4A3B0
	|-FrameBase.FreeList<HurtBox>
	|
	|-RVA: 0xB4A460 Offset: 0xB48A60 VA: 0x180B4A460
	|-FrameBase.FreeList<int>
	|
	|-RVA: 0xB4A510 Offset: 0xB48B10 VA: 0x180B4A510
	|-FrameBase.FreeList<ObjectVisibilityData>
	|
	|-RVA: 0xB4A5C0 Offset: 0xB48BC0 VA: 0x180B4A5C0
	|-FrameBase.FreeList<RuntimeGameSpeedModifier>
	|
	|-RVA: 0xB4A670 Offset: 0xB48C70 VA: 0x180B4A670
	|-FrameBase.FreeList<RuntimeMechanicTutorialGoal>
	|
	|-RVA: 0xB4A720 Offset: 0xB48D20 VA: 0x180B4A720
	|-FrameBase.FreeList<RuntimeStatusEffect>
	|
	|-RVA: 0xB4A7D0 Offset: 0xB48DD0 VA: 0x180B4A7D0
	|-FrameBase.FreeList<SFXToExecute>
	|
	|-RVA: 0xB4A880 Offset: 0xB48E80 VA: 0x180B4A880
	|-FrameBase.FreeList<ScheduledBehaviour>
	|
	|-RVA: 0xB4A930 Offset: 0xB48F30 VA: 0x180B4A930
	|-FrameBase.FreeList<SlotAttachmentData>
	|
	|-RVA: 0xB4A9E0 Offset: 0xB48FE0 VA: 0x180B4A9E0
	|-FrameBase.FreeList<StageEntity>
	|
	|-RVA: 0xB4AA90 Offset: 0xB49090 VA: 0x180B4AA90
	|-FrameBase.FreeList<StatusEffectAttributeModifier>
	|
	|-RVA: 0xB49D00 Offset: 0xB48300 VA: 0x180B49D00
	|-FrameBase.FreeList<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public bool TryResolveList<T>(QListPtr<T> ptr, out QList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB50CF0 Offset: 0xB4F2F0 VA: 0x180B50CF0
	|-FrameBase.TryResolveList<ActionData>
	|-FrameBase.TryResolveList<AnimationSpeedElement>
	|-FrameBase.TryResolveList<ChildEntity>
	|-FrameBase.TryResolveList<EntityRef>
	|-FrameBase.TryResolveList<ExperienceEventData>
	|-FrameBase.TryResolveList<FPVector2>
	|-FrameBase.TryResolveList<GameEntityReference>
	|-FrameBase.TryResolveList<HitBox>
	|-FrameBase.TryResolveList<HitEvent>
	|-FrameBase.TryResolveList<HurtBox>
	|-FrameBase.TryResolveList<int>
	|-FrameBase.TryResolveList<ObjectVisibilityData>
	|-FrameBase.TryResolveList<RuntimeGameSpeedModifier>
	|-FrameBase.TryResolveList<RuntimeMechanicTutorialGoal>
	|-FrameBase.TryResolveList<RuntimeStatusEffect>
	|-FrameBase.TryResolveList<SFXToExecute>
	|-FrameBase.TryResolveList<ScheduledBehaviour>
	|-FrameBase.TryResolveList<SlotAttachmentData>
	|-FrameBase.TryResolveList<StageEntity>
	|-FrameBase.TryResolveList<StatusEffectAttributeModifier>
	|
	|-RVA: 0xB50C70 Offset: 0xB4F270 VA: 0x180B50C70
	|-FrameBase.TryResolveList<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220D110 Offset: 0x220B710 VA: 0x18220D110
	internal QDictionaryInternal* ResolveDictionary(Ptr ptr) { }

	// RVA: -1 Offset: -1
	public QDictionary<K, V> ResolveDictionary<K, V>(QDictionaryPtr<K, V> ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AE00 Offset: 0xB49400 VA: 0x180B4AE00
	|-FrameBase.ResolveDictionary<int, CustomSubAnimatorPlayableClipInfo>
	|-FrameBase.ResolveDictionary<int, MoveLimit>
	|-FrameBase.ResolveDictionary<QString128, FP>
	|-FrameBase.ResolveDictionary<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public QDictionary<K, V> AllocateDictionary<K, V>(int capacity = 8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB48410 Offset: 0xB46A10 VA: 0x180B48410
	|-FrameBase.AllocateDictionary<int, CustomSubAnimatorPlayableClipInfo>
	|
	|-RVA: 0xB48530 Offset: 0xB46B30 VA: 0x180B48530
	|-FrameBase.AllocateDictionary<int, MoveLimit>
	|
	|-RVA: 0xB48590 Offset: 0xB46B90 VA: 0x180B48590
	|-FrameBase.AllocateDictionary<QString128, FP>
	|
	|-RVA: 0xB48380 Offset: 0xB46980 VA: 0x180B48380
	|-FrameBase.AllocateDictionary<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public QDictionary<K, V> AllocateDictionary<K, V>(QDictionaryPtr<K, V> ptr, int capacity = 8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB48470 Offset: 0xB46A70 VA: 0x180B48470
	|-FrameBase.AllocateDictionary<int, CustomSubAnimatorPlayableClipInfo>
	|
	|-RVA: 0xB484D0 Offset: 0xB46AD0 VA: 0x180B484D0
	|-FrameBase.AllocateDictionary<int, MoveLimit>
	|
	|-RVA: 0xB485F0 Offset: 0xB46BF0 VA: 0x180B485F0
	|-FrameBase.AllocateDictionary<QString128, FP>
	|
	|-RVA: 0xB482F0 Offset: 0xB468F0 VA: 0x180B482F0
	|-FrameBase.AllocateDictionary<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public bool TryResolveDictionary<K, V>(QDictionaryPtr<K, V> ptr, out QDictionary<K, V> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB50B70 Offset: 0xB4F170 VA: 0x180B50B70
	|-FrameBase.TryResolveDictionary<int, CustomSubAnimatorPlayableClipInfo>
	|-FrameBase.TryResolveDictionary<int, MoveLimit>
	|-FrameBase.TryResolveDictionary<QString128, FP>
	|
	|-RVA: 0xB50AF0 Offset: 0xB4F0F0 VA: 0x180B50AF0
	|-FrameBase.TryResolveDictionary<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void FreeDictionary<K, V>(QDictionaryPtr<K, V> ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49B70 Offset: 0xB48170 VA: 0x180B49B70
	|-FrameBase.FreeDictionary<int, CustomSubAnimatorPlayableClipInfo>
	|
	|-RVA: 0xB49BE0 Offset: 0xB481E0 VA: 0x180B49BE0
	|-FrameBase.FreeDictionary<int, MoveLimit>
	|
	|-RVA: 0xB49B00 Offset: 0xB48100 VA: 0x180B49B00
	|-FrameBase.FreeDictionary<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220D110 Offset: 0x220B710 VA: 0x18220D110
	internal QHashCollection* ResolveHashCollection(Ptr ptr) { }

	// RVA: -1 Offset: -1
	public QHashSet<T> ResolveHashSet<T>(QHashSetPtr<T> ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4AE70 Offset: 0xB49470 VA: 0x180B4AE70
	|-FrameBase.ResolveHashSet<AssetGuid>
	|-FrameBase.ResolveHashSet<int>
	|-FrameBase.ResolveHashSet<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public QHashSet<T> AllocateHashSet<T>(int capacity = 8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB486B0 Offset: 0xB46CB0 VA: 0x180B486B0
	|-FrameBase.AllocateHashSet<AssetGuid>
	|
	|-RVA: 0xB48710 Offset: 0xB46D10 VA: 0x180B48710
	|-FrameBase.AllocateHashSet<int>
	|
	|-RVA: 0xB48380 Offset: 0xB46980 VA: 0x180B48380
	|-FrameBase.AllocateHashSet<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public QHashSet<T> AllocateHashSet<T>(QHashSetPtr<T> ptr, int capacity = 8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB48650 Offset: 0xB46C50 VA: 0x180B48650
	|-FrameBase.AllocateHashSet<AssetGuid>
	|
	|-RVA: 0xB48770 Offset: 0xB46D70 VA: 0x180B48770
	|-FrameBase.AllocateHashSet<int>
	|
	|-RVA: 0xB482F0 Offset: 0xB468F0 VA: 0x180B482F0
	|-FrameBase.AllocateHashSet<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void FreeHashSet<T>(QHashSetPtr<T> ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49C50 Offset: 0xB48250 VA: 0x180B49C50
	|-FrameBase.FreeHashSet<AssetGuid>
	|
	|-RVA: 0xB49D80 Offset: 0xB48380 VA: 0x180B49D80
	|-FrameBase.FreeHashSet<int>
	|
	|-RVA: 0xB49D00 Offset: 0xB48300 VA: 0x180B49D00
	|-FrameBase.FreeHashSet<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public bool TryResolveHashSet<T>(QHashSetPtr<T> ptr, out QHashSet<T> hashSet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB50BF0 Offset: 0xB4F1F0 VA: 0x180B50BF0
	|-FrameBase.TryResolveHashSet<AssetGuid>
	|-FrameBase.TryResolveHashSet<int>
	|
	|-RVA: 0xB50C70 Offset: 0xB4F270 VA: 0x180B50C70
	|-FrameBase.TryResolveHashSet<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x220CA70 Offset: 0x220B070 VA: 0x18220CA70
	public void OnFrameSimulateBegin() { }

	// RVA: 0x220CB30 Offset: 0x220B130 VA: 0x18220CB30
	public void OnFrameSimulateEnd() { }

	// RVA: -1 Offset: -1
	public AddResult Add<T>(EntityRef entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB47ED0 Offset: 0xB464D0 VA: 0x180B47ED0
	|-FrameBase.Add<NavMeshSteeringAgent>
	|
	|-RVA: 0xB480E0 Offset: 0xB466E0 VA: 0x180B480E0
	|-FrameBase.Add<Transform2D>
	|
	|-RVA: 0xB47AB0 Offset: 0xB460B0 VA: 0x180B47AB0
	|-FrameBase.Add<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T FindAsset<T>(AssetGuid guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49970 Offset: 0xB47F70 VA: 0x180B49970
	|-FrameBase.FindAsset<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryFindAsset<TAssetRef, T>(TAssetRef assetRef, out T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4FED0 Offset: 0xB4E4D0 VA: 0x180B4FED0
	|-FrameBase.TryFindAsset<AssetRefAnimationBakedJointsData, object>
	|-FrameBase.TryFindAsset<AssetRefAnimationClipData, object>
	|-FrameBase.TryFindAsset<AssetRefAnimationsPoolData, object>
	|-FrameBase.TryFindAsset<AssetRefApplyImpulse_Behaviour, object>
	|-FrameBase.TryFindAsset<AssetRefAttackDatasPool, object>
	|-FrameBase.TryFindAsset<AssetRefBaseGameMode, object>
	|-FrameBase.TryFindAsset<AssetRefCameraManagerData, object>
	|-FrameBase.TryFindAsset<AssetRefCombatData, object>
	|-FrameBase.TryFindAsset<AssetRefGameEntityData, object>
	|-FrameBase.TryFindAsset<AssetRefGlobalCameraSettingsData, object>
	|-FrameBase.TryFindAsset<AssetRefGrabData, object>
	|-FrameBase.TryFindAsset<AssetRefJumpSettingsData, object>
	|-FrameBase.TryFindAsset<AssetRefMovesetLimiterData, object>
	|-FrameBase.TryFindAsset<AssetRefPhysicsData, object>
	|-FrameBase.TryFindAsset<AssetRefPhysicsMaterial, object>
	|-FrameBase.TryFindAsset<AssetRefPickupItemUsageData, object>
	|-FrameBase.TryFindAsset<AssetRefState, object>
	|-FrameBase.TryFindAsset<AssetRefStateBehaviour, object>
	|-FrameBase.TryFindAsset<AssetRefStateMachineData, object>
	|-FrameBase.TryFindAsset<AssetRefStatusEffectBase, object>
	|-FrameBase.TryFindAsset<AssetRefTransformKeyFramesData, object>
	|
	|-RVA: 0xB4FF20 Offset: 0xB4E520 VA: 0x180B4FF20
	|-FrameBase.TryFindAsset<__Il2CppFullySharedGenericStructType, object>
	*/

	// RVA: -1 Offset: -1
	public bool TryFindAsset<T>(AssetRef assetRef, out T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4FF70 Offset: 0xB4E570 VA: 0x180B4FF70
	|-FrameBase.TryFindAsset<object>
	*/

	// RVA: 0x220A5B0 Offset: 0x2208BB0 VA: 0x18220A5B0
	public void ClearAllNavMeshRegions() { }

	// RVA: -1 Offset: -1
	internal bool TryFindAssetInternal<T>(AssetGuid guid, bool isMainThread, out T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4FDB0 Offset: 0xB4E3B0 VA: 0x180B4FDB0
	|-FrameBase.TryFindAssetInternal<object>
	*/

	// RVA: -1 Offset: -1
	internal T FindAssetInternal<T>(AssetGuid guid, bool isMainThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB497F0 Offset: 0xB47DF0 VA: 0x180B497F0
	|-FrameBase.FindAssetInternal<object>
	*/

	// RVA: 0x220C730 Offset: 0x220AD30 VA: 0x18220C730
	private static void LogAssetNotFound(AssetGuid guid, Type assetType) { }

	// RVA: 0x220C7F0 Offset: 0x220ADF0 VA: 0x18220C7F0
	private static void LogAssetTypeMismatch(AssetGuid guid, Type expectedType, Type assetType) { }

	// RVA: 0x220C180 Offset: 0x220A780 VA: 0x18220C180
	internal void InitTrackedHeap(IHeapAllocationTracker tracker) { }
}
