// Namespace: Quantum
[Serializable]
public struct AssetRefMap : IEquatable<AssetRefMap>, IAssetRef<Map> // TypeDefIndex: 11479
{
	// Fields
	public const int SIZE = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x21C4C50 Offset: 0x21C3250 VA: 0x1821C4C50
	public static AssetRefMap op_Implicit(Map value) { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x21C4AE0 Offset: 0x21C30E0 VA: 0x1821C4AE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x93B7B0 Offset: 0x939DB0 VA: 0x18093B7B0 Slot: 4
	public bool Equals(AssetRefMap other) { }

	// RVA: 0x21C4E90 Offset: 0x21C3490 VA: 0x1821C4E90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20AA910 Offset: 0x20A8F10 VA: 0x1820AA910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x93BBD0 Offset: 0x93A1D0 VA: 0x18093BBD0
	public static bool op_Equality(AssetRefMap a, AssetRefMap b) { }
}
