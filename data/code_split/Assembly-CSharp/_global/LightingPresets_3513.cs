// Namespace: 
[CreateAssetMenu(fileName = "LightingPresets", menuName = "Stellar/LightingPresets")]
public class LightingPresets : ScriptableObject // TypeDefIndex: 3513
{
	// Fields
	public List<LightingPreset> Presets; // 0x18

	// Methods

	// RVA: 0x5E86D0 Offset: 0x5E6CD0 VA: 0x1805E86D0
	public bool GetLightingPreset(float hashID, out LightingPreset LightingPreset) { }

	// RVA: 0x5E8600 Offset: 0x5E6C00 VA: 0x1805E8600
	public bool GetLightSettings(LightingPreset preset, float lightHashID, out LightSettings lightSettings) { }

	// RVA: 0x5E87B0 Offset: 0x5E6DB0 VA: 0x1805E87B0
	public void .ctor() { }
}
