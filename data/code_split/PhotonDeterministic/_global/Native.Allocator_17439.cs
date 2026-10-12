// Namespace: 
public abstract class Native.Allocator // TypeDefIndex: 17439
{
	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void Dispose() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Free(void* ptr);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void* Alloc(int count);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void* Alloc(int count, int alignment);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void Clear(void* dest, int count);

	// RVA: 0x20AB350 Offset: 0x20A9950 VA: 0x1820AB350
	public void* AllocAndClear(int count) { }

	// RVA: 0x20AB3B0 Offset: 0x20A99B0 VA: 0x1820AB3B0
	public void* AllocAndClear(int count, int alignment) { }

	// RVA: -1 Offset: -1
	public T* AllocAndClear<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE3020 Offset: 0xCE1620 VA: 0x180CE3020
	|-Native.Allocator.AllocAndClear<UnsafeHashMap>
	|
	|-RVA: 0xCE2FA0 Offset: 0xCE15A0 VA: 0x180CE2FA0
	|-Native.Allocator.AllocAndClear<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xCE2F50 Offset: 0xCE1550 VA: 0x180CE2F50
	|-Native.Allocator.AllocAndClear<FrameBase.Culling.CullingData>
	*/

	// RVA: 0x20AB410 Offset: 0x20A9A10 VA: 0x1820AB410
	public void* Expand(void* buffer, int currentSize, int newSize) { }

	// RVA: -1 Offset: -1
	public T* ExpandArray<T>(T* buffer, int currentSize, int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE3120 Offset: 0xCE1720 VA: 0x180CE3120
	|-Native.Allocator.ExpandArray<Bucket>
	|
	|-RVA: 0xCE3070 Offset: 0xCE1670 VA: 0x180CE3070
	|-Native.Allocator.ExpandArray<Bucket3D>
	|
	|-RVA: 0xCE31D0 Offset: 0xCE17D0 VA: 0x180CE31D0
	|-Native.Allocator.ExpandArray<CollisionManifold2D>
	|
	|-RVA: 0xCE3270 Offset: 0xCE1870 VA: 0x180CE3270
	|-Native.Allocator.ExpandArray<CollisionManifold3D>
	|
	|-RVA: 0xCE33D0 Offset: 0xCE19D0 VA: 0x180CE33D0
	|-Native.Allocator.ExpandArray<Entry2D>
	|
	|-RVA: 0xCE3480 Offset: 0xCE1A80 VA: 0x180CE3480
	|-Native.Allocator.ExpandArray<Entry3D>
	|
	|-RVA: 0xCE3760 Offset: 0xCE1D60 VA: 0x180CE3760
	|-Native.Allocator.ExpandArray<int>
	|
	|-RVA: 0xCE3810 Offset: 0xCE1E10 VA: 0x180CE3810
	|-Native.Allocator.ExpandArray<Island2D>
	|
	|-RVA: 0xCE38C0 Offset: 0xCE1EC0 VA: 0x180CE38C0
	|-Native.Allocator.ExpandArray<Island3D>
	|
	|-RVA: 0xCE3A20 Offset: 0xCE2020 VA: 0x180CE3A20
	|-Native.Allocator.ExpandArray<QueryManifold>
	|
	|-RVA: 0xCE3970 Offset: 0xCE1F70 VA: 0x180CE3970
	|-Native.Allocator.ExpandArray<QueryManifold3D>
	|
	|-RVA: 0xCE3B80 Offset: 0xCE2180 VA: 0x180CE3B80
	|-Native.Allocator.ExpandArray<TriangleReference>
	|
	|-RVA: 0xCE3690 Offset: 0xCE1C90 VA: 0x180CE3690
	|-Native.Allocator.ExpandArray<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xCE35E0 Offset: 0xCE1BE0 VA: 0x180CE35E0
	|-Native.Allocator.ExpandArray<Navigation.Entry>
	|
	|-RVA: 0xCE3530 Offset: 0xCE1B30 VA: 0x180CE3530
	|-Native.Allocator.ExpandArray<Navigation.EntryPair>
	|
	|-RVA: 0xCE3320 Offset: 0xCE1920 VA: 0x180CE3320
	|-Native.Allocator.ExpandArray<Radix.EndPoint>
	|
	|-RVA: 0xCE3AD0 Offset: 0xCE20D0 VA: 0x180CE3AD0
	|-Native.Allocator.ExpandArray<TriangleMesh.Tri>
	*/

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
