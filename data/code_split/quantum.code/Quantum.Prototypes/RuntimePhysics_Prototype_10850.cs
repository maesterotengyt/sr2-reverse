// Namespace: Quantum.Prototypes
[Prototype(typeof(RuntimePhysics))]
[Serializable]
public sealed class RuntimePhysics_Prototype : StructPrototype // TypeDefIndex: 10850
{
	// Fields
	public FP Gravity; // 0x10
	public FP GravityMultiplier; // 0x18
	public FP FallSpeed; // 0x20
	public FP AirSpeed; // 0x28
	public FP AirAcceleration; // 0x30
	public FP AirFriction; // 0x38
	public FP AirExtraFrictionThresholdMax; // 0x40
	public FP AirExtraFrictionThresholdMin; // 0x48
	public FP AirExtraFrictionFactor; // 0x50
	public FP WalkSlowSpeed; // 0x58
	public FP WalkFastSpeed; // 0x60
	public FP RunSpeed; // 0x68
	public FP GroundAcceleration; // 0x70
	public FP GroundFriction; // 0x78
	public FP GroundExtraFrictionThresholdMax; // 0x80
	public FP GroundExtraFrictionThresholdMin; // 0x88
	public FP GroundExtraFrictionFactor; // 0x90
	public FP FloorRotationInfluence; // 0x98
	public FP FloorRotationSpeed; // 0xA0
	public FP KnockbackDecay; // 0xA8
	public FP TargetGroundFriction; // 0xB0
	public FP GroundFrictionStep; // 0xB8
	public QBoolean CrowdPushEnabled; // 0xC0
	public FP CrowdPushRadius; // 0xC8
	public FP CrowdPushMinForce; // 0xD0
	public FP CrowdPushMaxForce; // 0xD8
	public FP HitStunGravity; // 0xE0
	public FP HitStunFallSpeed; // 0xE8
	public FP HitStunGroundFriction; // 0xF0
	public FP HitStunAirFriction; // 0xF8

	// Methods

	// RVA: 0x210DA20 Offset: 0x210C020 VA: 0x18210DA20
	public void Materialize(Frame frame, ref RuntimePhysics result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
