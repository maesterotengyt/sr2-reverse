// Namespace: 
public class CharacterSelectOnlineBadge : SRMonoBehaviour // TypeDefIndex: 3010
{
	// Fields
	[Header("Real Player")]
	public GameObject RealPlayerContainer; // 0x20
	public TMP_Text PlayerNameText; // 0x28
	public TMP_Text PlayerNameTextShadow; // 0x30
	public TMP_Text PlayerTitleText; // 0x38
	public TMP_Text PlayerTitleTextShadow; // 0x40
	public Image PlayerIconIcon; // 0x48
	public Image CharacterIcon; // 0x50
	public Image BadgeBackground; // 0x58
	public Image CharacterBackground; // 0x60
	public Color CharacterBackgroundReadyColor; // 0x68
	public Color CharacterBackgroundNotReadyColor; // 0x78
	public Sprite CharacterRandomSprite; // 0x88
	public CharacterSelectCharacterSpawner CharacterSpawner; // 0x90
	public BadgePlatformIcon BadgePlatformIcon; // 0x98
	public UINavigationElement uiNavigationElement; // 0xA0
	private string playerName; // 0xA8
	private string currentPlayerCustomization; // 0xB0
	private string playerID; // 0xB8
	public PlayerListOptions playerListOptions; // 0xC0
	public SavedPlayerData savedPlayerData; // 0xC8
	[Header("CPU Player")]
	public GameObject CPUPlayerContainer; // 0x130
	public TextProxy CPUPlayerName; // 0x138
	public Image CPUPlayerCharacterImage; // 0x140
	[Header("Filled CPU Player")]
	public GameObject FilledCPUPlayerContainer; // 0x148
	[Header("Tip")]
	public GameObject TipContainer; // 0x150
	public TextProxy TipText; // 0x158
	private CharacterSelectOnlineBadge.OnlineBadgeType badgeType; // 0x160

	// Methods

	// RVA: 0x789990 Offset: 0x787F90 VA: 0x180789990
	public void OpenProfileOptions() { }

	// RVA: 0x789960 Offset: 0x787F60 VA: 0x180789960
	public void HideProfileOptions() { }

	// RVA: 0x789A70 Offset: 0x788070 VA: 0x180789A70
	public void SetBadgeType(CharacterSelectOnlineBadge.OnlineBadgeType newBadgeType) { }

	// RVA: 0x789F30 Offset: 0x788530 VA: 0x180789F30
	public void SetRealPlayerData(string playerName, int characterID, int costume, bool randomCharacter, bool ready, PlayerCustomization playerCustomization, GamePlatform platform, string playerID) { }

	// RVA: 0x789B40 Offset: 0x788140 VA: 0x180789B40
	public void SetCPUData(string playerName, int characterID, int costume) { }

	// RVA: 0x789EA0 Offset: 0x7884A0 VA: 0x180789EA0
	public void SetFilledCPUData() { }

	// RVA: 0x78A670 Offset: 0x788C70 VA: 0x18078A670
	public void SetTipData(string tipMessage) { }

	// RVA: 0x789720 Offset: 0x787D20 VA: 0x180789720
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x7895B0 Offset: 0x787BB0 VA: 0x1807895B0
	private void CPUCharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x789890 Offset: 0x787E90 VA: 0x180789890
	public void Disable() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
