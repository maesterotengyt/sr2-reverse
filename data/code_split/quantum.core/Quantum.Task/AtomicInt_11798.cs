// Namespace: Quantum.Task
public struct AtomicInt // TypeDefIndex: 11798
{
	// Fields
	private int _value; // 0x0

	// Properties
	public int Value { get; }

	// Methods

	// RVA: 0x2222080 Offset: 0x2220680 VA: 0x182222080
	public int get_Value() { }

	// RVA: 0x2222060 Offset: 0x2220660 VA: 0x182222060
	public int IncrementPre() { }

	// RVA: 0x2222040 Offset: 0x2220640 VA: 0x182222040
	public int IncrementPost() { }

	// RVA: 0x2222010 Offset: 0x2220610 VA: 0x182222010
	public int Exchange(int value) { }

	// RVA: 0x2221FD0 Offset: 0x22205D0 VA: 0x182221FD0
	public int CompareExchange(int value, int assumed) { }
}
