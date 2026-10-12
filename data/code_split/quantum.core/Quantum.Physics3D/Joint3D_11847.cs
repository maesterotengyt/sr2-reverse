// Namespace: Quantum.Physics3D
public struct Joint3D // TypeDefIndex: 11847
{
	// Fields
	public int UserTag; // 0x0
	internal JointType3D _type; // 0x4
	private ushort _disabled; // 0x6
	[FieldOverlap(8)]
	public FPVector3 Anchor; // 0x8
	[FieldOverlap(8)]
	public FPVector3 ConnectedAnchor; // 0x20
	[FieldOverlap(8)]
	public EntityRef ConnectedEntity; // 0x38
	[FieldOverlap(8)]
	public SpringJoint3D SpringJoint; // 0x8
	[FieldOverlap(8)]
	public DistanceJoint3D DistanceJoint; // 0x8
	[FieldOverlap(8)]
	public HingeJoint3D HingeJoint; // 0x8

	// Properties
	public JointType3D Type { get; }
	public bool Enabled { get; set; }

	// Methods

	// RVA: 0x2200E70 Offset: 0x21FF470 VA: 0x182200E70
	public JointType3D get_Type() { }

	// RVA: 0x2200E60 Offset: 0x21FF460 VA: 0x182200E60
	public bool get_Enabled() { }

	// RVA: 0x2200E80 Offset: 0x21FF480 VA: 0x182200E80
	public void set_Enabled(bool value) { }

	// RVA: 0x22654D0 Offset: 0x2263AD0 VA: 0x1822654D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x22653A0 Offset: 0x22639A0 VA: 0x1822653A0 Slot: 2
	public override int GetHashCode() { }
}
