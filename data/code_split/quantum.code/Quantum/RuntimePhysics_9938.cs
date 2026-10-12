// Namespace: Quantum
[Serializable]
public struct RuntimePhysics // TypeDefIndex: 9938
{
	// Fields
	public FP AirAcceleration; // 0x8
	public FP AirExtraFrictionFactor; // 0x10
	public FP AirExtraFrictionThresholdMax; // 0x18
	public FP AirExtraFrictionThresholdMin; // 0x20
	public FP AirFriction; // 0x28
	public FP AirSpeed; // 0x30
	public QBoolean CrowdPushEnabled; // 0x0
	public FP CrowdPushMaxForce; // 0x38
	public FP CrowdPushMinForce; // 0x40
	public FP CrowdPushRadius; // 0x48
	public FP FallSpeed; // 0x50
	public FP FloorRotationInfluence; // 0x58
	public FP FloorRotationSpeed; // 0x60
	public FP Gravity; // 0x68
	public FP GravityMultiplier; // 0x70
	public FP GroundAcceleration; // 0x78
	public FP GroundExtraFrictionFactor; // 0x80
	public FP GroundExtraFrictionThresholdMax; // 0x88
	public FP GroundExtraFrictionThresholdMin; // 0x90
	public FP GroundFriction; // 0x98
	public FP GroundFrictionStep; // 0xA0
	public FP HitStunAirFriction; // 0xA8
	public FP HitStunFallSpeed; // 0xB0
	public FP HitStunGravity; // 0xB8
	public FP HitStunGroundFriction; // 0xC0
	public FP KnockbackDecay; // 0xC8
	public FP RunSpeed; // 0xD0
	public FP TargetGroundFriction; // 0xD8
	public FP WalkFastSpeed; // 0xE0
	public FP WalkSlowSpeed; // 0xE8

	// Methods

	// RVA: 0x20D1E70 Offset: 0x20D0470 VA: 0x1820D1E70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D2090 Offset: 0x20D0690 VA: 0x1820D2090
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D1D50 Offset: 0x20D0350 VA: 0x1820D1D50
	public FP CalculateGravity(Frame frame, EntityRef entity, PhysicsBody* physicsBody, bool hitStunned) { }

	// RVA: 0x20D1900 Offset: 0x20CFF00 VA: 0x1820D1900
	public FP CalculateAcceleration(Frame frame, EntityRef entity, PhysicsBody* physicsBody) { }

	// RVA: 0x20D1A70 Offset: 0x20D0070 VA: 0x1820D1A70
	public FP CalculateDeceleration(Frame frame, EntityRef entity, PhysicsBody* physicsBody, bool hitStunned) { }

	// RVA: 0x20D1D30 Offset: 0x20D0330 VA: 0x1820D1D30
	public FP CalculateFallSpeed(Frame frame, EntityRef entity, PhysicsBody* physicsBody, bool hitStunned) { }

	// RVA: 0x20D1E10 Offset: 0x20D0410 VA: 0x1820D1E10
	public FP CalculateVelocityMultiplier(Frame frame, EntityRef entity, PhysicsBody* physicsBody) { }
}
