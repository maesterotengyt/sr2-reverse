// Namespace: 
public class StellarAudioSystem : MonoBehaviour // TypeDefIndex: 3551
{
	// Fields
	public static StellarAudioSystem.OnBankLoaded BankLoaded; // 0x0
	public static StellarAudioSystem.OnBankListLoaded BankListLoaded; // 0x8
	public AudioTool AudioTool; // 0x20

	// Methods

	// RVA: 0x5EA0C0 Offset: 0x5E86C0 VA: 0x1805EA0C0
	public void Initialize() { }

	// RVA: 0x5EA310 Offset: 0x5E8910 VA: 0x1805EA310
	public void PlaySFX(HashString categoryID, string eventID, EntityRef entity, Vector3 position, float delay = 0, int priority = 0, bool followEntity = False, bool fromGameplay = False) { }

	// RVA: 0x5EA4B0 Offset: 0x5E8AB0 VA: 0x1805EA4B0
	public void PlaySFX(HashString categoryID, string eventID, int sourceID, Vector3 position, float delay = 0, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x5EA640 Offset: 0x5E8C40 VA: 0x1805EA640
	public void PlaySFX(HashString categoryID, string eventID, int sourceID, float delay = 0, int priority = 0, bool fromGameplay = False) { }

	// RVA: 0x5EAB90 Offset: 0x5E9190 VA: 0x1805EAB90
	public void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, EntityRef entity) { }

	// RVA: 0x5EABE0 Offset: 0x5E91E0 VA: 0x1805EABE0
	public void StopSFX(HashString categoryID, AudioContextStopMode stopMode, string eventID, int sourceID) { }

	// RVA: 0x5EAAB0 Offset: 0x5E90B0 VA: 0x1805EAAB0
	public void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, EntityRef entity) { }

	// RVA: 0x5EAAF0 Offset: 0x5E90F0 VA: 0x1805EAAF0
	public void StopAllSFXFromSource(HashString categoryID, AudioContextStopMode stopMode, int sourceID) { }

	// RVA: 0x5EAB30 Offset: 0x5E9130 VA: 0x1805EAB30
	public void StopAllSFX() { }

	// RVA: 0x5EAA50 Offset: 0x5E9050 VA: 0x1805EAA50
	public void StopAllGameplaySFX() { }

	// RVA: 0x5EA210 Offset: 0x5E8810 VA: 0x1805EA210
	public void PlayMusic(string eventID, bool stopAllMusic) { }

	// RVA: 0x5EAB60 Offset: 0x5E9160 VA: 0x1805EAB60
	public void StopMusic(string eventID) { }

	// RVA: 0x5EAA80 Offset: 0x5E9080 VA: 0x1805EAA80
	public void StopAllMusic() { }

	// RVA: 0x5EA060 Offset: 0x5E8660 VA: 0x1805EA060
	public bool EventExist(string eventID) { }

	// RVA: 0x5EA8C0 Offset: 0x5E8EC0 VA: 0x1805EA8C0
	public void SetBusVolume(string busName, float volume) { }

	// RVA: 0x5EA090 Offset: 0x5E8690 VA: 0x1805EA090
	public float GetBusVolume(string busName) { }

	// RVA: 0x5EA930 Offset: 0x5E8F30 VA: 0x1805EA930
	public void SetInstanceVolume(HashString categoryID, EntityRef entity, float volumeMultiplier) { }

	// RVA: 0x5EA9E0 Offset: 0x5E8FE0 VA: 0x1805EA9E0
	public void SetSFXParameterString(HashString categoryID, string eventID, EntityRef entity, string parameterID, string parameterValue, bool globalParameters = False) { }

	// RVA: 0x5EA970 Offset: 0x5E8F70 VA: 0x1805EA970
	public void SetSFXParameterFloat(HashString categoryID, string eventID, EntityRef entity, string parameterID, float parameterValue, bool globalParameters = False) { }

	// RVA: 0x5EA8E0 Offset: 0x5E8EE0 VA: 0x1805EA8E0
	public void SetEventVolume(HashString categoryID, string eventID, EntityRef entity, float volumeMultiplier) { }

	// RVA: 0x5EA1B0 Offset: 0x5E87B0 VA: 0x1805EA1B0
	public void LoadBank(AssetReference bank, string identifier) { }

	// RVA: 0x5EA1E0 Offset: 0x5E87E0 VA: 0x1805EA1E0
	public void LoadBanks(List<AssetReference> banks) { }

	// RVA: 0x5EAD70 Offset: 0x5E9370 VA: 0x1805EAD70
	public void UnLoadBank(AssetReference bank, float delay = 0) { }

	[IteratorStateMachine(typeof(StellarAudioSystem.<UnLoadBankDelayed>d__28))]
	// RVA: 0x5EACD0 Offset: 0x5E92D0 VA: 0x1805EACD0
	private IEnumerator UnLoadBankDelayed(AssetReference bank, float delay = 0) { }

	// RVA: 0x5EAE50 Offset: 0x5E9450 VA: 0x1805EAE50
	public void UnLoadBanks(List<AssetReference> banks) { }

	// RVA: 0x5EA180 Offset: 0x5E8780 VA: 0x1805EA180
	public bool IsBankLoaded(string bankID) { }

	// RVA: 0x5EA760 Offset: 0x5E8D60 VA: 0x1805EA760
	public void PlayUISFX(string eventID) { }

	// RVA: 0x5EAC30 Offset: 0x5E9230 VA: 0x1805EAC30
	public void StopUISFX(string eventID) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
