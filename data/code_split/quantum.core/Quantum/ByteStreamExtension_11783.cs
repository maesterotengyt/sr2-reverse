// Namespace: Quantum
[Extension]
public static class ByteStreamExtension // TypeDefIndex: 11783
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] SerializeArrayLength<T>(ByteStream stream, bool write, T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2D80 Offset: 0xAD1380 VA: 0x180AD2D80
	|-ByteStreamExtension.SerializeArrayLength<byte>
	|-ByteStreamExtension.SerializeArrayLength<int>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshBorder>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshBorderNode>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshLink>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshPortal>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshTriangle>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshTriangleCenterGridNode>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshTriangleNode>
	|-ByteStreamExtension.SerializeArrayLength<NavMeshVertex>
	|-ByteStreamExtension.SerializeArrayLength<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x22223B0 Offset: 0x22209B0 VA: 0x1822223B0
	public static string SerializeString(ByteStream stream, bool write, string value) { }

	[Extension]
	// RVA: 0x2222230 Offset: 0x2220830 VA: 0x182222230
	public static byte[] SerializeByteArray(ByteStream stream, bool write, byte[] array) { }

	[Extension]
	// RVA: 0x2222310 Offset: 0x2220910 VA: 0x182222310
	public static int[] SerializeIntArray(ByteStream stream, bool write, int[] array) { }

	[Extension]
	// RVA: 0x2222460 Offset: 0x2220A60 VA: 0x182222460
	public static byte Serialize(ByteStream stream, bool write, byte value) { }

	[Extension]
	// RVA: 0x22224C0 Offset: 0x2220AC0 VA: 0x1822224C0
	public static int Serialize(ByteStream stream, bool write, int value) { }

	[Extension]
	// RVA: 0x2222730 Offset: 0x2220D30 VA: 0x182222730
	public static ulong Serialize(ByteStream stream, bool write, ulong value) { }

	[Extension]
	// RVA: 0x2222A00 Offset: 0x2221000 VA: 0x182222A00
	public static FP Serialize(ByteStream stream, bool write, FP value) { }

	[Extension]
	// RVA: 0x2222640 Offset: 0x2220C40 VA: 0x182222640
	public static FPVector3 Serialize(ByteStream stream, bool write, FPVector3 value) { }
}
