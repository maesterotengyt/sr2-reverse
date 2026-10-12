// Namespace: 
[Extension]
public static class IQuantumUnityDispatcherExtensions // TypeDefIndex: 2353
{
	// Fields
	public const uint CustomFlag_IsUnityObject = 256;
	public const uint CustomFlag_OnlyIfActiveAndEnabled = 512;

	// Methods

	[Extension]
	// RVA: 0x5203F0 Offset: 0x51E9F0 VA: 0x1805203F0
	internal static DispatcherBase.ListenerStatus GetUnityListenerStatus(IQuantumUnityDispatcher _, object listener, uint flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	internal static DispatcherSubscription Subscribe<TDispatcher, T>(TDispatcher dispatcher, Object listener, DispatchableHandler<T> handler, bool once = False, bool onlyIfActiveAndEnabled = False, DispatchableFilter filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB720F0 Offset: 0xB706F0 VA: 0x180B720F0
	|-IQuantumUnityDispatcherExtensions.Subscribe<object, object>
	|
	|-RVA: 0xB72070 Offset: 0xB70670 VA: 0x180B72070
	|-IQuantumUnityDispatcherExtensions.Subscribe<object, __Il2CppFullySharedGenericType>
	*/
}
