// Namespace: Quantum
public class EntityUtils // TypeDefIndex: 10372
{
	// Methods

	// RVA: 0x2184AD0 Offset: 0x21830D0 VA: 0x182184AD0
	public static bool TryGetSpeedRunnersCharacter(Frame frame, EntityRef entity, out SpeedRunnersCharacter* speedRunnerCharacter) { }

	// RVA: 0x2182620 Offset: 0x2180C20 VA: 0x182182620
	public static bool TryGetGoldenHook(Frame frame, EntityRef entity, out GoldenHook* goldenHook) { }

	// RVA: 0x2182300 Offset: 0x2180900 VA: 0x182182300
	public static bool TryGetFrogmanBossTongue(Frame frame, EntityRef entity, out FrogmanBossTongue* frogmanBossTongue) { }

	// RVA: 0x2184490 Offset: 0x2182A90 VA: 0x182184490
	public static bool TryGetRocket(Frame frame, EntityRef entity, out Rocket* rocket) { }

	// RVA: 0x21847B0 Offset: 0x2182DB0 VA: 0x1821847B0
	public static bool TryGetShockwave(Frame frame, EntityRef entity, out Shockwave* shockwave) { }

	// RVA: 0x21803A0 Offset: 0x217E9A0 VA: 0x1821803A0
	public static bool TryGetCheckpoint(Frame frame, EntityRef entity, out Checkpoint* checkpoint) { }

	// RVA: 0x2185110 Offset: 0x2183710 VA: 0x182185110
	public static bool TryGetStageHazardSpawnArea(Frame frame, EntityRef entity, out StageHazardSpawnArea* stageHazardSpawnArea) { }

	// RVA: 0x2185F20 Offset: 0x2184520 VA: 0x182185F20
	public static bool TryGetSuperBoostVolume(Frame frame, EntityRef entity, out SuperBoostVolume* superBoostVolume) { }

	// RVA: 0x2184DF0 Offset: 0x21833F0 VA: 0x182184DF0
	public static bool TryGetSpike(Frame frame, EntityRef entity, out Spike* spike) { }

	// RVA: 0x217FD60 Offset: 0x217E360 VA: 0x18217FD60
	public static bool TryGetAIVolume(Frame frame, EntityRef entity, out AIVolume* aiVolume) { }

	// RVA: 0x21871E0 Offset: 0x21857E0 VA: 0x1821871E0
	public static bool TryGetTrapDoorSwitch(Frame frame, EntityRef entity, out TrapDoorSwitch* trapDoorSwitch) { }

	// RVA: 0x2182F80 Offset: 0x2181580 VA: 0x182182F80
	public static bool TryGetLaser(Frame frame, EntityRef entity, out Laser* laser) { }

	// RVA: 0x2184300 Offset: 0x2182900 VA: 0x182184300
	public static bool TryGetRocketLauncher(Frame frame, EntityRef entity, out RocketLauncher* rocketLauncher) { }

	// RVA: 0x2182AD0 Offset: 0x21810D0 VA: 0x182182AD0
	public static bool TryGetItemBox(Frame frame, EntityRef entity, out ItemBox* itemBox) { }

	// RVA: 0x2184C60 Offset: 0x2183260 VA: 0x182184C60
	public static bool TryGetSpeedRunnersNPC(Frame frame, EntityRef entity, out SpeedRunnersNPC* npc) { }

	// RVA: 0x217F920 Offset: 0x217DF20 VA: 0x18217F920
	public static bool IsCharacterSpeedRunnersNPC(Frame frame, EntityRef entity) { }

	// RVA: 0x2183110 Offset: 0x2181710 VA: 0x182183110
	public static bool TryGetMechanicTutorialGoalTrigger(Frame frame, EntityRef entity, out MechanicTutorialGoalTrigger* goalTrigger) { }

	// RVA: 0x2182170 Offset: 0x2180770 VA: 0x182182170
	public static bool TryGetEscapeRoomGoalTrigger(Frame frame, EntityRef entity, out EscapeRoomGoalTrigger* escapeRoomgoalTrigger) { }

	// RVA: 0x2184620 Offset: 0x2182C20 VA: 0x182184620
	public static bool TryGetSecretRoomTrigger(Frame frame, EntityRef entity, out SecretRoomTrigger* secretRoomTrigger) { }

