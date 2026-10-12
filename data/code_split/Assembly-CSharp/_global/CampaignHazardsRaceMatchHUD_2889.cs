// Namespace: 
public class CampaignHazardsRaceMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2889
{
	// Fields
	public GameObject StandardCharactersUI; // 0xF0
	public GameObject ExtendedCharactersUI; // 0xF8
	public CharacterHUD ExtendedLocalPlayerHUD; // 0x100
	public List<CharacterHUD> StandardCharacterHUDs; // 0x108
	public List<CharacterHUD> ExtendedCharacterHUDs; // 0x110
	public BlastzoneHUD BlastzoneHUD; // 0x118
	public MatchCountdownHud MatchCountdownHud; // 0x120
	public List<CampaignHazardsRaceMatchHUD.HazardIndicatorData> LeftHazardsIndicators; // 0x128
	public List<CampaignHazardsRaceMatchHUD.HazardIndicatorData> UpHazardsIndicators; // 0x130
	public List<CampaignHazardsRaceMatchHUD.HazardIndicatorData> RightHazardsIndicators; // 0x138
	public CampaignDialogueMediaHUD CampaignDialogueHUD; // 0x140
	private IntroBanners introBanners; // 0x148
	private GameObject activeHazardIndicator; // 0x150

	// Methods

	// RVA: 0x74A3B0 Offset: 0x7489B0 VA: 0x18074A3B0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x744640 Offset: 0x742C40 VA: 0x180744640 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x74B6D0 Offset: 0x749CD0 VA: 0x18074B6D0 Slot: 5
	public override void Reload() { }

	// RVA: 0x74AE90 Offset: 0x749490 VA: 0x18074AE90
	private void OnHazardsIncoming(EventHazardsIncoming callback) { }

	// RVA: 0x74B060 Offset: 0x749660 VA: 0x18074B060
	private void OnHideHazardsIndicators(EventHideHazardsIndicators callback) { }

	// RVA: 0x74B070 Offset: 0x749670 VA: 0x18074B070
	private void OnPlayCampaignDialogue(EventPlayCampaignDialogue callback) { }

	// RVA: 0x74A330 Offset: 0x748930 VA: 0x18074A330
	private void HideCurrentHazardIndicator() { }

	// RVA: 0x749E40 Offset: 0x748440 VA: 0x180749E40
	public void ActivateHazardsIndicator(List<CampaignHazardsRaceMatchHUD.HazardIndicatorData> hazardsIndicatorsList, HashString hazard) { }

	// RVA: 0x74A8B0 Offset: 0x748EB0 VA: 0x18074A8B0 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x74B150 Offset: 0x749750 VA: 0x18074B150 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x74AD60 Offset: 0x749360 VA: 0x18074AD60 Slot: 11
	public override void OnExit() { }

	// RVA: 0x74B440 Offset: 0x749A40 VA: 0x18074B440 Slot: 17
	public override void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x74BAB0 Offset: 0x74A0B0 VA: 0x18074BAB0 Slot: 18
	public override void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x74BA10 Offset: 0x74A010 VA: 0x18074BA10 Slot: 19
	public override void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x74B0C0 Offset: 0x7496C0 VA: 0x18074B0C0 Slot: 20
	protected override void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x749FD0 Offset: 0x7485D0 VA: 0x180749FD0
	public void DisableCharactersHUD() { }

	// RVA: 0x74B4E0 Offset: 0x749AE0 VA: 0x18074B4E0 Slot: 14
	protected override void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x74A180 Offset: 0x748780 VA: 0x18074A180
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x744AC0 Offset: 0x7430C0 VA: 0x180744AC0
	public void .ctor() { }
}
