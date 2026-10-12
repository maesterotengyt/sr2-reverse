// Namespace: 
public class QuantumMultiClientPlayer : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, IInRoomCallbacks, IOnEventCallback // TypeDefIndex: 2431
{
	// Fields
	public RuntimeConfig RuntimeConfig; // 0x20
	public RuntimePlayer RuntimePlayer; // 0x28
	public QuantumEditorSettings GizmoSettings; // 0x30
	public int PlayerCount; // 0x38
	public bool IsFirstPlayer; // 0x3C
	public AssetGuid MapGuid; // 0x40
	public GameObject PlayerInputTemplate; // 0x48
	public EntityViewUpdater EntityViewUpdaterTemplate; // 0x50
	public Action<QuantumMultiClientPlayer> OnPlayerQuitCallback; // 0x58
	public Action<QuantumMultiClientPlayer> OnPlayerCreatedCallback; // 0x60
	private QuantumLoadBalancingClient _client; // 0x68
	private EnterRoomParams _enterRoomParams; // 0x70
	private QuantumMultiClientPlayerView _ui; // 0x78
	private QuantumRunner _runner; // 0x80
	private GameObject _input; // 0x88
	private EntityViewUpdater _evu; // 0x90
	private DispatcherSubscription _quantumGameStartedSubscription; // 0x98
	private DispatcherSubscription _quantumGameDisconnectedSubscription; // 0xA0

	// Properties
	public string RunnerId { get; }
	public GameObject Input { get; }

	// Methods

	// RVA: 0x531680 Offset: 0x52FC80 VA: 0x180531680
	public string get_RunnerId() { }

	// RVA: 0x531670 Offset: 0x52FC70 VA: 0x180531670
	public GameObject get_Input() { }

	// RVA: 0x531650 Offset: 0x52FC50 VA: 0x180531650
	public void Update() { }

	// RVA: 0x530080 Offset: 0x52E680 VA: 0x180530080
	public void OnDestroy() { }

	// RVA: 0x52FAB0 Offset: 0x52E0B0 VA: 0x18052FAB0
	public void BindView(QuantumMultiClientPlayerView view) { }

	// RVA: 0x5305C0 Offset: 0x52EBC0 VA: 0x1805305C0
	public void Run(AppSettings appSettings) { }

	// RVA: 0x531270 Offset: 0x52F870 VA: 0x180531270
	public void Stop() { }

	// RVA: 0x530490 Offset: 0x52EA90 VA: 0x180530490
	private void OnQuantumGameStarted(QuantumGame game) { }

	// RVA: 0x530570 Offset: 0x52EB70 VA: 0x180530570
	private void OnQuantumPluginDisconnected(QuantumGame game) { }

	// RVA: 0x5301C0 Offset: 0x52E7C0 VA: 0x1805301C0
	private void OnInputToggle(bool isEnabled) { }

	// RVA: 0x530580 Offset: 0x52EB80 VA: 0x180530580
	private void OnViewToggle(bool isEnabled) { }

	// RVA: 0x530190 Offset: 0x52E790 VA: 0x180530190
	private void OnGizmoToggle(bool isEnabled) { }

	// RVA: 0x530570 Offset: 0x52EB70 VA: 0x180530570
	private void OnQuitClicked() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public void OnConnected() { }

	// RVA: 0x52FBF0 Offset: 0x52E1F0 VA: 0x18052FBF0 Slot: 5
	public void OnConnectedToMaster() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 11
	public void OnCreatedRoom() { }

	// RVA: 0x52FF50 Offset: 0x52E550 VA: 0x18052FF50 Slot: 12
	public void OnCreateRoomFailed(short returnCode, string message) { }

	// RVA: 0x530010 Offset: 0x52E610 VA: 0x180530010 Slot: 9
	public void OnCustomAuthenticationFailed(string debugMessage) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public void OnCustomAuthenticationResponse(Dictionary<string, object> data) { }

	// RVA: 0x5300D0 Offset: 0x52E6D0 VA: 0x1805300D0 Slot: 6
	public void OnDisconnected(DisconnectCause cause) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public void OnFriendListUpdate(List<FriendInfo> friendList) { }

	// RVA: 0x5303D0 Offset: 0x52E9D0 VA: 0x1805303D0 Slot: 13
	public void OnJoinedRoom() { }

	// RVA: 0x5307A0 Offset: 0x52EDA0 VA: 0x1805307A0
	private void StartQuantumGame() { }

	// RVA: 0x530250 Offset: 0x52E850 VA: 0x180530250 Slot: 15
	public void OnJoinRandomFailed(short returnCode, string message) { }

	// RVA: 0x530310 Offset: 0x52E910 VA: 0x180530310 Slot: 14
	public void OnJoinRoomFailed(short returnCode, string message) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 16
	public void OnLeftRoom() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public void OnRegionListReceived(RegionHandler regionHandler) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 17
	public void OnPlayerEnteredRoom(Player newPlayer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 18
	public void OnPlayerLeftRoom(Player otherPlayer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 19
	public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 20
	public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 21
	public void OnMasterClientSwitched(Player newMasterClient) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 22
	public void OnEvent(EventData photonEvent) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x531510 Offset: 0x52FB10 VA: 0x180531510
	private void <StartQuantumGame>b__42_0(CallbackGameStarted c) { }

	[CompilerGenerated]
	// RVA: 0x5315F0 Offset: 0x52FBF0 VA: 0x1805315F0
	private bool <StartQuantumGame>b__42_1(IDeterministicGame game) { }

	[CompilerGenerated]
	// RVA: 0x531620 Offset: 0x52FC20 VA: 0x180531620
	private void <StartQuantumGame>b__42_2(CallbackPluginDisconnect c) { }

	[CompilerGenerated]
	// RVA: 0x5315F0 Offset: 0x52FBF0 VA: 0x1805315F0
	private bool <StartQuantumGame>b__42_3(IDeterministicGame game) { }
}
