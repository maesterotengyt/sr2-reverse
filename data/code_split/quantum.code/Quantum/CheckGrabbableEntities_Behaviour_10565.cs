// Namespace: Quantum
[Serializable]
public class CheckGrabbableEntities_Behaviour : StateBehaviour // TypeDefIndex: 10565
{
	// Fields
	[Header("Pickup")]
	public bool CheckForGrab; // 0x60
	[DrawIf("CheckForGrab", 1, 0, 3)]
	public ChangeStateEvent PickupState; // 0x68
	public bool ChangeState; // 0x80
	[Header("Use")]
	public bool InvertFacingDirection; // 0x81
	public bool ForceStrongThrow; // 0x82
	public bool ForceStrongUse; // 0x83
	public ChangeStateEvent ThrowState; // 0x88
	public ChangeStateEvent SwingState; // 0xA0
	public ChangeStateEvent ShootState; // 0xB8

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B1EF0 Offset: 0x21B04F0 VA: 0x1821B1EF0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B2540 Offset: 0x21B0B40 VA: 0x1821B2540
	public void .ctor() { }
}
