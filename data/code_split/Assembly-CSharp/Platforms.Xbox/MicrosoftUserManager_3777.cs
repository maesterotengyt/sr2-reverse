// Namespace: Platforms.Xbox
public class MicrosoftUserManager // TypeDefIndex: 3777
{
	// Fields
	[CompilerGenerated]
	private XboxUser <DefaultUser>k__BackingField; // 0x10
	public bool pendingLogOut; // 0x18
	private MicrosoftStoreSystem _microsoftStoreSystem; // 0x20
	private XUserChangeRegistrationToken _callbackRegistrationToken; // 0x28
	private bool _isRegistered; // 0x30

	// Properties
	public XboxUser DefaultUser { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public XboxUser get_DefaultUser() { }

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	private void set_DefaultUser(XboxUser value) { }

	// RVA: 0x64C780 Offset: 0x64AD80 VA: 0x18064C780
	public void .ctor(MicrosoftStoreSystem microsoftStoreSystem) { }

	[AsyncStateMachine(typeof(MicrosoftUserManager.<InitAsync>d__9))]
	// RVA: 0x64C2B0 Offset: 0x64A8B0 VA: 0x18064C2B0
	public Task InitAsync() { }

	// RVA: 0x64C520 Offset: 0x64AB20 VA: 0x18064C520
	public void Shutdown() { }

	// RVA: 0x64BE80 Offset: 0x64A480 VA: 0x18064BE80
	public Task<UserOpResult> AddDefaultUserSilentlyAsync() { }

	// RVA: 0x64C0A0 Offset: 0x64A6A0 VA: 0x18064C0A0
	public Task<UserOpResult> AddUserWithUIAsync() { }

	// RVA: 0x64C380 Offset: 0x64A980 VA: 0x18064C380
	private void ResolveSigninIssueWithUI(XUserHandle userHandle, TaskCompletionSource<UserOpResult> tcs) { }

	// RVA: 0x64C5C0 Offset: 0x64ABC0 VA: 0x18064C5C0
	private void UserChangeEventCallback(IntPtr ptr, XUserLocalId userLocalId, XUserChangeEvent eventType) { }
}
