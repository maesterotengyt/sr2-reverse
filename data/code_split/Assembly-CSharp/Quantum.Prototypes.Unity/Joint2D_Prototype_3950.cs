// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Joint))]
[Serializable]
public class Joint2D_Prototype : PrototypeAdapter<Joint2D_Prototype> // TypeDefIndex: 3950
{
	// Fields
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("If the joint should be materialized with Enabled set to false, not being considered by the Physics Engine.")]
	public bool StartDisabled; // 0x10
	[DisplayName("Type")]
	[Tooltip("The type of the joint, implying which constraints are applied.")]
	public JointType JointType; // 0x12
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("A numerical tag that can be used to identify a joint or a group of joints.")]
	public int UserTag; // 0x14
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("A Map Entity that the joint might be connected to.
The entity must have at least a Transform2D component.")]
	[LocalReference]
	public EntityPrototype ConnectedEntity; // 0x18
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor point to which the joint connects to.
If a Connected Entity is provided, this represents an offset in its local space. Otherwise, the connected anchor is a position in world space.")]
	public FPVector2 ConnectedAnchor; // 0x20
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor offset, in the local space of this joint entity's transform.
This is the point considered for the joint constraints and where the forces will be applied in the joint entity's body.")]
	public FPVector2 Anchor; // 0x30
	[DrawIf("JointType", 2, 0, 3)]
	[Tooltip("The frequency in Hertz (Hz) at which the spring joint will attempt to oscillate.
Typical values are below half the frequency of the simulation.")]
	public FP Frequency; // 0x40
	[Range(0, 2)]
	[DrawIf("JointType", 2, 0, 3)]
	[Tooltip("A dimensionless value representing the damper capacity of suppressing the spring oscillation, typically between 0 and 1.")]
	public FP DampingRatio; // 0x48
	[DrawIf("JointType", 0, 1, 3)]
	[DrawIf("JointType", 3, 1, 3)]
	[Tooltip("Automatically configure the target Distance to be the current distance between the anchor points in the scene.")]
	public bool AutoConfigureDistance; // 0x50
	[DrawIf("JointType", 2, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The distance between the anchor points that the joint will attempt to maintain.")]
	public FP Distance; // 0x58
	[DrawIf("JointType", 1, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The minimum distance between the anchor points that the joint will attempt to maintain.")]
	public FP MinDistance; // 0x60
	[DrawIf("JointType", 1, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The maximum distance between the anchor points that the joint will attempt to maintain.")]
	public FP MaxDistance; // 0x68
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the relative angle between the joint transform and its connected anchor should be limited by the hinge joint.
Set this checkbox to configure the lower and upper limiting angles.")]
	public bool UseAngleLimits; // 0x70
	[Degrees]
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The lower limiting angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	public FP LowerAngle; // 0x78
	[Degrees]
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The upper limiting  angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	public FP UpperAngle; // 0x80
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the hinge joint uses a motor.
Set this checkbox to configure the motor speed and max torque.")]
	public bool UseMotor; // 0x88
	[Degrees]
	[DrawIf("UseMotor", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The speed at which the hinge motor will attempt to rotate, in angles per second.")]
	public FP MotorSpeed; // 0x90
	[DrawIf("UseMotor", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The maximum torque produced by the hinge motor in order to achieve the target motor speed.
Leave this checkbox unchecked and the motor toque should not be limited.")]
	public NullableFP MaxMotorTorque; // 0x98

	// Methods

	// RVA: 0x677C00 Offset: 0x676200 VA: 0x180677C00 Slot: 5
	public sealed override Joint2D_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677D30 Offset: 0x676330 VA: 0x180677D30
	public void .ctor() { }
}
