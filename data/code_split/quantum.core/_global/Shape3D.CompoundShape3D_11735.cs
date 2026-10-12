// Namespace: 
public struct Shape3D.CompoundShape3D // TypeDefIndex: 11735
{
	// Fields
	public const int SIZE = 88;
	private const int DEFAULT_CAPACITY = 4;
	internal FPVector3 _centroid; // 0x0
	internal FP _broadRadius; // 0x38
	internal FP _volume; // 0x40
	[Ptr(typeof(Shape3D))]
	internal Ptr _shapesBuffer; // 0x48
	internal ushort _count; // 0x4C
	internal ushort _capacity; // 0x4E
	internal byte _isPersistent; // 0x50
	private int _padding; // 0x54

	// Methods

	// RVA: 0x22235C0 Offset: 0x2221BC0 VA: 0x1822235C0
	public void CopyFrom(FrameBase f, ref Shape3D shape) { }

	// RVA: 0x22233C0 Offset: 0x22219C0 VA: 0x1822233C0
	public void AddShape(FrameBase f, ref Shape3D shape, bool updateCompoundMeta = True) { }

	// RVA: 0x2223C70 Offset: 0x2222270 VA: 0x182223C70
	public bool GetShapes(FrameBase f, out Shape3D* shapesBuffer, out int count) { }

	// RVA: 0x2223AB0 Offset: 0x22220B0 VA: 0x182223AB0
	public void FreePersistent(FrameBase f, bool freeNestedPersistent = True) { }

	// RVA: 0x2223840 Offset: 0x2221E40 VA: 0x182223840
	private Shape3D* EnsureCapacity(FrameBase f, Nullable<int> capacity) { }

	// RVA: 0x2223CC0 Offset: 0x22222C0 VA: 0x182223CC0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2223BE0 Offset: 0x22221E0 VA: 0x182223BE0 Slot: 2
	public override int GetHashCode() { }
}
