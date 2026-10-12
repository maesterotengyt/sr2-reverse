// Namespace: Quantum
[Serializable]
public class SpeedRunnersWallSlide_Behaviour : StateBehaviour // TypeDefIndex: 10339
{
	// Fields
	public FP MinWallNormal; // 0x60
	[Space(10)]
	public ChangeStateEvent IdleAirState; // 0x68
	public ExecuteGroupEvent OnLeaveWallGroup; // 0x80
	public CollisionLayer[] WallLayers; // 0x98

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2194EF0 Offset: 0x21934F0 VA: 0x182194EF0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2195780 Offset: 0x2193D80 VA: 0x182195780 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2195860 Offset: 0x2193E60 VA: 0x182195860 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2195EE0 Offset: 0x21944E0 VA: 0x182195EE0
	public void .ctor() { }
}
