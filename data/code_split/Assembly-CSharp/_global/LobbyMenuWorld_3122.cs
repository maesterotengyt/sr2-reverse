// Namespace: 
public class LobbyMenuWorld : MainMenuWorldScreen // TypeDefIndex: 3122
{
	// Fields
	public LocalizedString CustomLobbyString; // 0x30
	public List<OnlineMenuOption> OnlineMenuOptions; // 0x38
	public PracticeMenuWorld PracticeMenu; // 0x40

	// Methods

	// RVA: 0x572420 Offset: 0x570A20 VA: 0x180572420 Slot: 5
	public override void Show() { }

	// RVA: 0x572290 Offset: 0x570890 VA: 0x180572290
	private void ShowTutorialMessage() { }

	// RVA: 0x571D20 Offset: 0x570320 VA: 0x180571D20
	public void SelectCreateLobby() { }

	// RVA: 0x5720C0 Offset: 0x5706C0 VA: 0x1805720C0
	public void SelectEnterPublicLobby() { }

	// RVA: 0x571EF0 Offset: 0x5704F0 VA: 0x180571EF0
	public void SelectEnterPrivateLobby() { }

	// RVA: 0x571810 Offset: 0x56FE10 VA: 0x180571810
	public void OnGoToTutorialSelectedFromCreate(string popUpID, int optionIndex) { }

	// RVA: 0x571B10 Offset: 0x570110 VA: 0x180571B10
	public void OnGoToTutorialSelectedFromPublic(string popUpID, int optionIndex) { }

	// RVA: 0x571990 Offset: 0x56FF90 VA: 0x180571990
	public void OnGoToTutorialSelectedFromPrivate(string popUpID, int optionIndex) { }

	// RVA: 0x571C90 Offset: 0x570290 VA: 0x180571C90
	public void ReturnToPreviousScreen() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
