// Namespace: 
public class PlayerListOptions : SRMonoBehaviour // TypeDefIndex: 3211
{
	// Fields
	public LocalizedString BlockPlayerString; // 0x20
	public LocalizedString BlockPlayerDescriptionString; // 0x28
	public LocalizedString BlockPlayerCompletedString; // 0x30
	public LocalizedString ReportPlayerString; // 0x38
	public LocalizedString ReportPlayerDescriptionString; // 0x40
	public LocalizedString ReportPlayerCompletedString; // 0x48
	public LocalizedString UnBlockPlayerString; // 0x50
	public LocalizedString UnBlockPlayerDescriptionString; // 0x58
	public LocalizedString UnBlockPlayerCompletedString; // 0x60
	public LocalizedString UnableToSendString; // 0x68
	public UINavigationElement BlockPlayerOption; // 0x70
	public UINavigationElement UnblockPlayerOption; // 0x78
	public UINavigationElement ReportPlayerOption; // 0x80
	public UINavigationElement OpenPlayerProfileOption; // 0x88
	public UINavigationElement YouOption; // 0x90
	public UINavigator Navigator; // 0x98
	private SavedPlayerData currentPlayerSelected; // 0xA0

	// Methods

	// RVA: 0x585DA0 Offset: 0x5843A0 VA: 0x180585DA0
	public bool IsAnyEnabled() { }

	// RVA: 0x587920 Offset: 0x585F20 VA: 0x180587920
	public void SetOptions(SavedPlayerData otherPlayer, bool OnlyProfile = False) { }

	// RVA: 0x587440 Offset: 0x585A40 VA: 0x180587440
	private void OpenProfileSetup(SavedPlayerData otherPlayer) { }

	// RVA: 0x585D50 Offset: 0x584350 VA: 0x180585D50
	public void HideOptions() { }

	// RVA: 0x5873C0 Offset: 0x5859C0 VA: 0x1805873C0
	public void OpenPlayerProfile(SavedPlayerData id) { }

	// RVA: 0x585E10 Offset: 0x584410 VA: 0x180585E10
	public static bool IsPlayerFromSamePlatform(SavedPlayerData otherPlayer) { }

	// RVA: 0x5875E0 Offset: 0x585BE0 VA: 0x1805875E0
	public void ReportPlayer(SavedPlayerData id) { }

	// RVA: 0x5863F0 Offset: 0x5849F0 VA: 0x1805863F0
	private void OnReportPlayerOptionSelected(string popUpID, int optionIndex) { }

	// RVA: 0x585E50 Offset: 0x584450 VA: 0x180585E50
	private static void MailDeliveryComplete(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x5859E0 Offset: 0x583FE0 VA: 0x1805859E0
	public void BlockPlayer(SavedPlayerData id) { }

	// RVA: 0x585FD0 Offset: 0x5845D0 VA: 0x180585FD0
	private void OnBlockPlayerOptionSelected(string popUpID, int optionIndex) { }

	// RVA: 0x588050 Offset: 0x586650 VA: 0x180588050
	public void UnblockPlayer(SavedPlayerData id) { }

	// RVA: 0x586FA0 Offset: 0x5855A0 VA: 0x180586FA0
	private void OnUnBlockPlayerOptionSelected(string popUpID, int optionIndex) { }

	// RVA: 0x587D50 Offset: 0x586350 VA: 0x180587D50
	private void ShowContinuePopup(string message) { }

	// RVA: 0x586DF0 Offset: 0x5853F0 VA: 0x180586DF0
	private void OnShowContinuePopupFinished(string popUpID) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
