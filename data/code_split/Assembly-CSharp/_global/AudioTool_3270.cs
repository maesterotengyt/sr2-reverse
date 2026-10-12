// Namespace: 
public abstract class AudioTool : StellarMonoBehaviour // TypeDefIndex: 3270
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void PlaySFX(HashString categoryID, string eventID, EntityRef entity, int sourceID, Nullable<Vector3> position, float delay = 0, bool followEntity = False, int priority = 0, bool fromGameplay = False);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PlaySFX(HashString categoryID, string eventID, EntityRef entity, Nullable<Vector3> position, float delay = 0, bool followEntity = False, int priority = 0, bool fromGameplay = False);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PlaySFX(HashString categoryID, string eventID, int sourceID, Nullable<Vector3> position, float delay = 0, int priority = 0, bool fromGameplay = False);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PlaySFX(HashString categoryID, string eventID, int sourceID, float delay = 0, int priority = 0, bool fromGameplay = False);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, EntityRef entity);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, int sourceID);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, EntityRef entity);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, int sourceID);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void StopAllSFX(HashString categoryID, AudioContextStopMode stopMode);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void StopAllSFX(AudioContextStopMode stopMode);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void PlayMusic(string eventID, bool stopAllMusic);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void StopMusic(string eventID);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void StopAllMusic();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool EventExist(string eventID);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetBusVolume(string busName, float volume);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract float GetBusVolume(string busName);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SetEventVolume(HashString categoryID, string eventID, EntityRef entity, float volumeMultiplier);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void SetInstanceVolume(HashString categoryID, EntityRef entity, float volumeMultiplier);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void LoadBank(AssetReference bank, string identifier);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void LoadBanks(List<AssetReference> banks);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void UnLoadBank(AssetReference bank);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void UnLoadBanks(List<AssetReference> banks);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool IsBankLoaded(string bankID);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SetParameterFloatSFX(HashString categoryID, string eventID, EntityRef entity, string parameterID, float parameterValue, bool globalParameters = False);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void SetParameterStringSFX(HashString categoryID, string eventID, EntityRef entity, string parameterID, string parameterValue, bool globalParameters = False);

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	protected void .ctor() { }
}
