// Namespace: 
public class CharacterViewerCharacterSelect : StellarMonoBehaviour // TypeDefIndex: 3599
{
	// Fields
	public CharacterViewer CharacterViewer; // 0x20
	public CharacterViewerAnimationList AnimationList; // 0x28
	public Animator CharacterSelectAnimator; // 0x30
	public Animator LoadingScreenAnimator; // 0x38
	public TMP_InputField CharacterSearchBar; // 0x40
	public TMP_InputField SkinsSearchBar; // 0x48
	public GameObject CharacterGrid; // 0x50
	public GameObject SkinsList; // 0x58
	public CustomToggleButton ToggleButton; // 0x60
	public Image CharacterIcon; // 0x68
	public GameObject AnimationListCover; // 0x70
	public List<CharacterViewerSkinSelectSlot> Skins; // 0x78
	private bool active; // 0x80
	private List<CharacterViewerCharacterSelectSlot> characters; // 0x88
	private HashString selectedCharacter; // 0x90
	private HashString loadedCharacter; // 0xA0
	private int selectedSkin; // 0xB0
	private int loadedSkin; // 0xB4
	private string characterFilter; // 0xB8
	private string skinsFilter; // 0xC0
	private int totalCharactersSpawned; // 0xC8

	// Methods

	// RVA: 0x6052C0 Offset: 0x6038C0 VA: 0x1806052C0
	private void Start() { }

	// RVA: 0x605770 Offset: 0x603D70 VA: 0x180605770
	public void ToggleCharacterSelect() { }

	// RVA: 0x604DA0 Offset: 0x6033A0 VA: 0x180604DA0
	public void SearchCharacter() { }

	// RVA: 0x604DF0 Offset: 0x6033F0 VA: 0x180604DF0
	public void SearchSkin() { }

	// RVA: 0x604E40 Offset: 0x603440 VA: 0x180604E40
	public void SelectCharacter(HashString characterID) { }

	// RVA: 0x5C61F0 Offset: 0x5C47F0 VA: 0x1805C61F0
	public void SelectSkin(int skin) { }

	// RVA: 0x604FB0 Offset: 0x6035B0 VA: 0x180604FB0
	public void ShowCharacterSelection() { }

	// RVA: 0x6051B0 Offset: 0x6037B0 VA: 0x1806051B0
	public void ShowSkinSelection() { }

	// RVA: 0x604780 Offset: 0x602D80 VA: 0x180604780
	private void LoadSkins() { }

	// RVA: 0x604570 Offset: 0x602B70 VA: 0x180604570
	public void ConfirmCharacter() { }

	[IteratorStateMachine(typeof(CharacterViewerCharacterSelect.<SpawnCharacterCoroutine>d__31))]
	// RVA: 0x605250 Offset: 0x603850 VA: 0x180605250
	private IEnumerator SpawnCharacterCoroutine() { }

	// RVA: 0x604B60 Offset: 0x603160 VA: 0x180604B60
	public void OnCharacterLoaded(EventOnCharacterLoaded callback) { }

	[IteratorStateMachine(typeof(CharacterViewerCharacterSelect.<CharacterReadySubrutine>d__33))]
	// RVA: 0x604500 Offset: 0x602B00 VA: 0x180604500
	private IEnumerator CharacterReadySubrutine() { }

	// RVA: 0x604D20 Offset: 0x603320 VA: 0x180604D20
	private void OnLoadSprite(Sprite sprite, string path) { }

	// RVA: 0x605B00 Offset: 0x604100 VA: 0x180605B00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x605AB0 Offset: 0x6040B0 VA: 0x180605AB0
	private bool <ToggleCharacterSelect>b__22_0(CharacterViewerCharacterSelectSlot x) { }

	[CompilerGenerated]
	// RVA: 0x605A50 Offset: 0x604050 VA: 0x180605A50
	private bool <LoadSkins>b__29_0(CharacterDetails x) { }

	[CompilerGenerated]
	// RVA: 0x605A90 Offset: 0x604090 VA: 0x180605A90
	private bool <LoadSkins>b__29_1(CharacterViewerSkinSelectSlot x) { }
}
