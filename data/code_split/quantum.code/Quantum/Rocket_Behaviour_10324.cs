// Namespace: Quantum
[Serializable]
public class Rocket_Behaviour : StateBehaviour // TypeDefIndex: 10324
{
	// Fields
	public FP InitialInterpolationSpeed; // 0x60
	public FP InterpolationSpeedIncrease; // 0x68
	public FP InitialSpeed; // 0x70
	public FP TargetVerticalOffset; // 0x78
	public int FramesForNewTargetCheck; // 0x80

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21769C0 Offset: 0x2174FC0 VA: 0x1821769C0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2176E00 Offset: 0x2175400 VA: 0x182176E00 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21766C0 Offset: 0x2174CC0 VA: 0x1821766C0
	private void FindTarget(Frame frame, CachedEntityData rocketEntityData, Rocket* rocket, int currentFrame) { }

	// RVA: 0x21771B0 Offset: 0x21757B0 VA: 0x1821771B0
	public void .ctor() { }
}
