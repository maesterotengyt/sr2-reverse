// Namespace: 
public class StellarOnlineSystem : StellarMonoBehaviour // TypeDefIndex: 3392
{
	// Fields
	[Header("Stellar Managers")]
	public StellarServerOperations ServerOperations; // 0x20
	public StellarMatchmakingSystem MatchmakingSystem; // 0x28
	public StellarRoomMigrator RoomMigrator; // 0x30
	public StellarOnlineProperties Properties; // 0x38
	public PhotonCallbacks PhotonCallbacks; // 0x40
	public StellarOnlineTimer StellarOnlineTimer; // 0x48
	public NetworkClient Client; // 0x50
	[CompilerGenerated]
	private bool <OnlineActive>k__BackingField; // 0x58
	[CompilerGenerated]
	private PlayerRef <OnlinePlayerRef>k__BackingField; // 0x5C
	[CompilerGenerated]
	private string <CurrentOnlineRegion>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <CrossplayEnabled>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <CrossplayMatchActive>k__BackingField; // 0x69
	[CompilerGenerated]
	private bool <OnlineMatchActive>k__BackingField; // 0x6A
	[CompilerGenerated]
	private Dictionary<string, RoomInfo> <CurrentPhotonRooms>k__BackingField; // 0x70
	[CompilerGenerated]
	private List<Player> <CachedRoomPlayers>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <IsInPhotonRoom>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <LeavingLobby>k__BackingField; // 0x81
	[CompilerGenerated]
	private BrainCloudWrapper <BrainCloudWrapper>k__BackingField; // 0x88

	// Properties
	public bool IsConnected { get; }
	public bool IsMasterClient { get; }
	public Player CurrentPlayer { get; }
	public Room RoomData { get; }
	public bool OnlineActive { get; set; }
	public PlayerRef OnlinePlayerRef { get; set; }
	public string CurrentOnlineRegion { get; set; }
	public bool CrossplayEnabled { get; set; }
	public bool CrossplayMatchActive { get; set; }
	public bool OnlineMatchActive { get; set; }
	public Dictionary<string, RoomInfo> CurrentPhotonRooms { get; set; }
	public List<Player> CachedRoomPlayers { get; set; }
	public bool IsInPhotonRoom { get; set; }
	public bool LeavingLobby { get; set; }
	public BrainCloudWrapper BrainCloudWrapper { get; set; }

	// Methods

	// RVA: 0x5DC850 Offset: 0x5DAE50 VA: 0x1805DC850
	public bool get_IsConnected() { }

	// RVA: 0x5DC880 Offset: 0x5DAE80 VA: 0x1805DC880
	public bool get_IsMasterClient() { }

	// RVA: 0x5DC830 Offset: 0x5DAE30 VA: 0x1805DC830
	public Player get_CurrentPlayer() { }

	// RVA: 0x5DC8F0 Offset: 0x5DAEF0 VA: 0x1805DC8F0
	public Room get_RoomData() { }

	[CompilerGenerated]
	// RVA: 0x5818C0 Offset: 0x57FEC0 VA: 0x1805818C0
	public bool get_OnlineActive() { }

	[CompilerGenerated]
	// RVA: 0x581900 Offset: 0x57FF00 VA: 0x180581900
	public void set_OnlineActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5DC8E0 Offset: 0x5DAEE0 VA: 0x1805DC8E0
	public PlayerRef get_OnlinePlayerRef() { }

	[CompilerGenerated]
	// RVA: 0x5DC980 Offset: 0x5DAF80 VA: 0x1805DC980
	public void set_OnlinePlayerRef(PlayerRef value) { }

	[CompilerGenerated]
	// RVA: 0x5818A0 Offset: 0x57FEA0 VA: 0x1805818A0
	public string get_CurrentOnlineRegion() { }

	[CompilerGenerated]
	// RVA: 0x5B45C0 Offset: 0x5B2BC0 VA: 0x1805B45C0
	public void set_CurrentOnlineRegion(string value) { }

	[CompilerGenerated]
	// RVA: 0x5DC800 Offset: 0x5DAE00 VA: 0x1805DC800
	public bool get_CrossplayEnabled() { }

	[CompilerGenerated]
	// RVA: 0x5DC920 Offset: 0x5DAF20 VA: 0x1805DC920
	public void set_CrossplayEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5DC810 Offset: 0x5DAE10 VA: 0x1805DC810
	public bool get_CrossplayMatchActive() { }

	[CompilerGenerated]
	// RVA: 0x5DC930 Offset: 0x5DAF30 VA: 0x1805DC930
	public void set_CrossplayMatchActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5DC8D0 Offset: 0x5DAED0 VA: 0x1805DC8D0
	public bool get_OnlineMatchActive() { }

	[CompilerGenerated]
	// RVA: 0x5DC970 Offset: 0x5DAF70 VA: 0x1805DC970
	public void set_OnlineMatchActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public Dictionary<string, RoomInfo> get_CurrentPhotonRooms() { }

