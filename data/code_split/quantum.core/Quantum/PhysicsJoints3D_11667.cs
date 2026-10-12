// Namespace: Quantum
public struct PhysicsJoints3D : IComponent // TypeDefIndex: 11667
{
	// Fields
	public const int SIZE = 8;
	private const int DEFAULT_CAPACITY = 4;
	[PtrBuffer(typeof(Joint3D), "_count")]
	private Ptr _jointsBuffer; // 0x0
	private ushort _count; // 0x4
	private ushort _capacity; // 0x6

	// Properties
	public ushort Count { get; }

	// Methods

	// RVA: 0x2200E70 Offset: 0x21FF470 VA: 0x182200E70
	public ushort get_Count() { }

	// RVA: 0x221EAB0 Offset: 0x221D0B0 VA: 0x18221EAB0
	public void AddJoint(FrameBase f, ref Joint3D joint) { }

	// RVA: 0x221ED50 Offset: 0x221D350 VA: 0x18221ED50
	public Joint3D* GetJoints(FrameBase f, out int count) { }

	// RVA: 0x221EB60 Offset: 0x221D160 VA: 0x18221EB60
	private Joint3D* EnsureCapacity(FrameBase f) { }

	// RVA: 0x221EDE0 Offset: 0x221D3E0 VA: 0x18221EDE0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x221E910 Offset: 0x221CF10 VA: 0x18221E910
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
