# Stage: Metro

- StageID: `Metro`
- Type: 1  (StageType enum)
- Music: StageMusic   Locked by default: 0
- Layouts: A, B (2)
- BlacklistedFromRandom flags: []

## Scenes (3)

### MetroStage.unity  (2 GameObjects, 7 KB)
**Scripts/components in scene:** TestRunner x1, ShapesCollisionVisualizer x1, StageLayoutLoader x1, ShapesDebugger x1

**Most common object names:** StageLoader x1, TestRunner x1

### MetroStage_Metro B.unity  (19941 GameObjects, 51482 KB)
**Scripts/components in scene:** StellarTileInstance x9165, QuantumStaticBoxCollider2D x8571, QuantumStaticPolygonCollider2D x594, EntityPrototype x199, EntityView x179, EntityComponentStatic x175, TriggerVisualizer x153, EntityComponentVisibilityTarget x152, EntityComponentTrigger x152, EntityComponentTriggerPolygonShape x94, ?3160adc3 x81, GameEntityManager x69, EntityComponentGameEntity x69, EntityComponentAIVolume x68, GameEntityObjectsManager x58, GameEntityRenderManager x58, EntityComponentTriggerSphereShape x58, CollectorsTreasureSpawnAreaVisualizer x21, EntityComponentCollectorsTreasureSpawnArea x21, EntityComponentCheckpoint x14, CheckpointDirectionVisualizer x14, EntityComponentItemBox x14, EntityComponentRespawnPoint x11, BadgePlatformIcon x8, EntityComponentStageSFX x6, EntityComponentTrapDoor x6, EntityComponentSuperBoostVolume x6, ?67dfb1fd x4, EntityComponentTrapDoorSwitch x4, IntroBanner x4, TrapDoorSwitchManager x4, StageHazardSpawnAreaVisualizer x4, EntityComponentStageHazardSpawnArea x4, ?d3e719b5 x2, PlatformOverrides x1, EntityComponentCheckpointManager x1, EntityComponentHazardsRaceGameModeManager x1, ?57c9a3e5 x1, MapData x1, StellarTileMap x1

**Most common object names:** Wall x7751, wall x7750, ceiling x596, Ceiling x596, walljump_L x146, WallJump_L x146, slope_up_L x143, Slope_up_L x143, slope_ceiling_L x126, Slope_ceiling_L x126, slope_ceiling_R x122, Slope_ceiling_R x122, slope_up_R x111, Slope_up_R x111, Item x78, Hurt x78, WallJump_R x78, walljump_R x78, Visuals x69, RotationPivot x69, RotationOffset x69, MainTransform x69, Stairs_L x49, stairs_L x49, stairs_R x43, Stairs_R x43, RedGlow x39, SR_ENV_Metro_GP_CubeOutline x39, SR_ENV_Metro_GP_CubeOutlineDefased x39, ObstacleVisualsManager x39

### MetroStage_Standard.unity  (18368 GameObjects, 47437 KB)
**Scripts/components in scene:** StellarTileInstance x8260, QuantumStaticBoxCollider2D x7953, QuantumStaticPolygonCollider2D x307, EntityPrototype x236, EntityView x223, EntityComponentStatic x216, EntityComponentVisibilityTarget x202, EntityComponentTrigger x202, TriggerVisualizer x202, EntityComponentTriggerPolygonShape x128, EntityComponentAIVolume x107, ?3160adc3 x90, GameEntityManager x81, EntityComponentGameEntity x81, GameEntityObjectsManager x76, GameEntityRenderManager x76, EntityComponentTriggerSphereShape x74, CollectorsTreasureSpawnAreaVisualizer x16, EntityComponentCollectorsTreasureSpawnArea x16, EntityComponentItemBox x15, EntityComponentCheckpoint x14, CheckpointDirectionVisualizer x14, BadgePlatformIcon x8, EntityComponentRespawnPoint x8, ?67dfb1fd x4, IntroBanner x4, StageHazardSpawnAreaVisualizer x4, EntityComponentStageHazardSpawnArea x4, EntityComponentTrapDoorSwitch x3, TrapDoorSwitchManager x3, EntityComponentStageSFX x2, ?d3e719b5 x2, EntityComponentTrapDoor x2, EntityComponentSuperBoostVolume x2, PlatformOverrides x1, EntityComponentCheckpointManager x1, StellarTileMap x1, HideOnStart x1, EntityComponentHazardsRaceGameModeManager x1, ?57c9a3e5 x1

**Most common object names:** Wall x7376, wall x7375, ceiling x297, Ceiling x297, walljump_L x156, WallJump_L x156, WallJump_R x124, walljump_R x124, Item x112, Hurt x112, slope_ceiling_R x97, Slope_ceiling_R x97, Visuals x81, RotationPivot x81, RotationOffset x81, MainTransform x81, RedGlow x56, SR_ENV_Metro_GP_CubeOutline x56, SR_ENV_Metro_GP_CubeOutlineDefased x56, ObstacleVisualsManager x56, InactiveVisuals x56, Stairs_L x56, stairs_L x56, ActiveVisuals x56, slope_up_L x55, Slope_up_L x55, slope_ceiling_L x45, Slope_ceiling_L x45, stairs_R x43, Stairs_R x43

## Quantum map data (static collision)

### MetroStage_Metro B_MapData.txt
- World size: 512   static 2D colliders: **1199**
- Collider position range: X -163.0..313.8  (span 476.8),  Y -54.8..64.0  (span 118.8)
- Physics layers: Stage x1167, Ceiling x24, Wall x8
- Shapes: 4 x605, polygon x594
- Collider kinds: MergedStatic_L x604, Slope_up_L x143, Slope_ceiling_L x126, Slope_ceiling_R x122, Slope_up_R x111, Stairs_L x49, Stairs_R x43, Wall x1

### MetroStage_Standard_MapData.txt
- World size: 512   static 2D colliders: **720**
- Collider position range: X -164.0..313.8  (span 477.8),  Y -54.8..64.2  (span 119.0)
- Physics layers: Stage x704, Wall x8, Ceiling x8
- Shapes: 4 x413, polygon x307
- Collider kinds: MergedStatic_L x412, Slope_ceiling_R x97, Stairs_L x56, Slope_up_L x55, Slope_ceiling_L x45, Stairs_R x43, Slope_up_R x11, Wall x1

## Camera data files: GreyBoxFirstLevel_Camera Manager Data Asset.txt, Metro Camera Manager Data Asset.txt

## Asset folders (file counts incl. .meta)
Animations: 14, Materials: 228, Models: 1146, Prefabs: 6, Scenes: 8, Textures: 100
