// Namespace: Quantum
public struct ComponentSet // TypeDefIndex: 11549
{
	// Fields
	public const int SIZE = 32;
	public const int BLOCK_COUNT = 4;
	public const int BITS_PER_BLOCK = 64;
	public const int MAX_COMPONENTS = 256;
	[FixedBuffer(typeof(ulong), 4)]
	public ComponentSet.<_set>e__FixedBuffer _set; // 0x0

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x21C7A00 Offset: 0x21C6000 VA: 0x1821C7A00
	public bool get_IsEmpty() { }

	// RVA: -1 Offset: -1
	public void Add<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADB330 Offset: 0xAD9930 VA: 0x180ADB330
	|-ComponentSet.Add<AIVolume>
	|-ComponentSet.Add<BaseGameModeManager>
	|-ComponentSet.Add<Blastzone>
	|-ComponentSet.Add<BossFightGameModeManager>
	|-ComponentSet.Add<CameraManager>
	|-ComponentSet.Add<CameraTarget>
	|-ComponentSet.Add<CampaignBoss>
	|-ComponentSet.Add<CampaignRaceGameModeManager>
	|-ComponentSet.Add<CheckpointManager>
	|-ComponentSet.Add<CollectorCharacter>
	|-ComponentSet.Add<CollectorTreasure>
	|-ComponentSet.Add<CollectorsGameModeManager>
	|-ComponentSet.Add<CollectorsTreasureSpawnArea>
	|-ComponentSet.Add<Combat>
	|-ComponentSet.Add<CombatStamina>
	|-ComponentSet.Add<ContinuousRotation>
	|-ComponentSet.Add<CustomAnimator>
	|-ComponentSet.Add<DestroyEntitiesManager>
	|-ComponentSet.Add<DynamicStageElement>
	|-ComponentSet.Add<EndlessGameModeManager>
	|-ComponentSet.Add<EscapeRoomGameModeManager>
	|-ComponentSet.Add<FrameByFrame>
	|-ComponentSet.Add<GameEntity>
	|-ComponentSet.Add<GameModeItemAutoTrigger>
	|-ComponentSet.Add<GameTimeManager>
	|-ComponentSet.Add<GoldenHook>
	|-ComponentSet.Add<Grab>
	|-ComponentSet.Add<HazardsRaceGameModeManager>
	|-ComponentSet.Add<InitialWaitTimer>
	|-ComponentSet.Add<InputBuffer>
	|-ComponentSet.Add<ItemAutoTrigger>
	|-ComponentSet.Add<ItemBox>
	|-ComponentSet.Add<KinematicBody>
	|-ComponentSet.Add<LayoutManager>
	|-ComponentSet.Add<MatchTimer>
	|-ComponentSet.Add<MechanicTutorialGameModeManager>
	|-ComponentSet.Add<Movable>
	|-ComponentSet.Add<ParentObject>
	|-ComponentSet.Add<PartnersManager>
	|-ComponentSet.Add<PhysicsBody>
	|-ComponentSet.Add<PhysicsCollider2D>
	|-ComponentSet.Add<PhysicsCollider3D>
	|-ComponentSet.Add<PlatformFightGameModeManager>
	|-ComponentSet.Add<PlayerManager>
	|-ComponentSet.Add<PlayerStats>
	|-ComponentSet.Add<RaceGameModeManager>
	|-ComponentSet.Add<RaceTutorialGameModeManager>
	|-ComponentSet.Add<RespawnPoint>
	|-ComponentSet.Add<RoomMember>
	|-ComponentSet.Add<SpawnPoint>
	|-ComponentSet.Add<SpeedRunnersBlastzone>
	|-ComponentSet.Add<SpeedRunnersCharacter>
	|-ComponentSet.Add<SpeedRunnersItem>
	|-ComponentSet.Add<SpeedRunnersNPC>
	|-ComponentSet.Add<StageBounds>
	|-ComponentSet.Add<StageEdge>
	|-ComponentSet.Add<StageSFX>
	|-ComponentSet.Add<StageTimeline>
	|-ComponentSet.Add<StateMachine>
	|-ComponentSet.Add<StatusEffectsHolder>
	|-ComponentSet.Add<StellarCharacter>
	|-ComponentSet.Add<TournamentGameModeManager>
	|-ComponentSet.Add<TrainingGameModeManager>
	|-ComponentSet.Add<Transform2D>
	|-ComponentSet.Add<Transform3D>
	|-ComponentSet.Add<TrapDoor>
	|-ComponentSet.Add<TrapDoorSwitch>
	|-ComponentSet.Add<Trigger>
	|-ComponentSet.Add<VelocityModifier>
	|-ComponentSet.Add<VisibilitySource>
	|-ComponentSet.Add<VisibilityTarget>
	|-ComponentSet.Add<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x20C8360 Offset: 0x20C6960 VA: 0x1820C8360
	public void Add(int index) { }

