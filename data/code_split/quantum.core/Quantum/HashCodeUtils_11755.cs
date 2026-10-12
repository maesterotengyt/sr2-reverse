// Namespace: Quantum
public class HashCodeUtils // TypeDefIndex: 11755
{
	// Methods

	// RVA: 0x1126C90 Offset: 0x1125290 VA: 0x181126C90
	public static int CombineHashCodes(int a, int b) { }

	// RVA: 0x1F590F0 Offset: 0x1F576F0 VA: 0x181F590F0
	public static int CombineHashCodes(int a, int b, int c) { }

	// RVA: 0x2224870 Offset: 0x2222E70 VA: 0x182224870
	public static int UInt64HashCode(ulong value) { }

	// RVA: -1 Offset: -1
	public static int GetArrayHashCode<T>(T* ptr, int length, int initialHash = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB5A4F0 Offset: 0xB58AF0 VA: 0x180B5A4F0
	|-HashCodeUtils.GetArrayHashCode<byte>
	|
	|-RVA: 0xB5A8E0 Offset: 0xB58EE0 VA: 0x180B5A8E0
	|-HashCodeUtils.GetArrayHashCode<ulong>
	|
	|-RVA: 0xB5A6B0 Offset: 0xB58CB0 VA: 0x180B5A6B0
	|-HashCodeUtils.GetArrayHashCode<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int GetArrayHashCode<T>(in FixedArray<T> arr, int initialHash = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB5A550 Offset: 0xB58B50 VA: 0x180B5A550
	|-HashCodeUtils.GetArrayHashCode<CustomAnimatorPlayableClipInfo>
	|
	|-RVA: 0xB5A880 Offset: 0xB58E80 VA: 0x180B5A880
	|-HashCodeUtils.GetArrayHashCode<Input>
	|
	|-RVA: 0xB5A7C0 Offset: 0xB58DC0 VA: 0x180B5A7C0
	|-HashCodeUtils.GetArrayHashCode<InputTimer>
	|
	|-RVA: 0xB5A820 Offset: 0xB58E20 VA: 0x180B5A820
	|-HashCodeUtils.GetArrayHashCode<InputValue>
	|
	|-RVA: 0xB5A5B0 Offset: 0xB58BB0 VA: 0x180B5A5B0
	|-HashCodeUtils.GetArrayHashCode<__Il2CppFullySharedGenericStructType>
	*/
}
