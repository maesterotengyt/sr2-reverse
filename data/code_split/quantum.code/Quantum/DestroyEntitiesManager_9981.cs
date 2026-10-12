// Namespace: Quantum
public struct DestroyEntitiesManager : IComponent // TypeDefIndex: 9981
{
	// Fields
	[PtrQList(typeof(EntityRef))]
	private Ptr EntitiesToDestroyPtr; // 0x0

	// Properties
	public QListPtr<EntityRef> EntitiesToDestroy { get; set; }

	// Methods

	// RVA: 0x20E0570 Offset: 0x20DEB70 VA: 0x1820E0570
	public QListPtr<EntityRef> get_EntitiesToDestroy() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_EntitiesToDestroy(QListPtr<EntityRef> value) { }

	// RVA: 0x20E0440 Offset: 0x20DEA40 VA: 0x1820E0440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0430 Offset: 0x20DEA30 VA: 0x1820E0430
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20E0450 Offset: 0x20DEA50 VA: 0x1820E0450
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20E04D0 Offset: 0x20DEAD0 VA: 0x1820E04D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
