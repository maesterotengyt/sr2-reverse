// Namespace: Quantum.Prototypes
[Prototype(typeof(Shockwave))]
[Serializable]
public sealed class Shockwave_Prototype : ComponentPrototype<Shockwave> // TypeDefIndex: 10855
{
	// Fields
	public MapEntityId Entity; // 0x18
	public FPVector2 InitialPosition; // 0x20
	public FPVector2 TargetPosition; // 0x30
	public FP Power; // 0x40

	// Methods

	// RVA: 0x210DDB0 Offset: 0x210C3B0 VA: 0x18210DDB0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210DF50 Offset: 0x210C550 VA: 0x18210DF50
	public void Materialize(Frame frame, ref Shockwave result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210DEC0 Offset: 0x210C4C0 VA: 0x18210DEC0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210DFA0 Offset: 0x210C5A0 VA: 0x18210DFA0
	public void .ctor() { }
}
