// Namespace: Quantum.Prototypes
[Prototype(typeof(TriggerSphereShape))]
[Serializable]
public sealed class TriggerSphereShape_Prototype : ComponentPrototype<TriggerSphereShape> // TypeDefIndex: 10889
{
	// Fields
	public FPVector2 Center; // 0x18
	public FP Radius; // 0x28

	// Methods

	// RVA: 0x2118C40 Offset: 0x2117240 VA: 0x182118C40 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2118DB0 Offset: 0x21173B0 VA: 0x182118DB0
	public void Materialize(Frame frame, ref TriggerSphereShape result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2118D20 Offset: 0x2117320 VA: 0x182118D20 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2118DD0 Offset: 0x21173D0 VA: 0x182118DD0
	public void .ctor() { }
}
