// Namespace: 
public class StellarAudioTool : AudioTool // TypeDefIndex: 3277
{
	// Methods

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 18
	public override bool EventExist(string eventID) { }

	// RVA: 0x5A3A10 Offset: 0x5A2010 VA: 0x1805A3A10 Slot: 20
	public override float GetBusVolume(string busName) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public override void Initialize() { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 27
	public override bool IsBankLoaded(string bankID) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 23
	public override void LoadBank(AssetReference bank, string identifier) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 24
	public override void LoadBanks(List<AssetReference> banks) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 15
	public override void PlayMusic(string eventID, bool stopAllMusic) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 6
	public override void PlaySFX(HashString categoryID, string eventID, EntityRef entity, Nullable<Vector3> position, float delay = 0, bool followEntity = False, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public override void PlaySFX(HashString categoryID, string eventID, int sourceID, Nullable<Vector3> position, float delay = 0, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public override void PlaySFX(HashString categoryID, string eventID, int sourceID, float delay = 0, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 19
	public override void SetBusVolume(string busName, float volume) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 21
	public override void SetEventVolume(HashString categoryID, string eventID, EntityRef entity, float volumeMultiplier) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 22
	public override void SetInstanceVolume(HashString categoryID, EntityRef entity, float volumeMultiplier) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 28
	public override void SetParameterFloatSFX(HashString categoryID, string eventID, EntityRef entity, string parameterID, float parameterValue, bool globalParameters = False) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 29
	public override void SetParameterStringSFX(HashString categoryID, string eventID, EntityRef entity, string parameterID, string parameterValue, bool globalParameters = False) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 17
	public override void StopAllMusic() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 11
	public override void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, EntityRef entity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 12
	public override void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, int sourceID) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 13
	public override void StopAllSFX(HashString categoryID, AudioContextStopMode stopMode) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 14
	public override void StopAllSFX(AudioContextStopMode stopMode) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 16
	public override void StopMusic(string eventID) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public override void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, EntityRef entity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public override void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, int sourceID) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 25
	public override void UnLoadBank(AssetReference bank) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 26
	public override void UnLoadBanks(List<AssetReference> banks) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	protected override void PlaySFX(HashString categoryID, string eventID, EntityRef entity, int sourceID, Nullable<Vector3> position, float delay = 0, bool followEntity = False, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
