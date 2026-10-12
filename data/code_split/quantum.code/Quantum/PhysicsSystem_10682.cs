// Namespace: Quantum
public class PhysicsSystem : SystemMainThread // TypeDefIndex: 10682
{
	// Fields
	public static readonly FP DefaultMaxVelocity; // 0x0
	public static readonly FP ECBLinecastStartOffset; // 0x8
	public static readonly FP ECBHorizontalDetectionOffset; // 0x10
	public static readonly FPVector2 MinECBSize; // 0x18
	public static readonly FP MinCollisionDistance; // 0x28
	public static readonly FP PerpendicularCollisionCrossValue; // 0x30

	// Methods

	// RVA: 0x20F6D10 Offset: 0x20F5310 VA: 0x1820F6D10 Slot: 10
	public override void Update(Frame frame) { }

	// RVA: 0x20F29E0 Offset: 0x20F0FE0 VA: 0x1820F29E0
	private void MoveAndCollide(Frame frame, FP deltaTime, EntityRef entity, GameEntity* gameEntity, PhysicsBody* physicsBody, Transform2D* transform, bool canApplyMovement, FP velocityMultiplier) { }

	// RVA: 0x20F6500 Offset: 0x20F4B00 VA: 0x1820F6500
	public static void TeleportEntity(Frame frame, EntityRef entity, FPVector2 newPosition, bool clearRelativeMovement = True) { }

	// RVA: 0x20F5950 Offset: 0x20F3F50 VA: 0x1820F5950
	public static void MoveEntity(Frame frame, EntityRef entity, FPVector2 newPosition, FPVector2 referencePoint, bool ignoreThinPlatforms = True) { }

	// RVA: 0x20F0AB0 Offset: 0x20EF0B0 VA: 0x1820F0AB0
	public static LinecastHitInfo ComplexLinecast(Frame frame, EntityRef entity, FPVector2 startPoint, FPVector2 endPoint, FPVector2 referencePoint, int layerMask, bool predictThinPlatformCorrection = False, PhysicsBody* physicsBody, Transform2D* transform) { }

	// RVA: 0x20F2720 Offset: 0x20F0D20 VA: 0x1820F2720
	private bool IsOnLedge(Frame frame, FP deltaTime, EntityRef entity, Transform2D* transform, FPVector2 frameVelocity, FPVector2 groundNormal, PhysicsData physicsData, int floorLayerMask) { }

	// RVA: 0x20F5CA0 Offset: 0x20F42A0 VA: 0x1820F5CA0
	private void MoveToClosestLedge(Frame frame, FP deltaTime, EntityRef entity, Transform2D* transform, FPVector2 frameVelocity, FPVector2 groundNormal, PhysicsData physicsData, int floorLayerMask) { }

	// RVA: 0x20EF790 Offset: 0x20EDD90 VA: 0x1820EF790
	private LinecastHitInfo CheckCollisionFromCenter(Frame frame, FP deltaTime, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 frameVelocity, int layerMask, bool predictThinPlatformCorrection) { }

	// RVA: 0x20F0370 Offset: 0x20EE970 VA: 0x1820F0370
	private LinecastHitInfo CheckFloorCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask) { }

	// RVA: 0x20EF490 Offset: 0x20EDA90 VA: 0x1820EF490
	private LinecastHitInfo CheckCeilingCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask) { }

	// RVA: 0x20F06B0 Offset: 0x20EECB0 VA: 0x1820F06B0
	private LinecastHitInfo CheckLeftWallCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask) { }

	// RVA: 0x20F08B0 Offset: 0x20EEEB0 VA: 0x1820F08B0
	private LinecastHitInfo CheckRightWallCollision(Frame frame, EntityRef entity, PhysicsBody* physicsBody, Transform2D* transform, FPVector2 startPoint, FPVector2 endPoint, int layerMask) { }

	// RVA: 0x20F87F0 Offset: 0x20F6DF0 VA: 0x1820F87F0
	private void WallJumpChecks(Frame frame, EntityRef entity, PhysicsData physicsData, PhysicsBody* physicsBody, Jump* jump, Transform2D* transform, int facingDirection, int defaultLayerMask) { }

	// RVA: 0x20EF9F0 Offset: 0x20EDFF0 VA: 0x1820EF9F0
	private void CheckEdgeGrabs(Frame frame, List<PhysicsBodyEntity> activeBodies) { }

	// RVA: 0x20F6020 Offset: 0x20F4620 VA: 0x1820F6020
	private bool SimpleEdgeCheck(Frame frame, PhysicsBodyEntity bodyEntity, EdgeGrab* edgeGrab, FP leftStickXValue, FP framesToIgnoreEdge, out EdgeGrabRequest edgeGrabRequest) { }

	// RVA: 0x20F1270 Offset: 0x20EF870 VA: 0x1820F1270
	private bool InterpolatedEdgeCheck(Frame frame, PhysicsBodyEntity bodyEntity, EdgeGrab* edgeGrab, FP leftStickXValue, FP framesToIgnoreEdge, out EdgeGrabRequest edgeGrabRequest) { }

	// RVA: 0x20F67C0 Offset: 0x20F4DC0 VA: 0x1820F67C0
	private void UpdateCrowdPush(Frame frame, List<PhysicsBodyEntity> activeBodies) { }

	// RVA: 0x20F6B30 Offset: 0x20F5130 VA: 0x1820F6B30
	private void UpdateTriggers(Frame frame, List<PhysicsBodyEntity> activeBodies) { }

	// RVA: 0x20F65B0 Offset: 0x20F4BB0 VA: 0x1820F65B0
	private void UpdateBlastzones(Frame frame, List<PhysicsBodyEntity> activeBodies, FPVector2 blastzoneTopLeft, FPVector2 blastzoneBottomRight) { }

	// RVA: 0x20EA200 Offset: 0x20E8800 VA: 0x1820EA200
	public void .ctor() { }

	// RVA: 0x20F8B80 Offset: 0x20F7180 VA: 0x1820F8B80
	private static void .cctor() { }
}
