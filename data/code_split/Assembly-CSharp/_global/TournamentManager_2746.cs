// Namespace: 
public class TournamentManager : SRMonoBehaviour // TypeDefIndex: 2746
{
	// Fields
	public TournamentManager.OnJoinTournamentFinish JoinTournamentFinish; // 0x20
	public TournamentManager.TournamentUpdate TournamentStatusUpdate; // 0x28
	public float ForceRoundStartTimer; // 0x30
	public float ServerTimer; // 0x34
	public List<LocalizedString> PhasesStrings; // 0x38
	public LocalizedString NoMatchesToSpectateMessage; // 0x40
	[CompilerGenerated]
	private bool <TournamentActive>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <CurrentRoomID>k__BackingField; // 0x4C
	[CompilerGenerated]
	private bool <StartExperienceSet>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <StartExperience>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <CharacterStartExperience>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <GainedExperience>k__BackingField; // 0x5C
	private float roomTimer; // 0x60
	private float roundStartTimer; // 0x64
	private float tournmanetTimer; // 0x68
	private string photonRoom; // 0x70
	private TournamentData currentTournamentData; // 0x78
	private bool tournamentReadyUp; // 0xA0
	private bool joiningRoom; // 0xA1
	private bool waitingRoomPlayers; // 0xA2
	private bool countdownRoomStart; // 0xA3
	private bool readyToAdvance; // 0xA4
	private bool searchingForPlayers; // 0xA5
	private int startTournamentTime; // 0xA8

	// Properties
	public bool TournamentActive { get; set; }
	public int CurrentRoomID { get; set; }
	public bool StartExperienceSet { get; set; }
	public int StartExperience { get; set; }
	public int CharacterStartExperience { get; set; }
	public int GainedExperience { get; set; }
	public bool IsSearchingTournamentMatch { get; }
	private StellarDataSystem dataSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5F2B50 Offset: 0x5F1150 VA: 0x1805F2B50
	public bool get_TournamentActive() { }

	[CompilerGenerated]
	// RVA: 0x5F2B80 Offset: 0x5F1180 VA: 0x1805F2B80
	public void set_TournamentActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B50 Offset: 0x5C4150 VA: 0x1805C5B50
	public int get_CurrentRoomID() { }

	[CompilerGenerated]
	// RVA: 0x5C5BA0 Offset: 0x5C41A0 VA: 0x1805C5BA0
	public void set_CurrentRoomID(int value) { }

	[CompilerGenerated]
	// RVA: 0x5C9FB0 Offset: 0x5C85B0 VA: 0x1805C9FB0
	public bool get_StartExperienceSet() { }

	[CompilerGenerated]
	// RVA: 0x626430 Offset: 0x624A30 VA: 0x180626430
	public void set_StartExperienceSet(bool value) { }

	[CompilerGenerated]
	// RVA: 0x73E010 Offset: 0x73C610 VA: 0x18073E010
	public int get_StartExperience() { }

	[CompilerGenerated]
	// RVA: 0x73E070 Offset: 0x73C670 VA: 0x18073E070
	public void set_StartExperience(int value) { }

	[CompilerGenerated]
	// RVA: 0x693B20 Offset: 0x692120 VA: 0x180693B20
	public int get_CharacterStartExperience() { }

	[CompilerGenerated]
	// RVA: 0x693B30 Offset: 0x692130 VA: 0x180693B30
	public void set_CharacterStartExperience(int value) { }

	[CompilerGenerated]
	// RVA: 0x5DC8E0 Offset: 0x5DAEE0 VA: 0x1805DC8E0
	public int get_GainedExperience() { }

	[CompilerGenerated]
	// RVA: 0x5DC980 Offset: 0x5DAF80 VA: 0x1805DC980
	public void set_GainedExperience(int value) { }

	// RVA: 0x73DFF0 Offset: 0x73C5F0 VA: 0x18073DFF0
	public bool get_IsSearchingTournamentMatch() { }

	// RVA: 0x73E020 Offset: 0x73C620 VA: 0x18073E020
	private StellarDataSystem get_dataSystem() { }

	// RVA: 0x73BDB0 Offset: 0x73A3B0 VA: 0x18073BDB0
	public void SearchTournament() { }

	// RVA: 0x73ACD0 Offset: 0x7392D0 VA: 0x18073ACD0
	public void JoinTournament(string code) { }

