// Namespace: 
public class StellarPCKeyboard : StellarInputDevice // TypeDefIndex: 3442
{
	// Fields
	public KeyboardInputsState CurrentInputsState; // 0x48
	public KeyboardInputMapping CurrentInputMapping; // 0x58
	[HideInInspector]
	public bool DebugKeyboard; // 0x70

	// Properties
	protected StellarData stellarData { get; }

	// Methods

	// RVA: 0x5F1AB0 Offset: 0x5F00B0 VA: 0x1805F1AB0
	protected StellarData get_stellarData() { }

	// RVA: 0x5F1A70 Offset: 0x5F0070 VA: 0x1805F1A70
	public void .ctor() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public override void OnInit() { }

	// RVA: 0x5F1220 Offset: 0x5EF820 VA: 0x1805F1220 Slot: 7
	public override bool GetUIInputDown(UIKey key) { }

	// RVA: 0x5F14C0 Offset: 0x5EFAC0 VA: 0x1805F14C0 Slot: 8
	public override bool GetUIInputUp(UIKey key) { }

	// RVA: 0x5F1370 Offset: 0x5EF970 VA: 0x1805F1370 Slot: 9
	public override bool GetUIInputHold(UIKey key) { }

	// RVA: 0x5F0F80 Offset: 0x5EF580 VA: 0x1805F0F80 Slot: 10
	public override bool GetGameplayInputHold(InputFlag key) { }

	// RVA: 0x5F10D0 Offset: 0x5EF6D0 VA: 0x1805F10D0 Slot: 11
	public override bool GetMovementInputHold(InputDirection direction) { }

	// RVA: 0x5F1610 Offset: 0x5EFC10 VA: 0x1805F1610 Slot: 5
	public override void PollGameplayInputs(ref Input input) { }

	// RVA: 0x5F1760 Offset: 0x5EFD60 VA: 0x1805F1760 Slot: 6
	public override void PollInputs() { }

	// RVA: 0x5F0E20 Offset: 0x5EF420 VA: 0x1805F0E20 Slot: 12
	public override bool AnyInput() { }

	// RVA: 0x5F0F70 Offset: 0x5EF570 VA: 0x1805F0F70 Slot: 13
	public override void CleanInputs() { }
}
