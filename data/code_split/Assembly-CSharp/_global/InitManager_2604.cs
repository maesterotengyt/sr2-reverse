// Namespace: 
public class InitManager : SRMonoBehaviour // TypeDefIndex: 2604
{
	// Fields
	public LaunchPreloader LaunchPreloader; // 0x20
	[HideInInspector]
	public string PS5LaunchSessionID; // 0x28
	[HideInInspector]
	public string PS4LaunchSessionID; // 0x30
	private bool gameManagerReady; // 0x38
	private bool launchPreloaderReady; // 0x39
	private bool stellarReady; // 0x3A
	private bool saveDataReady; // 0x3B

	// Methods

	// RVA: 0x6FB880 Offset: 0x6F9E80 VA: 0x1806FB880
	private void Start() { }

	// RVA: 0x6FBD90 Offset: 0x6FA390 VA: 0x1806FBD90
	private void StellarInitialized() { }

	// RVA: 0x6FB760 Offset: 0x6F9D60 VA: 0x1806FB760
	private void SaveDataReady() { }

	// RVA: 0x6FB6D0 Offset: 0x6F9CD0 VA: 0x1806FB6D0
	private void GameManagerLoaded(AsyncOperationHandle<GameObject> operation) { }

	// RVA: 0x6FB750 Offset: 0x6F9D50 VA: 0x1806FB750
	public void LaunchPreloaderReady() { }

	// RVA: 0x6FB5E0 Offset: 0x6F9BE0 VA: 0x1806FB5E0
	private void CheckInitReady() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
