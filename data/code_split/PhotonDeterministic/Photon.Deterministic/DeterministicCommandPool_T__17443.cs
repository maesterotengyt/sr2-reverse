// Namespace: Photon.Deterministic
public sealed class DeterministicCommandPool<T> : IDeterministicCommandFactory, IDeterministicCommandPool // TypeDefIndex: 17443
{
	// Fields
	private Stack<T> _pool; // 0x0

	// Properties
	public Type CommandType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public Type get_CommandType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD8B270 Offset: 0xD89870 VA: 0x180D8B270
	|-DeterministicCommandPool<object>.get_CommandType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public DeterministicCommand GetCommandInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EACE0 Offset: 0x17E92E0 VA: 0x1817EACE0
	|-DeterministicCommandPool<object>.GetCommandInstance
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DeterministicCommand Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EAC60 Offset: 0x17E9260 VA: 0x1817EAC60
	|-DeterministicCommandPool<object>.Acquire
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Release(DeterministicCommand cmd) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EAD70 Offset: 0x17E9370 VA: 0x1817EAD70
	|-DeterministicCommandPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EAE60 Offset: 0x17E9460 VA: 0x1817EAE60
	|-DeterministicCommandPool<object>..ctor
	*/
}
