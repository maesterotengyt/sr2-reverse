// Namespace: 
[Serializable]
public class CombiningInformation.MaterialProperties // TypeDefIndex: 4039
{
	// Fields
	public bool foldOut; // 0x10
	public int texArrIndex; // 0x14
	public int matIndex; // 0x18
	public string materialName; // 0x20
	public Material originalMaterial; // 0x28
	public Color albedoTint; // 0x30
	public Vector4 uvTileOffset; // 0x40
	public float normalIntensity; // 0x50
	public float occlusionIntensity; // 0x54
	public float smoothnessIntensity; // 0x58
	public float glossMapScale; // 0x5C
	public float metalIntensity; // 0x60
	public Color emissionColor; // 0x64
	public Vector4 detailUVTileOffset; // 0x74
	public float alphaCutoff; // 0x84
	public Color specularColor; // 0x88
	public float detailNormalScale; // 0x98
	public float heightIntensity; // 0x9C
	public float uvSec; // 0xA0
	public int alphaMode; // 0xA4
	public bool specularWorkflow; // 0xA8

	// Methods

	// RVA: 0x6AB110 Offset: 0x6A9710 VA: 0x1806AB110
	public bool IsSameAs(CombiningInformation.MaterialProperties toCompare) { }

	// RVA: 0x6AB440 Offset: 0x6A9A40 VA: 0x1806AB440
	public static Texture2D NewTexture() { }

	// RVA: 0x6AA630 Offset: 0x6A8C30 VA: 0x1806AA630
	public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex) { }

	// RVA: 0x6AAAE0 Offset: 0x6A90E0 VA: 0x1806AAAE0
	public void FillPropertiesFromMaterial(Material material, CombiningInformation combineInfo) { }

	// RVA: 0x6AB510 Offset: 0x6A9B10 VA: 0x1806AB510
	public void .ctor() { }
}
