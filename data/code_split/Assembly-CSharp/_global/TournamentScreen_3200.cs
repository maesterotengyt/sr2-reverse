// Namespace: 
public class TournamentScreen : MainMenuScreen // TypeDefIndex: 3200
{
	// Fields
	public TMP_Text PasswordText; // 0x90
	public CancelHoldBar CancelHoldBar; // 0x98
	public ScreenFooterButton CharacterSelectButton; // 0xA0
	public LocalizedString ContinueString; // 0xA8
	public LocalizedString CharacterSelectString; // 0xB0
	private TournamentState lastState; // 0xB8
	private bool passwordHidden; // 0xBC

	// Properties
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x593E40 Offset: 0x592440 VA: 0x180593E40
	private OnlineManager get_onlineManager() { }

	// RVA: 0x593780 Offset: 0x591D80 VA: 0x180593780 Slot: 7
	public override void Show() { }

	// RVA: 0x593600 Offset: 0x591C00 VA: 0x180593600 Slot: 8
	public override void Hide() { }

	// RVA: 0x5939C0 Offset: 0x591FC0 VA: 0x1805939C0 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x5936C0 Offset: 0x591CC0 VA: 0x1805936C0
	public void SetFinishedMode() { }

	// RVA: 0x593850 Offset: 0x591E50 VA: 0x180593850
	public void TogglePassword() { }

	// RVA: 0x593870 Offset: 0x591E70 VA: 0x180593870
	public void TogglePassword(bool hidden) { }

	// RVA: 0x593E30 Offset: 0x592430 VA: 0x180593E30
	public void .ctor() { }
}
