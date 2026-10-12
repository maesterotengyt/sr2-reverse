// Namespace: Photon.Deterministic
public class ByteUtils // TypeDefIndex: 17483
{
	// Methods

	// RVA: 0x20AF3D0 Offset: 0x20AD9D0 VA: 0x1820AF3D0
	public static byte[] MergeByteBlocks(byte[][] blocks) { }

	// RVA: 0x20AE410 Offset: 0x20ACA10 VA: 0x1820AE410
	public static int AddValueBlock(int value, byte[] buffer, int offset) { }

	// RVA: 0x20AE3A0 Offset: 0x20AC9A0 VA: 0x1820AE3A0
	public static int AddValueBlock(long value, byte[] buffer, int offset) { }

	// RVA: 0x20AE3A0 Offset: 0x20AC9A0 VA: 0x1820AE3A0
	public static int AddValueBlock(ulong value, byte[] buffer, int offset) { }

	// RVA: 0x20AE500 Offset: 0x20ACB00 VA: 0x1820AE500
	public static int BeginByteBlockHeader(byte[] buffer, int offset, out int blockStart) { }

	// RVA: 0x20AE650 Offset: 0x20ACC50 VA: 0x1820AE650
	public static int EndByteBlockHeader(byte[] buffer, int blockStart, int bytesWritten) { }

	// RVA: 0x20AF590 Offset: 0x20ADB90 VA: 0x1820AF590
	public static byte[] PackByteBlocks(byte[][] blocks) { }

	[IteratorStateMachine(typeof(ByteUtils.<ReadByteBlocks>d__9))]
	// RVA: 0x20AF7B0 Offset: 0x20ADDB0 VA: 0x1820AF7B0
	public static IEnumerable<byte[]> ReadByteBlocks(byte[] data) { }

	// RVA: 0x20AE510 Offset: 0x20ACB10 VA: 0x1820AE510
	private static void CopyTo(Stream source, Stream destination) { }

	// RVA: 0x20AE4B0 Offset: 0x20ACAB0 VA: 0x1820AE4B0
	public static string Base64Encode(byte[] data) { }

	// RVA: 0x20AE460 Offset: 0x20ACA60 VA: 0x1820AE460
	public static byte[] Base64Decode(string data) { }

	// RVA: 0x20AE940 Offset: 0x20ACF40 VA: 0x1820AE940
	public static byte[] GZipCompressBytes(byte[] data) { }

	// RVA: 0x20AE6A0 Offset: 0x20ACCA0 VA: 0x1820AE6A0
	public static void GZipCompressBytes(byte[] data, int offset, int size, Stream output) { }

	// RVA: 0x20AE7A0 Offset: 0x20ACDA0 VA: 0x1820AE7A0
	public static void GZipCompressBytes(Stream input, Stream output) { }

	// RVA: 0x20AE5E0 Offset: 0x20ACBE0 VA: 0x1820AE5E0
	public static GZipStream CreateGZipCompressStream(Stream output) { }

	// RVA: 0x20AEDA0 Offset: 0x20AD3A0 VA: 0x1820AEDA0
	public static byte[] GZipDecompressBytes(byte[] data) { }

	// RVA: 0x20AEA60 Offset: 0x20AD060 VA: 0x1820AEA60
	public static byte[] GZipCompressString(string data, Encoding encoding) { }

	// RVA: 0x20AF0A0 Offset: 0x20AD6A0 VA: 0x1820AF0A0
	public static string GZipDecompressString(byte[] data, Encoding encoding) { }

	// RVA: 0x20AF870 Offset: 0x20ADE70 VA: 0x1820AF870
	public static int WriteBytes(long value, byte[] array, int offset) { }

	// RVA: 0x20AF830 Offset: 0x20ADE30 VA: 0x1820AF830
	public static int WriteBytes(int value, byte[] array, int offset) { }
}
