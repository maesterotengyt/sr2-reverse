// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatStamina))]
[Serializable]
public sealed class CombatStamina_Prototype : ComponentPrototype<CombatStamina> // TypeDefIndex: 10779
{
	// Fields
	public FP Stamina; // 0x18
	public FP ExtraDamageForKnockback; // 0x20
	public FP ExtraDamageForKnockbackFrames; // 0x28

	// Methods

	// RVA: 0x20FFDE0 Offset: 0x20FE3E0 VA: 0x1820FFDE0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FFF40 Offset: 0x20FE540 VA: 0x1820FFF40
	public void Materialize(Frame frame, ref CombatStamina result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FFEB0 Offset: 0x20FE4B0 VA: 0x1820FFEB0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FFF60 Offset: 0x20FE560 VA: 0x1820FFF60
	public void .ctor() { }
}
