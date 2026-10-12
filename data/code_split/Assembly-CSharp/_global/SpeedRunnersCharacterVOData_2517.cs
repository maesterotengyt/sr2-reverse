// Namespace: 
[CreateAssetMenu(fileName = "SpeedRunnersCharacterVOData", menuName = "ScriptableObjects/SpeedRunnersCharacterVOData", order = 1)]
public class SpeedRunnersCharacterVOData : ScriptableObject // TypeDefIndex: 2517
{
	// Fields
	private const int MAX_PRIORITY = 1000;
	public OrderedAudioEventInfo[] RoundVictoryEvents; // 0x18
	public OrderedAudioEventInfo[] MatchVictoryEvents; // 0x20
	public StellarAudioEventInfo TumbleEvent; // 0x28
	public StellarAudioEventInfo TripEvent; // 0x30
	public StellarAudioEventInfo EnterSuperSpeedEvent; // 0x38
	public StellarAudioEventInfo JumpEvent; // 0x40
	public StellarAudioEventInfo GetItemEvent; // 0x48
	public StellarAudioEventInfo FreezeEvent; // 0x50
	public StellarAudioEventInfo BurnEvent; // 0x58
	public StellarAudioEventInfo TauntEvent; // 0x60
	public StellarAudioEventInfo IdleAltEvent; // 0x68
	private OrderedAudioEventInfo lastChosenEvent; // 0x70
	private static Random random; // 0x0
	private string[] largeCharacterLanguageCodes; // 0x78

	// Properties
	public StellarSettingsSystem stellarAudioSystem { get; }

	// Methods

	// RVA: 0x63A600 Offset: 0x638C00 VA: 0x18063A600
	public StellarSettingsSystem get_stellarAudioSystem() { }

	// RVA: 0x63A370 Offset: 0x638970 VA: 0x18063A370
	private OrderedAudioEventInfo getOldestEventInfo(OrderedAudioEventInfo[] array) { }

	// RVA: 0x63A650 Offset: 0x638C50 VA: 0x18063A650
	private string splitString(string text) { }

	// RVA: 0x639D80 Offset: 0x638380 VA: 0x180639D80
	public void StartGameplayEvent(EntityRef entity, GameplayCharacterVOEvent voEvent) { }

	// RVA: 0x639B70 Offset: 0x638170 VA: 0x180639B70
	private void StartGameplayEventFromID(EntityRef entity, StellarAudioEventInfo eventInfo) { }

	// RVA: 0x63A280 Offset: 0x638880 VA: 0x18063A280
	public void .ctor() { }

	// RVA: 0x63A200 Offset: 0x638800 VA: 0x18063A200
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x63A1F0 Offset: 0x6387F0 VA: 0x18063A1F0
	private bool <getOldestEventInfo>b__17_1(OrderedAudioEventInfo o) { }
}
