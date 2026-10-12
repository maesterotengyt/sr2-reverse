// Namespace: 
public class StellarInputSystem : StellarMonoBehaviour // TypeDefIndex: 3385
{
	// Fields
	public static StellarInputSystem.OnInputDeviceActivated InputDeviceActivated; // 0x0
	public static StellarInputSystem.OnInputDeviceDisconnected InputDeviceDisconnected; // 0x8
	public static StellarInputSystem.OnInputDeviceReconnected InputDeviceReconnected; // 0x10
	public List<StellarInputDevice> InputDevices; // 0x20
	[CompilerGenerated]
	private List<PlayerInputData> <PlayersInputData>k__BackingField; // 0x28
	[CompilerGenerated]
	private InputContext <CurrentContext>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <CurrentLayer>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <CurrentInputModeID>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <LastInputDeviceWithInput>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <LastActiveInputDevice>k__BackingField; // 0x4C
	[CompilerGenerated]
	private List<InputProfile> <Profiles>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <InputBlocked>k__BackingField; // 0x58
	private int devicesActivated; // 0x5C
	private Coroutine currentSetInputModeRoutine; // 0x60
	private List<PlayerInputData> playersRemoved; // 0x68
	private bool transitioningToGameplayInputs; // 0x70
	private InputFlag previousInputFlag; // 0x74
	private List<InputMode> registeredInputModes; // 0x78

