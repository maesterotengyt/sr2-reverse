// Namespace: 
public class MainMenuLevelOption : UINavigationElement // TypeDefIndex: 3101
{
	// Fields
	public Image LevelImage; // 0x98
	public Sprite RandomSprite; // 0xA0
	public RectTransform HighlightRef; // 0xA8
	private MainMenuHub newMainMenu; // 0xB0
	private HashString levelID; // 0xB8
	private List<int> playersHighlighting; // 0xC8

	// Methods

	// RVA: 0x5596F0 Offset: 0x557CF0 VA: 0x1805596F0
	public void Init(MainMenuHub newMainMenu) { }

	// RVA: 0x559710 Offset: 0x557D10 VA: 0x180559710
	public void SetData(StageData stageData) { }

	// RVA: 0x559770 Offset: 0x557D70 VA: 0x180559770
	public void SetRandomMode() { }

	// RVA: 0x5596E0 Offset: 0x557CE0 VA: 0x1805596E0 Slot: 4
	public override void ElementSelected(int playerIndex) { }

	// RVA: 0x5597A0 Offset: 0x557DA0 VA: 0x1805597A0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x559820 Offset: 0x557E20 VA: 0x180559820
	public void .ctor() { }
}
