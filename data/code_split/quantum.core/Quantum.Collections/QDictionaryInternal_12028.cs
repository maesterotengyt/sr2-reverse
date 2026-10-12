// Namespace: Quantum.Collections
internal struct QDictionaryInternal // TypeDefIndex: 12028
{
	// Fields
	public int _valueOffset; // 0x0
	public QHashCollection _collection; // 0x4

	// Methods

	// RVA: 0x2212BD0 Offset: 0x22111D0 VA: 0x182212BD0
	public static void CalculateStrides(out int entryStride, ref int keyStride, ref int valStride) { }

	// RVA: -1 Offset: -1
	public static QDictionaryInternal* Allocate<THeap>(THeap heap, int capacity, int keyStride, int valStride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC14310 Offset: 0xC12910 VA: 0x180C14310
	|-QDictionaryInternal.Allocate<object>
	|
	|-RVA: 0xC13FF0 Offset: 0xC125F0 VA: 0x180C13FF0
	|-QDictionaryInternal.Allocate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Free<THeap>(THeap heap, QDictionaryInternal* map) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC14690 Offset: 0xC12C90 VA: 0x180C14690
	|-QDictionaryInternal.Free<object>
	|
	|-RVA: 0xC14480 Offset: 0xC12A80 VA: 0x180C14480
	|-QDictionaryInternal.Free<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2212C90 Offset: 0x2211290 VA: 0x182212C90
	public static void Print(Ptr ptr, FramePrinter printer, Type keyType, Type valueType) { }

	// RVA: 0x22130E0 Offset: 0x22116E0 VA: 0x1822130E0
	public static void Serialize(Ptr* ptr, FrameSerializer serializer, int keySize, int valSize, FrameSerializer.Delegate keySerializer, FrameSerializer.Delegate valSerializer) { }
}
