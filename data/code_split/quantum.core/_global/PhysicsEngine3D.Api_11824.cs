// Namespace: 
public class PhysicsEngine3D.Api // TypeDefIndex: 11824
{
	// Fields
	private PhysicsEngine3D.Api.ThreadSafeApi _mainThread; // 0x10
	internal PhysicsEngine3D.Api.ThreadSafeApi[] ThreadSafe; // 0x28

	// Methods

	// RVA: 0x2234A90 Offset: 0x2233090 VA: 0x182234A90
	public void SetCallbacks(EntityRef entity, CallbackFlags flags) { }

	// RVA: 0x2234C60 Offset: 0x2233260 VA: 0x182234C60
	public void .ctor(FrameBase frame, int threadCount) { }

	// RVA: 0x2234A70 Offset: 0x2233070 VA: 0x182234A70
	public void Init(AssetRefMap mapRef) { }

	// RVA: 0x2234BB0 Offset: 0x22331B0 VA: 0x182234BB0
	public TaskHandle Update(ICollisionCallbacks3D callbacks, FP dt, TaskHandle taskHandle) { }
}
