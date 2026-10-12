// Namespace: Quantum
[Serializable]
public class SpeedRunnersDetectWallSlide_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10336
{
	// Fields
	public FP MinWallNormal; // 0x68
	public ChangeStateEvent WallSlideState; // 0x70
	[DrawWithLabel]
	public EntityVariable LinecastHeight; // 0x88
	[DrawWithLabel]
	public EntityVariable LinecastLength; // 0x90
	[Space(10)]
	public CollisionLayer[] DefaultLinecastLayers; // 0x98
	public CollisionLayer[] OnGoingDownLinecastLayers; // 0xA0
	public ColorRGBA DebugColor; // 0xA8

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21799C0 Offset: 0x2177FC0 VA: 0x1821799C0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x217A570 Offset: 0x2178B70 VA: 0x18217A570
	public void .ctor() { }
}
