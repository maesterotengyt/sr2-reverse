// Namespace: 
public class StellarSceneLoadingSystem : StellarMonoBehaviour // TypeDefIndex: 3572
{
	// Fields
	public static StellarSceneLoadingSystem.OnAdditiveSceneLoaded AdditiveSceneLoaded; // 0x0
	private bool waitingForPlayers; // 0x20
	private float loadingTimer; // 0x24
	private float printStateTimer; // 0x28
	private bool isMaster; // 0x2C
	private bool timeoutActive; // 0x2D

	// Methods

	// RVA: 0x5F3C90 Offset: 0x5F2290 VA: 0x1805F3C90
	public void Initialize() { }

	// RVA: 0x5F40D0 Offset: 0x5F26D0 VA: 0x1805F40D0
	private void LoadScene(string scene) { }

	// RVA: 0x5F41A0 Offset: 0x5F27A0 VA: 0x1805F41A0
	public void LoadScreenScene(string screenSceneID) { }

	// RVA: 0x5F4200 Offset: 0x5F2800 VA: 0x1805F4200
	public void LoadStageScene(string stageID, bool closeSimulation = False) { }

	// RVA: 0x5F4350 Offset: 0x5F2950 VA: 0x1805F4350
	public void LoadTransitionScene() { }

	// RVA: 0x5F43F0 Offset: 0x5F29F0 VA: 0x1805F43F0
	public void NotifyOnlineStageLoaded() { }

	// RVA: 0x5F4670 Offset: 0x5F2C70 VA: 0x1805F4670
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x5F47C0 Offset: 0x5F2DC0 VA: 0x1805F47C0
	private void SimulationStarted() { }

	// RVA: 0x5F47D0 Offset: 0x5F2DD0 VA: 0x1805F47D0
	private void Update() { }

	// RVA: 0x5F3F70 Offset: 0x5F2570 VA: 0x1805F3F70
	public void LoadAdditiveScene(string scenePath) { }

	// RVA: 0x5F3C30 Offset: 0x5F2230 VA: 0x1805F3C30
	private void AdditiveSceneLoadedResult(AsyncOperationHandle<SceneInstance> operation, string scenePath) { }

	// RVA: 0x5F3EB0 Offset: 0x5F24B0 VA: 0x1805F3EB0
	public bool IsMatchLoadingValid() { }

	// RVA: 0x5F4450 Offset: 0x5F2A50 VA: 0x1805F4450
	private void OnDestroy() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
