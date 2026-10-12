// Namespace: Photon.Realtime
[Serializable]
public class AppSettings // TypeDefIndex: 3951
{
	// Fields
	public string AppIdRealtime; // 0x10
	public string AppIdFusion; // 0x18
	public string AppIdChat; // 0x20
	public string AppIdVoice; // 0x28
	public string AppVersion; // 0x30
	public bool UseNameServer; // 0x38
	public string FixedRegion; // 0x40
	public string BestRegionSummaryFromStorage; // 0x48
	public string Server; // 0x50
	public int Port; // 0x58
	public string ProxyServer; // 0x60
	public ConnectionProtocol Protocol; // 0x68
	public bool EnableProtocolFallback; // 0x69
	public AuthModeOption AuthMode; // 0x6C
	public bool EnableLobbyStatistics; // 0x70
	public DebugLevel NetworkLogging; // 0x71

	// Properties
	public bool IsMasterServerAddress { get; }
	public bool IsBestRegion { get; }
	public bool IsDefaultNameServer { get; }
	public bool IsDefaultPort { get; }

	// Methods

	// RVA: 0x671870 Offset: 0x66FE70 VA: 0x180671870
	public bool get_IsMasterServerAddress() { }

	// RVA: 0x671820 Offset: 0x66FE20 VA: 0x180671820
	public bool get_IsBestRegion() { }

	// RVA: 0x671840 Offset: 0x66FE40 VA: 0x180671840
	public bool get_IsDefaultNameServer() { }

	// RVA: 0x671860 Offset: 0x66FE60 VA: 0x180671860
	public bool get_IsDefaultPort() { }

	// RVA: 0x670F50 Offset: 0x66F550 VA: 0x180670F50
	public string ToStringFull() { }

	// RVA: 0x670F20 Offset: 0x66F520 VA: 0x180670F20
	public static bool IsAppId(string val) { }

	// RVA: 0x670EA0 Offset: 0x66F4A0 VA: 0x180670EA0
	private string HideAppId(string appId) { }

	// RVA: 0x670DA0 Offset: 0x66F3A0 VA: 0x180670DA0
	public AppSettings CopyTo(AppSettings d) { }

	// RVA: 0x671800 Offset: 0x66FE00 VA: 0x180671800
	public void .ctor() { }
}
