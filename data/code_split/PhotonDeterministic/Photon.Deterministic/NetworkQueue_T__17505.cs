// Namespace: Photon.Deterministic
internal class NetworkQueue<T> // TypeDefIndex: 17505
{
	// Fields
	private Queue<T> _eventsQueue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Push(T ev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11752E0 Offset: 0x11738E0 VA: 0x1811752E0
	|-NetworkQueue<object>.Push
	|
	|-RVA: 0x11753A0 Offset: 0x11739A0 VA: 0x1811753A0
	|-NetworkQueue<__Il2CppFullySharedGenericType>.Push
	|
	|-RVA: 0x11754F0 Offset: 0x1173AF0 VA: 0x1811754F0
	|-NetworkQueue<DeterministicNetwork.NetworkEvent>.Push
	*/

	// RVA: -1 Offset: -1
	public bool TryPop(out T ev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11758E0 Offset: 0x1173EE0 VA: 0x1811758E0
	|-NetworkQueue<object>.TryPop
	|
	|-RVA: 0x11755D0 Offset: 0x1173BD0 VA: 0x1811755D0
	|-NetworkQueue<__Il2CppFullySharedGenericType>.TryPop
	|
	|-RVA: 0x11757A0 Offset: 0x1173DA0 VA: 0x1811757A0
	|-NetworkQueue<DeterministicNetwork.NetworkEvent>.TryPop
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1175A70 Offset: 0x1174070 VA: 0x181175A70
	|-NetworkQueue<object>..ctor
	|-NetworkQueue<DeterministicNetwork.NetworkEvent>..ctor
	|
	|-RVA: 0x11759E0 Offset: 0x1173FE0 VA: 0x1811759E0
	|-NetworkQueue<__Il2CppFullySharedGenericType>..ctor
	*/
}
