// Namespace: 
public class CharacterSelectTournament : CharacterSelectBase // TypeDefIndex: 3027
{
	// Fields
	public TMP_Text PlayersReady; // 0xC8
	public TMP_Text PlayersReadyShadow; // 0xD0
	public GameObject PlayersPreparing; // 0xD8
	public GameObject Timer; // 0xE0
	public TMP_Text TimerText; // 0xE8
	public TMP_Text TimerTextShadow; // 0xF0
	public int CharacterSelectTimer; // 0xF8
	public GameObject FindingPlayers; // 0x100
	public GameObject FindingTournament; // 0x108
	public TMP_Text PasswordText; // 0x110
	public ScreenFooterButton BackButton; // 0x118
	public LocalizedString PlayersReadyFormat; // 0x120
	public LocalizedString BackString; // 0x128
	private bool passwordHidden; // 0x130
	private float tournamentStartTime; // 0x134
	private bool activeTimer; // 0x138

	// Methods

	// RVA: 0x792720 Offset: 0x790D20 VA: 0x180792720 Slot: 5
	public override void Load() { }

	// RVA: 0x793160 Offset: 0x791760 VA: 0x180793160 Slot: 7
	public override void Show() { }

	// RVA: 0x7930E0 Offset: 0x7916E0 VA: 0x1807930E0
	private void SelectorUpdated(CharacterSelector updatedSelector) { }

	// RVA: 0x7935D0 Offset: 0x791BD0 VA: 0x1807935D0
	private void UpdateData() { }

	// RVA: 0x793800 Offset: 0x791E00 VA: 0x180793800 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x7929E0 Offset: 0x790FE0 VA: 0x1807929E0
	private void RemainTimer() { }

	// RVA: 0x793490 Offset: 0x791A90 VA: 0x180793490
	public void TogglePassword() { }

	// RVA: 0x7934B0 Offset: 0x791AB0 VA: 0x1807934B0
	public void TogglePassword(bool hidden) { }

	// RVA: 0x792F30 Offset: 0x791530 VA: 0x180792F30 Slot: 13
	public override void ReturnToPreviousScreen(string screen = "Undefined", string cameraTransition = "") { }

	// RVA: 0x7925D0 Offset: 0x790BD0 VA: 0x1807925D0
	public void LeaveLobby() { }

	// RVA: 0x792CB0 Offset: 0x7912B0 VA: 0x180792CB0
	private void ReturnToOnlineMenu() { }

	// RVA: 0x792380 Offset: 0x790980 VA: 0x180792380 Slot: 12
	public override void Disable() { }

	// RVA: 0x7938D0 Offset: 0x791ED0 VA: 0x1807938D0
	public void .ctor() { }
}
