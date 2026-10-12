// Namespace: 
public class VFXObject : StellarMonoBehaviour // TypeDefIndex: 3736
{
	// Fields
	public HashString ID; // 0x20
	[ReadOnlyField]
	public ParticleSystem[] ParticleSystems; // 0x30
	[HideInInspector]
	public EntityRef Entity; // 0x38
	private float[] defaultSimulationSpeeds; // 0x40
	private bool pause; // 0x48
	private Vector3 initialPosition; // 0x4C
	private Vector3 initialRotation; // 0x58
	private Vector3 initialScale; // 0x64
	private Transform originalParent; // 0x70
	[CompilerGenerated]
	private int <OwnerIndex>k__BackingField; // 0x78

	// Properties
	public int OwnerIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x567D40 Offset: 0x566340 VA: 0x180567D40
	public int get_OwnerIndex() { }

	[CompilerGenerated]
	// RVA: 0x567D70 Offset: 0x566370 VA: 0x180567D70
	public void set_OwnerIndex(int value) { }

	// RVA: 0x654D10 Offset: 0x653310 VA: 0x180654D10
	private void Awake() { }

	// RVA: 0x655710 Offset: 0x653D10 VA: 0x180655710
	private void Update() { }

	// RVA: 0x655000 Offset: 0x653600 VA: 0x180655000
	private void LateUpdate() { }

	// RVA: 0x6550B0 Offset: 0x6536B0 VA: 0x1806550B0
	public void Play(EntityRef entity, VFXPlayAttributes playAttributes) { }

	// RVA: 0x655620 Offset: 0x653C20 VA: 0x180655620
	public void Stop(VFXStopAttributes stopAttributes) { }

	// RVA: 0x6550A0 Offset: 0x6536A0 VA: 0x1806550A0
	public void Pause() { }

	// RVA: 0x655580 Offset: 0x653B80 VA: 0x180655580
	public void Resume() { }

	// RVA: 0x6557A0 Offset: 0x653DA0 VA: 0x1806557A0
	public void .ctor() { }
}
