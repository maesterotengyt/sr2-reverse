// Namespace: 
public class LevelSelect : LevelSelectBase // TypeDefIndex: 3066
{
	// Fields
	private bool readyToStart; // 0xD8
	private bool onScreen; // 0xD9

	// Methods

	// RVA: 0x547710 Offset: 0x545D10 VA: 0x180547710 Slot: 7
	public override void Show() { }

	// RVA: 0x547630 Offset: 0x545C30 VA: 0x180547630
	private void SelectorUpdated(LevelSelector updatedSelector) { }

	// RVA: 0x5475B0 Offset: 0x545BB0 VA: 0x1805475B0
	public void ReturnToPreviousScreen() { }

	// RVA: 0x547380 Offset: 0x545980 VA: 0x180547380
	private bool DoAllPlayersChooseTheSame() { }

	// RVA: 0x546D20 Offset: 0x545320 VA: 0x180546D20
	private void ChooseLevel() { }

	[IteratorStateMachine(typeof(LevelSelect.<StartLevel>d__7))]
	// RVA: 0x547920 Offset: 0x545F20 VA: 0x180547920
	private IEnumerator StartLevel() { }

	// RVA: 0x547250 Offset: 0x545850 VA: 0x180547250 Slot: 12
	public override void Disable() { }

	// RVA: 0x546CC0 Offset: 0x5452C0 VA: 0x180546CC0
	public void .ctor() { }
}
