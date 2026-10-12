// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatArmor))]
[Serializable]
public sealed class CombatArmor_Prototype : ComponentPrototype<CombatArmor> // TypeDefIndex: 10773
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public FP Armor; // 0x20
	[HideInInspector]
	public QBoolean SuperArmor; // 0x28

	// Methods

	// RVA: 0x20FF210 Offset: 0x20FD810 VA: 0x1820FF210 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF390 Offset: 0x20FD990 VA: 0x1820FF390
	public void Materialize(Frame frame, ref CombatArmor result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF300 Offset: 0x20FD900 VA: 0x1820FF300 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FF3D0 Offset: 0x20FD9D0 VA: 0x1820FF3D0
	public void .ctor() { }
}
