// Namespace: 
public class RaceTutorialManager : SpeedRunnersGameModeManager // TypeDefIndex: 2616
{
	// Fields
	private bool isInitialSection; // 0x48
	public LevelUpScreen LevelUpScreen; // 0x50

	// Properties
	private SaveManager saveManager { get; }
	private AchievementsManager achievementsManager { get; }
	protected SceneLoader sceneLoader { get; }
	private UIManager uiManager { get; }
	private DataManager dataManager { get; }
	public StellarGameModeHUD StellarHud { get; }

	// Methods

	// RVA: 0x7057A0 Offset: 0x703DA0 VA: 0x1807057A0
	private SaveManager get_saveManager() { }

	// RVA: 0x705700 Offset: 0x703D00 VA: 0x180705700
	private AchievementsManager get_achievementsManager() { }

	// RVA: 0x7057F0 Offset: 0x703DF0 VA: 0x1807057F0
	protected SceneLoader get_sceneLoader() { }

	// RVA: 0x705840 Offset: 0x703E40 VA: 0x180705840
	private UIManager get_uiManager() { }

	// RVA: 0x705750 Offset: 0x703D50 VA: 0x180705750
	private DataManager get_dataManager() { }

	// RVA: 0x705690 Offset: 0x703C90 VA: 0x180705690
	public StellarGameModeHUD get_StellarHud() { }

	// RVA: 0x7045E0 Offset: 0x702BE0 VA: 0x1807045E0 Slot: 4
	public override void Init() { }

	// RVA: 0x705570 Offset: 0x703B70 VA: 0x180705570
	private void OnRaceTutorialLoadedAndReady(EventRaceTutorialLoadedAndReady callback) { }

	// RVA: 0x7047A0 Offset: 0x702DA0 VA: 0x1807047A0
	private void OnLapFinished(EventOnLapFinished callback) { }

	// RVA: 0x704C10 Offset: 0x703210 VA: 0x180704C10
	private void OnRaceEnd(EventNotifyRaceEnd callback) { }

	// RVA: 0x705600 Offset: 0x703C00 VA: 0x180705600
	private CharacterSpawnData SetCPUData(HashString characterID) { }

	// RVA: 0x705680 Offset: 0x703C80 VA: 0x180705680
	public void .ctor() { }
}
