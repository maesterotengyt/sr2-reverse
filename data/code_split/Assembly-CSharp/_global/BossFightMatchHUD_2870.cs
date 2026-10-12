// Namespace: 
public class BossFightMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2870
{
	// Fields
	public GameObject StandardCharactersUI; // 0xF0
	public List<CharacterHUD> StandardCharacterHUDs; // 0xF8
	public BlastzoneHUD BlastzoneHUD; // 0x100
	public CampaignDialogueMediaHUD CampaignDialogueHUD; // 0x108
	public PlayerHealthBar PlayerHealthBar; // 0x110
	public BossHealthBar BossHealthBar; // 0x118
	private IntroBanners introBanners; // 0x120

	// Methods

	// RVA: 0x7436E0 Offset: 0x741CE0 VA: 0x1807436E0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x7441D0 Offset: 0x7427D0 VA: 0x1807441D0
	private void OnPlayCampaignDialogue(EventPlayCampaignDialogue callback) { }

	// RVA: 0x744640 Offset: 0x742C40 VA: 0x180744640 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x744840 Offset: 0x742E40 VA: 0x180744840 Slot: 5
	public override void Reload() { }

	// RVA: 0x743C10 Offset: 0x742210 VA: 0x180743C10
	private void OnBossFightCompleted(EventBossFightCompleted callback) { }

	// RVA: 0x743C20 Offset: 0x742220 VA: 0x180743C20 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x744260 Offset: 0x742860 VA: 0x180744260 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x743FA0 Offset: 0x7425A0 VA: 0x180743FA0 Slot: 11
	public override void OnExit() { }

	// RVA: 0x7445A0 Offset: 0x742BA0 VA: 0x1807445A0 Slot: 17
	public override void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x744A10 Offset: 0x743010 VA: 0x180744A10 Slot: 18
	public override void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x744980 Offset: 0x742F80 VA: 0x180744980 Slot: 19
	public override void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x7433E0 Offset: 0x7419E0 VA: 0x1807433E0
	public void DisableCharactersHUD() { }

	// RVA: 0x744650 Offset: 0x742C50 VA: 0x180744650 Slot: 14
	protected override void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x743580 Offset: 0x741B80 VA: 0x180743580
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x744510 Offset: 0x742B10 VA: 0x180744510 Slot: 23
	public override void OnResultsScreen() { }

	// RVA: 0x744AC0 Offset: 0x7430C0 VA: 0x180744AC0
	public void .ctor() { }
}
