// Namespace: 
[Serializable]
public class CombiningInformation.TextureArrayGroup // TypeDefIndex: 4038
{
	// Fields
	public CombiningInformation.TextureArrayUserSettings diffuseArraySettings; // 0x10
	public CombiningInformation.TextureArrayUserSettings metallicArraySettings; // 0x18
	public CombiningInformation.TextureArrayUserSettings specularArraySettings; // 0x20
	public CombiningInformation.TextureArrayUserSettings normalArraySettings; // 0x28
	public CombiningInformation.TextureArrayUserSettings heightArraySettings; // 0x30
	public CombiningInformation.TextureArrayUserSettings occlusionArraySettings; // 0x38
	public CombiningInformation.TextureArrayUserSettings emissiveArraySettings; // 0x40
	public CombiningInformation.TextureArrayUserSettings detailMaskArraySettings; // 0x48
	public CombiningInformation.TextureArrayUserSettings detailAlbedoArraySettings; // 0x50
	public CombiningInformation.TextureArrayUserSettings detailNormalArraySettings; // 0x58

	// Methods

	// RVA: 0x6B2C40 Offset: 0x6B1240 VA: 0x1806B2C40
	public void InitializeDefaultArraySettings(CombiningInformation.Resolution resolution, FilterMode filteringMode, CombiningInformation.CompressionType compressionType, CombiningInformation.CompressionQuality compressionQuality = 1, int anisotropicFilteringLevel = 1) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
