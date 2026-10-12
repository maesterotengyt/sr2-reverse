// Namespace: Quantum
public struct ParentObject : IComponent // TypeDefIndex: 10014
{
	// Fields
	[PtrQList(typeof(ChildEntity))]
	private Ptr ChildEntitiesPtr; // 0x0
	public EntityRef ParentEntity; // 0x8

	// Properties
	public QListPtr<ChildEntity> ChildEntities { get; set; }

	// Methods

	// RVA: 0x2121AD0 Offset: 0x21200D0 VA: 0x182121AD0
	public QListPtr<ChildEntity> get_ChildEntities() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_ChildEntities(QListPtr<ChildEntity> value) { }

	// RVA: 0x2121570 Offset: 0x211FB70 VA: 0x182121570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0430 Offset: 0x20DEA30 VA: 0x1820E0430
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2121710 Offset: 0x211FD10 VA: 0x182121710
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2121790 Offset: 0x211FD90 VA: 0x182121790
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2121590 Offset: 0x211FB90 VA: 0x182121590
	public void OnInit(Frame frame, EntityRef entity) { }

	// RVA: 0x2121840 Offset: 0x211FE40 VA: 0x182121840
	public void Update(Frame frame, EntityRef entity) { }
}
