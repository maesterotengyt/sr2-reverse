// Namespace: 
public struct KeyboardInputsState // TypeDefIndex: 3448
{
	// Fields
	public List<KeyboardInputState> KeyboardInputs; // 0x0
	public Vector2 DigitalLeftStick; // 0x8

	// Methods

	// RVA: 0x5E6560 Offset: 0x5E4B60 VA: 0x1805E6560
	public void Init() { }

	// RVA: 0x5AEBD0 Offset: 0x5AD1D0 VA: 0x1805AEBD0
	private KeyboardInputState InitKey(Key key) { }

	// RVA: 0x5E6370 Offset: 0x5E4970 VA: 0x1805E6370
	public void Clean() { }

	// RVA: 0x5E6850 Offset: 0x5E4E50 VA: 0x1805E6850
	public bool KeyIsDown(Key key) { }

	// RVA: 0x5E6AB0 Offset: 0x5E50B0 VA: 0x1805E6AB0
	public bool KeyIsUp(Key key) { }

	// RVA: 0x5E6980 Offset: 0x5E4F80 VA: 0x1805E6980
	public bool KeyIsHold(Key key) { }

	// RVA: 0x5E6BE0 Offset: 0x5E51E0 VA: 0x1805E6BE0
	public void SetKeyState(Key key, bool isDown, bool isUp, bool isHold) { }

	// RVA: 0x5E6430 Offset: 0x5E4A30 VA: 0x1805E6430
	public Key GetCurrentKeyDown() { }
}
