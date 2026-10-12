// Namespace: 
public class PlayerListOnlineBadge : SRMonoBehaviour // TypeDefIndex: 3207
{
	// Fields
	public TMP_Text PlayerNameText; // 0x20
	public TMP_Text PlayerNameTextShadow; // 0x28
	public TMP_Text PlayerTitleText; // 0x30
	public TMP_Text PlayerTitleTextShadow; // 0x38
	public Image PlayerIconIcon; // 0x40
	public Image LocalPlayerIcon; // 0x48
	public BadgePlatformIcon BadgePlatformIcon; // 0x50
	public Image BadgeBackground; // 0x58
	public SavedPlayerData Data; // 0x60
	public UINavigationElement navigationElement; // 0xC8
	private string playerName; // 0xD0
	private string currentPlayerCustomization; // 0xD8

	// Methods

	// RVA: 0x585980 Offset: 0x583F80 VA: 0x180585980
	public void SetData(SavedPlayerData playerData) { }

	// RVA: 0x585700 Offset: 0x583D00 VA: 0x180585700
	public void SetData(string playerName, PlayerCustomization playerCustomization, GamePlatform platform, bool isLocalPlayer) { }

	// RVA: 0x585690 Offset: 0x583C90 VA: 0x180585690
	public void Disable() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
