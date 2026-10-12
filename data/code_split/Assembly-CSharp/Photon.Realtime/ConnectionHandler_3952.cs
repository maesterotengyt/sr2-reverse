// Namespace: Photon.Realtime
public class ConnectionHandler : MonoBehaviour // TypeDefIndex: 3952
{
	// Fields
	[CompilerGenerated]
	private LoadBalancingClient <Client>k__BackingField; // 0x20
	public bool DisconnectAfterKeepAlive; // 0x28
	public int KeepAliveInBackground; // 0x2C
	[CompilerGenerated]
	private int <CountSendAcksOnly>k__BackingField; // 0x30
	public bool ApplyDontDestroyOnLoad; // 0x34
	public static bool AppQuits; // 0x0
	public static bool AppPause; // 0x1
	public static bool AppPauseRecent; // 0x2
	public static bool AppOutOfFocus; // 0x3
	public static bool AppOutOfFocusRecent; // 0x4
	private byte fallbackThreadId; // 0x35
	private bool didSendAcks; // 0x36
	private readonly Stopwatch backgroundStopwatch; // 0x38

	// Properties
	public LoadBalancingClient Client { get; set; }
	public int CountSendAcksOnly { get; set; }
	public bool FallbackThreadRunning { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public LoadBalancingClient get_Client() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	public void set_Client(LoadBalancingClient value) { }

	[CompilerGenerated]
	// RVA: 0x5114B0 Offset: 0x50FAB0 VA: 0x1805114B0
	public int get_CountSendAcksOnly() { }

	[CompilerGenerated]
	// RVA: 0x5C5B70 Offset: 0x5C4170 VA: 0x1805C5B70
	private void set_CountSendAcksOnly(int value) { }

	// RVA: 0x673950 Offset: 0x671F50 VA: 0x180673950
	public bool get_FallbackThreadRunning() { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x6737E0 Offset: 0x671DE0 VA: 0x1806737E0
	private static void StaticReset() { }

	// RVA: 0x6731F0 Offset: 0x6717F0 VA: 0x1806731F0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x673440 Offset: 0x671A40 VA: 0x180673440 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x673400 Offset: 0x671A00 VA: 0x180673400
	public void OnApplicationQuit() { }

	// RVA: 0x673360 Offset: 0x671960 VA: 0x180673360
	public void OnApplicationPause(bool pause) { }

	// RVA: 0x6736E0 Offset: 0x671CE0 VA: 0x1806736E0
	private void ResetAppPauseRecent() { }

	// RVA: 0x6732B0 Offset: 0x6718B0 VA: 0x1806732B0
	public void OnApplicationFocus(bool focus) { }

	// RVA: 0x6736A0 Offset: 0x671CA0 VA: 0x1806736A0
	private void ResetAppOutOfFocusRecent() { }

	// RVA: 0x673260 Offset: 0x671860 VA: 0x180673260
	public static bool IsNetworkReachableUnity() { }

	// RVA: 0x673720 Offset: 0x671D20 VA: 0x180673720
	public void StartFallbackSendAckThread() { }

	// RVA: 0x673860 Offset: 0x671E60 VA: 0x180673860
	public void StopFallbackSendAckThread() { }

	// RVA: 0x673560 Offset: 0x671B60 VA: 0x180673560
	public bool RealtimeFallbackThread() { }

	// RVA: 0x6738D0 Offset: 0x671ED0 VA: 0x1806738D0
	public void .ctor() { }
}
