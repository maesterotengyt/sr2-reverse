// Namespace: 
public class HazardsRaceMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2940
{
	// Fields
	public GameObject StandardCharactersUI; // 0xF0
	public GameObject ExtendedCharactersUI; // 0xF8
	public CharacterHUD ExtendedLocalPlayerHUD; // 0x100
	public List<CharacterHUD> StandardCharacterHUDs; // 0x108
	public List<CharacterHUD> ExtendedCharacterHUDs; // 0x110
	public BlastzoneHUD BlastzoneHUD; // 0x118
	public MatchCountdownHud MatchCountdownHud; // 0x120
	public MatchCountdownHud RocketCountdownHUD; // 0x128
	public GameObject SpectatorHUD; // 0x130
	public GameObject LeftPromptsContainer; // 0x138
	public List<HazardsRaceMatchHUD.HazardIndicatorData> LeftHazardsIndicators; // 0x140
	public List<HazardsRaceMatchHUD.HazardIndicatorData> UpHazardsIndicators; // 0x148
	public List<HazardsRaceMatchHUD.HazardIndicatorData> RightHazardsIndicators; // 0x150
	private IntroBanners introBanners; // 0x158
	private GameObject activeHazardIndicator; // 0x160

	// Methods

	// RVA: 0x765C70 Offset: 0x764270 VA: 0x180765C70 Slot: 4
	public override void Initialize() { }

	// RVA: 0x744640 Offset: 0x742C40 VA: 0x180744640 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x767160 Offset: 0x765760 VA: 0x180767160 Slot: 5
	public override void Reload() { }

	// RVA: 0x766D20 Offset: 0x765320 VA: 0x180766D20
	private void OnHazardsIncoming(EventHazardsIncoming callback) { }

	// RVA: 0x766DB0 Offset: 0x7653B0 VA: 0x180766DB0
	private void OnHideHazardsIndicators(EventHideHazardsIndicators callback) { }

	// RVA: 0x765BF0 Offset: 0x7641F0 VA: 0x180765BF0
	private void HideCurrentHazardIndicator() { }

	// RVA: 0x765780 Offset: 0x763D80 VA: 0x180765780
	public void ActivateHazardsIndicator(List<HazardsRaceMatchHUD.HazardIndicatorData> hazardsIndicatorsList, HashString hazard) { }

	// RVA: 0x766270 Offset: 0x764870 VA: 0x180766270 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x766E50 Offset: 0x765450 VA: 0x180766E50 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x766C20 Offset: 0x765220 VA: 0x180766C20 Slot: 11
	public override void OnExit() { }

	// RVA: 0x766EC0 Offset: 0x7654C0 VA: 0x180766EC0 Slot: 17
	public override void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x7673D0 Offset: 0x7659D0 VA: 0x1807673D0 Slot: 18
	public override void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x7672E0 Offset: 0x7658E0 VA: 0x1807672E0 Slot: 19
	public override void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x766DC0 Offset: 0x7653C0 VA: 0x180766DC0 Slot: 20
	protected override void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x765910 Offset: 0x763F10 VA: 0x180765910
	public void DisableCharactersHUD() { }

	// RVA: 0x766F70 Offset: 0x765570 VA: 0x180766F70 Slot: 14
	protected override void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x765A40 Offset: 0x764040 VA: 0x180765A40
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x744AC0 Offset: 0x7430C0 VA: 0x180744AC0
	public void .ctor() { }
}
