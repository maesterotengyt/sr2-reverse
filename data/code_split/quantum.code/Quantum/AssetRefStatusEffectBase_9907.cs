// Namespace: Quantum
[AssetRef(typeof(StatusEffectBase))]
[Serializable]
public struct AssetRefStatusEffectBase : IEquatable<AssetRefStatusEffectBase>, IAssetRef<StatusEffectBase> // TypeDefIndex: 9907
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7040 Offset: 0x20C5640 VA: 0x1820C7040
	public static AssetRefStatusEffectBase op_Implicit(StatusEffectBase value) { }

	// RVA: 0x20C8030 Offset: 0x20C6630 VA: 0x1820C8030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefStatusEffectBase other) { }

	// RVA: 0x20C80C0 Offset: 0x20C66C0 VA: 0x1820C80C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
