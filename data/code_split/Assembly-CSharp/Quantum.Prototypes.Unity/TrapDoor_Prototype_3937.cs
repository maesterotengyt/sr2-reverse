// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(TrapDoor))]
[Serializable]
public class TrapDoor_Prototype : PrototypeAdapter<TrapDoor_Prototype> // TypeDefIndex: 3937
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QString64 SwitchIDToReact; // 0x18
	[HideInInspector]
	public int SwitchIDToReactHash; // 0x58
	[HideInInspector]
	public QBoolean IsOn; // 0x5C
	public FP OffRotation; // 0x60
	public FP OnRotation; // 0x68
	public FP RotationSpeed; // 0x70

	// Methods

	// RVA: 0x6839B0 Offset: 0x681FB0 VA: 0x1806839B0 Slot: 5
	public sealed override TrapDoor_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x683A80 Offset: 0x682080 VA: 0x180683A80
	public void .ctor() { }
}
