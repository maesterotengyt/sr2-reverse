// Namespace: 
public class CharacterSelectPanelRunnerSlot : CharacterSelectPanelUINavigationElement // TypeDefIndex: 3021
{
	// Fields
	public Image CharacterRender; // 0xB0
	public Image CharacterExperienceFill; // 0xB8
	public TMP_Text CharacterLevel; // 0xC0
	public GameObject Locked; // 0xC8
	public GameObject CharacterLevelContainer; // 0xD0
	public GameObject ExperienceBar; // 0xD8
	public Sprite RandomSprite; // 0xE0
	private CharacterSelectRunnerMenu characterSelectRunnerMenu; // 0xE8
	private HashString characterID; // 0xF0
	private string iconOperationID; // 0x100
	private string characterName; // 0x108
	private bool randomSlot; // 0x110

	// Properties
	private FileLoadingManager fileLoadingManager { get; }
	private ProgressionManager progressionManager { get; }
	protected StellarOnlineSystem stellarOnlineSystem { get; }
	private SaveManager saveManager { get; }

	// Methods

	// RVA: 0x78E2B0 Offset: 0x78C8B0 VA: 0x18078E2B0
	private FileLoadingManager get_fileLoadingManager() { }

	// RVA: 0x78E300 Offset: 0x78C900 VA: 0x18078E300
	private ProgressionManager get_progressionManager() { }

	// RVA: 0x78E3A0 Offset: 0x78C9A0 VA: 0x18078E3A0
	protected StellarOnlineSystem get_stellarOnlineSystem() { }

	// RVA: 0x78E350 Offset: 0x78C950 VA: 0x18078E350
	private SaveManager get_saveManager() { }

	// RVA: 0x78DCD0 Offset: 0x78C2D0 VA: 0x18078DCD0
	public void SetData(CharacterDetails characterDetails, CharacterSelectRunnerMenu runnerMenu, bool random = False) { }

	// RVA: 0x78D700 Offset: 0x78BD00 VA: 0x18078D700
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x78D870 Offset: 0x78BE70 VA: 0x18078D870 Slot: 4
	public override void ElementSelected(int playerIndex) { }

	// RVA: 0x78E250 Offset: 0x78C850 VA: 0x18078E250 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
