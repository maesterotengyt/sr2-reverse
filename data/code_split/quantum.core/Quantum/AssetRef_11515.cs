// Namespace: Quantum
[Serializable]
public struct AssetRef : IEquatable<AssetRef> // TypeDefIndex: 11515
{
	// Fields
	public const int SIZE = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x21C4C50 Offset: 0x21C3250 VA: 0x1821C4C50
	public static AssetRef op_Implicit(AssetObject value) { }

	// RVA: 0x21C4AE0 Offset: 0x21C30E0 VA: 0x1821C4AE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21C53F0 Offset: 0x21C39F0 VA: 0x1821C53F0
	public static string ToString(AssetGuid Id) { }

	// RVA: 0x20AA910 Offset: 0x20A8F10 VA: 0x1820AA910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x93BBD0 Offset: 0x93A1D0 VA: 0x18093BBD0
	public static bool op_Equality(AssetRef a, AssetRef b) { }

	// RVA: 0x93B7B0 Offset: 0x939DB0 VA: 0x18093B7B0 Slot: 4
	public bool Equals(AssetRef other) { }

	// RVA: 0x21C5370 Offset: 0x21C3970 VA: 0x1821C5370 Slot: 0
	public override bool Equals(object obj) { }
}
