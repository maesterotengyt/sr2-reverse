// Namespace: 
public class OnlineProperties : StellarOnlineProperties // TypeDefIndex: 2705
{
	// Fields
	public string LobbyTypeID; // 0xC0
	public string LobbyRatingID; // 0xC8
	public string LobbyPasswordHiddenID; // 0xD0
	public string MatchStageID; // 0xD8
	public string MatchStageLayoutID; // 0xE0
	public string MatchActiveID; // 0xE8
	public string PlayerRatingID; // 0xF0
	public string PlayerLobbyLocationID; // 0xF8
	public string PlayerStageID; // 0x100
	public string PlayerStageLayoutID; // 0x108
	public string PlayerCharacterIsRandomID; // 0x110
	public string PlayerStageIsRandomID; // 0x118
	public string PlayerTeamID; // 0x120
	public string PlayerCharacterReadyID; // 0x128
	public string PlayerLevelReadyID; // 0x130
	public string PlayerCustomizationID; // 0x138
	public string MatchGameModeID; // 0x140
	public string CPUsLobbyInfoID; // 0x148
	public string CPUsNumberID; // 0x150
	public string CPUsDifficultyID; // 0x158
	private int stageID; // 0x160
	private string stageLayout; // 0x168
	private int playerCharacterID; // 0x170
	private int playerCharacterCostume; // 0x174
	private bool playerCharacterRandom; // 0x178
	private PlayerLobbyLocation playerLobbyLocation; // 0x17C
	private int playerTeam; // 0x180

	// Properties
	private OnlineManager onlineManager { get; }
	private UIManager uiManager { get; }

	// Methods

	// RVA: 0x733D00 Offset: 0x732300 VA: 0x180733D00
	private OnlineManager get_onlineManager() { }

	// RVA: 0x733D50 Offset: 0x732350 VA: 0x180733D50
	private UIManager get_uiManager() { }

	// RVA: 0x733270 Offset: 0x731870 VA: 0x180733270
	public void SetCPUsLobbyInfo(CPULobbyInfo cpusInfo) { }

	// RVA: 0x7324C0 Offset: 0x730AC0 VA: 0x1807324C0
	public CPULobbyInfo GetCPUsLobbyInfo() { }

	// RVA: 0x733440 Offset: 0x731A40 VA: 0x180733440
	public void SetLobbyType(OnlineLobbyType lobbyType) { }

	// RVA: 0x7326A0 Offset: 0x730CA0 VA: 0x1807326A0
	public OnlineLobbyType GetLobbyType() { }

	// RVA: 0x733500 Offset: 0x731B00 VA: 0x180733500
	public void SetMatchStageID(int stageID) { }

	// RVA: 0x732760 Offset: 0x730D60 VA: 0x180732760
	public int GetMatchStageID() { }

	// RVA: 0x733790 Offset: 0x731D90 VA: 0x180733790
	public void SetPlayerRating(int rating) { }

	// RVA: 0x732BF0 Offset: 0x7311F0 VA: 0x180732BF0
	public int GetPlayerRating(Player player) { }

	// RVA: 0x733550 Offset: 0x731B50 VA: 0x180733550
	public void SetMatchStageLayout(string stageLayout) { }

	// RVA: 0x732800 Offset: 0x730E00 VA: 0x180732800
	public string GetMatchStageLayout() { }

	// RVA: 0x733640 Offset: 0x731C40 VA: 0x180733640
	public void SetPlayerCustomizationID(string playerCustomization) { }

	// RVA: 0x733610 Offset: 0x731C10 VA: 0x180733610
	public void SetPlayerCustomizationID(PlayerCustomization playerCustomization) { }

	// RVA: 0x732910 Offset: 0x730F10 VA: 0x180732910
	public string GetPlayerCustomizationString(Player player) { }

	// RVA: 0x732990 Offset: 0x730F90 VA: 0x180732990
	public PlayerCustomization GetPlayerCustomization(Player player) { }

	// RVA: 0x7334B0 Offset: 0x731AB0 VA: 0x1807334B0
	public void SetMatchActive(bool started) { }

	// RVA: 0x732710 Offset: 0x730D10 VA: 0x180732710
	public bool GetMatchActive() { }

	// RVA: 0x7336B0 Offset: 0x731CB0 VA: 0x1807336B0
	public void SetPlayerLobbyLocation(PlayerLobbyLocation location) { }

