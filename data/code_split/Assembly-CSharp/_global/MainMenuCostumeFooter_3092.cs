// Namespace: 
public class MainMenuCostumeFooter : SRMonoBehaviour // TypeDefIndex: 3092
{
	// Fields
	public UINavigator Tabs; // 0x20
	public RectTransformAutoRebuild RectTransformAutoRebuild; // 0x28
	public Image buttonIconLeft; // 0x30
	public Image buttonIconRight; // 0x38
	private int currentIndex; // 0x40
	private int maxCostumes; // 0x44
	private MainMenuHub newMainMenu; // 0x48
	private bool onCooldown; // 0x50

	// Properties
	private StellarInputSystem inputSystem { get; }
	private StellarAudioSystem audioSystem { get; }

	// Methods

	// RVA: 0x553960 Offset: 0x551F60 VA: 0x180553960
	private StellarInputSystem get_inputSystem() { }

	// RVA: 0x553910 Offset: 0x551F10 VA: 0x180553910
	private StellarAudioSystem get_audioSystem() { }

	// RVA: 0x5531A0 Offset: 0x5517A0 VA: 0x1805531A0
	public void Initialize(MainMenuHub newMainMenu) { }

	// RVA: 0x552EF0 Offset: 0x5514F0 VA: 0x180552EF0
	public List<CharacterCostumeData> GetCharacterUnlockedCostumes(int characterID) { }

	// RVA: 0x552E90 Offset: 0x551490 VA: 0x180552E90
	public void Deactivate() { }

	// RVA: 0x552C40 Offset: 0x551240 VA: 0x180552C40
	public void Activate() { }

	// RVA: 0x553220 Offset: 0x551820 VA: 0x180553220
	public void LoadCostumes() { }

	// RVA: 0x552CA0 Offset: 0x5512A0 VA: 0x180552CA0
	public void ChangeCostume(int index, bool ignoreCooldown = False) { }

	[IteratorStateMachine(typeof(MainMenuCostumeFooter.<TriggerAnimationNextFrame>d__18))]
	// RVA: 0x553660 Offset: 0x551C60 VA: 0x180553660
	private IEnumerator TriggerAnimationNextFrame() { }

	[IteratorStateMachine(typeof(MainMenuCostumeFooter.<SkinChangeCooldown>d__19))]
	// RVA: 0x5535F0 Offset: 0x551BF0 VA: 0x1805535F0
	private IEnumerator SkinChangeCooldown() { }

	// RVA: 0x553120 Offset: 0x551720 VA: 0x180553120
	public UINavigationElement GetCostumeTab(int tabIndex) { }

	// RVA: 0x5536D0 Offset: 0x551CD0 VA: 0x1805536D0
	public void UpdatePanel() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
