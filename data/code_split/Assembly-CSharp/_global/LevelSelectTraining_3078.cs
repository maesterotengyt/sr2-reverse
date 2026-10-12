// Namespace: 
public class LevelSelectTraining : LevelSelectBase // TypeDefIndex: 3078
{
	// Fields
	private bool readyToStart; // 0xD8

	// Properties
	private SaveManager saveManager { get; }

	// Methods

	// RVA: 0x546CD0 Offset: 0x5452D0 VA: 0x180546CD0
	private SaveManager get_saveManager() { }

	// RVA: 0x546A80 Offset: 0x545080 VA: 0x180546A80 Slot: 7
	public override void Show() { }

	// RVA: 0x546300 Offset: 0x544900 VA: 0x180546300
	private void SelectorUpdated(LevelSelector updatedSelector) { }

	[IteratorStateMachine(typeof(LevelSelectTraining.<StartLevel>d__5))]
	// RVA: 0x546C50 Offset: 0x545250 VA: 0x180546C50
	private IEnumerator StartLevel() { }

	// RVA: 0x546290 Offset: 0x544890 VA: 0x180546290
	public void ReturnToPreviousScreen() { }

	// RVA: 0x546160 Offset: 0x544760 VA: 0x180546160 Slot: 12
	public override void Disable() { }

	// RVA: 0x546CC0 Offset: 0x5452C0 VA: 0x180546CC0
	public void .ctor() { }
}
