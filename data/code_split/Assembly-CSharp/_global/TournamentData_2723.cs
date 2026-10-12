// Namespace: 
public struct TournamentData // TypeDefIndex: 2723
{
	// Fields
	public string CurrentTournamentId; // 0x0
	public int CurrentPhase; // 0x8
	public TournamentState State; // 0xC
	public List<TournamentPhaseData> TournamentPhases; // 0x10
	public int SpectatorsAmount; // 0x18
	public string Region; // 0x20

	// Methods

	// RVA: 0x738FD0 Offset: 0x7375D0 VA: 0x180738FD0
	public TournamentPhaseData GetCurrentTournamentPhase() { }

	// RVA: 0x738F10 Offset: 0x737510 VA: 0x180738F10
	public RoomData GetCurrentRoomData() { }

	// RVA: 0x738DC0 Offset: 0x7373C0 VA: 0x180738DC0
	public int GetActivePlayers() { }

	// RVA: 0x739120 Offset: 0x737720 VA: 0x180739120
	public GamePlatform GetPlayerPlataform(string NickName) { }

	// RVA: 0x739270 Offset: 0x737870 VA: 0x180739270
	public int GetPlayers() { }
}
