// Namespace: Quantum
[Serializable]
public class SetupArmor_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10526
{
	// Fields
	public bool SuperArmor; // 0x68
	public bool CumulativeDamageBased; // 0x69
	[DrawIf("CumulativeDamageBased", 1, 0, 3)]
	public int ArmorPoints; // 0x6C

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BF8D0 Offset: 0x21BDED0 VA: 0x1821BF8D0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BF970 Offset: 0x21BDF70 VA: 0x1821BF970 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21AFF10 Offset: 0x21AE510 VA: 0x1821AFF10
	public void .ctor() { }
}
