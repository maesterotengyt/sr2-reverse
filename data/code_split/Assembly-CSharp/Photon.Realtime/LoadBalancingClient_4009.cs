// Namespace: Photon.Realtime
public class LoadBalancingClient : IPhotonPeerListener // TypeDefIndex: 4009
{
	// Fields
	[CompilerGenerated]
	private LoadBalancingPeer <LoadBalancingPeer>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <AppVersion>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <AppId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ClientAppType <ClientType>k__BackingField; // 0x28
	[CompilerGenerated]
	private AuthenticationValues <AuthValues>k__BackingField; // 0x30
	public AuthModeOption AuthMode; // 0x38
	public EncryptionMode EncryptionMode; // 0x3C
	[CompilerGenerated]
	private Nullable<ConnectionProtocol> <ExpectedProtocol>k__BackingField; // 0x40
	public AuthenticationValues PlarformValues; // 0x48
	private object tokenCache; // 0x50
	[CompilerGenerated]
	private bool <IsUsingNameServer>k__BackingField; // 0x58
	public string NameServerHost; // 0x60
	private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort; // 0x0
	[CompilerGenerated]
	private bool <UseAlternativeUdpPorts>k__BackingField; // 0x68
	public PhotonPortDefinition ServerPortOverrides; // 0x6A
	[CompilerGenerated]
	private bool <EnableProtocolFallback>k__BackingField; // 0x70
	[CompilerGenerated]
	private string <MasterServerAddress>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <GameServerAddress>k__BackingField; // 0x80
	[CompilerGenerated]
	private ServerConnection <Server>k__BackingField; // 0x88
	public string ProxyServerAddress; // 0x90
	private ClientState state; // 0x98
	[CompilerGenerated]
	private Action<ClientState, ClientState> StateChanged; // 0xA0
	[CompilerGenerated]
	private Action<EventData> EventReceived; // 0xA8
	[CompilerGenerated]
	private Action<OperationResponse> OpResponseReceived; // 0xB0
	public ConnectionCallbacksContainer ConnectionCallbackTargets; // 0xB8
	public MatchMakingCallbacksContainer MatchMakingCallbackTargets; // 0xC0
	internal InRoomCallbacksContainer InRoomCallbackTargets; // 0xC8
	internal LobbyCallbacksContainer LobbyCallbackTargets; // 0xD0
	internal WebRpcCallbacksContainer WebRpcCallbackTargets; // 0xD8
	internal ErrorInfoCallbacksContainer ErrorInfoCallbackTargets; // 0xE0
	[CompilerGenerated]
	private DisconnectCause <DisconnectedCause>k__BackingField; // 0xE8
	public SystemConnectionSummary SystemConnectionSummary; // 0xF0
	[CompilerGenerated]
	private TypedLobby <CurrentLobby>k__BackingField; // 0xF8
	public bool EnableLobbyStatistics; // 0x100
	private readonly List<TypedLobbyInfo> lobbyStatistics; // 0x108
	[CompilerGenerated]
	private Player <LocalPlayer>k__BackingField; // 0x110
	[CompilerGenerated]
	private Room <CurrentRoom>k__BackingField; // 0x118
	[CompilerGenerated]
	private int <PlayersOnMasterCount>k__BackingField; // 0x120
	[CompilerGenerated]
	private int <PlayersInRoomsCount>k__BackingField; // 0x124
	[CompilerGenerated]
	private int <RoomsCount>k__BackingField; // 0x128
	private JoinType lastJoinType; // 0x12C
	private EnterRoomParams enterRoomParamsCache; // 0x130
	private OperationResponse failedRoomEntryOperation; // 0x138
	private const int FriendRequestListMax = 512;
	private string[] friendListRequested; // 0x140
	[CompilerGenerated]
	private string <CloudRegion>k__BackingField; // 0x148
	[CompilerGenerated]
	private string <CurrentCluster>k__BackingField; // 0x150
	public RegionHandler RegionHandler; // 0x158
	private string bestRegionSummaryFromStorage; // 0x160
	public string SummaryToCache; // 0x168
	private bool connectToBestRegion; // 0x170
	private readonly Queue<LoadBalancingClient.CallbackTargetChange> callbackTargetChanges; // 0x178
	private readonly HashSet<object> callbackTargets; // 0x180
	public int NameServerPortInAppSettings; // 0x188

