// Namespace: 
public class StellarSteamOnlineSystem : StellarPlatformOnlineSystem // TypeDefIndex: 3458
{
	// Fields
	private Callback<LobbyEnter_t> lobbyEnterCallback; // 0x20
	private Callback<LobbyCreated_t> lobbyCreatedCallback; // 0x28
	private bool initialized; // 0x30
	private CSteamID steamIDLobby; // 0x34

	// Methods

	// RVA: 0x5F7050 Offset: 0x5F5650 VA: 0x1805F7050 Slot: 4
	public override bool CheckInternetConnection() { }

	// RVA: 0x5F70A0 Offset: 0x5F56A0 VA: 0x1805F70A0 Slot: 5
	public override void ConnectOnline() { }

	// RVA: 0x5F7170 Offset: 0x5F5770 VA: 0x1805F7170 Slot: 7
	public override void CreateOnlineLobby(bool publicLobby) { }

	// RVA: 0x5F76F0 Offset: 0x5F5CF0 VA: 0x1805F76F0
	private void OnLobbyCreated(LobbyCreated_t param) { }

	// RVA: 0x5F7510 Offset: 0x5F5B10 VA: 0x1805F7510 Slot: 8
	public override void JoinOnlineLobby(string platformLobbyID) { }

	// RVA: 0x5F7470 Offset: 0x5F5A70 VA: 0x1805F7470
	public void JoinLobby(CSteamID lobbyID) { }

	// RVA: 0x5F78E0 Offset: 0x5F5EE0 VA: 0x1805F78E0
	private void OnLobbyJoined(LobbyEnter_t param) { }

	// RVA: 0x5F7670 Offset: 0x5F5C70 VA: 0x1805F7670 Slot: 9
	public override void LeaveOnlineLobby() { }

	// RVA: 0x5F7B20 Offset: 0x5F6120 VA: 0x1805F7B20 Slot: 13
	public override void ShowInvitationMenu() { }

	// RVA: 0x5F7BF0 Offset: 0x5F61F0 VA: 0x1805F7BF0 Slot: 10
	public override void UpdatePhotonRoomID(string newPhotonRoomID) { }

	// RVA: 0x5F7430 Offset: 0x5F5A30 VA: 0x1805F7430 Slot: 11
	public override string GetPhotonRoomID() { }

	// RVA: 0x5F73F0 Offset: 0x5F59F0 VA: 0x1805F73F0 Slot: 12
	public override string GetLobbyRegion() { }

	// RVA: 0x5F7A50 Offset: 0x5F6050 VA: 0x1805F7A50 Slot: 6
	public override AuthenticationValues SetupPhotonAuthentication() { }

	// RVA: 0x5F72A0 Offset: 0x5F58A0 VA: 0x1805F72A0
	public string GetAuthToken() { }

	// RVA: 0x5F6C80 Offset: 0x5F5280 VA: 0x1805F6C80 Slot: 14
	public override void AuthenticateBraincloud() { }

	// RVA: 0x5F6F40 Offset: 0x5F5540 VA: 0x1805F6F40
	private string BytesToHex(byte[] bytes, int len) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5F7B30 Offset: 0x5F6130 VA: 0x1805F7B30
	private void <AuthenticateBraincloud>b__18_1(int status, int code, string error, object cbObject) { }
}
