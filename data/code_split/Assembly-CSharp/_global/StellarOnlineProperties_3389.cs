// Namespace: 
public class StellarOnlineProperties // TypeDefIndex: 3389
{
	// Fields
	public string LobbyVersionID; // 0x10
	public string LobbyVisibleID; // 0x18
	public string LobbyPasswordID; // 0x20
	public string LobbyRegionID; // 0x28
	public string LobbyCrossplayEnabledID; // 0x30
	public string LobbyOwnerNameID; // 0x38
	public string LobbyMaxPlayersID; // 0x40
	public string SimulationActiveID; // 0x48
	public string SimulationSeedID; // 0x50
	public string PlayerPlatformID; // 0x58
	public string PlayerPlatformUserID; // 0x60
	public string PlayerSpawnOrderID; // 0x68
	public string PlayerStateID; // 0x70
	public string PlayerPingID; // 0x78
	public string PlayerCharacterID; // 0x80
	public string PlayerCharacterCostumeID; // 0x88
	public string PlayerIsSpectatorID; // 0x90
	public string NewPhotonRoomID; // 0x98
	public string PlayerMigrationReadyID; // 0xA0
	private List<GamePlatform> platforms; // 0xA8
	private List<string> platformsLobbyIDs; // 0xB0
	private int playerSpawnOrder; // 0xB8
	private bool playerIsSpectator; // 0xBC

	// Properties
	protected StellarOnlineSystem onlineSystem { get; }
	private NetworkClient client { get; }

	// Methods

	// RVA: 0x5D9720 Offset: 0x5D7D20 VA: 0x1805D9720
	protected StellarOnlineSystem get_onlineSystem() { }

	// RVA: 0x5D96D0 Offset: 0x5D7CD0 VA: 0x1805D96D0
	private NetworkClient get_client() { }

	// RVA: 0x5D86C0 Offset: 0x5D6CC0 VA: 0x1805D86C0
	public void SetLobbyVisible(bool visible) { }

	// RVA: 0x5D6F50 Offset: 0x5D5550 VA: 0x1805D6F50
	public bool GetLobbyVisible() { }

	// RVA: 0x5D8690 Offset: 0x5D6C90 VA: 0x1805D8690
	public void SetLobbyPassword(string password) { }

	// RVA: 0x5D6E00 Offset: 0x5D5400 VA: 0x1805D6E00
	public string GetLobbyPassword() { }

	// RVA: 0x5D86A0 Offset: 0x5D6CA0 VA: 0x1805D86A0
	public void SetLobbyRegion(string region) { }

	// RVA: 0x5D6E70 Offset: 0x5D5470 VA: 0x1805D6E70
	public string GetLobbyRegion() { }

	// RVA: 0x5D85E0 Offset: 0x5D6BE0 VA: 0x1805D85E0
	public void SetLobbyCrossplayEnabled(bool enabled) { }

	// RVA: 0x5D6D60 Offset: 0x5D5360 VA: 0x1805D6D60
	public bool GetLobbyCrossplayEnabled() { }

	// RVA: 0x5D86B0 Offset: 0x5D6CB0 VA: 0x1805D86B0
	public void SetLobbyVersion(string version) { }

	// RVA: 0x5D6EE0 Offset: 0x5D54E0 VA: 0x1805D6EE0
	public string GetLobbyVersion() { }

	// RVA: 0x5D8680 Offset: 0x5D6C80 VA: 0x1805D8680
	public void SetLobbyOwnerName(string ownerName) { }

	// RVA: 0x5D7010 Offset: 0x5D5610 VA: 0x1805D7010
	public string GetOwnerName() { }

	// RVA: 0x5D8630 Offset: 0x5D6C30 VA: 0x1805D8630
	public void SetLobbyMaxPlayers(int amount) { }

	// RVA: 0x5D6DB0 Offset: 0x5D53B0 VA: 0x1805D6DB0
	public int GetLobbyMaxPlayers() { }

