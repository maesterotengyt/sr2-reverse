// Namespace: Quantum.Physics2D
public struct Joint // TypeDefIndex: 11938
{
	// Fields
	public int UserTag; // 0x0
	internal JointType _type; // 0x4
	private ushort _disabled; // 0x6
	[FieldOverlap(8)]
	public FPVector2 Anchor; // 0x8
	[FieldOverlap(8)]
	public FPVector2 ConnectedAnchor; // 0x18
	[FieldOverlap(8)]
	public EntityRef ConnectedEntity; // 0x28
	[FieldOverlap(8)]
	public SpringJoint SpringJoint; // 0x8
	[FieldOverlap(8)]
	public DistanceJoint DistanceJoint; // 0x8
	[FieldOverlap(8)]
	public HingeJoint HingeJoint; // 0x8

	// Properties
	public JointType Type { get; }
	public bool Enabled { get; set; }

	// Methods

	// RVA: 0x2200E70 Offset: 0x21FF470 VA: 0x182200E70
	public JointType get_Type() { }

	// RVA: 0x2200E60 Offset: 0x21FF460 VA: 0x182200E60
	public bool get_Enabled() { }

	// RVA: 0x2200E80 Offset: 0x21FF480 VA: 0x182200E80
	public void set_Enabled(bool value) { }

	// RVA: 0x2200B50 Offset: 0x21FF150 VA: 0x182200B50
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2200A20 Offset: 0x21FF020 VA: 0x182200A20 Slot: 2
	public override int GetHashCode() { }
}
