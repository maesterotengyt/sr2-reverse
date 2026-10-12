// Namespace: Platforms.Xbox
public class XboxUser // TypeDefIndex: 3789
{
	// Fields
	[CompilerGenerated]
	private readonly XUserHandle <UserHandle>k__BackingField; // 0x10
	[CompilerGenerated]
	private XblContextHandle <Context>k__BackingField; // 0x18
	[CompilerGenerated]
	private XUserLocalId <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ulong <XUID>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Gamertag>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <UserIsGuest>k__BackingField; // 0x38
	[CompilerGenerated]
	private XblPermissionCheckResult <MultiplayerPermission>k__BackingField; // 0x40

	// Properties
	public XUserHandle UserHandle { get; }
	public XblContextHandle Context { get; set; }
	public XUserLocalId LocalId { get; set; }
	public ulong XUID { get; set; }
	public string Gamertag { get; set; }
	public bool UserIsGuest { get; set; }
	public XblPermissionCheckResult MultiplayerPermission { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public XUserHandle get_UserHandle() { }

	[CompilerGenerated]
	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public XblContextHandle get_Context() { }

	[CompilerGenerated]
	// RVA: 0x5B5080 Offset: 0x5B3680 VA: 0x1805B5080
	private void set_Context(XblContextHandle value) { }

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public XUserLocalId get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	private void set_LocalId(XUserLocalId value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public ulong get_XUID() { }

	[CompilerGenerated]
	// RVA: 0x670AD0 Offset: 0x66F0D0 VA: 0x180670AD0
	private void set_XUID(ulong value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public string get_Gamertag() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	private void set_Gamertag(string value) { }

	[CompilerGenerated]
	// RVA: 0x670AB0 Offset: 0x66F0B0 VA: 0x180670AB0
	public bool get_UserIsGuest() { }

	[CompilerGenerated]
	// RVA: 0x670AC0 Offset: 0x66F0C0 VA: 0x180670AC0
	private void set_UserIsGuest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	public XblPermissionCheckResult get_MultiplayerPermission() { }

	[CompilerGenerated]
	// RVA: 0x5C5B80 Offset: 0x5C4180 VA: 0x1805C5B80
	private void set_MultiplayerPermission(XblPermissionCheckResult value) { }

	// RVA: 0x670A70 Offset: 0x66F070 VA: 0x180670A70
	public void .ctor(XUserHandle userHandle) { }

	// RVA: 0x670740 Offset: 0x66ED40 VA: 0x180670740
	public UserOpResult UpdateUserData() { }

	// RVA: 0x66FD20 Offset: 0x66E320 VA: 0x18066FD20
	public Task<bool> CheckMultiplayerPermissionAsync() { }

	// RVA: 0x66FF30 Offset: 0x66E530 VA: 0x18066FF30
	public Task<bool> CheckPrivilegeAsync(XUserPrivilege privilege) { }

	// RVA: 0x6705C0 Offset: 0x66EBC0 VA: 0x1806705C0
	public Task<byte[]> GetProfilePicAsync(XUserGamerPictureSize size = 2) { }

	// RVA: 0x6703C0 Offset: 0x66E9C0 VA: 0x1806703C0
	public Task<ulong[]> GetMuteListAsync() { }

	// RVA: 0x6701C0 Offset: 0x66E7C0 VA: 0x1806701C0
	public Task<ulong[]> GetAvoidListAsync() { }

	// RVA: 0x6706F0 Offset: 0x66ECF0 VA: 0x1806706F0
	private UserOpResult ResolveHR(int hr, Action successCallback) { }
}
