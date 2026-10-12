// Namespace: 
public class CampaignManager // TypeDefIndex: 2584
{
	// Fields
	public CampaignChapterData ActiveChapter; // 0x10
	public int ActiveActIndex; // 0x18
	public int ActiveChapterIndex; // 0x1C
	public int SelectedDifficulty; // 0x20
	public float LastPlayedChapterTime; // 0x24
	public bool CurrentIsRestart; // 0x28
	public bool CurrentOnStart; // 0x29
	public bool FromCampaign; // 0x2A
	public bool IsOnCutscene; // 0x2B
	public bool NewBestTime; // 0x2C
	public bool FromPause; // 0x2D
	private float bestTime; // 0x30

	// Properties
	private SaveManager saveManager { get; }

	// Methods

	// RVA: 0x6F3EF0 Offset: 0x6F24F0 VA: 0x1806F3EF0
	private SaveManager get_saveManager() { }

	// RVA: 0x6F3900 Offset: 0x6F1F00 VA: 0x1806F3900
	public void Initialize() { }

	// RVA: 0x6F3420 Offset: 0x6F1A20 VA: 0x1806F3420
	public void CheckCampaignAnnouncerMuteState() { }

	// RVA: 0x6F3E70 Offset: 0x6F2470 VA: 0x1806F3E70
	public CharacterSpawnData SetCPUData(HashString characterID, int difficulty) { }

	// RVA: 0x6F3920 Offset: 0x6F1F20 VA: 0x1806F3920
	public void SaveChapterBestTime(EventSaveChapterBestTime callback) { }

	// RVA: 0x6F3760 Offset: 0x6F1D60 VA: 0x1806F3760
	public void GetCurrentChapterBestTime() { }

	// RVA: 0x6F34D0 Offset: 0x6F1AD0 VA: 0x1806F34D0
	public ChapterScoreRank GetChapterRankScore(float time) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
