# Stage: Genetics

- StageID: `Genetics`
- Type: 1  (StageType enum)
- Music: StageMusic   Locked by default: 0
- Layouts: A, B (2)
- BlacklistedFromRandom flags: []

## Scenes (4)

### GeneticsStage.unity  (2 GameObjects, 7 KB)
**Scripts/components in scene:** TestRunner x1, ShapesCollisionVisualizer x1, StageLayoutLoader x1, ShapesDebugger x1

**Most common object names:** StageLoader x1, TestRunner x1

### GeneticsStage_A.unity  (48864 GameObjects, 114387 KB)
**Scripts/components in scene:** StellarTileInstance x23649, QuantumStaticBoxCollider2D x22973, QuantumStaticPolygonCollider2D x676, EntityPrototype x174, EntityView x155, EntityComponentStatic x148, TriggerVisualizer x132, EntityComponentVisibilityTarget x131, EntityComponentTrigger x131, EntityComponentTriggerPolygonShape x101, EntityComponentAIVolume x75, ?3160adc3 x64, GameEntityManager x46, EntityComponentGameEntity x46, GameEntityObjectsManager x30, GameEntityRenderManager x30, EntityComponentTriggerSphereShape x30, CollectorsTreasureSpawnAreaVisualizer x18, EntityComponentCollectorsTreasureSpawnArea x18, EntityComponentCheckpoint x15, CheckpointDirectionVisualizer x15, EntityComponentItemBox x13, EntityComponentTrapDoor x11, EntityComponentRespawnPoint x11, ?c88ab7b3 x9, BadgePlatformIcon x8, EntityComponentStageSFX x6, EntityComponentSuperBoostVolume x6, ?67dfb1fd x4, EntityComponentTrapDoorSwitch x4, IntroBanner x4, TrapDoorSwitchManager x4, ?d3e719b5 x2, EntityComponentCheckpointManager x1, ?57c9a3e5 x1, MapData x1, StellarTileMap x1, PlatformOverrides x1, EntityComponentCameraManager x1, EntityComponentSpawnPoint x1

**Most common object names:** wall x21779, Wall x21779, ceiling x885, Ceiling x885, slope_ceiling_L x278, Slope_ceiling_L x278, walljump_L x172, WallJump_L x172, slope_up_R x169, Slope_up_R x169, WallJump_R x137, walljump_R x137, stairs_R x82, Stairs_R x82, AIVolume x75, Smoke x72, Stairs_L x66, stairs_L x66, slope_ceiling_R x60, Slope_ceiling_R x60, Visuals x46, RotationPivot x46, RotationOffset x46, MainTransform x46, Cube x39, LabEnv_Geo_HangarLightPlane x30, ComicShape x26, Item x24, Hurt x24, LabEnv_Geo_ElevatorLightPlane x23

### GeneticsStage_PhysicsTest.unity  (7068 GameObjects, 15167 KB)
**Scripts/components in scene:** StellarTileInstance x3525, QuantumStaticBoxCollider2D x3503, QuantumStaticPolygonCollider2D x22, EntityPrototype x6, EntityComponentStatic x4, EntityView x3, EntityComponentCheckpoint x2, TriggerVisualizer x2, CheckpointDirectionVisualizer x2, EntityComponentTriggerPolygonShape x2, EntityComponentVisibilityTarget x2, EntityComponentTrigger x2, ?57c9a3e5 x1, MapData x1, EntityComponentCheckpointManager x1, StellarTileMap x1, ?3160adc3 x1, EntityComponentCameraManager x1, EntityComponentSpawnPoint x1, EntityComponentRespawnPoint x1

**Most common object names:** wall x3200, Wall x3200, ceiling x186, Ceiling x186, WallJump_R x65, walljump_R x65, walljump_L x52, WallJump_L x52, slope_up_L x11, slope_up_R x11, Slope_up_R x11, Slope_up_L x11, Directional Light x2, Checkpoint x2, RespawnPoints x1, PhysicsTestTileMap x1, SpawnPoints x1, PostProcess x1, MapGeometry x1, MapData x1, Reflection Probe x1, StageElements x1, CheckpointManager x1, Lighting x1, TileMap x1, RespawnPoint x1, CameraSettings x1, StartPoint x1

