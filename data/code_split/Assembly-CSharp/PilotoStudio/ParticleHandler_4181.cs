// Namespace: PilotoStudio
[ExecuteAlways]
public class ParticleHandler : MonoBehaviour // TypeDefIndex: 4181
{
	// Fields
	public GameObject castParticle; // 0x20
	public float castFXDuration; // 0x28
	public GameObject loopingParticle; // 0x30
	public float loopDuration; // 0x38
	public GameObject endParticle; // 0x40
	private ParticleSystem castParticleSystem; // 0x48
	private ParticleSystem loopingParticleSystem; // 0x50
	private ParticleSystem endParticleSystem; // 0x58
	private float startEmission; // 0x60

	// Methods

	// RVA: 0x6E8EF0 Offset: 0x6E74F0 VA: 0x1806E8EF0
	private void OnEnable() { }

	// RVA: 0x6E8E00 Offset: 0x6E7400 VA: 0x1806E8E00
	public void Cast() { }

	[IteratorStateMachine(typeof(ParticleHandler.<Flow>d__11))]
	// RVA: 0x6E8E80 Offset: 0x6E7480 VA: 0x1806E8E80
	private IEnumerator Flow() { }

	[IteratorStateMachine(typeof(ParticleHandler.<WaitUntilParticleSystemStops>d__12))]
	// RVA: 0x6E9350 Offset: 0x6E7950 VA: 0x1806E9350
	private IEnumerator WaitUntilParticleSystemStops(ParticleSystem particleSystem) { }

	// RVA: 0x6E9080 Offset: 0x6E7680 VA: 0x1806E9080
	private void PlayParticles(ParticleSystem particleSystem, float duration = 0) { }

	[IteratorStateMachine(typeof(ParticleHandler.<StopParticleAfterTime>d__14))]
	// RVA: 0x6E92D0 Offset: 0x6E78D0 VA: 0x1806E92D0
	private IEnumerator StopParticleAfterTime(ParticleSystem particleSystem, float duration) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
