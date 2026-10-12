// Namespace: Platforms.Xbox
public class MicrosoftStoreSystem : StellarPCSystem // TypeDefIndex: 3772
{
	// Fields
	private MicrosoftStoreOnlineSystem xboxOnlineSystem; // 0x68
	[CompilerGenerated]
	private string <SCID>k__BackingField; // 0x70
	public string MultiplayerPrivilege; // 0x78
	public string CrossPlayPrivilege; // 0x80
	public string CommunicationsPrivilege; // 0x88
	[CompilerGenerated]
	private Action PrivilegeUiShown; // 0x90
	public XPackageDetails[] installedPackages; // 0x98
	private MicrosoftUserManager _userManager; // 0xA0
	private XStoreContext storeContext; // 0xA8
	public bool IsUiMenuOpen; // 0xB0
	private string[] profanityWords; // 0xB8
	private string encryptPassword; // 0xC0
	private XGameInviteRegistrationToken _inviteToken; // 0xC8
	private bool _inviteTokenRegistered; // 0xD0
	private byte[] IV; // 0xD8
	private bool _defaultQueueInitialized; // 0xE0
	private Coroutine _taskQueueCoroutine; // 0xE8
	private const int LocaleNameMaxLength = 85;

	// Properties
	public string SCID { get; set; }
	public XboxUser DefaultUser { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public string get_SCID() { }

	[CompilerGenerated]
	// RVA: 0x5DC940 Offset: 0x5DAF40 VA: 0x1805DC940
	private void set_SCID(string value) { }

	// RVA: 0x64BDC0 Offset: 0x64A3C0 VA: 0x18064BDC0
	public XboxUser get_DefaultUser() { }

	[CompilerGenerated]
	// RVA: 0x64BD20 Offset: 0x64A320 VA: 0x18064BD20
	public void add_PrivilegeUiShown(Action value) { }

	[CompilerGenerated]
	// RVA: 0x64BDE0 Offset: 0x64A3E0 VA: 0x18064BDE0
	public void remove_PrivilegeUiShown(Action value) { }

	// RVA: 0x64ABB0 Offset: 0x6491B0 VA: 0x18064ABB0
	private static extern int GetUserDefaultLocaleName(StringBuilder lpLocaleName, int cchLocaleName) { }

	// RVA: 0x64A970 Offset: 0x648F70 VA: 0x18064A970
	public string GetConsoleLocaleName() { }

	// RVA: 0x64AE90 Offset: 0x649490 VA: 0x18064AE90 Slot: 4
	public override void InitializePlatform() { }

	[IteratorStateMachine(typeof(MicrosoftStoreSystem.<DispatchTaskQueue>d__28))]
	// RVA: 0x64A920 Offset: 0x648F20 VA: 0x18064A920
	private IEnumerator DispatchTaskQueue() { }

	// RVA: 0x64B1D0 Offset: 0x6497D0 VA: 0x18064B1D0
	private static bool InitializeXboxLive(string scid) { }

	[AsyncStateMachine(typeof(MicrosoftStoreSystem.<InitServices>d__30))]
	// RVA: 0x64ADC0 Offset: 0x6493C0 VA: 0x18064ADC0
	private Task InitServices() { }

	// RVA: 0x64BC10 Offset: 0x64A210 VA: 0x18064BC10
	protected void Update() { }

	// RVA: 0x64AAF0 Offset: 0x6490F0 VA: 0x18064AAF0
	public XStoreContext GetStoreContext() { }

	// RVA: 0x64A7B0 Offset: 0x648DB0 VA: 0x18064A7B0 Slot: 8
	public override string CheckStringProfanity(string str) { }

	// RVA: 0x64B6B0 Offset: 0x649CB0 VA: 0x18064B6B0 Slot: 7
	public override void OpenVirtualKeyboard(string currentString, int length, bool useFloatingKeyboard = False) { }

	// RVA: 0x64B960 Offset: 0x649F60 VA: 0x18064B960
	private void SetPrivilege(XUserPrivilege privilege, string value) { }

	// RVA: 0x64A2E0 Offset: 0x6488E0 VA: 0x18064A2E0
	public bool CheckPrivilege(XUserPrivilege privilege, bool checkAsync = True) { }

	// RVA: 0x64AC70 Offset: 0x649270 VA: 0x18064AC70 Slot: 5
	public override string GetUsername() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void JoinActiveGame(string photonRoomID, string region) { }

	// RVA: 0x64A900 Offset: 0x648F00 VA: 0x18064A900
	public void ClearOnlineFlags() { }

	// RVA: 0x64AA80 Offset: 0x649080 VA: 0x18064AA80 Slot: 6
	public override string GetPlatformUserID() { }

	// RVA: 0x64B7E0 Offset: 0x649DE0 VA: 0x18064B7E0
	public void RegisterInvites() { }

	// RVA: 0x64B9D0 Offset: 0x649FD0 VA: 0x18064B9D0 Slot: 9
	public override void UnlockAchievement(string achievementID, int achievementNumber) { }

	// RVA: 0x64B310 Offset: 0x649910 VA: 0x18064B310
	private void OnApplicationQuit() { }

	// RVA: 0x64B620 Offset: 0x649C20 VA: 0x18064B620
	private void OnDestroy() { }

	// RVA: 0x64BC60 Offset: 0x64A260 VA: 0x18064BC60
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x64B9C0 Offset: 0x649FC0 VA: 0x18064B9C0
	private void <>n__0() { }
}
