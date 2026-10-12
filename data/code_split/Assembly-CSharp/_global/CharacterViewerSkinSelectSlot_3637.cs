// Namespace: 
public class CharacterViewerSkinSelectSlot : MonoBehaviour // TypeDefIndex: 3637
{
	// Fields
	public Animator Animator; // 0x20
	public Button Button; // 0x28
	public TMP_Text IndexText; // 0x30
	public TMP_Text NameText; // 0x38
	public int Skin; // 0x40
	private CharacterViewerCharacterSelect characterSelect; // 0x48
	private bool selected; // 0x50
	private bool active; // 0x51

	// Methods

	// RVA: 0x614300 Offset: 0x612900 VA: 0x180614300
	private void OnEnable() { }

	// RVA: 0x58D130 Offset: 0x58B730 VA: 0x18058D130
	public void Init(CharacterViewerCharacterSelect characterSelect) { }

	// RVA: 0x614230 Offset: 0x612830 VA: 0x180614230
	public void LoadCharacterData(int skin, string name) { }

	// RVA: 0x6145E0 Offset: 0x612BE0 VA: 0x1806145E0
	public void Show(int index, string filter) { }

	// RVA: 0x6145B0 Offset: 0x612BB0 VA: 0x1806145B0
	public void Select() { }

	// RVA: 0x6143D0 Offset: 0x6129D0 VA: 0x1806143D0
	public void SelectAnimation(bool selected) { }

	// RVA: 0x614150 Offset: 0x612750 VA: 0x180614150
	public void HighlightAnimation(bool highlighted) { }

	// RVA: 0x614310 Offset: 0x612910 VA: 0x180614310
	private void ResetTriggers() { }

	// RVA: 0x614140 Offset: 0x612740 VA: 0x180614140
	public void Disable() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
