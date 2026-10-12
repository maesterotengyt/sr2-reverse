// Namespace: 
public class BrainCloudManager : SRMonoBehaviour // TypeDefIndex: 2678
{
	// Fields
	[CompilerGenerated]
	private BrainCloudManager.AuthenticationCheckFinished OnAuthenticationCheckFinished; // 0x20
	public List<EnvironmentData> EnvironmentDatas; // 0x28
	public float AuthTimeout; // 0x30
	public LocalizedString UnableToConnectString; // 0x38
	public LocalizedString UnableToConnectDescriptionString; // 0x40
	public LocalizedString ContinueOfflineString; // 0x48
	public LocalizedString ReconnectString; // 0x50
	private Dictionary<string, object> braincloudProperties; // 0x58
	private const string authenticationFailPopupID = "authentication_failed_popup";
	private int reconnectionTries; // 0x60
	private bool authenticating; // 0x64
	private float authTimer; // 0x68

	// Properties
	private BrainCloudWrapper brainCloudWrapper { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x715EC0 Offset: 0x7144C0 VA: 0x180715EC0
	public void add_OnAuthenticationCheckFinished(BrainCloudManager.AuthenticationCheckFinished value) { }

	[CompilerGenerated]
	// RVA: 0x716080 Offset: 0x714680 VA: 0x180716080
	public void remove_OnAuthenticationCheckFinished(BrainCloudManager.AuthenticationCheckFinished value) { }

	// RVA: 0x716020 Offset: 0x714620 VA: 0x180716020
	private BrainCloudWrapper get_brainCloudWrapper() { }

	// RVA: 0x715B00 Offset: 0x714100 VA: 0x180715B00
	public void Update() { }

	// RVA: 0x70EDB0 Offset: 0x70D3B0 VA: 0x18070EDB0
	public void AuthenticationCheck() { }

	// RVA: 0x70E920 Offset: 0x70CF20 VA: 0x18070E920
	public void AuthenticateResult(bool success, string error) { }

	// RVA: 0x7102E0 Offset: 0x70E8E0 VA: 0x1807102E0
	public bool GetTournamentModeActive() { }

	[AsyncStateMachine(typeof(BrainCloudManager.<askEula>d__38))]
	// RVA: 0x715F60 Offset: 0x714560 VA: 0x180715F60
	private void askEula(bool isAuthenticated) { }

	// RVA: 0x70F6E0 Offset: 0x70DCE0 VA: 0x18070F6E0
	public void EulaAnswered(bool isAuthenticated, bool eulaAccepted) { }

	// RVA: 0x7137C0 Offset: 0x711DC0 VA: 0x1807137C0
	private void OnAuthenticationFailOptionSelected(string popUpID, int optionIndex) { }

	// RVA: 0x70FFE0 Offset: 0x70E5E0 VA: 0x18070FFE0
	private Dictionary<string, object> GetDataFromJSONResponse(string jsonResponse, string[] dataPath) { }

	// RVA: 0x70FEE0 Offset: 0x70E4E0 VA: 0x18070FEE0
	private object GetDataFromJSONArrayResponse(string jsonResponse, string[] dataPath) { }

	// RVA: 0x712C10 Offset: 0x711210 VA: 0x180712C10
	public bool IsAuthenticated() { }

	// RVA: 0x713E50 Offset: 0x712450 VA: 0x180713E50
	public void PlaceMatchBet(int round, List<PlayerBetData> bets, string raceId, string entityId, BrainCloudManager.PlaceMatchBetResult placeMatchBetResult) { }

	// RVA: 0x7133D0 Offset: 0x7119D0 VA: 0x1807133D0
	public void MatchBetFinished(string raceId, string winnerId, string entityId, BrainCloudManager.MatchFinishedResult placeMatchBetResult) { }

	// RVA: 0x714390 Offset: 0x712990 VA: 0x180714390
	public void PlaceRoundBet(List<PlayerBetData> bets, string raceId, string entityId, BrainCloudManager.PlaceRoundBetResult placeRoundBetResult) { }

	// RVA: 0x7151D0 Offset: 0x7137D0 VA: 0x1807151D0
	public void RoundBetFinished(string raceId, string winnerId, string entityId, BrainCloudManager.RoundFinishedResult placeMatchBetResult) { }

	// RVA: 0x70FD50 Offset: 0x70E350 VA: 0x18070FD50
	public void GetCurrency(BrainCloudManager.GetCurrencyResult getCurrency) { }

	// RVA: 0x70F780 Offset: 0x70DD80 VA: 0x18070F780
	public void FindTournament(string iconID, string regionID, BrainCloudManager.FindTournamentRequestResult tournamentRequestResult) { }

	// RVA: 0x712C80 Offset: 0x711280 VA: 0x180712C80
	public void JoinTournament(string iconID, string tournamentID, BrainCloudManager.FindTournamentRequestResult tournamentRequestResult) { }

	// RVA: 0x70F490 Offset: 0x70DA90 VA: 0x18070F490
	public void EnableRTT(BrainCloudManager.TournamentStatusRequestResult tournamentRequestCompleted, BrainCloudManager.RTTResult RTTConnectedCompleted) { }

	// RVA: 0x713CA0 Offset: 0x7122A0 VA: 0x180713CA0
	private void OnRTTSuccess(string response, object cbObject, BrainCloudManager.TournamentStatusRequestResult tournamentRequestCompleted, BrainCloudManager.RTTResult RTTConnectedCompleted) { }

	// RVA: 0x713950 Offset: 0x711F50 VA: 0x180713950
	private void OnRTTFailure(int status, int reasonCode, string responseData, object cbPostObject, BrainCloudManager.TournamentStatusRequestResult tournamentRequestCompleted, BrainCloudManager.RTTResult RTTConnectedCompleted) { }

	// RVA: 0x70F340 Offset: 0x70D940 VA: 0x18070F340
	public void DisableRTT() { }

	// RVA: 0x711220 Offset: 0x70F820 VA: 0x180711220
	private void HandleTournamentFoundSuccess(object cbObject, BrainCloudManager.FindTournamentRequestResult tournamentRequestResult, string response) { }

	// RVA: 0x711490 Offset: 0x70FA90 VA: 0x180711490
	private void HandleTournamentJoinSuccess(object cbObject, BrainCloudManager.FindTournamentRequestResult tournamentRequestResult, string response) { }

	// RVA: 0x7100F0 Offset: 0x70E6F0 VA: 0x1807100F0
	public void GetTournamentList(BrainCloudManager.TournamentListResult tournamentRequestCompleted) { }

	// RVA: 0x7103F0 Offset: 0x70E9F0 VA: 0x1807103F0
	public void GetTournamentUpdate(string tournamentID) { }

	// RVA: 0x710530 Offset: 0x70EB30 VA: 0x180710530
	private void HandleGetTournamentListFoundSuccess(object cbObject, BrainCloudManager.TournamentListResult tournamentRequestCompleted, string response) { }

	// RVA: 0x711770 Offset: 0x70FD70 VA: 0x180711770
	private void HandleTournamentUpdate(BrainCloudManager.TournamentStatusRequestResult tournamentRequestCompleted, string response) { }

	// RVA: 0x712F90 Offset: 0x711590 VA: 0x180712F90
	public void LeaveTournament(string tournamentId, List<NPCData> winnersNpcs, bool diconnect = False, BrainCloudManager.TournamentLeaveResult tournamentRequestCompleted) { }

	// RVA: 0x714E20 Offset: 0x713420 VA: 0x180714E20
	public void ReadyUpTournament(string tournamentId, BrainCloudManager.TournamentReadyUpResult tournamentRequestCompleted) { }

	// RVA: 0x70FB40 Offset: 0x70E140 VA: 0x18070FB40
	public void ForceTournamentPrepare(string tournamentId, BrainCloudManager.TournamentReadyUpResult tournamentRequestCompleted) { }

	// RVA: 0x715430 Offset: 0x713A30 VA: 0x180715430
	public void SetTournamentPlaying(string tournamentId, BrainCloudManager.TournamentSetPlaying tournamentRequestCompleted) { }

	// RVA: 0x7149F0 Offset: 0x712FF0 VA: 0x1807149F0
	public void PostTournamentScore(string tournamentId, int score, List<NPCData> winnersNpcs) { }

	// RVA: 0x715790 Offset: 0x713D90 VA: 0x180715790
	public void UpdateSpectatorsAmount(string operation = "add", bool wasPlayer = False, int round = 0, BrainCloudManager.UpdateSpectatorResult updateSpectatorResult) { }

	// RVA: 0x7110A0 Offset: 0x70F6A0 VA: 0x1807110A0
	private void HandlePostTournamentSuccess(string response, object cbObject, BrainCloudManager.TournamentStatusRequestResult tournamentRequestCompleted) { }

	// RVA: 0x714C70 Offset: 0x713270 VA: 0x180714C70
	public void PrepareTournament(string tournamentId, int tournamentPhase) { }

	// RVA: 0x715030 Offset: 0x713630 VA: 0x180715030
	public void RequestAllServerInfo(BrainCloudManager.RequestAllPlayerInfoResult requestAllPlayerInfoResult) { }

	// RVA: 0x714870 Offset: 0x712E70 VA: 0x180714870
	public void PostRankedMatchResult(string matchJSONData, BrainCloudManager.PostRankedMatchResultsResult calculateRankedRatingCompleted) { }

	// RVA: 0x715C50 Offset: 0x714250 VA: 0x180715C50
	public void UploadLogFile(string fileName, byte[] bytes) { }

	// RVA: 0x7136C0 Offset: 0x711CC0 VA: 0x1807136C0
	public void MoveLogFiles() { }

	// RVA: 0x715E40 Offset: 0x714440 VA: 0x180715E40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x715640 Offset: 0x713C40 VA: 0x180715640
	private void <AuthenticateResult>b__36_0(string response, object cbObject) { }

	[CompilerGenerated]
	// RVA: 0x7110A0 Offset: 0x70F6A0 VA: 0x1807110A0
	private void <PostTournamentScore>b__65_0(string response, object cbObject) { }
}
