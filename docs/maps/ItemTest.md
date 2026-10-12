# Stage: ItemTest

- StageID: `ItemTest`
- Type: 1  (StageType enum)
- Music: TutorialMusic   Locked by default: 0
- Layouts: Standard, Physics, BossTest (3)
- BlacklistedFromRandom flags: []

## Scenes (4)

### ItemTestStage.unity  (2 GameObjects, 6 KB)
**Scripts/components in scene:** TestRunner x1, ShapesCollisionVisualizer x1, StageLayoutLoader x1, ShapesDebugger x1

**Most common object names:** StageLoader x1, TestRunner x1

### ItemTestStage_BossTest.unity  (7113 GameObjects, 17321 KB)
**Scripts/components in scene:** StellarTileInstance x3289, QuantumStaticBoxCollider2D x3285, EntityPrototype x12, EntityView x11, GameEntityObjectsManager x10, GameEntityRenderManager x10, GameEntityManager x10, EntityComponentGameEntity x10, EntityComponentVisibilityTarget x8, TriggerVisualizer x8, ?3160adc3 x8, EntityComponentTrigger x8, EntityComponentStatic x5, QuantumStaticPolygonCollider2D x4, EntityComponentTriggerPolygonShape x4, EntityComponentTriggerSphereShape x4, EntityComponentItemBox x4, EntityComponentCampaignBoss x2, EntityComponentSimpleLineRenderer x2, VFXObject x2, EntityComponentCameraTarget x2, CharacterOutlineManager x2, CustomAnimatorManager x2, EntityComponentKinematicBody x2, CharacterReferencePoint x2, EntityComponentCombatStamina x2, ?57c9a3e5 x1, MapData x1, StellarTileMap x1, EntityComponentCameraManager x1, EntityComponentSpawnPoint x1

**Most common object names:** wall x3245, Wall x3245, ceiling x40, Ceiling x40, Visuals x11, MainTransform x10, RotationPivot x10, RotationOffset x10, Body x9, SR_ENV_Metro_GP_SprintRefill x8, ComicShape x8, OuterThruster x6, R_Eye x6, L_Eye x6, Sparkles x5, SyncBoneDummy x4, BostFillerVisuals x4, ItemBox Costume00 Prefab x4, Empty x4, ItemBox Visuals x4, ItemBox x4, Glow x4, SR_VFX_P_Common_Crate x4, SR_VFX_P_Common_ItemBox x4, Impact x4, BoostFiller Costume00 Prefab x4, CrateImpact x4, Waves x4, SR_ENV_Metro_GP_OrbPickup x4, PS_Circle x4

### ItemTestStage_PhysicsTest.unity  (8172 GameObjects, 17536 KB)
**Scripts/components in scene:** StellarTileInstance x4077, QuantumStaticBoxCollider2D x4046, QuantumStaticPolygonCollider2D x31, EntityPrototype x6, EntityComponentStatic x4, EntityView x3, EntityComponentCheckpoint x2, TriggerVisualizer x2, CheckpointDirectionVisualizer x2, EntityComponentTriggerPolygonShape x2, EntityComponentVisibilityTarget x2, EntityComponentTrigger x2, EntityComponentCheckpointManager x1, StellarTileMap x1, ?57c9a3e5 x1, MapData x1, ?3160adc3 x1, EntityComponentCameraManager x1, EntityComponentSpawnPoint x1, EntityComponentRespawnPoint x1

**Most common object names:** wall x3743, Wall x3743, ceiling x186, Ceiling x186, WallJump_R x65, walljump_R x65, walljump_L x52, WallJump_L x52, slope_up_L x11, slope_up_R x11, Slope_up_L x11, Slope_up_R x11, slope_ceiling_L x9, Slope_ceiling_L x9, Directional Light x2, Checkpoint x2, CheckpointManager x1, SpawnPoints x1, StageElements x1, RespawnPoints x1, PhysicsTestTileMap x1, TileMap x1, PostProcess x1, MapGeometry x1, MapData x1, Reflection Probe x1, Lighting x1, RespawnPoint x1, CameraSettings x1, StartPoint x1

