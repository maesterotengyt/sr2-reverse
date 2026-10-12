// Namespace: Quantum
[AssetRef(typeof(InputCheck_Behaviour))]
[Serializable]
public struct AssetRefInputCheck_Behaviour : IEquatable<AssetRefInputCheck_Behaviour>, IAssetRef<InputCheck_Behaviour> // TypeDefIndex: 9894
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7040 Offset: 0x20C5640 VA: 0x1820C7040
	public static AssetRefInputCheck_Behaviour op_Implicit(InputCheck_Behaviour value) { }

	// RVA: 0x20C7730 Offset: 0x20C5D30 VA: 0x1820C7730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefInputCheck_Behaviour other) { }

	// RVA: 0x1E5C0E0 Offset: 0x1E5A6E0 VA: 0x181E5C0E0
	public static bool op_Equality(AssetRefInputCheck_Behaviour a, AssetRefInputCheck_Behaviour b) { }

	// RVA: 0x20C77C0 Offset: 0x20C5DC0 VA: 0x1820C77C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
