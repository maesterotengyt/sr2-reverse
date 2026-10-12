// Namespace: 
public class LightController : StellarMonoBehaviour // TypeDefIndex: 3536
{
	// Fields
	public LightingPresets LightingPresets; // 0x20
	public LightingPreset CurrentLightingPreset; // 0x28
	public List<SceneLight> Scenelights; // 0x30
	public Renderer NearFogRenderer; // 0x38
	public Renderer FarFogRenderer; // 0x40
	public bool EditMode; // 0x48
	private EnvironmentColorSettings startAmbientColor; // 0x4C
	private EnvironmentColorSettings TargetAmbientColor; // 0x94
	private float ambientTimer; // 0xDC
	private bool ambientTransitioning; // 0xE0
	private DistanceFog startNearFog; // 0xE4
	private DistanceFog targetNearFog; // 0x104
	private DistanceFog startFarFog; // 0x124
	private DistanceFog targetFarFog; // 0x144
	private float fogTimer; // 0x164
	private bool fogTransitioning; // 0x168
	private bool instantTransition; // 0x169
	private MaterialPropertyBlock materialPropertyBlock; // 0x170
	private const string FogBaseColorParam = "_BaseColor";
	private const string FogEmissionParam = "_EmissionColor";

	// Methods

	// RVA: 0x5E7680 Offset: 0x5E5C80 VA: 0x1805E7680
	private void OnEnable() { }

	// RVA: 0x5E7880 Offset: 0x5E5E80 VA: 0x1805E7880
	private void Update() { }

	// RVA: 0x5E7850 Offset: 0x5E5E50 VA: 0x1805E7850
	public void ReloadPreset() { }

	// RVA: 0x5E6F80 Offset: 0x5E5580 VA: 0x1805E6F80
	public void ApplyPreset(float hashID, bool InstantChange = False) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
