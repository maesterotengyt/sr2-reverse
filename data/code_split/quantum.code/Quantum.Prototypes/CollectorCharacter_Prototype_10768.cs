// Namespace: Quantum.Prototypes
[Prototype(typeof(CollectorCharacter))]
[Serializable]
public sealed class CollectorCharacter_Prototype : ComponentPrototype<CollectorCharacter> // TypeDefIndex: 10768
{
	// Fields
	public MapEntityId Entity; // 0x18
	public int Score; // 0x1C

	// Methods

	// RVA: 0x20FE820 Offset: 0x20FCE20 VA: 0x1820FE820 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FE990 Offset: 0x20FCF90 VA: 0x1820FE990
	public void Materialize(Frame frame, ref CollectorCharacter result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FE900 Offset: 0x20FCF00 VA: 0x1820FE900 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FE9D0 Offset: 0x20FCFD0 VA: 0x1820FE9D0
	public void .ctor() { }
}
