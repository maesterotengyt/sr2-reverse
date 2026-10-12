// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(SimpleLineRenderer))]
[Serializable]
public class SimpleLineRenderer_Prototype : PrototypeAdapter<SimpleLineRenderer_Prototype> // TypeDefIndex: 3924
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Visible; // 0x18
	public FPVector2 PointA; // 0x20
	public FPVector2 PointB; // 0x30
	public SimpleLineEndRotationMode_Prototype PointARotationMode; // 0x40
	public SimpleLineEndRotationMode_Prototype PointBRotationMode; // 0x44

	// Methods

	// RVA: 0x682740 Offset: 0x680D40 VA: 0x180682740 Slot: 5
	public sealed override SimpleLineRenderer_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6827F0 Offset: 0x680DF0 VA: 0x1806827F0
	public void .ctor() { }
}
