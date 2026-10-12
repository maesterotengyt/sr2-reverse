// Namespace: 
public class StellarRoomMigrator : StellarMonoBehaviour // TypeDefIndex: 3402
{
	// Fields
	public static StellarRoomMigrator.OnTimeoutEvent TimeoutEvent; // 0x0
	public List<string> PlayerNames; // 0x20
	private bool isMaster; // 0x28
	private string newRoomID; // 0x30
	private int playerCount; // 0x38
	private StellarRoomMigrator.RoomMigrationState currentState; // 0x3C
	private float timeoutForCancelling; // 0x40
	private float timeoutCounter; // 0x44
	private bool lobbyVisible; // 0x48
	private string lobbyPassword; // 0x50
	private int maxPlayers; // 0x58
	private Hashtable customProperties; // 0x60
	private string[] propertiesListedInLobby; // 0x68

	// Methods

	// RVA: 0x5DE1E0 Offset: 0x5DC7E0 VA: 0x1805DE1E0
	public void StartMigration(float timeoutForCancelling = 15) { }

	// RVA: 0x5DDA90 Offset: 0x5DC090 VA: 0x1805DDA90
	private void PhotonRoomLeave() { }

	// RVA: 0x5DD2F0 Offset: 0x5DB8F0 VA: 0x1805DD2F0
	private void JoinedPhotonLobby() { }

	// RVA: 0x5DEA50 Offset: 0x5DD050 VA: 0x1805DEA50
	private void Update() { }

	// RVA: 0x5DD800 Offset: 0x5DBE00 VA: 0x1805DD800
	private void MasterCreatedNewRoom(bool success) { }

	// RVA: 0x5DD5D0 Offset: 0x5DBBD0 VA: 0x1805DD5D0
	private void JoinedPhotonRoom(bool success, string message) { }

	// RVA: 0x5DD1F0 Offset: 0x5DB7F0 VA: 0x1805DD1F0
	private void CheckTimeout() { }

	// RVA: 0x5DD270 Offset: 0x5DB870 VA: 0x1805DD270
	public void FinishMigration() { }

	// RVA: 0x5DDD30 Offset: 0x5DC330 VA: 0x1805DDD30
	public void PrintReport() { }

	// RVA: 0x5DF2E0 Offset: 0x5DD8E0 VA: 0x1805DF2E0
	public void .ctor() { }
}
