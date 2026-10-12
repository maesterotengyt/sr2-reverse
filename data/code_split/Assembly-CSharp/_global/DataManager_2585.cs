// Namespace: 
public class DataManager : MonoBehaviour // TypeDefIndex: 2585
{
	// Fields
	public ProgressionManager ProgressionManager; // 0x20
	[CompilerGenerated]
	private CampaignManager <CampaignManager>k__BackingField; // 0x28
	[CompilerGenerated]
	private GameContext <GameContext>k__BackingField; // 0x30
	public TransitionContext TransitionContext; // 0x34
	public string CurrentOnlineRegion; // 0x38

	// Properties
	public StellarDataSystem StellarSystem { get; }
	public CampaignManager CampaignManager { get; set; }
	public GameContext GameContext { get; set; }

	// Methods

	// RVA: 0x6F4170 Offset: 0x6F2770 VA: 0x1806F4170
	public StellarDataSystem get_StellarSystem() { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public CampaignManager get_CampaignManager() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	public void set_CampaignManager(CampaignManager value) { }

	[CompilerGenerated]
	// RVA: 0x5114B0 Offset: 0x50FAB0 VA: 0x1805114B0
	public GameContext get_GameContext() { }

	[CompilerGenerated]
	// RVA: 0x5C5B70 Offset: 0x5C4170 VA: 0x1805C5B70
	private void set_GameContext(GameContext value) { }

	// RVA: 0x6F3F40 Offset: 0x6F2540 VA: 0x1806F3F40
	public void Initialize() { }

	// RVA: 0x6F4100 Offset: 0x6F2700 VA: 0x1806F4100
	private void QuantumCustomLogMessage(EventCustomLogMessage callback) { }

	// RVA: 0x5C5B70 Offset: 0x5C4170 VA: 0x1805C5B70
	public void SetGameContext(GameContext context) { }

	// RVA: 0x6F40A0 Offset: 0x6F26A0 VA: 0x1806F40A0
	private void OnDestroy() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