### GeneticsStage_Standard.unity  (46200 GameObjects, 107484 KB)
**Scripts/components in scene:** StellarTileInstance x22434, QuantumStaticBoxCollider2D x21950, QuantumStaticPolygonCollider2D x484, EntityPrototype x169, EntityComponentStatic x150, EntityView x139, EntityComponentVisibilityTarget x126, EntityComponentTrigger x126, TriggerVisualizer x126, EntityComponentTriggerPolygonShape x112, EntityComponentAIVolume x70, ?3160adc3 x53, GameEntityManager x30, EntityComponentGameEntity x30, EntityComponentCheckpoint x20, CheckpointDirectionVisualizer x20, CollectorsTreasureSpawnAreaVisualizer x18, EntityComponentCollectorsTreasureSpawnArea x18, EntityComponentStageSFX x16, GameEntityObjectsManager x16, GameEntityRenderManager x16, EntityComponentSuperBoostVolume x16, EntityComponentTriggerSphereShape x14, EntityComponentRespawnPoint x12, EntityComponentTrapDoor x10, ?c88ab7b3 x9, BadgePlatformIcon x8, EntityComponentItemBox x7, ?67dfb1fd x4, EntityComponentTrapDoorSwitch x4, IntroBanner x4, TrapDoorSwitchManager x4, ?d3e719b5 x2, ?57c9a3e5 x1, StellarTileMap x1, MapData x1, EntityComponentCheckpointManager x1, EntityComponentCameraManager x1, EntityComponentSpawnPoint x1, IntroBanners x1

**Most common object names:** wall x20748, Wall x20748, ceiling x971, Ceiling x971, slope_ceiling_L x180, Slope_ceiling_L x180, walljump_L x143, WallJump_L x143, stairs_R x102, Stairs_R x102, WallJump_R x88, walljump_R x88, slope_ceiling_R x82, Slope_ceiling_R x82, Stairs_L x77, stairs_L x77, Smoke x72, AIVolume x70, Cube x33, LabEnv_Geo_HangarLightPlane x30, Visuals x30, RotationPivot x30, RotationOffset x30, MainTransform x30, slope_up_R x29, Slope_up_R x29, LabEnv_Geo_ElevatorLightPlane x23, Checkpoint x20, Trails_Smaller x18, CollectorsTreasureSpawnArea x18

## Quantum map data (static collision)

### GeneticsStage_A_MapData.txt
- World size: 512   static 2D colliders: **1280**
- Collider position range: X -202.8..49.2  (span 252.0),  Y -6.8..108.0  (span 114.8)
- Physics layers: Stage x1240, Ceiling x29, Wall x11
- Shapes: polygon x676, 4 x604
- Collider kinds: MergedStatic_L x604, Slope_ceiling_L x278, Slope_up_R x169, Stairs_R x82, Stairs_L x66, Slope_ceiling_R x60, Slope_up_L x21

### GeneticsStage_PhysicsTest_MapData.txt
- World size: 512   static 2D colliders: **3525**
- Collider position range: X -24.8..62.2  (span 87.0),  Y -3.8..46.8  (span 50.5)
- Physics layers: Stage x3222, Ceiling x186, Wall x117
- Shapes: 4 x3503, polygon x22
- Collider kinds: Wall x3200, Ceiling x186, WallJump_R x65, WallJump_L x52, Slope_up_R x11, Slope_up_L x11

### GeneticsStage_Standard_MapData.txt
- World size: 512   static 2D colliders: **1001**
- Collider position range: X -202.8..49.2  (span 252.0),  Y -6.8..108.0  (span 114.8)
- Physics layers: Stage x963, Ceiling x30, Wall x8
- Shapes: 4 x517, polygon x484
- Collider kinds: MergedStatic_L x517, Slope_ceiling_L x180, Stairs_R x102, Slope_ceiling_R x82, Stairs_L x77, Slope_up_R x29, Slope_up_L x14

## Camera data files: Genetics Camera Manager Data Asset.txt

## Asset folders (file counts incl. .meta)
Materials: 236, Models: 2178, Prefabs: 4, Scenes: 8, Shaders: 50, Textures: 104, VFX: 4
