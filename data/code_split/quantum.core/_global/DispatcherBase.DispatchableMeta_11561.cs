// Namespace: 
protected abstract class DispatcherBase.DispatchableMeta // TypeDefIndex: 11561
{
	// Fields
	public readonly List<DispatchableFilter> Filters; // 0x10
	public readonly List<uint> Flags; // 0x18
	public readonly List<Delegate> Handlers; // 0x20
	public readonly List<object> Listeners; // 0x28
	private readonly List<uint> SubscriptionIDs; // 0x30
	public uint InvocationCount; // 0x38
	public bool NeedsCleanup; // 0x3C
	private uint _version; // 0x40

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x21CA9D0 Offset: 0x21C8FD0 VA: 0x1821CA9D0
	public int get_Count() { }

	// RVA: -1 Offset: -1
	public static DispatcherBase.DispatchableMeta Create<TDispatchable>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE5370 Offset: 0xCE3970 VA: 0x180CE5370
	|-DispatcherBase.DispatchableMeta.Create<object>
	|
	|-RVA: 0xCE5310 Offset: 0xCE3910 VA: 0x180CE5310
	|-DispatcherBase.DispatchableMeta.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21CA030 Offset: 0x21C8630 VA: 0x1821CA030
	public uint Add(object listener, Delegate handler, DispatchableFilter filter, uint flags) { }

	// RVA: 0x21CA2C0 Offset: 0x21C88C0 VA: 0x1821CA2C0
	public void Clear() { }

	// RVA: 0x21CA3E0 Offset: 0x21C89E0 VA: 0x1821CA3E0
	public void NullifyAt(int i) { }

	// RVA: 0x21CA5B0 Offset: 0x21C8BB0 VA: 0x1821CA5B0
	public bool Remove(uint id) { }

	// RVA: 0x21CA690 Offset: 0x21C8C90 VA: 0x1821CA690
	public bool Remove(Delegate handler, object listener) { }

	// RVA: 0x21CA4D0 Offset: 0x21C8AD0 VA: 0x1821CA4D0
	public void RemoveAt(int i) { }

	// RVA: 0x21CA7B0 Offset: 0x21C8DB0 VA: 0x1821CA7B0
	public void SetFlag(int i, uint flag, bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void InvokeSingle(Delegate handler, IDispatchable e);

	// RVA: 0x21CA850 Offset: 0x21C8E50 VA: 0x1821CA850
	protected void .ctor() { }
}
