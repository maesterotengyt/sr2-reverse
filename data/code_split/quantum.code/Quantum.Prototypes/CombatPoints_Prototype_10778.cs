// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatPoints))]
[Serializable]
public sealed class CombatPoints_Prototype : ComponentPrototype<CombatPoints> // TypeDefIndex: 10778
{
	// Fields
	public int Points; // 0x18

	// Methods

	// RVA: 0x20FFC60 Offset: 0x20FE260 VA: 0x1820FFC60 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC8E0 Offset: 0x20FAEE0 VA: 0x1820FC8E0
	public void Materialize(Frame frame, ref CombatPoints result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FFD10 Offset: 0x20FE310 VA: 0x1820FFD10 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FFDA0 Offset: 0x20FE3A0 VA: 0x1820FFDA0
	public void .ctor() { }
}
