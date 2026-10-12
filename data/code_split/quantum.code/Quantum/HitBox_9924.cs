// Namespace: Quantum
public struct HitBox // TypeDefIndex: 9924
{
	// Fields
	public QBoolean Active; // 0x10
	[PtrQList(typeof(int))]
	private Ptr AttackDatasPtr; // 0x18
	public FPVector2 CacheGlobalOffset; // 0x28
	public FPVector3 CacheLocalOffset; // 0x68
	public FPVector2 CachePoint; // 0x38
	public FPVector2 CurrentPosition; // 0x48
	public HitBoxType HitBoxType; // 0x4
	public int ID; // 0x8
	public QBoolean Interpolate; // 0x14
	public int JointID; // 0xC
	public FPVector2 PreviousPosition; // 0x58
	public HitBoxPriority Priority; // 0x0
	public FP Radius; // 0x20
	public SimpleAABB RectArea; // 0x80

	// Properties
	public QListPtr<int> AttackDatas { get; set; }

	// Methods

	// RVA: 0x20CF800 Offset: 0x20CDE00 VA: 0x1820CF800
	public QListPtr<int> get_AttackDatas() { }

	// RVA: 0x6A4F50 Offset: 0x6A3550 VA: 0x1806A4F50
	public void set_AttackDatas(QListPtr<int> value) { }

	// RVA: 0x20CF130 Offset: 0x20CD730 VA: 0x1820CF130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CF290 Offset: 0x20CD890 VA: 0x1820CF290
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20CF4A0 Offset: 0x20CDAA0 VA: 0x1820CF4A0
	public bool TryGetAttackData(Frame frame, CombatEntity check, CombatEntity target, out AttackData attackData) { }

	// RVA: 0x20CF250 Offset: 0x20CD850 VA: 0x1820CF250
	public bool IsDefault() { }

	// RVA: 0x20CF270 Offset: 0x20CD870 VA: 0x1820CF270
	public bool IsReflectOrRedirect() { }
}
