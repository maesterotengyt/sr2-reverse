// Namespace: 
[Serializable]
public class CampaignChapterData // TypeDefIndex: 2523
{
	// Fields
	public AssetReference SpriteReference; // 0x10
	public LocalizedString LocalizedName; // 0x18
	public HashString ID; // 0x20
	public HashString GameModeID; // 0x30
	public HashString StageID; // 0x40
	public string LayoutID; // 0x50
	public HashString PlayerCharacter; // 0x58
	public List<CampaignChapterData.CampaignNPCData> ChapterNPCs; // 0x68
	public HashString StartCutsceneID; // 0x70
	public HashString DialogueID; // 0x80
	public HashString EndCutsceneID; // 0x90
	public bool MuteAnnouncer; // 0xA0
	public float DefaultBestTime; // 0xA4
	public List<ChapterRankThresholds> RankThresholds; // 0xA8

	// Methods

	// RVA: 0x629100 Offset: 0x627700 VA: 0x180629100
	public void .ctor() { }
}
