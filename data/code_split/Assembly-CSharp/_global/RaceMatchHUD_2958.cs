// Namespace: 
public class RaceMatchHUD : SpeedRunnersMatchHUD // TypeDefIndex: 2958
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
	protected IntroBanners introBanners; // 0x140

	// Methods

	// RVA: 0x77B540 Offset: 0x779B40 VA: 0x18077B540 Slot: 4
	public override void Initialize() { }

	// RVA: 0x744640 Offset: 0x742C40 VA: 0x180744640 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x77CB80 Offset: 0x77B180 VA: 0x18077CB80
	public void OnPlayerGoingBackwards(EventPlayerWrongDirection callback) { }

	// RVA: 0x77D2C0 Offset: 0x77B8C0 VA: 0x18077D2C0 Slot: 5
	public override void Reload() { }

	// RVA: 0x77BC60 Offset: 0x77A260 VA: 0x18077BC60 Slot: 12
	protected override void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x77CEB0 Offset: 0x77B4B0 VA: 0x18077CEB0 Slot: 10
	public override void OnRestart() { }

	// RVA: 0x77C780 Offset: 0x77AD80 VA: 0x18077C780 Slot: 11
	public override void OnExit() { }

	// RVA: 0x777540 Offset: 0x775B40 VA: 0x180777540 Slot: 17
	public override void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x77D530 Offset: 0x77BB30 VA: 0x18077D530 Slot: 18
	public override void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x77D440 Offset: 0x77BA40 VA: 0x18077D440 Slot: 19
	public override void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x77CE50 Offset: 0x77B450 VA: 0x18077CE50 Slot: 20
	protected override void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x77CCC0 Offset: 0x77B2C0 VA: 0x18077CCC0 Slot: 21
	protected override void OnRaceRoundStart(EventRoundStart callback) { }

	// RVA: 0x77B260 Offset: 0x779860 VA: 0x18077B260
	public void DisableCharactersHUD() { }

	// RVA: 0x77D0E0 Offset: 0x77B6E0 VA: 0x18077D0E0 Slot: 14
	protected override void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x77B390 Offset: 0x779990 VA: 0x18077B390
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x744AC0 Offset: 0x7430C0 VA: 0x180744AC0
	public void .ctor() { }
}
