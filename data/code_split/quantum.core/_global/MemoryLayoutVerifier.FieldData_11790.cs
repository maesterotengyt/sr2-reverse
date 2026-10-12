// Namespace: 
private class MemoryLayoutVerifier.FieldData // TypeDefIndex: 11790
{
	// Fields
	private readonly Nullable<int> _overlap; // 0x10
	public readonly FieldInfo Field; // 0x18
	public readonly int OffsetAttribute; // 0x20
	public readonly int OffsetPlatform; // 0x24
	public readonly int Size; // 0x28
	public readonly bool IsFixedBuffer; // 0x2C

	// Properties
	public int FieldOverlap { get; }
	public bool AllowFieldOverlap { get; }

	// Methods

	// RVA: 0x2224830 Offset: 0x2222E30 VA: 0x182224830
	public int get_FieldOverlap() { }

	// RVA: 0x22247F0 Offset: 0x2222DF0 VA: 0x1822247F0
	public bool get_AllowFieldOverlap() { }

	// RVA: 0x2224790 Offset: 0x2222D90 VA: 0x182224790
	public void .ctor(FieldInfo field, int offsetAttribute, int size, Nullable<int> overlap, bool isFixed, int offsetPlatform) { }

	// RVA: 0x22246F0 Offset: 0x2222CF0 VA: 0x1822246F0 Slot: 3
	public override string ToString() { }
}
