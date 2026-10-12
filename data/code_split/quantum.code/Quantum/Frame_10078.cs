// Namespace: Quantum
public class Frame : FrameBase // TypeDefIndex: 10078
{
	// Fields
	public const int DumpFlag_NoSimulationConfig = 2;
	public const int DumpFlag_NoRuntimeConfig = 8;
	public const int DumpFlag_NoDeterministicSessionConfig = 16;
	public const int DumpFlag_NoRuntimePlayers = 32;
	public const int DumpFlag_NoDynamicDB = 64;
	public const int DumpFlag_ReadableDynamicDB = 128;
	public const int DumpFlag_PrintRawValues = 256;
	public const int DumpFlag_ComponentChecksums = 512;
	public const int DumpFlag_AssetDBCheckums = 1024;
	public const int DumpFlag_NoIsVerified = 2048;
	[Obsolete("Use DumpFlag_ComponentChecksums")]
	public const int DumpFlag_PrintComponentChecksums = 512;
	[Obsolete("Use DumpFlag_ReadableDynamicDB")]
	public const int DumpFlag_PrintReadableDynamicDB = 128;
	[DebuggerBrowsable(0)]
	private _globals_* _globals; // 0xC8
	private RuntimeConfig _runtimeConfig; // 0xD0
	private SimulationConfig _simulationConfig; // 0xD8
	private DeterministicSessionConfig _sessionConfig; // 0xE0
	private SystemBase[] _systemsAll; // 0xE8
	private SystemBase[] _systemsRoots; // 0xF0
	private Dictionary<Type, int> _systemIndexByType; // 0xF8
	private PersistentMap<int, Frame.RuntimePlayerData> _playerData; // 0x100
	private List<Frame.RuntimePlayerData> _oldPlayerData; // 0x108
	private ISignalOnPlayerDataSet[] _ISignalOnPlayerDataSet; // 0x110
	private ISignalOnCollision2D[] _ISignalOnCollision2DSystems; // 0x118
	private ISignalOnCollisionEnter2D[] _ISignalOnCollisionEnter2DSystems; // 0x120
	private ISignalOnCollisionExit2D[] _ISignalOnCollisionExit2DSystems; // 0x128
	private ISignalOnTrigger2D[] _ISignalOnTrigger2DSystems; // 0x130
	private ISignalOnTriggerEnter2D[] _ISignalOnTriggerEnter2DSystems; // 0x138
	private ISignalOnTriggerExit2D[] _ISignalOnTriggerExit2DSystems; // 0x140
	private ISignalOnCollision3D[] _ISignalOnCollision3DSystems; // 0x148
	private ISignalOnCollisionEnter3D[] _ISignalOnCollisionEnter3DSystems; // 0x150
	private ISignalOnCollisionExit3D[] _ISignalOnCollisionExit3DSystems; // 0x158
	private ISignalOnTrigger3D[] _ISignalOnTrigger3DSystems; // 0x160
	private ISignalOnTriggerEnter3D[] _ISignalOnTriggerEnter3DSystems; // 0x168
	private ISignalOnTriggerExit3D[] _ISignalOnTriggerExit3DSystems; // 0x170
	private ISignalOnNavMeshWaypointReached[] _ISignalOnNavMeshWaypointReachedSystems; // 0x178
	private ISignalOnNavMeshSearchFailed[] _ISignalOnNavMeshSearchFailedSystems; // 0x180
	private ISignalOnNavMeshMoveAgent[] _ISignalOnNavMeshMoveAgentSystems; // 0x188
	private ISignalOnMapChanged[] _ISignalOnMapChangedSystems; // 0x190
	private ISignalOnEntityPrototypeMaterialized[] _ISignalOnEntityPrototypeMaterializedSystems; // 0x198
	private ISignalOnPlayerConnected[] _ISignalOnPlayerConnectedSystems; // 0x1A0
	private ISignalOnPlayerDisconnected[] _ISignalOnPlayerDisconnectedSystems; // 0x1A8
	public Frame.FrameSignals Signals; // 0x1B0
	public Frame.FrameEvents Events; // 0x1B8
	public Frame.FrameAssets Assets; // 0x1C0