	// Properties
	public List<PlayerInputData> PlayersInputData { get; set; }
	public InputContext CurrentContext { get; set; }
	public string CurrentLayer { get; set; }
	public string CurrentInputModeID { get; set; }
	public int LastInputDeviceWithInput { get; set; }
	public int LastActiveInputDevice { get; set; }
	public List<InputProfile> Profiles { get; set; }
	public bool InputBlocked { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public List<PlayerInputData> get_PlayersInputData() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	public void set_PlayersInputData(List<PlayerInputData> value) { }

	[CompilerGenerated]
	// RVA: 0x5114B0 Offset: 0x50FAB0 VA: 0x1805114B0
	public InputContext get_CurrentContext() { }

	[CompilerGenerated]
	// RVA: 0x5C5B70 Offset: 0x5C4170 VA: 0x1805C5B70
	public void set_CurrentContext(InputContext value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public string get_CurrentLayer() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	public void set_CurrentLayer(string value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	public string get_CurrentInputModeID() { }

	[CompilerGenerated]
	// RVA: 0x5C5B80 Offset: 0x5C4180 VA: 0x1805C5B80
	private void set_CurrentInputModeID(string value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B60 Offset: 0x5C4160 VA: 0x1805C5B60
	public int get_LastInputDeviceWithInput() { }

	[CompilerGenerated]
	// RVA: 0x5C5BB0 Offset: 0x5C41B0 VA: 0x1805C5BB0
	public void set_LastInputDeviceWithInput(int value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B50 Offset: 0x5C4150 VA: 0x1805C5B50
	public int get_LastActiveInputDevice() { }

	[CompilerGenerated]
	// RVA: 0x5C5BA0 Offset: 0x5C41A0 VA: 0x1805C5BA0
	public void set_LastActiveInputDevice(int value) { }

	[CompilerGenerated]
	// RVA: 0x5B38B0 Offset: 0x5B1EB0 VA: 0x1805B38B0
	public List<InputProfile> get_Profiles() { }

	[CompilerGenerated]
	// RVA: 0x5B38C0 Offset: 0x5B1EC0 VA: 0x1805B38C0
	public void set_Profiles(List<InputProfile> value) { }

	[CompilerGenerated]
	// RVA: 0x5818C0 Offset: 0x57FEC0 VA: 0x1805818C0
	public bool get_InputBlocked() { }

	[CompilerGenerated]
	// RVA: 0x581900 Offset: 0x57FF00 VA: 0x180581900
	private void set_InputBlocked(bool value) { }

	// RVA: 0x5C46B0 Offset: 0x5C2CB0 VA: 0x1805C46B0
	public void Initialize() { }

	// RVA: 0x5C5840 Offset: 0x5C3E40 VA: 0x1805C5840
	private void Update() { }

	// RVA: 0x5C1750 Offset: 0x5BFD50 VA: 0x1805C1750
	public void OnLoadingScene() { }

	// RVA: 0x5C12C0 Offset: 0x5BF8C0 VA: 0x1805C12C0
	public void BlockInput() { }

	// RVA: 0x5C5830 Offset: 0x5C3E30 VA: 0x1805C5830
	public void UnblockInput() { }

	// RVA: 0x5C0BD0 Offset: 0x5BF1D0 VA: 0x1805C0BD0
	public void AddPlayerInputData(int playerIndex, int inputDeviceIndex, int profileIndex) { }

	// RVA: 0x5C5230 Offset: 0x5C3830 VA: 0x1805C5230
	public void RemovePlayerInputData(int playerIndex) { }

	// RVA: 0x5C17D0 Offset: 0x5BFDD0 VA: 0x1805C17D0
	public void CleanPlayersInputData() { }

	// RVA: 0x5C4C20 Offset: 0x5C3220 VA: 0x1805C4C20
	public void OrderPlayersInputDataByIndex() { }

	// RVA: 0x5C5740 Offset: 0x5C3D40 VA: 0x1805C5740
	public void SetPlayerIndex(int playerPosition, int playerIndex) { }

	// RVA: 0x5C5430 Offset: 0x5C3A30 VA: 0x1805C5430
	public void SetInputMode(string inputModeID, InputContext context, string layerID = "", float delay = 0) { }

	[IteratorStateMachine(typeof(StellarInputSystem.<SetInputModeDelay>d__56))]
	// RVA: 0x5C5380 Offset: 0x5C3980 VA: 0x1805C5380
	private IEnumerator SetInputModeDelay(string inputModeID, InputContext context, string layerID, float delay) { }

	// RVA: 0x5C1A90 Offset: 0x5C0090 VA: 0x1805C1A90
	public void DisableInputMode(string inputModeID) { }

	// RVA: 0x5C1750 Offset: 0x5BFD50 VA: 0x1805C1750
	public void CleanInputModes() { }

	// RVA: 0x5C0480 Offset: 0x5BEA80 VA: 0x1805C0480
	public int AddInputDevice(StellarInputDevice inputDevice, bool activate = False) { }

	// RVA: 0x5C5020 Offset: 0x5C3620 VA: 0x1805C5020
	public void RemoveInputDevice(StellarInputDevice inputDevice) { }

	// RVA: 0x5C57C0 Offset: 0x5C3DC0 VA: 0x1805C57C0
	public bool ShouldReconnectController(StellarInputDevice inputDevice) { }

	// RVA: 0x5C4FF0 Offset: 0x5C35F0 VA: 0x1805C4FF0
	public void RemoveInputDevice(int inputDeviceIndex) { }

	// RVA: 0x5C4F40 Offset: 0x5C3540 VA: 0x1805C4F40
	public void RemoveAllDevices() { }

	// RVA: 0x5C19B0 Offset: 0x5BFFB0 VA: 0x1805C19B0
	public void DeactivateInputDevice(int inputDeviceIndex) { }

	// RVA: 0x5C19E0 Offset: 0x5BFFE0 VA: 0x1805C19E0
	public void DeactivateInputDevice(StellarInputDevice inputDevice) { }

	// RVA: 0x5C1880 Offset: 0x5BFE80 VA: 0x1805C1880
	public void DeactivateAllInputDevices() { }

	// RVA: 0x5C1DD0 Offset: 0x5C03D0 VA: 0x1805C1DD0
	private int GenerateDeviceIndex() { }

	// RVA: 0x5C32C0 Offset: 0x5C18C0 VA: 0x1805C32C0
	public StellarInputDevice GetInputDevice(int deviceIndex) { }

	// RVA: 0x5C3770 Offset: 0x5C1D70 VA: 0x1805C3770
	public StellarInputDevice GetPlayerInputDevice(int playerIndex) { }

	// RVA: 0x5C4570 Offset: 0x5C2B70 VA: 0x1805C4570
	public bool HasDeviceActiveUser(int inputDeviceIndex) { }

	// RVA: 0x5C3410 Offset: 0x5C1A10 VA: 0x1805C3410
	public InputDeviceType GetMainInputDeviceType() { }

	// RVA: 0x5C21C0 Offset: 0x5C07C0 VA: 0x1805C21C0
	public List<StellarInputDevice> GetActiveInputDevices() { }

	// RVA: 0x5C3620 Offset: 0x5C1C20 VA: 0x1805C3620
	public int GetPlayerInputDeviceIndex(int playerIndex) { }

	// RVA: 0x5C38D0 Offset: 0x5C1ED0 VA: 0x1805C38D0
	public int GetPlayerProfile(int playerIndex) { }

	// RVA: 0x5C34D0 Offset: 0x5C1AD0 VA: 0x1805C34D0
	public int GetPlayerIndex(int inputDeviceIndex) { }

	// RVA: 0x5C1310 Offset: 0x5BF910 VA: 0x1805C1310
	public bool CheckNewDeviceToActivate() { }

	// RVA: 0x5C4D40 Offset: 0x5C3340 VA: 0x1805C4D40
	public void PollGameplayInputs(CallbackPollInput poll) { }

	// RVA: 0x5C3FC0 Offset: 0x5C25C0 VA: 0x1805C3FC0
	public bool GetUIInputDown(UIKey key, string layer = "", bool ignoreContext = False) { }

	// RVA: 0x5C3F20 Offset: 0x5C2520 VA: 0x1805C3F20
	public bool GetUIInputDown(int deviceIndex, UIKey key, string layer = "", bool ignoreContext = False) { }

	// RVA: 0x5C4300 Offset: 0x5C2900 VA: 0x1805C4300
	public bool GetUIInputUp(UIKey key, string layer = "", bool ignoreContext = False) { }

	// RVA: 0x5C44D0 Offset: 0x5C2AD0 VA: 0x1805C44D0
	public bool GetUIInputUp(int deviceIndex, UIKey key, string layer = "", bool ignoreContext = False) { }

	// RVA: 0x5C4190 Offset: 0x5C2790 VA: 0x1805C4190
	public bool GetUIInputHold(UIKey key, string layer = "", bool ignoreContext = False) { }

	// RVA: 0x5C4260 Offset: 0x5C2860 VA: 0x1805C4260
	public bool GetUIInputHold(int deviceIndex, UIKey key, string layer = "", bool ignoreContext = False) { }

	// RVA: 0x5C0E40 Offset: 0x5BF440 VA: 0x1805C0E40
	public bool AnyInput() { }

	// RVA: 0x5C2570 Offset: 0x5C0B70 VA: 0x1805C2570
	public ControllerKey GetCurrentPressedControllerKey(int inputDeviceIndex) { }

	// RVA: 0x5C2350 Offset: 0x5C0950 VA: 0x1805C2350
	public ControllerKey GetControllerKey(int inputDeviceIndex, UIKey key) { }

	// RVA: 0x5C2680 Offset: 0x5C0C80 VA: 0x1805C2680
	public Key GetCurrentPressedKeyboardKey(int inputDeviceIndex) { }

	// RVA: 0x5C1720 Offset: 0x5BFD20 VA: 0x1805C1720
	public void CleanInputDevice(int deviceIndex) { }

	// RVA: 0x5C1610 Offset: 0x5BFC10 VA: 0x1805C1610
	public void CleanAllInputDevices() { }

	// RVA: 0x5C49B0 Offset: 0x5C2FB0 VA: 0x1805C49B0
	private bool InputValidation(StellarInputDevice inputDevice, InputContext context, string layer = "") { }

	// RVA: 0x5C4A20 Offset: 0x5C3020 VA: 0x1805C4A20
	public bool IsMouseLeftClickPressed() { }

	// RVA: 0x5C4A10 Offset: 0x5C3010 VA: 0x1805C4A10
	public bool IsMouseLeftClickHold() { }

	// RVA: 0x5C4A30 Offset: 0x5C3030 VA: 0x1805C4A30
	public bool IsMouseRightClickPressed() { }

	// RVA: 0x5C2E50 Offset: 0x5C1450 VA: 0x1805C2E50
	public Vector3 GetDirectionMovementLocal(int deviceIndex, bool useYAxis = False) { }

	// RVA: 0x5C3A20 Offset: 0x5C2020 VA: 0x1805C3A20
	public Vector3 GetSecondDirectionMovementLocal(int deviceIndex, bool useZAxis = False) { }

	// RVA: 0x5C2850 Offset: 0x5C0E50 VA: 0x1805C2850
	public InputProfile GetDefaultProfile(InputDeviceType inputDeviceType) { }

	// RVA: 0x5C2790 Offset: 0x5C0D90 VA: 0x1805C2790
	public PlayerSettings GetDefaultPlayerSettings() { }

	// RVA: 0x5C0F00 Offset: 0x5BF500 VA: 0x1805C0F00
	public void AssignInputProfile(int profileIndex, int playerIndex) { }

	// RVA: 0x5C1FF0 Offset: 0x5C05F0 VA: 0x1805C1FF0
	public int GeneratePlayerIndex() { }

	// RVA: 0x5C4A40 Offset: 0x5C3040 VA: 0x1805C4A40
	public bool IsPlayerUsingKeyboard(int playerIndex = -1) { }

	// RVA: 0x5C12D0 Offset: 0x5BF8D0 VA: 0x1805C12D0
	private bool CanTransitionToQuantumInput(Input inputReference) { }

	// RVA: 0x5C4B00 Offset: 0x5C3100 VA: 0x1805C4B00
	private void OnDestroy() { }

	// RVA: 0x5C59B0 Offset: 0x5C3FB0 VA: 0x1805C59B0
	public void .ctor() { }
}
