// Namespace: Quantum
public abstract class DispatcherBase // TypeDefIndex: 11563
{
	// Fields
	private readonly Dictionary<Type, int> _typeToIndex; // 0x10
	private readonly DispatcherBase.DispatchableMeta[] _metaEntries; // 0x18
	[CompilerGenerated]
	private DispatcherBase <Next>k__BackingField; // 0x20

	// Properties
	public DispatcherBase Next { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public DispatcherBase get_Next() { }

	// RVA: 0x21CB570 Offset: 0x21C9B70 VA: 0x1821CB570
	protected void .ctor(Dictionary<Type, int> typeToIndex) { }

	// RVA: -1 Offset: -1
	protected int GetIndex<TDispatchable>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0DFC0 Offset: 0xB0C5C0 VA: 0x180B0DFC0
	|-DispatcherBase.GetIndex<object>
	|-DispatcherBase.GetIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public DispatcherSubscription Subscribe<TDispatchable>(object listener, DispatchableHandler<TDispatchable> handler, bool once = False, uint flags = 0, DispatchableFilter filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E860 Offset: 0xB0CE60 VA: 0x180B0E860
	|-DispatcherBase.Subscribe<object>
	|
	|-RVA: 0xB0E7D0 Offset: 0xB0CDD0 VA: 0x180B0E7D0
	|-DispatcherBase.Subscribe<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21CB560 Offset: 0x21C9B60 VA: 0x1821CB560
	public bool Unsubscribe(DispatcherSubscription subscription) { }

	// RVA: -1 Offset: -1
	public bool UnsubscribeListener<TDispatchable>(object listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E960 Offset: 0xB0CF60 VA: 0x180B0E960
	|-DispatcherBase.UnsubscribeListener<object>
	|
	|-RVA: 0xB0E900 Offset: 0xB0CF00 VA: 0x180B0E900
	|-DispatcherBase.UnsubscribeListener<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public IDisposable SubscribeManual<TDispatchable>(DispatchableHandler<TDispatchable> handler, bool once = False, DispatchableFilter filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E6E0 Offset: 0xB0CCE0 VA: 0x180B0E6E0
	|-DispatcherBase.SubscribeManual<object>
	|
	|-RVA: 0xB0E5F0 Offset: 0xB0CBF0 VA: 0x180B0E5F0
	|-DispatcherBase.SubscribeManual<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public IDisposable SubscribeManual<TDispatchable>(object listener, DispatchableHandler<TDispatchable> handler, bool once = False, DispatchableFilter filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E660 Offset: 0xB0CC60 VA: 0x180B0E660
	|-DispatcherBase.SubscribeManual<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21CAA10 Offset: 0x21C9010 VA: 0x1821CAA10
	public void Clear() { }

	// RVA: 0x21CAFC0 Offset: 0x21C95C0 VA: 0x1821CAFC0
	public void RemoveDeadListners() { }

	// RVA: 0x21CB420 Offset: 0x21C9A20 VA: 0x1821CB420
	public bool UnsubscribeListener(object listener) { }

	// RVA: 0x1E29C10 Offset: 0x1E28210 VA: 0x181E29C10
	protected static bool CheckFlag(uint flags, uint flag) { }

	// RVA: 0x21CAA70 Offset: 0x21C9070 VA: 0x1821CAA70 Slot: 4
	protected virtual DispatcherBase.ListenerStatus GetListenerStatus(object listener, uint flags) { }

	// RVA: 0x21CAA80 Offset: 0x21C9080 VA: 0x1821CAA80
	protected bool InvokeMeta(int metaIndex, IDispatchable e) { }

	// RVA: -1 Offset: -1
	protected DispatcherSubscription SubscribeInternal<TDispatchable>(int metaIndex, object listener, DispatchableHandler<TDispatchable> handler, DispatchableFilter filter, uint flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E250 Offset: 0xB0C850 VA: 0x180B0E250
	|-DispatcherBase.SubscribeInternal<object>
	|
	|-RVA: 0xB0E050 Offset: 0xB0C650 VA: 0x180B0E050
	|-DispatcherBase.SubscribeInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected IDisposable SubscribeManualInternal<TDispatchable>(object listener, int metaIndex, DispatchableHandler<TDispatchable> handler, DispatchableFilter filter, bool once) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E520 Offset: 0xB0CB20 VA: 0x180B0E520
	|-DispatcherBase.SubscribeManualInternal<object>
	|
	|-RVA: 0xB0E450 Offset: 0xB0CA50 VA: 0x180B0E450
	|-DispatcherBase.SubscribeManualInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21CB1B0 Offset: 0x21C97B0 VA: 0x1821CB1B0
	protected bool UnsubscribeInternal(int metaIndex, object listener, Delegate handler) { }

	// RVA: 0x21CB310 Offset: 0x21C9910 VA: 0x1821CB310
	protected bool UnsubscribeInternal(int metaIndex, uint subscriptionId) { }

	// RVA: 0x21CB030 Offset: 0x21C9630 VA: 0x1821CB030
	private void RemoveDeadListners(DispatcherBase.DispatchableMeta meta) { }
}
