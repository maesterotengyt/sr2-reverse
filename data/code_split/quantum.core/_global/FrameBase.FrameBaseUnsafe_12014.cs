// Namespace: 
public struct FrameBase.FrameBaseUnsafe : IDisposable // TypeDefIndex: 12014
{
	// Fields
	private FrameBase _f; // 0x0
	private ReaderWriterLockSlim _rwLock; // 0x8
	private Dictionary<Type, ComponentFilterStructMeta> _filterStructMetaLookup; // 0x10

	// Methods

	// RVA: 0x220A040 Offset: 0x2208640 VA: 0x18220A040
	public void .ctor(FrameBase frame) { }

	// RVA: -1 Offset: -1
	public ComponentBlockIterator<T> GetComponentBlockIterator<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56240 Offset: 0xB54840 VA: 0x180B56240
	|-FrameBase.FrameBaseUnsafe.GetComponentBlockIterator<NavMeshAvoidanceObstacle>
	|-FrameBase.FrameBaseUnsafe.GetComponentBlockIterator<NavMeshPathfinder>
	|-FrameBase.FrameBaseUnsafe.GetComponentBlockIterator<SpeedRunnersCharacter>
	|-FrameBase.FrameBaseUnsafe.GetComponentBlockIterator<Transform2D>
	|
	|-RVA: 0xB561D0 Offset: 0xB547D0 VA: 0x180B561D0
	|-FrameBase.FrameBaseUnsafe.GetComponentBlockIterator<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T* GetPointer<T>(EntityRef entityRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56310 Offset: 0xB54910 VA: 0x180B56310
	|-FrameBase.FrameBaseUnsafe.GetPointer<CharacterController3D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<GameEntity>
	|-FrameBase.FrameBaseUnsafe.GetPointer<NavMeshAvoidanceAgent>
	|-FrameBase.FrameBaseUnsafe.GetPointer<NavMeshPathfinder>
	|-FrameBase.FrameBaseUnsafe.GetPointer<NavMeshSteeringAgent>
	|-FrameBase.FrameBaseUnsafe.GetPointer<PhysicsBody2D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<PhysicsBody3D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<PhysicsCallbacks3D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<PhysicsCollider2D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<PhysicsCollider3D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<PhysicsJoints2D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<PhysicsJoints3D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<Transform2D>
	|-FrameBase.FrameBaseUnsafe.GetPointer<Transform2DVertical>
	|-FrameBase.FrameBaseUnsafe.GetPointer<Transform3D>
	|
	|-RVA: 0xB562B0 Offset: 0xB548B0 VA: 0x180B562B0
	|-FrameBase.FrameBaseUnsafe.GetPointer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetPointer<T>(EntityRef entityRef, out T* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56480 Offset: 0xB54A80 VA: 0x180B56480
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<AIVolume>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<BlastzoneTrigger>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<BreakableGlass>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CameraManager>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CameraTarget>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Checkpoint>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CollectorCharacter>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CollectorTreasure>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CollectorsTreasureSpawnArea>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Combat>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatArmor>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatBlock>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatCharge>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatDI>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatDamage>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatStamina>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatStocks>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CombatTech>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<ContinuousRotation>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<CustomAnimator>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<DynamicStageElement>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<EdgeGrab>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<EnergyBar>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<EntityModifier>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<EntityModifierTarget>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<EntityReferencesHandler>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<EscapeRoomGoalTrigger>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<FrogmanBossTongue>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<GameEntity>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<GoldenHook>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Grab>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<InputBuffer>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<ItemBox>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Jump>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<KinematicBody>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Laser>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<MechanicTutorialGoalTrigger>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Movable>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<MovesetLimiter>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<NonDeterministicAnimation>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<ParentObject>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PartnersManager>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PhysicsBody>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PhysicsBody2D>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PhysicsBody3D>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PhysicsCollider2D>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PhysicsModifier>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PlayerManager>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<PlayerStats>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<RespawnPoint>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Rocket>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<RocketLauncher>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<SecretRoomTrigger>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Shockwave>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<SimpleLineRenderer>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<SpeedRunnersCharacter>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<SpeedRunnersNPC>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Spike>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StageEdge>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StageHazardSpawnArea>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StageSFX>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StateMachine>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Static>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StaticRotation>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StatusEffectsHolder>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StatusEffectsModifiers>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StellarCharacter>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<StellarNPC>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<SuperBoostVolume>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Teams>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Transform2D>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Transform2DVertical>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Transform3D>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<TrapDoorSwitch>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<Trigger>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<TriggerPolygonShape>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<TriggerSphereShape>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<VelocityModifier>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<VisibilitySource>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<VisibilityTarget>
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<VisualShake>
	|
	|-RVA: 0xB56430 Offset: 0xB54A30 VA: 0x180B56430
	|-FrameBase.FrameBaseUnsafe.TryGetPointer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2209FD0 Offset: 0x22085D0 VA: 0x182209FD0
	public void CommitAllCommands() { }

	// RVA: 0x220A000 Offset: 0x2208600 VA: 0x18220A000 Slot: 4
	public void Dispose() { }
}
