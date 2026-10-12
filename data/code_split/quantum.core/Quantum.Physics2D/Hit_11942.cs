// Namespace: Quantum.Physics2D
public struct Hit // TypeDefIndex: 11942
{
	// Fields
	public const int SIZE = 64;
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
	private const int FirstVector2 = 32;
	public FPVector2 Point; // 0x20
	public FPVector2 Normal; // 0x30

	// Properties
	public bool IsTrigger { set; }
	public EntityRef Entity { get; }

	// Methods

	// RVA: 0x2200A10 Offset: 0x21FF010 VA: 0x182200A10
	public void set_IsTrigger(bool value) { }

	// RVA: 0x2200A00 Offset: 0x21FF000 VA: 0x182200A00
	public EntityRef get_Entity() { }

	// RVA: 0x22007E0 Offset: 0x21FEDE0 VA: 0x1822007E0
	public bool TryGetStaticCollider(FrameBase f, out MapStaticCollider2D collider) { }

	// RVA: 0x2200830 Offset: 0x21FEE30 VA: 0x182200830
	public bool TryGetStaticCollider(FrameThreadSafe f, out MapStaticCollider2D collider) { }

	// RVA: 0x2200740 Offset: 0x21FED40 VA: 0x182200740 Slot: 2
	public override int GetHashCode() { }
}
