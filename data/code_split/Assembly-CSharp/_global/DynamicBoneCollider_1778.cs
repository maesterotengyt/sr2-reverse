// Namespace: 
[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase // TypeDefIndex: 1778
{
	// Fields
	[Tooltip("The radius of the sphere or capsule.")]
	public float m_Radius; // 0x38
	[Tooltip("The height of the capsule.")]
	public float m_Height; // 0x3C
	[Tooltip("The other radius of the capsule.")]
	public float m_Radius2; // 0x40
	private float m_ScaledRadius; // 0x44
	private float m_ScaledRadius2; // 0x48
	private Vector3 m_C0; // 0x4C
	private Vector3 m_C1; // 0x58
	private float m_C01Distance; // 0x64
	private int m_CollideType; // 0x68

	// Methods

	// RVA: 0x506ED0 Offset: 0x5054D0 VA: 0x180506ED0
	private void OnValidate() { }

	// RVA: 0x507660 Offset: 0x505C60 VA: 0x180507660 Slot: 5
	public override void Prepare() { }

	// RVA: 0x506200 Offset: 0x504800 VA: 0x180506200 Slot: 6
	public override bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	// RVA: 0x507560 Offset: 0x505B60 VA: 0x180507560
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x506C30 Offset: 0x505230 VA: 0x180506C30
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x507290 Offset: 0x505890 VA: 0x180507290
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen) { }

	// RVA: 0x5069B0 Offset: 0x504FB0 VA: 0x1805069B0
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen) { }

	// RVA: 0x506F00 Offset: 0x505500 VA: 0x180506F00
	private static bool OutsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen) { }

	// RVA: 0x506650 Offset: 0x504C50 VA: 0x180506650
	private static bool InsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen) { }

	// RVA: 0x506D20 Offset: 0x505320 VA: 0x180506D20
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5065A0 Offset: 0x504BA0 VA: 0x1805065A0
	private static void DrawCapsule(Vector3 c0, Vector3 c1, float radius0, float radius1) { }

	// RVA: 0x507A40 Offset: 0x506040 VA: 0x180507A40
	public void .ctor() { }
}
