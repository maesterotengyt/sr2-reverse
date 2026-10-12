// Namespace: Quantum
[Serializable]
public struct AnimationSpeedElement // TypeDefIndex: 9911
{
	// Fields
	public const int SIZE = 16;
	public const int ALIGNMENT = 8;
	public int Frame; // 0x0
	public FP Speed; // 0x8

	// Methods

	// RVA: 0x20C6C80 Offset: 0x20C5280 VA: 0x1820C6C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6CC0 Offset: 0x20C52C0 VA: 0x1820C6CC0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
