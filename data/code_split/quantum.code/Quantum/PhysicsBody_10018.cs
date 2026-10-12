// Namespace: Quantum
public struct PhysicsBody : IComponent // TypeDefIndex: 10018
{
	// Fields
	public QBoolean Active; // 0x10
	[HideInInspector]
	public QBoolean BounceEnabled; // 0x14
	[HideInInspector]
	public FPVector2 BounceNormal; // 0xC8
	[HideInInspector]
	public QBoolean CanEnterGroundedState; // 0x18
	[HideInInspector]
	public QBoolean CanFallThrough; // 0x1C
	[HideInInspector]
	public QBoolean CanLeaveEdges; // 0x20
	[HideInInspector]
	public QBoolean CapKnockbackVelocity; // 0x24
	[HideInInspector]
	public EntityRef CeilingEntity; // 0x88
	[HideInInspector]
	public int CeilingLayerIndex; // 0x0
	[HideInInspector]
	public FPVector2 CeilingNormal; // 0xD8
	public SlideDirection CeilingSlideDirection; // 0x68
	[HideInInspector]
	public QBoolean CorrectionEnabled; // 0x28
	[HideInInspector]
	public AssetRefApplyImpulse_Behaviour CurrentImpulseBehaviour; // 0x78
	public AssetRefPhysicsData DefaultPhysicsData; // 0x80
	[HideInInspector]
	public QBoolean DetectBlastzones; // 0x2C
	[HideInInspector]
	public QBoolean DetectTopBlastzone; // 0x30
	[HideInInspector]
	public EnvironmentCollisionBox ECB; // 0x1A8
	public EntityRef Entity; // 0x90
	[HideInInspector]
	public FPVector2 ExternalVelocity; // 0xE8
	[HideInInspector]
	public QBoolean ForceSnapToGround; // 0x34
	[HideInInspector]
	public FP FramesInAir; // 0xB0
	[HideInInspector]
	public FPVector2 GlobalVelocity; // 0xF8
	[HideInInspector]
	public EntityRef GroundEntity; // 0x98
	[HideInInspector]
	public int GroundLayerIndex; // 0x4
	[HideInInspector]
	public FPVector2 GroundNormal; // 0x108
	[HideInInspector]
	public QBoolean Grounded; // 0x38
	[HideInInspector]
	public FP IgnoreThinPlatformFrames; // 0xB8
	[HideInInspector]
	public QBoolean IgnoreThinPlatforms; // 0x3C
	[HideInInspector]
	public FP ImpulseFrames; // 0xC0
	[HideInInspector]
	public FPVector2 ImpulseVelocity; // 0x118
	[HideInInspector]
	public QBoolean InBlastzone; // 0x40
	[HideInInspector]
	public WallSnapDirection InitialWallSnapDirection; // 0x70
	[HideInInspector]
	public FPVector2 InitialWallSnapPoint; // 0x128
	[HideInInspector]
	public FPVector2 KnockbackVelocity; // 0x138
	[HideInInspector]
	public EntityRef LeftWallEntity; // 0xA0
	[HideInInspector]
	public int LeftWallLayerIndex; // 0x8
	[HideInInspector]
	public FPVector2 LeftWallNormal; // 0x148
	[HideInInspector]
	public QBoolean OnCeiling; // 0x44
	[HideInInspector]
	public QBoolean OnFloor; // 0x48
	[HideInInspector]
	public QBoolean OnLeftWall; // 0x4C
	[HideInInspector]
	public QBoolean OnRightWall; // 0x50
	[HideInInspector]
	public FPVector2 PreviousGroundNormal; // 0x158
	[HideInInspector]
	public FPVector2 ReferenceLeftStick; // 0x168
	[HideInInspector]
	public EntityRef RightWallEntity; // 0xA8
	[HideInInspector]
	public int RightWallLayerIndex; // 0xC
	[HideInInspector]
	public FPVector2 RightWallNormal; // 0x178
	[HideInInspector]
	public RuntimePhysics RuntimePhysics; // 0x280
	[HideInInspector]
	public QBoolean SetGroundedOnlyWhenGoingDown; // 0x54
	public QBoolean SlideOnCeiling; // 0x58
	public QBoolean SlideOnGround; // 0x5C
	public QBoolean SlideOnWalls; // 0x60
	[HideInInspector]
	public QBoolean SnapToWall; // 0x64
	[HideInInspector]
	public FPVector2 TargetVelocity; // 0x188
	[HideInInspector]
	public FPVector2 Velocity; // 0x198
	public SlideDirection WallSlideDirection; // 0x6C

