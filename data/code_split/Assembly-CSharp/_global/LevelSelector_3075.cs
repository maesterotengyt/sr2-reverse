// Namespace: 
public class LevelSelector : SRMonoBehaviour // TypeDefIndex: 3075
{
	// Fields
	public static LevelSelector.OnSelectorUpdated SelectorUpdated; // 0x0
	public int SelectorNumber; // 0x20
	public TMP_Text PlayerNameText; // 0x28
	public Animator ReadyStatus; // 0x30
	public Animator NextLayoutButtonAnimator; // 0x38
	public Animator PreviousLayoutButtonAnimator; // 0x40
	[Header("Elements")]
	public LevelLayoutSelector LayoutSelector; // 0x48
	public GameObject ChangeLayoutLabel; // 0x50
	public GameObject PlayerNameBackgroundEnabled; // 0x58
	public GameObject PlayerNameBackgroundDisabled; // 0x60
	public GameObject CPUNameBackgroundEnabled; // 0x68
	[Header("Selector Data (Only for visualization)")]
	public bool IsCPU; // 0x70
	public bool Enabled; // 0x71
	public bool Ready; // 0x72
	public int PlayerIndex; // 0x74
	public int InputDeviceIndex; // 0x78
	public HashString LevelID; // 0x80
	public int LevelLayoutIndex; // 0x90
	public string LevelLayoutID; // 0x98
	public bool RandomLevel; // 0xA0
	private LevelSelectBase levelSelect; // 0xA8

	// Methods

	// RVA: 0x547A20 Offset: 0x546020 VA: 0x180547A20
	public void Clean() { }

	// RVA: 0x547D00 Offset: 0x546300 VA: 0x180547D00
	public void Init(LevelSelectBase levelSelect) { }

	// RVA: 0x547DB0 Offset: 0x5463B0 VA: 0x180547DB0
	public void SetEnabled(bool enabled) { }

	// RVA: 0x547F10 Offset: 0x546510 VA: 0x180547F10
	public void SetIsCPU(bool isCPU, string cpuName) { }

	// RVA: 0x548020 Offset: 0x546620 VA: 0x180548020
	public void SetLevelID(HashString levelID) { }

	// RVA: 0x548140 Offset: 0x546740 VA: 0x180548140
	public void SetLevelLayout(int layoutIndex) { }

	// RVA: 0x548340 Offset: 0x546940 VA: 0x180548340
	public void SetRandomLevel(bool random) { }

	// RVA: 0x5484B0 Offset: 0x546AB0 VA: 0x1805484B0
	public void SetReady(bool ready) { }

	// RVA: 0x547D70 Offset: 0x546370 VA: 0x180547D70
	public void MovePlayerHighlight(RectTransform target) { }

	// RVA: 0x547CB0 Offset: 0x5462B0 VA: 0x180547CB0
	public StageData GetStageData() { }

	// RVA: 0x547B70 Offset: 0x546170 VA: 0x180547B70
	private int GetPlayerNumber() { }

	// RVA: 0x548640 Offset: 0x546C40 VA: 0x180548640
	private void Update() { }

	// RVA: 0x547A50 Offset: 0x546050 VA: 0x180547A50
	public void Disable() { }

	// RVA: 0x5486E0 Offset: 0x546CE0 VA: 0x1805486E0
	public void .ctor() { }
}
