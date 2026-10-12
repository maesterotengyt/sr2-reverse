// Namespace: Quantum
public struct Jump : IComponent // TypeDefIndex: 10004
{
	// Fields
	[HideInInspector]
	public JumpType ActiveJump; // 0x4
	[HideInInspector]
	public QBoolean DoShortJump; // 0x8
	public EntityRef Entity; // 0x20
	[HideInInspector]
	public int JumpAnticipationFrames; // 0x0
	public AssetRefJumpSettingsData JumpData; // 0x18
	[HideInInspector]
	public FP JumpImpulseFrames; // 0x28
	[HideInInspector]
	public FPVector2 JumpImpulseVelocity; // 0x30
	[HideInInspector]
	public QBoolean OnWallSlide; // 0xC
	[HideInInspector]
	public FPVector2 ReferenceLeftStick; // 0x40
	[HideInInspector]
	public QBoolean TouchingBackWall; // 0x10
	[HideInInspector]
	public QBoolean TouchingFrontWall; // 0x14

	// Methods

	// RVA: 0x211F460 Offset: 0x211DA60 VA: 0x18211F460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211F5B0 Offset: 0x211DBB0 VA: 0x18211F5B0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x211F500 Offset: 0x211DB00 VA: 0x18211F500
	public void Reset(Frame frame) { }

	// RVA: 0x211F350 Offset: 0x211D950 VA: 0x18211F350
	public FP GetGravityMultiplier(Frame frame) { }

	// RVA: 0x211F6D0 Offset: 0x211DCD0 VA: 0x18211F6D0
	public void StartJump(Frame frame, CachedEntityData entityData, JumpType jumpType) { }

	// RVA: 0x211FD50 Offset: 0x211E350 VA: 0x18211FD50
	public void UpdateJump(Frame frame, CachedEntityData entityData, FP velocityMultiplier) { }

	// RVA: 0x211FB20 Offset: 0x211E120 VA: 0x18211FB20
	public void StopJump(Frame frame, PhysicsBody* physicsBody, bool preventVelocityInheritance = False) { }
}
