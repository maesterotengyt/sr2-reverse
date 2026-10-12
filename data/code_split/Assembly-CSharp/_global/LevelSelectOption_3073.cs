// Namespace: 
public class LevelSelectOption : UINavigationElement // TypeDefIndex: 3073
{
	// Fields
	public Image LevelImage; // 0x98
	public Sprite RandomSprite; // 0xA0
	public RectTransform HighlightRef; // 0xA8
	public GameObject Locked; // 0xB0
	private LevelSelectBase levelSelect; // 0xB8
	private HashString levelID; // 0xC0
	private bool isRandomOption; // 0xD0
	private List<int> playersHighlighting; // 0xD8

	// Methods

	// RVA: 0x545940 Offset: 0x543F40 VA: 0x180545940
	public void Init(LevelSelectBase levelSelect) { }

	// RVA: 0x545B30 Offset: 0x544130 VA: 0x180545B30
	public void SetData(StageData stageData) { }

	// RVA: 0x545BB0 Offset: 0x5441B0 VA: 0x180545BB0
	public void SetRandomMode() { }

	// RVA: 0x545890 Offset: 0x543E90 VA: 0x180545890 Slot: 4
	public override void ElementSelected(int playerIndex) { }

	// RVA: 0x545C00 Offset: 0x544200 VA: 0x180545C00 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x545960 Offset: 0x543F60 VA: 0x180545960
	private void RefreshMarkers() { }

	// RVA: 0x545F50 Offset: 0x544550 VA: 0x180545F50
	public void .ctor() { }
}
