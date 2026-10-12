// Namespace: Quantum
[AssetRef(typeof(TransformKeyFramesData))]
[Serializable]
public struct AssetRefTransformKeyFramesData : IEquatable<AssetRefTransformKeyFramesData>, IAssetRef<TransformKeyFramesData> // TypeDefIndex: 9909
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C8190 Offset: 0x20C6790 VA: 0x1820C8190 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefTransformKeyFramesData other) { }

	// RVA: 0x20C8220 Offset: 0x20C6820 VA: 0x1820C8220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