	// RVA: 0x2180080 Offset: 0x217E680 VA: 0x182180080
	public static bool TryGetBreakableGlass(Frame frame, EntityRef entity, out BreakableGlass* breakableGlass) { }

	// RVA: 0x2184170 Offset: 0x2182770 VA: 0x182184170
	internal static bool TryGetRespawnPoint(Frame frame, EntityRef entity, out RespawnPoint* respawnPoint) { }

	// RVA: 0x2183FE0 Offset: 0x21825E0 VA: 0x182183FE0
	public static bool TryGetPlayerStats(Frame frame, EntityRef characterEntity, out PlayerStats* playerStats) { }

	// RVA: 0x2180850 Offset: 0x217EE50 VA: 0x182180850
	public static bool TryGetCollectorsTreasureSpawnArea(Frame frame, EntityRef entity, out CollectorsTreasureSpawnArea* spawnArea) { }

	// RVA: 0x21806C0 Offset: 0x217ECC0 VA: 0x1821806C0
	public static bool TryGetCollectorTreasure(Frame frame, EntityRef entity, out CollectorTreasure* collectorTreasure) { }

	// RVA: 0x2180530 Offset: 0x217EB30 VA: 0x182180530
	public static bool TryGetCollectorCharacter(Frame frame, EntityRef entity, out CollectorCharacter* collectorCharacter) { }

	// RVA: 0x217FEF0 Offset: 0x217E4F0 VA: 0x18217FEF0
	public static bool TryGetBlastzoneTrigger(Frame frame, EntityRef entity, out BlastzoneTrigger* blastzoneTrigger) { }

	// RVA: 0x21860B0 Offset: 0x21846B0 VA: 0x1821860B0
	public static bool TryGetTargetEntity(Frame frame, CachedEntityData entityData, BehaviourTargetEntity targetEntityToCheck, HashString targetIndexParameterID, out CachedEntityData targetEntity) { }

	// RVA: 0x217FC50 Offset: 0x217E250 VA: 0x18217FC50
	public static bool TryFindFromIndex(Frame frame, int index, out EntityRef entityFound) { }

	// RVA: 0x2182490 Offset: 0x2180A90 VA: 0x182182490
	public static bool TryGetGameEntity(Frame frame, EntityRef entity, out GameEntity* gameEntity) { }

	// RVA: 0x2181FE0 Offset: 0x21805E0 VA: 0x182181FE0
	public static bool TryGetEntityReferencesHandler(Frame frame, EntityRef entity, out EntityReferencesHandler* entityReferencesHandler) { }

	// RVA: 0x21839A0 Offset: 0x2181FA0 VA: 0x1821839A0
	public static bool TryGetPartnersManager(Frame frame, EntityRef entity, out PartnersManager* partnersManager) { }

	// RVA: 0x2181E50 Offset: 0x2180450 VA: 0x182181E50
	public static bool TryGetEntityModifier(Frame frame, EntityRef entity, out EntityModifier* entityModifier) { }

	// RVA: 0x2181CC0 Offset: 0x21802C0 VA: 0x182181CC0
	public static bool TryGetEntityModifierTarget(Frame frame, EntityRef entity, out EntityModifierTarget* entityModifierTarget) { }

	// RVA: 0x2187050 Offset: 0x2185650 VA: 0x182187050
	public static bool TryGetTransform(Frame frame, EntityRef entity, out Transform2D* transform2D) { }

	// RVA: 0x2185750 Offset: 0x2183D50 VA: 0x182185750
	public static bool TryGetStatic(Frame frame, EntityRef entity, out Static* _static) { }

	// RVA: 0x2187820 Offset: 0x2185E20 VA: 0x182187820
	public static bool TryGetVelocityModifier(Frame frame, EntityRef entity, out VelocityModifier* velocityModifier) { }

	// RVA: 0x2183E50 Offset: 0x2182450 VA: 0x182183E50
	public static bool TryGetPhysicsModifier(Frame frame, EntityRef entity, out PhysicsModifier* physicsModifier) { }

	// RVA: 0x21852A0 Offset: 0x21838A0 VA: 0x1821852A0
	public static bool TryGetStageSFX(Frame frame, EntityRef entity, out StageSFX* stageSFX) { }

	// RVA: 0x2183680 Offset: 0x2181C80 VA: 0x182183680
	public static bool TryGetNonDeterministicAniamtion(Frame frame, EntityRef entity, out NonDeterministicAnimation* nonDeterministic) { }

