// Namespace: Quantum
public static class ComponentTypeId // TypeDefIndex: 11552
{
	// Fields
	private static bool _initAcquired; // 0x0
	private static bool _initFinished; // 0x1
	private static List<Type> _typeList; // 0x8
	private static List<int> _sizeList; // 0x10
	private static List<ComponentCallbacks> _callbacksList; // 0x18
	private static List<ComponentFlags> _flagsList; // 0x20
	private static Dictionary<Type, int> _reverseLookup; // 0x28
	private static Dictionary<string, int> _reverseStringLookup; // 0x30
	public static Type[] Type; // 0x38
	public static int[] Size; // 0x40
	public static ComponentFlags[] Flags; // 0x48
	public static ComponentCallbacks[] Callbacks; // 0x50

	// Methods

	// RVA: 0x21C7A20 Offset: 0x21C6020 VA: 0x1821C7A20
	public static int GetComponentIndex(Type type) { }

	// RVA: 0x21C7B20 Offset: 0x21C6120 VA: 0x1821C7B20
	public static int GetComponentSize(int index) { }

	// RVA: 0x21C7B80 Offset: 0x21C6180 VA: 0x1821C7B80
	public static Type GetComponentType(int index) { }

	// RVA: 0x21C7BE0 Offset: 0x21C61E0 VA: 0x1821C7BE0
	public static void Setup(Action action) { }

