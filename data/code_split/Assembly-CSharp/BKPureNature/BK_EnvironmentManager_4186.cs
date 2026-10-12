// Namespace: BKPureNature
[ExecuteInEditMode]
public class BK_EnvironmentManager : MonoBehaviour // TypeDefIndex: 4186
{
	// Fields
	public Light directionalLight; // 0x20
	public Gradient sunColorGradient; // 0x28
	public Gradient fogColorGradient; // 0x30
	public Gradient cloudColorGradient; // 0x38
	public Gradient scatteringColorGradient; // 0x40
	[Header("Color Gradients Enable Flags")]
	public bool overrideSunColor; // 0x48
	public bool overrideFogColor; // 0x49
	public bool overrideCloudColor; // 0x4A
	[Header("Base Wind")]
	[Tooltip("Base wind animate the trunks")]
	[Range(0, 5)]
	public float baseWindPower; // 0x4C
	[Tooltip("Base wind animate the trunks")]
	public float baseWindSpeed; // 0x50
	[Header("Wind Burst")]
	[Tooltip("Bursts are managed by a moving World-Space noise that multiply the base wind speed and power")]
	[Range(0, 10)]
	public float burstsPower; // 0x54
	[Tooltip("Speed of the Bursts noise")]
	public float burstsSpeed; // 0x58
	[Tooltip("Size of the Bursts noise in Word-Space")]
	public float burstsScale; // 0x5C
	[Header("Micro Wind")]
	[Tooltip("Micro wind animate the leaves")]
	[Range(0, 1)]
	public float microPower; // 0x60
	[Tooltip("Micro wind animate the leaves")]
	public float microSpeed; // 0x64
	[Tooltip("Micro wind animate the leaves")]
	public float microFrequency; // 0x68
	[Space(10)]
	public float renderDistance; // 0x6C
	[Space(10)]
	public float Altitude; // 0x70
	public float volumeSize; // 0x74
	public int volumeSamples; // 0x78
	private float volumeOffset; // 0x7C
	private Mesh quadMesh; // 0x80
	private Matrix4x4[] matrices; // 0x88
	[Space(10)]
	[Tooltip("Material for the clouds")]
	public Material cloudsMaterial; // 0x90
	private bool hasIssuedMaterialWarning; // 0x98

	// Methods

	// RVA: 0x6E4810 Offset: 0x6E2E10 VA: 0x1806E4810
	private void Awake() { }

	// RVA: 0x6E5150 Offset: 0x6E3750 VA: 0x1806E5150
	private void Update() { }

	// RVA: 0x6E4D50 Offset: 0x6E3350 VA: 0x1806E4D50
	private void UpdateEnvironment() { }

	// RVA: 0x6E48A0 Offset: 0x6E2EA0 VA: 0x1806E48A0
	private void UpdateCloudsVolume() { }

	// RVA: 0x6E4E90 Offset: 0x6E3490 VA: 0x1806E4E90
	private void UpdateLighting() { }

	// RVA: 0x6E52B0 Offset: 0x6E38B0 VA: 0x1806E52B0
	public void .ctor() { }
}
