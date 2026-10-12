// Namespace: 
[Serializable]
public class PolyfewRuntime.MaterialProperties // TypeDefIndex: 4154
{
	// Fields
	public readonly int texArrIndex; // 0x10
	public readonly int matIndex; // 0x14
	public readonly string materialName; // 0x18
	public readonly Material originalMaterial; // 0x20
	public Color albedoTint; // 0x28
	public Vector4 uvTileOffset; // 0x38
	public float normalIntensity; // 0x48
	public float occlusionIntensity; // 0x4C
	public float smoothnessIntensity; // 0x50
	public float glossMapScale; // 0x54
	public float metalIntensity; // 0x58
	public Color emissionColor; // 0x5C
	public Vector4 detailUVTileOffset; // 0x6C
	public float alphaCutoff; // 0x7C
	public Color specularColor; // 0x80
	public float detailNormalScale; // 0x90
	public float heightIntensity; // 0x94
	public readonly float uvSec; // 0x98

	// Methods

	// RVA: 0x6CEAB0 Offset: 0x6CD0B0 VA: 0x1806CEAB0
	public void .ctor(int texArrIndex, int matIndex, string materialName, Material originalMaterial, Color albedoTint, Vector4 uvTileOffset, float normalIntensity, float occlusionIntensity, float smoothnessIntensity, float glossMapScale, float metalIntensity, Color emissionColor, Vector4 detailUVTileOffset, float alphaCutoff, Color specularColor, float detailNormalScale, float heightIntensity, float uvSec) { }

	// RVA: 0x6CE600 Offset: 0x6CCC00 VA: 0x1806CE600
	public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex) { }
}
