// Namespace: Quantum.Collections
internal struct UnsafeBuffer // TypeDefIndex: 12043
{
	// Fields
	public void* Ptr; // 0x0
	public int Length; // 0x8
	public int Stride; // 0xC
	public int Dynamic; // 0x10

	// Methods

	// RVA: 0x2213EC0 Offset: 0x22124C0 VA: 0x182213EC0
	public static void Free(Native.Allocator allocator, UnsafeBuffer* buffer) { }

	// RVA: 0x2213DB0 Offset: 0x22123B0 VA: 0x182213DB0
	public static void Clear(UnsafeBuffer* buffer) { }

	// RVA: 0x2213FB0 Offset: 0x22125B0 VA: 0x182213FB0
	public static void InitFixed(UnsafeBuffer* buffer, void* ptr, int length, int stride) { }

	// RVA: 0x2213F50 Offset: 0x2212550 VA: 0x182213F50
	public static void InitDynamic(Native.Allocator allocator, UnsafeBuffer* buffer, int length, int stride) { }

	// RVA: 0x2213E20 Offset: 0x2212420 VA: 0x182213E20
	public static void Copy(UnsafeBuffer source, int sourceIndex, UnsafeBuffer destination, int destinationIndex, int count) { }

	// RVA: 0x2211F70 Offset: 0x2210570 VA: 0x182211F70
	public static void* Element(void* bufferPtr, int index, int stride) { }
}
