// Namespace: Quantum
public struct TriggerPolygonShape : IComponent // TypeDefIndex: 10061
{
	// Fields
	[HideInInspector]
	public FPVector2 Center; // 0x8
	[PtrQList(typeof(FPVector2))]
	private Ptr PolygonVerticesPtr; // 0x0

	// Properties
	public QListPtr<FPVector2> PolygonVertices { get; set; }

	// Methods

	// RVA: 0x21487E0 Offset: 0x2146DE0 VA: 0x1821487E0
	public QListPtr<FPVector2> get_PolygonVertices() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_PolygonVertices(QListPtr<FPVector2> value) { }

	// RVA: 0x2148680 Offset: 0x2146C80 VA: 0x182148680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0430 Offset: 0x20DEA30 VA: 0x1820E0430
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x21486B0 Offset: 0x2146CB0 VA: 0x1821486B0
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2148730 Offset: 0x2146D30 VA: 0x182148730
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
