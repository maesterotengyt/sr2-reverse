// Namespace: Photon.Realtime
public class EventCode // TypeDefIndex: 3965
{
	// Fields
	public const byte GameList = 230;
	public const byte GameListUpdate = 229;
	public const byte QueueState = 228;
	public const byte Match = 227;
	public const byte AppStats = 226;
	public const byte LobbyStats = 224;
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const byte AzureNodeInfo = 210;
	public const byte Join = 255;
	public const byte Leave = 254;
	public const byte PropertiesChanged = 253;
	[Obsolete("Use PropertiesChanged now.")]
	public const byte SetProperties = 253;
	public const byte ErrorInfo = 251;
	public const byte CacheSliceChanged = 250;
	public const byte AuthEvent = 223;

	// Methods

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
