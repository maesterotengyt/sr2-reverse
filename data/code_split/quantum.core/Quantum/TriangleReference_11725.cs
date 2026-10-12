// Namespace: Quantum
public struct TriangleReference : IEquatable<TriangleReference> // TypeDefIndex: 11725
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 4;
	private int _index; // 0x0
	private int _many; // 0x4

	// Methods

	// RVA: 0x222E1B0 Offset: 0x222C7B0 VA: 0x18222E1B0
	public void .ctor(int index, bool isMany) { }

	// RVA: 0x1D10FF0 Offset: 0x1D0F5F0 VA: 0x181D10FF0 Slot: 4
	public bool Equals(TriangleReference other) { }

	// RVA: 0x222E050 Offset: 0x222C650 VA: 0x18222E050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x222E0E0 Offset: 0x222C6E0 VA: 0x18222E0E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222E0F0 Offset: 0x222C6F0 VA: 0x18222E0F0
	public static void Serialize(void* p, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x222E1C0 Offset: 0x222C7C0 VA: 0x18222E1C0
	public static bool op_Equality(TriangleReference a, TriangleReference b) { }
}
