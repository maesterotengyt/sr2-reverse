// Namespace: 
public class MainMenuPanelRunnerSlot : UINavigationElement // TypeDefIndex: 3104
{
	// Fields
	[Header("Character Panel")]
	public RectTransform HighlightRef; // 0x98
	public List<Image> ColoredHighlightsImages; // 0xA0
	public Image CharacterRender; // 0xA8
	public Image CharacterExperienceFill; // 0xB0
	public TMP_Text CharacterLevel; // 0xB8
	public Image SelectedImage; // 0xC0
	public GameObject LevelGameObject; // 0xC8
	public GameObject Locked; // 0xD0
	private MainMenuHub newMainMenu; // 0xD8
	private HashString characterID; // 0xE0
	private string iconOperationID; // 0xF0
	private bool randomSlot; // 0xF8

	// Properties
	private FileLoadingManager fileLoadingManager { get; }
	private ProgressionManager progressionManager { get; }
	private UIManager uiManager { get; }
	private SaveManager saveManager { get; }
	private AudioManager audioManager { get; }

	// Methods

	// RVA: 0x565530 Offset: 0x563B30 VA: 0x180565530
	private FileLoadingManager get_fileLoadingManager() { }

	// RVA: 0x565580 Offset: 0x563B80 VA: 0x180565580
	private ProgressionManager get_progressionManager() { }

	// RVA: 0x565620 Offset: 0x563C20 VA: 0x180565620
	private UIManager get_uiManager() { }

	// RVA: 0x5655D0 Offset: 0x563BD0 VA: 0x1805655D0
	private SaveManager get_saveManager() { }

	// RVA: 0x5654E0 Offset: 0x563AE0 VA: 0x1805654E0
	private AudioManager get_audioManager() { }

	// RVA: 0x564CF0 Offset: 0x5632F0 VA: 0x180564CF0
	public void SetData(CharacterDetails characterDetails, MainMenuHub newMainMenu, bool random = False) { }

	// RVA: 0x564670 Offset: 0x562C70 VA: 0x180564670
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x5647E0 Offset: 0x562DE0 VA: 0x1805647E0 Slot: 4
	public override void ElementSelected(int playerIndex) { }

	// RVA: 0x5651D0 Offset: 0x5637D0 VA: 0x1805651D0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
