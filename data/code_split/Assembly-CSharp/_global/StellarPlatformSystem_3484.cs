// Namespace: 
public class StellarPlatformSystem : StellarMonoBehaviour // TypeDefIndex: 3484
{
	// Fields
	public GamePlatform Platform; // 0x20
	public GamePlatformFamily PlatformFamily; // 0x24
	public InputDeviceType DefaultInputDeviceType; // 0x28
	public VirtualKeyboardMode VirtualKeyboard; // 0x2C
	[Header("Subsystems")]
	public StellarPlatformSaveSystem SaveSystem; // 0x30
	public StellarPlatformOnlineSystem OnlineSystem; // 0x38
	public StellarPlatformDLCSystem DLCSystem; // 0x40
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <SaveSystemReady>k__BackingField; // 0x49
	[CompilerGenerated]
	private bool <ControllerDisconnectAlert>k__BackingField; // 0x4A
	[CompilerGenerated]
	private string <InvitationLobbyID>k__BackingField; // 0x50
	[CompilerGenerated]
	private StellarInvitationsManager <InvitationsManager>k__BackingField; // 0x58

	// Properties
	public bool Initialized { get; set; }
	public bool SaveSystemReady { get; set; }
	public bool ControllerDisconnectAlert { get; set; }
	public string InvitationLobbyID { get; set; }
	public StellarInvitationsManager InvitationsManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5F2B50 Offset: 0x5F1150 VA: 0x1805F2B50
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x5F2B80 Offset: 0x5F1180 VA: 0x1805F2B80
	private void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5F2B60 Offset: 0x5F1160 VA: 0x1805F2B60
	public bool get_SaveSystemReady() { }

	[CompilerGenerated]
	// RVA: 0x5F2B90 Offset: 0x5F1190 VA: 0x1805F2B90
	private void set_SaveSystemReady(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5F2B40 Offset: 0x5F1140 VA: 0x1805F2B40
	public bool get_ControllerDisconnectAlert() { }

	[CompilerGenerated]
	// RVA: 0x5F2B70 Offset: 0x5F1170 VA: 0x1805F2B70
	public void set_ControllerDisconnectAlert(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5B38B0 Offset: 0x5B1EB0 VA: 0x1805B38B0
	public string get_InvitationLobbyID() { }

	[CompilerGenerated]
	// RVA: 0x5B38C0 Offset: 0x5B1EC0 VA: 0x1805B38C0
	public void set_InvitationLobbyID(string value) { }

	[CompilerGenerated]
	// RVA: 0x5B45B0 Offset: 0x5B2BB0 VA: 0x1805B45B0
	public StellarInvitationsManager get_InvitationsManager() { }

	[CompilerGenerated]
	// RVA: 0x5B45D0 Offset: 0x5B2BD0 VA: 0x1805B45D0
	public void set_InvitationsManager(StellarInvitationsManager value) { }

	// RVA: 0x5F2A20 Offset: 0x5F1020 VA: 0x1805F2A20 Slot: 4
	public virtual void InitializePlatform() { }

	// RVA: 0x5F2A80 Offset: 0x5F1080 VA: 0x1805F2A80
	public void NotifyPlatformInitialized() { }

	// RVA: 0x5F2AE0 Offset: 0x5F10E0 VA: 0x1805F2AE0
	public void NotifySaveSystemReady() { }

	// RVA: 0x5F29F0 Offset: 0x5F0FF0 VA: 0x1805F29F0 Slot: 5
	public virtual string GetUsername() { }

	// RVA: 0x5F29C0 Offset: 0x5F0FC0 VA: 0x1805F29C0 Slot: 6
	public virtual string GetPlatformUserID() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void OpenVirtualKeyboard(string currentString, int characterLimit, bool useFloatingKeyboard = False) { }

	// RVA: 0x4FCAB0 Offset: 0x4FB0B0 VA: 0x1804FCAB0 Slot: 8
	public virtual string CheckStringProfanity(string str) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public virtual void UnlockAchievement(string achievementID, int achievementNumber) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void OpenPlatformUserInfo(string platformUserID) { }

	// RVA: 0x5F2860 Offset: 0x5F0E60 VA: 0x1805F2860
	public GamePlatformFamily GetGamePlatformFamily(GamePlatform gamePlatform) { }

	// RVA: 0x5F2980 Offset: 0x5F0F80 VA: 0x1805F2980 Slot: 11
	public virtual string GetPersistentDataPath() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