	// Methods

	// RVA: 0x2122580 Offset: 0x2120B80 VA: 0x182122580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21258B0 Offset: 0x2123EB0 VA: 0x1821258B0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2122990 Offset: 0x2120F90 VA: 0x182122990
	internal FPVector2 GetUnnormalizedSurfaceNormal(Frame frame, FPVector2 surfaceNormal) { }

	// RVA: 0x2123070 Offset: 0x2121670 VA: 0x182123070
	internal void Initialize(Frame frame, EntityRef entity, AssetRefPhysicsData physicsData) { }

	// RVA: 0x2122550 Offset: 0x2120B50 VA: 0x182122550
	internal void Enable() { }

	// RVA: 0x21223C0 Offset: 0x21209C0 VA: 0x1821223C0
	internal void Disable() { }

	// RVA: 0x2123060 Offset: 0x2121660 VA: 0x182123060
	internal FPVector2 GetVelocity() { }

	// RVA: 0x2121E90 Offset: 0x2120490 VA: 0x182121E90
	internal void AddVelocity(Frame frame, FPVector2 velocityToAdd) { }

	// RVA: 0x2121E30 Offset: 0x2120430 VA: 0x182121E30
	internal void AddVelocityX(Frame frame, FP velocityToAdd) { }

	// RVA: 0x2121E40 Offset: 0x2120440 VA: 0x182121E40
	internal void AddVelocityY(Frame frame, FP velocityToAdd) { }

	// RVA: 0x21231B0 Offset: 0x21217B0 VA: 0x1821231B0
	internal void MultiplyVelocity(Frame frame, FP velocityMultiplier) { }

	// RVA: 0x2123130 Offset: 0x2121730 VA: 0x182123130
	internal void MultiplyVelocityX(Frame frame, FP velocityMultiplier) { }

	// RVA: 0x2123150 Offset: 0x2121750 VA: 0x182123150
	internal void MultiplyVelocityY(Frame frame, FP velocityMultiplier) { }

	// RVA: 0x2126770 Offset: 0x2124D70 VA: 0x182126770
	internal void SetVelocity(Frame frame, FPVector2 newVelocity) { }

	// RVA: 0x2126710 Offset: 0x2124D10 VA: 0x182126710
	internal void SetVelocityX(Frame frame, FP newVelocityX) { }

	// RVA: 0x2126720 Offset: 0x2124D20 VA: 0x182126720
	internal void SetVelocityY(Frame frame, FP newVelocityY) { }

	// RVA: 0x2122360 Offset: 0x2120960 VA: 0x182122360
	internal void ClampVelocityX(FP maxVelocity) { }

	// RVA: 0x2122390 Offset: 0x2120990 VA: 0x182122390
	internal void ClampVelocityY(FP maxVelocity) { }

	// RVA: 0x6A39E0 Offset: 0x6A1FE0 VA: 0x1806A39E0
	internal FPVector2 GetKnockbackVelocity() { }

	// RVA: 0x2125FA0 Offset: 0x21245A0 VA: 0x182125FA0
	internal void SetKnockbackVelocity(Frame frame, FPVector2 newKnockbackVelocity) { }

	// RVA: 0x2125F40 Offset: 0x2124540 VA: 0x182125F40
	internal void SetKnockbackVelocityX(Frame frame, FP newVelocityX) { }

