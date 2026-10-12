// Namespace: 
public class CollectorsMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2918
{
	// Fields
	public GameObject StandardCharactersUI; // 0xF0
	public GameObject ExtendedCharactersUI; // 0xF8
	public CharacterHUD ExtendedLocalPlayerHUD; // 0x100
	public List<CharacterHUD> StandardCharacterHUDs; // 0x108
	public List<CharacterHUD> ExtendedCharacterHUDs; // 0x110
	public GameObject SpectatorHUD; // 0x118
	public GameObject CollectorElementsContainer; // 0x120
	public CollectorsHUDTimer Timer; // 0x128
	private IntroBanners introBanners; // 0x130

	// Methods

	// RVA: 0x759C40 Offset: 0x758240 VA: 0x180759C40 Slot: 4
	public override void Initialize() { }

	// RVA: 0x75AC60 Offset: 0x759260 VA: 0x18075AC60 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x75AE80 Offset: 0x759480 VA: 0x18075AE80 Slot: 5
	public override void Reload() { }

	// RVA: 0x75A090 Offset: 0x758690 VA: 0x18075A090 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x74C9E0 Offset: 0x74AFE0 VA: 0x18074C9E0 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x75AA40 Offset: 0x759040 VA: 0x18075AA40 Slot: 11
	public override void OnExit() { }

	// RVA: 0x75ABB0 Offset: 0x7591B0 VA: 0x18075ABB0 Slot: 17
	public override void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x75B070 Offset: 0x759670 VA: 0x18075B070 Slot: 18
	public override void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x75B000 Offset: 0x759600 VA: 0x18075B000 Slot: 19
	public override void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x75AB40 Offset: 0x759140 VA: 0x18075AB40 Slot: 20
	protected override void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x759940 Offset: 0x757F40 VA: 0x180759940
	public void DisableCharactersHUD() { }

	// RVA: 0x75AC90 Offset: 0x759290 VA: 0x18075AC90 Slot: 14
	protected override void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x759A90 Offset: 0x758090 VA: 0x180759A90
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x744AC0 Offset: 0x7430C0 VA: 0x180744AC0
	public void .ctor() { }
}
