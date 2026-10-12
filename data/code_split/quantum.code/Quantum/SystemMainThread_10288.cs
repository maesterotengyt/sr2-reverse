// Namespace: Quantum
public abstract class SystemMainThread : SystemBase // TypeDefIndex: 10288
{
	// Fields
	private TaskDelegateHandle _updateHandle; // 0x28
	private string _update; // 0x30

	// Methods

	// RVA: 0x217AB10 Offset: 0x2179110 VA: 0x18217AB10
	public void .ctor() { }

	// RVA: 0x217A900 Offset: 0x2178F00 VA: 0x18217A900
	protected TaskHandle ScheduleUpdate(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x217A900 Offset: 0x2178F00 VA: 0x18217A900 Slot: 9
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x217AA40 Offset: 0x2179040 VA: 0x18217AA40
	private void TaskCallback(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Update(Frame f);
}
