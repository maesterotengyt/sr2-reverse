// Namespace: Quantum
public struct HurtBox // TypeDefIndex: 9927
{
	// Fields
	public FPVector2 CacheGlobalOffsetA; // 0x20
	public FPVector2 CacheGlobalOffsetB; // 0x30
	public FPVector3 CacheLocalOffsetA; // 0x80
	public FPVector3 CacheLocalOffsetB; // 0x98
	public FPVector2 CachePointA; // 0x40
	public FPVector2 CachePointB; // 0x50
	public int ID; // 0x0
	public QBoolean IsIntangible; // 0xC
	public QBoolean IsInvincible; // 0x10
	public int JointA; // 0x4
	public int JointB; // 0x8
	public FPVector2 PointA; // 0x60
	public FPVector2 PointB; // 0x70
	public FP Radius; // 0x18
	public SimpleAABB RectArea; // 0xB0

	// Methods

	// RVA: 0x20CFF10 Offset: 0x20CE510 VA: 0x1820CFF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D0060 Offset: 0x20CE660 VA: 0x1820D0060
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
