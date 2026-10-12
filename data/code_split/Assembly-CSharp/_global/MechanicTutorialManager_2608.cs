// Namespace: 
public class MechanicTutorialManager : SpeedRunnersGameModeManager // TypeDefIndex: 2608
{
	// Fields
	[CompilerGenerated]
	private int <CurrentSectionIndex>k__BackingField; // 0x48

	// Properties
	public int CurrentSectionIndex { get; set; }
	private SaveManager saveManager { get; }
	private DataManager dataManager { get; }
	private UIManager uiManager { get; }
	private SceneLoader sceneLoadManager { get; }
	private AchievementsManager achievementsManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C5B60 Offset: 0x5C4160 VA: 0x1805C5B60
	public int get_CurrentSectionIndex() { }

	[CompilerGenerated]
	// RVA: 0x5C5BB0 Offset: 0x5C41B0 VA: 0x1805C5BB0
	public void set_CurrentSectionIndex(int value) { }

	// RVA: 0x6FF3E0 Offset: 0x6FD9E0 VA: 0x1806FF3E0
	private SaveManager get_saveManager() { }

	// RVA: 0x6FF390 Offset: 0x6FD990 VA: 0x1806FF390
	private DataManager get_dataManager() { }

	// RVA: 0x6FF480 Offset: 0x6FDA80 VA: 0x1806FF480
	private UIManager get_uiManager() { }

	// RVA: 0x6FF430 Offset: 0x6FDA30 VA: 0x1806FF430
	private SceneLoader get_sceneLoadManager() { }

	// RVA: 0x6FF340 Offset: 0x6FD940 VA: 0x1806FF340
	private AchievementsManager get_achievementsManager() { }

	// RVA: 0x6FE1C0 Offset: 0x6FC7C0 VA: 0x1806FE1C0 Slot: 4
	public override void Init() { }

	// RVA: 0x6FF2A0 Offset: 0x6FD8A0 VA: 0x1806FF2A0
	private void OnMechanicTutorialStarted(EventMechanicTutorialStarted callback) { }

	// RVA: 0x6FF330 Offset: 0x6FD930 VA: 0x1806FF330
	private void OnRestartTutorialSection(EventRestartTutorialSection callback) { }

	// RVA: 0x6FE310 Offset: 0x6FC910 VA: 0x1806FE310
	public void LoadCurrentSection() { }

	// RVA: 0x6FE600 Offset: 0x6FCC00 VA: 0x1806FE600
	public void LoadNextSection() { }

	// RVA: 0x6FE720 Offset: 0x6FCD20 VA: 0x1806FE720
	public void OnMechanicTutorialCompleted() { }

	// RVA: 0x6EFA30 Offset: 0x6EE030 VA: 0x1806EFA30
	public void .ctor() { }
}
