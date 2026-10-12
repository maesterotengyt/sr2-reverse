// Namespace: 
public struct ControllerInputsState // TypeDefIndex: 3367
{
	// Fields
	public List<ControllerInputState> Inputs; // 0x0
	public Vector2 LeftStick; // 0x8
	public Vector2 RightStick; // 0x10

	// Methods

	// RVA: 0x5AEBF0 Offset: 0x5AD1F0 VA: 0x1805AEBF0
	public void Init() { }

	// RVA: 0x5AEBD0 Offset: 0x5AD1D0 VA: 0x1805AEBD0
	private ControllerInputState InitKey(ControllerKey key) { }

	// RVA: 0x5AE6B0 Offset: 0x5ACCB0 VA: 0x1805AE6B0
	public void Clean() { }

	// RVA: 0x5AEF00 Offset: 0x5AD500 VA: 0x1805AEF00
	public bool KeyIsDown(ControllerKey key) { }

	// RVA: 0x5AF160 Offset: 0x5AD760 VA: 0x1805AF160
	public bool KeyIsUp(ControllerKey key) { }

	// RVA: 0x5AF030 Offset: 0x5AD630 VA: 0x1805AF030
	public bool KeyIsHold(ControllerKey key) { }

	// RVA: 0x5AF290 Offset: 0x5AD890 VA: 0x1805AF290
	public void SetKeyState(ControllerKey key, bool isDown, bool isUp, bool isHold) { }

	// RVA: 0x5AE770 Offset: 0x5ACD70 VA: 0x1805AE770
	public ControllerKey GetCurrentKeyDown() { }
}
