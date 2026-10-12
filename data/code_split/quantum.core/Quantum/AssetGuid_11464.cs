// Namespace: Quantum
[Serializable]
public struct AssetGuid : IEquatable<AssetGuid>, IComparable<AssetGuid> // TypeDefIndex: 11464
{
	// Fields
	public const int SIZE = 8;
	public const long DynamicBit = -9223372036854775808;
	public const long ReservedBits = -4611686018427387904;
	public const long Invalid = 0;
	public const long None = 0;
	public const long NumberBase = 16;
	public long Value; // 0x0

	// Properties
	public bool IsValid { get; }
	public bool IsDynamic { get; }

	// Methods

	// RVA: 0x1FA0950 Offset: 0x1F9EF50 VA: 0x181FA0950
	public bool get_IsValid() { }

	// RVA: 0x21C49A0 Offset: 0x21C2FA0 VA: 0x1821C49A0
	public bool get_IsDynamic() { }

	// RVA: 0x93BBC0 Offset: 0x93A1C0 VA: 0x18093BBC0
	public void .ctor(long value) { }

	// RVA: 0x21C47B0 Offset: 0x21C2DB0 VA: 0x1821C47B0
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x93B7B0 Offset: 0x939DB0 VA: 0x18093B7B0 Slot: 4
	public bool Equals(AssetGuid other) { }

	// RVA: 0x20AA7F0 Offset: 0x20A8DF0 VA: 0x1820AA7F0 Slot: 5
	public int CompareTo(AssetGuid other) { }

	// RVA: 0x21C4720 Offset: 0x21C2D20 VA: 0x1821C4720 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20AA910 Offset: 0x20A8F10 VA: 0x1820AA910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x93BBD0 Offset: 0x93A1D0 VA: 0x18093BBD0
	public static bool op_Equality(AssetGuid a, AssetGuid b) { }

	// RVA: 0x6264D0 Offset: 0x624AD0 VA: 0x1806264D0
	public static bool op_Inequality(AssetGuid a, AssetGuid b) { }

	// RVA: 0x62D6F0 Offset: 0x62BCF0 VA: 0x18062D6F0
	public static AssetGuid op_Implicit(long value) { }

	// RVA: 0x21C4930 Offset: 0x21C2F30 VA: 0x1821C4930 Slot: 3
	public override string ToString() { }

	// RVA: 0x21C48B0 Offset: 0x21C2EB0 VA: 0x1821C48B0
	public string ToString(bool includeBrackets) { }
}
