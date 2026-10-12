// Namespace: Quantum
[IsReadOnly]
[DefaultMember("Item")]
public struct FixedArray<T> : IEquatable<FixedArray<T>> // TypeDefIndex: 11522
{
	// Fields
	public readonly byte* Buffer; // 0x0
	public readonly int Stride; // 0x0
	public readonly int Length; // 0x0

	// Properties
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C517E0 Offset: 0x1C4FDE0 VA: 0x181C517E0
	|-FixedArray<CustomAnimatorPlayableClipInfo>.get_Item
	|-FixedArray<Input>.get_Item
	|-FixedArray<InputTimer>.get_Item
	|-FixedArray<InputValue>.get_Item
	|-FixedArray<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(byte* buffer, int stride, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D97E0 Offset: 0x15D7DE0 VA: 0x1815D97E0
	|-FixedArray<CustomAnimatorPlayableClipInfo>..ctor
	|-FixedArray<Input>..ctor
	|-FixedArray<InputTimer>..ctor
	|-FixedArray<InputValue>..ctor
	|-FixedArray<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T* GetPointer(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C517E0 Offset: 0x1C4FDE0 VA: 0x181C517E0
	|-FixedArray<CustomAnimatorPlayableClipInfo>.GetPointer
	|-FixedArray<Input>.GetPointer
	|-FixedArray<InputTimer>.GetPointer
	|-FixedArray<InputValue>.GetPointer
	|-FixedArray<__Il2CppFullySharedGenericStructType>.GetPointer
	*/

	// RVA: -1 Offset: -1
	internal T* GetPointerNoChecks(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C517D0 Offset: 0x1C4FDD0 VA: 0x181C517D0
	|-FixedArray<CustomAnimatorPlayableClipInfo>.GetPointerNoChecks
	|-FixedArray<Input>.GetPointerNoChecks
	|-FixedArray<InputTimer>.GetPointerNoChecks
	|-FixedArray<InputValue>.GetPointerNoChecks
	|-FixedArray<__Il2CppFullySharedGenericStructType>.GetPointerNoChecks
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C51790 Offset: 0x1C4FD90 VA: 0x181C51790
	|-FixedArray<CustomAnimatorPlayableClipInfo>.GetHashCode
	|-FixedArray<Input>.GetHashCode
	|-FixedArray<InputTimer>.GetHashCode
	|-FixedArray<InputValue>.GetHashCode
	|-FixedArray<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(FixedArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C51780 Offset: 0x1C4FD80 VA: 0x181C51780
	|-FixedArray<CustomAnimatorPlayableClipInfo>.Equals
	|-FixedArray<Input>.Equals
	|-FixedArray<InputTimer>.Equals
	|-FixedArray<InputValue>.Equals
	|-FixedArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C516A0 Offset: 0x1C4FCA0 VA: 0x181C516A0
	|-FixedArray<CustomAnimatorPlayableClipInfo>.Equals
	|-FixedArray<Input>.Equals
	|-FixedArray<InputTimer>.Equals
	|-FixedArray<InputValue>.Equals
	|-FixedArray<__Il2CppFullySharedGenericStructType>.Equals
	*/
}
