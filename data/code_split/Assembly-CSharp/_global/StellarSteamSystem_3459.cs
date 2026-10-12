// Namespace: 
public class StellarSteamSystem : StellarPCSystem // TypeDefIndex: 3459
{
	// Fields
	private bool initialized; // 0x68
	private bool keyboardOpen; // 0x69
	private Callback<GameLobbyJoinRequested_t> gameLobbyJoinRequestedCallback; // 0x70
	private Callback<GamepadTextInputDismissed_t> gamepadTextInputDismissed; // 0x78
	private Callback<FloatingGamepadTextInputDismissed_t> floatingGamepadTextInputDismissed; // 0x80

	// Methods

	// RVA: 0x5F7DB0 Offset: 0x5F63B0 VA: 0x1805F7DB0 Slot: 4
	public override void InitializePlatform() { }

	// RVA: 0x5F8670 Offset: 0x5F6C70 VA: 0x1805F8670
	public void Update() { }

	// RVA: 0x5F7DA0 Offset: 0x5F63A0 VA: 0x1805F7DA0 Slot: 5
	public override string GetUsername() { }

	// RVA: 0x5F7D70 Offset: 0x5F6370 VA: 0x1805F7D70 Slot: 6
	public override string GetPlatformUserID() { }

	// RVA: 0x5F8550 Offset: 0x5F6B50 VA: 0x1805F8550 Slot: 7
	public override void OpenVirtualKeyboard(string currentString, int characterLimit, bool useFloatingKeyboard = False) { }

	// RVA: 0x5F8240 Offset: 0x5F6840 VA: 0x1805F8240
	private void OnFloatingGamepadTextInputDismissed(FloatingGamepadTextInputDismissed_t pCallback) { }

	// RVA: 0x5F8250 Offset: 0x5F6850 VA: 0x1805F8250
	private void OnGamepadTextInputDismissed(GamepadTextInputDismissed_t pCallback) { }

	// RVA: 0x5F7C40 Offset: 0x5F6240 VA: 0x1805F7C40
	private void GameLobbyJoinRequested(GameLobbyJoinRequested_t param) { }

	// RVA: 0x5F8650 Offset: 0x5F6C50 VA: 0x1805F8650 Slot: 9
	public override void UnlockAchievement(string achievementID, int achievementNumber) { }

	// RVA: 0x5F81C0 Offset: 0x5F67C0 VA: 0x1805F81C0 Slot: 12
	public override bool IsSteamDeck() { }

	// RVA: 0x5F7C80 Offset: 0x5F6280 VA: 0x1805F7C80
	public string[] GetAllFriends() { }

	// RVA: 0x5F81D0 Offset: 0x5F67D0 VA: 0x1805F81D0 Slot: 13
	protected virtual void OnDestroy() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
