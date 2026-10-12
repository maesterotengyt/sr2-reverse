// Namespace: 
public class MechanicTutorialMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2953
{
	// Fields
	public float HoldTimeToTriggerAction; // 0xF0
	public float WaitTimeForNextSection; // 0xF4
	public float WaitTimeToFinishTutorial; // 0xF8
	public GameObject Footer; // 0x100
	public CharacterHUD CharacterHUD; // 0x108
	public MechanicTutorialTimer Timer; // 0x110
	public MechanicTutorialGoalsHUD GoalsHUD; // 0x118
	public TrainingMatchHUDPrompt RestartPrompt; // 0x120
	public TrainingMatchHUDPrompt SkipPrompt; // 0x128
	private bool justCompletedFinalSection; // 0x130
	private bool waitingToLoadNextSection; // 0x131
	private float remainingTimeToLoadNextSection; // 0x134
	private bool isPauseActive; // 0x138
	private bool triggeredAPrompt; // 0x139
	private float skipHoldTime; // 0x13C
	private float restartHoldTime; // 0x140

	// Methods

	// RVA: 0x7797A0 Offset: 0x777DA0 VA: 0x1807797A0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x77A250 Offset: 0x778850 VA: 0x18077A250 Slot: 5
	public override void Reload() { }

	// RVA: 0x779C10 Offset: 0x778210 VA: 0x180779C10 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x777490 Offset: 0x775A90 VA: 0x180777490 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x77A080 Offset: 0x778680 VA: 0x18077A080 Slot: 11
	public override void OnExit() { }

	// RVA: 0x77AC50 Offset: 0x779250 VA: 0x18077AC50
	private void Update() { }

	// RVA: 0x77AA20 Offset: 0x779020 VA: 0x18077AA20
	private void UpdateSkipOption() { }

	// RVA: 0x77A7F0 Offset: 0x778DF0 VA: 0x18077A7F0
	private void UpdateRestartOption() { }

	// RVA: 0x77A790 Offset: 0x778D90 VA: 0x18077A790
	private void UpdatePromptFillProgress(TrainingMatchHUDPrompt prompt, float holdTime) { }

	// RVA: 0x77A2C0 Offset: 0x7788C0 VA: 0x18077A2C0 Slot: 16
	public override void ShowDialogue(EventShowDialogue callback) { }

	// RVA: 0x779F20 Offset: 0x778520 VA: 0x180779F20
	public void OnDialogueFinished() { }

	// RVA: 0x77A230 Offset: 0x778830 VA: 0x18077A230
	private void OnPauseStateChange(bool paused) { }

	// RVA: 0x77A240 Offset: 0x778840 VA: 0x18077A240
	private void OnTutorialSectionFinished(EventTutorialSectionFinished callback) { }

	// RVA: 0x77A1D0 Offset: 0x7787D0 VA: 0x18077A1D0
	private void OnMechanicTutorialCompleted(EventMechanicTutorialCompleted callback) { }

	// RVA: 0x77A3A0 Offset: 0x7789A0 VA: 0x18077A3A0
	private void ShowRaceEndOverlay(bool isFinalSection) { }

	// RVA: 0x77A1E0 Offset: 0x7787E0 VA: 0x18077A1E0
	private void OnMechanicTutorialGoalsUpdated(EventMechanicTutorialGoalsUpdated callback) { }

	// RVA: 0x779CC0 Offset: 0x7782C0 VA: 0x180779CC0 Slot: 22
	protected override void OnDestroy() { }

	// RVA: 0x77B070 Offset: 0x779670 VA: 0x18077B070
	public void .ctor() { }
}
