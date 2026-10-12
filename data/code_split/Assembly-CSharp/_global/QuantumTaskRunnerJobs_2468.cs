// Namespace: 
public class QuantumTaskRunnerJobs : MonoBehaviour, IDisposable, IDeterministicPlatformTaskRunner // TypeDefIndex: 2468
{
	// Fields
	public bool dontDestroyOnLoad; // 0x20
	public QuantumJobsMaxCountMode quantumJobsMaxCountMode; // 0x24
	private static Action[] _delegates; // 0x0
	private NativeArray<JobHandle> _handles; // 0x28
	private QuantumTaskRunnerJobs.ActionJob[] _jobs; // 0x38

	// Properties
	protected virtual int CustomQuantumJobsMaxCount { get; }
	protected int DefaultQuantumJobsMaxCount { get; }

	// Methods

	// RVA: 0x633AB0 Offset: 0x6320B0 VA: 0x180633AB0 Slot: 7
	protected virtual int get_CustomQuantumJobsMaxCount() { }

	// RVA: 0x633AB0 Offset: 0x6320B0 VA: 0x180633AB0
	protected int get_DefaultQuantumJobsMaxCount() { }

	// RVA: 0x633500 Offset: 0x631B00 VA: 0x180633500
	private void Awake() { }

	// RVA: 0x633600 Offset: 0x631C00 VA: 0x180633600
	public static QuantumTaskRunnerJobs GetInstance() { }

	// RVA: 0x633760 Offset: 0x631D60 VA: 0x180633760 Slot: 8
	public virtual void Schedule(Action[] delegates) { }

	// RVA: 0x633890 Offset: 0x631E90 VA: 0x180633890
	private void Schedule(Action[] delegates, int jobsMaxCount) { }

	// RVA: 0x6336D0 Offset: 0x631CD0 VA: 0x1806336D0 Slot: 6
	public bool PollForComplete() { }

	// RVA: 0x633A80 Offset: 0x632080 VA: 0x180633A80 Slot: 9
	public void WaitForComplete() { }

	// RVA: 0x633560 Offset: 0x631B60 VA: 0x180633560
	private void OnDestroy() { }

	// RVA: 0x633560 Offset: 0x631B60 VA: 0x180633560 Slot: 4
	public void Dispose() { }

	// RVA: 0x633AA0 Offset: 0x6320A0 VA: 0x180633AA0
	public void .ctor() { }
}
