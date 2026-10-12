// Namespace: Quantum
public struct FrameThreadSafe // TypeDefIndex: 11577
{
	// Fields
	private FrameBase _frame; // 0x0
	private int _thread; // 0x8

	// Properties
	public int Thread { get; }
	public bool IsMainThread { get; }
	public FrameContext Context { get; }
	public Map Map { get; }
	public FP DeltaTime { get; }
	public PhysicsEngine3D.Api.ThreadSafeApi Physics3D { get; }

	// Methods

	// RVA: 0xE03F60 Offset: 0xE02560 VA: 0x180E03F60
	public int get_Thread() { }

	// RVA: 0x21D3110 Offset: 0x21D1710 VA: 0x1821D3110
	public bool get_IsMainThread() { }

	// RVA: 0x21D30C0 Offset: 0x21D16C0 VA: 0x1821D30C0
	public FrameContext get_Context() { }

	// RVA: 0x21D3130 Offset: 0x21D1730 VA: 0x1821D3130
	public Map get_Map() { }

	// RVA: 0x21D30E0 Offset: 0x21D16E0 VA: 0x1821D30E0
	public FP get_DeltaTime() { }

	// RVA: 0x21D3160 Offset: 0x21D1760 VA: 0x1821D3160
	public PhysicsEngine3D.Api.ThreadSafeApi get_Physics3D() { }

	// RVA: 0xD64030 Offset: 0xD62630 VA: 0x180D64030
	internal void .ctor(FrameBase frame, int thread) { }

	// RVA: 0x21D3090 Offset: 0x21D1690 VA: 0x1821D3090
	public void* Void(Ptr ptr) { }

	// RVA: 0x6AB600 Offset: 0x6A9C00 VA: 0x1806AB600
	public static FrameBase op_Implicit(FrameThreadSafe f) { }

	// RVA: 0x21D31C0 Offset: 0x21D17C0 VA: 0x1821D31C0
	public static FrameThreadSafe op_Explicit(FrameBase f) { }

	// RVA: -1 Offset: -1
	public bool Has<T>(EntityRef entityRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56370 Offset: 0xB54970 VA: 0x180B56370
	|-FrameThreadSafe.Has<Transform2DVertical>
	|
	|-RVA: 0xB562B0 Offset: 0xB548B0 VA: 0x180B562B0
	|-FrameThreadSafe.Has<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21C41D0 Offset: 0x21C27D0 VA: 0x1821C41D0
	public bool Exists(EntityRef entityRef) { }

	// RVA: 0x21D3070 Offset: 0x21D1670 VA: 0x1821D3070
	public bool IsCulled(EntityRef entityRef) { }

	// RVA: -1 Offset: -1
	public T FindAsset<T>(AssetGuid assetRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56170 Offset: 0xB54770 VA: 0x180B56170
	|-FrameThreadSafe.FindAsset<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryFindAsset<T>(AssetGuid guid, out T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB563D0 Offset: 0xB549D0 VA: 0x180B563D0
	|-FrameThreadSafe.TryFindAsset<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetPointer<T>(EntityRef entityRef, out T* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56480 Offset: 0xB54A80 VA: 0x180B56480
	|-FrameThreadSafe.TryGetPointer<PhysicsBody2D>
	|-FrameThreadSafe.TryGetPointer<PhysicsBody3D>
	|-FrameThreadSafe.TryGetPointer<PhysicsCallbacks2D>
	|-FrameThreadSafe.TryGetPointer<PhysicsCallbacks3D>
	|-FrameThreadSafe.TryGetPointer<PhysicsJoints2D>
	|-FrameThreadSafe.TryGetPointer<PhysicsJoints3D>
	|-FrameThreadSafe.TryGetPointer<Transform2D>
	|-FrameThreadSafe.TryGetPointer<Transform2DVertical>
	|-FrameThreadSafe.TryGetPointer<Transform3D>
	|
	|-RVA: 0xB56430 Offset: 0xB54A30 VA: 0x180B56430
	|-FrameThreadSafe.TryGetPointer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T* GetPointer<T>(EntityRef entityRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56310 Offset: 0xB54910 VA: 0x180B56310
	|-FrameThreadSafe.GetPointer<Transform2D>
	|-FrameThreadSafe.GetPointer<Transform2DVertical>
	|-FrameThreadSafe.GetPointer<Transform3D>
	|
	|-RVA: 0xB562B0 Offset: 0xB548B0 VA: 0x180B562B0
	|-FrameThreadSafe.GetPointer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public ComponentBlockIterator<T> GetComponentBlockIterator<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56240 Offset: 0xB54840 VA: 0x180B56240
	|-FrameThreadSafe.GetComponentBlockIterator<PhysicsCollider2D>
	|-FrameThreadSafe.GetComponentBlockIterator<PhysicsCollider3D>
	|
	|-RVA: 0xB561D0 Offset: 0xB547D0 VA: 0x180B561D0
	|-FrameThreadSafe.GetComponentBlockIterator<__Il2CppFullySharedGenericStructType>
	*/
}
