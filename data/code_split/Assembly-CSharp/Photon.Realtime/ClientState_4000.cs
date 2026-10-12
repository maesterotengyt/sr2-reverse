// Namespace: Photon.Realtime
public enum ClientState // TypeDefIndex: 4000
{
	// Fields
	public int value__; // 0x0
	public const ClientState PeerCreated = 0;
	public const ClientState Authenticating = 1;
	public const ClientState Authenticated = 2;
	public const ClientState JoiningLobby = 3;
	public const ClientState JoinedLobby = 4;
	public const ClientState DisconnectingFromMasterServer = 5;
	[Obsolete("Renamed to DisconnectingFromMasterServer")]
	public const ClientState DisconnectingFromMasterserver = 5;
	public const ClientState ConnectingToGameServer = 6;
	[Obsolete("Renamed to ConnectingToGameServer")]
	public const ClientState ConnectingToGameserver = 6;
	public const ClientState ConnectedToGameServer = 7;
	[Obsolete("Renamed to ConnectedToGameServer")]
	public const ClientState ConnectedToGameserver = 7;
	public const ClientState Joining = 8;
	public const ClientState Joined = 9;
	public const ClientState Leaving = 10;
	public const ClientState DisconnectingFromGameServer = 11;
	[Obsolete("Renamed to DisconnectingFromGameServer")]
	public const ClientState DisconnectingFromGameserver = 11;
	public const ClientState ConnectingToMasterServer = 12;
	[Obsolete("Renamed to ConnectingToMasterServer.")]
	public const ClientState ConnectingToMasterserver = 12;
	public const ClientState Disconnecting = 13;
	public const ClientState Disconnected = 14;
	public const ClientState ConnectedToMasterServer = 15;
	[Obsolete("Renamed to ConnectedToMasterServer.")]
	public const ClientState ConnectedToMasterserver = 15;
	[Obsolete("Renamed to ConnectedToMasterServer.")]
	public const ClientState ConnectedToMaster = 15;
	public const ClientState ConnectingToNameServer = 16;
	public const ClientState ConnectedToNameServer = 17;
	public const ClientState DisconnectingFromNameServer = 18;
	public const ClientState ConnectWithFallbackProtocol = 19;
	public const ClientState ConnectWithoutAuthOnceWss = 20;
}
