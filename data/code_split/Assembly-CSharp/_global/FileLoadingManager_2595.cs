// Namespace: 
public class FileLoadingManager : SRMonoBehaviour // TypeDefIndex: 2595
{
	// Fields
	public static FileLoadingManager.OnCharacterTrailInstanced CharacterTrailInstanced; // 0x0
	public static FileLoadingManager.OnCharacterInstanced CharacterInstanced; // 0x8
	public static FileLoadingManager.OnCharacterRenderLoaded CharacterRenderLoaded; // 0x10

	// Properties
	public StellarFileLoadingSystem StellarSystem { get; }

	// Methods

	// RVA: 0x6F5A00 Offset: 0x6F4000 VA: 0x1806F5A00
	public StellarFileLoadingSystem get_StellarSystem() { }

	// RVA: 0x6F5660 Offset: 0x6F3C60 VA: 0x1806F5660
	public void SpawnBasicCharacter(string operationID, int characterID, int costume, Transform parent) { }

	// RVA: 0x6F58C0 Offset: 0x6F3EC0 VA: 0x1806F58C0
	public void SpawnCharacterTrail(string operationID, AssetReferenceGameObject trailAsset, Transform parent) { }

	// RVA: 0x6F5470 Offset: 0x6F3A70 VA: 0x1806F5470
	public void LoadCharacterRenderSprite(string operationID, int characterID, int costume) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
