# Stage: Casino

- StageID: `Casino`
- Type: 1  (StageType enum)
- Music: StageMusic   Locked by default: 0
- Layouts: A, B (2)
- BlacklistedFromRandom flags: []

## Scenes (3)

### CasinoStage.unity  (2 GameObjects, 6 KB)
**Scripts/components in scene:** TestRunner x1, ShapesCollisionVisualizer x1, StageLayoutLoader x1, ShapesDebugger x1

**Most common object names:** StageLoader x1, TestRunner x1

### CasinoStage_CasinoB.unity  (25615 GameObjects, 71725 KB)
**Scripts/components in scene:** StellarTileInstance x11847, QuantumStaticBoxCollider2D x11065, QuantumStaticPolygonCollider2D x782, EntityPrototype x243, EntityView x217, EntityComponentStatic x210, TriggerVisualizer x195, EntityComponentVisibilityTarget x194, EntityComponentTrigger x194, EntityComponentTriggerPolygonShape x127, EntityComponentAIVolume x97, ?3160adc3 x93, GameEntityManager x78, EntityComponentGameEntity x78, EntityComponentTriggerSphereShape x67, GameEntityObjectsManager x66, GameEntityRenderManager x66, EntityComponentItemBox x24, CollectorsTreasureSpawnAreaVisualizer x22, EntityComponentCollectorsTreasureSpawnArea x22, EntityComponentCheckpoint x16, CheckpointDirectionVisualizer x16, EntityComponentRespawnPoint x14, EntityComponentStageSFX x9, EntityComponentSuperBoostVolume x9, BadgePlatformIcon x8, VFXObject x6, EntityComponentTrapDoor x6, EntityComponentTrapDoorSwitch x5, TrapDoorSwitchManager x5, ?67dfb1fd x4, IntroBanner x4, ?2183220b x3, StageHazardSpawnAreaVisualizer x3, EntityComponentStageHazardSpawnArea x3, ?57c9a3e5 x2, ScaleShaker x2, ?d3e719b5 x2, PlatformOverrides x1, EntityComponentCheckpointManager x1

**Most common object names:** wall x10138, Wall x10138, ceiling x535, Ceiling x535, walljump_L x262, WallJump_L x262, slope_ceiling_L x240, Slope_ceiling_L x240, slope_up_R x197, Slope_up_R x197, slope_up_L x164, Slope_up_L x164, slope_ceiling_R x147, Slope_ceiling_R x147, WallJump_R x130, walljump_R x130, SR_ENV_Geo_LightShadowPlanes_A x125, Visuals x78, RotationPivot x78, RotationOffset x78, MainTransform x78, Item x74, Hurt x74, ComicShape x48, SR_ENV_Metro_GP_CubeOutline x37, RedGlow x37, SR_ENV_Metro_GP_CubeOutlineDefased x37, ObstacleVisualsManager x37, InactiveVisuals x37, ActiveVisuals x37

### CasinoStage_Standard.unity  (25698 GameObjects, 65307 KB)
**Scripts/components in scene:** StellarTileInstance x11889, QuantumStaticBoxCollider2D x11231, QuantumStaticPolygonCollider2D x658, EntityPrototype x253, EntityView x227, EntityComponentStatic x225, EntityComponentVisibilityTarget x203, EntityComponentTrigger x203, TriggerVisualizer x203, EntityComponentTriggerPolygonShape x135, ?3160adc3 x102, EntityComponentAIVolume x96, GameEntityManager x87, EntityComponentGameEntity x87, GameEntityObjectsManager x76, GameEntityRenderManager x76, EntityComponentTriggerSphereShape x68, CollectorsTreasureSpawnAreaVisualizer x21, EntityComponentCollectorsTreasureSpawnArea x21, EntityComponentCheckpoint x18, CheckpointDirectionVisualizer x18, EntityComponentItemBox x17, EntityComponentRespawnPoint x14, EntityComponentStageSFX x9, EntityComponentSuperBoostVolume x9, BadgePlatformIcon x8, EntityComponentTrapDoor x7, ?67dfb1fd x4, EntityComponentTrapDoorSwitch x4, IntroBanner x4, TrapDoorSwitchManager x4, StageHazardSpawnAreaVisualizer x3, EntityComponentStageHazardSpawnArea x3, ?2183220b x2, ?d3e719b5 x2, EntityComponentHazardsRaceGameModeManager x1, EntityComponentCheckpointManager x1, StellarTileMap x1, HideOnStart x1, ?57c9a3e5 x1

**Most common object names:** wall x10438, Wall x10438, ceiling x431, Ceiling x431, walljump_L x241, WallJump_L x241, slope_ceiling_L x200, Slope_ceiling_L x200, slope_up_R x177, Slope_up_R x177, SR_ENV_Geo_LightShadowPlanes_B x128, slope_ceiling_R x124, Slope_ceiling_R x124, WallJump_R x121, walljump_R x121, slope_up_L x115, Slope_up_L x115, Item x94, Hurt x94, Visuals x87, RotationPivot x87, RotationOffset x87, MainTransform x87, RedGlow x47, SR_ENV_Metro_GP_CubeOutline x47, SR_ENV_Metro_GP_CubeOutlineDefased x47, ObstacleVisualsManager x47, InactiveVisuals x47, ActiveVisuals x47, ComicShape x34

## Quantum map data (static collision)

### CasinoStage_CasinoB_MapData.txt
- World size: 512   static 2D colliders: **3642**
- Collider position range: X -149.5..199.0  (span 348.5),  Y -9.2..111.0  (span 120.2)
- Physics layers: Stage x3196, Wall x364, Ceiling x82
- Shapes: 4 x2860, polygon x782
- Collider kinds: Wall x1854, MergedStatic_L x584, WallJump_L x262, Slope_ceiling_L x240, Slope_up_R x197, Slope_up_L x164, Slope_ceiling_R x147, WallJump_R x101, Ceiling x59, Stairs_L x18, Stairs_R x16

### CasinoStage_Standard_MapData.txt
- World size: 512   static 2D colliders: **2192**
- Collider position range: X -150.0..199.2  (span 349.2),  Y -8.8..111.5  (span 120.2)
- Physics layers: Stage x2032, Wall x134, Ceiling x26
- Shapes: 4 x1534, polygon x658
- Collider kinds: Wall x705, MergedStatic_L x705, Slope_ceiling_L x200, Slope_up_R x177, Slope_ceiling_R x124, Slope_up_L x115, WallJump_L x109, Stairs_L x26, Stairs_R x16, WallJump_R x15

## Camera data files: Casino Camera Manager Data Asset.txt, GreyBoxFirstLevel_Camera Manager Data Asset.txt

## Asset folders (file counts incl. .meta)
Animations: 4, Materials: 228, Models: 532, Scenes: 6, Textures: 200
