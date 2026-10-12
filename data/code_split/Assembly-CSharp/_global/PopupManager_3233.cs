// Namespace: 
public class PopupManager : SRMonoBehaviour // TypeDefIndex: 3233
{
	// Fields
	public SystemMessages SystemMessages; // 0x20
	[Header("Popups")]
	public GameObject AlertPopup; // 0x28
	public GameObject LoadingPopup; // 0x30
	public GameObject ConfirmationPopup; // 0x38
	public GameObject CustomExitPopup; // 0x40
	public GameObject SteamFestAlert; // 0x48
	public GameObject InformationPopup; // 0x50
	public GameObject EulaPopup; // 0x58
	[Header("Strings")]
	public LocalizedString ConfirmString; // 0x60
	public LocalizedString CancelString; // 0x68
	public LocalizedString YesString; // 0x70
	public LocalizedString NoString; // 0x78
	public LocalizedString FeedbackString; // 0x80
	public LocalizedString WishlistString; // 0x88
	public LocalizedString ContinueString; // 0x90
	public LocalizedString ExitString; // 0x98
	public LocalizedString CustomExitGameWarningString; // 0xA0
	public LocalizedString SteamFestDescriptionString; // 0xA8
	public LocalizedString SteamFestTitleString; // 0xB0
	public PopupManager.OnConfirmSelected ConfirmSelected; // 0xB8
	public PopupManager.OnOption1Selected OptionSelected; // 0xC0
	private List<UIPopup> currentPopups; // 0xC8
	[CompilerGenerated]
	private static PopupManager <Instance>k__BackingField; // 0x0
	private int lastPopups; // 0xD0
	private bool PopupThisFrame; // 0xD4

	// Properties
	public static PopupManager Instance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x589700 Offset: 0x587D00 VA: 0x180589700
	public static PopupManager get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x589740 Offset: 0x587D40 VA: 0x180589740
	private static void set_Instance(PopupManager value) { }

	// RVA: 0x588390 Offset: 0x586990 VA: 0x180588390
	private void Awake() { }

	// RVA: 0x5894D0 Offset: 0x587AD0 VA: 0x1805894D0
	private void Update() { }

	// RVA: 0x588790 Offset: 0x586D90 VA: 0x180588790
	private void SetupPopup(UIPopup popUp, string popUpID) { }

	// RVA: 0x5886F0 Offset: 0x586CF0 VA: 0x1805886F0
	public bool IsPopupActive(string popUpID) { }

	// RVA: 0x5886A0 Offset: 0x586CA0 VA: 0x1805886A0
	public bool IsPopupActive() { }

	// RVA: 0x589670 Offset: 0x587C70 VA: 0x180589670
	public bool WasPopupActiveThisFrame() { }

	// RVA: 0x589250 Offset: 0x587850 VA: 0x180589250
	public void ShowSteamFestAlert(string popUpID, string message, string description = "", bool interruptsLoading = True) { }

	// RVA: 0x5893B0 Offset: 0x5879B0 VA: 0x1805893B0
	public void ShowWishListPopUpAlert(string popUpID, string message, string description, string option1, string option2) { }

	// RVA: 0x588D30 Offset: 0x587330 VA: 0x180588D30
	public void ShowEulaPopUp(string popUpID, bool isAuthenticated) { }

	// RVA: 0x589000 Offset: 0x587600 VA: 0x180589000
	public void ShowInformationPopup(string popUpID, string message) { }

	// RVA: 0x588910 Offset: 0x586F10 VA: 0x180588910
	public void ShowAlert(string popUpID, string message, string description = "", bool interruptsLoading = True, GamePlatform platform = 0) { }

	// RVA: 0x588AF0 Offset: 0x5870F0 VA: 0x180588AF0
	public void ShowAlert(string popUpID, bool interruptsLoading = True) { }

	// RVA: 0x588AE0 Offset: 0x5870E0 VA: 0x180588AE0
	public void ShowAlert(AlertPopup alertPopup, string popUpID) { }

	// RVA: 0x589140 Offset: 0x587740 VA: 0x180589140
	public void ShowLoadingMessage(string popUpID, string message) { }

	// RVA: 0x588C00 Offset: 0x587200 VA: 0x180588C00
	public void ShowConfirmationWindow(string popUpID, string message, string description, string option1, string option2, ConfirmationPopup.Style style) { }

	// RVA: 0x588EE0 Offset: 0x5874E0 VA: 0x180588EE0
	public void ShowExitWindow(string popUpID, string message, string description, string option1, string option2) { }

	// RVA: 0x588B80 Offset: 0x587180 VA: 0x180588B80
	public void ShowConfirmationWindow(string popUpID, string message, string description, ConfirmationPopup.Style style) { }

	// RVA: 0x588520 Offset: 0x586B20 VA: 0x180588520
	public void HidePopup(string popUpID) { }

	// RVA: 0x5883F0 Offset: 0x5869F0 VA: 0x1805883F0
	public void HideAllPopups() { }

	// RVA: 0x589680 Offset: 0x587C80 VA: 0x180589680
	public void .ctor() { }
}
