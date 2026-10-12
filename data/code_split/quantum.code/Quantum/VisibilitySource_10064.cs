// Namespace: Quantum
public struct VisibilitySource : IComponent // TypeDefIndex: 10064
{
	// Fields
	public QBoolean Active; // 0x0
	public SimpleAABB Bounds; // 0x10
	[HideInInspector]
	public EntityRef Entity; // 0x8

	// Methods

	// RVA: 0x214E200 Offset: 0x214C800 VA: 0x18214E200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214E280 Offset: 0x214C880 VA: 0x18214E280
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2137310 Offset: 0x2135910 VA: 0x182137310
	public FP GetValue(Frame frame, VisibilitySourceVariable variable) { }

	// RVA: 0x214E310 Offset: 0x214C910 VA: 0x18214E310
	public void SetValue(Frame frame, VisibilitySourceVariable variable, FP value) { }
}
