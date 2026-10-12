// Namespace: Quantum.Prototypes
[Prototype(typeof(HurtBox))]
[Serializable]
public sealed class HurtBox_Prototype : StructPrototype // TypeDefIndex: 10813
{
	// Fields
	public int JointA; // 0x10
	public int JointB; // 0x14
	public int ID; // 0x18
	public FPVector2 CachePointA; // 0x20
	public FPVector2 CachePointB; // 0x30
	public FP Radius; // 0x40
	public FPVector3 CacheLocalOffsetA; // 0x48
	public FPVector2 CacheGlobalOffsetA; // 0x60
	public FPVector3 CacheLocalOffsetB; // 0x70
	public FPVector2 CacheGlobalOffsetB; // 0x88
	public FPVector2 PointA; // 0x98
	public FPVector2 PointB; // 0xA8
	public SimpleAABB_Prototype RectArea; // 0xB8
	public QBoolean IsIntangible; // 0xC0
	public QBoolean IsInvincible; // 0xC4

	// Methods

	// RVA: 0x2107340 Offset: 0x2105940 VA: 0x182107340
	public void Materialize(Frame frame, ref HurtBox result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
