// Namespace: Quantum
public struct StageSFX : IComponent // TypeDefIndex: 10044
{
	// Fields
	[PtrQList(typeof(SFXToExecute))]
	private Ptr EventIDListPtr; // 0x8
	public StageExecutionMode ExecutionMode; // 0xC
	public QBoolean PlayOnStart; // 0x0
	public QBoolean UpdateSoundPosition; // 0x4

	// Properties
	public QListPtr<SFXToExecute> EventIDList { get; set; }

	// Methods

	// RVA: 0x2130B50 Offset: 0x212F150 VA: 0x182130B50
	public QListPtr<SFXToExecute> get_EventIDList() { }

	// RVA: 0x1ED2130 Offset: 0x1ED0730 VA: 0x181ED2130
	public void set_EventIDList(QListPtr<SFXToExecute> value) { }

	// RVA: 0x21306C0 Offset: 0x212ECC0 VA: 0x1821306C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21207D0 Offset: 0x211EDD0 VA: 0x1821207D0
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2130730 Offset: 0x212ED30 VA: 0x182130730
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2130A60 Offset: 0x212F060 VA: 0x182130A60
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x21306E0 Offset: 0x212ECE0 VA: 0x1821306E0
	public void OnInit(Frame frame, EntityRef entity) { }

	// RVA: 0x21307B0 Offset: 0x212EDB0 VA: 0x1821307B0
	public void PlaySFX(Frame frame, EntityRef entityRef) { }
}
