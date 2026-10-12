# Stage: SSRoyale

- StageID: `SSRoyale`
- Type: 1  (StageType enum)
- Music: StageMusic   Locked by default: 0
- Layouts: A, B (2)
- BlacklistedFromRandom flags: []

## Scenes (3)

### SSRoyaleStage.unity  (2 GameObjects, 7 KB)
**Scripts/components in scene:** TestRunner x1, ShapesCollisionVisualizer x1, StageLayoutLoader x1, ShapesDebugger x1

**Most common object names:** StageLoader x1, TestRunner x1

### SSRoyaleStage_SSRoyaleB.unity  (22590 GameObjects, 56970 KB)
**Scripts/components in scene:** StellarTileInstance x10688, QuantumStaticBoxCollider2D x9873, QuantumStaticPolygonCollider2D x815, EntityPrototype x173, EntityView x151, EntityComponentStatic x147, EntityComponentVisibilityTarget x127, EntityComponentTrigger x127, TriggerVisualizer x127, EntityComponentTriggerPolygonShape x89, ?3160adc3 x68, EntityComponentAIVolume x56, GameEntityManager x54, EntityComponentGameEntity x54, GameEntityObjectsManager x39, GameEntityRenderManager x39, EntityComponentTriggerSphereShape x38, SimpleObjectRotator x20, EntityComponentCheckpoint x19, CheckpointDirectionVisualizer x19, CollectorsTreasureSpawnAreaVisualizer x18, EntityComponentCollectorsTreasureSpawnArea x18, EntityComponentItemBox x15, EntityComponentRespawnPoint x13, EntityComponentTrapDoor x8, BadgePlatformIcon x8, EntityComponentTrapDoorSwitch x7, TrapDoorSwitchManager x7, EntityComponentStageSFX x6, EntityComponentSuperBoostVolume x6, ?67dfb1fd x4, IntroBanner x4, StageHazardSpawnAreaVisualizer x3, EntityComponentStageHazardSpawnArea x3, ?d3e719b5 x2, EntityComponentCheckpointManager x1, PlatformOverrides x1, ?57c9a3e5 x1, StellarTileMap x1, HideOnStart x1

**Most common object names:** wall x9373, Wall x9373, ceiling x423, Ceiling x423, slope_ceiling_R x246, Slope_ceiling_R x246, slope_up_L x148, Slope_up_L x148, Stairs_L x136, stairs_L x136, slope_ceiling_L x134, Slope_ceiling_L x134, slope_up_R x87, Slope_up_R x87, stairs_R x64, Stairs_R x64, Visuals x54, RotationPivot x54, RotationOffset x54, MainTransform x54, walljump_L x46, WallJump_L x46, Item x32, Hurt x32, WallJump_R x31, walljump_R x31, ComicShape x30, SR_SSR_ENV_Geo_Blade x27, AIVolume AdvVol x22, Cube x22

### SSRoyaleStage_Standard.unity  (22467 GameObjects, 54652 KB)
**Scripts/components in scene:** StellarTileInstance x10642, QuantumStaticBoxCollider2D x9968, QuantumStaticPolygonCollider2D x674, EntityPrototype x170, EntityView x152, EntityComponentStatic x145, TriggerVisualizer x121, EntityComponentVisibilityTarget x120, EntityComponentTrigger x120, EntityComponentTriggerPolygonShape x81, ?3160adc3 x68, GameEntityManager x54, EntityComponentGameEntity x54, EntityComponentAIVolume x54, EntityComponentTriggerSphereShape x39, GameEntityObjectsManager x37, GameEntityRenderManager x37, SimpleObjectRotator x20, CollectorsTreasureSpawnAreaVisualizer x20, EntityComponentCollectorsTreasureSpawnArea x20, EntityComponentCheckpoint x19, CheckpointDirectionVisualizer x19, EntityComponentRespawnPoint x13, EntityComponentItemBox x12, EntityComponentTrapDoor x9, BadgePlatformIcon x8, EntityComponentTrapDoorSwitch x7, TrapDoorSwitchManager x7, ?67dfb1fd x4, IntroBanner x4, StageHazardSpawnAreaVisualizer x3, EntityComponentStageHazardSpawnArea x3, EntityComponentStageSFX x2, ?d3e719b5 x2, EntityComponentSuperBoostVolume x2, EntityComponentHazardsRaceGameModeManager x1, StellarTileMap x1, HideOnStart x1, EntityComponentCheckpointManager x1, ?57c9a3e5 x1

**Most common object names:** wall x9612, Wall x9612, ceiling x279, Ceiling x279, slope_ceiling_R x227, Slope_ceiling_R x227, Stairs_L x169, stairs_L x169, slope_up_L x110, Slope_up_L x110, stairs_R x78, Stairs_R x78, slope_ceiling_L x73, Slope_ceiling_L x73, Visuals x54, RotationPivot x54, RotationOffset x54, MainTransform x54, walljump_L x46, WallJump_L x46, Item x38, Hurt x38, WallJump_R x31, walljump_R x31, SR_SSR_ENV_Geo_Blade x27, ComicShape x24, CollectorsTreasureSpawnArea x20, RedGlow x19, SR_ENV_Metro_GP_CubeOutline x19, SR_ENV_Metro_GP_CubeOutlineDefased x19

## Quantum map data (static collision)

### SSRoyaleStage_SSRoyaleB_MapData.txt
- World size: 512   static 2D colliders: **1530**
- Collider position range: X -151.8..265.2  (span 416.9),  Y -32.2..62.8  (span 95.0)
- Physics layers: Stage x1509, Ceiling x19, Wall x2
- Shapes: polygon x815, 4 x715
- Collider kinds: MergedStatic_L x715, Slope_ceiling_R x246, Slope_up_L x148, Stairs_L x136, Slope_ceiling_L x134, Slope_up_R x87, Stairs_R x64

### SSRoyaleStage_Standard_MapData.txt
- World size: 512   static 2D colliders: **1302**
- Collider position range: X -151.8..265.2  (span 416.9),  Y -32.2..99.2  (span 131.5)
- Physics layers: Stage x1290, Ceiling x10, Wall x2
- Shapes: polygon x674, 4 x628
- Collider kinds: MergedStatic_L x628, Slope_ceiling_R x227, Stairs_L x169, Slope_up_L x110, Stairs_R x78, Slope_ceiling_L x73, Slope_up_R x17

## Camera data files: SSRoyale Camera Manager Data Asset.txt

## Asset folders (file counts incl. .meta)
Animations: 8, Materials: 212, Models: 414, Prefabs: 2, Scenes: 6, Shaders: 4, Textures: 112
