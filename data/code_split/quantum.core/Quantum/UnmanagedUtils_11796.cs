// Namespace: Quantum
public static class UnmanagedUtils // TypeDefIndex: 11796
{
	// Fields
	private static readonly string[] _byteHexValue; // 0x0

	// Methods

	// RVA: 0x222ECA0 Offset: 0x222D2A0 VA: 0x18222ECA0
	public static string ByteToHex(byte value) { }

	// RVA: 0x222ED10 Offset: 0x222D310 VA: 0x18222ED10
	public static void PrintBytesBits(byte* buffer, int bitsLength, int blockSize, FramePrinter printer) { }

	// RVA: 0x222EE10 Offset: 0x222D410 VA: 0x18222EE10
	public static void PrintBytesHex(byte* buffer, int length, int blockSize, FramePrinter printer) { }

	// RVA: -1 Offset: -1
	public static T* ToNativeBuffer<T>(T[] array, Native.Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC94FB0 Offset: 0xC935B0 VA: 0x180C94FB0
	|-UnmanagedUtils.ToNativeBuffer<FPVector2>
	|
	|-RVA: 0xC95070 Offset: 0xC93670 VA: 0x180C95070
	|-UnmanagedUtils.ToNativeBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x222EF20 Offset: 0x222D520 VA: 0x18222EF20
	private static void .cctor() { }
}