	// RVA: 0x5D9260 Offset: 0x5D7860 VA: 0x1805D9260
	public void SetSimulationActive(bool active) { }

	// RVA: 0x5D7ED0 Offset: 0x5D64D0 VA: 0x1805D7ED0
	public bool GetSimulationActive() { }

	// RVA: 0x5D92B0 Offset: 0x5D78B0 VA: 0x1805D92B0
	public void SetSimulationSeed(int simulationSeed) { }

	// RVA: 0x5D7F20 Offset: 0x5D6520 VA: 0x1805D7F20
	public int GetSimulationSeed() { }

	// RVA: 0x5D8C60 Offset: 0x5D7260 VA: 0x1805D8C60
	public void SetPlayerPlatform(GamePlatform platform) { }

	// RVA: 0x5D7930 Offset: 0x5D5F30 VA: 0x1805D7930
	public GamePlatform GetPlayerPlatform(Player player) { }

	// RVA: 0x5D8C50 Offset: 0x5D7250 VA: 0x1805D8C50
	public void SetPlayerPlatformUserID(string userID) { }

	// RVA: 0x5D7870 Offset: 0x5D5E70 VA: 0x1805D7870
	public string GetPlayerPlatformUserID(Player player) { }

	// RVA: 0x5D8EB0 Offset: 0x5D74B0 VA: 0x1805D8EB0
	public void SetPlayerSpawnOrder(int spawnOrder) { }

	// RVA: 0x5D8F00 Offset: 0x5D7500 VA: 0x1805D8F00
	public void SetPlayerSpawnOrder(Player player, int spawnOrder) { }

	// RVA: 0x5D7B80 Offset: 0x5D6180 VA: 0x1805D7B80
	public int GetPlayerSpawnOrder(Player player) { }

	// RVA: 0x5D7B30 Offset: 0x5D6130 VA: 0x1805D7B30
	public int GetPlayerSpawnOrder() { }

	// RVA: 0x5D8FC0 Offset: 0x5D75C0 VA: 0x1805D8FC0
	public void SetPlayerState(PlayerState state) { }

	// RVA: 0x5D7C30 Offset: 0x5D6230 VA: 0x1805D7C30
	public PlayerState GetPlayerState(Player player) { }

	// RVA: 0x5D7D00 Offset: 0x5D6300 VA: 0x1805D7D00
	public PlayerState GetPlayerState() { }

	// RVA: 0x5D8C00 Offset: 0x5D7200 VA: 0x1805D8C00
	public void SetPlayerPing(int ping) { }

	// RVA: 0x5D77C0 Offset: 0x5D5DC0 VA: 0x1805D77C0
	public int GetPlayerPing(Player player) { }

	// RVA: 0x5D89A0 Offset: 0x5D6FA0 VA: 0x1805D89A0
	public void SetPlayerCharacter(int characterID) { }

	// RVA: 0x5D8A20 Offset: 0x5D7020 VA: 0x1805D8A20
	public void SetPlayerCharacter(int characterID, int partnerCharacterIndex) { }

	// RVA: 0x5D74F0 Offset: 0x5D5AF0 VA: 0x1805D74F0
	public int GetPlayerCharacter(Player player) { }

	// RVA: 0x5D73D0 Offset: 0x5D59D0 VA: 0x1805D73D0
	public int GetPlayerCharacter(Player player, int partnerCharacterIndex) { }

	// RVA: 0x5D88A0 Offset: 0x5D6EA0 VA: 0x1805D88A0
	public void SetPlayerCharacterCostume(int costume) { }

	// RVA: 0x5D8920 Offset: 0x5D6F20 VA: 0x1805D8920
	public void SetPlayerCharacterCostume(int costume, int playerCharacterIndex) { }

	// RVA: 0x5D7300 Offset: 0x5D5900 VA: 0x1805D7300
	public int GetPlayerCharacterCostume(Player player) { }

