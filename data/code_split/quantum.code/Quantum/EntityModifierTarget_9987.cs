// Namespace: Quantum
public struct EntityModifierTarget : IComponent // TypeDefIndex: 9987
{
	// Fields
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public EntityModifierInfo EntityModifier; // 0x10
	[HideInInspector]
	[PtrQList(typeof(EntityRef))]
	private Ptr EntityModifiersPtr; // 0x0
	[HideInInspector]
	public PhysicsModifierInfo PhysicsModifier; // 0x20
	[HideInInspector]
	[PtrQList(typeof(EntityRef))]
	private Ptr PhysicsModifiersPtr; // 0x4

	// Properties
	public QListPtr<EntityRef> EntityModifiers { get; set; }
	public QListPtr<EntityRef> PhysicsModifiers { get; set; }

	// Methods

	// RVA: 0x20E2560 Offset: 0x20E0B60 VA: 0x1820E2560
	public QListPtr<EntityRef> get_EntityModifiers() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_EntityModifiers(QListPtr<EntityRef> value) { }

	// RVA: 0x20E25A0 Offset: 0x20E0BA0 VA: 0x1820E25A0
	public QListPtr<EntityRef> get_PhysicsModifiers() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_PhysicsModifiers(QListPtr<EntityRef> value) { }

	// RVA: 0x20E1F10 Offset: 0x20E0510 VA: 0x1820E1F10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E1F00 Offset: 0x20E0500 VA: 0x1820E1F00
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20E1F70 Offset: 0x20E0570 VA: 0x1820E1F70
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20E21D0 Offset: 0x20E07D0 VA: 0x1820E21D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20E1D20 Offset: 0x20E0320 VA: 0x1820E1D20
	public void AddEntityModifier(Frame frame, EntityRef entityModifierEntity) { }

	// RVA: 0x20E1FF0 Offset: 0x20E05F0 VA: 0x1820E1FF0
	public void RemoveEntityModifier(Frame frame, EntityRef entityModifierEntity) { }

	// RVA: 0x20E1E10 Offset: 0x20E0410 VA: 0x1820E1E10
	public void AddPhysicsModifier(Frame frame, EntityRef physicsModifierEntity) { }

	// RVA: 0x20E20E0 Offset: 0x20E06E0 VA: 0x1820E20E0
	public void RemovePhysicsModifier(Frame frame, EntityRef physicsModifierEntity) { }

	// RVA: 0x20E22E0 Offset: 0x20E08E0 VA: 0x1820E22E0
	public void UpdateEntityModifierMultipliers(Frame frame, ref QList<EntityRef> entityModifiers) { }

	// RVA: 0x20E2410 Offset: 0x20E0A10 VA: 0x1820E2410
	public void UpdatePhysicsMultipliers(Frame frame, ref QList<EntityRef> physicsModifiers) { }
}
