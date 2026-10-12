// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(StageEdge))]
[Serializable]
public class StageEdge_Prototype : PrototypeAdapter<StageEdge_Prototype> // TypeDefIndex: 3928
{
	// Fields
	public QBoolean Active; // 0x10
	public EdgeSide_Prototype EdgeSide; // 0x14
	[HideInInspector]
	[LocalReference]
	public EntityPrototype GrabbedEntity; // 0x18

	// Methods

	// RVA: 0x682EA0 Offset: 0x6814A0 VA: 0x180682EA0 Slot: 5
	public sealed override StageEdge_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x682F30 Offset: 0x681530 VA: 0x180682F30
	public void .ctor() { }
}
