// Namespace: Quantum
public class PhysicsUtils // TypeDefIndex: 10693
{
	// Methods

	// RVA: 0x210C010 Offset: 0x210A610 VA: 0x18210C010
	public static int LayerFromIndex(int layerIndex) { }

	// RVA: 0x210C020 Offset: 0x210A620 VA: 0x18210C020
	public static int LayerMaskFromCollisionLayersGroup(CollisionLayer[] layersGroup) { }

	// RVA: 0x210BE30 Offset: 0x210A430 VA: 0x18210BE30
	public static bool IsLayerIndexInCollisionLayersGroup(int layerIndex, CollisionLayer[] layersGroup) { }

	// RVA: 0x210BEB0 Offset: 0x210A4B0 VA: 0x18210BEB0
	public static bool IsThinPlatformLayer(Frame frame, int layerIndex) { }

	// RVA: 0x210BC90 Offset: 0x210A290 VA: 0x18210BC90
	public static int GetFloorLayerMask(Frame frame, bool ignoreThinPlatforms) { }

	// RVA: 0x210BC10 Offset: 0x210A210 VA: 0x18210BC10
	public static int GetDefaultLayerMask(Frame frame) { }

	// RVA: 0x210C090 Offset: 0x210A690 VA: 0x18210C090
	public static bool LinecastIntersectsSurface(FPVector2 hitPoint, FPVector2 endPoint, FPVector2 surfaceNormal) { }

	// RVA: 0x210BF50 Offset: 0x210A550 VA: 0x18210BF50
	public static bool IsValidGround(FPVector2 groundNormal, PhysicsData physicsData) { }

	// RVA: 0x210BD90 Offset: 0x210A390 VA: 0x18210BD90
	public static bool IsGoingDownSlope(FP xVelocitySign, FPVector2 groundNormal) { }

	// RVA: 0x210BDE0 Offset: 0x210A3E0 VA: 0x18210BDE0
	public static bool IsGoingUpSlope(FP xVelocitySign, FPVector2 groundNormal) { }

	// RVA: 0x210BFA0 Offset: 0x210A5A0 VA: 0x18210BFA0
	public static bool IsValidWall(FPVector2 wallNormal, PhysicsData physicsData, bool WallJumpCheck = False) { }

	// RVA: 0x210BF80 Offset: 0x210A580 VA: 0x18210BF80
	public static bool IsValidWall(FPVector2 wallNormal, FP minWallNormal) { }

	// RVA: 0x210BAF0 Offset: 0x210A0F0 VA: 0x18210BAF0
	public static FPVector2 CalculateSurfaceSlideVector(FPVector2 surfaceNormal, FPVector2 slideDirection) { }

	// RVA: 0x210C3B0 Offset: 0x210A9B0 VA: 0x18210C3B0
	public static bool TryGetCollisionLayer(Frame frame, EntityRef entity, out int layer) { }

	// RVA: 0x210C210 Offset: 0x210A810 VA: 0x18210C210
	public static bool TryGetCollisionLayer(Frame frame, Nullable<Hit> hit, out int layer) { }

	// RVA: 0x210C400 Offset: 0x210AA00 VA: 0x18210C400
	public static bool TryGetPhysicsMaterial(Frame frame, EntityRef entity, out AssetRefPhysicsMaterial physicsMaterial) { }

	// RVA: 0x210C1E0 Offset: 0x210A7E0 VA: 0x18210C1E0
	public static FPVector2 RelativeMovement(FPVector2 currentPosition, FPVector2 previousPosition) { }

	// RVA: 0x210BB80 Offset: 0x210A180 VA: 0x18210BB80
	public static bool CirclesIntersect(FPVector2 centerA, FP radiusA, FPVector2 centerB, FP radiusB) { }

	// RVA: 0x210C0F0 Offset: 0x210A6F0 VA: 0x18210C0F0
	public static bool PointInPolygon(FPVector2 point, FPVector2[] vertices) { }

	// RVA: 0x210BBC0 Offset: 0x210A1C0 VA: 0x18210BBC0
	public static FP GetCombinedPhysicsValue(FP physicsValueA, FP physicsValueB, PhysicsCombineFunction combineFunction) { }
}
