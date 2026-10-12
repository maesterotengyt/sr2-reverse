# Stage: Museum

- StageID: `Museum`
- Type: 1  (StageType enum)
- Music: StageMusic   Locked by default: 0
- Layouts: A, B (2)
- BlacklistedFromRandom flags: []

## Scenes (3)

### MuseumStage.unity  (2 GameObjects, 7 KB)
**Scripts/components in scene:** TestRunner x1, ShapesCollisionVisualizer x1, StageLayoutLoader x1, ShapesDebugger x1

**Most common object names:** StageLoader x1, TestRunner x1

### MuseumStage_MuseumB.unity  (30312 GameObjects, 79164 KB)
**Scripts/components in scene:** StellarTileInstance x13903, QuantumStaticBoxCollider2D x12827, QuantumStaticPolygonCollider2D x1076, EntityPrototype x253, EntityComponentStatic x223, EntityView x220, TriggerVisualizer x205, EntityComponentVisibilityTarget x203, EntityComponentTrigger x203, EntityComponentTriggerPolygonShape x133, ?3160adc3 x101, GameEntityManager x88, EntityComponentGameEntity x88, EntityComponentAIVolume x88, GameEntityObjectsManager x74, GameEntityRenderManager x71, EntityComponentTriggerSphereShape x70, EntityComponentCheckpoint x21, CheckpointDirectionVisualizer x21, CollectorsTreasureSpawnAreaVisualizer x19, EntityComponentCollectorsTreasureSpawnArea x19, EntityComponentItemBox x19, EntityComponentStageSFX x15, EntityComponentRespawnPoint x15, EntityComponentSuperBoostVolume x15, BadgePlatformIcon x8, EntityComponentTrapDoor x6, EntityComponentTrapDoorSwitch x5, TrapDoorSwitchManager x5, ?67dfb1fd x4, IntroBanner x4, ?2183220b x3, StageHazardSpawnAreaVisualizer x3, EntityComponentStageHazardSpawnArea x3, EntityComponentSimpleLineRenderer x2, ?d3e719b5 x2, ?57c9a3e5 x1, EntityComponentCheckpointManager x1, StellarTileMap x1, HideOnStart x1

**Most common object names:** wall x11908, Wall x11908, ceiling x758, Ceiling x758, slope_up_L x311, Slope_up_L x311, slope_ceiling_R x296, Slope_ceiling_R x296, slope_up_R x213, Slope_up_R x213, slope_ceiling_L x189, Slope_ceiling_L x189, Item x88, MainTransform x88, Hurt x88, Visuals x88, RotationPivot x88, RotationOffset x88, WallJump_R x88, walljump_R x88, walljump_L x73, WallJump_L x73, Stairs_L x64, stairs_L x64, S03_Vegetation_01_BaseColor x61, AIVolume adv x45, RedGlow x44, SR_ENV_Metro_GP_CubeOutline x44, SR_ENV_Metro_GP_CubeOutlineDefased x44, ObstacleVisualsManager x44

### MuseumStage_Standard.unity  (31584 GameObjects, 80781 KB)
**Scripts/components in scene:** StellarTileInstance x14745, QuantumStaticBoxCollider2D x13721, QuantumStaticPolygonCollider2D x1024, EntityPrototype x237, EntityComponentStatic x212, EntityView x205, EntityComponentVisibilityTarget x194, EntityComponentTrigger x194, TriggerVisualizer x194, EntityComponentTriggerPolygonShape x147, EntityComponentAIVolume x102, ?3160adc3 x72, GameEntityManager x58, EntityComponentGameEntity x58, GameEntityObjectsManager x52, GameEntityRenderManager x52, EntityComponentTriggerSphereShape x47, EntityComponentCheckpoint x21, CheckpointDirectionVisualizer x21, CollectorsTreasureSpawnAreaVisualizer x20, EntityComponentCollectorsTreasureSpawnArea x20, EntityComponentItemBox x19, EntityComponentStageSFX x16, EntityComponentSuperBoostVolume x16, EntityComponentRespawnPoint x13, BadgePlatformIcon x8, ?67dfb1fd x4, IntroBanner x4, ?2183220b x3, EntityComponentTrapDoorSwitch x3, EntityComponentTrapDoor x3, TrapDoorSwitchManager x3, StageHazardSpawnAreaVisualizer x3, EntityComponentStageHazardSpawnArea x3, ?d3e719b5 x2, ?57c9a3e5 x1, EntityComponentCheckpointManager x1, MapData x1, PlatformOverrides x1, EntityComponentHazardsRaceGameModeManager x1

**Most common object names:** wall x12557, Wall x12557, ceiling x582, Ceiling x582, WallJump_R x308, walljump_R x308, walljump_L x274, WallJump_L x274, slope_ceiling_R x266, Slope_ceiling_R x266, slope_up_L x256, Slope_up_L x256, slope_up_R x234, Slope_up_R x234, slope_ceiling_L x189, Slope_ceiling_L x189, Stairs_L x76, stairs_L x76, S03_Vegetation_01_BaseColor x61, AIVolume 1 x60, Visuals x58, RotationPivot x58, RotationOffset x58, MainTransform x58, Item x50, Hurt x50, AIVolume adv x41, ComicShape x38, SetDress x27, Trails x25

## Quantum map data (static collision)

### MuseumStage_MuseumB_MapData.txt
- World size: 512   static 2D colliders: **2120**
- Collider position range: X -159.8..147.0  (span 306.8),  Y -22.8..103.2  (span 126.0)
- Physics layers: Stage x2078, Ceiling x36, Wall x6
- Shapes: polygon x1076, 4 x1044
- Collider kinds: MergedStatic_L x1044, Slope_up_L x311, Slope_ceiling_R x296, Slope_up_R x213, Slope_ceiling_L x189, Stairs_L x64, Stairs_R x3

### MuseumStage_Standard_MapData.txt
- World size: 512   static 2D colliders: **2023**
- Collider position range: X -159.8..146.5  (span 306.2),  Y -22.8..130.5  (span 153.2)
- Physics layers: Stage x1974, Ceiling x30, Wall x19
- Shapes: polygon x1024, 4 x999
- Collider kinds: MergedStatic_L x999, Slope_ceiling_R x266, Slope_up_L x256, Slope_up_R x234, Slope_ceiling_L x189, Stairs_L x76, Stairs_R x3

## Camera data files: Museum Camera Manager Data Asset.txt

## Asset folders (file counts incl. .meta)
Materials: 246, Models: 1540, Scenes: 6, Textures: 210
