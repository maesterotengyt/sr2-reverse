// Namespace: Quantum
public sealed class CallbackPollInput : QuantumGame.CallbackBase // TypeDefIndex: 10260
{
	// Fields
	public const int ID = 0;
	public int Frame; // 0x20
	public int Player; // 0x24
	[CompilerGenerated]
	private bool <IsFirstInThisUpdate>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsInputSet>k__BackingField; // 0x29
	[CompilerGenerated]
	private Input <Input>k__BackingField; // 0x2C
	[CompilerGenerated]
	private DeterministicInputFlags <Flags>k__BackingField; // 0x34

	// Properties
	internal bool IsFirstInThisUpdate { set; }
	public bool IsInputSet { get; set; }
	public Input Input { get; set; }
	public DeterministicInputFlags Flags { get; set; }

	// Methods

	// RVA: 0x2167050 Offset: 0x2165650 VA: 0x182167050
	internal void .ctor(QuantumGame game) { }

	// RVA: 0x2167040 Offset: 0x2165640 VA: 0x182167040
	public void SetInput(Input input, DeterministicInputFlags flags) { }

	[CompilerGenerated]
	// RVA: 0x5BA5B0 Offset: 0x5B8BB0 VA: 0x1805BA5B0
	internal void set_IsFirstInThisUpdate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x619830 Offset: 0x617E30 VA: 0x180619830
	public bool get_IsInputSet() { }

	[CompilerGenerated]
	// RVA: 0x61A6E0 Offset: 0x618CE0 VA: 0x18061A6E0
	internal void set_IsInputSet(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2167060 Offset: 0x2165660 VA: 0x182167060
	public Input get_Input() { }

	[CompilerGenerated]
	// RVA: 0x2167070 Offset: 0x2165670 VA: 0x182167070
	private void set_Input(Input value) { }

	[CompilerGenerated]
	// RVA: 0x881B20 Offset: 0x880120 VA: 0x180881B20
	public DeterministicInputFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x881B30 Offset: 0x880130 VA: 0x180881B30
	private void set_Flags(DeterministicInputFlags value) { }
}
