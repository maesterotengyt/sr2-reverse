// Namespace: Quantum
public abstract class SystemBase // TypeDefIndex: 10287
{
	// Fields
	private Nullable<int> _runtimeIndex; // 0x10
	private string _scheduleSample; // 0x18
	private SystemBase _parentSystem; // 0x20

	// Properties
	public int RuntimeIndex { get; set; }
	public SystemBase ParentSystem { get; }
	public virtual IEnumerable<SystemBase> ChildSystems { get; }
	public IEnumerable<SystemBase> Hierarchy { get; }
	public virtual bool StartEnabled { get; }

	// Methods

	// RVA: 0x217A810 Offset: 0x2178E10 VA: 0x18217A810 Slot: 4
	public int get_RuntimeIndex() { }

	// RVA: 0x217A850 Offset: 0x2178E50 VA: 0x18217A850
	public void set_RuntimeIndex(int value) { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public SystemBase get_ParentSystem() { }

	// RVA: 0x217A750 Offset: 0x2178D50 VA: 0x18217A750 Slot: 5
	public virtual IEnumerable<SystemBase> get_ChildSystems() { }

	[IteratorStateMachine(typeof(SystemBase.<get_Hierarchy>d__12))]
	// RVA: 0x217A790 Offset: 0x2178D90 VA: 0x18217A790
	public IEnumerable<SystemBase> get_Hierarchy() { }

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 6
	public virtual bool get_StartEnabled() { }

	// RVA: 0x217A6D0 Offset: 0x2178CD0 VA: 0x18217A6D0
	public void .ctor() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void OnInit(Frame f) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public virtual void OnEnabled(Frame f) { }

	// RVA: 0x217A680 Offset: 0x2178C80 VA: 0x18217A680
	public TaskHandle OnSchedule(Frame f, TaskHandle taskHandle) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract TaskHandle Schedule(Frame f, TaskHandle taskHandle);
}
