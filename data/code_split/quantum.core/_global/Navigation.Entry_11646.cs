// Namespace: 
internal struct Navigation.Entry // TypeDefIndex: 11646
{
	// Fields
	public EntityRef Entity; // 0x0
	public FPVector3 Position; // 0x8
	public FP Rotation; // 0x20
	public int EntryIndex; // 0x28
	public NavMeshPathfinder* PathfinderAgent; // 0x30
	public NavMeshAvoidanceAgent* AvoidanceAgent; // 0x38
	public NavMeshAvoidanceObstacle* AvoidanceObstacle; // 0x40
	public NavMeshSteeringAgent* SteeringAgent; // 0x48
	public Transform2D* Transform2D; // 0x50
	public Transform3D* Transform3D; // 0x58
	public PhysicsBody2D* PhysicsBody2D; // 0x60
	public PhysicsBody3D* PhysicsBody3D; // 0x68
	public CharacterController3D* KCC3D; // 0x70
	private byte _flags; // 0x78
	public NavMeshRegionMask RegionMask; // 0x80
	public FPVector3 CurrentWaypoint; // 0x88
	public int AvoidanceRadius; // 0xA0
	public Navigation.VelocityObstacle* VoStart; // 0xA8
	public FPVector2 DesiredVelocity; // 0xB0
	public FPVector2 DesiredDirection; // 0xC0
	public FP DesiredSpeed; // 0xD0

	// Properties
	public Navigation.Entry.AgentFlags Flags { get; set; }
	public int AvoidanceMask { get; }
	public int AvoidanceLayer { get; }
	public bool IsActive { get; }

	// Methods

	// RVA: 0x5BAA00 Offset: 0x5B9000 VA: 0x1805BAA00
	public Navigation.Entry.AgentFlags get_Flags() { }

	// RVA: 0x5BAB60 Offset: 0x5B9160 VA: 0x1805BAB60
	public void set_Flags(Navigation.Entry.AgentFlags value) { }

	// RVA: 0x21DC440 Offset: 0x21DAA40 VA: 0x1821DC440
	public NavMeshAgentConfig TryGetConfig(FrameBase f) { }

	// RVA: 0x21DC510 Offset: 0x21DAB10 VA: 0x1821DC510
	public int get_AvoidanceMask() { }

	// RVA: 0x21DC4E0 Offset: 0x21DAAE0 VA: 0x1821DC4E0
	public int get_AvoidanceLayer() { }

	// RVA: 0x21DC530 Offset: 0x21DAB30 VA: 0x1821DC530
	public bool get_IsActive() { }

	// RVA: 0x21DC3D0 Offset: 0x21DA9D0 VA: 0x1821DC3D0
	public void ClearEntityPhysics() { }
}