	// RVA: 0x2187B40 Offset: 0x2186140 VA: 0x182187B40
	public static bool TryGetVisibilityTarget(Frame frame, EntityRef entity, out VisibilityTarget* visibilityTarget) { }

	// RVA: 0x21879B0 Offset: 0x2185FB0 VA: 0x1821879B0
	public static bool TryGetVisibilitySource(Frame frame, EntityRef entity, out VisibilitySource* visibilitySource) { }

	// RVA: 0x2187CD0 Offset: 0x21862D0 VA: 0x182187CD0
	public static bool TryGetVisualShake(Frame frame, EntityRef entity, out VisualShake* visualShake) { }

	// RVA: 0x2183810 Offset: 0x2181E10 VA: 0x182183810
	public static bool TryGetParentObject(Frame frame, EntityRef entity, out ParentObject* parentObject) { }

	// RVA: 0x21855C0 Offset: 0x2183BC0 VA: 0x1821855C0
	public static bool TryGetStaticRotation(Frame frame, EntityRef entity, out StaticRotation* staticRotation) { }

	// RVA: 0x2185C00 Offset: 0x2184200 VA: 0x182185C00
	public static bool TryGetStellarCharacter(Frame frame, EntityRef entity, out StellarCharacter* character) { }

	// RVA: 0x21834F0 Offset: 0x2181AF0 VA: 0x1821834F0
	public static bool TryGetMovesetLimiter(Frame frame, EntityRef entity, out MovesetLimiter* movesetLimiter) { }

	// RVA: 0x2182940 Offset: 0x2180F40 VA: 0x182182940
	public static bool TryGetInputBuffer(Frame frame, EntityRef entity, out InputBuffer* inputBuffer) { }

	// RVA: 0x2185430 Offset: 0x2183A30 VA: 0x182185430
	public static bool TryGetStateMachine(Frame frame, EntityRef entity, out StateMachine* stateMachine) { }

	// RVA: 0x2181740 Offset: 0x217FD40 VA: 0x182181740
	public static bool TryGetCustomAnimator(Frame frame, EntityRef entity, out CustomAnimator* customAnimator) { }

	// RVA: 0x2184940 Offset: 0x2182F40 VA: 0x182184940
	public static bool TryGetSimpleLineRenderer(Frame frame, EntityRef entity, out SimpleLineRenderer* simpleLineRenderer) { }

	// RVA: 0x2183B30 Offset: 0x2182130 VA: 0x182183B30
	public static bool TryGetPhysicsBody(Frame frame, EntityRef entity, out PhysicsBody* physicsBody) { }

	// RVA: 0x2187690 Offset: 0x2185C90 VA: 0x182187690
	public static bool TryGetTrigger(Frame frame, EntityRef entity, out Trigger* trigger) { }

	// RVA: 0x2183CC0 Offset: 0x21822C0 VA: 0x182183CC0
	public static bool TryGetPhysicsCollider(Frame frame, EntityRef entity, out PhysicsCollider2D* collider) { }

	// RVA: 0x2187500 Offset: 0x2185B00 VA: 0x182187500
	public static bool TryGetTriggerSphereShape(Frame frame, EntityRef entity, out TriggerSphereShape* shape) { }

	// RVA: 0x2187370 Offset: 0x2185970 VA: 0x182187370
	public static bool TryGetTriggerPolygonShape(Frame frame, EntityRef entity, out TriggerPolygonShape* shape) { }

	// RVA: 0x2181A60 Offset: 0x2180060 VA: 0x182181A60
	public static bool TryGetEdgeGrab(Frame frame, EntityRef entity, out EdgeGrab* edgeGrab) { }

	// RVA: 0x2184F80 Offset: 0x2183580 VA: 0x182184F80
	public static bool TryGetStageEdge(Frame frame, EntityRef entity, out StageEdge* stageEdge) { }

	// RVA: 0x21818D0 Offset: 0x217FED0 VA: 0x1821818D0
	public static bool TryGetDynamicStageElement(Frame frame, EntityRef entity, out DynamicStageElement* dynamicStageElement) { }

	// RVA: 0x2181420 Offset: 0x217FA20 VA: 0x182181420
	public static bool TryGetCombat(Frame frame, EntityRef entity, out Combat* combat) { }

	// RVA: 0x2181020 Offset: 0x217F620 VA: 0x182181020
	public static bool TryGetCombatDamage(Frame frame, EntityRef entity, out CombatDamage* combatDamage) { }

