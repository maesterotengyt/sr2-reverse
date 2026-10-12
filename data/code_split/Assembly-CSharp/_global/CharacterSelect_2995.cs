// Namespace: 
public class CharacterSelect : CharacterSelectBase // TypeDefIndex: 2995
{
	// Fields
	public GameObject StartBanner; // 0xC8
	public TMP_Text startText; // 0xD0
	public TMP_Text startTextShadow; // 0xD8
	public RectTransform startGroup; // 0xE0
	[CompilerGenerated]
	private bool <Force8LocalPlayers>k__BackingField; // 0xE8

	// Properties
	public bool Force8LocalPlayers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x775EF0 Offset: 0x7744F0 VA: 0x180775EF0
	public bool get_Force8LocalPlayers() { }

	[CompilerGenerated]
	// RVA: 0x775F00 Offset: 0x774500 VA: 0x180775F00
	public void set_Force8LocalPlayers(bool value) { }

	// RVA: 0x775680 Offset: 0x773C80 VA: 0x180775680 Slot: 7
	public override void Show() { }

	// RVA: 0x7742F0 Offset: 0x7728F0 VA: 0x1807742F0
	private void DeactivateUnusedInputDevices() { }

	// RVA: 0x774A40 Offset: 0x773040 VA: 0x180774A40
	private void OnInputDeviceActivated(int inputDeviceIndex) { }

	// RVA: 0x7749E0 Offset: 0x772FE0 VA: 0x1807749E0
	private void InputDeviceDisconnected(int inputDeviceIndex) { }

	// RVA: 0x7754C0 Offset: 0x773AC0 VA: 0x1807754C0
	private void SelectorUpdated(CharacterSelector updatedSelector) { }

	// RVA: 0x775C00 Offset: 0x774200 VA: 0x180775C00 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x774C80 Offset: 0x773280 VA: 0x180774C80
	public void SelectStart() { }

	// RVA: 0x774BF0 Offset: 0x7731F0 VA: 0x180774BF0 Slot: 13
	public override void ReturnToPreviousScreen(string screen = "Undefined", string cameraTransition = "") { }

	// RVA: 0x7745C0 Offset: 0x772BC0 VA: 0x1807745C0 Slot: 12
	public override void Disable() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
