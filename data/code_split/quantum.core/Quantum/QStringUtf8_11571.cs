// Namespace: Quantum
public static class QStringUtf8 // TypeDefIndex: 11571
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool AreEqual<T>(ref T qstr, object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1A520 Offset: 0xC18B20 VA: 0x180C1A520
	|-QStringUtf8.AreEqual<QStringUtf8_64>
	|
	|-RVA: 0xC1A450 Offset: 0xC18A50 VA: 0x180C1A450
	|-QStringUtf8.AreEqual<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21D8300 Offset: 0x21D6900 VA: 0x1821D8300
	public static bool CanHold(string str, int maxByteCount) { }

	// RVA: -1 Offset: -1
	public static int CompareOrdinal<T>(ref T qstr, byte* bytes, ushort byteCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1A620 Offset: 0xC18C20 VA: 0x180C1A620
	|-QStringUtf8.CompareOrdinal<QStringUtf8_64>
	|-QStringUtf8.CompareOrdinal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int CompareOrdinal<T>(ref T qstr, string str) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1A5F0 Offset: 0xC18BF0 VA: 0x180C1A5F0
	|-QStringUtf8.CompareOrdinal<QStringUtf8_64>
	|-QStringUtf8.CompareOrdinal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void ConstructFrom<T>(string str, int maxByteCount, out T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1A720 Offset: 0xC18D20 VA: 0x180C1A720
	|-QStringUtf8.ConstructFrom<QStringUtf8_64>
	|
	|-RVA: 0xC1A660 Offset: 0xC18C60 VA: 0x180C1A660
	|-QStringUtf8.ConstructFrom<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21D85F0 Offset: 0x21D6BF0 VA: 0x1821D85F0
	public static int GetFittingCharacterCount(string str, int maxByteCount) { }

	// RVA: 0x21D8600 Offset: 0x21D6C00 VA: 0x1821D8600
	public static int GetFittingCharacterCount(string str, int maxByteCount, out int actualByteCount) { }

	// RVA: -1 Offset: -1
	public static string GetString<T>(ref T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1AA40 Offset: 0xC19040 VA: 0x180C1AA40
	|-QStringUtf8.GetString<QStringUtf8_64>
	|-QStringUtf8.GetString<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static void ConstructNoByteCountCheck<T>(string str, int characterCount, int maxByteCount, out T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1A970 Offset: 0xC18F70 VA: 0x180C1A970
	|-QStringUtf8.ConstructNoByteCountCheck<QStringUtf8_64>
	|
	|-RVA: 0xC1A880 Offset: 0xC18E80 VA: 0x180C1A880
	|-QStringUtf8.ConstructNoByteCountCheck<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21D8290 Offset: 0x21D6890 VA: 0x1821D8290
	private static bool CanHoldBestCase(string str, int maxByteCount) { }

	// RVA: 0x21D82B0 Offset: 0x21D68B0 VA: 0x1821D82B0
	private static bool CanHoldWorstCase(string str, int maxByteCount) { }

	// RVA: 0x21D8460 Offset: 0x21D6A60 VA: 0x1821D8460
	private static int CompareOrdinal(byte* bytes, ushort byteCount, string s) { }

	// RVA: 0x21D83A0 Offset: 0x21D69A0 VA: 0x1821D83A0
	private static int CompareOrdinal(byte* a, ushort aCount, byte* b, ushort bCount) { }

	// RVA: 0x21D8610 Offset: 0x21D6C10 VA: 0x1821D8610
	private static int GetFittingCharacterCount(string str, int maxByteCount, int* actualByteCount) { }
}
