// Namespace: 
public class SceneLoader : SRMonoBehaviour // TypeDefIndex: 2573
{
	// Fields
	private string screenSceneToLoad; // 0x20
	private string stageSceneToLoad; // 0x28
	private bool closeSimulation; // 0x30
	private bool alertReceived; // 0x31
	private bool loadInProgress; // 0x32
	private const float ResumeLoadGracePeriodSeconds = 6;
	private Coroutine resumeLoadWatchdog; // 0x38

	// Properties
	public StellarSceneLoadingSystem StellarSystem { get; }
	public bool LoadInProgress { get; }

	// Methods

	// RVA: 0x707D90 Offset: 0x706390 VA: 0x180707D90
	public StellarSceneLoadingSystem get_StellarSystem() { }

	// RVA: 0x707D80 Offset: 0x706380 VA: 0x180707D80
	public bool get_LoadInProgress() { }

	// RVA: 0x7068F0 Offset: 0x704EF0 VA: 0x1807068F0
	public void LoadLevel(List<StellarPlayer> players, List<CharacterSpawnData> cpus, HashString stageID, string stageLayout, HashString gameMode) { }

	// RVA: 0x7076A0 Offset: 0x705CA0 VA: 0x1807076A0
	public void RestartCurrentLevel() { }

	// RVA: 0x706E20 Offset: 0x705420 VA: 0x180706E20
	public void LoadScreenScene(string screenSceneID, bool closeSimulation = False) { }

	// RVA: 0x707020 Offset: 0x705620 VA: 0x180707020
	public void LoadStageScene(HashString stageID, bool closeSimulation = False) { }

	[IteratorStateMachine(typeof(SceneLoader.<ShowLoadingScreen>d__13))]
	// RVA: 0x7077B0 Offset: 0x705DB0 VA: 0x1807077B0
	private IEnumerator ShowLoadingScreen() { }

	// RVA: 0x707B80 Offset: 0x706180 VA: 0x180707B80
	public void TransitionSceneLoaded() { }

	// RVA: 0x707820 Offset: 0x705E20 VA: 0x180707820
	public void StageLoaded() { }

	// RVA: 0x707250 Offset: 0x705850 VA: 0x180707250
	private void MatchResourcesReady() { }

	// RVA: 0x7066C0 Offset: 0x704CC0 VA: 0x1807066C0
	public bool CheckMatchLoadingValid() { }

	// RVA: 0x7074F0 Offset: 0x705AF0 VA: 0x1807074F0
	public void NotifyLoadingEnd(bool fromError = False) { }

	// RVA: 0x707630 Offset: 0x705C30 VA: 0x180707630
	public void ReceiveAlert() { }

	// RVA: 0x706850 Offset: 0x704E50 VA: 0x180706850
	public void CheckStuckLoadAfterResume() { }

	[IteratorStateMachine(typeof(SceneLoader.<ResumeLoadWatchdog>d__23))]
	// RVA: 0x707740 Offset: 0x705D40 VA: 0x180707740
	private IEnumerator ResumeLoadWatchdog() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
