// Namespace: Quantum
public struct LayoutManager : IComponent // TypeDefIndex: 10007
{
	// Fields
	[PtrQList(typeof(StageEntity))]
	private Ptr StageEntitiesPtr; // 0x0

	// Properties
	public QListPtr<StageEntity> StageEntities { get; set; }

	// Methods

	// RVA: 0x2120530 Offset: 0x211EB30 VA: 0x182120530
	public QListPtr<StageEntity> get_StageEntities() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_StageEntities(QListPtr<StageEntity> value) { }

	// RVA: 0x2120160 Offset: 0x211E760 VA: 0x182120160 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0430 Offset: 0x20DEA30 VA: 0x1820E0430
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2120410 Offset: 0x211EA10 VA: 0x182120410
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2120490 Offset: 0x211EA90 VA: 0x182120490
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2120170 Offset: 0x211E770 VA: 0x182120170
	public void OnInit(Frame frame, EntityRef entity) { }
}
