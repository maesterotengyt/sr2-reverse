// Namespace: 
public class InputEditorSubMenu : InputProfileSubMenu // TypeDefIndex: 3053
{
	// Fields
	public InputOption InputOptionNew; // 0x38
	public InputOption InputOptionOld; // 0x40
	public GameObject NewInputText; // 0x48
	public LocalizedString EditString; // 0x50
	public LocalizedString SelectNewInputString; // 0x58
	public LocalizedString SelectNewButtonString; // 0x60
	public LocalizedString SelectNewButtonSwitchString; // 0x68
	private Key newKey; // 0x70
	private ControllerKey newControllerKey; // 0x74
	private bool detectingNewInputKey; // 0x78
	private InputFlag currentGameplayKey; // 0x7C
	private int editingInputIndex; // 0x80
	private InputProfile currentProfile; // 0x88
	private int editingInputProfileIndex; // 0xD8
	private bool movementInputEditing; // 0xDC
	private InputDirection currentDirection; // 0xE0

	// Methods

	// RVA: 0x53CF10 Offset: 0x53B510 VA: 0x18053CF10
	public void Show(int index, int editingInputProfileIndex) { }

	// RVA: 0x53D6B0 Offset: 0x53BCB0 VA: 0x18053D6B0
	public void Show(InputDirection direction, int editingInputProfileIndex, string directionString) { }

	// RVA: 0x53C1B0 Offset: 0x53A7B0 VA: 0x18053C1B0
	public void DetectInput() { }

	// RVA: 0x53CA90 Offset: 0x53B090 VA: 0x18053CA90
	public void SetNewKeyboardInput(Key newKey) { }

	// RVA: 0x53C5F0 Offset: 0x53ABF0 VA: 0x18053C5F0
	public void RemoveDuplicatedInputMapping() { }

	// RVA: 0x53C7E0 Offset: 0x53ADE0 VA: 0x18053C7E0
	public void SetNewControllerInput(ControllerKey newKey) { }

	// RVA: 0x53CE50 Offset: 0x53B450 VA: 0x18053CE50
	public void SetProfileData(InputProfile profile) { }

	// RVA: 0x53C570 Offset: 0x53AB70 VA: 0x18053C570 Slot: 5
	public override void Hide() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x53DD10 Offset: 0x53C310 VA: 0x18053DD10
	private bool <SetNewKeyboardInput>b__19_0(MovementKeyboardMapping x) { }
}
