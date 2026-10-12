// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(TrapDoorSwitch))]
[Serializable]
public class TrapDoorSwitch_Prototype : PrototypeAdapter<TrapDoorSwitch_Prototype> // TypeDefIndex: 3938
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public QBoolean IsOn; // 0x18
	public QString64 SwitchID; // 0x1C
	[HideInInspector]
	public int SwitchIDHash; // 0x5C
	public TrapDoorSwitchActivationMode_Prototype ActivationMode; // 0x60
	public FP FramesToDeactivate; // 0x68
	[HideInInspector]
	public FP RuntimeFramesToDeactivate; // 0x70

	// Methods

	// RVA: 0x6838A0 Offset: 0x681EA0 VA: 0x1806838A0 Slot: 5
	public sealed override TrapDoorSwitch_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x683970 Offset: 0x681F70 VA: 0x180683970
	public void .ctor() { }
}
