// Namespace: Quantum
public struct EndlessGameModeManager : IComponent // TypeDefIndex: 9984
{
	// Fields
	public FP DistanceRunned; // 0x8
	public QBoolean HasDialogue; // 0x0
	[PtrQList(typeof(EntityRef))]
	private Ptr PlataformsPtr; // 0x4
	[HideInInspector]
	public FP RandomPlataformIndex; // 0x10
	public FP SpawnedPlataforms; // 0x18

	// Properties
	public QListPtr<EntityRef> Plataforms { get; set; }

	// Methods

	// RVA: 0x20E1C50 Offset: 0x20E0250 VA: 0x1820E1C50
	public QListPtr<EntityRef> get_Plataforms() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_Plataforms(QListPtr<EntityRef> value) { }

	// RVA: 0x20E1A90 Offset: 0x20E0090 VA: 0x1820E1A90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CCF30 Offset: 0x20CB530 VA: 0x1820CCF30
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20E1AF0 Offset: 0x20E00F0 VA: 0x1820E1AF0
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20E1B70 Offset: 0x20E0170 VA: 0x1820E1B70
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
