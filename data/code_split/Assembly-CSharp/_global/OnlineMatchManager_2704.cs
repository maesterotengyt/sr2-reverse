// Namespace: 
public class OnlineMatchManager : SRMonoBehaviour // TypeDefIndex: 2704
{
	// Fields
	[Header("Strings")]
	public LocalizedString PlayerLeftMatchMessageString; // 0x20
	public LocalizedString MatchCannotContinueMessageString; // 0x28
	public LocalizedString CPUPrefixString; // 0x30
	private List<string> currentMatchPlayers; // 0x38
	private List<string> spectatorPlayers; // 0x40

	// Methods

	// RVA: 0x71F780 Offset: 0x71DD80 VA: 0x18071F780
	public void PrepareOnlineMatch() { }

	[IteratorStateMachine(typeof(OnlineMatchManager.<StartOnlineMatchRoutine>d__6))]
	// RVA: 0x721350 Offset: 0x71F950 VA: 0x180721350
	private IEnumerator StartOnlineMatchRoutine() { }

	// RVA: 0x7212F0 Offset: 0x71F8F0 VA: 0x1807212F0
	public void StartOnlineCountdownEvent() { }

	// RVA: 0x7213C0 Offset: 0x71F9C0 VA: 0x1807213C0
	public void StartOnlineMatch() { }

	// RVA: 0x7210E0 Offset: 0x71F6E0 VA: 0x1807210E0
	public void SetMatchPlayers() { }

	// RVA: 0x7207B0 Offset: 0x71EDB0 VA: 0x1807207B0
	private void RecordRecentPlayers() { }

	// RVA: 0x7218B0 Offset: 0x71FEB0 VA: 0x1807218B0
	public void ValidatePlayerData() { }

	// RVA: 0x720C50 Offset: 0x71F250 VA: 0x180720C50
	public void SetMatchCPUs() { }

	// RVA: 0x71EB30 Offset: 0x71D130 VA: 0x18071EB30
	public void PlayerLeftDuringMatch(Player otherPlayer) { }

	// RVA: 0x71E5C0 Offset: 0x71CBC0 VA: 0x18071E5C0
	public void ConfirmOnPlayerLeftAlert(string popUpID) { }

	// RVA: 0x71E800 Offset: 0x71CE00 VA: 0x18071E800
	public void MatchEnded() { }

	// RVA: 0x71E7C0 Offset: 0x71CDC0 VA: 0x18071E7C0
	public bool IsPlayerMatchBrawler(Player player) { }

	// RVA: 0x71E420 Offset: 0x71CA20 VA: 0x18071E420
	public int CalculateMatchPlayers() { }

	// RVA: 0x721CA0 Offset: 0x7202A0 VA: 0x180721CA0
	public void .ctor() { }
}
