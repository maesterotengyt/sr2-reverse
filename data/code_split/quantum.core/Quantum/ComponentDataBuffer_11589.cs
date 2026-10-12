// Namespace: Quantum
internal struct ComponentDataBuffer // TypeDefIndex: 11589
{
	// Fields
	private const int DEFAULT_BLOCK_CAPACITY = 4;
	internal ushort _flags; // 0x0
	internal ushort _singletonSparse; // 0x2
	internal int _count; // 0x4
	internal int _pendingRemoval; // 0x8
	internal int _stride; // 0xC
	internal int _version; // 0x10
	internal int _componentTypeID; // 0x14
	internal ComponentDataBuffer.Block* _blocksList; // 0x18
	internal int _blocksListCapacity; // 0x20
	internal int _blocksListCount; // 0x24
	internal int _blockCapacity; // 0x28
	internal int _blockByteSize; // 0x2C
	internal int _blockDataOffset; // 0x30
	internal ushort* _sparse; // 0x38
	internal int _sparseCapacity; // 0x40

	// Properties
	public int Count { get; }
	public int Version { get; }
	public int BlockListCount { get; }
	internal bool IsSingleton { get; }

	// Methods

	// RVA: 0x1CFA480 Offset: 0x1CF8A80 VA: 0x181CFA480
	public int get_Count() { }

	// RVA: 0x502900 Offset: 0x500F00 VA: 0x180502900
	public int get_Version() { }

	// RVA: 0x682110 Offset: 0x680710 VA: 0x180682110
	public int get_BlockListCount() { }

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	internal bool get_IsSingleton() { }

	// RVA: 0x21C6560 Offset: 0x21C4B60 VA: 0x1821C6560
	internal static ComponentDataBuffer Create(Native.Allocator allocator, FrameBase.EntitiesConfig config, Type type, int dataStride, ComponentFlags flags) { }

	// RVA: 0x21C66E0 Offset: 0x21C4CE0 VA: 0x1821C66E0
	internal static void Free(Native.Allocator allocator, ComponentDataBuffer* buffer) { }

	// RVA: 0x21C63B0 Offset: 0x21C49B0 VA: 0x1821C63B0
	internal static void Copy(Native.Allocator allocator, ComponentDataBuffer* to, ComponentDataBuffer* from) { }

	// RVA: 0x21C6320 Offset: 0x21C4920 VA: 0x1821C6320
	internal void ChangeEntityCapacity(ushort* oldBuffer, int oldCapacity, ushort* newBuffer, int newCapacity) { }

	// RVA: 0x21C6780 Offset: 0x21C4D80 VA: 0x1821C6780
	public byte* GetBlockData(int block) { }

	// RVA: 0x21C67B0 Offset: 0x21C4DB0 VA: 0x1821C67B0
	public EntityRef* GetBlockEntityRefs(int block) { }

	// RVA: 0x21C6A30 Offset: 0x21C5030 VA: 0x1821C6A30
	public EntityRef GetEntityRefByIndex(int index) { }

	// RVA: 0x21C69A0 Offset: 0x21C4FA0 VA: 0x1821C69A0
	public void* GetDataPointerByIndex(int index) { }

	// RVA: 0xB47900 Offset: 0xB45F00 VA: 0x180B47900
	public void* GetDataPointer(EntityRef entityRef) { }

	// RVA: 0x21C69E0 Offset: 0x21C4FE0 VA: 0x1821C69E0
	public void* GetDataPointerFastUnsafe(EntityRef entityRef) { }

