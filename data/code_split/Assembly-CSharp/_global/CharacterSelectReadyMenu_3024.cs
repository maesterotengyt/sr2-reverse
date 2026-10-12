// Namespace: 
public class CharacterSelectReadyMenu : CharacterSelectSubPanel // TypeDefIndex: 3024
{
	// Fields
	public Image CharacterRender; // 0x48
	public Animator CharacterRenderAnimator; // 0x50
	public UINavigationElement EditButtonLarge; // 0x58
	public UINavigationElement EditButton; // 0x60
	public UINavigationElement DeleteButton; // 0x68
	public GameObject ReadySelection; // 0x70
	public GameObject ReadyState; // 0x78
	public GameObject CPUIcon; // 0x80
	public GameObject CharacterLevelIcon; // 0x88
	public TMP_Text CharacterLevelText; // 0x90
	public TMP_Text CharacterLevelTextShadow; // 0x98
	public RectTransform PanelHighlightRef; // 0xA0
	public Sprite RandomSprite; // 0xA8
	public CharacterSelectPanel[] CharacterPanels; // 0xB0
	private HashString currentCharacterID; // 0xB8
	private int currentCostume; // 0xC8

	// Properties
	private ProgressionManager progressionManager { get; }

	// Methods

	// RVA: 0x791320 Offset: 0x78F920 VA: 0x180791320
	private ProgressionManager get_progressionManager() { }

	// RVA: 0x78F980 Offset: 0x78DF80 VA: 0x18078F980 Slot: 4
	public override void Initialize(int selectorNumber, CharacterSelectBase characterSelect) { }

	// RVA: 0x790320 Offset: 0x78E920 VA: 0x180790320 Slot: 5
	public override void Show() { }

	// RVA: 0x78F7A0 Offset: 0x78DDA0 VA: 0x18078F7A0 Slot: 6
	public override void Hide() { }

	// RVA: 0x7900E0 Offset: 0x78E6E0 VA: 0x1807900E0
	private void SelectorReserved(CharacterSelector updatedSelector, ReserveSelectorContext context) { }

	// RVA: 0x78FFE0 Offset: 0x78E5E0 VA: 0x18078FFE0
	private void SelectorReserveCanceled(CharacterSelector updatedSelector) { }

	// RVA: 0x78F270 Offset: 0x78D870 VA: 0x18078F270
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x78FE00 Offset: 0x78E400 VA: 0x18078FE00
	public void SelectReady() { }

	// RVA: 0x78FD10 Offset: 0x78E310 VA: 0x18078FD10
	public void SelectEdit() { }

	// RVA: 0x7883C0 Offset: 0x7869C0 VA: 0x1807883C0
	public void SelectDelete() { }

	// RVA: 0x78FBE0 Offset: 0x78E1E0 VA: 0x18078FBE0
	public void RightMenuOverflow() { }

	// RVA: 0x78FAB0 Offset: 0x78E0B0 VA: 0x18078FAB0
	public void LeftMenuOverflow() { }

	// RVA: 0x78F660 Offset: 0x78DC60 VA: 0x18078F660
	public void ClickCancelReady() { }

	// RVA: 0x78F050 Offset: 0x78D650 VA: 0x18078F050
	public void CancelReady() { }

	// RVA: 0x790F40 Offset: 0x78F540 VA: 0x180790F40
	private void Update() { }

	// RVA: 0x78F420 Offset: 0x78DA20 VA: 0x18078F420 Slot: 7
	public override void Clean() { }

	// RVA: 0x791300 Offset: 0x78F900 VA: 0x180791300
	public void .ctor() { }
}
