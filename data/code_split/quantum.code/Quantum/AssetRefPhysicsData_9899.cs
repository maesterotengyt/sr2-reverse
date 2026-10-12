// Namespace: Quantum
[AssetRef(typeof(PhysicsData))]
[Serializable]
public struct AssetRefPhysicsData : IEquatable<AssetRefPhysicsData>, IAssetRef<PhysicsData> // TypeDefIndex: 9899
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7AA0 Offset: 0x20C60A0 VA: 0x1820C7AA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefPhysicsData other) { }

	// RVA: 0x20C7B30 Offset: 0x20C6130 VA: 0x1820C7B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