	// Properties
	public LoadBalancingPeer LoadBalancingPeer { get; set; }
	public SerializationProtocol SerializationProtocol { get; set; }
	public string AppVersion { get; set; }
	public string AppId { get; set; }
	public ClientAppType ClientType { get; set; }
	public AuthenticationValues AuthValues { get; set; }
	public Nullable<ConnectionProtocol> ExpectedProtocol { get; set; }
	private object TokenForInit { get; }
	public bool IsUsingNameServer { get; set; }
	public string NameServerAddress { get; }
	[Obsolete("Set port overrides in ServerPortOverrides. Not used anymore!")]
	public bool UseAlternativeUdpPorts { get; set; }
	public bool EnableProtocolFallback { get; set; }
	public string CurrentServerAddress { get; }
	public string MasterServerAddress { get; set; }
	public string GameServerAddress { get; set; }
	public ServerConnection Server { get; set; }
	public ClientState State { get; set; }
	public bool IsConnected { get; }
	public bool IsConnectedAndReady { get; }
	public DisconnectCause DisconnectedCause { get; set; }
	public bool InLobby { get; }
	public TypedLobby CurrentLobby { get; set; }
	public Player LocalPlayer { get; set; }
	public string NickName { get; set; }
	public string UserId { get; set; }
	public Room CurrentRoom { get; set; }
	public bool InRoom { get; }
	public int PlayersOnMasterCount { get; set; }
	public int PlayersInRoomsCount { get; set; }
	public int RoomsCount { get; set; }
	public bool IsFetchingFriendList { get; }
	public string CloudRegion { get; set; }
	public string CurrentCluster { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public LoadBalancingPeer get_LoadBalancingPeer() { }

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	private void set_LoadBalancingPeer(LoadBalancingPeer value) { }

	// RVA: 0x691770 Offset: 0x68FD70 VA: 0x180691770
	public SerializationProtocol get_SerializationProtocol() { }

	// RVA: 0x691AE0 Offset: 0x6900E0 VA: 0x180691AE0
	public void set_SerializationProtocol(SerializationProtocol value) { }

	[CompilerGenerated]
	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public string get_AppVersion() { }

	[CompilerGenerated]
	// RVA: 0x5B5080 Offset: 0x5B3680 VA: 0x1805B5080
	public void set_AppVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public string get_AppId() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	public void set_AppId(string value) { }

	[CompilerGenerated]
	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public ClientAppType get_ClientType() { }

	[CompilerGenerated]
	// RVA: 0x51AE50 Offset: 0x519450 VA: 0x18051AE50
	public void set_ClientType(ClientAppType value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public AuthenticationValues get_AuthValues() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_AuthValues(AuthenticationValues value) { }

	[CompilerGenerated]
	// RVA: 0x691640 Offset: 0x68FC40 VA: 0x180691640
	public Nullable<ConnectionProtocol> get_ExpectedProtocol() { }

	[CompilerGenerated]
	// RVA: 0x691A60 Offset: 0x690060 VA: 0x180691A60
	public void set_ExpectedProtocol(Nullable<ConnectionProtocol> value) { }

	// RVA: 0x6917A0 Offset: 0x68FDA0 VA: 0x1806917A0
	private object get_TokenForInit() { }

	[CompilerGenerated]
	// RVA: 0x5818C0 Offset: 0x57FEC0 VA: 0x1805818C0
	public bool get_IsUsingNameServer() { }

	[CompilerGenerated]
	// RVA: 0x581900 Offset: 0x57FF00 VA: 0x180581900
	public void set_IsUsingNameServer(bool value) { }

	// RVA: 0x691710 Offset: 0x68FD10 VA: 0x180691710
	public string get_NameServerAddress() { }

	[CompilerGenerated]
	// RVA: 0x5DC800 Offset: 0x5DAE00 VA: 0x1805DC800
	public bool get_UseAlternativeUdpPorts() { }

	[CompilerGenerated]
	// RVA: 0x5DC920 Offset: 0x5DAF20 VA: 0x1805DC920
	public void set_UseAlternativeUdpPorts(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5851F0 Offset: 0x5837F0 VA: 0x1805851F0
	public bool get_EnableProtocolFallback() { }

	[CompilerGenerated]
	// RVA: 0x5853A0 Offset: 0x5839A0 VA: 0x1805853A0
	public void set_EnableProtocolFallback(bool value) { }

	// RVA: 0x691610 Offset: 0x68FC10 VA: 0x180691610
	public string get_CurrentServerAddress() { }

	[CompilerGenerated]
	// RVA: 0x5DC7F0 Offset: 0x5DADF0 VA: 0x1805DC7F0
	public string get_MasterServerAddress() { }

	[CompilerGenerated]
	// RVA: 0x5DC910 Offset: 0x5DAF10 VA: 0x1805DC910
	public void set_MasterServerAddress(string value) { }

	[CompilerGenerated]
	// RVA: 0x54C330 Offset: 0x54A930 VA: 0x18054C330
	public string get_GameServerAddress() { }

	[CompilerGenerated]
	// RVA: 0x54C390 Offset: 0x54A990 VA: 0x18054C390
	protected internal void set_GameServerAddress(string value) { }

	[CompilerGenerated]
	// RVA: 0x5B7BD0 Offset: 0x5B61D0 VA: 0x1805B7BD0
	public ServerConnection get_Server() { }

	[CompilerGenerated]
	// RVA: 0x691B00 Offset: 0x690100 VA: 0x180691B00
	private void set_Server(ServerConnection value) { }

	// RVA: 0x691790 Offset: 0x68FD90 VA: 0x180691790
	public ClientState get_State() { }

	// RVA: 0x691B10 Offset: 0x690110 VA: 0x180691B10
	public void set_State(ClientState value) { }

	// RVA: 0x6916D0 Offset: 0x68FCD0 VA: 0x1806916D0
	public bool get_IsConnected() { }

	// RVA: 0x691680 Offset: 0x68FC80 VA: 0x180691680
	public bool get_IsConnectedAndReady() { }

	[CompilerGenerated]
	// RVA: 0x691530 Offset: 0x68FB30 VA: 0x180691530
	public void add_StateChanged(Action<ClientState, ClientState> value) { }

	[CompilerGenerated]
	// RVA: 0x691940 Offset: 0x68FF40 VA: 0x180691940
	public void remove_StateChanged(Action<ClientState, ClientState> value) { }

	[CompilerGenerated]
	// RVA: 0x6913D0 Offset: 0x68F9D0 VA: 0x1806913D0
	public void add_EventReceived(Action<EventData> value) { }

	[CompilerGenerated]
	// RVA: 0x6917E0 Offset: 0x68FDE0 VA: 0x1806917E0
	public void remove_EventReceived(Action<EventData> value) { }

	[CompilerGenerated]
	// RVA: 0x691480 Offset: 0x68FA80 VA: 0x180691480
	public void add_OpResponseReceived(Action<OperationResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x691890 Offset: 0x68FE90 VA: 0x180691890
	public void remove_OpResponseReceived(Action<OperationResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x691630 Offset: 0x68FC30 VA: 0x180691630
	public DisconnectCause get_DisconnectedCause() { }

	[CompilerGenerated]
	// RVA: 0x691A50 Offset: 0x690050 VA: 0x180691A50
	protected void set_DisconnectedCause(DisconnectCause value) { }

	// RVA: 0x691650 Offset: 0x68FC50 VA: 0x180691650
	public bool get_InLobby() { }

	[CompilerGenerated]
	// RVA: 0x691600 Offset: 0x68FC00 VA: 0x180691600
	public TypedLobby get_CurrentLobby() { }

	[CompilerGenerated]
	// RVA: 0x60C870 Offset: 0x60AE70 VA: 0x18060C870
	internal void set_CurrentLobby(TypedLobby value) { }

	[CompilerGenerated]
	// RVA: 0x691700 Offset: 0x68FD00 VA: 0x180691700
	public Player get_LocalPlayer() { }

	[CompilerGenerated]
	// RVA: 0x691A70 Offset: 0x690070 VA: 0x180691A70
	internal void set_LocalPlayer(Player value) { }

	// RVA: 0x691720 Offset: 0x68FD20 VA: 0x180691720
	public string get_NickName() { }

	// RVA: 0x691A90 Offset: 0x690090 VA: 0x180691A90
	public void set_NickName(string value) { }

	// RVA: 0x6917C0 Offset: 0x68FDC0 VA: 0x1806917C0
	public string get_UserId() { }

	// RVA: 0x691B50 Offset: 0x690150 VA: 0x180691B50
	public void set_UserId(string value) { }

	[CompilerGenerated]
	// RVA: 0x502340 Offset: 0x500940 VA: 0x180502340
	public Room get_CurrentRoom() { }

	[CompilerGenerated]
	// RVA: 0x691A30 Offset: 0x690030 VA: 0x180691A30
	public void set_CurrentRoom(Room value) { }

	// RVA: 0x691660 Offset: 0x68FC60 VA: 0x180691660
	public bool get_InRoom() { }

	[CompilerGenerated]
	// RVA: 0x691750 Offset: 0x68FD50 VA: 0x180691750
	public int get_PlayersOnMasterCount() { }

	[CompilerGenerated]
	// RVA: 0x691AC0 Offset: 0x6900C0 VA: 0x180691AC0
	internal void set_PlayersOnMasterCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x691740 Offset: 0x68FD40 VA: 0x180691740
	public int get_PlayersInRoomsCount() { }

	[CompilerGenerated]
	// RVA: 0x691AB0 Offset: 0x6900B0 VA: 0x180691AB0
	internal void set_PlayersInRoomsCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x691760 Offset: 0x68FD60 VA: 0x180691760
	public int get_RoomsCount() { }

	[CompilerGenerated]
	// RVA: 0x691AD0 Offset: 0x6900D0 VA: 0x180691AD0
	internal void set_RoomsCount(int value) { }

	// RVA: 0x6916F0 Offset: 0x68FCF0 VA: 0x1806916F0
	public bool get_IsFetchingFriendList() { }

	[CompilerGenerated]
	// RVA: 0x6915E0 Offset: 0x68FBE0 VA: 0x1806915E0
	public string get_CloudRegion() { }

	[CompilerGenerated]
	// RVA: 0x6919F0 Offset: 0x68FFF0 VA: 0x1806919F0
	private void set_CloudRegion(string value) { }

	[CompilerGenerated]
	// RVA: 0x6915F0 Offset: 0x68FBF0 VA: 0x1806915F0
	public string get_CurrentCluster() { }

	[CompilerGenerated]
	// RVA: 0x691A10 Offset: 0x690010 VA: 0x180691A10
	private void set_CurrentCluster(string value) { }

	// RVA: 0x690DD0 Offset: 0x68F3D0 VA: 0x180690DD0
	public void .ctor(ConnectionProtocol protocol = 0) { }

	// RVA: 0x690D70 Offset: 0x68F370 VA: 0x180690D70
	public void .ctor(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = 0) { }

	// RVA: 0x68A6F0 Offset: 0x688CF0 VA: 0x18068A6F0
	private string GetNameServerAddress() { }

	// RVA: 0x6896F0 Offset: 0x687CF0 VA: 0x1806896F0 Slot: 8
	public virtual bool ConnectUsingSettings(AppSettings appSettings) { }

	[Obsolete("Use ConnectToMasterServer() instead.")]
	// RVA: 0x689E20 Offset: 0x688420 VA: 0x180689E20
	public bool Connect() { }

	// RVA: 0x688F80 Offset: 0x687580 VA: 0x180688F80 Slot: 9
	public virtual bool ConnectToMasterServer() { }

	// RVA: 0x6891B0 Offset: 0x6877B0 VA: 0x1806891B0
	public bool ConnectToNameServer() { }

	// RVA: 0x689410 Offset: 0x687A10 VA: 0x180689410
	public bool ConnectToRegionMaster(string region) { }

	[Conditional("UNITY_WEBGL")]
	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void CheckConnectSetupWebGl() { }

	// RVA: 0x689B30 Offset: 0x688130 VA: 0x180689B30
	private bool Connect(string serverAddress, string proxyServerAddress, ServerConnection serverType) { }

	// RVA: 0x690200 Offset: 0x68E800 VA: 0x180690200
	public bool ReconnectToMaster() { }

	// RVA: 0x68FFE0 Offset: 0x68E5E0 VA: 0x18068FFE0
	public bool ReconnectAndRejoin() { }

	// RVA: 0x68A110 Offset: 0x688710 VA: 0x18068A110
	public void Disconnect(DisconnectCause cause = 17) { }

	// RVA: 0x68A030 Offset: 0x688630 VA: 0x18068A030
	private void DisconnectToReconnect() { }

	// RVA: 0x690780 Offset: 0x68ED80 VA: 0x180690780
	public void SimulateConnectionLoss(bool simulateTimeout) { }

	// RVA: 0x688170 Offset: 0x686770 VA: 0x180688170
	private bool CallAuthenticate() { }

	// RVA: 0x6905B0 Offset: 0x68EBB0 VA: 0x1806905B0
	public void Service() { }

	// RVA: 0x68E4F0 Offset: 0x68CAF0 VA: 0x18068E4F0
	private bool OpGetRegions() { }

	// RVA: 0x68E010 Offset: 0x68C610 VA: 0x18068E010
	public bool OpFindFriends(string[] friendsToFind, FindFriendsOptions options) { }

	// RVA: 0x68E570 Offset: 0x68CB70 VA: 0x18068E570
	public bool OpJoinLobby(TypedLobby lobby) { }

	// RVA: 0x68EC60 Offset: 0x68D260 VA: 0x18068EC60
	public bool OpLeaveLobby() { }

	// RVA: 0x68E990 Offset: 0x68CF90 VA: 0x18068E990
	public bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams) { }

	// RVA: 0x68E7D0 Offset: 0x68CDD0 VA: 0x18068E7D0
	public bool OpJoinRandomOrCreateRoom(OpJoinRandomRoomParams opJoinRandomRoomParams, EnterRoomParams createRoomParams) { }

	// RVA: 0x68DF00 Offset: 0x68C500 VA: 0x18068DF00
	public bool OpCreateRoom(EnterRoomParams enterRoomParams) { }

	// RVA: 0x68E6B0 Offset: 0x68CCB0 VA: 0x18068E6B0
	public bool OpJoinOrCreateRoom(EnterRoomParams enterRoomParams) { }

	// RVA: 0x68EB30 Offset: 0x68D130 VA: 0x18068EB30
	public bool OpJoinRoom(EnterRoomParams enterRoomParams) { }

	// RVA: 0x68EEA0 Offset: 0x68D4A0 VA: 0x18068EEA0
	public bool OpRejoinRoom(string roomName) { }

	// RVA: 0x68ECE0 Offset: 0x68D2E0 VA: 0x18068ECE0
	public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = False) { }

	// RVA: 0x68E3F0 Offset: 0x68C9F0 VA: 0x18068E3F0
	public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter) { }

	// RVA: 0x68F000 Offset: 0x68D600 VA: 0x18068F000
	public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, WebFlags webFlags) { }

	// RVA: 0x68F500 Offset: 0x68DB00 VA: 0x18068F500
	protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties, WebFlags webFlags) { }

