// Namespace: Quantum
[AssetObjectConfig(GenerateLinkingScripts = True, GenerateAssetCreateMenu = False, GenerateAssetResetMethod = False, GenerateAsMainScript = False)]
[Serializable]
public class SimulationConfig : AssetObject // TypeDefIndex: 10245
{
	// Fields
	public const long DEFAULT_ID = 5;
	[Space(8)]
	public Navigation.Config Navigation; // 0x20
	[Space(8)]
	public PhysicsCommon.Config Physics; // 0x28
	[Space(8)]
	public FrameBase.EntitiesConfig Entities; // 0x30
	[Tooltip("This option will trigger a Unity scene load during the Quantum start sequence.
This might be convenient to start with but once the starting sequence is customized disable it and implement the scene loading by yourself.
"Previous Scene" refers to a scene name in Quantum Map.")]
	public SimulationConfig.AutoLoadSceneFromMapMode AutoLoadSceneFromMap; // 0x38
	[Tooltip("Configure how the client tracks the time to progress the Quantum simulation from the QuantumRunner class.")]
	public SimulationUpdateTime DeltaTimeType; // 0x3C
	[Tooltip("Override the number of threads used internally.
Default is 2.")]
	public int ThreadCount; // 0x40
	[Tooltip("How long to store checksumed verified frames.
The are used to generate a frame dump in case of a checksum error happening. Not used in Replay and Local mode.
Default is 3.")]
	public FP ChecksumSnapshotHistoryLengthSeconds; // 0x48
	[EnumFlags]
	[Tooltip("Additional options for checksum dumps, if the default settings don't provide a clear picture. ")]
	public SimulationConfigChecksumErrorDumpOptions ChecksumErrorDumpOptions; // 0x50
	[Header("Frame Heap Settings")]
	[Tooltip("If and to which extent allocations in the Frame Heap should be tracked when in Debug mode.
Recommended modes for development is `DetectLeaks`.
While actively debugging a memory leak,`TraceAllocations` mode can be enabled (warning: tracing is very slow).")]
	public HeapTrackingMode HeapTrackingMode; // 0x54
	[Tooltip("Define the max heap size for one page of memory the frame class uses for custom allocations like QList<> for example.

2^15 = 32.768 bytes
TotalHeapSizeInBytes = (1 << HeapPageShift) * HeapPageCount

Default is 15.")]
	public int HeapPageShift; // 0x58
	[Tooltip("Define the max heap page count for memory the frame class uses for custom allocations like QList<> for example.

TotalHeapSizeInBytes = (1 << HeapPageShift) * HeapPageCount

Default is 256.")]
	public int HeapPageCount; // 0x5C
	[Tooltip("Sets extra heaps to allocate for a session in case you need to create 'auxiliary' frames than actually required for the simulation itself.
Default is 0.")]
	public int HeapExtraCount; // 0x60
	public AssetRefSpeedRunnersSettingsData SpeedRunnerSettings; // 0x68
	public PickupItemUsageDataFile[] PickupItemUsageDatas; // 0x70
	public AssetRefNPCSettingsData NPCSettingsData; // 0x78
	[Space(10)]
	public CharacterDataFile[] CharacterDatas; // 0x80
	public GameModeFile[] GameModes; // 0x88
	[Header("Physics")]
	public CollisionLayer[] GroundLayers; // 0x90
	public CollisionLayer[] ThinPlatformLayers; // 0x98
	public CollisionLayer[] DefaultCollisionLayer; // 0xA0
	public CollisionLayer[] DynamicObjectLayers; // 0xA8
	public PhysicsDataSurfaceType[] SurfaceTypes; // 0xB0
	[Header("Combat")]
	public bool ComputeRedirectsAndReflects; // 0xB8
	public bool ComputeHitBoxAgainstHitBox; // 0xB9
	[Header("Config Files")]
	public AssetRefGameplayInputSettingsData GameplayInputSettingsData; // 0xC0
	public AssetRefCombatSettingsData CombatSettingsData; // 0xC8
	public AssetRefPlayerSettings DefaultNPCPlayerSettings; // 0xD0
	public AssetRefGameSpeedModifiersData GameSpeedModifiersData; // 0xD8
	public AssetRefStatusEffectsData StatusEffectsData; // 0xE0

	// Methods

	// RVA: 0x215A990 Offset: 0x2158F90 VA: 0x18215A990
	public SpeedRunnersSettingsData GetSpeedRunnersSettingsData(Frame frame) { }

	// RVA: 0x215A850 Offset: 0x2158E50 VA: 0x18215A850
	public NPCSettingsData GetNPCSettingsData(Frame frame) { }

	// RVA: 0x215A880 Offset: 0x2158E80 VA: 0x18215A880
	public PickupItemUsageData GetPickupItemUsageData(Frame frame, int identifier) { }

	// RVA: 0x215A600 Offset: 0x2158C00 VA: 0x18215A600
	public GameEntityData GetCharacterGameEntityData(Frame frame, HashString characterID) { }

	// RVA: 0x215AAA0 Offset: 0x21590A0 VA: 0x18215AAA0
	public bool TryGetGameMode(Frame frame, out BaseGameMode gameMode) { }

	// RVA: 0x215A820 Offset: 0x2158E20 VA: 0x18215A820
	public GameplayInputSettingsData GetGameplayInputSettingsData(Frame frame) { }

	// RVA: 0x215A790 Offset: 0x2158D90 VA: 0x18215A790
	public CombatSettingsData GetCombatSettingsData(Frame frame) { }

	// RVA: 0x215A9F0 Offset: 0x2158FF0 VA: 0x18215A9F0
	public SurfaceType GetSurfaceType(AssetRefPhysicsMaterial physicsMaterial) { }

	// RVA: 0x215A7C0 Offset: 0x2158DC0 VA: 0x18215A7C0
	public PlayerSettings GetDefaultNPCPlayerSettings(Frame frame) { }

	// RVA: 0x215A7F0 Offset: 0x2158DF0 VA: 0x18215A7F0
	public GameSpeedModifiersData GetGameSpeedModifiersData(Frame frame) { }

	// RVA: 0x215A9C0 Offset: 0x2158FC0 VA: 0x18215A9C0
	public StatusEffectsData GetStatusEffectsData(Frame frame) { }

	// RVA: 0x215AC50 Offset: 0x2159250 VA: 0x18215AC50
	public void .ctor() { }
}
