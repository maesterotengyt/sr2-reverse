// Namespace: Quantum
[Serializable]
public class SetupHurtBoxes_Behaviour : StateBehaviour // TypeDefIndex: 10530
{
	// Fields
	public SetupHurtBoxes_Behaviour.HurtBoxUpdateMode UpdateMode; // 0x60
	[DrawIf("UpdateMode", 0, 0, 3)]
	public HashString PresetID; // 0x68
	[DrawIf("UpdateMode", 1, 0, 3)]
	public HurtBoxData[] HurtBoxes; // 0x78

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C0A10 Offset: 0x21BF010 VA: 0x1821C0A10 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C0BA0 Offset: 0x21BF1A0 VA: 0x1821C0BA0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C0C10 Offset: 0x21BF210 VA: 0x1821C0C10 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21C0DA0 Offset: 0x21BF3A0 VA: 0x1821C0DA0
	public void .ctor() { }
}
