// Namespace: 
public sealed class QuantumRunner : MonoBehaviour, IDisposable // TypeDefIndex: 3420
{
	// Fields
	private static List<QuantumRunner> _activeRunners; // 0x0
	[HideInInspector]
	public bool OverrideUpdateSession; // 0x20
	[CompilerGenerated]
	private QuantumGame <Game>k__BackingField; // 0x28
	[CompilerGenerated]
	private DeterministicSession <Session>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x38
	[CompilerGenerated]
	private SimulationUpdateTime <DeltaTimeType>k__BackingField; // 0x40
	[CompilerGenerated]
	private LoadBalancingClient <NetworkClient>k__BackingField; // 0x48
	[CompilerGenerated]
	private RecordingFlags <RecordingFlags>k__BackingField; // 0x50
	public bool HideGizmos; // 0x54
	public QuantumEditorSettings GizmoSettings; // 0x58
	private bool _shutdownRequested; // 0x60
	private float _startGameTimeout; // 0x64

	// Properties
	public static QuantumRunner Default { get; }
	public static IEnumerable<QuantumRunner> ActiveRunners { get; }
	public QuantumGame Game { get; set; }
	public DeterministicSession Session { get; set; }
	public string Id { get; set; }
	public SimulationUpdateTime DeltaTimeType { get; set; }
	public LoadBalancingClient NetworkClient { get; set; }
	public RecordingFlags RecordingFlags { get; set; }
	public bool IsRunning { get; }
	public bool HasGameStartTimedOut { get; }
	public Nullable<float> DeltaTime { get; }

	// Methods

	// RVA: 0x5D3920 Offset: 0x5D1F20 VA: 0x1805D3920
	public static QuantumRunner get_Default() { }

	// RVA: 0x5D38D0 Offset: 0x5D1ED0 VA: 0x1805D38D0
	public static IEnumerable<QuantumRunner> get_ActiveRunners() { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public QuantumGame get_Game() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	private void set_Game(QuantumGame value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public DeterministicSession get_Session() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	private void set_Session(DeterministicSession value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	private void set_Id(string value) { }

	[CompilerGenerated]
	// RVA: 0x5D39D0 Offset: 0x5D1FD0 VA: 0x1805D39D0
	public SimulationUpdateTime get_DeltaTimeType() { }

	[CompilerGenerated]
	// RVA: 0x5D3B00 Offset: 0x5D2100 VA: 0x1805D3B00
	public void set_DeltaTimeType(SimulationUpdateTime value) { }

	[CompilerGenerated]
	// RVA: 0x5C9FA0 Offset: 0x5C85A0 VA: 0x1805C9FA0
	public LoadBalancingClient get_NetworkClient() { }

	[CompilerGenerated]
	// RVA: 0x58D130 Offset: 0x58B730 VA: 0x18058D130
	private void set_NetworkClient(LoadBalancingClient value) { }

	[CompilerGenerated]
	// RVA: 0x5D3AF0 Offset: 0x5D20F0 VA: 0x1805D3AF0
	public RecordingFlags get_RecordingFlags() { }

	[CompilerGenerated]
	// RVA: 0x5D3B10 Offset: 0x5D2110 VA: 0x1805D3B10
	private void set_RecordingFlags(RecordingFlags value) { }

	// RVA: 0x5D3AB0 Offset: 0x5D20B0 VA: 0x1805D3AB0
	public bool get_IsRunning() { }

	// RVA: 0x5D3A60 Offset: 0x5D2060 VA: 0x1805D3A60
	public bool get_HasGameStartTimedOut() { }

	// RVA: 0x5D39E0 Offset: 0x5D1FE0 VA: 0x1805D39E0
	public Nullable<float> get_DeltaTime() { }

	// RVA: 0x5D3700 Offset: 0x5D1D00 VA: 0x1805D3700
	private void Update() { }

	// RVA: 0x5D2000 Offset: 0x5D0600 VA: 0x1805D2000
	private void OnDisable() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnDrawGizmos() { }

	// RVA: 0x5D2330 Offset: 0x5D0930 VA: 0x1805D2330
	public void Shutdown() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public void Dispose() { }

	// RVA: 0x5D1850 Offset: 0x5CFE50 VA: 0x1805D1850
	public static void Init(bool force = False) { }

	// RVA: 0x5D2390 Offset: 0x5D0990 VA: 0x1805D2390
	public static QuantumRunner StartGame(string clientId, QuantumRunner.StartParameters param) { }

	// RVA: 0x5D1430 Offset: 0x5CFA30 VA: 0x1805D1430
	public static DeterministicPlatformInfo CreatePlatformInfo() { }

	// RVA: 0x5D20C0 Offset: 0x5D06C0 VA: 0x1805D20C0
	public static bool ShutdownAll(bool immediate = False) { }

	// RVA: 0x5D16C0 Offset: 0x5CFCC0 VA: 0x1805D16C0
	public static QuantumRunner FindRunner(string id) { }

	// RVA: 0x5D1540 Offset: 0x5CFB40 VA: 0x1805D1540
	public static QuantumRunner FindRunner(IDeterministicGame game) { }

	[Obsolete("Use FindRunner")]
	// RVA: 0x5D14F0 Offset: 0x5CFAF0 VA: 0x1805D14F0
	internal static QuantumRunner FindRunnerForGame(IDeterministicGame game) { }

	// RVA: 0x5D1200 Offset: 0x5CF800 VA: 0x1805D1200
	private static QuantumNetworkCommunicator CreateCommunicator(DeterministicGameMode mode, LoadBalancingClient networkClient, QuantumNetworkCommunicator.QuitBehaviour quitBehaviour) { }

	// RVA: 0x5D1290 Offset: 0x5CF890 VA: 0x1805D1290
	private static QuantumRunner CreateInstance(string name) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	// RVA: 0x5D3840 Offset: 0x5D1E40 VA: 0x1805D3840
	private static void .cctor() { }
}