	// Properties
	[DebuggerBrowsable(0)]
	public _globals_* Global { get; }
	[DebuggerBrowsable(0)]
	public RNGSession* RNG { get; }
	public int PlayerCount { get; }
	public override NavMeshRegionMask* NavMeshRegionMask { get; }
	public override FrameMetaData* FrameMetaData { get; }
	protected override PhysicsEngineState* _physicsState2D { get; }
	protected override PhysicsEngineState* _physicsState3D { get; }
	public override CommitCommandsModes CommitCommandsMode { get; }
	public FrameContextUser Context { get; }
	public RuntimeConfig RuntimeConfig { get; set; }
	public SimulationConfig SimulationConfig { get; set; }
	public DeterministicSessionConfig SessionConfig { get; set; }
	public sealed override PhysicsSceneSettings* PhysicsSceneSettings { get; }
	public override FP DeltaTime { get; }
	public sealed override Map Map { get; }

	// Methods

	// RVA: 0x2146910 Offset: 0x2144F10 VA: 0x182146910
	public void SetPlayerInput(int player, Input input) { }

	// RVA: 0x2143F00 Offset: 0x2142500 VA: 0x182143F00
	public Input* GetPlayerInput(int player) { }

	// RVA: 0x73FE10 Offset: 0x73E410 VA: 0x18073FE10
	public _globals_* get_Global() { }

	// RVA: 0x2147F80 Offset: 0x2146580 VA: 0x182147F80
	public RNGSession* get_RNG() { }

	// RVA: 0x2147F60 Offset: 0x2146560 VA: 0x182147F60
	public int get_PlayerCount() { }

	// RVA: 0x2147F00 Offset: 0x2146500 VA: 0x182147F00 Slot: 13
	public override NavMeshRegionMask* get_NavMeshRegionMask() { }

	// RVA: 0x2147E50 Offset: 0x2146450 VA: 0x182147E50 Slot: 14
	public override FrameMetaData* get_FrameMetaData() { }

	// RVA: 0x2147FB0 Offset: 0x21465B0 VA: 0x182147FB0 Slot: 15
	protected override PhysicsEngineState* get__physicsState2D() { }

	// RVA: 0x2147FE0 Offset: 0x21465E0 VA: 0x182147FE0 Slot: 16
	protected override PhysicsEngineState* get__physicsState3D() { }

	// RVA: 0x2147D90 Offset: 0x2146390 VA: 0x182147D90 Slot: 10
	public override CommitCommandsModes get_CommitCommandsMode() { }

	// RVA: 0x2147DC0 Offset: 0x21463C0 VA: 0x182147DC0
	public FrameContextUser get_Context() { }

	// RVA: 0x6230C0 Offset: 0x6216C0 VA: 0x1806230C0
	public RuntimeConfig get_RuntimeConfig() { }

	// RVA: 0x6230D0 Offset: 0x6216D0 VA: 0x1806230D0
	internal void set_RuntimeConfig(RuntimeConfig value) { }

	// RVA: 0x502330 Offset: 0x500930 VA: 0x180502330
	public SimulationConfig get_SimulationConfig() { }

	// RVA: 0x1CB31E0 Offset: 0x1CB17E0 VA: 0x181CB31E0
	internal void set_SimulationConfig(SimulationConfig value) { }

	// RVA: 0x7A80E0 Offset: 0x7A66E0 VA: 0x1807A80E0
	public DeterministicSessionConfig get_SessionConfig() { }

	// RVA: 0x818FF0 Offset: 0x8175F0 VA: 0x180818FF0
	internal void set_SessionConfig(DeterministicSessionConfig value) { }

	// RVA: 0x2147F30 Offset: 0x2146530 VA: 0x182147F30 Slot: 11
	public sealed override PhysicsSceneSettings* get_PhysicsSceneSettings() { }

