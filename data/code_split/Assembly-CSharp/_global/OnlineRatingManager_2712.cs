// Namespace: 
public class OnlineRatingManager : SRMonoBehaviour // TypeDefIndex: 2712
{
	// Fields
	[CompilerGenerated]
	private OnlineRatingManager.ServerInfoRequestFinished OnServerInfoRequestFinished; // 0x20
	[CompilerGenerated]
	private OnlineRatingManager.PostRatingCompleted OnPostRatingCompleted; // 0x28
	public OnlineRankedData OnlineRankedData; // 0x30
	public string ActivePlaygroundGameMode; // 0x38
	private HashString PlaygroundGameModeID; // 0x40
	private HashString PlaygroundGameModeIDOverride; // 0x50
	public int RankedRating; // 0x60
	public int RankedLeagueIndex; // 0x64
	public int HighestRankedRating; // 0x68
	public int HighestRankedLeagueIndex; // 0x6C
	[CompilerGenerated]
	private int <PreviousRankedRating>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <PreviousRankedLeagueIndex>k__BackingField; // 0x74
	private RankedMatchResultInfo lastRankedMatchResultInfo; // 0x78

	// Properties
	public int PreviousRankedRating { get; set; }
	public int PreviousRankedLeagueIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x735870 Offset: 0x733E70 VA: 0x180735870
	public void add_OnServerInfoRequestFinished(OnlineRatingManager.ServerInfoRequestFinished value) { }

	[CompilerGenerated]
	// RVA: 0x7359C0 Offset: 0x733FC0 VA: 0x1807359C0
	public void remove_OnServerInfoRequestFinished(OnlineRatingManager.ServerInfoRequestFinished value) { }

	[CompilerGenerated]
	// RVA: 0x7357D0 Offset: 0x733DD0 VA: 0x1807357D0
	public void add_OnPostRatingCompleted(OnlineRatingManager.PostRatingCompleted value) { }

	[CompilerGenerated]
	// RVA: 0x735920 Offset: 0x733F20 VA: 0x180735920
	public void remove_OnPostRatingCompleted(OnlineRatingManager.PostRatingCompleted value) { }

	[CompilerGenerated]
	// RVA: 0x70CE10 Offset: 0x70B410 VA: 0x18070CE10
	public int get_PreviousRankedRating() { }

	[CompilerGenerated]
	// RVA: 0x735A70 Offset: 0x734070 VA: 0x180735A70
	public void set_PreviousRankedRating(int value) { }

	[CompilerGenerated]
	// RVA: 0x735910 Offset: 0x733F10 VA: 0x180735910
	public int get_PreviousRankedLeagueIndex() { }

	[CompilerGenerated]
	// RVA: 0x735A60 Offset: 0x734060 VA: 0x180735A60
	public void set_PreviousRankedLeagueIndex(int value) { }

	// RVA: 0x734AD0 Offset: 0x7330D0 VA: 0x180734AD0
	public void Init() { }

	// RVA: 0x734960 Offset: 0x732F60 VA: 0x180734960
	public RankData GetRankedDataFromIndex(int ratingIndex) { }

	// RVA: 0x735050 Offset: 0x733650 VA: 0x180735050
	public void SaveAndSyncRankedRating() { }

	// RVA: 0x734F10 Offset: 0x733510 VA: 0x180734F10
	public void RequestAllServerInfo() { }

	// RVA: 0x735360 Offset: 0x733960 VA: 0x180735360
	public void SaveQuickPlayRating(int newRating) { }

	// RVA: 0x734660 Offset: 0x732C60 VA: 0x180734660
	public void CalculateRating() { }

	// RVA: 0x734CD0 Offset: 0x7332D0 VA: 0x180734CD0
	public void PostRating() { }

	// RVA: 0x734900 Offset: 0x732F00 VA: 0x180734900
	public HashString GetPlaygroundModeID() { }

	// RVA: 0x734CB0 Offset: 0x7332B0 VA: 0x180734CB0
	public void OverridePlaygroundGameMode(HashString newGameModeID) { }

	// RVA: 0x733DA0 Offset: 0x7323A0 VA: 0x180733DA0
	private void CalculateQuickPlayScores() { }

	// RVA: 0x733F50 Offset: 0x732550 VA: 0x180733F50
	private void CalculateRankingScore() { }

	// RVA: 0x734EF0 Offset: 0x7334F0 VA: 0x180734EF0
	private int RatingValidations(int rating) { }

	// RVA: 0x735730 Offset: 0x733D30 VA: 0x180735730
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x735470 Offset: 0x733A70 VA: 0x180735470
	private void <RequestAllServerInfo>b__28_0(bool success, List<RankData> rankedLeagues, int rankedRating, int rankedIndex, string activePlaygroundGameMode) { }

	[CompilerGenerated]
	// RVA: 0x735410 Offset: 0x733A10 VA: 0x180735410
	private void <PostRating>b__31_0(bool success, int rankedRating, int rankedLeagueIndex, int previousRankedRating, int previousRankedLeagueIndex) { }
}
