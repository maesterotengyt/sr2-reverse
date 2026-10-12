// Namespace: Quantum.Prototypes
[Prototype(typeof(View))]
[Serializable]
public sealed class View_Prototype : ComponentPrototype<View> // TypeDefIndex: 11912
{
	// Fields
	public AssetRefEntityView Current; // 0x18

	// Methods

	// RVA: 0x20FFC10 Offset: 0x20FE210 VA: 0x1820FFC10
	public void Materialize(FrameBase frame, ref View result) { }

	// RVA: 0x227F290 Offset: 0x227D890 VA: 0x18227F290 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227F300 Offset: 0x227D900 VA: 0x18227F300 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227F330 Offset: 0x227D930 VA: 0x18227F330
	public void .ctor() { }
}
