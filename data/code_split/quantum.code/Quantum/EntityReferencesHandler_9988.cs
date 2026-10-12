// Namespace: Quantum
public struct EntityReferencesHandler : IComponent // TypeDefIndex: 9988
{
	// Fields
	[PtrQList(typeof(GameEntityReference))]
	private Ptr EntitiesPtr; // 0x0

	// Properties
	public QListPtr<GameEntityReference> Entities { get; set; }

	// Methods

	// RVA: 0x20E2740 Offset: 0x20E0D40 VA: 0x1820E2740
	public QListPtr<GameEntityReference> get_Entities() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_Entities(QListPtr<GameEntityReference> value) { }

	// RVA: 0x20E2610 Offset: 0x20E0C10 VA: 0x1820E2610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0430 Offset: 0x20DEA30 VA: 0x1820E0430
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20E2620 Offset: 0x20E0C20 VA: 0x1820E2620
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20E26A0 Offset: 0x20E0CA0 VA: 0x1820E26A0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
