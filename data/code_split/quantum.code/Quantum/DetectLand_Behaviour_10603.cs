// Namespace: Quantum
[Serializable]
public class DetectLand_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10603
{
	// Fields
	public ChangeStateEvent LandState; // 0x68
	[DrawWithLabel]
	public EntityVariable LandLagFrames; // 0x80
	[DrawWithLabel]
	public EntityVariable OutLandLagFrames; // 0x88

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B4440 Offset: 0x21B2A40 VA: 0x1821B4440 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B4440 Offset: 0x21B2A40 VA: 0x1821B4440 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B42D0 Offset: 0x21B28D0 VA: 0x1821B42D0
	private void CheckForGround(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x21B44C0 Offset: 0x21B2AC0 VA: 0x1821B44C0
	public void .ctor() { }
}
