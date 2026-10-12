// Namespace: 
public class OnlineManager : SRMonoBehaviour // TypeDefIndex: 2702
{
	// Fields
	[Header("Custom Managers")]
	public OnlineCoordinator Coordinator; // 0x20
	public MatchmakingManager MatchmakingManager; // 0x28
	public TournamentManager TournamentManager; // 0x30
	public BettingManager BettingManager; // 0x38
	public OnlineMatchManager OnlineMatchManager; // 0x40
	public RoomMigrator RoomMigrator; // 0x48
	public OnlineProperties Properties; // 0x50
	public OnlineRatingManager OnlineRatingManager; // 0x58
	public BrainCloudManager BraincloudManager; // 0x60
	public static OnlineManager.OnEmoteSent EmoteSent; // 0x0
	public static OnlineManager.OnMessageSent MessageSent; // 0x8
	[CompilerGenerated]
	private bool <ChatEnabled>k__BackingField; // 0x68

	// Properties
	public StellarOnlineSystem StellarSystem { get; }
	public bool ChatEnabled { get; set; }

	// Methods

	// RVA: 0x71E3D0 Offset: 0x71C9D0 VA: 0x18071E3D0
	public StellarOnlineSystem get_StellarSystem() { }

	[CompilerGenerated]
	// RVA: 0x5DC800 Offset: 0x5DAE00 VA: 0x1805DC800
	public bool get_ChatEnabled() { }

	[CompilerGenerated]
	// RVA: 0x5DC920 Offset: 0x5DAF20 VA: 0x1805DC920
	public void set_ChatEnabled(bool value) { }

	// RVA: 0x71C280 Offset: 0x71A880 VA: 0x18071C280
	public void Initialize() { }

	// RVA: 0x71C190 Offset: 0x71A790 VA: 0x18071C190
	public List<Player> GetPlayersList(bool excludeSpectators = False) { }

	// RVA: 0x71DF70 Offset: 0x71C570 VA: 0x18071DF70
	private void SetPlayerDataInRoom() { }

	// RVA: 0x71E0D0 Offset: 0x71C6D0 VA: 0x18071E0D0
	public bool TryGetLocalPlayerRaceResult(out PlayerRaceResult playerRaceResult) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnConnectedOnlineRefreshBlockList(bool success, string errorID = "") { }

	// RVA: 0x71E010 Offset: 0x71C610 VA: 0x18071E010
	public void ShowCrossplayAlert() { }

	// RVA: 0x71D630 Offset: 0x71BC30 VA: 0x18071D630
	public void ReceivedCustomEvent(byte eventCode, object content) { }

	// RVA: 0x71BB00 Offset: 0x71A100 VA: 0x18071BB00
	public void ChooseMatchStage(bool trueRandom = False) { }

	// RVA: 0x71D410 Offset: 0x71BA10 VA: 0x18071D410
	public void PlayerSignOut() { }

	// RVA: 0x71DB70 Offset: 0x71C170 VA: 0x18071DB70
	private void ReturnToMainMenuAfterSignOut() { }

	// RVA: 0x71CED0 Offset: 0x71B4D0 VA: 0x18071CED0
	public void OnlineDisconnectionEvent() { }

	// RVA: 0x71D2F0 Offset: 0x71B8F0 VA: 0x18071D2F0
	private void OnlineTimeoutError() { }

	// RVA: 0x71C0F0 Offset: 0x71A6F0 VA: 0x18071C0F0
	public OnlineManager.OnlineMode GetCurrentOnlineMode() { }

	// RVA: 0x71C8E0 Offset: 0x71AEE0 VA: 0x18071C8E0
	private void OnDestroy() { }

	// RVA: 0x71E360 Offset: 0x71C960 VA: 0x18071E360
	public void .ctor() { }
}
