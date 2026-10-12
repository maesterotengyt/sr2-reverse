// Namespace: Photon.Realtime
[Extension]
public static class Extensions // TypeDefIndex: 3954
{
	// Fields
	private static readonly List<object> keysWithNullValue; // 0x0

	// Methods

	[Extension]
	// RVA: 0x675B70 Offset: 0x674170 VA: 0x180675B70
	public static void Merge(IDictionary target, IDictionary addHash) { }

	[Extension]
	// RVA: 0x675900 Offset: 0x673F00 VA: 0x180675900
	public static void MergeStringKeys(IDictionary target, IDictionary addHash) { }

	[Extension]
	// RVA: 0x676A50 Offset: 0x675050 VA: 0x180676A50
	public static string ToStringFull(IDictionary origin) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static string ToStringFull<T>(List<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB44EC0 Offset: 0xB434C0 VA: 0x180B44EC0
	|-Extensions.ToStringFull<int>
	|
	|-RVA: 0xB44D10 Offset: 0xB43310 VA: 0x180B44D10
	|-Extensions.ToStringFull<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x676AA0 Offset: 0x6750A0 VA: 0x180676AA0
	public static string ToStringFull(object[] data) { }

	[Extension]
	// RVA: 0x676690 Offset: 0x674C90 VA: 0x180676690
	public static Hashtable StripToStringKeys(IDictionary original) { }

	[Extension]
	// RVA: 0x6768F0 Offset: 0x674EF0 VA: 0x1806768F0
	public static Hashtable StripToStringKeys(Hashtable original) { }

	[Extension]
	// RVA: 0x6761C0 Offset: 0x6747C0 VA: 0x1806761C0
	public static void StripKeysWithNullValues(IDictionary original) { }

	[Extension]
	// RVA: 0x675E80 Offset: 0x674480 VA: 0x180675E80
	public static void StripKeysWithNullValues(Hashtable original) { }

	[Extension]
	// RVA: 0x6758B0 Offset: 0x673EB0 VA: 0x1806758B0
	public static bool Contains(int[] target, int nr) { }

	// RVA: 0x676BA0 Offset: 0x6751A0 VA: 0x180676BA0
	private static void .cctor() { }
}
