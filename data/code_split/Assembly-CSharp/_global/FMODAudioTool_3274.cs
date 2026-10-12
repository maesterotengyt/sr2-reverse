// Namespace: 
public class FMODAudioTool : AudioTool // TypeDefIndex: 3274
{
	// Fields
	private Dictionary<int, List<FMODAudioInstance>> audioInstancesDict; // 0x20
	private List<EventInstance> musicEventInstances; // 0x28
	private List<FMODSFXEvent> sfxEvents; // 0x30
	private List<string> banksLoading; // 0x38

	// Methods

	// RVA: 0x59B9C0 Offset: 0x599FC0 VA: 0x18059B9C0
	private void Update() { }

	// RVA: 0x59B7C0 Offset: 0x599DC0 VA: 0x18059B7C0
	private void UpdateAudioInstances(Frame frame, List<FMODAudioInstance> audioInstances) { }

	// RVA: 0x599AC0 Offset: 0x5980C0 VA: 0x180599AC0
	private void PlaySFXEvent(FMODSFXEvent sfxEvent) { }

	// RVA: 0x598AD0 Offset: 0x5970D0 VA: 0x180598AD0
	public FMODSFXEvent CreateSFXEvent(string eventID, Nullable<Vector3> location, int entityIndex = -1) { }

	// RVA: 0x599140 Offset: 0x597740 VA: 0x180599140
	protected bool IsAudioInstanceFromContext(AudioContextStopMode stopMode, FMODAudioInstance audioInstance) { }

	// RVA: 0x598E60 Offset: 0x597460 VA: 0x180598E60
	private int GetFreeSFXEventIndex() { }

	// RVA: 0x598D20 Offset: 0x597320 VA: 0x180598D20
	private int GetFreeMusicInstanceIndex() { }

	// RVA: 0x5989C0 Offset: 0x596FC0 VA: 0x1805989C0
	private EventInstance CreateEventIntance(string eventID, Nullable<Vector3> location) { }

