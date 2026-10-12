// Namespace: Quantum
[Extension]
public static class ArrayUtils // TypeDefIndex: 11779
{
	// Methods

	// RVA: -1 Offset: -1
	public static void Add<T>(ref T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA94270 Offset: 0xA92870 VA: 0x180A94270
	|-ArrayUtils.Add<int>
	|
	|-RVA: 0xA942F0 Offset: 0xA928F0 VA: 0x180A942F0
	|-ArrayUtils.Add<NavMeshLink>
	|
	|-RVA: 0xA943C0 Offset: 0xA929C0 VA: 0x180A943C0
	|-ArrayUtils.Add<NavMeshPortal>
	|
	|-RVA: 0xA94450 Offset: 0xA92A50 VA: 0x180A94450
	|-ArrayUtils.Add<object>
	|
	|-RVA: 0xA94110 Offset: 0xA92710 VA: 0x180A94110
	|-ArrayUtils.Add<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static B[] Map<A, B>(List<A> array, Func<A, B> map) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA94710 Offset: 0xA92D10 VA: 0x180A94710
	|-ArrayUtils.Map<object, ProfilerData>
	|
	|-RVA: 0xA944E0 Offset: 0xA92AE0 VA: 0x180A944E0
	|-ArrayUtils.Map<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] Slice<T>(T[] array, int slice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA94820 Offset: 0xA92E20 VA: 0x180A94820
	|-ArrayUtils.Slice<Sample>
	|-ArrayUtils.Slice<__Il2CppFullySharedGenericType>
	*/
}
