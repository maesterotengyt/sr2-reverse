// Namespace: Quantum.Prototypes
[Prototype(typeof(Joint3D))]
[Serializable]
public class Joint3D_Prototype : StructPrototype // TypeDefIndex: 11896
{
	// Fields
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("If the joint should be materialized with Enabled set to false, not being considered by the Physics Engine.")]
	public bool StartDisabled; // 0x10
	[DisplayName("Type")]
	[Tooltip("The type of the joint, implying which constraints are applied.")]
	public JointType3D JointType; // 0x12
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("A numerical tag that can be used to identify a joint or a group of joints.")]
	public int UserTag; // 0x14
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("A Map Entity that the joint might be connected to.\nThe entity must have at least a transform component.")]
	public MapEntityId ConnectedEntity; // 0x18
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor point to which the joint connects to.\nIf a Connected Entity is provided, this represents an offset in its local space. Otherwise, the connected anchor is a position in world space.")]
	public FPVector3 ConnectedAnchor; // 0x20
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor offset, in the local space of this joint entity's transform.\nThis is the point considered for the joint constraints and where the forces will be applied in the joint entity's body.")]
	public FPVector3 Anchor; // 0x38
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("Axis around which the joint rotates, defined in the local space of the entity.\nThe vector is normalized before set. If zeroed, FPVector3.Right is used instead.")]
	public FPVector3 Axis; // 0x50
	[DrawIf("JointType", 2, 0, 3)]
	[Tooltip("The frequency in Hertz (Hz) at which the spring joint will attempt to oscillate.\nTypical values are below half the frequency of the simulation.")]
	public FP Frequency; // 0x68
	[Range(0, 2)]
	[DrawIf("JointType", 2, 0, 3)]
	[Tooltip("A dimensionless value representing the damper capacity of suppressing the spring oscillation, typically between 0 and 1.")]
	public FP DampingRatio; // 0x70
	[DrawIf("JointType", 0, 1, 3)]
	[DrawIf("JointType", 3, 1, 3)]
	[Tooltip("Automatically configure the target Distance to be the current distance between the anchor points in the scene.")]
	public bool AutoConfigureDistance; // 0x78
	[DrawIf("JointType", 2, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The distance between the anchor points that the joint will attempt to maintain.")]
	public FP Distance; // 0x80
	[DrawIf("JointType", 1, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The minimum distance between the anchor points that the joint will attempt to maintain.")]
	public FP MinDistance; // 0x88
	[DrawIf("JointType", 1, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The maximum distance between the anchor points that the joint will attempt to maintain.")]
	public FP MaxDistance; // 0x90
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the relative angle between the joint transform and its connected anchor should be limited by the hinge joint.\nSet this checkbox to configure the lower and upper limiting angles.")]
	public bool UseAngleLimits; // 0x98
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The lower limiting angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	public FP LowerAngle; // 0xA0
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The upper limiting  angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	public FP UpperAngle; // 0xA8
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the hinge joint uses a motor.\nSet this checkbox to configure the motor speed and max torque.")]
	public bool UseMotor; // 0xB0
	[DrawIf("UseMotor", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The speed at which the hinge motor will attempt to rotate, in angles per second.")]
	public FP MotorSpeed; // 0xB8
	[DrawIf("UseMotor", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The maximum torque produced by the hinge motor in order to achieve the target motor speed.\nLeave this checkbox unchecked and the motor toque should not be limited.")]
	public NullableFP MaxMotorTorque; // 0xC0

	// Methods

	// RVA: 0x2273D40 Offset: 0x2272340 VA: 0x182273D40
	public void Materialize(FrameBase frame, ref Joint3D joint, in PrototypeMaterializationContext context) { }

	// RVA: 0x2274140 Offset: 0x2272740 VA: 0x182274140
	public void OnEntityPrototypeMaterializedJoint(FrameBase f, EntityRef entity, EntityPrototypeRef prototypeRef, Joint3D* joint) { }

	// RVA: 0x2274280 Offset: 0x2272880 VA: 0x182274280
	public void .ctor() { }
}
