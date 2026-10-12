// Namespace: 
public class StellarData : ScriptableObject // TypeDefIndex: 3521
{
	// Fields
	public List<StellarPlatformSystemData> PlatformSystems; // 0x18
	[Header("Input")]
	public KeyboardMapping KeyboardMappingFile; // 0x20
	public List<KeyboardMapping> DebugKeyboardMappingFiles; // 0x28
	public List<ControllerMappingData> ControllerMappingFiles; // 0x30
	public DefaultPlayerSettings DefaultPlayerSettings; // 0x38
	public bool EnableKeyboardDebugMapping; // 0x40
	[Header("Online")]
	public string OnlineVersion; // 0x48
	public PhotonServerSettings PhotonServerSettings; // 0x50
	public int DefaultInputDelay; // 0x58
	public int SlowInputDelay; // 0x5C
	public int LobbyMaxPlayers; // 0x60
	public List<RegionData> Regions; // 0x68
	public bool DisablePlatformLobbies; // 0x70
	public float OnlineLoadingTimeout; // 0x74
	[Header("Simulation")]
	public StellarPlayer DefaultPlayerData; // 0x78
	public int LocalPlayerCount; // 0x80
	public AssetRefSimulationConfig SimulationConfig; // 0x88
	public AssetRefSimulationConfig TrainingSimulationConfig; // 0x90
	public DeterministicSessionConfigAsset DeterministicConfig; // 0x98
	public float SimulationLoadingTimeout; // 0xA0
	[Header("UI")]
	public CharactersDetails CharactersDetails; // 0xA8
	public StagesData StagesData; // 0xB0
	public ScreenScenesData ScreenScenesData; // 0xB8
	public KeyboardIcons KeyboardIcons; // 0xC0
	public List<ControllerIcons> ControllerIcons; // 0xC8
	public bool ForceEnglishLanguage; // 0xD0
	[Header("CustomLog")]
	public bool AutomaticCustomLogSave; // 0xD1
	public bool ShowCustomLogInConsole; // 0xD2
	public List<string> CustomLogConsoleCategories; // 0xD8
	[Header("Other")]
	public bool SavesEncrypted; // 0xE0
	public DLCData DLCData; // 0xE8
	public CameraShakePresets CameraShakePresets; // 0xF0
	public List<AssetReferenceGameObject> DefaultGameObjectsToLoad; // 0xF8

	// Methods

	// RVA: 0x5EB820 Offset: 0x5E9E20 VA: 0x1805EB820
	public StellarPlatformSystem GetPlatformSystem(GamePlatform platform) { }

	// RVA: 0x5EBB90 Offset: 0x5EA190 VA: 0x1805EBB90
	public bool IsCharacterValid(int characterID) { }

	// RVA: 0x5EBD20 Offset: 0x5EA320 VA: 0x1805EBD20
	public bool IsRegionValid(string regionID) { }

	// RVA: 0x5EB960 Offset: 0x5E9F60 VA: 0x1805EB960
	public RegionData GetRegionData(string photonCode) { }

	// RVA: 0x5EBE90 Offset: 0x5EA490 VA: 0x1805EBE90
	public void .ctor() { }
}
