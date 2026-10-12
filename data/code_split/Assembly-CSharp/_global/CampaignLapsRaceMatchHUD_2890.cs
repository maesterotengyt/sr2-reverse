// Namespace: 
public class CampaignLapsRaceMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2890
{
	// Fields
	public GameObject StandardCharactersUI; // 0xF0
	public GameObject ExtendedCharactersUI; // 0xF8
	public CharacterHUD ExtendedLocalPlayerHUD; // 0x100
	public List<CharacterHUD> StandardCharacterHUDs; // 0x108
	public List<CharacterHUD> ExtendedCharacterHUDs; // 0x110
	public LapsAndPlacementManager LapsAndPlacementManager; // 0x118
	public CampaignDialogueMediaHUD CampaignDialogueHUD; // 0x120
	private IntroBanners introBanners; // 0x128

	// Methods

	// RVA: 0x74BF00 Offset: 0x74A500 VA: 0x18074BF00 Slot: 4
	public override void Initialize() { }

	// RVA: 0x74C300 Offset: 0x74A900 VA: 0x18074C300 Slot: 15
	protected override void MatchStart(EventShowIntroAnimation callback) { }

	// RVA: 0x74CA40 Offset: 0x74B040 VA: 0x18074CA40 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x74CC60 Offset: 0x74B260 VA: 0x18074CC60 Slot: 5
	public override void Reload() { }

	// RVA: 0x74C360 Offset: 0x74A960 VA: 0x18074C360 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x74C9E0 Offset: 0x74AFE0 VA: 0x18074C9E0 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x74C830 Offset: 0x74AE30 VA: 0x18074C830 Slot: 11
	public override void OnExit() { }

	// RVA: 0x74C960 Offset: 0x74AF60 VA: 0x18074C960
	private void OnPlayCampaignDialogue(EventPlayCampaignDialogue callback) { }

	// RVA: 0x7445A0 Offset: 0x742BA0 VA: 0x1807445A0 Slot: 17
	public override void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x74CE40 Offset: 0x74B440 VA: 0x18074CE40 Slot: 18
	public override void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x74CDD0 Offset: 0x74B3D0 VA: 0x18074CDD0 Slot: 19
	public override void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x74C9B0 Offset: 0x74AFB0 VA: 0x18074C9B0 Slot: 20
	protected override void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x74BB60 Offset: 0x74A160 VA: 0x18074BB60
	public void DisableCharactersHUD() { }

	// RVA: 0x74CA70 Offset: 0x74B070 VA: 0x18074CA70 Slot: 14
	protected override void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x74BD50 Offset: 0x74A350 VA: 0x18074BD50
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x744AC0 Offset: 0x7430C0 VA: 0x180744AC0
	public void .ctor() { }
}
