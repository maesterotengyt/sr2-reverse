// Namespace: 
public class LapsRaceMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2950
{
	// Fields
	public GameObject StandardCharactersUI; // 0xF0
	public GameObject ExtendedCharactersUI; // 0xF8
	public CharacterHUD ExtendedLocalPlayerHUD; // 0x100
	public List<CharacterHUD> StandardCharacterHUDs; // 0x108
	public List<CharacterHUD> ExtendedCharacterHUDs; // 0x110
	public GameObject SpectatorHUD; // 0x118
	public LapsAndPlacementManager LapsAndPlacementManager; // 0x120
	private IntroBanners introBanners; // 0x128

	// Methods

	// RVA: 0x776440 Offset: 0x774A40 VA: 0x180776440 Slot: 4
	public override void Initialize() { }

	// RVA: 0x7768E0 Offset: 0x774EE0 VA: 0x1807768E0 Slot: 15
	protected override void MatchStart(EventShowIntroAnimation callback) { }

	// RVA: 0x777600 Offset: 0x775C00 VA: 0x180777600 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x777810 Offset: 0x775E10 VA: 0x180777810 Slot: 5
	public override void Reload() { }

	// RVA: 0x776940 Offset: 0x774F40 VA: 0x180776940 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x777490 Offset: 0x775A90 VA: 0x180777490 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x7772B0 Offset: 0x7758B0 VA: 0x1807772B0 Slot: 11
	public override void OnExit() { }

	// RVA: 0x777540 Offset: 0x775B40 VA: 0x180777540 Slot: 17
	public override void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x7779F0 Offset: 0x775FF0 VA: 0x1807779F0 Slot: 18
	public override void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x777980 Offset: 0x775F80 VA: 0x180777980 Slot: 19
	public override void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x74C9B0 Offset: 0x74AFB0 VA: 0x18074C9B0 Slot: 20
	protected override void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x776130 Offset: 0x774730 VA: 0x180776130
	public void DisableCharactersHUD() { }

	// RVA: 0x777630 Offset: 0x775C30 VA: 0x180777630 Slot: 14
	protected override void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x776290 Offset: 0x774890 VA: 0x180776290
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x744AC0 Offset: 0x7430C0 VA: 0x180744AC0
	public void .ctor() { }
}
