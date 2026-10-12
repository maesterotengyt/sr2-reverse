// Namespace: Quantum
public struct PhysicsJoints2D : IComponent // TypeDefIndex: 11665
{
	// Fields
	public const int SIZE = 8;
	private const int DEFAULT_CAPACITY = 4;
	[PtrBuffer(typeof(Joint), "_count")]
	private Ptr _jointsBuffer; // 0x0
	private ushort _count; // 0x4
	private ushort _capacity; // 0x6

	// Properties
	public ushort Count { get; }

	// Methods

	// RVA: 0x2200E70 Offset: 0x21FF470 VA: 0x182200E70
	public ushort get_Count() { }

	// RVA: 0x221E620 Offset: 0x221CC20 VA: 0x18221E620
	public void AddJoint(FrameBase f, ref Joint joint) { }

	// RVA: 0x221E880 Offset: 0x221CE80 VA: 0x18221E880
	public Joint* GetJoints(FrameBase f, out int count) { }

	// RVA: 0x221E690 Offset: 0x221CC90 VA: 0x18221E690
	private Joint* EnsureCapacity(FrameBase f) { }

	// RVA: 0x221E9A0 Offset: 0x221CFA0 VA: 0x18221E9A0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x221E910 Offset: 0x221CF10 VA: 0x18221E910
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
