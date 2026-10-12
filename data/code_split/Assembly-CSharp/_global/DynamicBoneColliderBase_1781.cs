// Namespace: 
public class DynamicBoneColliderBase : MonoBehaviour // TypeDefIndex: 1781
{
	// Fields
	[Tooltip("The axis of the capsule's height.")]
	public DynamicBoneColliderBase.Direction m_Direction; // 0x20
	[Tooltip("The center of the sphere or capsule, in the object's local space.")]
	public Vector3 m_Center; // 0x24
	[Tooltip("Constrain bones to outside bound or inside bound.")]
	public DynamicBoneColliderBase.Bound m_Bound; // 0x30
	[CompilerGenerated]
	private int <PrepareFrame>k__BackingField; // 0x34

	// Properties
	public int PrepareFrame { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5061F0 Offset: 0x5047F0 VA: 0x1805061F0
	public void set_PrepareFrame(int value) { }

	[CompilerGenerated]
	// RVA: 0x5061E0 Offset: 0x5047E0 VA: 0x1805061E0
	public int get_PrepareFrame() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public virtual void Start() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void Prepare() { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 6
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	// RVA: 0x506180 Offset: 0x504780 VA: 0x180506180
	public void .ctor() { }
}
