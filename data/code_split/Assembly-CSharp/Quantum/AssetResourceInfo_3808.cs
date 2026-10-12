// Namespace: Quantum
[Serializable]
public class AssetResourceInfo // TypeDefIndex: 3808
{
	// Fields
	public string Path; // 0x10
	public AssetRef AssetRef; // 0x18

	// Properties
	public AssetGuid Guid { get; set; }
	public bool IsNestedAsset { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public AssetGuid get_Guid() { }

	// RVA: 0x6569E0 Offset: 0x654FE0 VA: 0x1806569E0
	public void set_Guid(AssetGuid value) { }

	// RVA: 0x6569B0 Offset: 0x654FB0 VA: 0x1806569B0
	public bool get_IsNestedAsset() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
