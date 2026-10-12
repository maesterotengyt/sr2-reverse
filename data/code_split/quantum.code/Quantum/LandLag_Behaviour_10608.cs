// Namespace: Quantum
[Serializable]
public class LandLag_Behaviour : StateBehaviour // TypeDefIndex: 10608
{
	// Fields
	public ExecuteGroupEvent LandLagEndGroup; // 0x60
	public int FrameToExtendAnimation; // 0x78
	[DrawWithLabel]
	public EntityVariable OutLandLagFrames; // 0x80

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20EC120 Offset: 0x20EA720 VA: 0x1820EC120 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20EC440 Offset: 0x20EAA40 VA: 0x1820EC440 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EC6E0 Offset: 0x20EACE0 VA: 0x1820EC6E0
	public void .ctor() { }
}
