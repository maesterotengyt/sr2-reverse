// Namespace: 
public class LevelSelectOnline : LevelSelectBase // TypeDefIndex: 3071
{
	// Fields
	public Transform OnlinePlayerSelections; // 0xD8
	public TMP_Text PlayersReadyText; // 0xE0
	public LocalizedString PlayersReadyFormat; // 0xE8
	public CancelHoldBar CancelHoldBar; // 0xF0
	public GameObject Timer; // 0xF8
	public TMP_Text TimerText; // 0x100
	public int LevelSelectTimer; // 0x108
	private bool levelStarted; // 0x10C

	// Methods

	// RVA: 0x544BD0 Offset: 0x5431D0 VA: 0x180544BD0 Slot: 7
	public override void Show() { }

	// RVA: 0x545410 Offset: 0x543A10 VA: 0x180545410
	public void TimerEnd() { }

	// RVA: 0x545710 Offset: 0x543D10 VA: 0x180545710
	public void TimerUpdate(bool active, float totalSeconds) { }

	// RVA: 0x5441F0 Offset: 0x5427F0 VA: 0x1805441F0
	private void PhotomRoomInfoUpdate() { }

	[IteratorStateMachine(typeof(LevelSelectOnline.<StartLevel>d__12))]
	// RVA: 0x5453A0 Offset: 0x5439A0 VA: 0x1805453A0
	private IEnumerator StartLevel() { }

	// RVA: 0x543CA0 Offset: 0x5422A0 VA: 0x180543CA0
	private LevelSelectOnlinePlayerSelection GetPlayerSelection(int index) { }

	// RVA: 0x543FB0 Offset: 0x5425B0 VA: 0x180543FB0
	private void OtherPlayerLeavePhotonRoom(Player otherPlayer) { }

	// RVA: 0x5449F0 Offset: 0x542FF0 VA: 0x1805449F0 Slot: 13
	public override void ReturnToPreviousScreen(string screen = "Undefined", string cameraTransition = "") { }

	// RVA: 0x543E30 Offset: 0x542430 VA: 0x180543E30
	public void LeaveLobby() { }

	// RVA: 0x544880 Offset: 0x542E80 VA: 0x180544880
	private void ReturnToOnlineMenu() { }

	// RVA: 0x543D10 Offset: 0x542310 VA: 0x180543D10 Slot: 8
	public override void Hide() { }

	// RVA: 0x5437D0 Offset: 0x541DD0 VA: 0x1805437D0 Slot: 12
	public override void Disable() { }

	// RVA: 0x545870 Offset: 0x543E70 VA: 0x180545870
	public void .ctor() { }
}