	// RVA: 0x2147E30 Offset: 0x2146430 VA: 0x182147E30 Slot: 17
	public override FP get_DeltaTime() { }

	// RVA: 0x2147E80 Offset: 0x2146480 VA: 0x182147E80 Slot: 12
	public sealed override Map get_Map() { }

	// RVA: 0x2147210 Offset: 0x2145810 VA: 0x182147210
	public void .ctor(FrameContext context, SystemBase[] systemsAll, SystemBase[] systemsRoots, DeterministicSessionConfig sessionConfig, RuntimeConfig runtimeConfig, SimulationConfig simulationConfig, FP deltaTime) { }

	// RVA: 0x2146200 Offset: 0x2144800 VA: 0x182146200 Slot: 7
	public override byte[] Serialize(DeterministicFrameSerializeMode mode) { }

	// RVA: 0x21461B0 Offset: 0x21447B0 VA: 0x1821461B0
	public ArraySegment<byte> Serialize(DeterministicFrameSerializeMode mode, byte[] buffer, int offset = 0, bool allocOutput = False) { }

	// RVA: 0x21462C0 Offset: 0x21448C0 VA: 0x1821462C0
	public ArraySegment<byte> Serialize(DeterministicFrameSerializeMode mode, byte[] buffer, out FrameSerializer serializer, int offset = 0, bool allocOutput = False) { }

	// RVA: 0x21429A0 Offset: 0x2140FA0 VA: 0x1821429A0 Slot: 8
	public override void Deserialize(byte[] data) { }

	// RVA: 0x2146170 Offset: 0x2144770 VA: 0x182146170
	private void SerializeState(FrameSerializer serializer) { }

	// RVA: 0x2145C90 Offset: 0x2144290 VA: 0x182145C90
	private void SerializeRuntimePlayers(BitStream stream) { }

	// RVA: 0x2142740 Offset: 0x2140D40 VA: 0x182142740
	private void DeserializeRuntimePlayers(byte[] bytes) { }

	// RVA: 0x2142480 Offset: 0x2140A80 VA: 0x182142480
	private void DeserializeDynamicAssetDB(byte[] bytes) { }

	// RVA: 0x2142C00 Offset: 0x2141200 VA: 0x182142C00 Slot: 4
	public sealed override string DumpFrame(int dumpFlags = 0) { }

	// RVA: 0x2142070 Offset: 0x2140670 VA: 0x182142070 Slot: 5
	public sealed override ulong CalculateChecksum() { }

	// RVA: 0x21420F0 Offset: 0x21406F0 VA: 0x1821420F0
	public ulong CalculateChecksum(bool useSharedSerializer) { }

	// RVA: 0x2141D90 Offset: 0x2140390 VA: 0x182141D90
	internal ulong CalculateChecksumInternal(FrameSerializer serializer) { }

	// RVA: 0x2142240 Offset: 0x2140840 VA: 0x182142240 Slot: 9
	protected sealed override void Copy(DeterministicFrame frame) { }

	// RVA: 0x2143E20 Offset: 0x2142420 VA: 0x182143E20 Slot: 6
	public sealed override void Free() { }

	// RVA: 0x2146AC0 Offset: 0x21450C0 VA: 0x182146AC0
	public bool SystemIsEnabledSelf(SystemBase s) { }

	// RVA: 0x2146A10 Offset: 0x2145010 VA: 0x182146A10
	public bool SystemIsEnabledInHierarchy(SystemBase system) { }

