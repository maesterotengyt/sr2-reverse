// Namespace: Quantum.Prototypes
[Prototype(typeof(HitBox))]
[Serializable]
public sealed class HitBox_Prototype : StructPrototype // TypeDefIndex: 10810
{
	// Fields
	public QBoolean Active; // 0x10
	public HitBoxType_Prototype HitBoxType; // 0x14
	public HitBoxPriority_Prototype Priority; // 0x18
	public int ID; // 0x1C
	public int JointID; // 0x20
	public FPVector2 CachePoint; // 0x28
	public FPVector3 CacheLocalOffset; // 0x38
	public FPVector2 CacheGlobalOffset; // 0x50
	public FP Radius; // 0x60
	public FPVector2 CurrentPosition; // 0x68
	public FPVector2 PreviousPosition; // 0x78
	public QBoolean Interpolate; // 0x88
	public SimpleAABB_Prototype RectArea; // 0x90
	[DynamicCollection]
	public int[] AttackDatas; // 0x98

	// Methods

	// RVA: 0x2106F60 Offset: 0x2105560 VA: 0x182106F60
	public void Materialize(Frame frame, ref HitBox result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2107150 Offset: 0x2105750 VA: 0x182107150
	public void .ctor() { }
}
