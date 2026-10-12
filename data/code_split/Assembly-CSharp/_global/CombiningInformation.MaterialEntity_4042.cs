// Namespace: 
[Serializable]
public class CombiningInformation.MaterialEntity // TypeDefIndex: 4042
{
	// Fields
	public List<CombiningInformation.CombineMetaData> combinedMats; // 0x10
	public int textArrIndex; // 0x18
	public Texture2D diffuseMap; // 0x20
	public Texture2D metallicMap; // 0x28
	public Texture2D specularMap; // 0x30
	public Texture2D normalMap; // 0x38
	public Texture2D heightMap; // 0x40
	public Texture2D occlusionMap; // 0x48
	public Texture2D emissionMap; // 0x50
	public Texture2D detailMaskMap; // 0x58
	public Texture2D detailAlbedoMap; // 0x60
	public Texture2D detailNormalMap; // 0x68

	// Methods

	// RVA: 0x6AA3B0 Offset: 0x6A89B0 VA: 0x1806AA3B0
	public bool HasAnyTextures() { }

	// RVA: 0x6AA5B0 Offset: 0x6A8BB0 VA: 0x1806AA5B0
	public void .ctor() { }
}