	// RVA: 0x2125F50 Offset: 0x2124550 VA: 0x182125F50
	internal void SetKnockbackVelocityY(Frame frame, FP newVelocityY) { }

	// RVA: 0x2122300 Offset: 0x2120900 VA: 0x182122300
	internal void ClampKnockbackVelocityX(FP maxVelocity) { }

	// RVA: 0x2122330 Offset: 0x2120930 VA: 0x182122330
	internal void ClampKnockbackVelocityY(FP maxVelocity) { }

	// RVA: 0x2121E10 Offset: 0x2120410 VA: 0x182121E10
	internal void AddExternalForceX(Frame frame, FP xForce) { }

	// RVA: 0x2121E20 Offset: 0x2120420 VA: 0x182121E20
	internal void AddExternalForceY(Frame frame, FP xForce) { }

	// RVA: 0x21228A0 Offset: 0x2120EA0 VA: 0x1821228A0
	internal FPVector2 GetImpulseVelocity() { }

	// RVA: 0x2122A90 Offset: 0x2121090 VA: 0x182122A90
	internal FP GetValue(Frame frame, PhysicsBodyVariable variable) { }

	// RVA: 0x21260A0 Offset: 0x21246A0 VA: 0x1821260A0
	internal void SetValue(Frame frame, PhysicsBodyVariable variable, FP value) { }

	// RVA: 0x2126BE0 Offset: 0x21251E0 VA: 0x182126BE0
	internal void StartWallSnap(Frame frame, FPVector2 currentPosition) { }

	// RVA: 0x21230E0 Offset: 0x21216E0 VA: 0x1821230E0
	public bool IsOverThinPlatform(Frame frame) { }

	// RVA: 0x2126A40 Offset: 0x2125040 VA: 0x182126A40
	internal void StartLaunch(Frame frame, PhysicsBody* physicsBody, FPVector2 direction) { }

	// RVA: 0x21270A0 Offset: 0x21256A0 VA: 0x1821270A0
	internal bool TryGetFloorSurfaceType(Frame frame, out SurfaceType surfaceType) { }

	// RVA: 0x2121F00 Offset: 0x2120500 VA: 0x182121F00
	internal void Bounce(Frame frame, FP restitution, LinecastHitInfo linecastHitInfo) { }

	// RVA: 0x21267D0 Offset: 0x2124DD0 VA: 0x1821267D0
	internal void StartImpulse(Frame frame, AssetRefApplyImpulse_Behaviour impulseBehaviour, CachedEntityData entityData) { }

	// RVA: 0x2127140 Offset: 0x2125740 VA: 0x182127140
	internal void UpdateImpulse(Frame frame, CachedEntityData entityData, FP velocityMultiplier) { }

	// RVA: 0x2126EE0 Offset: 0x21254E0 VA: 0x182126EE0
	internal void StopImpulse(Frame frame, bool preventVelocityInheritance = False) { }

	// RVA: 0x2127310 Offset: 0x2125910 VA: 0x182127310
	internal void UpdateImpulses(Frame frame, FP velocityMultiplier) { }

	// RVA: 0x2127030 Offset: 0x2125630 VA: 0x182127030
	internal void StopImpulses(Frame frame, PhysicsBody* physicsBody, bool preventVelocityInheritance = False) { }

	// RVA: 0x2123100 Offset: 0x2121700 VA: 0x182123100
	internal void LeaveGround(Frame frame) { }

	// RVA: 0x21274C0 Offset: 0x2125AC0 VA: 0x1821274C0
	internal void UseGroundRotation(Frame frame, GameEntity* gameEntity, bool force = False) { }

	// RVA: 0x2122190 Offset: 0x2120790 VA: 0x182122190
	internal bool CanApplyMovement(Frame frame) { }

	// RVA: 0x2122230 Offset: 0x2120830 VA: 0x182122230
	internal bool CanStandOnThinPlatform(PhysicsData physicsData, Transform2D* transform, FP hitPointY) { }

