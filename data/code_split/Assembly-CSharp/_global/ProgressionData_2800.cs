// Namespace: 
public class ProgressionData : ScriptableObject // TypeDefIndex: 2800
{
	// Fields
	public List<ExperienceData> ExperienceDatas; // 0x18
	public int RoundWonExperience; // 0x20
	public List<PlayerLevelData> PlayerLevelsData; // 0x28
	public List<CharacterLevelData> CharacterLevelsData; // 0x30
	public List<PlayerItemEventData> PlayerItemEventsData; // 0x38
	public List<PlayerBiomeEventData> PlayerBiomesEventsData; // 0x40
	public List<PlayerTreasureEventData> PlayerTreasureEventsData; // 0x48
	public List<PlayerRankedEventData> PlayerRankedEventsData; // 0x50
	public List<PlayerTotalGamesEventData> PlayerTotalGamesEventsData; // 0x58
	public List<TutorialEventData> TutorialEventsData; // 0x60
	public List<Unlockable> AllTutorialsEventData; // 0x68

	// Methods

	// RVA: 0x737130 Offset: 0x735730 VA: 0x180737130
	public CharacterLevelData GetCharacterLevelData(HashString characterID) { }

	// RVA: 0x737220 Offset: 0x735820 VA: 0x180737220
	public ExperienceData GetExprienceData(string eventID) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
