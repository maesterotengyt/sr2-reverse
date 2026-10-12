// Namespace: Quantum
[Serializable]
public struct Ptr : IEquatable<Ptr> // TypeDefIndex: 11463
{
	// Fields
	public const int SIZE = 4;
	public int Offset; // 0x0

	// Properties
	public static Ptr Null { get; }

	// Methods

	// RVA: 0x81E2E0 Offset: 0x81C8E0 VA: 0x18081E2E0
	public static Ptr get_Null() { }

	// RVA: 0x93A610 Offset: 0x938C10 VA: 0x18093A610 Slot: 4
	public bool Equals(Ptr other) { }

	// RVA: 0x21D81A0 Offset: 0x21D67A0 VA: 0x1821D81A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xB72450 Offset: 0xB70A50 VA: 0x180B72450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21D8220 Offset: 0x21D6820 VA: 0x1821D8220 Slot: 3
	public override string ToString() { }

	// RVA: 0x93A650 Offset: 0x938C50 VA: 0x18093A650
	public static bool op_Equality(Ptr a, Ptr b) { }

	// RVA: 0x21D8280 Offset: 0x21D6880 VA: 0x1821D8280
	public static bool op_Inequality(Ptr a, Ptr b) { }
}