	// RVA: -1 Offset: -1
	private T[] BuildSignalsArray<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB47760 Offset: 0xB45D60 VA: 0x180B47760
	|-Frame.BuildSignalsArray<object>
	|
	|-RVA: 0xB475C0 Offset: 0xB45BC0 VA: 0x180B475C0
	|-Frame.BuildSignalsArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void BuildSignalsArrayOnComponentAdded<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB46CF0 Offset: 0xB452F0 VA: 0x180B46CF0
	|-Frame.BuildSignalsArrayOnComponentAdded<AIVolume>
	|-Frame.BuildSignalsArrayOnComponentAdded<BaseGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<Blastzone>
	|-Frame.BuildSignalsArrayOnComponentAdded<BlastzoneTrigger>
	|-Frame.BuildSignalsArrayOnComponentAdded<BossFightGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<BreakableGlass>
	|-Frame.BuildSignalsArrayOnComponentAdded<CameraManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<CameraTarget>
	|-Frame.BuildSignalsArrayOnComponentAdded<CampaignBoss>
	|-Frame.BuildSignalsArrayOnComponentAdded<CampaignRaceGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<CharacterController2D>
	|-Frame.BuildSignalsArrayOnComponentAdded<CharacterController3D>
	|-Frame.BuildSignalsArrayOnComponentAdded<Checkpoint>
	|-Frame.BuildSignalsArrayOnComponentAdded<CheckpointManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<CollectorCharacter>
	|-Frame.BuildSignalsArrayOnComponentAdded<CollectorTreasure>
	|-Frame.BuildSignalsArrayOnComponentAdded<CollectorsGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<CollectorsTreasureSpawnArea>
	|-Frame.BuildSignalsArrayOnComponentAdded<Combat>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatArmor>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatBlock>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatCharge>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatDI>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatDamage>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatPoints>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatStamina>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatStocks>
	|-Frame.BuildSignalsArrayOnComponentAdded<CombatTech>
	|-Frame.BuildSignalsArrayOnComponentAdded<ContinuousRotation>
	|-Frame.BuildSignalsArrayOnComponentAdded<CustomAnimator>
	|-Frame.BuildSignalsArrayOnComponentAdded<DestroyEntitiesManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<DynamicStageElement>
	|-Frame.BuildSignalsArrayOnComponentAdded<EdgeGrab>
	|-Frame.BuildSignalsArrayOnComponentAdded<EndlessGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<EnergyBar>
	|-Frame.BuildSignalsArrayOnComponentAdded<EntityModifier>
	|-Frame.BuildSignalsArrayOnComponentAdded<EntityModifierTarget>
	|-Frame.BuildSignalsArrayOnComponentAdded<EntityReferencesHandler>
	|-Frame.BuildSignalsArrayOnComponentAdded<EscapeRoomGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<EscapeRoomGoalTrigger>
	|-Frame.BuildSignalsArrayOnComponentAdded<FrameByFrame>
	|-Frame.BuildSignalsArrayOnComponentAdded<FrogmanBossTongue>
	|-Frame.BuildSignalsArrayOnComponentAdded<GameEntity>
	|-Frame.BuildSignalsArrayOnComponentAdded<GameModeItemAutoTrigger>
	|-Frame.BuildSignalsArrayOnComponentAdded<GameTimeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<GoldenHook>
	|-Frame.BuildSignalsArrayOnComponentAdded<Grab>
	|-Frame.BuildSignalsArrayOnComponentAdded<HazardsRaceGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<InitialWaitTimer>
	|-Frame.BuildSignalsArrayOnComponentAdded<InputBuffer>
	|-Frame.BuildSignalsArrayOnComponentAdded<ItemAutoTrigger>
	|-Frame.BuildSignalsArrayOnComponentAdded<ItemBox>
	|-Frame.BuildSignalsArrayOnComponentAdded<Jump>
	|-Frame.BuildSignalsArrayOnComponentAdded<KinematicBody>
	|-Frame.BuildSignalsArrayOnComponentAdded<Laser>
	|-Frame.BuildSignalsArrayOnComponentAdded<LayoutManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<MapEntityLink>
	|-Frame.BuildSignalsArrayOnComponentAdded<MatchTimer>
	|-Frame.BuildSignalsArrayOnComponentAdded<MechanicTutorialGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<MechanicTutorialGoalTrigger>
	|-Frame.BuildSignalsArrayOnComponentAdded<Movable>
	|-Frame.BuildSignalsArrayOnComponentAdded<MovesetLimiter>
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshAvoidanceAgent>
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshAvoidanceObstacle>
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshPathfinder>
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshSteeringAgent>
	|-Frame.BuildSignalsArrayOnComponentAdded<NonDeterministicAnimation>
	|-Frame.BuildSignalsArrayOnComponentAdded<ParentObject>
	|-Frame.BuildSignalsArrayOnComponentAdded<PartnersManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<PersistentEntity>
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsBody>
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsBody2D>
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsBody3D>
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsCollider2D>
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsCollider3D>
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsModifier>
	|-Frame.BuildSignalsArrayOnComponentAdded<PlatformFightGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<PlayerManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<PlayerStats>
	|-Frame.BuildSignalsArrayOnComponentAdded<RaceGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<RaceTutorialGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<RespawnPoint>
	|-Frame.BuildSignalsArrayOnComponentAdded<Rocket>
	|-Frame.BuildSignalsArrayOnComponentAdded<RocketLauncher>
	|-Frame.BuildSignalsArrayOnComponentAdded<RoomMember>
	|-Frame.BuildSignalsArrayOnComponentAdded<SecretRoomTrigger>
	|-Frame.BuildSignalsArrayOnComponentAdded<Shockwave>
	|-Frame.BuildSignalsArrayOnComponentAdded<SimpleLineRenderer>
	|-Frame.BuildSignalsArrayOnComponentAdded<SpawnPoint>
	|-Frame.BuildSignalsArrayOnComponentAdded<SpeedRunnersBlastzone>
	|-Frame.BuildSignalsArrayOnComponentAdded<SpeedRunnersCharacter>
	|-Frame.BuildSignalsArrayOnComponentAdded<SpeedRunnersItem>
	|-Frame.BuildSignalsArrayOnComponentAdded<SpeedRunnersNPC>
	|-Frame.BuildSignalsArrayOnComponentAdded<Spike>
	|-Frame.BuildSignalsArrayOnComponentAdded<StageBounds>
	|-Frame.BuildSignalsArrayOnComponentAdded<StageEdge>
	|-Frame.BuildSignalsArrayOnComponentAdded<StageHazardSpawnArea>
	|-Frame.BuildSignalsArrayOnComponentAdded<StageSFX>
	|-Frame.BuildSignalsArrayOnComponentAdded<StageTimeline>
	|-Frame.BuildSignalsArrayOnComponentAdded<StateMachine>
	|-Frame.BuildSignalsArrayOnComponentAdded<Static>
	|-Frame.BuildSignalsArrayOnComponentAdded<StaticRotation>
	|-Frame.BuildSignalsArrayOnComponentAdded<StatusEffectsHolder>
	|-Frame.BuildSignalsArrayOnComponentAdded<StatusEffectsModifiers>
	|-Frame.BuildSignalsArrayOnComponentAdded<StellarCharacter>
	|-Frame.BuildSignalsArrayOnComponentAdded<StellarNPC>
	|-Frame.BuildSignalsArrayOnComponentAdded<SuperBoostVolume>
	|-Frame.BuildSignalsArrayOnComponentAdded<Teams>
	|-Frame.BuildSignalsArrayOnComponentAdded<TournamentGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<TrainingGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentAdded<Transform2D>
	|-Frame.BuildSignalsArrayOnComponentAdded<Transform2DVertical>
	|-Frame.BuildSignalsArrayOnComponentAdded<Transform3D>
	|-Frame.BuildSignalsArrayOnComponentAdded<TrapDoor>
	|-Frame.BuildSignalsArrayOnComponentAdded<TrapDoorSwitch>
	|-Frame.BuildSignalsArrayOnComponentAdded<Trigger>
	|-Frame.BuildSignalsArrayOnComponentAdded<TriggerPolygonShape>
	|-Frame.BuildSignalsArrayOnComponentAdded<TriggerSphereShape>
	|-Frame.BuildSignalsArrayOnComponentAdded<VelocityModifier>
	|-Frame.BuildSignalsArrayOnComponentAdded<View>
	|-Frame.BuildSignalsArrayOnComponentAdded<VisibilitySource>
	|-Frame.BuildSignalsArrayOnComponentAdded<VisibilityTarget>
	|-Frame.BuildSignalsArrayOnComponentAdded<VisualShake>
	|
	|-RVA: 0xB46FE0 Offset: 0xB455E0 VA: 0x180B46FE0
	|-Frame.BuildSignalsArrayOnComponentAdded<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void BuildSignalsArrayOnComponentRemoved<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB472D0 Offset: 0xB458D0 VA: 0x180B472D0
	|-Frame.BuildSignalsArrayOnComponentRemoved<AIVolume>
	|-Frame.BuildSignalsArrayOnComponentRemoved<BaseGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Blastzone>
	|-Frame.BuildSignalsArrayOnComponentRemoved<BlastzoneTrigger>
	|-Frame.BuildSignalsArrayOnComponentRemoved<BossFightGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<BreakableGlass>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CameraManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CameraTarget>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CampaignBoss>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CampaignRaceGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CharacterController2D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CharacterController3D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Checkpoint>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CheckpointManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CollectorCharacter>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CollectorTreasure>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CollectorsGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CollectorsTreasureSpawnArea>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Combat>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatArmor>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatBlock>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatCharge>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatDI>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatDamage>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatPoints>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatStamina>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatStocks>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CombatTech>
	|-Frame.BuildSignalsArrayOnComponentRemoved<ContinuousRotation>
	|-Frame.BuildSignalsArrayOnComponentRemoved<CustomAnimator>
	|-Frame.BuildSignalsArrayOnComponentRemoved<DestroyEntitiesManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<DynamicStageElement>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EdgeGrab>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EndlessGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EnergyBar>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EntityModifier>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EntityModifierTarget>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EntityReferencesHandler>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EscapeRoomGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<EscapeRoomGoalTrigger>
	|-Frame.BuildSignalsArrayOnComponentRemoved<FrameByFrame>
	|-Frame.BuildSignalsArrayOnComponentRemoved<FrogmanBossTongue>
	|-Frame.BuildSignalsArrayOnComponentRemoved<GameEntity>
	|-Frame.BuildSignalsArrayOnComponentRemoved<GameModeItemAutoTrigger>
	|-Frame.BuildSignalsArrayOnComponentRemoved<GameTimeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<GoldenHook>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Grab>
	|-Frame.BuildSignalsArrayOnComponentRemoved<HazardsRaceGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<InitialWaitTimer>
	|-Frame.BuildSignalsArrayOnComponentRemoved<InputBuffer>
	|-Frame.BuildSignalsArrayOnComponentRemoved<ItemAutoTrigger>
	|-Frame.BuildSignalsArrayOnComponentRemoved<ItemBox>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Jump>
	|-Frame.BuildSignalsArrayOnComponentRemoved<KinematicBody>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Laser>
	|-Frame.BuildSignalsArrayOnComponentRemoved<LayoutManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<MapEntityLink>
	|-Frame.BuildSignalsArrayOnComponentRemoved<MatchTimer>
	|-Frame.BuildSignalsArrayOnComponentRemoved<MechanicTutorialGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<MechanicTutorialGoalTrigger>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Movable>
	|-Frame.BuildSignalsArrayOnComponentRemoved<MovesetLimiter>
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshAvoidanceAgent>
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshAvoidanceObstacle>
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshPathfinder>
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshSteeringAgent>
	|-Frame.BuildSignalsArrayOnComponentRemoved<NonDeterministicAnimation>
	|-Frame.BuildSignalsArrayOnComponentRemoved<ParentObject>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PartnersManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PersistentEntity>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsBody>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsBody2D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsBody3D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsCollider2D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsCollider3D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsModifier>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PlatformFightGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PlayerManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<PlayerStats>
	|-Frame.BuildSignalsArrayOnComponentRemoved<RaceGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<RaceTutorialGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<RespawnPoint>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Rocket>
	|-Frame.BuildSignalsArrayOnComponentRemoved<RocketLauncher>
	|-Frame.BuildSignalsArrayOnComponentRemoved<RoomMember>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SecretRoomTrigger>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Shockwave>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SimpleLineRenderer>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SpawnPoint>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SpeedRunnersBlastzone>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SpeedRunnersCharacter>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SpeedRunnersItem>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SpeedRunnersNPC>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Spike>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StageBounds>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StageEdge>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StageHazardSpawnArea>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StageSFX>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StageTimeline>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StateMachine>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Static>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StaticRotation>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StatusEffectsHolder>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StatusEffectsModifiers>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StellarCharacter>
	|-Frame.BuildSignalsArrayOnComponentRemoved<StellarNPC>
	|-Frame.BuildSignalsArrayOnComponentRemoved<SuperBoostVolume>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Teams>
	|-Frame.BuildSignalsArrayOnComponentRemoved<TournamentGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<TrainingGameModeManager>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Transform2D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Transform2DVertical>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Transform3D>
	|-Frame.BuildSignalsArrayOnComponentRemoved<TrapDoor>
	|-Frame.BuildSignalsArrayOnComponentRemoved<TrapDoorSwitch>
	|-Frame.BuildSignalsArrayOnComponentRemoved<Trigger>
	|-Frame.BuildSignalsArrayOnComponentRemoved<TriggerPolygonShape>
	|-Frame.BuildSignalsArrayOnComponentRemoved<TriggerSphereShape>
	|-Frame.BuildSignalsArrayOnComponentRemoved<VelocityModifier>
	|-Frame.BuildSignalsArrayOnComponentRemoved<View>
	|-Frame.BuildSignalsArrayOnComponentRemoved<VisibilitySource>
	|-Frame.BuildSignalsArrayOnComponentRemoved<VisibilityTarget>
	|-Frame.BuildSignalsArrayOnComponentRemoved<VisualShake>
	|
	|-RVA: 0xB4DD90 Offset: 0xB4C390 VA: 0x180B4DD90
	|-Frame.BuildSignalsArrayOnComponentRemoved<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2141C60 Offset: 0x2140260 VA: 0x182141C60
	private void AddEvent(EventBase evnt) { }

