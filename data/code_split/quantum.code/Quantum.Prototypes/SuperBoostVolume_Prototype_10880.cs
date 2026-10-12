// Namespace: Quantum.Prototypes
[Prototype(typeof(SuperBoostVolume))]
[Serializable]
public sealed class SuperBoostVolume_Prototype : ComponentPrototype<SuperBoostVolume> // TypeDefIndex: 10880
{
	// Fields
	public MapEntityId Entity; // 0x18
	public SuperBoostDirection_Prototype Direction; // 0x1C

	// Methods

	// RVA: 0x2112F50 Offset: 0x2111550 VA: 0x182112F50 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210FD90 Offset: 0x210E390 VA: 0x18210FD90
	public void Materialize(Frame frame, ref SuperBoostVolume result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113030 Offset: 0x2111630 VA: 0x182113030 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21130C0 Offset: 0x21116C0 VA: 0x1821130C0
	public void .ctor() { }
}
