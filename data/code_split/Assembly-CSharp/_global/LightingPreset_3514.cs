// Namespace: 
[Serializable]
public class LightingPreset // TypeDefIndex: 3514
{
	// Fields
	public HashString PresetID; // 0x10
	[Header("Color and Lights")]
	public bool ModifyEnviorementColorSettings; // 0x20
	public EnvironmentColorSettings EnvColor; // 0x24
	public List<LightSettings> LightsSettings; // 0x70
	[Header("Fog")]
	public bool ModifyFogColor; // 0x78
	public DistanceFog NearFog; // 0x7C
	public DistanceFog FarFog; // 0x9C
	[Header("Transition")]
	[Range(0, 5)]
	public float transitionDuration; // 0xBC
	public AnimationCurve transitionCurve; // 0xC0

	// Methods

	// RVA: 0x5E85A0 Offset: 0x5E6BA0 VA: 0x1805E85A0
	public void .ctor() { }
}
