// Namespace: Quantum.Prototypes
[Prototype(typeof(TrapDoorSwitch))]
[Serializable]
public sealed class TrapDoorSwitch_Prototype : ComponentPrototype<TrapDoorSwitch> // TypeDefIndex: 10886
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public QBoolean IsOn; // 0x1C
	public QString64 SwitchID; // 0x20
	[HideInInspector]
	public int SwitchIDHash; // 0x60
	public TrapDoorSwitchActivationMode_Prototype ActivationMode; // 0x64
	public FP FramesToDeactivate; // 0x68
	[HideInInspector]
	public FP RuntimeFramesToDeactivate; // 0x70

	// Methods

	// RVA: 0x2113670 Offset: 0x2111C70 VA: 0x182113670 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21138A0 Offset: 0x2111EA0 VA: 0x1821138A0
	public void Materialize(Frame frame, ref TrapDoorSwitch result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113810 Offset: 0x2111E10 VA: 0x182113810 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2113910 Offset: 0x2111F10 VA: 0x182113910
	public void .ctor() { }
}
