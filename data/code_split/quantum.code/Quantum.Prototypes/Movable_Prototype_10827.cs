// Namespace: Quantum.Prototypes
[Prototype(typeof(Movable))]
[Serializable]
public sealed class Movable_Prototype : ComponentPrototype<Movable> // TypeDefIndex: 10827
{
	// Fields
	public FPVector2 PreviousPosition; // 0x18
	public QBoolean Teleported; // 0x28
	public QBoolean TeleportedFlag; // 0x2C

	// Methods

	// RVA: 0x21094F0 Offset: 0x2107AF0 VA: 0x1821094F0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2109670 Offset: 0x2107C70 VA: 0x182109670
	public void Materialize(Frame frame, ref Movable result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21095E0 Offset: 0x2107BE0 VA: 0x1821095E0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2109690 Offset: 0x2107C90 VA: 0x182109690
	public void .ctor() { }
}
