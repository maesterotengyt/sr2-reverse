// Namespace: Quantum
[Serializable]
public class PhysicsData : AssetObject // TypeDefIndex: 10193
{
	// Fields
	public ECBPreset[] ECBPresets; // 0x20
	[Header("Air Control")]
	[Tooltip("Entity's gravity")]
	public FP Gravity; // 0x28
	[Tooltip("Max vertical speed while falling")]
	public FP FallSpeed; // 0x30
	[Tooltip("Max horizontal speed in air")]
	public FP AirSpeed; // 0x38
	[Tooltip("How fast will reach the max speed on air")]
	public FP AirAcceleration; // 0x40
	[Tooltip("How fast will stop horizontal movement when no forces are applied on the air")]
	public FP AirFriction; // 0x48
	[Tooltip("Min speed to apply air extra friction")]
	public FP AirExtraFrictionThresholdMax; // 0x50
	[Tooltip("Max speed to apply air extra friction")]
	public FP AirExtraFrictionThresholdMin; // 0x58
	[Tooltip("Air extra friction multiplier")]
	public FP AirExtraFrictionFactor; // 0x60
	[Header("Ground Control")]
	[Tooltip("Max horizontal speed while walking slow")]
	public FP WalkSlowSpeed; // 0x68
	[Tooltip("Max horizontal speed while walking fast")]
	public FP WalkFastSpeed; // 0x70
	[Tooltip("Max horizontal speed while running")]
	public FP RunSpeed; // 0x78
	[Tooltip("How fast will reach the max speed on the ground")]
	public FP GroundAcceleration; // 0x80
	[Tooltip("How fast will stop horizontal movement when no forces are applied on the ground")]
	public FP GroundFriction; // 0x88
	[Tooltip("Min speed to apply ground extra friction")]
	public FP GroundExtraFrictionThresholdMax; // 0x90
	[Tooltip("Max speed to apply ground extra friction")]
	public FP GroundExtraFrictionThresholdMin; // 0x98
	[Tooltip("Ground extra friction multiplier")]
	public FP GroundExtraFrictionFactor; // 0xA0
	[Header("Surface Detection")]
	[Tooltip("Minimum surface normal to detect a wall")]
	public FP MinWallNormal; // 0xA8
	[Tooltip("Minimum surface normal to detect the ground")]
	public FP MinSlopeNormal; // 0xB0
	[Header("Crowd Push")]
	[Tooltip("Distance to push other physics bodies")]
	public FP CrowdPushRadius; // 0xB8
	[Tooltip("Max force to be applied when crowd pushing")]
	public FP CrowdPushMaxForce; // 0xC0
	[Tooltip("Min force to be applied when crowd pushing")]
	public FP CrowdPushMinForce; // 0xC8
	[Header("Thin Platform Settings")]
	[Tooltip("If true the thin platforms will be ignored")]
	public bool IgnoreThinPlatformCompletely; // 0xD0
	[DrawIf("IgnoreThinPlatformCompletely", 0, 0, 3)]
	[Tooltip("The body will be placed over the thin floor if the thin platform is located between the feet and center of gravity of the body, this is a multiplier to be applied to the center of gravity")]
	public FP MinDistanceToStandOnThinPlatform; // 0xD8
	[Header("Others")]
	[Tooltip("How fast the entity will brake when is in a knockback state")]
	public FP KnockbackDecay; // 0xE0
	[Tooltip("How much the entity will bounce against surfaces")]
	public FP Restitution; // 0xE8
	[Tooltip("Minimum distance required to perform a bounce")]
	public FP MinMagnitudeForBounce; // 0xF0
	[Header("Hit Stun")]
	[Tooltip("Gravity applied during the Hit Stun state")]
	public FP HitStunGravity; // 0xF8
	[Tooltip("Fall Speed used during the Hit Stun state")]
	public FP HitStunFallSpeed; // 0x100
	[Tooltip("Air Friction applied during the Hit Stun state")]
	public FP HitStunAirFriction; // 0x108
	[Tooltip("Ground Friction applied during the Hit Stun state")]
	public FP HitStunGroundFriction; // 0x110
	[Header("Events")]
	public StateNotificationMode OnTouchFloorNotificationMode; // 0x118
	[DrawIf("OnTouchFloorNotificationMode", 0, 1, 3)]
	public HashString OnTouchFloorState; // 0x120
	public StateNotificationMode OnLeaveFloorNotificationMode; // 0x130
	[DrawIf("OnLeaveFloorNotificationMode", 0, 1, 3)]
	public HashString OnLeaveFloorState; // 0x138
	public StateNotificationMode OnTouchLeftWallNotificationMode; // 0x148
	[DrawIf("OnTouchLeftWallNotificationMode", 0, 1, 3)]
	public HashString OnTouchLeftWallState; // 0x150
	public StateNotificationMode OnTouchRightWallNotificationMode; // 0x160
	[DrawIf("OnTouchRightWallNotificationMode", 0, 1, 3)]
	public HashString OnTouchRightWallState; // 0x168
	public StateNotificationMode OnTouchCeilingNotificationMode; // 0x178
	[DrawIf("OnTouchCeilingNotificationMode", 0, 1, 3)]
	public HashString OnTouchCeilingState; // 0x180
	public StateNotificationMode OnEnterBlastzoneNotificationMode; // 0x190
	[DrawIf("OnEnterBlastzoneNotificationMode", 0, 1, 3)]
	public HashString OnEnterBlastzoneState; // 0x198

	// Methods

	// RVA: 0x2153E20 Offset: 0x2152420 VA: 0x182153E20
	public bool TryGetECBPreset(int identifier, out ECBPreset preset) { }

	// RVA: 0x2153EC0 Offset: 0x21524C0 VA: 0x182153EC0
	public void .ctor() { }
}