	[IteratorStateMachine(typeof(FMODAudioTool.<PlaySFXDelayed>d__12))]
	// RVA: 0x5999E0 Offset: 0x597FE0 VA: 0x1805999E0
	private IEnumerator PlaySFXDelayed(HashString categoryID, string eventID, EntityRef entity, int sourceID, Nullable<Vector3> position, float delay = 0, bool followEntity = False, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x59B4A0 Offset: 0x599AA0 VA: 0x18059B4A0
	public bool TryGetCategoryAudioInstances(HashString categoryID, out List<FMODAudioInstance> audioInstances, out bool allowmultipleSoundPerSource) { }

	// RVA: 0x599020 Offset: 0x597620 VA: 0x180599020 Slot: 4
	public override void Initialize() { }

	// RVA: 0x599C50 Offset: 0x598250 VA: 0x180599C50 Slot: 5
	protected override void PlaySFX(HashString categoryID, string eventID, EntityRef entity, int sourceID, Nullable<Vector3> position, float delay = 0, bool followEntity = False, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x59A270 Offset: 0x598870 VA: 0x18059A270 Slot: 6
	public override void PlaySFX(HashString categoryID, string eventID, EntityRef entity, Nullable<Vector3> position, float delay = 0, bool followEntity = False, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x599BA0 Offset: 0x5981A0 VA: 0x180599BA0 Slot: 7
	public override void PlaySFX(HashString categoryID, string eventID, int sourceID, Nullable<Vector3> position, float delay = 0, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x59A150 Offset: 0x598750 VA: 0x18059A150 Slot: 8
	public override void PlaySFX(HashString categoryID, string eventID, int sourceID, float delay = 0, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x59B370 Offset: 0x599970 VA: 0x18059B370 Slot: 9
	public override void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, EntityRef entity) { }

	// RVA: 0x59B220 Offset: 0x599820 VA: 0x18059B220 Slot: 10
	public override void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, int sourceID) { }

	// RVA: 0x59ACE0 Offset: 0x5992E0 VA: 0x18059ACE0 Slot: 11
	public override void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, EntityRef entity) { }

	// RVA: 0x59ADF0 Offset: 0x5993F0 VA: 0x18059ADF0 Slot: 12
	public override void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, int sourceID) { }

	// RVA: 0x59AFD0 Offset: 0x5995D0 VA: 0x18059AFD0 Slot: 13
	public override void StopAllSFX(HashString categoryID, AudioContextStopMode stopMode) { }

	// RVA: 0x59AF00 Offset: 0x599500 VA: 0x18059AF00 Slot: 14
	public override void StopAllSFX(AudioContextStopMode stopMode) { }

	// RVA: 0x5996F0 Offset: 0x597CF0 VA: 0x1805996F0 Slot: 15
	public override void PlayMusic(string eventID, bool stopAllMusic) { }

	// RVA: 0x59B0E0 Offset: 0x5996E0 VA: 0x18059B0E0 Slot: 16
	public override void StopMusic(string eventID) { }

	// RVA: 0x59AB80 Offset: 0x599180 VA: 0x18059AB80 Slot: 17
	public override void StopAllMusic() { }

	// RVA: 0x598BE0 Offset: 0x5971E0 VA: 0x180598BE0 Slot: 18
	public override bool EventExist(string eventID) { }

	// RVA: 0x59A300 Offset: 0x598900 VA: 0x18059A300 Slot: 19
	public override void SetBusVolume(string busName, float volume) { }

	// RVA: 0x598C80 Offset: 0x597280 VA: 0x180598C80 Slot: 20
	public override float GetBusVolume(string busName) { }

	// RVA: 0x599260 Offset: 0x597860 VA: 0x180599260 Slot: 23
	public override void LoadBank(AssetReference bank, string identifier) { }

	[IteratorStateMachine(typeof(FMODAudioTool.<LoadBankRoutine>d__32))]
	// RVA: 0x5991D0 Offset: 0x5977D0 VA: 0x1805991D0
	private IEnumerator LoadBankRoutine(AssetReference bank, string identifier) { }

	// RVA: 0x599340 Offset: 0x597940 VA: 0x180599340 Slot: 24
	public override void LoadBanks(List<AssetReference> banks) { }

	// RVA: 0x598820 Offset: 0x596E20 VA: 0x180598820
	private void BankLoadedFromList(string identifier) { }

	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public List<FMODSFXEvent> GetSFXEvents() { }

	// RVA: 0x59B600 Offset: 0x599C00 VA: 0x18059B600 Slot: 25
	public override void UnLoadBank(AssetReference bank) { }

	// RVA: 0x59B650 Offset: 0x599C50 VA: 0x18059B650 Slot: 26
	public override void UnLoadBanks(List<AssetReference> banks) { }

	// RVA: 0x59A3A0 Offset: 0x5989A0 VA: 0x18059A3A0 Slot: 21
	public override void SetEventVolume(HashString categoryID, string eventID, EntityRef entity, float volumeMultiplier) { }

	// RVA: 0x59A4E0 Offset: 0x598AE0 VA: 0x18059A4E0 Slot: 22
	public override void SetInstanceVolume(HashString categoryID, EntityRef entity, float volumeMultiplier) { }

	// RVA: 0x599180 Offset: 0x597780 VA: 0x180599180 Slot: 27
	public override bool IsBankLoaded(string bankID) { }

	// RVA: 0x59A600 Offset: 0x598C00 VA: 0x18059A600 Slot: 28
	public override void SetParameterFloatSFX(HashString categoryID, string eventID, EntityRef entity, string parameterID, float parameterValue, bool globalParameters = False) { }

	// RVA: 0x59A8C0 Offset: 0x598EC0 VA: 0x18059A8C0 Slot: 29
	public override void SetParameterStringSFX(HashString categoryID, string eventID, EntityRef entity, string parameterID, string parameterValue, bool globalParameters = False) { }

	// RVA: 0x59BD40 Offset: 0x59A340 VA: 0x18059BD40
	public void .ctor() { }
}
