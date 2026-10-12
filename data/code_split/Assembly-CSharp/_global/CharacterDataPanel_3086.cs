// Namespace: 
public class CharacterDataPanel : MainMenuSubPanel // TypeDefIndex: 3086
{
	// Fields
	public Image CharacterRender; // 0x48
	public TMP_Text CharacterLabel; // 0x50
	public TMP_Text CurrentLevelText; // 0x58
	public TMP_Text ExperiencePointsText; // 0x60
	public TMP_Text RewardTypeText; // 0x68
	public GameObject RewardSegment; // 0x70
	public Image LevelBar; // 0x78
	public Image UnlockIcon; // 0x80
	public LocalizedString TitleString; // 0x88
	public LocalizedString TrailString; // 0x90
	public LocalizedString BackgroundString; // 0x98
	public LocalizedString SkinString; // 0xA0
	public LocalizedString CatchPhraseString; // 0xA8
	public LocalizedString IconString; // 0xB0

	// Properties
	private ProgressionManager progressionManager { get; }

	// Methods

	// RVA: 0x53A070 Offset: 0x538670 VA: 0x18053A070
	private ProgressionManager get_progressionManager() { }

	// RVA: 0x539A90 Offset: 0x538090 VA: 0x180539A90
	public void UpdateCharacterData(HashString character) { }

	// RVA: 0x5397D0 Offset: 0x537DD0 VA: 0x1805397D0
	public void SetUnlockImage(Unlockable unlockable) { }

	// RVA: 0x539660 Offset: 0x537C60 VA: 0x180539660
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
