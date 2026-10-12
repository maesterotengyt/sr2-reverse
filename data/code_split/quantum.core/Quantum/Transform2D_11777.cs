// Namespace: Quantum
[Serializable]
public struct Transform2D : IComponent // TypeDefIndex: 11777
{
	// Fields
	public const int SIZE = 24;
	public FPVector2 Position; // 0x0
	public FP Rotation; // 0x10

	// Properties
	public FPVector2 Up { get; }

	// Methods

	// RVA: 0x2229BA0 Offset: 0x22281A0 VA: 0x182229BA0
	public FPVector2 get_Up() { }

	// RVA: 0x2229A90 Offset: 0x2228090 VA: 0x182229A90
	public FPVector2 TransformPoint(FPVector2 point) { }

	// RVA: 0x2229940 Offset: 0x2227F40 VA: 0x182229940
	public FPVector2 InverseTransformPoint(FPVector2 point) { }

	// RVA: 0x2229A50 Offset: 0x2228050 VA: 0x182229A50
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2229900 Offset: 0x2227F00 VA: 0x182229900 Slot: 2
	public override int GetHashCode() { }
}
