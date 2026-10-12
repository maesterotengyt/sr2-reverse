// Namespace: 
public class AnnouncerVOData : ScriptableObject // TypeDefIndex: 2768
{
	// Fields
	[Header("UI")]
	public StellarAudioEventInfo CharacterSelectScreenEvent; // 0x18
	public StellarAudioEventInfo LevelSelectScreenEvent; // 0x20
	public StellarAudioEventInfo LevelSelectedEvent; // 0x28
	[Space(10)]
	public StellarAudioEventInfo Countdown3Event; // 0x30
	public StellarAudioEventInfo Countdown2Event; // 0x38
	public StellarAudioEventInfo Countdown1Event; // 0x40
	public StellarAudioEventInfo MatchStartEvent; // 0x48
	[Header("Gameplay")]
	public StellarAudioEventInfo MidMatchEvent; // 0x50
	public StellarAudioEventInfo KOEvent; // 0x58
	public StellarAudioEventInfo FirstKOEvent; // 0x60
	public StellarAudioEventInfo SuddenDeathStartEvent; // 0x68
	public StellarAudioEventInfo FirstPlaceDisplacedEvent; // 0x70
	public StellarAudioEventInfo MatchFinishedEvent; // 0x78
	[Space(10)]
	public StellarAudioEventInfo CharacterFreezeEvent; // 0x80
	public StellarAudioEventInfo CharacterBurnEvent; // 0x88
	public StellarAudioEventInfo CharacterRocketEvent; // 0x90
	public StellarAudioEventInfo CharacterHookedEvent; // 0x98
	public StellarAudioEventInfo CharacterTackledEvent; // 0xA0
	public StellarAudioEventInfo CharacterInSuperSpeedEvent; // 0xA8
	public StellarAudioEventInfo CharacterBackfiredEvent; // 0xB0
	public StellarAudioEventInfo CharacterBigAirEvent; // 0xB8
	public StellarAudioEventInfo CharacterRevengeEvent; // 0xC0
	public StellarAudioEventInfo CharacterStillAliveEvent; // 0xC8
	public StellarAudioEventInfo CharacterDeflectedEvent; // 0xD0
	[Header("Tournament")]
	public StellarAudioEventInfo TournamentStartEvent; // 0xD8
	public StellarAudioEventInfo TournamentRoundEvent; // 0xE0
	public StellarAudioEventInfo TournamentFinalEvent; // 0xE8
	public StellarAudioEventInfo TournamentWinnerStartEvent; // 0xF0
	public CharacterNameEvent[] TournamentWinnerNameEvent; // 0xF8
	public int WinnerCharacterName; // 0x100

	// Properties
	private StellarAudioSystem stellarAudioSystem { get; }

	// Methods

	// RVA: 0x726970 Offset: 0x724F70 VA: 0x180726970
	private StellarAudioSystem get_stellarAudioSystem() { }

	// RVA: 0x726830 Offset: 0x724E30 VA: 0x180726830
	public void StartUIEvent(UIAnnouncerVOEvent voEvent) { }

	// RVA: 0x726500 Offset: 0x724B00 VA: 0x180726500
	public void StartTournamentEvent(TournamentAnnouncerVOEvent voEvent) { }

	// RVA: 0x726250 Offset: 0x724850 VA: 0x180726250
	public void StartGameplayEvent(GameplayAnnouncerVOEvent voEvent) { }

	// RVA: 0x726750 Offset: 0x724D50 VA: 0x180726750
	private void StartUIEventFromID(StellarAudioEventInfo eventInfo) { }

	// RVA: 0x726170 Offset: 0x724770 VA: 0x180726170
	private void StartGameplayEventFromID(StellarAudioEventInfo eventInfo) { }

	// RVA: 0x726420 Offset: 0x724A20 VA: 0x180726420
	private void StartTournamentEventFromID(StellarAudioEventInfo eventInfo) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
