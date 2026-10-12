// Namespace: Quantum
public abstract class EventBase : IDispatchable // TypeDefIndex: 11596
{
	// Fields
	internal EventBase Prev; // 0x10
	internal EventBase Next; // 0x18
	internal EventList List; // 0x20
	public int Tick; // 0x28
	[CompilerGenerated]
	private IDeterministicGame <Game>k__BackingField; // 0x30
	public readonly int Id; // 0x38
	private readonly EventFlags _flags; // 0x3C

	// Properties
	public IDeterministicGame Game { get; set; }
	public bool Synced { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090 Slot: 4
	public IDeterministicGame get_Game() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_Game(IDeterministicGame value) { }

	// RVA: 0x21CD4C0 Offset: 0x21CBAC0 VA: 0x1821CD4C0
	public bool get_Synced() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void OnReleased() { }

	// RVA: 0x21CD480 Offset: 0x21CBA80 VA: 0x1821CD480
	public void .ctor(int id, EventFlags flags) { }
}