	// RVA: 0x5D7230 Offset: 0x5D5830 VA: 0x1805D7230
	public int GetPlayerCharacterCostume(Player player, int playerCharacterIndex) { }

	// RVA: 0x5D8AA0 Offset: 0x5D70A0 VA: 0x1805D8AA0
	public void SetPlayerIsSpectator(bool isSpectator) { }

	// RVA: 0x5D8AF0 Offset: 0x5D70F0 VA: 0x1805D8AF0
	public void SetPlayerIsSpectator(Player player, bool isSpectator) { }

	// RVA: 0x5D7660 Offset: 0x5D5C60 VA: 0x1805D7660
	public bool GetPlayerIsSpectator(Player player) { }

	// RVA: 0x5D7610 Offset: 0x5D5C10 VA: 0x1805D7610
	public bool GetPlayerIsSpectator() { }

	// RVA: 0x5D8710 Offset: 0x5D6D10 VA: 0x1805D8710
	public void SetNewPhotonRoomID(string roomID) { }

	// RVA: 0x5D6FA0 Offset: 0x5D55A0 VA: 0x1805D6FA0
	public string GetNewPhotonRoomID() { }

	// RVA: 0x5D8BB0 Offset: 0x5D71B0 VA: 0x1805D8BB0
	public void SetPlayerMigrationReady(bool ready) { }

	// RVA: 0x5D7710 Offset: 0x5D5D10 VA: 0x1805D7710
	public bool GetPlayerMigrationReady(Player player) { }

	// RVA: 0x5D8730 Offset: 0x5D6D30 VA: 0x1805D8730
	public void SetPlatformLobbyID(string lobbyID) { }

	// RVA: 0x5D8800 Offset: 0x5D6E00 VA: 0x1805D8800
	public void SetPlatformLobbyID(string lobbyID, GamePlatform platform) { }

	// RVA: 0x5D7140 Offset: 0x5D5740 VA: 0x1805D7140
	public string GetPlatformLobbyID() { }

	// RVA: 0x5D7080 Offset: 0x5D5680 VA: 0x1805D7080
	public string GetPlatformLobbyID(GamePlatform platform) { }

	// RVA: 0x5D90B0 Offset: 0x5D76B0 VA: 0x1805D90B0
	protected void SetRoomProperty(string propertyName, object state) { }

	// RVA: 0x5D7D70 Offset: 0x5D6370 VA: 0x1805D7D70
	protected object GetRoomProperty(string propertyName) { }

	// RVA: 0x5D8E10 Offset: 0x5D7410 VA: 0x1805D8E10
	protected void SetPlayerRoomProperty(Player player, string propertyName, object state) { }

	// RVA: 0x5D8CD0 Offset: 0x5D72D0 VA: 0x1805D8CD0
	protected void SetPlayerRoomProperty(string propertyName, object state) { }

	// RVA: 0x5D7AC0 Offset: 0x5D60C0 VA: 0x1805D7AC0
	protected object GetPlayerRoomProperty(Player player, string propertyName) { }

	// RVA: 0x5D7A00 Offset: 0x5D6000 VA: 0x1805D7A00
	protected object GetPlayerRoomProperty(string propertyName) { }

	// RVA: 0x5D8140 Offset: 0x5D6740 VA: 0x1805D8140 Slot: 4
	public virtual void SaveMatchProperties() { }

	// RVA: 0x5D7F70 Offset: 0x5D6570 VA: 0x1805D7F70 Slot: 5
	public virtual void RestoreMatchProperties() { }

	// RVA: 0x5D8540 Offset: 0x5D6B40 VA: 0x1805D8540 Slot: 6
	public virtual void SavePlayerProperties() { }

	// RVA: 0x5D80C0 Offset: 0x5D66C0 VA: 0x1805D80C0 Slot: 7
	public virtual void RestorePlayerProperties() { }

	// RVA: 0x5D9300 Offset: 0x5D7900 VA: 0x1805D9300
	public void .ctor() { }
}