	// RVA: 0x21810F0 Offset: 0x217F6F0 VA: 0x1821810F0
	public static bool TryGetCombatStamina(Frame frame, EntityRef entity, out CombatStamina* combatStamina) { }

	// RVA: 0x21811C0 Offset: 0x217F7C0 VA: 0x1821811C0
	public static bool TryGetCombatStocks(Frame frame, EntityRef entity, out CombatStocks* combatStocks) { }

	// RVA: 0x2180B70 Offset: 0x217F170 VA: 0x182180B70
	public static bool TryGetCombatBlock(Frame frame, EntityRef entity, out CombatBlock* combatBlock) { }

	// RVA: 0x2181290 Offset: 0x217F890 VA: 0x182181290
	public static bool TryGetCombatTech(Frame frame, EntityRef entity, out CombatTech* combatTech) { }

	// RVA: 0x2180D00 Offset: 0x217F300 VA: 0x182180D00
	public static bool TryGetCombatCharge(Frame frame, EntityRef entity, out CombatCharge* combatCharge) { }

	// RVA: 0x21809E0 Offset: 0x217EFE0 VA: 0x1821809E0
	public static bool TryGetCombatArmor(Frame frame, EntityRef entity, out CombatArmor* combatArmor) { }

	// RVA: 0x2180E90 Offset: 0x217F490 VA: 0x182180E90
	public static bool TryGetCombatDI(Frame frame, EntityRef entity, out CombatDI* combatDI) { }

	// RVA: 0x2186EC0 Offset: 0x21854C0 VA: 0x182186EC0
	public static bool TryGetTeams(Frame frame, EntityRef entity, out Teams* teams) { }

	// RVA: 0x21827B0 Offset: 0x2180DB0 VA: 0x1821827B0
	public static bool TryGetGrab(Frame frame, EntityRef entity, out Grab* grab) { }

	// RVA: 0x2182DF0 Offset: 0x21813F0 VA: 0x182182DF0
	public static bool TryGetKinematicBody(Frame frame, EntityRef entity, out KinematicBody* kinematicBody) { }

	// RVA: 0x21815B0 Offset: 0x217FBB0 VA: 0x1821815B0
	public static bool TryGetContinuousRotation(Frame frame, EntityRef entity, out ContinuousRotation* continuousRotation) { }

	// RVA: 0x2180210 Offset: 0x217E810 VA: 0x182180210
	public static bool TryGetCameraTarget(Frame frame, EntityRef entity, out CameraTarget* cameraTarget) { }

	// RVA: 0x2185D90 Offset: 0x2184390 VA: 0x182185D90
	public static bool TryGetStellarNPC(Frame frame, EntityRef entity, out StellarNPC* npc) { }

	// RVA: 0x217F7B0 Offset: 0x217DDB0 VA: 0x18217F7B0
	public static bool IsCharacterNPC(Frame frame, EntityRef entity) { }

	// RVA: 0x2182C60 Offset: 0x2181260 VA: 0x182182C60
	public static bool TryGetJump(Frame frame, EntityRef entity, out Jump* jump) { }

	// RVA: 0x2181BF0 Offset: 0x21801F0 VA: 0x182181BF0
	public static bool TryGetEnergyBar(Frame frame, EntityRef entity, out EnergyBar* energyBar) { }

	// RVA: 0x21832A0 Offset: 0x21818A0 VA: 0x1821832A0
	public static bool TryGetMovable(Frame frame, EntityRef entity, out Movable* movable, bool addComponent = False) { }

	// RVA: 0x21858E0 Offset: 0x2183EE0 VA: 0x1821858E0
	public static bool TryGetStatusEffectsHolder(Frame frame, EntityRef entity, out StatusEffectsHolder* statusEffectsHolder) { }

	// RVA: 0x2185A70 Offset: 0x2184070 VA: 0x182185A70
	public static bool TryGetStatusEffectsModifiers(Frame frame, EntityRef entity, out StatusEffectsModifiers* statusEffectsModifiers) { }

	// RVA: 0x217F590 Offset: 0x217DB90 VA: 0x18217F590
	public static void DestroyEntity(Frame frame, EntityRef entity) { }

	// RVA: 0x217FA90 Offset: 0x217E090 VA: 0x18217FA90
	public static bool IsEntityInDestroyQueue(Frame frame, EntityRef entity) { }
}
