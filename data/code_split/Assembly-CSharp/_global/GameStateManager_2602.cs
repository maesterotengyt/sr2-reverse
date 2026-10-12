// Namespace: 
public class GameStateManager : SRMonoBehaviour // TypeDefIndex: 2602
{
	// Fields
	[CompilerGenerated]
	private List<PlayerRaceResult> <PlayerRaceResults>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<string, int> <PlayerRaceResultsIndexes>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <WinnerPlayerID>k__BackingField; // 0x30
	[CompilerGenerated]
	private PlayerStats <WinnerPlayerStats>k__BackingField; // 0x38
	public bool IsMatchDifficultyUniform; // 0xB8
	public int MatchDifficulty; // 0xBC
	public int RoundNumber; // 0xC0
	public bool IsBasicTutorialMatch; // 0xC4
	public Transform WinnerCharacter; // 0xC8
	public Transform LocalCharacter; // 0xD0
	private PlayerCustomization winnerCustomization; // 0xD8
	private List<StellarCharacterData> charactersData; // 0x128
	private bool WonMatch; // 0x130

	// Properties
	public List<PlayerRaceResult> PlayerRaceResults { get; set; }
	public Dictionary<string, int> PlayerRaceResultsIndexes { get; set; }
	public string WinnerPlayerID { get; set; }
	public PlayerStats WinnerPlayerStats { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public List<PlayerRaceResult> get_PlayerRaceResults() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	public void set_PlayerRaceResults(List<PlayerRaceResult> value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public Dictionary<string, int> get_PlayerRaceResultsIndexes() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	public void set_PlayerRaceResultsIndexes(Dictionary<string, int> value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public string get_WinnerPlayerID() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_WinnerPlayerID(string value) { }

	[CompilerGenerated]
	// RVA: 0x6FB540 Offset: 0x6F9B40 VA: 0x1806FB540
	public PlayerStats get_WinnerPlayerStats() { }

	[CompilerGenerated]
	// RVA: 0x6FB590 Offset: 0x6F9B90 VA: 0x1806FB590
	public void set_WinnerPlayerStats(PlayerStats value) { }

	// RVA: 0x6F78D0 Offset: 0x6F5ED0 VA: 0x1806F78D0
	public void Initialize() { }

	// RVA: 0x6F7D70 Offset: 0x6F6370 VA: 0x1806F7D70
	public void MatchStart() { }

	// RVA: 0x6FA420 Offset: 0x6F8A20 VA: 0x1806FA420
	private void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x6F7FC0 Offset: 0x6F65C0 VA: 0x1806F7FC0
	private void NotifyMatchFinished(EventNotifyMatchFinished callback) { }

	// RVA: 0x6FA410 Offset: 0x6F8A10 VA: 0x1806FA410
	public void NotifyRaceRoundStart(EventRoundStart callback) { }

	// RVA: 0x6FA0D0 Offset: 0x6F86D0 VA: 0x1806FA0D0
	public void NotifyRaceRoundEnd(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x6F8650 Offset: 0x6F6C50 VA: 0x1806F8650
	private void NotifyRaceFinished(EventNotifyRaceEnd callback) { }

	// RVA: 0x6FAC70 Offset: 0x6F9270 VA: 0x1806FAC70
	public void SaveWinnerCharacter() { }

	// RVA: 0x6FA800 Offset: 0x6F8E00 VA: 0x1806FA800
	public void SaveLocalCharacter() { }

	// RVA: 0x6F7710 Offset: 0x6F5D10 VA: 0x1806F7710
	public Player GetPlayerFromNickname(string nickname) { }

	// RVA: 0x6FB2F0 Offset: 0x6F98F0 VA: 0x1806FB2F0
	public bool TryFindPlayerRaceResult(string playerID, out PlayerRaceResult playerRaceResult) { }

	// RVA: 0x6F7890 Offset: 0x6F5E90 VA: 0x1806F7890
	public PlayerCustomization GetWinnerData() { }

	// RVA: 0x6FA5C0 Offset: 0x6F8BC0 VA: 0x1806FA5C0
	public bool OnlyBotsAlive() { }

	// RVA: 0x6FB090 Offset: 0x6F9690 VA: 0x1806FB090
	public bool SoloMatch() { }

	// RVA: 0x6F71E0 Offset: 0x6F57E0 VA: 0x1806F71E0
	public int CountPlayersAlive() { }

	// RVA: 0x6F7AE0 Offset: 0x6F60E0 VA: 0x1806F7AE0
	public bool IsPlayerAlive(EntityRef entity) { }

	// RVA: 0x6F7390 Offset: 0x6F5990 VA: 0x1806F7390
	public StellarCharacterData GetLocalCharacter() { }

	// RVA: 0x6F7BB0 Offset: 0x6F61B0 VA: 0x1806F7BB0
	public bool IsPlayerLocal(EntityRef entityRef) { }

	// RVA: 0x6FB430 Offset: 0x6F9A30 VA: 0x1806FB430
	public void .ctor() { }
}
