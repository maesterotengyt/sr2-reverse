// Namespace: 
public struct TournamentPhaseData // TypeDefIndex: 2724
{
	// Fields
	public int PhaseId; // 0x0
	public bool CurrentPhase; // 0x4
	public bool ReadyToPlay; // 0x5
	public bool RoundPlayed; // 0x6
	public int WinnersNeeded; // 0x8
	public bool FinalRound; // 0xC
	public List<RoomData> RoomsData; // 0x10
	public List<TournamentPlayer> TournamentPlayers; // 0x18
	public int LocalPlayerIndex; // 0x20

	// Methods

	// RVA: 0x73E080 Offset: 0x73C680 VA: 0x18073E080
	public RoomData GetCurrentRoom() { }

	// RVA: 0x73E100 Offset: 0x73C700 VA: 0x18073E100
	public TournamentPlayer GetLocalPlayer() { }
}
