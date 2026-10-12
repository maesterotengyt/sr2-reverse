// Namespace: 
public class TrainingMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2968
{
	// Fields
	public float HoldTimeToTriggerAction; // 0xF0
	public CharacterHUD CharacterHUD; // 0xF8
	public GameAdjustmentOptions GameAdjustmentOptions; // 0x100
	public TrainingMatchHUDChronometer Chronometer; // 0x108
	[Header("Equip Item")]
	public Animator EquipItemMenuAnimator; // 0x110
	public UINavigator EquipItemNavigator; // 0x118
	public Transform ItemButtonsContainer; // 0x120
	public TMP_Text CurrentItemName; // 0x128
	[Header("Prompts")]
	public TrainingMatchHUDPrompt StartFrameByFramePrompt; // 0x130
	public TrainingMatchHUDPrompt ExitFrameByFramePrompt; // 0x138
	public TrainingMatchHUDPrompt NextFramePrompt; // 0x140
	public TrainingMatchHUDPrompt FocusOnPlayerPrompt; // 0x148
	public TrainingMatchHUDPrompt FocusOnGhostPrompt; // 0x150
	public TrainingMatchHUDPrompt OpenItemListPrompt; // 0x158
	public TrainingMatchHUDPrompt RestartPrompt; // 0x160
	private bool triggeredAPrompt; // 0x168
	private bool isEquipItemMenuVisible; // 0x169
	private bool requestedGameAdjustmentsUpdate; // 0x16A
	private bool isPauseActive; // 0x16B
	private float frameByFrameHoldTime; // 0x16C
	private float itemsHoldTime; // 0x170
	private float restartHoldTime; // 0x174

	// Methods

	// RVA: 0x783780 Offset: 0x781D80 VA: 0x180783780 Slot: 4
	public override void Initialize() { }

	// RVA: 0x783470 Offset: 0x781A70 VA: 0x180783470
	public void InitializeItemNavigator() { }

	// RVA: 0x784150 Offset: 0x782750 VA: 0x180784150 Slot: 5
	public override void Reload() { }

	// RVA: 0x7839A0 Offset: 0x781FA0 VA: 0x1807839A0 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x783E40 Offset: 0x782440 VA: 0x180783E40 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x784890 Offset: 0x782E90 VA: 0x180784890
	private void UpdateFrameByFrameOptions() { }

	// RVA: 0x784CC0 Offset: 0x7832C0 VA: 0x180784CC0
	private void UpdateRestartOption() { }

	// RVA: 0x7843B0 Offset: 0x7829B0 VA: 0x1807843B0
	private void UpdateEquipItemOptions() { }

	// RVA: 0x783D50 Offset: 0x782350 VA: 0x180783D50
	private void OnPauseStateChange(bool paused) { }

	// RVA: 0x783D70 Offset: 0x782370 VA: 0x180783D70 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x783B80 Offset: 0x782180 VA: 0x180783B80 Slot: 11
	public override void OnExit() { }

	// RVA: 0x783400 Offset: 0x781A00 VA: 0x180783400
	private EquipableItemOption GetEquipableItemOption(int index) { }

	// RVA: 0x784B10 Offset: 0x783110 VA: 0x180784B10
	private void UpdatePromptsVisibility() { }

	// RVA: 0x77A790 Offset: 0x778D90 VA: 0x18077A790
	private void UpdatePromptFillProgress(TrainingMatchHUDPrompt prompt, float holdTime) { }

	// RVA: 0x7841B0 Offset: 0x7827B0 VA: 0x1807841B0
	private bool TryFindFirstCharacterEntity(out EntityRef targetEntity) { }

	// RVA: 0x784380 Offset: 0x782980 VA: 0x180784380
	public void UpdateCurrentItemName(string itemName) { }

	// RVA: 0x783A50 Offset: 0x782050 VA: 0x180783A50 Slot: 22
	protected override void OnDestroy() { }

	// RVA: 0x784E20 Offset: 0x783420 VA: 0x180784E20
	public void .ctor() { }
}
