// Namespace: 
[Serializable]
public struct EnvironmentColorSettings // TypeDefIndex: 3515
{
	// Fields
	[Header("Ambient")]
	[ColorUsage(True, True)]
	public Color SkyColor; // 0x0
	[ColorUsage(True, True)]
	public Color EquatorColor; // 0x10
	[ColorUsage(True, True)]
	public Color GroundColor; // 0x20
	[Header("Ambient Fog")]
	public Color FogColor; // 0x30
	public float FogStart; // 0x40
	public float FogEnd; // 0x44
}
