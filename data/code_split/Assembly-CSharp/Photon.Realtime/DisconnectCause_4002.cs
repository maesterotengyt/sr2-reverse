// Namespace: Photon.Realtime
public enum DisconnectCause // TypeDefIndex: 4002
{
	// Fields
	public int value__; // 0x0
	public const DisconnectCause None = 0;
	public const DisconnectCause ExceptionOnConnect = 1;
	public const DisconnectCause DnsExceptionOnConnect = 2;
	public const DisconnectCause ServerAddressInvalid = 3;
	public const DisconnectCause Exception = 4;
	public const DisconnectCause SendException = 5;
	public const DisconnectCause ReceiveException = 6;
	public const DisconnectCause ServerTimeout = 7;
	public const DisconnectCause ClientTimeout = 8;
	public const DisconnectCause DisconnectByServerLogic = 9;
	public const DisconnectCause DisconnectByServerReasonUnknown = 10;
	public const DisconnectCause InvalidAuthentication = 11;
	public const DisconnectCause CustomAuthenticationFailed = 12;
	public const DisconnectCause AuthenticationTicketExpired = 13;
	public const DisconnectCause MaxCcuReached = 14;
	public const DisconnectCause InvalidRegion = 15;
	public const DisconnectCause OperationNotAllowedInCurrentState = 16;
	public const DisconnectCause DisconnectByClientLogic = 17;
	public const DisconnectCause DisconnectByOperationLimit = 18;
	public const DisconnectCause DisconnectByDisconnectMessage = 19;
	public const DisconnectCause ApplicationQuit = 20;
}
