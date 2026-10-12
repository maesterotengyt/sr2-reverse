// Namespace: 
public abstract class StellarController : StellarInputDevice // TypeDefIndex: 3364
{
	// Fields
	public ControllerInputsState CurrentInputsState; // 0x48
	public ControllerInputMapping CurrentInputMapping; // 0x60

	// Methods

	// RVA: 0x5BF8D0 Offset: 0x5BDED0 VA: 0x1805BF8D0 Slot: 4
	public override void OnInit() { }

	// RVA: 0x5BF030 Offset: 0x5BD630 VA: 0x1805BF030
	public void AssignMapping(ControllerInputMapping newMapping) { }

	// RVA: 0x5BFB10 Offset: 0x5BE110 VA: 0x1805BFB10 Slot: 6
	public override void PollInputs() { }

	// RVA: 0x5BF990 Offset: 0x5BDF90 VA: 0x1805BF990 Slot: 5
	public override void PollGameplayInputs(ref Input input) { }

	// RVA: 0x5BF4E0 Offset: 0x5BDAE0 VA: 0x1805BF4E0 Slot: 7
	public override bool GetUIInputDown(UIKey key) { }

	// RVA: 0x5BF780 Offset: 0x5BDD80 VA: 0x1805BF780 Slot: 8
	public override bool GetUIInputUp(UIKey key) { }

	// RVA: 0x5BF630 Offset: 0x5BDC30 VA: 0x1805BF630 Slot: 9
	public override bool GetUIInputHold(UIKey key) { }

	// RVA: 0x5BF240 Offset: 0x5BD840 VA: 0x1805BF240 Slot: 10
	public override bool GetGameplayInputHold(InputFlag key) { }

	// RVA: 0x5BF390 Offset: 0x5BD990 VA: 0x1805BF390 Slot: 11
	public override bool GetMovementInputHold(InputDirection direction) { }

	// RVA: 0x5BEEE0 Offset: 0x5BD4E0 VA: 0x1805BEEE0 Slot: 12
	public override bool AnyInput() { }

	// RVA: 0x5BF230 Offset: 0x5BD830 VA: 0x1805BF230 Slot: 13
	public override void CleanInputs() { }

	// RVA: 0x5BFBA0 Offset: 0x5BE1A0 VA: 0x1805BFBA0
	public void SetKeyState(ControllerKey key, bool isDown, bool isUp, bool isHold) { }

	// RVA: 0x5BFBC0 Offset: 0x5BE1C0 VA: 0x1805BFBC0
	protected void .ctor() { }
}
