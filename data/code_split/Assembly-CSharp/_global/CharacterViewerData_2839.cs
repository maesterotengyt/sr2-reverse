// Namespace: 
[Serializable]
public class CharacterViewerData : ScriptableObject // TypeDefIndex: 2839
{
	// Fields
	public List<CharacterViewerExtraOptionsData> ExtraSettingsOptions; // 0x18
	public string CharactersDataFolderPath; // 0x20
	public string CharactersIconsPath; // 0x28
	public List<CharacterViewerCharacterData> Characters; // 0x30
	public List<string> SortingRuleKeywords; // 0x38
	public List<CharacterViewerExtraSettings> ExtraSettings; // 0x40

	// Methods

	// RVA: 0x727500 Offset: 0x725B00 VA: 0x180727500
	public CharacterViewerExtraSettings GetExtraSettings(CharacterViewerPanelType panelType) { }

	// RVA: 0x727650 Offset: 0x725C50 VA: 0x180727650
	public void .ctor() { }
}
