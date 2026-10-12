// Namespace: 
public abstract class PauseMenu : UIScreen // TypeDefIndex: 3213
{
	// Fields
	public static PauseMenu.OnPauseStateChanged PauseStateChanged; // 0x0
	public UINavigator UINavigator; // 0x58
	public CanvasGroup NavigatorCanvasGroup; // 0x60
	public List<PauseSubMenu> SubMenus; // 0x68
	[CompilerGenerated]
	private bool <PauseActive>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <ExitPauseWithCancel>k__BackingField; // 0x71

	// Properties
	public bool PauseActive { get; set; }
	public bool ExitPauseWithCancel { get; set; }
	private SimulationManager simulationManager { get; }
	private UIManager uiManager { get; }
	private OnlineManager onlineManager { get; }
	protected SceneLoader sceneLoader { get; }
	private DataManager dataManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5851F0 Offset: 0x5837F0 VA: 0x1805851F0
	public bool get_PauseActive() { }

	[CompilerGenerated]
	// RVA: 0x5853A0 Offset: 0x5839A0 VA: 0x1805853A0
	public void set_PauseActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5851E0 Offset: 0x5837E0 VA: 0x1805851E0
	public bool get_ExitPauseWithCancel() { }

	[CompilerGenerated]
	// RVA: 0x585390 Offset: 0x583990 VA: 0x180585390
	public void set_ExitPauseWithCancel(bool value) { }

	// RVA: 0x5852F0 Offset: 0x5838F0 VA: 0x1805852F0
	private SimulationManager get_simulationManager() { }

	// RVA: 0x585340 Offset: 0x583940 VA: 0x180585340
	private UIManager get_uiManager() { }

	// RVA: 0x585250 Offset: 0x583850 VA: 0x180585250
	private OnlineManager get_onlineManager() { }

	// RVA: 0x5852A0 Offset: 0x5838A0 VA: 0x1805852A0
	protected SceneLoader get_sceneLoader() { }

	// RVA: 0x585200 Offset: 0x583800 VA: 0x180585200
	private DataManager get_dataManager() { }

	// RVA: 0x5843D0 Offset: 0x5829D0 VA: 0x1805843D0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x583B90 Offset: 0x582190 VA: 0x180583B90
	public void ChangeSubMenu(PauseSubMenuID id) { }

	// RVA: 0x584620 Offset: 0x582C20 VA: 0x180584620
	private void InputDeviceDisconnected() { }

	// RVA: 0x584E90 Offset: 0x583490 VA: 0x180584E90 Slot: 11
	public override void Update() { }

	// RVA: 0x584870 Offset: 0x582E70 VA: 0x180584870 Slot: 7
	public override void Show() { }

	// RVA: 0x583DD0 Offset: 0x5823D0 VA: 0x180583DD0 Slot: 8
	public override void Hide() { }

	// RVA: 0x584850 Offset: 0x582E50 VA: 0x180584850
	public void Resume() { }

	// RVA: 0x584710 Offset: 0x582D10 VA: 0x180584710
	private void OnDestroy() { }

	// RVA: 0x5851D0 Offset: 0x5837D0 VA: 0x1805851D0
	protected void .ctor() { }
}
