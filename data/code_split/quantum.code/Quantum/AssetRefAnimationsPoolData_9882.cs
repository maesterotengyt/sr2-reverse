// Namespace: Quantum
[AssetRef(typeof(AnimationsPoolData))]
[Serializable]
public struct AssetRefAnimationsPoolData : IEquatable<AssetRefAnimationsPoolData>, IAssetRef<AnimationsPoolData> // TypeDefIndex: 9882
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C6EE0 Offset: 0x20C54E0 VA: 0x1820C6EE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefAnimationsPoolData other) { }

	// RVA: 0x20C6F70 Offset: 0x20C5570 VA: 0x1820C6F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