	// RVA: 0x2145B90 Offset: 0x2144190 VA: 0x182145B90
	public static void InitStatic() { }

	// RVA: 0x2145AA0 Offset: 0x21440A0 VA: 0x182145AA0
	private static void InitStaticGen() { }

	// RVA: 0x2143FD0 Offset: 0x21425D0 VA: 0x182143FD0
	private void InitGen() { }

	// RVA: 0x2143D80 Offset: 0x2142380 VA: 0x182143D80
	private void FreeGen() { }

	// RVA: 0x2141D00 Offset: 0x2140300 VA: 0x182141D00
	private void AllocGen() { }

	// RVA: 0x21421B0 Offset: 0x21407B0 VA: 0x1821421B0
	private void CopyFromGen(Frame frame) { }

	// RVA: 0x2143EC0 Offset: 0x21424C0 VA: 0x182143EC0
	public RuntimePlayer GetPlayerData(PlayerRef player) { }

	// RVA: 0x2146B30 Offset: 0x2145130 VA: 0x182146B30
	private bool TryGetPlayerData(PlayerRef player, out Frame.RuntimePlayerData playerData) { }

	// RVA: 0x2146CF0 Offset: 0x21452F0 VA: 0x182146CF0
	public void UpdatePlayerData() { }

	[CompilerGenerated]
	// RVA: 0x2146CC0 Offset: 0x21452C0 VA: 0x182146CC0
	private void <.ctor>b__89_0(EntityRef entity, EntityPrototypeRef prototype) { }
}
