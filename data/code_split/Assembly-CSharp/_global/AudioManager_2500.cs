// Namespace: 
public class AudioManager : SRMonoBehaviour // TypeDefIndex: 2500
{
	// Fields
	public static AudioManager.OnAudioManagerInitialized AudioManagerInitialized; // 0x0
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <TimeSinceLastAnnouncerGameplayEvent>k__BackingField; // 0x24
	public AudioData AudioData; // 0x28
	public AudioMatchEvents AudioMatchEvents; // 0x30
	public AnnouncerVOData AnnouncerVOData; // 0x38
	public float MidMatchCommentsWaitTime; // 0x40
	[CompilerGenerated]
	private StageMusicData <CurrentStageMusicData>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <StagePart2MusicActive>k__BackingField; // 0x68
	public readonly string CharactersSFXLabel; // 0x70
	private bool isAnnouncerMuted; // 0x78

	// Properties
	public bool Initialized { get; set; }
	public float TimeSinceLastAnnouncerGameplayEvent { get; set; }
	public bool IsAnnouncerMuted { get; }
	public StageMusicData CurrentStageMusicData { get; set; }
	public bool StagePart2MusicActive { get; set; }
	public StellarAudioSystem StellarSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x627880 Offset: 0x625E80 VA: 0x180627880
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x4FA000 Offset: 0x4F8600 VA: 0x1804FA000
	private void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6278E0 Offset: 0x625EE0 VA: 0x1806278E0
	public float get_TimeSinceLastAnnouncerGameplayEvent() { }

	[CompilerGenerated]
	// RVA: 0x627910 Offset: 0x625F10 VA: 0x180627910
	public void set_TimeSinceLastAnnouncerGameplayEvent(float value) { }

	// RVA: 0x5BAA00 Offset: 0x5B9000 VA: 0x1805BAA00
	public bool get_IsAnnouncerMuted() { }

	[CompilerGenerated]
	// RVA: 0x5A5160 Offset: 0x5A3760 VA: 0x1805A5160
	public StageMusicData get_CurrentStageMusicData() { }

	[CompilerGenerated]
	// RVA: 0x6278F0 Offset: 0x625EF0 VA: 0x1806278F0
	public void set_CurrentStageMusicData(StageMusicData value) { }

	[CompilerGenerated]
	// RVA: 0x5DC800 Offset: 0x5DAE00 VA: 0x1805DC800
	public bool get_StagePart2MusicActive() { }

	[CompilerGenerated]
	// RVA: 0x5DC920 Offset: 0x5DAF20 VA: 0x1805DC920
	public void set_StagePart2MusicActive(bool value) { }

	// RVA: 0x627890 Offset: 0x625E90 VA: 0x180627890
	public StellarAudioSystem get_StellarSystem() { }

	// RVA: 0x6276B0 Offset: 0x625CB0 VA: 0x1806276B0
	private void Update() { }

	// RVA: 0x6269F0 Offset: 0x624FF0 VA: 0x1806269F0
	public void Initialize() { }

	// RVA: 0x6267E0 Offset: 0x624DE0 VA: 0x1806267E0
	private void DefaultBanksLoaded() { }

	// RVA: 0x626940 Offset: 0x624F40 VA: 0x180626940
	public int GetMusicIndexFromID(string musicID) { }

	// RVA: 0x627510 Offset: 0x625B10 VA: 0x180627510
	public void SetStageMusic(int musicIndex) { }

	// RVA: 0x626FB0 Offset: 0x6255B0 VA: 0x180626FB0
	private void OnStageLoaded(EventOnLoadingFinished callback) { }

	// RVA: 0x626600 Offset: 0x624C00 VA: 0x180626600
	public void CheckForValidMusicData() { }

	// RVA: 0x627400 Offset: 0x625A00 VA: 0x180627400
	private void PlayStageMusic(EventPlayStageMusic callback) { }

	// RVA: 0x6272E0 Offset: 0x6258E0 VA: 0x1806272E0
	private void PlayStageMusicTense(EventPlayStageMusicPart2 callback) { }

	// RVA: 0x6272E0 Offset: 0x6258E0 VA: 0x1806272E0
	public void PlayStageMusicTense() { }

	// RVA: 0x626F70 Offset: 0x625570 VA: 0x180626F70
	private void OnPlayAnnouncerVO(EventNotifyVOAnnouncerEvent callback) { }

	// RVA: 0x6270D0 Offset: 0x6256D0 VA: 0x1806270D0
	public void PlayAnnouncerGameplayVOEvent(GameplayAnnouncerVOEvent voEvent) { }

	// RVA: 0x627130 Offset: 0x625730 VA: 0x180627130
	public void PlayAnnouncerUIVOEvent(UIAnnouncerVOEvent voEvent) { }

	// RVA: 0x627110 Offset: 0x625710 VA: 0x180627110
	public void PlayAnnouncerTournamentVOEvent(TournamentAnnouncerVOEvent voEvent) { }

	// RVA: 0x627150 Offset: 0x625750 VA: 0x180627150
	public void PlayCharacterCatchPhrase(HashString characterID, int sourceID) { }

	// RVA: 0x626F60 Offset: 0x625560 VA: 0x180626F60
	public void MuteAnnouncer() { }

	// RVA: 0x627600 Offset: 0x625C00 VA: 0x180627600
	public void UnmuteAnnouncer() { }

	// RVA: 0x627820 Offset: 0x625E20 VA: 0x180627820
	public void .ctor() { }
}