	// RVA: 0x21C7700 Offset: 0x21C5D00 VA: 0x1821C7700
	public void Remove(int index) { }

	// RVA: 0x20C82C0 Offset: 0x20C68C0 VA: 0x1820C82C0
	public bool IsSet(int index) { }

	// RVA: 0x21C75A0 Offset: 0x21C5BA0 VA: 0x1821C75A0
	public bool Equals(ComponentSet other) { }

	// RVA: 0x21C75D0 Offset: 0x21C5BD0 VA: 0x1821C75D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21C7670 Offset: 0x21C5C70 VA: 0x1821C7670 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21C7830 Offset: 0x21C5E30 VA: 0x1821C7830 Slot: 3
	public override string ToString() { }

	// RVA: 0x21C76C0 Offset: 0x21C5CC0 VA: 0x1821C76C0
	public bool IsSupersetOf(in ComponentSet other) { }

	// RVA: 0x21C7730 Offset: 0x21C5D30 VA: 0x1821C7730
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: -1 Offset: -1
	public static ComponentSet Create<T0>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADB3A0 Offset: 0xAD99A0 VA: 0x180ADB3A0
	|-ComponentSet.Create<AIVolume>
	|-ComponentSet.Create<BaseGameModeManager>
	|-ComponentSet.Create<Blastzone>
	|-ComponentSet.Create<BossFightGameModeManager>
	|-ComponentSet.Create<CameraManager>
	|-ComponentSet.Create<CameraTarget>
	|-ComponentSet.Create<CampaignBoss>
	|-ComponentSet.Create<CampaignRaceGameModeManager>
	|-ComponentSet.Create<CheckpointManager>
	|-ComponentSet.Create<CollectorTreasure>
	|-ComponentSet.Create<CollectorsGameModeManager>
	|-ComponentSet.Create<CollectorsTreasureSpawnArea>
	|-ComponentSet.Create<Combat>
	|-ComponentSet.Create<ContinuousRotation>
	|-ComponentSet.Create<CustomAnimator>
	|-ComponentSet.Create<DestroyEntitiesManager>
	|-ComponentSet.Create<DynamicStageElement>
	|-ComponentSet.Create<EndlessGameModeManager>
	|-ComponentSet.Create<EscapeRoomGameModeManager>
	|-ComponentSet.Create<FrameByFrame>
	|-ComponentSet.Create<GameEntity>
	|-ComponentSet.Create<GameModeItemAutoTrigger>
	|-ComponentSet.Create<GameTimeManager>
	|-ComponentSet.Create<Grab>
	|-ComponentSet.Create<HazardsRaceGameModeManager>
	|-ComponentSet.Create<InitialWaitTimer>
	|-ComponentSet.Create<ItemAutoTrigger>
	|-ComponentSet.Create<ItemBox>
	|-ComponentSet.Create<LayoutManager>
	|-ComponentSet.Create<MatchTimer>
	|-ComponentSet.Create<MechanicTutorialGameModeManager>
	|-ComponentSet.Create<ParentObject>
	|-ComponentSet.Create<PartnersManager>
	|-ComponentSet.Create<PlatformFightGameModeManager>
	|-ComponentSet.Create<PlayerManager>
	|-ComponentSet.Create<PlayerStats>
	|-ComponentSet.Create<RaceGameModeManager>
	|-ComponentSet.Create<RaceTutorialGameModeManager>
	|-ComponentSet.Create<RespawnPoint>
	|-ComponentSet.Create<RoomMember>
	|-ComponentSet.Create<SpeedRunnersBlastzone>
	|-ComponentSet.Create<SpeedRunnersCharacter>
	|-ComponentSet.Create<SpeedRunnersItem>
	|-ComponentSet.Create<SpeedRunnersNPC>
	|-ComponentSet.Create<StageSFX>
	|-ComponentSet.Create<StageTimeline>
	|-ComponentSet.Create<StateMachine>
	|-ComponentSet.Create<StatusEffectsHolder>
	|-ComponentSet.Create<StellarCharacter>
	|-ComponentSet.Create<TournamentGameModeManager>
	|-ComponentSet.Create<TrainingGameModeManager>
	|-ComponentSet.Create<TrapDoor>
	|-ComponentSet.Create<TrapDoorSwitch>
	|-ComponentSet.Create<Trigger>
	|-ComponentSet.Create<VelocityModifier>
	|
	|-RVA: 0xADB450 Offset: 0xAD9A50 VA: 0x180ADB450
	|-ComponentSet.Create<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ComponentSet Create<T0, T1>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADB3F0 Offset: 0xAD99F0 VA: 0x180ADB3F0
	|-ComponentSet.Create<Blastzone, Transform2D>
	|-ComponentSet.Create<CameraTarget, Transform2D>
	|-ComponentSet.Create<CampaignBoss, CombatStamina>
	|-ComponentSet.Create<CollectorTreasure, Transform2D>
	|-ComponentSet.Create<Combat, Transform2D>
	|-ComponentSet.Create<GameEntity, GoldenHook>
	|-ComponentSet.Create<GameEntity, Transform2D>
	|-ComponentSet.Create<KinematicBody, Transform2D>
	|-ComponentSet.Create<Movable, Transform2D>
	|-ComponentSet.Create<PhysicsBody, Transform2D>
	|-ComponentSet.Create<RespawnPoint, Transform2D>
	|-ComponentSet.Create<SpeedRunnersCharacter, CollectorCharacter>
	|-ComponentSet.Create<SpeedRunnersCharacter, CombatStamina>
	|-ComponentSet.Create<SpeedRunnersCharacter, PhysicsBody>
	|-ComponentSet.Create<SpeedRunnersCharacter, Transform2D>
	|-ComponentSet.Create<StageBounds, Transform2D>
	|-ComponentSet.Create<StageEdge, Transform2D>
	|-ComponentSet.Create<StellarCharacter, InputBuffer>
	|-ComponentSet.Create<StellarCharacter, SpeedRunnersCharacter>
	|-ComponentSet.Create<Transform2D, PhysicsCollider2D>
	|-ComponentSet.Create<Transform2D, SpawnPoint>
	|-ComponentSet.Create<Transform3D, PhysicsCollider3D>
	|-ComponentSet.Create<Trigger, VisibilityTarget>
	|-ComponentSet.Create<VisibilitySource, Transform2D>
	|-ComponentSet.Create<VisibilityTarget, Transform2D>
	|
	|-RVA: 0xADC840 Offset: 0xADAE40 VA: 0x180ADC840
	|-ComponentSet.Create<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ComponentSet Create<T0, T1, T2>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADC650 Offset: 0xADAC50 VA: 0x180ADC650
	|-ComponentSet.Create<CampaignBoss, PhysicsBody, Transform2D>
	|-ComponentSet.Create<PhysicsBody, GameEntity, Transform2D>
	|-ComponentSet.Create<SpeedRunnersCharacter, GameEntity, Transform2D>
	|
	|-RVA: 0xADC6C0 Offset: 0xADACC0 VA: 0x180ADC6C0
	|-ComponentSet.Create<CampaignBoss, StateMachine, CombatStamina>
	|-ComponentSet.Create<Transform2D, Grab, Trigger>
	|
	|-RVA: 0xADC8A0 Offset: 0xADAEA0 VA: 0x180ADC8A0
	|-ComponentSet.Create<SpeedRunnersCharacter, Transform2D, Movable>
	|
	|-RVA: 0xADC7D0 Offset: 0xADADD0 VA: 0x180ADC7D0
	|-ComponentSet.Create<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}
