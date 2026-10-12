// Namespace: Quantum
public static class QString // TypeDefIndex: 11567
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool AreEqual<T>(ref T qstr, object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1AB70 Offset: 0xC19170 VA: 0x180C1AB70
	|-QString.AreEqual<QString128>
	|-QString.AreEqual<QString256>
	|-QString.AreEqual<QString64>
	|
	|-RVA: 0xC1AAA0 Offset: 0xC190A0 VA: 0x180C1AAA0
	|-QString.AreEqual<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21D8830 Offset: 0x21D6E30 VA: 0x1821D8830
	public static bool CanHold(string str, int maxByteCount) { }

	// RVA: -1 Offset: -1
	public static int CompareOrdinal<T>(ref T qstr, byte* bytes, ushort byteCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1AC40 Offset: 0xC19240 VA: 0x180C1AC40
	|-QString.CompareOrdinal<QString128>
	|-QString.CompareOrdinal<QString256>
	|-QString.CompareOrdinal<QString64>
	|-QString.CompareOrdinal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int CompareOrdinal<T>(ref T qstr, string str) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1AC80 Offset: 0xC19280 VA: 0x180C1AC80
	|-QString.CompareOrdinal<QString128>
	|-QString.CompareOrdinal<QString256>
	|-QString.CompareOrdinal<QString64>
	|-QString.CompareOrdinal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void ConstructFrom<T>(string str, int maxByteCount, out T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1AD70 Offset: 0xC19370 VA: 0x180C1AD70
	|-QString.ConstructFrom<QString128>
	|
	|-RVA: 0xC1AEF0 Offset: 0xC194F0 VA: 0x180C1AEF0
	|-QString.ConstructFrom<QString256>
	|
	|-RVA: 0xC1B060 Offset: 0xC19660 VA: 0x180C1B060
	|-QString.ConstructFrom<QString64>
	|
	|-RVA: 0xC1ACB0 Offset: 0xC192B0 VA: 0x180C1ACB0
	|-QString.ConstructFrom<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21D8A50 Offset: 0x21D7050 VA: 0x1821D8A50
	public static int GetFittingCharacterCount(string str, int maxByteCount) { }

	// RVA: -1 Offset: -1
	public static string GetString<T>(ref T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1B5B0 Offset: 0xC19BB0 VA: 0x180C1B5B0
	|-QString.GetString<QString128>
	|-QString.GetString<QString256>
	|-QString.GetString<QString64>
	|-QString.GetString<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static void ConstructNoByteCountCheck<T>(string str, int characterCount, int maxByteCount, out T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1B2D0 Offset: 0xC198D0 VA: 0x180C1B2D0
	|-QString.ConstructNoByteCountCheck<QString128>
	|
	|-RVA: 0xC1B3D0 Offset: 0xC199D0 VA: 0x180C1B3D0
	|-QString.ConstructNoByteCountCheck<QString256>
	|
	|-RVA: 0xC1B4C0 Offset: 0xC19AC0 VA: 0x180C1B4C0
	|-QString.ConstructNoByteCountCheck<QString64>
	|
	|-RVA: 0xC1B1D0 Offset: 0xC197D0 VA: 0x180C1B1D0
	|-QString.ConstructNoByteCountCheck<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21D88C0 Offset: 0x21D6EC0 VA: 0x1821D88C0
	private static int CompareOrdinal(byte* bytes, ushort byteCount, string s) { }

	// RVA: 0x21D8850 Offset: 0x21D6E50 VA: 0x1821D8850
	private static int CompareOrdinal(byte* a, ushort aCount, byte* b, ushort bCount) { }

	// RVA: 0x21D8940 Offset: 0x21D6F40 VA: 0x1821D8940
	private static int CompareOridinalNot4ByteAligned(char* a, int aa, char* b, int bb) { }

	// RVA: 0x21D89B0 Offset: 0x21D6FB0 VA: 0x1821D89B0
	private static int GetByteCount(string str) { }

	// RVA: 0x21D89C0 Offset: 0x21D6FC0 VA: 0x1821D89C0
	private static int GetCharCount(int byteCount) { }

	// RVA: 0x21D89D0 Offset: 0x21D6FD0 VA: 0x1821D89D0
	private static int GetFittingCharacterCount(string str, int maxByteCount, int* actualByteCount) { }
}
