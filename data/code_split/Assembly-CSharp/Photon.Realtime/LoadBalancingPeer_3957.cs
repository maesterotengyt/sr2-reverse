// Namespace: Photon.Realtime
public class LoadBalancingPeer : PhotonPeer // TypeDefIndex: 3957
{
	// Fields
	private readonly Pool<ParameterDictionary> paramDictionaryPool; // 0x118

	// Properties
	[Obsolete("Use RegionHandler.PingImplementation directly.")]
	protected internal static Type PingImplementation { get; set; }

	// Methods

	// RVA: 0x67B7C0 Offset: 0x679DC0 VA: 0x18067B7C0
	protected internal static Type get_PingImplementation() { }

	// RVA: 0x67B800 Offset: 0x679E00 VA: 0x18067B800
	protected internal static void set_PingImplementation(Type value) { }

	// RVA: 0x67B400 Offset: 0x679A00 VA: 0x18067B400
	public void .ctor(ConnectionProtocol protocolType) { }

	// RVA: 0x67B380 Offset: 0x679980 VA: 0x18067B380
	public void .ctor(IPhotonPeerListener listener, ConnectionProtocol protocolType) { }

	[Conditional("SUPPORTED_UNITY")]
	// RVA: 0x6781C0 Offset: 0x6767C0 VA: 0x1806781C0
	private void ConfigUnitySockets() { }

	// RVA: 0x679370 Offset: 0x677970 VA: 0x180679370 Slot: 14
	public virtual bool OpGetRegions(string appId) { }

	// RVA: 0x679480 Offset: 0x677A80 VA: 0x180679480 Slot: 15
	public virtual bool OpJoinLobby(TypedLobby lobby) { }

	// RVA: 0x67A190 Offset: 0x678790 VA: 0x18067A190 Slot: 16
	public virtual bool OpLeaveLobby() { }

	// RVA: 0x67AF50 Offset: 0x679550 VA: 0x18067AF50
	private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions, bool usePropertiesKey = False) { }

	// RVA: 0x678CD0 Offset: 0x6772D0 VA: 0x180678CD0 Slot: 17
	public virtual bool OpCreateRoom(EnterRoomParams opParams) { }

	// RVA: 0x679E40 Offset: 0x678440 VA: 0x180679E40 Slot: 18
	public virtual bool OpJoinRoom(EnterRoomParams opParams) { }

	// RVA: 0x679A60 Offset: 0x678060 VA: 0x180679A60 Slot: 19
	public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams) { }

	// RVA: 0x679600 Offset: 0x677C00 VA: 0x180679600 Slot: 20
	public virtual bool OpJoinRandomOrCreateRoom(OpJoinRandomRoomParams opJoinRandomRoomParams, EnterRoomParams createRoomParams) { }

	// RVA: 0x67A250 Offset: 0x678850 VA: 0x18067A250 Slot: 21
	public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = False) { }

	// RVA: 0x6790F0 Offset: 0x6776F0 VA: 0x1806790F0 Slot: 22
	public virtual bool OpGetGameList(TypedLobby lobby, string queryData) { }

	// RVA: 0x678F90 Offset: 0x677590 VA: 0x180678F90 Slot: 23
	public virtual bool OpFindFriends(string[] friendsToFind, FindFriendsOptions options) { }

	// RVA: 0x67A740 Offset: 0x678D40 VA: 0x18067A740
	public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties) { }

	// RVA: 0x67A830 Offset: 0x678E30 VA: 0x18067A830
	protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties, WebFlags webflags) { }

	// RVA: 0x67AD30 Offset: 0x679330 VA: 0x18067AD30
	protected bool OpSetPropertyOfRoom(byte propCode, object value) { }

	// RVA: 0x67A7C0 Offset: 0x678DC0 VA: 0x18067A7C0
	public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties) { }

	// RVA: 0x67AAD0 Offset: 0x6790D0 VA: 0x18067AAD0
	protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties, WebFlags webflags) { }

	// RVA: 0x678870 Offset: 0x676E70 VA: 0x180678870 Slot: 24
	public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics) { }

	// RVA: 0x678370 Offset: 0x676970 VA: 0x180678370 Slot: 25
	public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol) { }

	// RVA: 0x678B60 Offset: 0x677160 VA: 0x180678B60 Slot: 26
	public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd) { }

	// RVA: 0x67A390 Offset: 0x678990 VA: 0x18067A390 Slot: 27
	public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) { }

	// RVA: 0x67ADC0 Offset: 0x6793C0 VA: 0x18067ADC0 Slot: 28
	public virtual bool OpSettings(bool receiveLobbyStats) { }
}
