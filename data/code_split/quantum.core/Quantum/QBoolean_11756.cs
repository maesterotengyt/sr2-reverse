// Namespace: Quantum
[Serializable]
public struct QBoolean : IEquatable<QBoolean> // TypeDefIndex: 11756
{
	// Fields
	public const int SIZE = 4;
	public int Value; // 0x0

	// Methods

	// RVA: 0x1E9F740 Offset: 0x1E9DD40 VA: 0x181E9F740
	public static bool op_Implicit(QBoolean b) { }

	// RVA: 0x1EA23C0 Offset: 0x1EA09C0 VA: 0x181EA23C0
	public static QBoolean op_Implicit(bool b) { }

	// RVA: 0x2227FC0 Offset: 0x22265C0 VA: 0x182227FC0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2228030 Offset: 0x2226630 VA: 0x182228030 Slot: 3
	public override string ToString() { }

	// RVA: 0x93A610 Offset: 0x938C10 VA: 0x18093A610 Slot: 4
	public bool Equals(QBoolean other) { }

	// RVA: 0x2227F40 Offset: 0x2226540 VA: 0x182227F40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xB72450 Offset: 0xB70A50 VA: 0x180B72450 Slot: 2
	public override int GetHashCode() { }
}
