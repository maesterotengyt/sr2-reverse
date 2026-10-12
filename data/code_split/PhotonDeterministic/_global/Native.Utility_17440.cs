// Namespace: 
public abstract class Native.Utility // TypeDefIndex: 17440
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Native.ObjectHandle HandleAcquire(object obj);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void HandleRelease(Native.ObjectHandle handle);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object GetObjectForHandle(Native.ObjectHandle handle);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Copy(void* dest, void* src, int count);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Clear(void* dest, int count);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Move(void* dest, void* src, int count);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(void* ptr1, void* ptr2, int count);

	// RVA: 0x20C30A0 Offset: 0x20C16A0 VA: 0x1820C30A0
	public static void ClearFast(void* dest, int count) { }

	// RVA: 0x20C3110 Offset: 0x20C1710 VA: 0x1820C3110
	public static void CopyFast(void* dest, void* src, int count) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
