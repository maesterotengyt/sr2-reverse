// Namespace: 
public class StellarPCInputSystem : StellarMonoBehaviour // TypeDefIndex: 3441
{
	// Fields
	private StellarPCSystem pcSystem; // 0x20
	private bool controllerConnectedAtStart; // 0x28
	private int previousLastInputDeviceWithInput; // 0x2C
	private int pendingInputDeviceToActivate; // 0x30
	private int pendingInputDeviceToDeactivate; // 0x34
	private bool initialized; // 0x38

	// Methods

	// RVA: 0x5F0630 Offset: 0x5EEC30 VA: 0x1805F0630
	public void Init(StellarPCSystem pcSystem) { }

	// RVA: 0x5F02C0 Offset: 0x5EE8C0 VA: 0x1805F02C0
	public void CreatePCGamepads() { }

	// RVA: 0x5F0030 Offset: 0x5EE630 VA: 0x1805F0030
	public void CreatePCGamepad(Gamepad gamepad, bool startActive) { }

	// RVA: 0x5EFF50 Offset: 0x5EE550 VA: 0x1805EFF50
	public void CreateKeyboard(bool startActive) { }

	// RVA: 0x5EFCC0 Offset: 0x5EE2C0 VA: 0x1805EFCC0
	public void CreateDebugKeyboard(bool startActive, int keyboardSet) { }

	// RVA: 0x5EFDC0 Offset: 0x5EE3C0 VA: 0x1805EFDC0
	public void CreateGamecubeControllers() { }

	// RVA: 0x5F0480 Offset: 0x5EEA80 VA: 0x1805F0480
	private StellarPCGamePad GetPCGamePad(Gamepad gamepad) { }

	// RVA: 0x5EFC20 Offset: 0x5EE220 VA: 0x1805EFC20
	public void ActivateGamecubeController(int inputDeviceIndex) { }

	// RVA: 0x5061F0 Offset: 0x5047F0 VA: 0x1805061F0
	public void DeactivateGamecubeController(int inputDeviceIndex) { }

	// RVA: 0x5F0D00 Offset: 0x5EF300 VA: 0x1805F0D00
	private void Update() { }

	// RVA: 0x5F0E10 Offset: 0x5EF410 VA: 0x1805F0E10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5F0AC0 Offset: 0x5EF0C0 VA: 0x1805F0AC0
	private void <CreatePCGamepads>b__7_0(InputDevice device, InputDeviceChange change) { }
}