	[CompilerGenerated]
	// RVA: 0x5DC940 Offset: 0x5DAF40 VA: 0x1805DC940
	public void set_CurrentPhotonRooms(Dictionary<string, RoomInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x5DC7F0 Offset: 0x5DADF0 VA: 0x1805DC7F0
	public List<Player> get_CachedRoomPlayers() { }

	[CompilerGenerated]
	// RVA: 0x5DC910 Offset: 0x5DAF10 VA: 0x1805DC910
	public void set_CachedRoomPlayers(List<Player> value) { }

	[CompilerGenerated]
	// RVA: 0x5DC870 Offset: 0x5DAE70 VA: 0x1805DC870
	public bool get_IsInPhotonRoom() { }

	[CompilerGenerated]
	// RVA: 0x5DC950 Offset: 0x5DAF50 VA: 0x1805DC950
	public void set_IsInPhotonRoom(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5DC8C0 Offset: 0x5DAEC0 VA: 0x1805DC8C0
	public bool get_LeavingLobby() { }

	[CompilerGenerated]
	// RVA: 0x5DC960 Offset: 0x5DAF60 VA: 0x1805DC960
	public void set_LeavingLobby(bool value) { }

	[CompilerGenerated]
	// RVA: 0x531670 Offset: 0x52FC70 VA: 0x180531670
	public BrainCloudWrapper get_BrainCloudWrapper() { }

	[CompilerGenerated]
	// RVA: 0x54C3B0 Offset: 0x54A9B0 VA: 0x18054C3B0
	public void set_BrainCloudWrapper(BrainCloudWrapper value) { }

	// RVA: 0x5DB0B0 Offset: 0x5D96B0 VA: 0x1805DB0B0
	public void Initialize() { }

	// RVA: 0x5D9AD0 Offset: 0x5D80D0 VA: 0x1805D9AD0
	public bool CheckInternetConnection() { }

	// RVA: 0x5D9DF0 Offset: 0x5D83F0 VA: 0x1805D9DF0
	public void ConnectOnline() { }

	// RVA: 0x5DBB00 Offset: 0x5DA100 VA: 0x1805DBB00
	private void PlatformOnlineConnectionFinished(bool success, string errorID) { }

	// RVA: 0x5DB290 Offset: 0x5D9890 VA: 0x1805DB290
	private void JoinedPhotonLobby() { }

	// RVA: 0x5DB880 Offset: 0x5D9E80 VA: 0x1805DB880
	private void OnlineDisconnected() { }

	// RVA: 0x5DAEB0 Offset: 0x5D94B0 VA: 0x1805DAEB0
	public List<RoomInfo> GetRoomList() { }

	// RVA: 0x5DA510 Offset: 0x5D8B10 VA: 0x1805DA510
	public string GetCurrentRoomID() { }

	// RVA: 0x5DA580 Offset: 0x5D8B80 VA: 0x1805DA580
	public List<Player> GetPlayersList(bool excludeSpectators = False) { }

	// RVA: 0x5DAC70 Offset: 0x5D9270 VA: 0x1805DAC70
	public RegionData GetRegionData(string code) { }

	// RVA: 0x5DC4E0 Offset: 0x5DAAE0 VA: 0x1805DC4E0
	public void SetPlayerDataInRoom() { }

	// RVA: 0x5D9F90 Offset: 0x5D8590 VA: 0x1805D9F90
	public string GenerateRoomID() { }

	// RVA: 0x5DB520 Offset: 0x5D9B20 VA: 0x1805DB520
	public void MarkMatchActiveFlags() { }

	// RVA: 0x5DC200 Offset: 0x5DA800 VA: 0x1805DC200
	public void SendEvent(PhotonEventCode code) { }

	// RVA: 0x5DC080 Offset: 0x5DA680 VA: 0x1805DC080
	public void SendEvent(PhotonEventCode code, object content) { }

	// RVA: 0x5DBEC0 Offset: 0x5DA4C0 VA: 0x1805DBEC0
	public void SendEventToActor(PhotonEventCode code, int actorNumber) { }

	// RVA: 0x5DC370 Offset: 0x5DA970 VA: 0x1805DC370
	public void SendMessageEvent(string message) { }

	// RVA: 0x5DA540 Offset: 0x5D8B40 VA: 0x1805DA540
	public PlayerState GetPlayerState() { }

	// RVA: 0x5DA2E0 Offset: 0x5D88E0 VA: 0x1805DA2E0
	public int GetAvailableSpawnOrder(bool ignoreOwnPlayer = True) { }

	// RVA: 0x5DB120 Offset: 0x5D9720 VA: 0x1805DB120
	public bool IsSpawnOrderAvailable(int spawnOrder) { }

	// RVA: 0x5D99E0 Offset: 0x5D7FE0 VA: 0x1805D99E0
	public bool CheckIfRoomExist(string photonRoom) { }

	// RVA: 0x5D9770 Offset: 0x5D7D70 VA: 0x1805D9770
	public void CacheCurrentRoomPlayers() { }

	// RVA: 0x5D9BC0 Offset: 0x5D81C0 VA: 0x1805D9BC0
	public void CleanOnlineData() { }

	// RVA: 0x5DC6C0 Offset: 0x5DACC0 VA: 0x1805DC6C0
	public void .ctor() { }
}
