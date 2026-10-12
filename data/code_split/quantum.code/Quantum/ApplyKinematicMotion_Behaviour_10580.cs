// Namespace: Quantum
[Serializable]
public class ApplyKinematicMotion_Behaviour : StateBehaviour // TypeDefIndex: 10580
{
	// Fields
	public bool SnapToGround; // 0x60
	public bool PhysicsCorrectionDisabled; // 0x61
	public bool EnablePhysicsCorrectionManually; // 0x62
	[DrawIf("EnableBodyCorrectionManually", 1, 0, 3)]
	public int FrameToEnableCorrection; // 0x64

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B0700 Offset: 0x21AED00 VA: 0x1821B0700 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B0760 Offset: 0x21AED60 VA: 0x1821B0760 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B07E0 Offset: 0x21AEDE0 VA: 0x1821B07E0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B0480 Offset: 0x21AEA80 VA: 0x1821B0480
	private void ApplyKinematicMotion(Frame frame, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