### ItemTestStage_Standard.unity  (9005 GameObjects, 28070 KB)
**Scripts/components in scene:** StellarTileInstance x4165, QuantumStaticBoxCollider2D x3712, QuantumStaticPolygonCollider2D x453, EntityPrototype x50, ?3160adc3 x45, EntityView x43, TriggerVisualizer x43, EntityComponentVisibilityTarget x41, EntityComponentTrigger x41, GameEntityManager x40, EntityComponentGameEntity x40, GameEntityObjectsManager x31, EntityComponentTriggerSphereShape x31, GameEntityRenderManager x29, EntityComponentStatic x26, EntityComponentItemBox x16, EntityComponentTriggerPolygonShape x10, EntityComponentTrapDoorSwitch x3, EntityComponentStageSFX x3, EntityComponentTrapDoor x3, EntityComponentSuperBoostVolume x3, TrapDoorSwitchManager x3, EntityComponentCheckpointManager x2, EntityComponentCheckpoint x2, CheckpointDirectionVisualizer x2, ?57c9a3e5 x1, MapData x1, StellarTileMap x1, BK_EnvironmentManager x1, EntityComponentSimpleLineRenderer x1, EntityComponentCollectorTreasure x1, EntityComponentBreakableGlass x1, EntityComponentCameraManager x1, EntityComponentSpawnPoint x1, EntityComponentRespawnPoint x1, BreakableGlassManager x1

**Most common object names:** wall x3168, Wall x3168, ceiling x306, Ceiling x306, WallJump_R x166, walljump_R x166, slope_up_L x124, Slope_up_L x124, slope_ceiling_R x122, Slope_ceiling_R x122, slope_up_R x114, Slope_up_R x114, slope_ceiling_L x93, Slope_ceiling_L x93, walljump_L x72, WallJump_L x72, MainTransform x40, Visuals x40, RotationPivot x40, RotationOffset x40, ComicShape x32, Cube x19, Item x18, PS_Circle x18, Hurt x18, Sparkles x17, SyncBoneDummy x16, ItemBox Costume00 Prefab x16, ItemBox Visuals x16, ItemBox x16

## Quantum map data (static collision)

### ItemTestStage_BossTest_MapData.txt
- World size: 512   static 2D colliders: **3289**
- Collider position range: X -57.8..105.8  (span 163.5),  Y -6.2..62.2  (span 68.5)
- Physics layers: Stage x3249, Ceiling x40
- Shapes: 4 x3285, polygon x4
- Collider kinds: Wall x3245, Ceiling x40, Slope_ceiling_R x2, Slope_ceiling_L x2

### ItemTestStage_PhysicsTest_MapData.txt
- World size: 512   static 2D colliders: **4077**
- Collider position range: X -24.8..108.2  (span 133.0),  Y -3.8..46.8  (span 50.5)
- Physics layers: Stage x3774, Ceiling x186, Wall x117
- Shapes: 4 x4046, polygon x31
- Collider kinds: Wall x3743, Ceiling x186, WallJump_R x65, WallJump_L x52, Slope_up_R x11, Slope_up_L x11, Slope_ceiling_L x9

### ItemTestStage_Standard_MapData.txt
- World size: 512   static 2D colliders: **4165**
- Collider position range: X -84.8..148.8  (span 233.5),  Y -3.2..102.8  (span 106.1)
- Physics layers: Stage x3621, Ceiling x306, Wall x238
- Shapes: 4 x3712, polygon x453
- Collider kinds: Wall x3168, Ceiling x306, WallJump_R x166, Slope_up_L x124, Slope_ceiling_R x122, Slope_up_R x114, Slope_ceiling_L x93, WallJump_L x72

## Camera data files: Testing Stage Camera Manager Data Asset.txt

## Asset folders (file counts incl. .meta)
Scenes: 8
