// Namespace: Quantum.Collections
internal struct QBuffer // TypeDefIndex: 12026
{
	// Fields
	public int Length; // 0x0
	public int Stride; // 0x4
	public Ptr Ptr; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	public static void Clear<THeap>(THeap heap, QBuffer* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC13710 Offset: 0xC11D10 VA: 0x180C13710
	|-QBuffer.Clear<object>
	|
	|-RVA: 0xC135D0 Offset: 0xC11BD0 VA: 0x180C135D0
	|-QBuffer.Clear<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Free<THeap>(THeap heap, QBuffer* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC13BD0 Offset: 0xC121D0 VA: 0x180C13BD0
	|-QBuffer.Free<object>
	|
	|-RVA: 0xC13AD0 Offset: 0xC120D0 VA: 0x180C13AD0
	|-QBuffer.Free<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2211FC0 Offset: 0x22105C0 VA: 0x182211FC0
	private static void SerializeMeta(QBuffer* buffer, int stride, FrameSerializer serializer) { }

	// RVA: 0x2212060 Offset: 0x2210660 VA: 0x182212060
	public static bool Serialize(QBuffer* buffer, int stride, FrameSerializer serializer, out FrameSerializer.PtrKey ptrKey) { }

	// RVA: 0x2212100 Offset: 0x2210700 VA: 0x182212100
	public static void Serialize(QBuffer* buffer, int stride, FrameSerializer serializer, int count, FrameSerializer.Delegate itemSerializer) { }

	// RVA: 0x2211F80 Offset: 0x2210580 VA: 0x182211F80 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1
	public static void Init<THeap>(THeap heap, QBuffer* buffer, int length, int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC13D50 Offset: 0xC12350 VA: 0x180C13D50
	|-QBuffer.Init<object>
	|
	|-RVA: 0xC13C40 Offset: 0xC12240 VA: 0x180C13C40
	|-QBuffer.Init<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Copy<THeap>(THeap heap, QBuffer source, int sourceIndex, QBuffer destination, int destinationIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC139E0 Offset: 0xC11FE0 VA: 0x180C139E0
	|-QBuffer.Copy<object>
	|
	|-RVA: 0xC137C0 Offset: 0xC11DC0 VA: 0x180C137C0
	|-QBuffer.Copy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Move<THeap>(THeap heap, QBuffer source, int fromIndex, int toIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC13F30 Offset: 0xC12530 VA: 0x180C13F30
	|-QBuffer.Move<object>
	|
	|-RVA: 0xC13DC0 Offset: 0xC123C0 VA: 0x180C13DC0
	|-QBuffer.Move<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2211F70 Offset: 0x2210570 VA: 0x182211F70
	public static void* Element(void* bufferPtr, int index, int stride) { }
}
