// Namespace: Quantum
[Serializable]
public class WallSlide_Behaviour : StateBehaviour // TypeDefIndex: 10610
{
	// Fields
	[Space(10)]
	public ChangeStateEvent IdleAirState; // 0x60
	public ExecuteGroupEvent OnLeaveWallGroup; // 0x78
	[Space(10)]
	public FP FallSpeed; // 0x90
	public FP BrakeFallSpeed; // 0x98
	public bool LeaveWallWithStickMove; // 0xA0
	[DrawIf("LeaveWallWithStickMove", 1, 0, 3)]
	public FP StickValueToLeaveWall; // 0xA8

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20FBBE0 Offset: 0x20FA1E0 VA: 0x1820FBBE0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20FBD30 Offset: 0x20FA330 VA: 0x1820FBD30 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20FBDC0 Offset: 0x20FA3C0 VA: 0x1820FBDC0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20FC1A0 Offset: 0x20FA7A0 VA: 0x1820FC1A0
	public void .ctor() { }
}
