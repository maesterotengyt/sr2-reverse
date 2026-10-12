// Namespace: 
public class LevelLayoutSelector : SRMonoBehaviour // TypeDefIndex: 3063
{
	// Fields
	public string NavigationSFX; // 0x20
	public GameObject EnabledObjects; // 0x28
	public GameObject DisabledObjects; // 0x30
	public GameObject CPUObjects; // 0x38
	public RectTransformAutoRebuild RectTransformAutoRebuild; // 0x40
	[Space(10)]
	public Image LayoutImage; // 0x48
	public TMP_Text LayoutNameText; // 0x50
	public Transform Indicators; // 0x58
	public GameObject Arrows; // 0x60
	public Animator NextLayoutArrowAnimator; // 0x68
	public Animator PreviousLayoutArrowAnimator; // 0x70
	public Animator LayoutImageAnimator; // 0x78
	[Space(10)]
	public Sprite IndicatorOffSprite; // 0x80
	public Sprite IndicatorOnSprite; // 0x88
	public Sprite RandomLayoutSprite; // 0x90
	private LevelSelectBase levelSelect; // 0x98
	private int selectorNumber; // 0xA0
	private Sprite layoutSprite; // 0xA8
	private List<StageLayout> layouts; // 0xB0

	// Properties
	private LevelSelector selector { get; }

	// Methods

	// RVA: 0x540F70 Offset: 0x53F570 VA: 0x180540F70
	private LevelSelector get_selector() { }

	// RVA: 0x540320 Offset: 0x53E920 VA: 0x180540320
	public void Initialize(int selectorNumber, LevelSelectBase levelSelect) { }

	// RVA: 0x540C90 Offset: 0x53F290 VA: 0x180540C90
	private void Update() { }

	// RVA: 0x540540 Offset: 0x53EB40 VA: 0x180540540
	public void PreviousLayout() { }

	// RVA: 0x540360 Offset: 0x53E960 VA: 0x180540360
	public void NextLayout() { }

	// RVA: 0x540820 Offset: 0x53EE20 VA: 0x180540820
	public void SetLayoutData(int layout) { }

	// RVA: 0x540230 Offset: 0x53E830 VA: 0x180540230
	public void ChangeLayoutSprite() { }

	// RVA: 0x540BE0 Offset: 0x53F1E0 VA: 0x180540BE0
	public void SetRandomMode() { }

	// RVA: 0x5402B0 Offset: 0x53E8B0 VA: 0x1805402B0
	private Image GetIndicator(int index) { }

	// RVA: 0x540260 Offset: 0x53E860 VA: 0x180540260
	public void Disable() { }

	// RVA: 0x5407D0 Offset: 0x53EDD0 VA: 0x1805407D0
	public void SetAsCPU() { }

	// RVA: 0x540EF0 Offset: 0x53F4F0 VA: 0x180540EF0
	public void .ctor() { }
}
