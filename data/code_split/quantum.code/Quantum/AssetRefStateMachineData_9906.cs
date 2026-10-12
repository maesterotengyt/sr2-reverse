// Namespace: Quantum
[AssetRef(typeof(StateMachineData))]
[Serializable]
public struct AssetRefStateMachineData : IEquatable<AssetRefStateMachineData>, IAssetRef<StateMachineData> // TypeDefIndex: 9906
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7EC0 Offset: 0x20C64C0 VA: 0x1820C7EC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefStateMachineData other) { }

	// RVA: 0x20C7F70 Offset: 0x20C6570 VA: 0x1820C7F70
	public static bool op_Inequality(AssetRefStateMachineData a, AssetRefStateMachineData b) { }

	// RVA: 0x20C7F50 Offset: 0x20C6550 VA: 0x1820C7F50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
