// Namespace: Quantum.Prototypes
[Prototype(typeof(StaticRotation))]
[Serializable]
public sealed class StaticRotation_Prototype : ComponentPrototype<StaticRotation> // TypeDefIndex: 10873
{
	// Fields
	public FP Rotation; // 0x18

	// Methods

	// RVA: 0x2111BA0 Offset: 0x21101A0 VA: 0x182111BA0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FFC10 Offset: 0x20FE210 VA: 0x1820FFC10
	public void Materialize(Frame frame, ref StaticRotation result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2111C50 Offset: 0x2110250 VA: 0x182111C50 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2111CE0 Offset: 0x21102E0 VA: 0x182111CE0
	public void .ctor() { }
}
