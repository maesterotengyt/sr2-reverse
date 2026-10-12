// Namespace: 
public class JoinPrivateLobbyWorld : MainMenuWorldScreen // TypeDefIndex: 3119
{
	// Fields
	public UINavigator UINavigator; // 0x30
	public StellarInputField PasswordInputField; // 0x38
	public LocalizedString JoiningLobbyString; // 0x40
	public LocalizedString ConfirmString; // 0x48
	public LocalizedString PrivateLobbiesString; // 0x50
	public LocalizedString ErrorLobbyFullString; // 0x58
	private bool joining; // 0x60

	// Methods

	// RVA: 0x5526E0 Offset: 0x550CE0 VA: 0x1805526E0 Slot: 5
	public override void Show() { }

	// RVA: 0x5529F0 Offset: 0x550FF0 VA: 0x1805529F0 Slot: 7
	public override void UpdateScreen() { }

	// RVA: 0x552030 Offset: 0x550630 VA: 0x180552030
	public void JoinLobby() { }

	// RVA: 0x551BE0 Offset: 0x5501E0 VA: 0x180551BE0
	private void JoinLobbyWithPassword(string passwordTyped) { }

	// RVA: 0x5517D0 Offset: 0x54FDD0 VA: 0x1805517D0
	private void JoinLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x552580 Offset: 0x550B80 VA: 0x180552580
	public void ReturnToPreviousScreen(bool forced = False) { }

	// RVA: 0x5516A0 Offset: 0x54FCA0 VA: 0x1805516A0
	private void GetPasswordCrossplayAndPlatformInfo(string pass, out bool fromDifferentCrossplaySetting, out bool crossplayEnabled, out bool fromDifferentPlaformFamily) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