	// RVA: 0x21228B0 Offset: 0x2120EB0 VA: 0x1821228B0
	public FPVector2 GetTotalVelocity(Frame frame) { }

	// RVA: 0x2125D40 Offset: 0x2124340 VA: 0x182125D40
	internal void SetGroundNormal(Frame frame, FPVector2 normal) { }

	// RVA: 0x2124730 Offset: 0x2122D30 VA: 0x182124730
	private void OnSetGroundNormal(Frame frame, FPVector2 previousNormal) { }

	// RVA: 0x2125D10 Offset: 0x2124310 VA: 0x182125D10
	internal void SetCeilingNormal(Frame frame, FPVector2 normal) { }

	// RVA: 0x2124040 Offset: 0x2122640 VA: 0x182124040
	private void OnSetCeilingNormal(Frame frame, FPVector2 previousNormal) { }

	// RVA: 0x2126000 Offset: 0x2124600 VA: 0x182126000
	internal void SetLeftWallNormal(Frame frame, FPVector2 normal) { }

	// RVA: 0x2124B20 Offset: 0x2123120 VA: 0x182124B20
	private void OnSetLeftWallNormal(Frame frame, FPVector2 previousNormal) { }

	// RVA: 0x2126050 Offset: 0x2124650 VA: 0x182126050
	internal void SetRightWallNormal(Frame frame, FPVector2 normal) { }

	// RVA: 0x2124B70 Offset: 0x2123170 VA: 0x182124B70
	private void OnSetRightWallNormal(Frame frame, FPVector2 previousNormal) { }

	// RVA: 0x2123C80 Offset: 0x2122280 VA: 0x182123C80
	internal void OnLeaveFloor(Frame frame) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnLeaveFloorEvent(Frame frame) { }

	// RVA: 0x2123BC0 Offset: 0x21221C0 VA: 0x182123BC0
	internal void OnLeaveCeiling(Frame frame) { }

	// RVA: 0x2123E50 Offset: 0x2122450 VA: 0x182123E50
	internal void OnLeaveLeftWall(Frame frame) { }

	// RVA: 0x2123F20 Offset: 0x2122520 VA: 0x182123F20
	internal void OnLeaveRightWall(Frame frame) { }

	// RVA: 0x2124E20 Offset: 0x2123420 VA: 0x182124E20
	internal void OnTouchFloor(Frame frame, Transform2D* transform, LinecastHitInfo linecastHitInfo, bool fromBounceFailed = False) { }

	// RVA: 0x2124DB0 Offset: 0x21233B0 VA: 0x182124DB0
	private void OnTouchFloorEvent(Frame frame, Transform2D* transform, LinecastHitInfo linecastHitInfo) { }

	// RVA: 0x21233F0 Offset: 0x21219F0 VA: 0x1821233F0
	private void OnEnterGroundedState(Frame frame) { }

	// RVA: 0x2124BC0 Offset: 0x21231C0 VA: 0x182124BC0
	internal void OnTouchCeiling(Frame frame, LinecastHitInfo linecastHitInfo) { }

	// RVA: 0x2125230 Offset: 0x2123830 VA: 0x182125230
	internal void OnTouchLeftWall(Frame frame, LinecastHitInfo linecastHitInfo) { }

	// RVA: 0x2125420 Offset: 0x2123A20 VA: 0x182125420
	internal void OnTouchRightWall(Frame frame, LinecastHitInfo linecastHitInfo) { }

	// RVA: 0x2123FF0 Offset: 0x21225F0 VA: 0x182123FF0
	internal void OnReachLedge(Frame frame) { }

	// RVA: 0x2123220 Offset: 0x2121820 VA: 0x182123220
	internal void OnEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, bool forced = False) { }

	// RVA: 0x2125670 Offset: 0x2123C70 VA: 0x182125670
	internal void ResetRuntimePhysics(Frame frame) { }

	// RVA: 0x2125610 Offset: 0x2123C10 VA: 0x182125610
	private void ResetGroundVariables(Frame frame) { }
}
