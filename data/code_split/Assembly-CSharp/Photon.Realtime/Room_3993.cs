// Namespace: Photon.Realtime
public class Room : RoomInfo // TypeDefIndex: 3993
{
	// Fields
	[CompilerGenerated]
	private LoadBalancingClient <LoadBalancingClient>k__BackingField; // 0x60
	private bool isOffline; // 0x68
	private Dictionary<int, Player> players; // 0x70
	[CompilerGenerated]
	private bool <BroadcastPropertiesChangeToAll>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <SuppressRoomEvents>k__BackingField; // 0x79
	[CompilerGenerated]
	private bool <SuppressPlayerInfo>k__BackingField; // 0x7A
	[CompilerGenerated]
	private bool <PublishUserId>k__BackingField; // 0x7B
	[CompilerGenerated]
	private bool <DeleteNullProperties>k__BackingField; // 0x7C

	// Properties
	public LoadBalancingClient LoadBalancingClient { get; set; }
	public string Name { get; set; }
	public bool IsOffline { get; set; }
	public bool IsOpen { get; set; }
	public bool IsVisible { get; set; }
	public int MaxPlayers { get; set; }
	public int PlayerCount { get; }
	public Dictionary<int, Player> Players { get; set; }
	public string[] ExpectedUsers { get; }
	public int PlayerTtl { get; set; }
	public int EmptyRoomTtl { get; set; }
	public int MasterClientId { get; }
	public string[] PropertiesListedInLobby { get; set; }
	public bool AutoCleanUp { get; }
	public bool BroadcastPropertiesChangeToAll { get; set; }
	public bool SuppressRoomEvents { get; set; }
	public bool SuppressPlayerInfo { get; set; }
	public bool PublishUserId { get; set; }
	public bool DeleteNullProperties { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5818A0 Offset: 0x57FEA0 VA: 0x1805818A0
	public LoadBalancingClient get_LoadBalancingClient() { }

	[CompilerGenerated]
	// RVA: 0x5B45C0 Offset: 0x5B2BC0 VA: 0x1805B45C0
	public void set_LoadBalancingClient(LoadBalancingClient value) { }

	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	public string get_Name() { }

	// RVA: 0x5C5B80 Offset: 0x5C4180 VA: 0x1805C5B80
	internal void set_Name(string value) { }

	// RVA: 0x5DC800 Offset: 0x5DAE00 VA: 0x1805DC800
	public bool get_IsOffline() { }

	// RVA: 0x5DC920 Offset: 0x5DAF20 VA: 0x1805DC920
	private void set_IsOffline(bool value) { }

	// RVA: 0x670AB0 Offset: 0x66F0B0 VA: 0x180670AB0
	public bool get_IsOpen() { }

	// RVA: 0x682220 Offset: 0x680820 VA: 0x180682220
	public void set_IsOpen(bool value) { }

	// RVA: 0x682120 Offset: 0x680720 VA: 0x180682120
	public bool get_IsVisible() { }

	// RVA: 0x6822F0 Offset: 0x6808F0 VA: 0x1806822F0
	public void set_IsVisible(bool value) { }

	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_MaxPlayers() { }

	// RVA: 0x6823C0 Offset: 0x6809C0 VA: 0x1806823C0
	public void set_MaxPlayers(int value) { }

	// RVA: 0x682130 Offset: 0x680730 VA: 0x180682130
	public int get_PlayerCount() { }

	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public Dictionary<int, Player> get_Players() { }

	// RVA: 0x5DC940 Offset: 0x5DAF40 VA: 0x1805DC940
	private void set_Players(Dictionary<int, Player> value) { }

	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public string[] get_ExpectedUsers() { }

	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public int get_PlayerTtl() { }

	// RVA: 0x6824D0 Offset: 0x680AD0 VA: 0x1806824D0
	public void set_PlayerTtl(int value) { }

	// RVA: 0x682110 Offset: 0x680710 VA: 0x180682110
	public int get_EmptyRoomTtl() { }

	// RVA: 0x6821B0 Offset: 0x6807B0 VA: 0x1806821B0
	public void set_EmptyRoomTtl(int value) { }

	// RVA: 0x5C5B60 Offset: 0x5C4160 VA: 0x1805C5B60
	public int get_MasterClientId() { }

	// RVA: 0x5B38B0 Offset: 0x5B1EB0 VA: 0x1805B38B0
	public string[] get_PropertiesListedInLobby() { }

	// RVA: 0x5B38C0 Offset: 0x5B1EC0 VA: 0x1805B38C0
	private void set_PropertiesListedInLobby(string[] value) { }

	// RVA: 0x682100 Offset: 0x680700 VA: 0x180682100
	public bool get_AutoCleanUp() { }

	[CompilerGenerated]
	// RVA: 0x5BAA00 Offset: 0x5B9000 VA: 0x1805BAA00
	public bool get_BroadcastPropertiesChangeToAll() { }

	[CompilerGenerated]
	// RVA: 0x5BAB60 Offset: 0x5B9160 VA: 0x1805BAB60
	private void set_BroadcastPropertiesChangeToAll(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6821A0 Offset: 0x6807A0 VA: 0x1806821A0
	public bool get_SuppressRoomEvents() { }

	[CompilerGenerated]
	// RVA: 0x682560 Offset: 0x680B60 VA: 0x180682560
	private void set_SuppressRoomEvents(bool value) { }

	[CompilerGenerated]
	// RVA: 0x682190 Offset: 0x680790 VA: 0x180682190
	public bool get_SuppressPlayerInfo() { }

	[CompilerGenerated]
	// RVA: 0x682550 Offset: 0x680B50 VA: 0x180682550
	private void set_SuppressPlayerInfo(bool value) { }

	[CompilerGenerated]
	// RVA: 0x682180 Offset: 0x680780 VA: 0x180682180
	public bool get_PublishUserId() { }

	[CompilerGenerated]
	// RVA: 0x682540 Offset: 0x680B40 VA: 0x180682540
	private void set_PublishUserId(bool value) { }

	[CompilerGenerated]
	// RVA: 0x567D60 Offset: 0x566360 VA: 0x180567D60
	public bool get_DeleteNullProperties() { }

	[CompilerGenerated]
	// RVA: 0x567DA0 Offset: 0x5663A0 VA: 0x180567DA0
	private void set_DeleteNullProperties(bool value) { }

	// RVA: 0x682030 Offset: 0x680630 VA: 0x180682030
	public void .ctor(string roomName, RoomOptions options, bool isOffline = False) { }

	// RVA: 0x6813D0 Offset: 0x67F9D0 VA: 0x1806813D0
	internal void InternalCacheRoomFlags(int roomFlags) { }

	// RVA: 0x681360 Offset: 0x67F960 VA: 0x180681360 Slot: 4
	protected internal override void InternalCacheProperties(Hashtable propertiesToCache) { }

	// RVA: 0x6814C0 Offset: 0x67FAC0 VA: 0x1806814C0 Slot: 5
	public virtual bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedProperties, WebFlags webFlags) { }

	// RVA: 0x6818E0 Offset: 0x67FEE0 VA: 0x1806818E0
	public bool SetPropertiesListedInLobby(string[] lobbyProps) { }

	// RVA: 0x681410 Offset: 0x67FA10 VA: 0x180681410 Slot: 6
	protected internal virtual void RemovePlayer(Player player) { }

	// RVA: 0x681480 Offset: 0x67FA80 VA: 0x180681480 Slot: 7
	protected internal virtual void RemovePlayer(int id) { }

	// RVA: 0x6817C0 Offset: 0x67FDC0 VA: 0x1806817C0
	public bool SetMasterClient(Player masterClientPlayer) { }

	// RVA: 0x6811E0 Offset: 0x67F7E0 VA: 0x1806811E0 Slot: 8
	public virtual bool AddPlayer(Player player) { }

	// RVA: 0x681990 Offset: 0x67FF90 VA: 0x180681990 Slot: 9
	public virtual Player StorePlayer(Player player) { }

	// RVA: 0x6812E0 Offset: 0x67F8E0 VA: 0x1806812E0 Slot: 10
	public virtual Player GetPlayer(int id, bool findMaster = False) { }

	// RVA: 0x681270 Offset: 0x67F870 VA: 0x180681270
	public bool ClearExpectedUsers() { }

	// RVA: 0x681730 Offset: 0x67FD30 VA: 0x180681730
	public bool SetExpectedUsers(string[] newExpectedUsers) { }

	// RVA: 0x681620 Offset: 0x67FC20 VA: 0x180681620
	private bool SetExpectedUsers(string[] newExpectedUsers, string[] oldExpectedUsers) { }

	// RVA: 0x681D70 Offset: 0x680370 VA: 0x180681D70 Slot: 3
	public override string ToString() { }

	// RVA: 0x681A00 Offset: 0x680000 VA: 0x180681A00
	public string ToStringFull() { }
}
