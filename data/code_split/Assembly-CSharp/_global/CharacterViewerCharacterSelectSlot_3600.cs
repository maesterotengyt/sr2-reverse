// Namespace: 
public class CharacterViewerCharacterSelectSlot : StellarMonoBehaviour // TypeDefIndex: 3600
{
	// Fields
	public TMP_Text NameLabel; // 0x20
	public Image CharacterIcon; // 0x28
	public Animator Animator; // 0x30
	public CharacterDetails CharacterData; // 0x38
	private CharacterViewerCharacterSelect characterSelect; // 0x40
	private string fullPath; // 0x48
	private bool active; // 0x50
	private bool selected; // 0x51
	private bool highlighted; // 0x52

	// Properties
	private CharacterViewerData characterViewerData { get; }

	// Methods

	// RVA: 0x6044D0 Offset: 0x602AD0 VA: 0x1806044D0
	private CharacterViewerData get_characterViewerData() { }

	// RVA: 0x603D60 Offset: 0x602360 VA: 0x180603D60
	public void Init(CharacterDetails data, CharacterViewerCharacterSelect characterSelect) { }

	// RVA: 0x603E90 Offset: 0x602490 VA: 0x180603E90
	private void OnEnable() { }

	// RVA: 0x6040B0 Offset: 0x6026B0 VA: 0x1806040B0
	private void OnLoadSprite(Sprite sprite, string path) { }

	// RVA: 0x604390 Offset: 0x602990 VA: 0x180604390
	public void Show(string filter) { }

	// RVA: 0x6042F0 Offset: 0x6028F0 VA: 0x1806042F0
	public void Select() { }

	// RVA: 0x603C60 Offset: 0x602260 VA: 0x180603C60
	public void Disable() { }

	// RVA: 0x604250 Offset: 0x602850 VA: 0x180604250
	public void SelectAnimation(bool select) { }

	// RVA: 0x603C70 Offset: 0x602270 VA: 0x180603C70
	public void HighlightAnimation(bool highlight) { }

	// RVA: 0x604150 Offset: 0x602750 VA: 0x180604150
	private void ResetTriggers() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
