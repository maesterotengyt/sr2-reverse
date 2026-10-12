// Namespace: 
private sealed class GA_MiniJSON.Serializer // TypeDefIndex: 3794
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x66C920 Offset: 0x66AF20 VA: 0x18066C920
	private void .ctor() { }

	// RVA: 0x65AF30 Offset: 0x659530 VA: 0x18065AF30
	public static string Serialize(object obj) { }

	// RVA: 0x66C740 Offset: 0x66AD40 VA: 0x18066C740
	private void SerializeValue(object value) { }

	// RVA: 0x66BE90 Offset: 0x66A490 VA: 0x18066BE90
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x66BC40 Offset: 0x66A240 VA: 0x18066BC40
	private void SerializeArray(IList anArray) { }

	// RVA: 0x66C3F0 Offset: 0x66A9F0 VA: 0x18066C3F0
	private void SerializeString(string str) { }

	// RVA: 0x66C160 Offset: 0x66A760 VA: 0x18066C160
	private void SerializeOther(object value) { }
}
