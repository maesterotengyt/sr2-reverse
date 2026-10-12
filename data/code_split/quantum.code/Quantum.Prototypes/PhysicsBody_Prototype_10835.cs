// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsBody))]
[Serializable]
public sealed class PhysicsBody_Prototype : ComponentPrototype<PhysicsBody> // TypeDefIndex: 10835
{
	// Fields
	public QBoolean Active; // 0x18
	public MapEntityId Entity; // 0x1C
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
	public MapEntityId GroundEntity; // 0xC0
	[HideInInspector]
	public FPVector2 GroundNormal; // 0xC8
	[HideInInspector]
	public int GroundLayerIndex; // 0xD8
	[HideInInspector]
	public FPVector2 PreviousGroundNormal; // 0xE0
	[HideInInspector]
	public MapEntityId CeilingEntity; // 0xF0
	[HideInInspector]
	public FPVector2 CeilingNormal; // 0xF8
	[HideInInspector]
	public int CeilingLayerIndex; // 0x108
	[HideInInspector]
	public MapEntityId LeftWallEntity; // 0x10C
	[HideInInspector]
	public FPVector2 LeftWallNormal; // 0x110
	[HideInInspector]
	public int LeftWallLayerIndex; // 0x120
	[HideInInspector]
	public MapEntityId RightWallEntity; // 0x124
	[HideInInspector]
	public FPVector2 RightWallNormal; // 0x128
	[HideInInspector]
	public int RightWallLayerIndex; // 0x138
	[HideInInspector]
	public FPVector2 BounceNormal; // 0x140
	[HideInInspector]
	public FP FramesInAir; // 0x150
	[HideInInspector]
	public QBoolean InBlastzone; // 0x158
	[HideInInspector]
	public QBoolean SnapToWall; // 0x15C
	[HideInInspector]
	public FPVector2 InitialWallSnapPoint; // 0x160
	[HideInInspector]
	public WallSnapDirection_Prototype InitialWallSnapDirection; // 0x170
	[HideInInspector]
	public QBoolean ForceSnapToGround; // 0x174
	[HideInInspector]
	public QBoolean CanLeaveEdges; // 0x178
	[HideInInspector]
	public QBoolean CanFallThrough; // 0x17C
	[HideInInspector]
	public QBoolean IgnoreThinPlatforms; // 0x180
	[HideInInspector]
	public FP IgnoreThinPlatformFrames; // 0x188
	[HideInInspector]
	public QBoolean DetectBlastzones; // 0x190
	[HideInInspector]
	public QBoolean DetectTopBlastzone; // 0x194
	[HideInInspector]
	public AssetRefApplyImpulse_Behaviour CurrentImpulseBehaviour; // 0x198
	[HideInInspector]
	public FP ImpulseFrames; // 0x1A0
	[HideInInspector]
	public FPVector2 ReferenceLeftStick; // 0x1A8
	public QBoolean SlideOnCeiling; // 0x1B8
	public QBoolean SlideOnGround; // 0x1BC
	public QBoolean SlideOnWalls; // 0x1C0
	public SlideDirection_Prototype CeilingSlideDirection; // 0x1C4
	public SlideDirection_Prototype WallSlideDirection; // 0x1C8

	// Methods

	// RVA: 0x210AA30 Offset: 0x2109030 VA: 0x18210AA30 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210AD00 Offset: 0x2109300 VA: 0x18210AD00
	public void Materialize(Frame frame, ref PhysicsBody result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210AC70 Offset: 0x2109270 VA: 0x18210AC70 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210B240 Offset: 0x2109840 VA: 0x18210B240
	public void .ctor() { }
}
