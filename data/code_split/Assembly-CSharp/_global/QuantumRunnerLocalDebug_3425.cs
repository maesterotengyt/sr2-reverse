// Namespace: 
public class QuantumRunnerLocalDebug : QuantumCallbacks // TypeDefIndex: 3425
{
	// Fields
	public RecordingFlags RecordingFlags; // 0x20
	public InstantReplaySettings InstantReplayConfig; // 0x28
	public float SimulationSpeedMultiplier; // 0x38
	public bool DisplaySaveAndReloadButton; // 0x3C
	public RuntimeConfig Config; // 0x40
	public RuntimePlayer[] Players; // 0x48
	public bool PreloadAddressables; // 0x50
	public QuantumRunnerLocalDebug.DynamicAssetDBSettings DynamicAssetDB; // 0x58
	private bool _isReload; // 0x60

	// Methods

	[AsyncStateMachine(typeof(QuantumRunnerLocalDebug.<Start>d__9))]
	// RVA: 0x5D0E90 Offset: 0x5CF490 VA: 0x1805D0E90
	public void Start() { }

	// RVA: 0x5D0A20 Offset: 0x5CF020 VA: 0x1805D0A20
	public void StartWithFrame(int frameNumber = 0, byte[] frameData) { }

	// RVA: 0x5D0920 Offset: 0x5CEF20 VA: 0x1805D0920 Slot: 6
	public override void OnGameStart(QuantumGame game) { }

	// RVA: 0x5D0760 Offset: 0x5CED60 VA: 0x1805D0760
	public void OnGUI() { }

	// RVA: 0x5D0F50 Offset: 0x5CF550 VA: 0x1805D0F50
	public void Update() { }

	[IteratorStateMachine(typeof(QuantumRunnerLocalDebug.<SaveAndReload>d__14))]
	// RVA: 0x5D09B0 Offset: 0x5CEFB0 VA: 0x1805D09B0
	private IEnumerator SaveAndReload() { }

	// RVA: 0x5D1190 Offset: 0x5CF790 VA: 0x1805D1190
	public void .ctor() { }
}
