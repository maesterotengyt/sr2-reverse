// Namespace: 
public class EscapeRoomMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2934
{
	// Fields
	public float HoldTimeToTriggerAction; // 0xF0
	public float WaitTimeToFinishEscapeRoom; // 0xF4
	public GameObject Footer; // 0xF8
	public CharacterHUD CharacterHUD; // 0x100
	public EscapeRoomTimer Timer; // 0x108
	public CampaignDialogueMediaHUD CampaignDialogueHUD; // 0x110
	private bool waitingToCompleteEscapeRoom; // 0x118
	private float remainingTimeToCompleteEscapeRoom; // 0x11C
	private IntroBanners introBanners; // 0x120
	private bool isPauseActive; // 0x128

	// Methods

	// RVA: 0x761180 Offset: 0x75F780 VA: 0x180761180 Slot: 4
	public override void Initialize() { }

	// RVA: 0x761D30 Offset: 0x760330 VA: 0x180761D30 Slot: 5
	public override void Reload() { }

	// RVA: 0x7615D0 Offset: 0x75FBD0 VA: 0x1807615D0 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x74C9E0 Offset: 0x74AFE0 VA: 0x18074C9E0 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x761BA0 Offset: 0x7601A0 VA: 0x180761BA0 Slot: 11
	public override void OnExit() { }

	// RVA: 0x7620B0 Offset: 0x7606B0 VA: 0x1807620B0
	private void Update() { }

	// RVA: 0x762050 Offset: 0x760650 VA: 0x180762050
	private void UpdatePromptFillProgress(TrainingMatchHUDPrompt prompt, float holdTime) { }

	// RVA: 0x761CE0 Offset: 0x7602E0 VA: 0x180761CE0
	private void OnPlayCampaignDialogue(EventPlayCampaignDialogue callback) { }

	// RVA: 0x7618D0 Offset: 0x75FED0 VA: 0x1807618D0
	public void OnDialogueFinished() { }

	// RVA: 0x761CD0 Offset: 0x7602D0 VA: 0x180761CD0
	private void OnPauseStateChange(bool paused) { }

	// RVA: 0x761970 Offset: 0x75FF70 VA: 0x180761970
	private void OnEscapeRoomCompleted(EventEscapeRoomCompleted callback) { }

	// RVA: 0x761E40 Offset: 0x760440 VA: 0x180761E40
	private void ShowRaceEndOverlay() { }

	// RVA: 0x7617A0 Offset: 0x75FDA0 VA: 0x1807617A0 Slot: 22
	protected override void OnDestroy() { }

	// RVA: 0x7621D0 Offset: 0x7607D0 VA: 0x1807621D0
	public void .ctor() { }
}
