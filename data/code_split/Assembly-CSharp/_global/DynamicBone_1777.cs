// Namespace: 
[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour // TypeDefIndex: 1777
{
	// Fields
	[Tooltip("The roots of the transform hierarchy to apply physics.")]
	public Transform m_Root; // 0x20
	public List<Transform> m_Roots; // 0x28
	[Tooltip("Internal physics simulation rate.")]
	public float m_UpdateRate; // 0x30
	public DynamicBone.UpdateMode m_UpdateMode; // 0x34
	[Tooltip("How much the bones slowed down.")]
	[Range(0, 1)]
	public float m_Damping; // 0x38
	public AnimationCurve m_DampingDistrib; // 0x40
	[Tooltip("How much the force applied to return each bone to original orientation.")]
	[Range(0, 1)]
	public float m_Elasticity; // 0x48
	public AnimationCurve m_ElasticityDistrib; // 0x50
	[Tooltip("How much bone's original orientation are preserved.")]
	[Range(0, 1)]
	public float m_Stiffness; // 0x58
	public AnimationCurve m_StiffnessDistrib; // 0x60
	[Tooltip("How much character's position change is ignored in physics simulation.")]
	[Range(0, 1)]
	public float m_Inert; // 0x68
	public AnimationCurve m_InertDistrib; // 0x70
	[Tooltip("How much the bones slowed down when collide.")]
	public float m_Friction; // 0x78
	public AnimationCurve m_FrictionDistrib; // 0x80
	[Tooltip("Each bone can be a sphere to collide with colliders. Radius describe sphere's size.")]
	public float m_Radius; // 0x88
	public AnimationCurve m_RadiusDistrib; // 0x90
	[Tooltip("If End Length is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public float m_EndLength; // 0x98
	[Tooltip("If End Offset is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public Vector3 m_EndOffset; // 0x9C
	[Tooltip("The force apply to bones. Partial force apply to character's initial pose is cancelled out.")]
	public Vector3 m_Gravity; // 0xA8
	[Tooltip("The force apply to bones.")]
	public Vector3 m_Force; // 0xB4
	[Tooltip("Control how physics blends with existing animation.")]
	[Range(0, 1)]
	public float m_BlendWeight; // 0xC0
	[Tooltip("Collider objects interact with the bones.")]
	public List<DynamicBoneColliderBase> m_Colliders; // 0xC8
	[Tooltip("Bones exclude from physics simulation.")]
	public List<Transform> m_Exclusions; // 0xD0
	[Tooltip("Constrain bones to move on specified plane.")]
	public DynamicBone.FreezeAxis m_FreezeAxis; // 0xD8
	[Tooltip("Disable physics simulation automatically if character is far from camera or player.")]
	public bool m_DistantDisable; // 0xDC
	public Transform m_ReferenceObject; // 0xE0
	public float m_DistanceToObject; // 0xE8
	[HideInInspector]
	public bool m_Multithread; // 0xEC
	private Vector3 m_ObjectMove; // 0xF0
	private Vector3 m_ObjectPrevPosition; // 0xFC
	private float m_ObjectScale; // 0x108
	private float m_Time; // 0x10C
	private float m_Weight; // 0x110
	private bool m_DistantDisabled; // 0x114
	private int m_PreUpdateCount; // 0x118
	private List<DynamicBone.ParticleTree> m_ParticleTrees; // 0x120
	private float m_DeltaTime; // 0x128
	private List<DynamicBoneColliderBase> m_EffectiveColliders; // 0x130
	private bool m_WorkAdded; // 0x138
	private static List<DynamicBone> s_PendingWorks; // 0x0
	private static List<DynamicBone> s_EffectiveWorks; // 0x8
	private static AutoResetEvent s_AllWorksDoneEvent; // 0x10
	private static int s_RemainWorkCount; // 0x18
	private static Semaphore s_WorkQueueSemaphore; // 0x20
	private static int s_WorkQueueIndex; // 0x28
	private static int s_UpdateCount; // 0x2C
	private static int s_PrepareFrame; // 0x30

	// Methods

	// RVA: 0x50B7A0 Offset: 0x509DA0 VA: 0x18050B7A0
	private void Start() { }

	// RVA: 0x509720 Offset: 0x507D20 VA: 0x180509720
	private void FixedUpdate() { }

	// RVA: 0x50CF30 Offset: 0x50B530 VA: 0x18050CF30
	private void Update() { }

	// RVA: 0x509F70 Offset: 0x508570 VA: 0x180509F70
	private void LateUpdate() { }

	// RVA: 0x50A5D0 Offset: 0x508BD0 VA: 0x18050A5D0
	private void Prepare() { }

	// RVA: 0x509C30 Offset: 0x508230 VA: 0x180509C30
	private bool IsNeedUpdate() { }

	// RVA: 0x50A590 Offset: 0x508B90 VA: 0x18050A590
	private void PreUpdate() { }

	// RVA: 0x508DE0 Offset: 0x5073E0 VA: 0x180508DE0
	private void CheckDistance() { }

	// RVA: 0x50A420 Offset: 0x508A20 VA: 0x18050A420
	private void OnEnable() { }

	// RVA: 0x50A180 Offset: 0x508780 VA: 0x18050A180
	private void OnDisable() { }

	// RVA: 0x50A430 Offset: 0x508A30 VA: 0x18050A430
	private void OnValidate() { }

	// RVA: 0x509C60 Offset: 0x508260 VA: 0x180509C60
	private bool IsRootChanged() { }

	// RVA: 0x50A170 Offset: 0x508770 VA: 0x18050A170
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x50A190 Offset: 0x508790 VA: 0x18050A190
	private void OnDrawGizmosSelected() { }

	// RVA: 0x508FA0 Offset: 0x5075A0 VA: 0x180508FA0
	private void DrawGizmos(DynamicBone.ParticleTree pt) { }

	// RVA: 0x50AE50 Offset: 0x509450 VA: 0x18050AE50
	public void SetWeight(float w) { }

	// RVA: 0x509770 Offset: 0x507D70 VA: 0x180509770
	public float GetWeight() { }

	// RVA: 0x50CD20 Offset: 0x50B320 VA: 0x18050CD20
	private void UpdateParticles() { }

	// RVA: 0x50AEB0 Offset: 0x5094B0 VA: 0x18050AEB0
	public void SetupParticles() { }

	// RVA: 0x507F20 Offset: 0x506520 VA: 0x180507F20
	private void AppendParticleTree(Transform root) { }

	// RVA: 0x5080F0 Offset: 0x5066F0 VA: 0x1805080F0
	private void AppendParticles(DynamicBone.ParticleTree pt, Transform b, int parentIndex, float boneLength) { }

	// RVA: 0x50B900 Offset: 0x509F00 VA: 0x18050B900
	public void UpdateParameters() { }

	// RVA: 0x50B9F0 Offset: 0x509FF0 VA: 0x18050B9F0
	private void UpdateParameters(DynamicBone.ParticleTree pt) { }

	// RVA: 0x5099C0 Offset: 0x507FC0 VA: 0x1805099C0
	private void InitTransforms() { }

	// RVA: 0x509B40 Offset: 0x508140 VA: 0x180509B40
	private void InitTransforms(DynamicBone.ParticleTree pt) { }

	// RVA: 0x50AB20 Offset: 0x509120 VA: 0x18050AB20
	private void ResetParticlesPosition() { }

	// RVA: 0x50AD20 Offset: 0x509320 VA: 0x18050AD20
	private void ResetParticlesPosition(DynamicBone.ParticleTree pt) { }

	// RVA: 0x50BE30 Offset: 0x50A430 VA: 0x18050BE30
	private void UpdateParticles1(float timeVar, int loopIndex) { }

	// RVA: 0x50C260 Offset: 0x50A860 VA: 0x18050C260
	private void UpdateParticles1(DynamicBone.ParticleTree pt, float timeVar, int loopIndex) { }

	// RVA: 0x50C5D0 Offset: 0x50ABD0 VA: 0x18050C5D0
	private void UpdateParticles2(float timeVar) { }

	// RVA: 0x50C680 Offset: 0x50AC80 VA: 0x18050C680
	private void UpdateParticles2(DynamicBone.ParticleTree pt, float timeVar) { }

	// RVA: 0x50B700 Offset: 0x509D00 VA: 0x18050B700
	private void SkipUpdateParticles() { }

	// RVA: 0x50B230 Offset: 0x509830 VA: 0x18050B230
	private void SkipUpdateParticles(DynamicBone.ParticleTree pt) { }

	// RVA: 0x50A0F0 Offset: 0x5086F0 VA: 0x18050A0F0
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis) { }

	// RVA: 0x5088A0 Offset: 0x506EA0 VA: 0x1805088A0
	private void ApplyParticlesToTransforms() { }

	// RVA: 0x508A60 Offset: 0x507060 VA: 0x180508A60
	private void ApplyParticlesToTransforms(DynamicBone.ParticleTree pt, Vector3 ax, Vector3 ay, Vector3 az, bool nx, bool ny, bool nz) { }

	// RVA: 0x507DF0 Offset: 0x5063F0 VA: 0x180507DF0
	private static void AddPendingWork(DynamicBone db) { }

	// RVA: 0x507EC0 Offset: 0x5064C0 VA: 0x180507EC0
	private static void AddWorkToQueue(DynamicBone db) { }

	// RVA: 0x509780 Offset: 0x507D80 VA: 0x180509780
	private static DynamicBone GetWorkFromQueue() { }

	// RVA: 0x50B7B0 Offset: 0x509DB0 VA: 0x18050B7B0
	private static void ThreadProc() { }

	// RVA: 0x509810 Offset: 0x507E10 VA: 0x180509810
	private static void InitThreadPool() { }

	// RVA: 0x509100 Offset: 0x507700 VA: 0x180509100
	private static void ExecuteWorks() { }

	// RVA: 0x50D190 Offset: 0x50B790 VA: 0x18050D190
	public void .ctor() { }

	// RVA: 0x50D0C0 Offset: 0x50B6C0 VA: 0x18050D0C0
	private static void .cctor() { }
}