	// RVA: -1 Offset: -1
	internal T* Set<T>(Native.Allocator allocator, EntityRef entityRef, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD9D50 Offset: 0xAD8350 VA: 0x180AD9D50
	|-ComponentDataBuffer.Set<AIVolume>
	|-ComponentDataBuffer.Set<Grab>
	|-ComponentDataBuffer.Set<SpawnPoint>
	|
	|-RVA: 0xAD9DD0 Offset: 0xAD83D0 VA: 0x180AD9DD0
	|-ComponentDataBuffer.Set<BaseGameModeManager>
	|-ComponentDataBuffer.Set<CollectorTreasure>
	|-ComponentDataBuffer.Set<CombatPoints>
	|-ComponentDataBuffer.Set<CombatStocks>
	|-ComponentDataBuffer.Set<DestroyEntitiesManager>
	|-ComponentDataBuffer.Set<EntityReferencesHandler>
	|-ComponentDataBuffer.Set<LayoutManager>
	|-ComponentDataBuffer.Set<MapEntityLink>
	|-ComponentDataBuffer.Set<PersistentEntity>
	|-ComponentDataBuffer.Set<SecretRoomTrigger>
	|-ComponentDataBuffer.Set<Spike>
	|-ComponentDataBuffer.Set<Static>
	|-ComponentDataBuffer.Set<Teams>
	|
	|-RVA: 0xAD9E10 Offset: 0xAD8410 VA: 0x180AD9E10
	|-ComponentDataBuffer.Set<Blastzone>
	|-ComponentDataBuffer.Set<BossFightGameModeManager>
	|-ComponentDataBuffer.Set<CharacterController2D>
	|-ComponentDataBuffer.Set<CheckpointManager>
	|-ComponentDataBuffer.Set<CombatDI>
	|-ComponentDataBuffer.Set<NavMeshAvoidanceAgent>
	|-ComponentDataBuffer.Set<NavMeshSteeringAgent>
	|-ComponentDataBuffer.Set<PhysicsModifier>
	|-ComponentDataBuffer.Set<StageHazardSpawnArea>
	|
	|-RVA: 0xAD9DF0 Offset: 0xAD83F0 VA: 0x180AD9DF0
	|-ComponentDataBuffer.Set<BlastzoneTrigger>
	|-ComponentDataBuffer.Set<CombatDamage>
	|-ComponentDataBuffer.Set<PhysicsJoints2D>
	|-ComponentDataBuffer.Set<PhysicsJoints3D>
	|-ComponentDataBuffer.Set<RoomMember>
	|-ComponentDataBuffer.Set<StaticRotation>
	|-ComponentDataBuffer.Set<View>
	|
	|-RVA: 0xAD9E40 Offset: 0xAD8440 VA: 0x180AD9E40
	|-ComponentDataBuffer.Set<BreakableGlass>
	|-ComponentDataBuffer.Set<Jump>
	|-ComponentDataBuffer.Set<PhysicsCollider2D>
	|-ComponentDataBuffer.Set<VisibilityTarget>
	|
	|-RVA: 0xAD9E80 Offset: 0xAD8480 VA: 0x180AD9E80
	|-ComponentDataBuffer.Set<CameraManager>
	|-ComponentDataBuffer.Set<ItemAutoTrigger>
	|
	|-RVA: 0xAD9ED0 Offset: 0xAD84D0 VA: 0x180AD9ED0
	|-ComponentDataBuffer.Set<CameraTarget>
	|-ComponentDataBuffer.Set<EscapeRoomGameModeManager>
	|-ComponentDataBuffer.Set<PhysicsBody2D>
	|
	|-RVA: 0xAD9F30 Offset: 0xAD8530 VA: 0x180AD9F30
	|-ComponentDataBuffer.Set<CampaignBoss>
	|-ComponentDataBuffer.Set<EntityModifierTarget>
	|-ComponentDataBuffer.Set<EscapeRoomGoalTrigger>
	|-ComponentDataBuffer.Set<ItemBox>
	|-ComponentDataBuffer.Set<VelocityModifier>
	|
	|-RVA: 0xAD9F70 Offset: 0xAD8570 VA: 0x180AD9F70
	|-ComponentDataBuffer.Set<CampaignRaceGameModeManager>
	|-ComponentDataBuffer.Set<Checkpoint>
	|-ComponentDataBuffer.Set<CollectorsGameModeManager>
	|-ComponentDataBuffer.Set<CombatArmor>
	|-ComponentDataBuffer.Set<CombatCharge>
	|-ComponentDataBuffer.Set<CombatStamina>
	|-ComponentDataBuffer.Set<ContinuousRotation>
	|-ComponentDataBuffer.Set<EntityModifier>
	|-ComponentDataBuffer.Set<KinematicBody>
	|-ComponentDataBuffer.Set<Movable>
	|-ComponentDataBuffer.Set<PartnersManager>
	|-ComponentDataBuffer.Set<RaceGameModeManager>
	|-ComponentDataBuffer.Set<TournamentGameModeManager>
	|-ComponentDataBuffer.Set<Transform2D>
	|-ComponentDataBuffer.Set<TriggerPolygonShape>
	|-ComponentDataBuffer.Set<TriggerSphereShape>
	|
	|-RVA: 0xAD9FA0 Offset: 0xAD85A0 VA: 0x180AD9FA0
	|-ComponentDataBuffer.Set<CharacterController3D>
	|-ComponentDataBuffer.Set<CombatBlock>
	|-ComponentDataBuffer.Set<Shockwave>
	|-ComponentDataBuffer.Set<VisibilitySource>
	|
	|-RVA: 0xAD9FD0 Offset: 0xAD85D0 VA: 0x180AD9FD0
	|-ComponentDataBuffer.Set<CollectorCharacter>
	|-ComponentDataBuffer.Set<EnergyBar>
	|-ComponentDataBuffer.Set<FrameByFrame>
	|-ComponentDataBuffer.Set<GameTimeManager>
	|-ComponentDataBuffer.Set<InitialWaitTimer>
	|-ComponentDataBuffer.Set<Laser>
	|-ComponentDataBuffer.Set<MatchTimer>
	|-ComponentDataBuffer.Set<MovesetLimiter>
	|-ComponentDataBuffer.Set<ParentObject>
	|-ComponentDataBuffer.Set<PhysicsCallbacks2D>
	|-ComponentDataBuffer.Set<PhysicsCallbacks3D>
	|-ComponentDataBuffer.Set<PlatformFightGameModeManager>
	|-ComponentDataBuffer.Set<RespawnPoint>
	|-ComponentDataBuffer.Set<RocketLauncher>
	|-ComponentDataBuffer.Set<SpeedRunnersItem>
	|-ComponentDataBuffer.Set<StageEdge>
	|-ComponentDataBuffer.Set<StageSFX>
	|-ComponentDataBuffer.Set<StageTimeline>
	|-ComponentDataBuffer.Set<StatusEffectsHolder>
	|-ComponentDataBuffer.Set<StellarNPC>
	|-ComponentDataBuffer.Set<SuperBoostVolume>
	|-ComponentDataBuffer.Set<TrainingGameModeManager>
	|-ComponentDataBuffer.Set<Transform2DVertical>
	|
	|-RVA: 0xAD9FF0 Offset: 0xAD85F0 VA: 0x180AD9FF0
	|-ComponentDataBuffer.Set<CollectorsTreasureSpawnArea>
	|-ComponentDataBuffer.Set<CombatTech>
	|-ComponentDataBuffer.Set<DynamicStageElement>
	|-ComponentDataBuffer.Set<EndlessGameModeManager>
	|-ComponentDataBuffer.Set<MechanicTutorialGameModeManager>
	|-ComponentDataBuffer.Set<NavMeshAvoidanceObstacle>
	|-ComponentDataBuffer.Set<Rocket>
	|-ComponentDataBuffer.Set<SpeedRunnersBlastzone>
	|-ComponentDataBuffer.Set<StageBounds>
	|-ComponentDataBuffer.Set<Trigger>
	|-ComponentDataBuffer.Set<VisualShake>
	|
	|-RVA: 0xADA020 Offset: 0xAD8620 VA: 0x180ADA020
	|-ComponentDataBuffer.Set<Combat>
	|
	|-RVA: 0xADA0E0 Offset: 0xAD86E0 VA: 0x180ADA0E0
	|-ComponentDataBuffer.Set<CustomAnimator>
	|
	|-RVA: 0xADA190 Offset: 0xAD8790 VA: 0x180ADA190
	|-ComponentDataBuffer.Set<EdgeGrab>
	|-ComponentDataBuffer.Set<PlayerStats>
	|
	|-RVA: 0xADA1F0 Offset: 0xAD87F0 VA: 0x180ADA1F0
	|-ComponentDataBuffer.Set<FrogmanBossTongue>
	|-ComponentDataBuffer.Set<GoldenHook>
	|-ComponentDataBuffer.Set<HazardsRaceGameModeManager>
	|-ComponentDataBuffer.Set<SimpleLineRenderer>
	|-ComponentDataBuffer.Set<Transform3D>
	|
	|-RVA: 0xADA230 Offset: 0xAD8830 VA: 0x180ADA230
	|-ComponentDataBuffer.Set<GameEntity>
	|
	|-RVA: 0xADA2C0 Offset: 0xAD88C0 VA: 0x180ADA2C0
	|-ComponentDataBuffer.Set<GameModeItemAutoTrigger>
	|
	|-RVA: 0xADA3E0 Offset: 0xAD89E0 VA: 0x180ADA3E0
	|-ComponentDataBuffer.Set<InputBuffer>
	|
	|-RVA: 0xADA420 Offset: 0xAD8A20 VA: 0x180ADA420
	|-ComponentDataBuffer.Set<MechanicTutorialGoalTrigger>
	|
	|-RVA: 0xADA4D0 Offset: 0xAD8AD0 VA: 0x180ADA4D0
	|-ComponentDataBuffer.Set<NavMeshPathfinder>
	|
	|-RVA: 0xADA520 Offset: 0xAD8B20 VA: 0x180ADA520
	|-ComponentDataBuffer.Set<NonDeterministicAnimation>
	|
	|-RVA: 0xADA630 Offset: 0xAD8C30 VA: 0x180ADA630
	|-ComponentDataBuffer.Set<PhysicsBody>
	|
	|-RVA: 0xADA590 Offset: 0xAD8B90 VA: 0x180ADA590
	|-ComponentDataBuffer.Set<PhysicsBody3D>
	|
	|-RVA: 0xADA6E0 Offset: 0xAD8CE0 VA: 0x180ADA6E0
	|-ComponentDataBuffer.Set<PhysicsCollider3D>
	|
	|-RVA: 0xADA730 Offset: 0xAD8D30 VA: 0x180ADA730
	|-ComponentDataBuffer.Set<PlayerManager>
	|
	|-RVA: 0xADA760 Offset: 0xAD8D60 VA: 0x180ADA760
	|-ComponentDataBuffer.Set<RaceTutorialGameModeManager>
	|
	|-RVA: 0xADA790 Offset: 0xAD8D90 VA: 0x180ADA790
	|-ComponentDataBuffer.Set<SpeedRunnersCharacter>
	|
	|-RVA: 0xADA830 Offset: 0xAD8E30 VA: 0x180ADA830
	|-ComponentDataBuffer.Set<SpeedRunnersNPC>
	|
	|-RVA: 0xADA8A0 Offset: 0xAD8EA0 VA: 0x180ADA8A0
	|-ComponentDataBuffer.Set<StateMachine>
	|-ComponentDataBuffer.Set<StellarCharacter>
	|
	|-RVA: 0xADA920 Offset: 0xAD8F20 VA: 0x180ADA920
	|-ComponentDataBuffer.Set<StatusEffectsModifiers>
	|-ComponentDataBuffer.Set<TrapDoor>
	|-ComponentDataBuffer.Set<TrapDoorSwitch>
	|
	|-RVA: 0xADA300 Offset: 0xAD8900 VA: 0x180ADA300
	|-ComponentDataBuffer.Set<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21C67E0 Offset: 0x21C4DE0 VA: 0x1821C67E0
	private void* GetBufferEntry(Native.Allocator allocator, EntityRef entityRef) { }

	// RVA: 0x21C6A80 Offset: 0x21C5080 VA: 0x1821C6A80
	internal void Remove(EntityRef entityRef) { }

	// RVA: 0x21C6680 Offset: 0x21C4C80 VA: 0x1821C6680
	private void ExpandBlockListCapacity(Native.Allocator allocator, int newCapacity) { }

	// RVA: 0x21C6CD0 Offset: 0x21C52D0 VA: 0x1821C6CD0
	private void UseNextBlock(Native.Allocator allocator) { }

	// RVA: 0x21C62C0 Offset: 0x21C48C0 VA: 0x1821C62C0
	internal ComponentDataBuffer.Block AllocateBlock(Native.Allocator allocator) { }

	// RVA: 0x21C6A70 Offset: 0x21C5070 VA: 0x1821C6A70
	internal void RemovalPending(EntityRef entityRef) { }
}
