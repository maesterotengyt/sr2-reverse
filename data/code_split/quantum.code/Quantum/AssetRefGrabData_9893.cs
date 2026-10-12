// Namespace: Quantum
[AssetRef(typeof(GrabData))]
[Serializable]
public struct AssetRefGrabData : IEquatable<AssetRefGrabData>, IAssetRef<GrabData> // TypeDefIndex: 9893
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7680 Offset: 0x20C5C80 VA: 0x1820C7680 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefGrabData other) { }

	// RVA: 0x20C7710 Offset: 0x20C5D10 VA: 0x1820C7710 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
