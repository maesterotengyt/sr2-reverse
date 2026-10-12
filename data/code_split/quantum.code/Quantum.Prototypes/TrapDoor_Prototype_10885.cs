// Namespace: Quantum.Prototypes
[Prototype(typeof(TrapDoor))]
[Serializable]
public sealed class TrapDoor_Prototype : ComponentPrototype<TrapDoor> // TypeDefIndex: 10885
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QString64 SwitchIDToReact; // 0x1C
	[HideInInspector]
	public int SwitchIDToReactHash; // 0x5C
	[HideInInspector]
	public QBoolean IsOn; // 0x60
	public FP OffRotation; // 0x68
	public FP OnRotation; // 0x70
	public FP RotationSpeed; // 0x78

	// Methods

	// RVA: 0x2113950 Offset: 0x2111F50 VA: 0x182113950 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113B80 Offset: 0x2112180 VA: 0x182113B80
	public void Materialize(Frame frame, ref TrapDoor result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113AF0 Offset: 0x21120F0 VA: 0x182113AF0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2113BF0 Offset: 0x21121F0 VA: 0x182113BF0
	public void .ctor() { }
}
