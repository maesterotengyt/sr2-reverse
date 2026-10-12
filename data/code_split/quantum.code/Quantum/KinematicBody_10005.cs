// Namespace: Quantum
public struct KinematicBody : IComponent // TypeDefIndex: 10005
{
	// Fields
	public QBoolean Active; // 0x0
	public FPVector2 Velocity; // 0x8

	// Methods

	// RVA: 0x211FF50 Offset: 0x211E550 VA: 0x18211FF50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211FFC0 Offset: 0x211E5C0 VA: 0x18211FFC0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x211FF80 Offset: 0x211E580 VA: 0x18211FF80
	public FP GetValue(KinematicBodyVariable variable) { }

	// RVA: 0x2120000 Offset: 0x211E600 VA: 0x182120000
	public void SetValue(KinematicBodyVariable variable, FP value) { }
}
