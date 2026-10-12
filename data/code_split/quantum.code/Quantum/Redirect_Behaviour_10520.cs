// Namespace: Quantum
[Serializable]
public class Redirect_Behaviour : StateBehaviour // TypeDefIndex: 10520
{
	// Fields
	[Header("For this Behaviour it is required to have the following variables in the state machine
You can then use the RedirectionSpeed params to apply the velocity calculated here")]
	[DrawWithLabel]
	public EntityVariable Redirections; // 0x60
	[DrawWithLabel]
	public EntityVariable InitialSpeed; // 0x68
	[DrawWithLabel]
	public EntityVariable RedirectionSpeedIncrease; // 0x70
	[DrawWithLabel]
	public EntityVariable MaxSpeed; // 0x78
	[Header("Output Variables")]
	public RedirectionMode RedirectMode; // 0x80
	[DrawWithLabel]
	public EntityVariable OutRedirectedFlag; // 0x88
	[DrawIf("RedirectMode", 0, 0, 3)]
	[DrawWithLabel]
	public EntityVariable OutRedirectionSpeed; // 0x90
	[DrawIf("RedirectMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable OutRedirectionX; // 0x98
	[DrawIf("RedirectMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable OutRedirectionY; // 0xA0

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BCC70 Offset: 0x21BB270 VA: 0x1821BCC70 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
