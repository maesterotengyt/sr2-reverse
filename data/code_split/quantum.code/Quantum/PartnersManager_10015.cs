// Namespace: Quantum
public struct PartnersManager : IComponent // TypeDefIndex: 10015
{
	// Fields
	[PtrQList(typeof(EntityRef))]
	private Ptr CharacterEntitiesPtr; // 0x8
	public QBoolean CharacterSwapAllowed; // 0x4
	public FP CharacterSwapCooldown; // 0x10
	public int CurrentCharacterIndex; // 0x0

	// Properties
	public QListPtr<EntityRef> CharacterEntities { get; set; }

	// Methods

	// RVA: 0x2121DC0 Offset: 0x21203C0 VA: 0x182121DC0
	public QListPtr<EntityRef> get_CharacterEntities() { }

	// RVA: 0x1ED2130 Offset: 0x1ED0730 VA: 0x181ED2130
	public void set_CharacterEntities(QListPtr<EntityRef> value) { }

	// RVA: 0x2121B10 Offset: 0x2120110 VA: 0x182121B10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21207D0 Offset: 0x211EDD0 VA: 0x1821207D0
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2121B60 Offset: 0x2120160 VA: 0x182121B60
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2121BE0 Offset: 0x21201E0 VA: 0x182121BE0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2121CD0 Offset: 0x21202D0 VA: 0x182121CD0
	public static bool TryFind(Frame frame, EntityRef characterEntityRef, out PartnersManager* partnersManager, out EntityRef entityRef) { }

	// RVA: 0x2121D60 Offset: 0x2120360 VA: 0x182121D60
	public void Update(Frame frame) { }
}
