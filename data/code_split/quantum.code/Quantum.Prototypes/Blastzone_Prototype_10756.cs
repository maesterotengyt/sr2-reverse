// Namespace: Quantum.Prototypes
[Prototype(typeof(Blastzone))]
[Serializable]
public sealed class Blastzone_Prototype : ComponentPrototype<Blastzone> // TypeDefIndex: 10756
{
	// Fields
	public FPVector2 TopLeft; // 0x18
	public FPVector2 BottomRight; // 0x28
	[HideInInspector]
	public QBoolean TriggerEnabled; // 0x38

	// Methods

	// RVA: 0x20FCAE0 Offset: 0x20FB0E0 VA: 0x1820FCAE0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCC70 Offset: 0x20FB270 VA: 0x1820FCC70
	public void Materialize(Frame frame, ref Blastzone result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCBE0 Offset: 0x20FB1E0 VA: 0x1820FCBE0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FCC90 Offset: 0x20FB290 VA: 0x1820FCC90
	public void .ctor() { }
}
