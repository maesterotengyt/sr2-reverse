// Namespace: 
public class CheatsManager : MonoBehaviour // TypeDefIndex: 2542
{
	// Fields
	public float CameraMoveSpeed; // 0x20
	public float CameraRotationSpeed; // 0x24
	public GameObject PlayerStatsMenu; // 0x28
	public GameObject Menu; // 0x30
	public Toggle BlastzoneActiveStateToggle; // 0x38
	public Toggle GameUIActiveStateToggle; // 0x40
	public Toggle KeepGameFreezeToggle; // 0x48
	public Toggle FlyModeToggle; // 0x50
	public Toggle ShowPlayerStatsToggle; // 0x58
	public TMP_Dropdown TargetCharacterDropdown; // 0x60
	public TMP_Dropdown ItemToEquipDropdown; // 0x68
	public TMP_Dropdown CameraModeDropdown; // 0x70
	public TMP_Dropdown CameraZoomDropdown; // 0x78
	public GameObject StillCameraSettingsContainer; // 0x80
	public TMP_InputField CameraManualZoomField; // 0x88
	public Toggle FreezeCameraToggle; // 0x90
	public Toggle MuteAllSFXToggle; // 0x98
	public Toggle MuteMusicToggle; // 0xA0
	public Toggle MuteAmbientSFXToggle; // 0xA8
	public Toggle MuteGeneralSFXToggle; // 0xB0
	private GameSpeedModifier freezeGameSpeedModifier; // 0xB8
	private DispatcherSubscription debugAlertSubscription; // 0xD8
	private bool isSimulationActive; // 0xE0
	private int targetCharacterIndex; // 0xE4
	private HashString itemToEquip; // 0xE8

	// Properties
	private UIManager uiManager { get; }
	private SaveManager saveManager { get; }
	private StellarSimulationSystem stellarSimulationSystem { get; }
	private StellarInputSystem stellarInputSystem { get; }
	private StellarCameraSystem stellarCameraSystem { get; }
	private StellarAudioSystem audioSystem { get; }

	// Methods

	// RVA: 0x62BC40 Offset: 0x62A240 VA: 0x18062BC40
	private UIManager get_uiManager() { }

	// RVA: 0x62BB00 Offset: 0x62A100 VA: 0x18062BB00
	private SaveManager get_saveManager() { }

	// RVA: 0x62BBF0 Offset: 0x62A1F0 VA: 0x18062BBF0
	private StellarSimulationSystem get_stellarSimulationSystem() { }

	// RVA: 0x62BBA0 Offset: 0x62A1A0 VA: 0x18062BBA0
	private StellarInputSystem get_stellarInputSystem() { }

	// RVA: 0x62BB50 Offset: 0x62A150 VA: 0x18062BB50
	private StellarCameraSystem get_stellarCameraSystem() { }

	// RVA: 0x62BAB0 Offset: 0x62A0B0 VA: 0x18062BAB0
	private StellarAudioSystem get_audioSystem() { }

	// RVA: 0x6298F0 Offset: 0x627EF0 VA: 0x1806298F0
	private void Awake() { }

	// RVA: 0x62AE70 Offset: 0x629470 VA: 0x18062AE70
	private void Update() { }

	// RVA: 0x62A8E0 Offset: 0x628EE0 VA: 0x18062A8E0
	public void SimulationStarted() { }

	// RVA: 0x62A850 Offset: 0x628E50 VA: 0x18062A850
	public void SimulationEnded() { }

	// RVA: 0x62A820 Offset: 0x628E20 VA: 0x18062A820
	public void OnTargetCharacterChanged() { }

	// RVA: 0x62A200 Offset: 0x628800 VA: 0x18062A200
	public void OnItemToEquipChanged() { }

	// RVA: 0x629A20 Offset: 0x628020 VA: 0x180629A20
	public void EquipItem() { }

	// RVA: 0x629950 Offset: 0x627F50 VA: 0x180629950
	public void ClearBoost() { }

	// RVA: 0x629B00 Offset: 0x628100 VA: 0x180629B00
	public void FillBoost() { }

	// RVA: 0x62AA40 Offset: 0x629040 VA: 0x18062AA40
	private bool TryFindCharacterEntity(int characterIndex, out EntityRef targetEntity) { }

	// RVA: 0x62AC20 Offset: 0x629220 VA: 0x18062AC20
	public void UpdateBlastzoneActiveState() { }

	// RVA: 0x62A9B0 Offset: 0x628FB0 VA: 0x18062A9B0
	public void ToggleNPCs() { }

	// RVA: 0x62ADA0 Offset: 0x6293A0 VA: 0x18062ADA0
	public void UpdateGameUIActiveState() { }

	// RVA: 0x62ACE0 Offset: 0x6292E0 VA: 0x18062ACE0
	public void UpdateFlyModeState() { }

	// RVA: 0x62AE40 Offset: 0x629440 VA: 0x18062AE40
	public void UpdateShowPlayerStatsVisibility() { }

	// RVA: 0x629CB0 Offset: 0x6282B0 VA: 0x180629CB0
	public void OnCameraModeChanged() { }

	// RVA: 0x62A070 Offset: 0x628670 VA: 0x18062A070
	public void OnCameraZoomPresetChanged() { }

	// RVA: 0x629BD0 Offset: 0x6281D0 VA: 0x180629BD0
	public void OnCameraManualZoomChanged() { }

	// RVA: 0x62A180 Offset: 0x628780 VA: 0x18062A180
	public void OnFreezeCameraUpdate() { }

	// RVA: 0x62A320 Offset: 0x628920 VA: 0x18062A320
	public void OnMuteAllSFXToggle() { }

	// RVA: 0x62A6E0 Offset: 0x628CE0 VA: 0x18062A6E0
	public void OnMuteMusicToggle() { }

	// RVA: 0x62A460 Offset: 0x628A60 VA: 0x18062A460
	public void OnMuteAmbientSFXToggle() { }

	// RVA: 0x62A5A0 Offset: 0x628BA0 VA: 0x18062A5A0
	public void OnMuteGeneralSFXToggle() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void ShowAlertCallback(EventDebugAlert callback) { }

	// RVA: 0x62B9F0 Offset: 0x629FF0 VA: 0x18062B9F0
	public void .ctor() { }
}