	// RVA: 0x68F390 Offset: 0x68D990 VA: 0x18068F390
	public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, WebFlags webFlags) { }

	// RVA: 0x68F800 Offset: 0x68DE00 VA: 0x18068F800
	protected internal bool OpSetPropertyOfRoom(byte propCode, object value) { }

	// RVA: 0x68F6A0 Offset: 0x68DCA0 VA: 0x18068F6A0
	protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties, WebFlags webFlags) { }

	// RVA: 0x68EE00 Offset: 0x68D400 VA: 0x18068EE00 Slot: 10
	public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) { }

	// RVA: 0x68DE60 Offset: 0x68C460 VA: 0x18068DE60 Slot: 11
	public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd) { }

	// RVA: 0x68FB50 Offset: 0x68E150 VA: 0x18068FB50
	private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr) { }

	// RVA: 0x68FA60 Offset: 0x68E060 VA: 0x18068FA60
	private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr) { }

	// RVA: 0x688580 Offset: 0x686B80 VA: 0x180688580
	public void ChangeLocalID(int newID) { }

	// RVA: 0x68A390 Offset: 0x688990 VA: 0x18068A390
	private void GameEnteredOnGameServer(OperationResponse operationResponse) { }

	// RVA: 0x690B60 Offset: 0x68F160 VA: 0x180690B60
	private void UpdatedActorList(int[] actorsInGame) { }

	// RVA: 0x689E40 Offset: 0x688440 VA: 0x180689E40 Slot: 12
	protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties) { }

	// RVA: 0x689EC0 Offset: 0x6884C0 VA: 0x180689EC0 Slot: 13
	protected internal virtual Room CreateRoom(string roomName, RoomOptions opt) { }

	// RVA: 0x688860 Offset: 0x686E60 VA: 0x180688860
	private bool CheckIfOpAllowedOnServer(byte opCode, ServerConnection serverConnection) { }

	// RVA: 0x6889D0 Offset: 0x686FD0 VA: 0x1806889D0
	private bool CheckIfOpCanBeSent(byte opCode, ServerConnection serverConnection, string opName) { }

	// RVA: 0x688700 Offset: 0x686D00 VA: 0x180688700
	private bool CheckIfClientIsReadyToCallOperation(byte opCode) { }

	// RVA: 0x689F30 Offset: 0x688530 VA: 0x180689F30 Slot: 14
	public virtual void DebugReturn(DebugLevel level, string message) { }

	// RVA: 0x6884F0 Offset: 0x686AF0 VA: 0x1806884F0
	private void CallbackRoomEnterFailed(OperationResponse operationResponse) { }

	// RVA: 0x68B890 Offset: 0x689E90 VA: 0x18068B890 Slot: 15
	public virtual void OnOperationResponse(OperationResponse operationResponse) { }

	// RVA: 0x68CEB0 Offset: 0x68B4B0 VA: 0x18068CEB0 Slot: 16
	public virtual void OnStatusChanged(StatusCode statusCode) { }

	// RVA: 0x68AA50 Offset: 0x689050 VA: 0x18068AA50 Slot: 17
	public virtual void OnEvent(EventData photonEvent) { }

	// RVA: 0x68B820 Offset: 0x689E20 VA: 0x18068B820 Slot: 18
	public virtual void OnMessage(object message) { }

	// RVA: 0x68A950 Offset: 0x688F50 VA: 0x18068A950
	private void OnDisconnectMessageReceived(DisconnectMessage obj) { }

	// RVA: 0x68CE40 Offset: 0x68B440 VA: 0x18068CE40
	private void OnRegionPingCompleted(RegionHandler regionHandler) { }

	// RVA: 0x690460 Offset: 0x68EA60 VA: 0x180690460
	protected internal static string ReplacePortWithAlternative(string address, ushort replacementPort) { }

	// RVA: 0x6905D0 Offset: 0x68EBD0 VA: 0x1806905D0
	private void SetupEncryption(Dictionary<byte, object> encryptionData) { }

	// RVA: 0x68F890 Offset: 0x68DE90 VA: 0x18068F890
	public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = False) { }

	// RVA: 0x6880D0 Offset: 0x6866D0 VA: 0x1806880D0
	public void AddCallbackTarget(object target) { }

	// RVA: 0x6903C0 Offset: 0x68E9C0 VA: 0x1806903C0
	public void RemoveCallbackTarget(object target) { }

	// RVA: 0x690880 Offset: 0x68EE80 VA: 0x180690880
	protected internal void UpdateCallbackTargets() { }

	// RVA: -1 Offset: -1
	private void UpdateCallbackTarget<T>(LoadBalancingClient.CallbackTargetChange change, List<T> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA4EE0 Offset: 0xBA34E0 VA: 0x180BA4EE0
	|-LoadBalancingClient.UpdateCallbackTarget<object>
	*/

	// RVA: 0x690C70 Offset: 0x68F270 VA: 0x180690C70
	private static void .cctor() { }
}
