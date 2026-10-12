// Namespace: 
[Serializable]
public class SaveData // TypeDefIndex: 2525
{
	// Fields
	[HideInInspector]
	public string Version; // 0x10
	[Header("Flags")]
	public bool FirstMatchPlayed; // 0x18
	public bool WishListPopUpShown; // 0x19
	public bool ClosedCorrectly; // 0x1A
	public bool BasicTutorialPromptShown; // 0x1B
	[Header("Audio")]
	public float MasterVolume; // 0x1C
	public float MusicVolume; // 0x20
	public float AmbientVolume; // 0x24
	public float SoundsVolume; // 0x28
	public float VOVolume; // 0x2C
	[Header("Game")]
	public List<InputProfile> Profiles; // 0x30
	public List<EmoteData> Emotes; // 0x38
	public int DefaultProfile; // 0x40
	public string Language; // 0x48
	public bool CrossPlayEnabled; // 0x50
	public bool EmotesEnabled; // 0x51
	public bool ChatEnabled; // 0x52
	public bool HudOnlyEmotes; // 0x53
	public bool TrailsEnabled; // 0x54
	public bool OpponentsTrailsEnabled; // 0x55
	public PlayerCustomization PlayerCustomization; // 0x58
	public OutlineColor OutlineColor; // 0xA8
	public OutlineVisibility OutlineVisibility; // 0xAC
	public int CameraFieldOfViewIndex; // 0xB0
	public bool IsDetailedRopeEffectEnabled; // 0xB4
	[Header("Last Used")]
	public HashString LastUsedCharacter; // 0xB8
	public int LastUsedCostume; // 0xC8
	public List<LastSelectedCharacterCostume> LastSelectedCharactersCostume; // 0xD0
	[Header("Unlockables")]
	public List<string> AchievementsUnlocked; // 0xD8
	public List<Unlockable> Unlockables; // 0xE0
	public List<Unlockable> CurrentMatchRewards; // 0xE8
	public List<Unlockable> TournamentRewards; // 0xF0
	public List<HashString> FoundTreasureID; // 0xF8
	[Header("Level / Stats")]
	public bool BasicTutorialCompleted; // 0x100
	public bool BasicTutorialUnlockableCompleted; // 0x101
	public int Experience; // 0x104
	public List<CharacterStats> CharacterStats; // 0x108
	public int MatchesWon; // 0x110
	public int RankedWon; // 0x114
	public int GamesOnline; // 0x118
	public int GamesOffline; // 0x11C
	public List<BestLevelLapTime> BestStageLapTimes; // 0x120
	public List<BestChapterTime> BestChapterTimes; // 0x128
	public List<HashString> CompletedAdvancedTutorials; // 0x130
	public int RocketsHit; // 0x138
	public int BombsHit; // 0x13C
	public int FreezeRaysHit; // 0x140
	public int CratesHit; // 0x144
	public int InvinciDrillsHit; // 0x148
	public int FireBallsHit; // 0x14C
	public int ShockWavesHit; // 0x150
	public int GoldenHooksHit; // 0x154
	public List<BiomeHistory> BiomesHistory; // 0x158
	[Header("Accolades counters")]
	public int AccoladeSuperSpeedCounter; // 0x160
	public int AccoladeTackleCounter; // 0x164
	public int AccoladeRevengeCounter; // 0x168
	public int AccoladeDoubleCounter; // 0x16C
	public int AccoladeTripleCounter; // 0x170
	public int AccoladeFreezeCounter; // 0x174
	public int AccoladeBackfiredCounter; // 0x178
	public int AccoladeGotchaCounter; // 0x17C
	public int AccoladeBlockedCounter; // 0x180
	public int AccoladeDodgedCounter; // 0x184
	public int AccoladeStillAliveCounter; // 0x188
	[Header("Online")]
	public string OnlineRegion; // 0x190
	public HashString OnlineCharacter; // 0x198
	public int OnlineCostume; // 0x1A8
	public int GlobalRating; // 0x1AC
	public int LastKnownRankedRating; // 0x1B0
	public int LastKnownRankedLeagueIndex; // 0x1B4
	public int HighestKnownRankedRating; // 0x1B8
	public int HighestKnownRankedLeagueIndex; // 0x1BC
	public List<SavedPlayerData> BlockedPlayers; // 0x1C0
	public List<SavedPlayerData> RecentPlayers; // 0x1C8
	public static SaveData.OnBlockListUpdated BlockListUpdated; // 0x0
	public bool EulaAccepted; // 0x1D0
	[Header("PC Settings")]
	public FullScreenMode FullScreenMode; // 0x1D4
	public int ResolutionWidth; // 0x1D8
	public int ResolutionHeight; // 0x1DC
	public bool VSync; // 0x1E0
	public int FrameLimit; // 0x1E4
	public int AntiAliasing; // 0x1E8
	public int QualityLevel; // 0x1EC
	[Header("Campaign")]
	public CampaignSaveData CampaignSaveData; // 0x1F0

	// Methods

	// RVA: 0x635090 Offset: 0x633690 VA: 0x180635090
	public PlayerSettings GetDefaultPlayerSettings() { }

	// RVA: 0x634BF0 Offset: 0x6331F0 VA: 0x180634BF0
	public BestLevelLapTime GetBestLevelLapTime(HashString levelID, string layoutID) { }

	// RVA: 0x634A40 Offset: 0x633040 VA: 0x180634A40
	public BestChapterTime GetBestChapterTime(HashString chapterID) { }

	// RVA: 0x635640 Offset: 0x633C40 VA: 0x180635640
	public bool TryAddBlockedPlayer(SavedPlayerData data) { }

	// RVA: 0x634780 Offset: 0x632D80 VA: 0x180634780
	public bool AddRecentPlayers(SavedPlayerData[] data) { }

	// RVA: 0x634590 Offset: 0x632B90 VA: 0x180634590
	public bool AddRecentPlayer(SavedPlayerData data) { }

	// RVA: 0x6349E0 Offset: 0x632FE0 VA: 0x1806349E0
	public bool ClearRecentPlayer() { }

	// RVA: 0x6352A0 Offset: 0x6338A0 VA: 0x1806352A0
	public bool IsPlayerBlocked(SavedPlayerData data) { }

	// RVA: 0x635470 Offset: 0x633A70 VA: 0x180635470
	public bool IsPlayerIDBlocked(string playerID) { }

	// RVA: 0x6359C0 Offset: 0x633FC0 VA: 0x1806359C0
	public bool TryRemoveBlockedPlayer(SavedPlayerData data) { }

	// RVA: 0x634E50 Offset: 0x633450 VA: 0x180634E50
	public CharacterStats GetCharacterStats(HashString characterID) { }

	// RVA: 0x634DB0 Offset: 0x6333B0 VA: 0x180634DB0
	public CharacterStats GetCharacterStats(int characterID) { }

	// RVA: 0x6350F0 Offset: 0x6336F0 VA: 0x1806350F0
	public LastSelectedCharacterCostume GetLastSelectedCharacterCostume(HashString characterID) { }

	// RVA: 0x635AD0 Offset: 0x6340D0 VA: 0x180635AD0
	public void UpdateLastSelectedCharacterCostume(HashString characterID, int costumeID) { }

	// RVA: 0x635CD0 Offset: 0x6342D0 VA: 0x180635CD0
	public void .ctor() { }
}
