// Namespace: 
public struct Shape2D.CompoundShape2D // TypeDefIndex: 11705
{
	// Fields
	public const int SIZE = 56;
	private const int DEFAULT_CAPACITY = 4;
	internal FPVector2 _centroid; // 0x0
	internal FP _area; // 0x18
	internal FP _broadRadius; // 0x20
	[Ptr(typeof(Shape2D))]
	internal Ptr _shapesBuffer; // 0x28
	internal ushort _count; // 0x2C
	internal ushort _capacity; // 0x2E
	internal int _isPersistent; // 0x30
	private int _padding; // 0x34

	// Properties
	public bool IsPersistent { get; }

	// Methods

	// RVA: 0x221ADB0 Offset: 0x22193B0 VA: 0x18221ADB0
	public bool get_IsPersistent() { }

	// RVA: 0x221A5B0 Offset: 0x2218BB0 VA: 0x18221A5B0
	public void CopyFrom(FrameBase f, ref Shape2D shape) { }

	// RVA: 0x221A470 Offset: 0x2218A70 VA: 0x18221A470
	public void AddShape(FrameBase f, ref Shape2D shape, bool updateCompoundMeta = True) { }

	// RVA: 0x221AC00 Offset: 0x2219200 VA: 0x18221AC00
	public bool GetShapes(FrameBase f, out Shape2D* shapesBuffer, out int count) { }

	// RVA: 0x221AA40 Offset: 0x2219040 VA: 0x18221AA40
	public void FreePersistent(FrameBase f, bool freeNestedPersistent = True) { }

	// RVA: 0x221A7E0 Offset: 0x2218DE0 VA: 0x18221A7E0
	private Shape2D* EnsureCapacity(FrameBase f, Nullable<int> capacity) { }

	// RVA: 0x221AC50 Offset: 0x2219250 VA: 0x18221AC50
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x221AB70 Offset: 0x2219170 VA: 0x18221AB70 Slot: 2
	public override int GetHashCode() { }
}