	// RVA: 0x733720 Offset: 0x731D20 VA: 0x180733720
	public void SetPlayerLobbyLocation(Player player, PlayerLobbyLocation location) { }

	// RVA: 0x732AF0 Offset: 0x7310F0 VA: 0x180732AF0
	public PlayerLobbyLocation GetPlayerLobbyLocation() { }

	// RVA: 0x732B60 Offset: 0x731160 VA: 0x180732B60
	public PlayerLobbyLocation GetPlayerLobbyLocation(Player player) { }

	// RVA: 0x7333F0 Offset: 0x7319F0 VA: 0x1807333F0
	public void SetLobbyRating(int rating) { }

	// RVA: 0x732650 Offset: 0x730C50 VA: 0x180732650
	public int GetLobbyRating() { }

	// RVA: 0x7333A0 Offset: 0x7319A0 VA: 0x1807333A0
	public void SetLobbyPasswordHidden(bool hidden) { }

	// RVA: 0x732600 Offset: 0x730C00 VA: 0x180732600
	public bool GetLobbyPasswordHidden() { }

	// RVA: 0x7337E0 Offset: 0x731DE0 VA: 0x1807337E0
	public void SetPlayerStageID(int stageID) { }

	// RVA: 0x732C40 Offset: 0x731240 VA: 0x180732C40
	public int GetPlayerStageID(Player player) { }

	// RVA: 0x733880 Offset: 0x731E80 VA: 0x180733880
	public void SetPlayerStageLayout(string stageLayout) { }

	// RVA: 0x732D40 Offset: 0x731340 VA: 0x180732D40
	public string GetPlayerStageLayout(Player player) { }

	// RVA: 0x733570 Offset: 0x731B70 VA: 0x180733570
	public void SetPlayerCharacterIsRandom(bool isRandom) { }

	// RVA: 0x732870 Offset: 0x730E70 VA: 0x180732870
	public bool GetPlayerCharacterIsRandom(Player player) { }

	// RVA: 0x733830 Offset: 0x731E30 VA: 0x180733830
	public void SetPlayerStageIsRandom(bool isRandom) { }

	// RVA: 0x732CF0 Offset: 0x7312F0 VA: 0x180732CF0
	public bool GetPlayerStageIsRandom(Player player) { }

	// RVA: 0x733900 Offset: 0x731F00 VA: 0x180733900
	public void SetPlayerTeam(int team) { }

	// RVA: 0x7338A0 Offset: 0x731EA0 VA: 0x1807338A0
	public void SetPlayerTeam(Player player, int team) { }

	// RVA: 0x732DC0 Offset: 0x7313C0 VA: 0x180732DC0
	public int GetPlayerTeam(Player player) { }

	// RVA: 0x7335C0 Offset: 0x731BC0 VA: 0x1807335C0
	public void SetPlayerCharacterReady(bool ready) { }

	// RVA: 0x7328C0 Offset: 0x730EC0 VA: 0x1807328C0
	public bool GetPlayerCharacterReady(Player player) { }

	// RVA: 0x733660 Offset: 0x731C60 VA: 0x180733660
	public void SetPlayerLevelReady(bool ready) { }

	// RVA: 0x732AA0 Offset: 0x7310A0 VA: 0x180732AA0
	public bool GetPlayerLevelReady(Player player) { }

	// RVA: 0x733350 Offset: 0x731950 VA: 0x180733350
	public void SetGameMode(int gameMode) { }

	// RVA: 0x732560 Offset: 0x730B60 VA: 0x180732560
	public int GetGameMode() { }

	// RVA: 0x732F90 Offset: 0x731590 VA: 0x180732F90 Slot: 4
	public override void SaveMatchProperties() { }

	// RVA: 0x732E10 Offset: 0x731410 VA: 0x180732E10 Slot: 5
	public override void RestoreMatchProperties() { }

	// RVA: 0x7330B0 Offset: 0x7316B0 VA: 0x1807330B0 Slot: 6
	public override void SavePlayerProperties() { }

	// RVA: 0x732E80 Offset: 0x731480 VA: 0x180732E80 Slot: 7
	public override void RestorePlayerProperties() { }

	// RVA: 0x733950 Offset: 0x731F50 VA: 0x180733950
	public void .ctor() { }
}
