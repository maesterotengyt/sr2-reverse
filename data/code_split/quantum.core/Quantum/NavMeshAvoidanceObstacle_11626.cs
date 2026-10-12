// Namespace: Quantum
public struct NavMeshAvoidanceObstacle : IComponent // TypeDefIndex: 11626
{
	// Fields
	public const int SIZE = 32;
	internal byte _disabled; // 0x0
	internal byte _avoidanceLayer; // 0x1
	internal FP _radius; // 0x8
	internal FPVector2 _velocity; // 0x10

	// Properties
	public bool IsActive { set; }
	public byte AvoidanceLayer { set; }
	public FP Radius { get; set; }

	// Methods

	// RVA: 0x21DCC00 Offset: 0x21DB200 VA: 0x1821DCC00
	public void set_IsActive(bool value) { }

	// RVA: 0x21DCBF0 Offset: 0x21DB1F0 VA: 0x1821DCBF0
	public void set_AvoidanceLayer(byte value) { }

	// RVA: 0x6AB5F0 Offset: 0x6A9BF0 VA: 0x1806AB5F0
	public FP get_Radius() { }

	// RVA: 0x1F9DFD0 Offset: 0x1F9C5D0 VA: 0x181F9DFD0
	public void set_Radius(FP value) { }

	// RVA: 0x21DCB50 Offset: 0x21DB150 VA: 0x1821DCB50
	public static void Serialize(void* p, FrameSerializer serializer) { }

	// RVA: 0x21DCAD0 Offset: 0x21DB0D0 VA: 0x1821DCAD0
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
