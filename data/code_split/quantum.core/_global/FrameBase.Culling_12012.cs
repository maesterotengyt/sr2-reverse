// Namespace: 
public class FrameBase.Culling // TypeDefIndex: 12012
{
	// Fields
	private TaskDelegateHandle _cull2DTask; // 0x10
	private TaskDelegateHandle _cull3DTask; // 0x14
	private FrameBase.Culling.CullingData* _data; // 0x18

	// Methods

	// RVA: 0x2208B20 Offset: 0x2207120 VA: 0x182208B20
	internal void .ctor(FrameContext context) { }

	// RVA: 0x2208320 Offset: 0x2206920 VA: 0x182208320
	internal void Dispose(FrameContext context) { }

	// RVA: 0x2208370 Offset: 0x2206970 VA: 0x182208370
	public TaskHandle Schedule2D(FrameBase f, TaskHandle handle) { }

	// RVA: 0x2208420 Offset: 0x2206A20 VA: 0x182208420
	public TaskHandle Schedule3D(FrameBase f, TaskHandle handle) { }

	// RVA: 0x22084E0 Offset: 0x2206AE0 VA: 0x1822084E0
	private static void Task_CullTransform2D(FrameThreadSafe frame, int start, int end, void* arg) { }

	// RVA: 0x2208810 Offset: 0x2206E10 VA: 0x182208810
	private static void Task_CullTransform3D(FrameThreadSafe frame, int start, int end, void* arg) { }
}
