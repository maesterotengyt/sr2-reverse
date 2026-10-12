// Namespace: Quantum
[Serializable]
public struct Transform3D : IComponent // TypeDefIndex: 11753
{
	// Fields
	public const int SIZE = 56;
	public FPVector3 Position; // 0x0
	public FPQuaternion Rotation; // 0x18

	// Properties
	public FPVector3 Forward { get; }

	// Methods

	// RVA: 0x2229CB0 Offset: 0x22282B0 VA: 0x182229CB0
	public FPVector3 InverseTransformDirection(FPVector3 direction) { }

	// RVA: 0x2229D80 Offset: 0x2228380 VA: 0x182229D80
	public FPVector3 TransformDirection(FPVector3 direction) { }

	// RVA: 0x2229DF0 Offset: 0x22283F0 VA: 0x182229DF0
	public FPVector3 get_Forward() { }

	// RVA: 0x2229D40 Offset: 0x2228340 VA: 0x182229D40
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2229C70 Offset: 0x2228270 VA: 0x182229C70 Slot: 2
	public override int GetHashCode() { }
}
