// Namespace: Quantum.Prototypes
[Prototype(typeof(Rocket))]
[Serializable]
public sealed class Rocket_Prototype : ComponentPrototype<Rocket> // TypeDefIndex: 10844
{
	// Fields
	public MapEntityId Entity; // 0x18
	public MapEntityId Target; // 0x1C
	public FP ReCheckTargetFrames; // 0x20
	public FP InterpolationSpeed; // 0x28

	// Methods

	// RVA: 0x210D610 Offset: 0x210BC10 VA: 0x18210D610 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D7B0 Offset: 0x210BDB0 VA: 0x18210D7B0
	public void Materialize(Frame frame, ref Rocket result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D720 Offset: 0x210BD20 VA: 0x18210D720 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210D810 Offset: 0x210BE10 VA: 0x18210D810
	public void .ctor() { }
}
