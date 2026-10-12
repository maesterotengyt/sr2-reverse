// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PhysicsBody))]
[Serializable]
public class PhysicsBody_Prototype : PrototypeAdapter<PhysicsBody_Prototype> // TypeDefIndex: 3914
{
	// Fields
	public QBoolean Active; // 0x10
	[LocalReference]
	public EntityPrototype Entity; // 0x18
	public AssetRefPhysicsData DefaultPhysicsData; // 0x20
	[HideInInspector]
	public QBoolean CanEnterGroundedState; // 0x28
	[HideInInspector]
	public QBoolean SetGroundedOnlyWhenGoingDown; // 0x2C
	[HideInInspector]
	public QBoolean CorrectionEnabled; // 0x30
	[HideInInspector]
	public QBoolean BounceEnabled; // 0x34
	[HideInInspector]
	public EnvironmentCollisionBox_Prototype ECB; // 0x38
	[HideInInspector]
	public RuntimePhysics_Prototype RuntimePhysics; // 0x40
	[HideInInspector]
	public FPVector2 TargetVelocity; // 0x48
	[HideInInspector]
	public FPVector2 Velocity; // 0x58
	[HideInInspector]
	public FPVector2 KnockbackVelocity; // 0x68
	[HideInInspector]
	public FPVector2 ImpulseVelocity; // 0x78
	[HideInInspector]
	public FPVector2 ExternalVelocity; // 0x88
	[HideInInspector]
	public FPVector2 GlobalVelocity; // 0x98
	[HideInInspector]
	public QBoolean CapKnockbackVelocity; // 0xA8
	[HideInInspector]
	public QBoolean Grounded; // 0xAC
	[HideInInspector]
	public QBoolean OnFloor; // 0xB0
	[HideInInspector]
	public QBoolean OnCeiling; // 0xB4
	[HideInInspector]
	public QBoolean OnLeftWall; // 0xB8
	[HideInInspector]
	public QBoolean OnRightWall; // 0xBC
	[HideInInspector]
	[LocalReference]
	public EntityPrototype GroundEntity; // 0xC0
	[HideInInspector]
	public FPVector2 GroundNormal; // 0xC8
	[HideInInspector]
	public int GroundLayerIndex; // 0xD8
	[HideInInspector]
	public FPVector2 PreviousGroundNormal; // 0xE0
	[HideInInspector]
	[LocalReference]
	public EntityPrototype CeilingEntity; // 0xF0
	[HideInInspector]
	public FPVector2 CeilingNormal; // 0xF8
	[HideInInspector]
	public int CeilingLayerIndex; // 0x108
	[HideInInspector]
	[LocalReference]
	public EntityPrototype LeftWallEntity; // 0x110
	[HideInInspector]
	public FPVector2 LeftWallNormal; // 0x118
	[HideInInspector]
	public int LeftWallLayerIndex; // 0x128
	[HideInInspector]
	[LocalReference]
	public EntityPrototype RightWallEntity; // 0x130
	[HideInInspector]
	public FPVector2 RightWallNormal; // 0x138
	[HideInInspector]
	public int RightWallLayerIndex; // 0x148
	[HideInInspector]
	public FPVector2 BounceNormal; // 0x150
	[HideInInspector]
	public FP FramesInAir; // 0x160
	[HideInInspector]
	public QBoolean InBlastzone; // 0x168
	[HideInInspector]
	public QBoolean SnapToWall; // 0x16C
	[HideInInspector]
	public FPVector2 InitialWallSnapPoint; // 0x170
	[HideInInspector]
	public WallSnapDirection_Prototype InitialWallSnapDirection; // 0x180
	[HideInInspector]
	public QBoolean ForceSnapToGround; // 0x184
	[HideInInspector]
	public QBoolean CanLeaveEdges; // 0x188
	[HideInInspector]
	public QBoolean CanFallThrough; // 0x18C
	[HideInInspector]
	public QBoolean IgnoreThinPlatforms; // 0x190
	[HideInInspector]
	public FP IgnoreThinPlatformFrames; // 0x198
	[HideInInspector]
	public QBoolean DetectBlastzones; // 0x1A0
	[HideInInspector]
	public QBoolean DetectTopBlastzone; // 0x1A4
	[HideInInspector]
	public AssetRefApplyImpulse_Behaviour CurrentImpulseBehaviour; // 0x1A8
	[HideInInspector]
	public FP ImpulseFrames; // 0x1B0
	[HideInInspector]
	public FPVector2 ReferenceLeftStick; // 0x1B8
	public QBoolean SlideOnCeiling; // 0x1C8
	public QBoolean SlideOnGround; // 0x1CC
	public QBoolean SlideOnWalls; // 0x1D0
	public SlideDirection_Prototype CeilingSlideDirection; // 0x1D4
	public SlideDirection_Prototype WallSlideDirection; // 0x1D8

	// Methods

	// RVA: 0x67C0F0 Offset: 0x67A6F0 VA: 0x18067C0F0 Slot: 5
	public sealed override PhysicsBody_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x67C430 Offset: 0x67AA30 VA: 0x18067C430
	public void .ctor() { }
}
