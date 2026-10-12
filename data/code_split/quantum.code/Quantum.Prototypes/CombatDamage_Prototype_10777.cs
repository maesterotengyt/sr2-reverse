// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatDamage))]
[Serializable]
public sealed class CombatDamage_Prototype : ComponentPrototype<CombatDamage> // TypeDefIndex: 10777
{
	// Fields
	public FP Damage; // 0x18

	// Methods

	// RVA: 0x20FFAD0 Offset: 0x20FE0D0 VA: 0x1820FFAD0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FFC10 Offset: 0x20FE210 VA: 0x1820FFC10
	public void Materialize(Frame frame, ref CombatDamage result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FFB80 Offset: 0x20FE180 VA: 0x1820FFB80 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FFC20 Offset: 0x20FE220 VA: 0x1820FFC20
	public void .ctor() { }
}
