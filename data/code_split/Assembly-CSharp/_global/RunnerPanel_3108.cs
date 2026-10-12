// Namespace: 
public class RunnerPanel : MainMenuSubPanel // TypeDefIndex: 3108
{
	// Fields
	public Transform RunnersSlots; // 0x48
	public Image MaximizeButtonIcon; // 0x50
	public Image RandomButtonIcon; // 0x58
	public TMP_Text HighlightedCharacterName; // 0x60
	[CompilerGenerated]
	private HashString <HighlitedCharacterID>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <Costume>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <Random>k__BackingField; // 0x7C

	// Properties
	public HashString HighlitedCharacterID { get; set; }
	public int Costume { get; set; }
	public bool Random { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x567D50 Offset: 0x566350 VA: 0x180567D50
	public HashString get_HighlitedCharacterID() { }

	[CompilerGenerated]
	// RVA: 0x567D80 Offset: 0x566380 VA: 0x180567D80
	public void set_HighlitedCharacterID(HashString value) { }

	[CompilerGenerated]
	// RVA: 0x567D40 Offset: 0x566340 VA: 0x180567D40
	public int get_Costume() { }

	[CompilerGenerated]
	// RVA: 0x567D70 Offset: 0x566370 VA: 0x180567D70
	public void set_Costume(int value) { }

	[CompilerGenerated]
	// RVA: 0x567D60 Offset: 0x566360 VA: 0x180567D60
	public bool get_Random() { }

	[CompilerGenerated]
	// RVA: 0x567DA0 Offset: 0x5663A0 VA: 0x180567DA0
	public void set_Random(bool value) { }

	// RVA: 0x567660 Offset: 0x565C60 VA: 0x180567660 Slot: 4
	public override void Initialize(MainMenuHub newMainMenu) { }

	// RVA: 0x567A90 Offset: 0x566090 VA: 0x180567A90 Slot: 5
	public override void Show() { }

	// RVA: 0x567BC0 Offset: 0x5661C0 VA: 0x180567BC0
	public void UnSelectSlots() { }

	// RVA: 0x567710 Offset: 0x565D10 VA: 0x180567710
	private void SetSlotsData() { }

	// RVA: 0x567C90 Offset: 0x566290 VA: 0x180567C90 Slot: 6
	public override void UpdatePanel() { }

	// RVA: 0x5673B0 Offset: 0x5659B0 VA: 0x1805673B0
	public void ConfirmSelection() { }

	// RVA: 0x567470 Offset: 0x565A70 VA: 0x180567470
	private MainMenuPanelRunnerSlot GetRunnerSlot(int index) { }

	// RVA: 0x5674E0 Offset: 0x565AE0 VA: 0x1805674E0 Slot: 7
	public override void Hide() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