	// RVA: 0x73AF50 Offset: 0x739550 VA: 0x18073AF50
	private void OnAuthenticationFinished(bool isAuthenticated) { }

	// RVA: 0x73CC80 Offset: 0x73B280 VA: 0x18073CC80
	public void TournamentFound(bool success, string tournamentId, int startingIn, string region) { }

	// RVA: 0x73BBB0 Offset: 0x73A1B0 VA: 0x18073BBB0
	private void RegionChanged(bool success, string errorID = "") { }

	// RVA: 0x73DDA0 Offset: 0x73C3A0 VA: 0x18073DDA0
	public void Update() { }

	// RVA: 0x73A0B0 Offset: 0x7386B0 VA: 0x18073A0B0
	public TournamentPhaseData GetCurrentPhase() { }

	// RVA: 0x73A300 Offset: 0x738900 VA: 0x18073A300
	public TournamentData GetTournamentData() { }

	// RVA: 0x73A2E0 Offset: 0x7388E0 VA: 0x18073A2E0
	public int GetRoundTimer() { }

	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public string GetPhotonRoom() { }

	// RVA: 0x73A2F0 Offset: 0x7388F0 VA: 0x18073A2F0
	public float GetStartingTime() { }

	// RVA: 0x73D2A0 Offset: 0x73B8A0 VA: 0x18073D2A0
	public void TournamentStatusCheck(bool success, TournamentState state, List<TournamentPlayer> tournamentPlayers, List<RoomData> roomDatas, int playerIndex, int phase, bool readyStart, bool finalRace) { }

	// RVA: 0x73AAE0 Offset: 0x7390E0 VA: 0x18073AAE0
	public void JoinRoomAsSpectator() { }

	// RVA: 0x73AE20 Offset: 0x739420 VA: 0x18073AE20
	public void LeaveTournamentRoom() { }

	// RVA: 0x73CBB0 Offset: 0x73B1B0 VA: 0x18073CBB0
	public void StartNextTournamentPhase(bool success = True) { }

	// RVA: 0x73BA00 Offset: 0x73A000 VA: 0x18073BA00
	public void ReadyToAdvance() { }

	// RVA: 0x73A830 Offset: 0x738E30 VA: 0x18073A830
	private void JoinLobby(string roomID) { }

	// RVA: 0x73A4A0 Offset: 0x738AA0 VA: 0x18073A4A0
	private void JoinLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x73C260 Offset: 0x73A860 VA: 0x18073C260
	public void StartMatch() { }

	// RVA: 0x739B80 Offset: 0x738180 VA: 0x180739B80
	private void CreateTournamentRoom() { }

	// RVA: 0x7398B0 Offset: 0x737EB0 VA: 0x1807398B0
	private void CreateTornamentFinish(bool success, string errorCode) { }

	// RVA: 0x73B2E0 Offset: 0x7398E0 VA: 0x18073B2E0
	public void PostPlayerScore() { }

	// RVA: 0x73A110 Offset: 0x738710 VA: 0x18073A110
	private NPCData GetNPCData(string playerID) { }

	// RVA: 0x73AED0 Offset: 0x7394D0 VA: 0x18073AED0
	public void LeaveTournament() { }

	// RVA: 0x7394B0 Offset: 0x737AB0 VA: 0x1807394B0
	public void ClearTornamentData() { }

	// RVA: 0x73A330 Offset: 0x738930 VA: 0x18073A330
	public string GetTournamentPhaseName(int phase) { }

	// RVA: 0x73A0F0 Offset: 0x7386F0 VA: 0x18073A0F0
	public List<NPCData> GetCurrentRoomNPCs() { }

	// RVA: 0x7392C0 Offset: 0x7378C0 VA: 0x1807392C0
	public void BecomeSpectator(bool wasPlayer = False) { }

	// RVA: 0x739FA0 Offset: 0x7385A0 VA: 0x180739FA0
	private void EnableRTT() { }

	// RVA: 0x73B1F0 Offset: 0x7397F0 VA: 0x18073B1F0
	public void OnEnableRTT(bool success) { }

	// RVA: 0x73A3A0 Offset: 0x7389A0 VA: 0x18073A3A0
	private bool IsMatchHost() { }

	// RVA: 0x73BED0 Offset: 0x73A4D0 VA: 0x18073BED0
	private void SetPlayerData() { }

	// RVA: 0x73DFD0 Offset: 0x73C5D0 VA: 0x18073DFD0
	public void .ctor() { }
}
