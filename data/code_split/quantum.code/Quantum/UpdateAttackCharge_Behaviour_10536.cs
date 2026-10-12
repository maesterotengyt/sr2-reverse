// Namespace: Quantum
[Serializable]
public class UpdateAttackCharge_Behaviour : StateBehaviour // TypeDefIndex: 10536
{
	// Fields
	public ExecuteGroupEvent ChargeFinishedGroup; // 0x60
	public bool OverrideGroundAttackMaxChargeFrames; // 0x78
	public int GroundAttackMaxChargeFrames; // 0x7C
	public bool OverrideFramesToReleaseChargeGroundAttack; // 0x80
	public int FramesToReleaseChargeGroundAttack; // 0x84

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C29A0 Offset: 0x21C0FA0 VA: 0x1821C29A0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
