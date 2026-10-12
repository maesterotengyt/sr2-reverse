// Namespace: Quantum
public struct ComponentFilter<T0> // TypeDefIndex: 11533
{
	// Fields
	private bool _anySuccess; // 0x0
	private bool _withoutSuccess; // 0x0
	private bool _cullingSuccess; // 0x0
	private FrameBase _registry; // 0x0
	private ComponentSet _any; // 0x0
	private ComponentSet _with; // 0x0
	private ComponentSet _without; // 0x0
	private readonly ComponentDataBuffer* _t0; // 0x0
	private ComponentBlockIterator _blockIterator; // 0x0
	private int _t0Id; // 0x0
	private int _blockIndex; // 0x0
	private int _blockCount; // 0x0
	private byte* _blockComponentData; // 0x0
	private EntityRef* _blockEntityHandles; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(FrameBase f, ComponentSet with, ComponentSet any, ComponentSet without) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B22B0 Offset: 0x17B08B0 VA: 0x1817B22B0
	|-ComponentFilter<AIVolume>..ctor
	|-ComponentFilter<BaseGameModeManager>..ctor
	|-ComponentFilter<Blastzone>..ctor
	|-ComponentFilter<BossFightGameModeManager>..ctor
	|-ComponentFilter<CameraManager>..ctor
	|-ComponentFilter<CameraTarget>..ctor
	|-ComponentFilter<CampaignBoss>..ctor
	|-ComponentFilter<CampaignRaceGameModeManager>..ctor
	|-ComponentFilter<CheckpointManager>..ctor
	|-ComponentFilter<CollectorTreasure>..ctor
	|-ComponentFilter<CollectorsGameModeManager>..ctor
	|-ComponentFilter<CollectorsTreasureSpawnArea>..ctor
	|-ComponentFilter<Combat>..ctor
	|-ComponentFilter<ContinuousRotation>..ctor
	|-ComponentFilter<CustomAnimator>..ctor
	|-ComponentFilter<DestroyEntitiesManager>..ctor
	|-ComponentFilter<DynamicStageElement>..ctor
	|-ComponentFilter<EndlessGameModeManager>..ctor
	|-ComponentFilter<EscapeRoomGameModeManager>..ctor
	|-ComponentFilter<FrameByFrame>..ctor
	|-ComponentFilter<GameEntity>..ctor
	|-ComponentFilter<GameModeItemAutoTrigger>..ctor
	|-ComponentFilter<GameTimeManager>..ctor
	|-ComponentFilter<Grab>..ctor
	|-ComponentFilter<HazardsRaceGameModeManager>..ctor
	|-ComponentFilter<InitialWaitTimer>..ctor
	|-ComponentFilter<ItemAutoTrigger>..ctor
	|-ComponentFilter<ItemBox>..ctor
	|-ComponentFilter<LayoutManager>..ctor
	|-ComponentFilter<MatchTimer>..ctor
	|-ComponentFilter<MechanicTutorialGameModeManager>..ctor
	|-ComponentFilter<ParentObject>..ctor
	|-ComponentFilter<PartnersManager>..ctor
	|-ComponentFilter<PlatformFightGameModeManager>..ctor
	|-ComponentFilter<PlayerManager>..ctor
	|-ComponentFilter<PlayerStats>..ctor
	|-ComponentFilter<RaceGameModeManager>..ctor
	|-ComponentFilter<RaceTutorialGameModeManager>..ctor
	|-ComponentFilter<RespawnPoint>..ctor
	|-ComponentFilter<RoomMember>..ctor
	|-ComponentFilter<SpeedRunnersBlastzone>..ctor
	|-ComponentFilter<SpeedRunnersCharacter>..ctor
	|-ComponentFilter<SpeedRunnersItem>..ctor
	|-ComponentFilter<SpeedRunnersNPC>..ctor
	|-ComponentFilter<StageSFX>..ctor
	|-ComponentFilter<StageTimeline>..ctor
	|-ComponentFilter<StateMachine>..ctor
	|-ComponentFilter<StatusEffectsHolder>..ctor
	|-ComponentFilter<StellarCharacter>..ctor
	|-ComponentFilter<TournamentGameModeManager>..ctor
	|-ComponentFilter<TrainingGameModeManager>..ctor
	|-ComponentFilter<TrapDoor>..ctor
	|-ComponentFilter<TrapDoorSwitch>..ctor
	|-ComponentFilter<Trigger>..ctor
	|-ComponentFilter<VelocityModifier>..ctor
	|
	|-RVA: 0x17B5C60 Offset: 0x17B4260 VA: 0x1817B5C60
	|-ComponentFilter<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Next(out EntityRef entity, out T0 component0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B1FB0 Offset: 0x17B05B0 VA: 0x1817B1FB0
	|-ComponentFilter<AIVolume>.Next
	|-ComponentFilter<Grab>.Next
	|
	|-RVA: 0x17B1E70 Offset: 0x17B0470 VA: 0x1817B1E70
	|-ComponentFilter<BaseGameModeManager>.Next
	|-ComponentFilter<CollectorTreasure>.Next
	|-ComponentFilter<DestroyEntitiesManager>.Next
	|-ComponentFilter<LayoutManager>.Next
	|
	|-RVA: 0x17B1DC0 Offset: 0x17B03C0 VA: 0x1817B1DC0
	|-ComponentFilter<Blastzone>.Next
	|-ComponentFilter<BossFightGameModeManager>.Next
	|-ComponentFilter<CheckpointManager>.Next
	|
	|-RVA: 0x17B20F0 Offset: 0x17B06F0 VA: 0x1817B20F0
	|-ComponentFilter<CameraManager>.Next
	|-ComponentFilter<ItemAutoTrigger>.Next
	|
	|-RVA: 0x17B21C0 Offset: 0x17B07C0 VA: 0x1817B21C0
	|-ComponentFilter<CameraTarget>.Next
	|-ComponentFilter<EscapeRoomGameModeManager>.Next
	|
	|-RVA: 0x17B1F00 Offset: 0x17B0500 VA: 0x1817B1F00
	|-ComponentFilter<CampaignBoss>.Next
	|-ComponentFilter<ItemBox>.Next
	|-ComponentFilter<VelocityModifier>.Next
	|
	|-RVA: 0x17B3BC0 Offset: 0x17B21C0 VA: 0x1817B3BC0
	|-ComponentFilter<CampaignRaceGameModeManager>.Next
	|-ComponentFilter<CollectorsGameModeManager>.Next
	|-ComponentFilter<ContinuousRotation>.Next
	|-ComponentFilter<PartnersManager>.Next
	|-ComponentFilter<RaceGameModeManager>.Next
	|-ComponentFilter<TournamentGameModeManager>.Next
	|
	|-RVA: 0x17B3DC0 Offset: 0x17B23C0 VA: 0x1817B3DC0
	|-ComponentFilter<CollectorsTreasureSpawnArea>.Next
	|-ComponentFilter<DynamicStageElement>.Next
	|-ComponentFilter<EndlessGameModeManager>.Next
	|-ComponentFilter<MechanicTutorialGameModeManager>.Next
	|-ComponentFilter<SpeedRunnersBlastzone>.Next
	|-ComponentFilter<Trigger>.Next
	|
	|-RVA: 0x17B3E60 Offset: 0x17B2460 VA: 0x1817B3E60
	|-ComponentFilter<Combat>.Next
	|
	|-RVA: 0x17B4320 Offset: 0x17B2920 VA: 0x1817B4320
	|-ComponentFilter<CustomAnimator>.Next
	|
	|-RVA: 0x17B3B30 Offset: 0x17B2130 VA: 0x1817B3B30
	|-ComponentFilter<FrameByFrame>.Next
	|-ComponentFilter<GameTimeManager>.Next
	|-ComponentFilter<InitialWaitTimer>.Next
	|-ComponentFilter<MatchTimer>.Next
	|-ComponentFilter<ParentObject>.Next
	|-ComponentFilter<PlatformFightGameModeManager>.Next
	|-ComponentFilter<RespawnPoint>.Next
	|-ComponentFilter<SpeedRunnersItem>.Next
	|-ComponentFilter<StageSFX>.Next
	|-ComponentFilter<StageTimeline>.Next
	|-ComponentFilter<StatusEffectsHolder>.Next
	|-ComponentFilter<TrainingGameModeManager>.Next
	|
	|-RVA: 0x17B3C60 Offset: 0x17B2260 VA: 0x1817B3C60
	|-ComponentFilter<GameEntity>.Next
	|
	|-RVA: 0x17B41B0 Offset: 0x17B27B0 VA: 0x1817B41B0
	|-ComponentFilter<GameModeItemAutoTrigger>.Next
	|
	|-RVA: 0x17B4270 Offset: 0x17B2870 VA: 0x1817B4270
	|-ComponentFilter<HazardsRaceGameModeManager>.Next
	|
	|-RVA: 0x17B4020 Offset: 0x17B2620 VA: 0x1817B4020
	|-ComponentFilter<PlayerManager>.Next
	|
	|-RVA: 0x17B40C0 Offset: 0x17B26C0 VA: 0x1817B40C0
	|-ComponentFilter<PlayerStats>.Next
	|
	|-RVA: 0x17B5BC0 Offset: 0x17B41C0 VA: 0x1817B5BC0
	|-ComponentFilter<RaceTutorialGameModeManager>.Next
	|
	|-RVA: 0x17B5940 Offset: 0x17B3F40 VA: 0x1817B5940
	|-ComponentFilter<RoomMember>.Next
	|
	|-RVA: 0x17B57A0 Offset: 0x17B3DA0 VA: 0x1817B57A0
	|-ComponentFilter<SpeedRunnersCharacter>.Next
	|
	|-RVA: 0x17B59D0 Offset: 0x17B3FD0 VA: 0x1817B59D0
	|-ComponentFilter<SpeedRunnersNPC>.Next
	|
	|-RVA: 0x17B5530 Offset: 0x17B3B30 VA: 0x1817B5530
	|-ComponentFilter<StateMachine>.Next
	|-ComponentFilter<StellarCharacter>.Next
	|
	|-RVA: 0x17B5AE0 Offset: 0x17B40E0 VA: 0x1817B5AE0
	|-ComponentFilter<TrapDoor>.Next
	|-ComponentFilter<TrapDoorSwitch>.Next
	|
	|-RVA: 0x17B5650 Offset: 0x17B3C50 VA: 0x1817B5650
	|-ComponentFilter<__Il2CppFullySharedGenericStructType>.Next
	*/

	// RVA: -1 Offset: -1
	public bool NextUnsafe(out EntityRef entity, out T0* component0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B1930 Offset: 0x17AFF30 VA: 0x1817B1930
	|-ComponentFilter<AIVolume>.NextUnsafe
	|-ComponentFilter<Grab>.NextUnsafe
	|
	|-RVA: 0x17B1010 Offset: 0x17AF610 VA: 0x1817B1010
	|-ComponentFilter<BaseGameModeManager>.NextUnsafe
	|-ComponentFilter<CollectorTreasure>.NextUnsafe
	|-ComponentFilter<DestroyEntitiesManager>.NextUnsafe
	|-ComponentFilter<LayoutManager>.NextUnsafe
	|
	|-RVA: 0x17B16E0 Offset: 0x17AFCE0 VA: 0x1817B16E0
	|-ComponentFilter<Blastzone>.NextUnsafe
	|-ComponentFilter<BossFightGameModeManager>.NextUnsafe
	|-ComponentFilter<CheckpointManager>.NextUnsafe
	|
	|-RVA: 0x17B1B80 Offset: 0x17B0180 VA: 0x1817B1B80
	|-ComponentFilter<CameraManager>.NextUnsafe
	|-ComponentFilter<ItemAutoTrigger>.NextUnsafe
	|
	|-RVA: 0x17B1260 Offset: 0x17AF860 VA: 0x1817B1260
	|-ComponentFilter<CameraTarget>.NextUnsafe
	|-ComponentFilter<EscapeRoomGameModeManager>.NextUnsafe
	|
	|-RVA: 0x17B14A0 Offset: 0x17AFAA0 VA: 0x1817B14A0
	|-ComponentFilter<CampaignBoss>.NextUnsafe
	|-ComponentFilter<ItemBox>.NextUnsafe
	|-ComponentFilter<VelocityModifier>.NextUnsafe
	|
	|-RVA: 0x17B2450 Offset: 0x17B0A50 VA: 0x1817B2450
	|-ComponentFilter<CampaignRaceGameModeManager>.NextUnsafe
	|-ComponentFilter<CollectorsGameModeManager>.NextUnsafe
	|-ComponentFilter<ContinuousRotation>.NextUnsafe
	|-ComponentFilter<PartnersManager>.NextUnsafe
	|-ComponentFilter<RaceGameModeManager>.NextUnsafe
	|-ComponentFilter<TournamentGameModeManager>.NextUnsafe
	|
	|-RVA: 0x17B2D70 Offset: 0x17B1370 VA: 0x1817B2D70
	|-ComponentFilter<CollectorsTreasureSpawnArea>.NextUnsafe
	|-ComponentFilter<DynamicStageElement>.NextUnsafe
	|-ComponentFilter<EndlessGameModeManager>.NextUnsafe
	|-ComponentFilter<MechanicTutorialGameModeManager>.NextUnsafe
	|-ComponentFilter<SpeedRunnersBlastzone>.NextUnsafe
	|-ComponentFilter<Trigger>.NextUnsafe
	|
	|-RVA: 0x17B2FB0 Offset: 0x17B15B0 VA: 0x1817B2FB0
	|-ComponentFilter<Combat>.NextUnsafe
	|
	|-RVA: 0x17B3200 Offset: 0x17B1800 VA: 0x1817B3200
	|-ComponentFilter<CustomAnimator>.NextUnsafe
	|
	|-RVA: 0x17B26A0 Offset: 0x17B0CA0 VA: 0x1817B26A0
	|-ComponentFilter<FrameByFrame>.NextUnsafe
	|-ComponentFilter<GameTimeManager>.NextUnsafe
	|-ComponentFilter<InitialWaitTimer>.NextUnsafe
	|-ComponentFilter<MatchTimer>.NextUnsafe
	|-ComponentFilter<ParentObject>.NextUnsafe
	|-ComponentFilter<PlatformFightGameModeManager>.NextUnsafe
	|-ComponentFilter<RespawnPoint>.NextUnsafe
	|-ComponentFilter<SpeedRunnersItem>.NextUnsafe
	|-ComponentFilter<StageSFX>.NextUnsafe
	|-ComponentFilter<StageTimeline>.NextUnsafe
	|-ComponentFilter<StatusEffectsHolder>.NextUnsafe
	|-ComponentFilter<TrainingGameModeManager>.NextUnsafe
	|
	|-RVA: 0x17B38E0 Offset: 0x17B1EE0 VA: 0x1817B38E0
	|-ComponentFilter<GameEntity>.NextUnsafe
	|
	|-RVA: 0x17B3450 Offset: 0x17B1A50 VA: 0x1817B3450
	|-ComponentFilter<GameModeItemAutoTrigger>.NextUnsafe
	|
	|-RVA: 0x17B36A0 Offset: 0x17B1CA0 VA: 0x1817B36A0
	|-ComponentFilter<HazardsRaceGameModeManager>.NextUnsafe
	|
	|-RVA: 0x17B28E0 Offset: 0x17B0EE0 VA: 0x1817B28E0
	|-ComponentFilter<PlayerManager>.NextUnsafe
	|
	|-RVA: 0x17B2B30 Offset: 0x17B1130 VA: 0x1817B2B30
	|-ComponentFilter<PlayerStats>.NextUnsafe
	|
	|-RVA: 0x17B52E0 Offset: 0x17B38E0 VA: 0x1817B52E0
	|-ComponentFilter<RaceTutorialGameModeManager>.NextUnsafe
	|
	|-RVA: 0x17B4BF0 Offset: 0x17B31F0 VA: 0x1817B4BF0
	|-ComponentFilter<RoomMember>.NextUnsafe
	|
	|-RVA: 0x17B4E40 Offset: 0x17B3440 VA: 0x1817B4E40
	|-ComponentFilter<SpeedRunnersCharacter>.NextUnsafe
	|
	|-RVA: 0x17B5090 Offset: 0x17B3690 VA: 0x1817B5090
	|-ComponentFilter<SpeedRunnersNPC>.NextUnsafe
	|
	|-RVA: 0x17B44E0 Offset: 0x17B2AE0 VA: 0x1817B44E0
	|-ComponentFilter<StateMachine>.NextUnsafe
	|-ComponentFilter<StellarCharacter>.NextUnsafe
	|
	|-RVA: 0x17B4730 Offset: 0x17B2D30 VA: 0x1817B4730
	|-ComponentFilter<TrapDoor>.NextUnsafe
	|-ComponentFilter<TrapDoorSwitch>.NextUnsafe
	|
	|-RVA: 0x17B4970 Offset: 0x17B2F70 VA: 0x1817B4970
	|-ComponentFilter<__Il2CppFullySharedGenericStructType>.NextUnsafe
	*/
}
