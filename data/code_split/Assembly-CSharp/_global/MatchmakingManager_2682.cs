// Namespace: 
public class MatchmakingManager : SRMonoBehaviour // TypeDefIndex: 2682
{
	// Fields
	public MatchmakingManager.OnMatchmakingFinished MatchmakingFinished; // 0x20
	private MatchmakingMode matchmakingMode; // 0x28
	private List<string> excludedLobbies; // 0x30
	public MatchmakingManager.MatchmakingState matchmakingState; // 0x38
	private int ratingSearchIndex; // 0x3C
	private float timeSearching; // 0x40
	private float timeGettingRooms; // 0x44
	private List<RatingSearchData> searchData; // 0x48
	private RatingSearchData currentSearchData; // 0x50
	private OnlineLobbyType currentLobbyType; // 0x5C
	private int currentRating; // 0x60
	private int maxPlayers; // 0x64
	private float secondsToExpireLobby; // 0x68
	private string currentLobby; // 0x70
	private int currentRegionIndex; // 0x78

	// Properties
	public bool IsSearchingMatch { get; }
	public bool IsStartingMatch { get; }

	// Methods

	// RVA: 0x718A70 Offset: 0x717070 VA: 0x180718A70
	public bool get_IsSearchingMatch() { }

	// RVA: 0x718A90 Offset: 0x717090 VA: 0x180718A90
	public bool get_IsStartingMatch() { }

	// RVA: 0x51AE50 Offset: 0x519450 VA: 0x18051AE50
	public void SetMatchmakingMode(MatchmakingMode mode) { }

	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public MatchmakingMode GetMatchmakingMode() { }

	// RVA: 0x7170F0 Offset: 0x7156F0 VA: 0x1807170F0
	public void FindOpponent(MatchmakingMode mode = 0) { }

	// RVA: 0x716560 Offset: 0x714B60 VA: 0x180716560
	private string CheckIfLobbyExist() { }

	// RVA: 0x717050 Offset: 0x715650 VA: 0x180717050
	public void ExcluteCurrentLobby() { }

	// RVA: 0x717880 Offset: 0x715E80 VA: 0x180717880
	private void JoinLobby(string roomID) { }

	// RVA: 0x717500 Offset: 0x715B00 VA: 0x180717500
	private void JoinLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x716B40 Offset: 0x715140 VA: 0x180716B40
	private void CreateLobby(CreateLobbyMessage messageType, HashString gameMode) { }

	// RVA: 0x716E50 Offset: 0x715450 VA: 0x180716E50
	private void CreatingLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x718740 Offset: 0x716D40 VA: 0x180718740
	private void Update() { }

	// RVA: 0x718220 Offset: 0x716820 VA: 0x180718220
	private void TryToJoinLobby() { }

	// RVA: 0x717B90 Offset: 0x716190 VA: 0x180717B90
	private void ReconnectFinish(bool success, string errorID) { }

	// RVA: 0x716930 Offset: 0x714F30 VA: 0x180716930
	private void CheckLobbies() { }

	// RVA: 0x717CC0 Offset: 0x7162C0 VA: 0x180717CC0
	public void StopSearching() { }

	// RVA: 0x7189F0 Offset: 0x716FF0 VA: 0x1807189F0
	public void .ctor() { }
}
