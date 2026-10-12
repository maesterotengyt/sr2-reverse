// Namespace: 
public class ProgressionManager : SRMonoBehaviour // TypeDefIndex: 2615
{
	// Fields
	public ProgressionData ProgressionData; // 0x20
	public bool TutorialRewards; // 0x28
	public HashString[] ExcludedGameModes; // 0x30
	public HashString[] NoRewardGameModes; // 0x38

	// Methods

	// RVA: 0x7035E0 Offset: 0x701BE0 VA: 0x1807035E0
	public int GiveMatchExperience(int bonusExperience = 0) { }

	// RVA: 0x7034B0 Offset: 0x701AB0 VA: 0x1807034B0
	public void GiveExperience(int experience) { }

	// RVA: 0x7030B0 Offset: 0x7016B0 VA: 0x1807030B0
	public void GiveExperience(HashString character, int experience) { }

	// RVA: 0x6FFA40 Offset: 0x6FE040 VA: 0x1806FFA40
	public void AddBiomePlayed() { }

	// RVA: 0x703F90 Offset: 0x702590 VA: 0x180703F90
	public bool IsMaxLevel(int experience) { }

	// RVA: 0x704000 Offset: 0x702600 VA: 0x180704000
	public bool IsMaxLevel(HashString character, int experience) { }

	// RVA: 0x6FFF70 Offset: 0x6FE570 VA: 0x1806FFF70
	public void AddFoundTreasureID(HashString foundBiome) { }

	// RVA: 0x7011E0 Offset: 0x6FF7E0 VA: 0x1807011E0
	public void CheckToUnlockRewardsCharacter(HashString character) { }

	// RVA: 0x7016B0 Offset: 0x6FFCB0 VA: 0x1807016B0
	public void CheckToUnlockRewards() { }

	// RVA: 0x700750 Offset: 0x6FED50 VA: 0x180700750
	public void CheckToUnlockItemRewards() { }

	// RVA: 0x700070 Offset: 0x6FE670 VA: 0x180700070
	public void CheckToUnlockBiomeRewards() { }

	// RVA: 0x702010 Offset: 0x700610 VA: 0x180702010
	public void CheckToUnlockTreasureRewards() { }

	// RVA: 0x700D80 Offset: 0x6FF380 VA: 0x180700D80
	public void CheckToUnlockRankedRewards(int newRankIndex) { }

	// RVA: 0x701AC0 Offset: 0x7000C0 VA: 0x180701AC0
	public void CheckToUnlockTotalGamesRewards() { }

	// RVA: 0x702C40 Offset: 0x701240 VA: 0x180702C40
	public int GetLocalLevel() { }

	// RVA: 0x702E80 Offset: 0x701480 VA: 0x180702E80
	public PlayerLevelData GetPlayerLevelData() { }

	// RVA: 0x7024F0 Offset: 0x700AF0 VA: 0x1807024F0
	public PlayerLevelData GetCharacterLevelData(HashString character) { }

	// RVA: 0x7028C0 Offset: 0x700EC0 VA: 0x1807028C0
	public int GetCharacterLevel(HashString character) { }

	// RVA: 0x704090 Offset: 0x702690 VA: 0x180704090
	public bool TryGetFirstNonNPCPlayerResult(out PlayerRaceResult playerRaceResult) { }

	// RVA: 0x704270 Offset: 0x702870 VA: 0x180704270
	public void .ctor() { }
}
