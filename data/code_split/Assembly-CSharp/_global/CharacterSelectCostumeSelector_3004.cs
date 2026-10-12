// Namespace: 
public class CharacterSelectCostumeSelector : SRMonoBehaviour // TypeDefIndex: 3004
{
	// Fields
	public TMP_Text CostumeText; // 0x20
	public GameObject CostumeChangeVFX; // 0x28
	public Sprite IndicatorOffSprite; // 0x30
	public Sprite IndicatorOnSprite; // 0x38
	private int selectorNumber; // 0x40
	private List<CharacterCostumeData> costumes; // 0x48

	// Properties
	private CharacterSelector selector { get; }

	// Methods

	// RVA: 0x787FC0 Offset: 0x7865C0 VA: 0x180787FC0
	private CharacterSelector get_selector() { }

	// RVA: 0x5D3B00 Offset: 0x5D2100 VA: 0x1805D3B00 Slot: 4
	public virtual void Initialize(int selectorNumber) { }

	// RVA: 0x787BE0 Offset: 0x7861E0 VA: 0x180787BE0
	private void Update() { }

	// RVA: 0x787850 Offset: 0x785E50 VA: 0x180787850
	public void PreviousCostume() { }

	// RVA: 0x787710 Offset: 0x785D10 VA: 0x180787710
	public void NextCostume() { }

	// RVA: 0x787980 Offset: 0x785F80 VA: 0x180787980
	public void SetCostumeData(int costume) { }

	// RVA: 0x787680 Offset: 0x785C80 VA: 0x180787680
	private Image GetIndicator(int index) { }

	// RVA: 0x7875B0 Offset: 0x785BB0 VA: 0x1807875B0
	public void Disable() { }

	// RVA: 0x787F40 Offset: 0x786540 VA: 0x180787F40
	public void .ctor() { }
}
