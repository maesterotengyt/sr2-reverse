// Namespace: Quantum
[Serializable]
public class GameEntityData : AssetObject // TypeDefIndex: 10190
{
	// Fields
	[Header("General Settings")]
	public HashString EntityName; // 0x20
	public GameEntityType EntityType; // 0x30
	public AssetRefEntityPrototype[] EntityPrototypeCostumes; // 0x38
	public FPVector2 RotationPivot; // 0x40
	[Header("Entity Modifier")]
	public bool HasEntityModifier; // 0x50
	[Header("State Machine")]
	public bool HasStateMachine; // 0x51
	[DrawIf("HasStateMachine", 1, 0, 3)]
	public AssetRefStateMachineData StateMachineData; // 0x58
	[Header("Custom Animator")]
	public bool HasCustomAnimator; // 0x60
	[DrawIf("HasCustomAnimator", 1, 0, 3)]
	public AssetRefAnimationsPoolData AnimationsPoolData; // 0x68
	[DrawIf("HasCustomAnimator", 1, 0, 3)]
	public AssetRefAnimationBakedJointsData BakedJointsData; // 0x70
	[Header("Combat")]
	public bool HasCombat; // 0x78
	[DrawIf("HasCombat", 1, 0, 3)]
	public AssetRefCombatData CombatData; // 0x80
	[Header("Grab")]
	public bool HasGrab; // 0x88
	[DrawIf("HasGrab", 1, 0, 3)]
	public AssetRefGrabData GrabData; // 0x90
	[Header("Physics")]
	public bool HasPhysicsBody; // 0x98
	[DrawIf("HasPhysicsBody", 1, 0, 3)]
	public AssetRefPhysicsData PhysicsData; // 0xA0
	[Header("Edge Grab")]
	public bool HasEdgeGrab; // 0xA8
	[DrawIf("HasEdgeGrab", 1, 0, 3)]
	public FPVector2 EdgeHook; // 0xB0
	[DrawIf("HasEdgeGrab", 1, 0, 3)]
	public SimpleAABB EdgeGrabBox; // 0xC0
	[DrawIf("HasEdgeGrab", 1, 0, 3)]
	public int FramesToIgnoreEdgeGrab; // 0xE0
	[DrawIf("HasEdgeGrab", 1, 0, 3)]
	public int EdgeGrabCooldownFrames; // 0xE4
	[DrawIf("HasEdgeGrab", 1, 0, 3)]
	public StateNotificationMode EdgeGrabNotificationMode; // 0xE8
	[DrawIf("EdgeGrabNotificationMode", 0, 1, 3)]
	[DrawIf("HasEdgeGrab", 1, 0, 3)]
	public HashString EdgeGrabState; // 0xF0
	[Header("Jumps")]
	public bool HasJumps; // 0x100
	[DrawIf("HasJumps", 1, 0, 3)]
	public AssetRefJumpSettingsData JumpSettings; // 0x108
	[Header("Moveset Limits")]
	public bool HasMovesetLimiter; // 0x110
	[DrawIf("HasMovesetLimiter", 1, 0, 3)]
	public AssetRefMovesetLimiterData MovesetLimiterData; // 0x118

	// Methods

	// RVA: 0x2153870 Offset: 0x2151E70 VA: 0x182153870
	public EntityRef Spawn(Frame frame, int costumeIndex = 0) { }

	// RVA: 0x2152B50 Offset: 0x2151150 VA: 0x182152B50
	public void Initialize(Frame frame, EntityRef entity) { }

	// RVA: 0x2152B00 Offset: 0x2151100 VA: 0x182152B00
	private AssetRefEntityPrototype GetEntityPrototypeCostume(int index) { }

	// RVA: 0x21538D0 Offset: 0x2151ED0 VA: 0x1821538D0
	public void .ctor() { }
}
