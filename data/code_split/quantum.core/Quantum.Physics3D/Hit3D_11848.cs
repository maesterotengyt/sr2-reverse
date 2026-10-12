// Namespace: Quantum.Physics3D
public struct Hit3D // TypeDefIndex: 11848
{
	// Fields
	public const int SIZE = 80;
	private ushort _isTrigger; // 0x0
	public ushort ShapeUserTag; // 0x2
	internal int _staticColliderIndex; // 0x4
	private const int PenetrationOffset = 8;
	[FieldOverlap(8)]
	public FP OverlapPenetration; // 0x8
	[FieldOverlap(8)]
	public FP CastDistanceNormalized; // 0x8
	private const int EntityOffset = 16;
	[FieldOverlap(16)]
	internal EntityRef _entity; // 0x10
	[FieldOverlap(16)]
	internal AssetGuid _mapGuid; // 0x10
	internal long sqrDistance; // 0x18
	private const int FirstVector3 = 32;
	public FPVector3 Point; // 0x20
	public FPVector3 Normal; // 0x38

	// Properties
	public bool IsDynamic { get; }
	public bool IsTrigger { get; set; }
	public EntityRef Entity { get; }

	// Methods

	// RVA: 0x2264B20 Offset: 0x2263120 VA: 0x182264B20
	public bool get_IsDynamic() { }

	// RVA: 0x2264B30 Offset: 0x2263130 VA: 0x182264B30
	public bool get_IsTrigger() { }

	// RVA: 0x2200A10 Offset: 0x21FF010 VA: 0x182200A10
	public void set_IsTrigger(bool value) { }

	// RVA: 0x2200A00 Offset: 0x21FF000 VA: 0x182200A00
	public EntityRef get_Entity() { }

	// RVA: 0x2264A70 Offset: 0x2263070 VA: 0x182264A70
	public ref MapStaticCollider3D GetStaticCollider(FrameThreadSafe f) { }

	// RVA: 0x22649D0 Offset: 0x2262FD0 VA: 0x1822649D0 Slot: 2
	public override int GetHashCode() { }
}
