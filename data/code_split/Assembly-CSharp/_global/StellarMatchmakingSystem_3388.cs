// Namespace: 
public class StellarMatchmakingSystem : StellarMonoBehaviour // TypeDefIndex: 3388
{
	// Fields
	private bool platformLobbyNeeded; // 0x20
	private bool publicLobby; // 0x21
	private string platformLobbyID; // 0x28
	private string photonRoomID; // 0x30
	private LobbyJoinMethod lobbyJoinMethod; // 0x38

	// Properties
	private StellarOnlineProperties properties { get; }

	// Methods

	// RVA: 0x5D6D40 Offset: 0x5D5340 VA: 0x1805D6D40
	private StellarOnlineProperties get_properties() { }

	// RVA: 0x5D3B20 Offset: 0x5D2120 VA: 0x1805D3B20
	public void CreateLobby(string roomID, string password, bool publicLobby, int maxPlayers, Hashtable customProperties, string[] publicProperties, bool platformLobbyNeeded) { }

	// RVA: 0x5D4F80 Offset: 0x5D3580 VA: 0x1805D4F80
	private void JoinedPhotonRoomAfterCreation(bool success, string message) { }

	// RVA: 0x5D61D0 Offset: 0x5D47D0 VA: 0x1805D61D0
	private void PlatformLobbyCreationFinished(bool success, string platformLobbyID) { }

	// RVA: 0x5D4390 Offset: 0x5D2990 VA: 0x1805D4390
	public void JoinLobbyWithPhotonRoomID(string photonRoomID, string lobbyRegion = "", bool platformLobbyNeeded = True) { }

	// RVA: 0x5D6A40 Offset: 0x5D5040 VA: 0x1805D6A40
	private void RegionChanged(bool success, string errorID = "") { }

	// RVA: 0x5D46F0 Offset: 0x5D2CF0 VA: 0x1805D46F0
	private void JoinPhotonRoom() { }

	// RVA: 0x5D4580 Offset: 0x5D2B80 VA: 0x1805D4580
	public void JoinLobbyWithPlatformLobbyID(string platformLobbyID) { }

	// RVA: 0x5D5370 Offset: 0x5D3970 VA: 0x1805D5370
	private void JoinedPhotonRoom(bool success, string message) { }

	// RVA: 0x5D4A40 Offset: 0x5D3040 VA: 0x1805D4A40
	private void JoinPlatformLobbyOrFinish() { }

	// RVA: 0x5D6410 Offset: 0x5D4A10 VA: 0x1805D6410
	private void PlatformLobbyJoin(bool success) { }

	// RVA: 0x5D5EF0 Offset: 0x5D44F0 VA: 0x1805D5EF0
	private void PlatformLobbyCreationAfterJoining(bool success, string platformLobbyID) { }

	// RVA: 0x5D5740 Offset: 0x5D3D40 VA: 0x1805D5740
	public void LeaveLobby() { }

	// RVA: 0x5D5B80 Offset: 0x5D4180 VA: 0x1805D5B80
	private void PhotonRoomLeave() { }

	// RVA: 0x5D6890 Offset: 0x5D4E90 VA: 0x1805D6890
	private void PlatformLobbyLeft() { }

	// RVA: 0x5D4270 Offset: 0x5D2870 VA: 0x1805D4270
	private RoomOptions GetRoomOptions() { }

	// RVA: 0x5D5910 Offset: 0x5D3F10 VA: 0x1805D5910
	private static string LogHashtable(Hashtable ht) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5D6C10 Offset: 0x5D5210 VA: 0x1805D6C10
	private void <JoinedPhotonRoom>b__14_0() { }
}
