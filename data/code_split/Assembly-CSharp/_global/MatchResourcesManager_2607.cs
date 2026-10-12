// Namespace: 
public class MatchResourcesManager : MonoBehaviour // TypeDefIndex: 2607
{
	// Fields
	public MatchResourcesManager.OnMatchResourcesReady MatchResourcesReady; // 0x20
	public MatchPreloader MatchPreloader; // 0x28
	[Header("Resources")]
	public GameObject VFXManagerGeneral; // 0x30
	private bool isGameModeLoaded; // 0x38

	// Properties
	private UIManager uiManager { get; }
	private GameModeManager gameModeManager { get; }

	// Methods

	// RVA: 0x6FE170 Offset: 0x6FC770 VA: 0x1806FE170
	private UIManager get_uiManager() { }

	// RVA: 0x6FE120 Offset: 0x6FC720 VA: 0x1806FE120
	private GameModeManager get_gameModeManager() { }

	// RVA: 0x6FDBB0 Offset: 0x6FC1B0 VA: 0x1806FDBB0
	public void LoadMatchResources() { }

	// RVA: 0x6FD9A0 Offset: 0x6FBFA0 VA: 0x1806FD9A0
	private void GameModeReady() { }

	// RVA: 0x6FD550 Offset: 0x6FBB50 VA: 0x1806FD550
	private void CheckResourcesLoadFinished() { }

	// RVA: 0x6FDF20 Offset: 0x6FC520 VA: 0x1806FDF20
	public void MatchPreloaded() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