	// RVA: -1 Offset: -1
	public static void Add<T>(ComponentSerializeDelegate serialize, ComponentChangedDelegate onAdded, ComponentChangedDelegate onRemoved, ComponentFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADC960 Offset: 0xADAF60 VA: 0x180ADC960
	|-ComponentTypeId.Add<AIVolume>
	|-ComponentTypeId.Add<Grab>
	|-ComponentTypeId.Add<SpawnPoint>
	|
	|-RVA: 0xADD370 Offset: 0xADB970 VA: 0x180ADD370
	|-ComponentTypeId.Add<BaseGameModeManager>
	|-ComponentTypeId.Add<CollectorTreasure>
	|-ComponentTypeId.Add<CombatPoints>
	|-ComponentTypeId.Add<CombatStocks>
	|-ComponentTypeId.Add<DestroyEntitiesManager>
	|-ComponentTypeId.Add<EntityReferencesHandler>
	|-ComponentTypeId.Add<LayoutManager>
	|-ComponentTypeId.Add<PersistentEntity>
	|-ComponentTypeId.Add<SecretRoomTrigger>
	|-ComponentTypeId.Add<Spike>
	|-ComponentTypeId.Add<Static>
	|-ComponentTypeId.Add<Teams>
	|
	|-RVA: 0xADDE10 Offset: 0xADC410 VA: 0x180ADDE10
	|-ComponentTypeId.Add<Blastzone>
	|-ComponentTypeId.Add<BossFightGameModeManager>
	|-ComponentTypeId.Add<CheckpointManager>
	|-ComponentTypeId.Add<CombatDI>
	|-ComponentTypeId.Add<PhysicsModifier>
	|-ComponentTypeId.Add<StageHazardSpawnArea>
	|
	|-RVA: 0xADD8C0 Offset: 0xADBEC0 VA: 0x180ADD8C0
	|-ComponentTypeId.Add<BlastzoneTrigger>
	|-ComponentTypeId.Add<CombatDamage>
	|-ComponentTypeId.Add<RoomMember>
	|-ComponentTypeId.Add<StaticRotation>
	|
	|-RVA: 0xADE360 Offset: 0xADC960 VA: 0x180ADE360
	|-ComponentTypeId.Add<BreakableGlass>
	|-ComponentTypeId.Add<Jump>
	|-ComponentTypeId.Add<VisibilityTarget>
	|
	|-RVA: 0xADE3F0 Offset: 0xADC9F0 VA: 0x180ADE3F0
	|-ComponentTypeId.Add<CameraManager>
	|-ComponentTypeId.Add<ItemAutoTrigger>
	|
	|-RVA: 0xADEE00 Offset: 0xADD400 VA: 0x180ADEE00
	|-ComponentTypeId.Add<CameraTarget>
	|-ComponentTypeId.Add<EscapeRoomGameModeManager>
	|
	|-RVA: 0xADF350 Offset: 0xADD950 VA: 0x180ADF350
	|-ComponentTypeId.Add<CampaignBoss>
	|-ComponentTypeId.Add<EntityModifierTarget>
	|-ComponentTypeId.Add<EscapeRoomGoalTrigger>
	|-ComponentTypeId.Add<ItemBox>
	|-ComponentTypeId.Add<VelocityModifier>
	|
	|-RVA: 0xADF8A0 Offset: 0xADDEA0 VA: 0x180ADF8A0
	|-ComponentTypeId.Add<CampaignRaceGameModeManager>
	|-ComponentTypeId.Add<Checkpoint>
	|-ComponentTypeId.Add<CollectorsGameModeManager>
	|-ComponentTypeId.Add<CombatArmor>
	|-ComponentTypeId.Add<CombatCharge>
	|-ComponentTypeId.Add<CombatStamina>
	|-ComponentTypeId.Add<ContinuousRotation>
	|-ComponentTypeId.Add<EntityModifier>
	|-ComponentTypeId.Add<KinematicBody>
	|-ComponentTypeId.Add<Movable>
	|-ComponentTypeId.Add<PartnersManager>
	|-ComponentTypeId.Add<RaceGameModeManager>
	|-ComponentTypeId.Add<TournamentGameModeManager>
	|-ComponentTypeId.Add<TriggerPolygonShape>
	|-ComponentTypeId.Add<TriggerSphereShape>
	|
	|-RVA: 0xAE02B0 Offset: 0xADE8B0 VA: 0x180AE02B0
	|-ComponentTypeId.Add<CollectorCharacter>
	|-ComponentTypeId.Add<EnergyBar>
	|-ComponentTypeId.Add<FrameByFrame>
	|-ComponentTypeId.Add<GameTimeManager>
	|-ComponentTypeId.Add<InitialWaitTimer>
	|-ComponentTypeId.Add<Laser>
	|-ComponentTypeId.Add<MatchTimer>
	|-ComponentTypeId.Add<MovesetLimiter>
	|-ComponentTypeId.Add<ParentObject>
	|-ComponentTypeId.Add<PlatformFightGameModeManager>
	|-ComponentTypeId.Add<RespawnPoint>
	|-ComponentTypeId.Add<RocketLauncher>
	|-ComponentTypeId.Add<SpeedRunnersItem>
	|-ComponentTypeId.Add<StageEdge>
	|-ComponentTypeId.Add<StageSFX>
	|-ComponentTypeId.Add<StageTimeline>
	|-ComponentTypeId.Add<StatusEffectsHolder>
	|-ComponentTypeId.Add<StellarNPC>
	|-ComponentTypeId.Add<SuperBoostVolume>
	|-ComponentTypeId.Add<TrainingGameModeManager>
	|
	|-RVA: 0xAE0800 Offset: 0xADEE00 VA: 0x180AE0800
	|-ComponentTypeId.Add<CollectorsTreasureSpawnArea>
	|-ComponentTypeId.Add<CombatTech>
	|-ComponentTypeId.Add<DynamicStageElement>
	|-ComponentTypeId.Add<EndlessGameModeManager>
	|-ComponentTypeId.Add<MechanicTutorialGameModeManager>
	|-ComponentTypeId.Add<Rocket>
	|-ComponentTypeId.Add<SpeedRunnersBlastzone>
	|-ComponentTypeId.Add<StageBounds>
	|-ComponentTypeId.Add<Trigger>
	|-ComponentTypeId.Add<VisualShake>
	|
	|-RVA: 0xAE0DE0 Offset: 0xADF3E0 VA: 0x180AE0DE0
	|-ComponentTypeId.Add<Combat>
	|
	|-RVA: 0xAE0890 Offset: 0xADEE90 VA: 0x180AE0890
	|-ComponentTypeId.Add<CombatBlock>
	|-ComponentTypeId.Add<Shockwave>
	|-ComponentTypeId.Add<VisibilitySource>
	|
	|-RVA: 0xAE1330 Offset: 0xADF930 VA: 0x180AE1330
	|-ComponentTypeId.Add<CustomAnimator>
	|
	|-RVA: 0xAE1880 Offset: 0xADFE80 VA: 0x180AE1880
	|-ComponentTypeId.Add<EdgeGrab>
	|-ComponentTypeId.Add<PlayerStats>
	|
	|-RVA: 0xAE1910 Offset: 0xADFF10 VA: 0x180AE1910
	|-ComponentTypeId.Add<FrogmanBossTongue>
	|-ComponentTypeId.Add<GoldenHook>
	|-ComponentTypeId.Add<HazardsRaceGameModeManager>
	|-ComponentTypeId.Add<SimpleLineRenderer>
	|
	|-RVA: 0xAE1E60 Offset: 0xAE0460 VA: 0x180AE1E60
	|-ComponentTypeId.Add<GameEntity>
	|
	|-RVA: 0xAE23B0 Offset: 0xAE09B0 VA: 0x180AE23B0
	|-ComponentTypeId.Add<GameModeItemAutoTrigger>
	|
	|-RVA: 0xAE3310 Offset: 0xAE1910 VA: 0x180AE3310
	|-ComponentTypeId.Add<InputBuffer>
	|
	|-RVA: 0xAE33A0 Offset: 0xAE19A0 VA: 0x180AE33A0
	|-ComponentTypeId.Add<MechanicTutorialGoalTrigger>
	|
	|-RVA: 0xAE4270 Offset: 0xAE2870 VA: 0x180AE4270
	|-ComponentTypeId.Add<NonDeterministicAnimation>
	|
	|-RVA: 0xAE4C80 Offset: 0xAE3280 VA: 0x180AE4C80
	|-ComponentTypeId.Add<PhysicsBody>
	|
	|-RVA: 0xAE5690 Offset: 0xAE3C90 VA: 0x180AE5690
	|-ComponentTypeId.Add<PlayerManager>
	|
	|-RVA: 0xAE5720 Offset: 0xAE3D20 VA: 0x180AE5720
	|-ComponentTypeId.Add<RaceTutorialGameModeManager>
	|
	|-RVA: 0xAE6130 Offset: 0xAE4730 VA: 0x180AE6130
	|-ComponentTypeId.Add<SpeedRunnersCharacter>
	|
	|-RVA: 0xAE61C0 Offset: 0xAE47C0 VA: 0x180AE61C0
	|-ComponentTypeId.Add<SpeedRunnersNPC>
	|
	|-RVA: 0xAE6710 Offset: 0xAE4D10 VA: 0x180AE6710
	|-ComponentTypeId.Add<StateMachine>
	|-ComponentTypeId.Add<StellarCharacter>
	|
	|-RVA: 0xAE7120 Offset: 0xAE5720 VA: 0x180AE7120
	|-ComponentTypeId.Add<StatusEffectsModifiers>
	|-ComponentTypeId.Add<TrapDoor>
	|-ComponentTypeId.Add<TrapDoorSwitch>
	|
	|-RVA: 0xAE2DC0 Offset: 0xAE13C0 VA: 0x180AE2DC0
	|-ComponentTypeId.Add<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Add<T>(ComponentCallbacks callbacks, ComponentFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADC9F0 Offset: 0xADAFF0 VA: 0x180ADC9F0
	|-ComponentTypeId.Add<AIVolume>
	|-ComponentTypeId.Add<Grab>
	|-ComponentTypeId.Add<SpawnPoint>
	|
	|-RVA: 0xADCEB0 Offset: 0xADB4B0 VA: 0x180ADCEB0
	|-ComponentTypeId.Add<BaseGameModeManager>
	|-ComponentTypeId.Add<CollectorTreasure>
	|-ComponentTypeId.Add<CombatPoints>
	|-ComponentTypeId.Add<CombatStocks>
	|-ComponentTypeId.Add<DestroyEntitiesManager>
	|-ComponentTypeId.Add<EntityReferencesHandler>
	|-ComponentTypeId.Add<LayoutManager>
	|-ComponentTypeId.Add<MapEntityLink>
	|-ComponentTypeId.Add<PersistentEntity>
	|-ComponentTypeId.Add<SecretRoomTrigger>
	|-ComponentTypeId.Add<Spike>
	|-ComponentTypeId.Add<Static>
	|-ComponentTypeId.Add<Teams>
	|
	|-RVA: 0xADD950 Offset: 0xADBF50 VA: 0x180ADD950
	|-ComponentTypeId.Add<Blastzone>
	|-ComponentTypeId.Add<BossFightGameModeManager>
	|-ComponentTypeId.Add<CharacterController2D>
	|-ComponentTypeId.Add<CheckpointManager>
	|-ComponentTypeId.Add<CombatDI>
	|-ComponentTypeId.Add<NavMeshAvoidanceAgent>
	|-ComponentTypeId.Add<NavMeshSteeringAgent>
	|-ComponentTypeId.Add<PhysicsModifier>
	|-ComponentTypeId.Add<StageHazardSpawnArea>
	|
	|-RVA: 0xADD400 Offset: 0xADBA00 VA: 0x180ADD400
	|-ComponentTypeId.Add<BlastzoneTrigger>
	|-ComponentTypeId.Add<CombatDamage>
	|-ComponentTypeId.Add<PhysicsJoints2D>
	|-ComponentTypeId.Add<PhysicsJoints3D>
	|-ComponentTypeId.Add<RoomMember>
	|-ComponentTypeId.Add<StaticRotation>
	|-ComponentTypeId.Add<View>
	|
	|-RVA: 0xADDEA0 Offset: 0xADC4A0 VA: 0x180ADDEA0
	|-ComponentTypeId.Add<BreakableGlass>
	|-ComponentTypeId.Add<Jump>
	|-ComponentTypeId.Add<PhysicsCollider2D>
	|-ComponentTypeId.Add<VisibilityTarget>
	|
	|-RVA: 0xADE480 Offset: 0xADCA80 VA: 0x180ADE480
	|-ComponentTypeId.Add<CameraManager>
	|-ComponentTypeId.Add<ItemAutoTrigger>
	|
	|-RVA: 0xADE940 Offset: 0xADCF40 VA: 0x180ADE940
	|-ComponentTypeId.Add<CameraTarget>
	|-ComponentTypeId.Add<EscapeRoomGameModeManager>
	|-ComponentTypeId.Add<PhysicsBody2D>
	|
	|-RVA: 0xADEE90 Offset: 0xADD490 VA: 0x180ADEE90
	|-ComponentTypeId.Add<CampaignBoss>
	|-ComponentTypeId.Add<EntityModifierTarget>
	|-ComponentTypeId.Add<EscapeRoomGoalTrigger>
	|-ComponentTypeId.Add<ItemBox>
	|-ComponentTypeId.Add<VelocityModifier>
	|
	|-RVA: 0xADF3E0 Offset: 0xADD9E0 VA: 0x180ADF3E0
	|-ComponentTypeId.Add<CampaignRaceGameModeManager>
	|-ComponentTypeId.Add<Checkpoint>
	|-ComponentTypeId.Add<CollectorsGameModeManager>
	|-ComponentTypeId.Add<CombatArmor>
	|-ComponentTypeId.Add<CombatCharge>
	|-ComponentTypeId.Add<CombatStamina>
	|-ComponentTypeId.Add<ContinuousRotation>
	|-ComponentTypeId.Add<EntityModifier>
	|-ComponentTypeId.Add<KinematicBody>
	|-ComponentTypeId.Add<Movable>
	|-ComponentTypeId.Add<PartnersManager>
	|-ComponentTypeId.Add<RaceGameModeManager>
	|-ComponentTypeId.Add<TournamentGameModeManager>
	|-ComponentTypeId.Add<Transform2D>
	|-ComponentTypeId.Add<TriggerPolygonShape>
	|-ComponentTypeId.Add<TriggerSphereShape>
	|
	|-RVA: 0xADF930 Offset: 0xADDF30 VA: 0x180ADF930
	|-ComponentTypeId.Add<CharacterController3D>
	|-ComponentTypeId.Add<CombatBlock>
	|-ComponentTypeId.Add<Shockwave>
	|-ComponentTypeId.Add<VisibilitySource>
	|
	|-RVA: 0xADFDF0 Offset: 0xADE3F0 VA: 0x180ADFDF0
	|-ComponentTypeId.Add<CollectorCharacter>
	|-ComponentTypeId.Add<EnergyBar>
	|-ComponentTypeId.Add<FrameByFrame>
	|-ComponentTypeId.Add<GameTimeManager>
	|-ComponentTypeId.Add<InitialWaitTimer>
	|-ComponentTypeId.Add<Laser>
	|-ComponentTypeId.Add<MatchTimer>
	|-ComponentTypeId.Add<MovesetLimiter>
	|-ComponentTypeId.Add<ParentObject>
	|-ComponentTypeId.Add<PhysicsCallbacks2D>
	|-ComponentTypeId.Add<PhysicsCallbacks3D>
	|-ComponentTypeId.Add<PlatformFightGameModeManager>
	|-ComponentTypeId.Add<RespawnPoint>
	|-ComponentTypeId.Add<RocketLauncher>
	|-ComponentTypeId.Add<SpeedRunnersItem>
	|-ComponentTypeId.Add<StageEdge>
	|-ComponentTypeId.Add<StageSFX>
	|-ComponentTypeId.Add<StageTimeline>
	|-ComponentTypeId.Add<StatusEffectsHolder>
	|-ComponentTypeId.Add<StellarNPC>
	|-ComponentTypeId.Add<SuperBoostVolume>
	|-ComponentTypeId.Add<TrainingGameModeManager>
	|-ComponentTypeId.Add<Transform2DVertical>
	|
	|-RVA: 0xAE0340 Offset: 0xADE940 VA: 0x180AE0340
	|-ComponentTypeId.Add<CollectorsTreasureSpawnArea>
	|-ComponentTypeId.Add<CombatTech>
	|-ComponentTypeId.Add<DynamicStageElement>
	|-ComponentTypeId.Add<EndlessGameModeManager>
	|-ComponentTypeId.Add<MechanicTutorialGameModeManager>
	|-ComponentTypeId.Add<NavMeshAvoidanceObstacle>
	|-ComponentTypeId.Add<Rocket>
	|-ComponentTypeId.Add<SpeedRunnersBlastzone>
	|-ComponentTypeId.Add<StageBounds>
	|-ComponentTypeId.Add<Trigger>
	|-ComponentTypeId.Add<VisualShake>
	|
	|-RVA: 0xAE0920 Offset: 0xADEF20 VA: 0x180AE0920
	|-ComponentTypeId.Add<Combat>
	|
	|-RVA: 0xAE0E70 Offset: 0xADF470 VA: 0x180AE0E70
	|-ComponentTypeId.Add<CustomAnimator>
	|
	|-RVA: 0xAE13C0 Offset: 0xADF9C0 VA: 0x180AE13C0
	|-ComponentTypeId.Add<EdgeGrab>
	|-ComponentTypeId.Add<PlayerStats>
	|
	|-RVA: 0xAE19A0 Offset: 0xADFFA0 VA: 0x180AE19A0
	|-ComponentTypeId.Add<FrogmanBossTongue>
	|-ComponentTypeId.Add<GoldenHook>
	|-ComponentTypeId.Add<HazardsRaceGameModeManager>
	|-ComponentTypeId.Add<SimpleLineRenderer>
	|-ComponentTypeId.Add<Transform3D>
	|
	|-RVA: 0xAE1EF0 Offset: 0xAE04F0 VA: 0x180AE1EF0
	|-ComponentTypeId.Add<GameEntity>
	|
	|-RVA: 0xAE2440 Offset: 0xAE0A40 VA: 0x180AE2440
	|-ComponentTypeId.Add<GameModeItemAutoTrigger>
	|
	|-RVA: 0xAE2E50 Offset: 0xAE1450 VA: 0x180AE2E50
	|-ComponentTypeId.Add<InputBuffer>
	|
	|-RVA: 0xAE3430 Offset: 0xAE1A30 VA: 0x180AE3430
	|-ComponentTypeId.Add<MechanicTutorialGoalTrigger>
	|
	|-RVA: 0xAE38F0 Offset: 0xAE1EF0 VA: 0x180AE38F0
	|-ComponentTypeId.Add<NavMeshPathfinder>
	|
	|-RVA: 0xAE3DB0 Offset: 0xAE23B0 VA: 0x180AE3DB0
	|-ComponentTypeId.Add<NonDeterministicAnimation>
	|
	|-RVA: 0xAE47C0 Offset: 0xAE2DC0 VA: 0x180AE47C0
	|-ComponentTypeId.Add<PhysicsBody>
	|
	|-RVA: 0xAE4300 Offset: 0xAE2900 VA: 0x180AE4300
	|-ComponentTypeId.Add<PhysicsBody3D>
	|
	|-RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10
	|-ComponentTypeId.Add<PhysicsCollider3D>
	|
	|-RVA: 0xAE51D0 Offset: 0xAE37D0 VA: 0x180AE51D0
	|-ComponentTypeId.Add<PlayerManager>
	|
	|-RVA: 0xAE57B0 Offset: 0xAE3DB0 VA: 0x180AE57B0
	|-ComponentTypeId.Add<RaceTutorialGameModeManager>
	|
	|-RVA: 0xAE5C70 Offset: 0xAE4270 VA: 0x180AE5C70
	|-ComponentTypeId.Add<SpeedRunnersCharacter>
	|
	|-RVA: 0xAE6250 Offset: 0xAE4850 VA: 0x180AE6250
	|-ComponentTypeId.Add<SpeedRunnersNPC>
	|
	|-RVA: 0xAE67A0 Offset: 0xAE4DA0 VA: 0x180AE67A0
	|-ComponentTypeId.Add<StateMachine>
	|-ComponentTypeId.Add<StellarCharacter>
	|
	|-RVA: 0xAE6C60 Offset: 0xAE5260 VA: 0x180AE6C60
	|-ComponentTypeId.Add<StatusEffectsModifiers>
	|-ComponentTypeId.Add<TrapDoor>
	|-ComponentTypeId.Add<TrapDoorSwitch>
	|
	|-RVA: 0xAE2900 Offset: 0xAE0F00 VA: 0x180AE2900
	|-ComponentTypeId.Add<__Il2CppFullySharedGenericStructType>
	*/
}
