// Namespace: Quantum
public static class Assert // TypeDefIndex: 11781
{
	// Methods

	[DoesNotReturn]
	// RVA: 0x2221F60 Offset: 0x2220560 VA: 0x182221F60
	public static void Fail() { }

	// RVA: 0x2221EB0 Offset: 0x22204B0 VA: 0x182221EB0
	public static void Always(bool condition) { }

	// RVA: 0x2221F00 Offset: 0x2220500 VA: 0x182221F00
	public static void Always(bool condition, string message) { }

	// RVA: -1 Offset: -1
	public static void Always<T0>(bool condition, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA99960 Offset: 0xA97F60 VA: 0x180A99960
	|-Assert.Always<int>
	|
	|-RVA: 0xA99850 Offset: 0xA97E50 VA: 0x180A99850
	|-Assert.Always<__Il2CppFullySharedGenericType>
	*/
}
