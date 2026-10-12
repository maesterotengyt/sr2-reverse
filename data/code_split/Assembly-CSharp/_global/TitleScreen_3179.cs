// Namespace: 
public class TitleScreen : MainMenuScreen // TypeDefIndex: 3179
{
	// Fields
	public GameObject MovementLines; // 0x90
	public LocalizedString PressAnyButtonSwitchString; // 0x98
	public LocalizedString PressAnyButtonString; // 0xA0
	public TMP_Text PressAnyButtonText; // 0xA8
	private bool authenticating; // 0xB0

	// Properties
	private OnlineManager onlineManager { get; }
	private UIManager uiManager { get; }
	protected SaveManager saveManager { get; }
	protected StellarPlatformSystem stellarPlatformSystem { get; }

	// Methods

	// RVA: 0x58DC50 Offset: 0x58C250 VA: 0x18058DC50
	private OnlineManager get_onlineManager() { }

	// RVA: 0x58DD40 Offset: 0x58C340 VA: 0x18058DD40
	private UIManager get_uiManager() { }

	// RVA: 0x58DCA0 Offset: 0x58C2A0 VA: 0x18058DCA0
	protected SaveManager get_saveManager() { }

	// RVA: 0x58DCF0 Offset: 0x58C2F0 VA: 0x18058DCF0
	protected StellarPlatformSystem get_stellarPlatformSystem() { }

	// RVA: 0x58D420 Offset: 0x58BA20 VA: 0x18058D420 Slot: 5
	public override void Load() { }

	// RVA: 0x58D9B0 Offset: 0x58BFB0 VA: 0x18058D9B0 Slot: 7
	public override void Show() { }

	// RVA: 0x58D320 Offset: 0x58B920 VA: 0x18058D320 Slot: 8
	public override void Hide() { }

	// RVA: 0x58DBB0 Offset: 0x58C1B0 VA: 0x18058DBB0 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x58D470 Offset: 0x58BA70 VA: 0x18058D470
	private void OnAuthenticationFinished(bool isAuthenticated) { }

	// RVA: 0x58D840 Offset: 0x58BE40 VA: 0x18058D840
	private void RequestInitialServerInfo() { }

	// RVA: 0x58D6D0 Offset: 0x58BCD0 VA: 0x18058D6D0
	private void OnInitialServerInfoRequested() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
