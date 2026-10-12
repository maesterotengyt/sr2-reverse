// Namespace: Quantum.Allocator
public interface IFrameHeap // TypeDefIndex: 12066
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void* AllocateAndClear(int size);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Ptr AllocateAndClearPtr(int size);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Free(void* ptr);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Free(Ptr ptr);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Ptr Void(void* ptr);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void* Void(Ptr p);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TPtr* Void<TPtr>(Ptr p);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IFrameHeap.Void<QHashCollection>
	|-IFrameHeap.Void<__Il2CppFullySharedGenericStructType>
	|-IFrameHeap.Void<ulong>
	*/
}
