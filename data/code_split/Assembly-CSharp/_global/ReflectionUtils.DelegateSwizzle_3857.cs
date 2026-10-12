// Namespace: 
public class ReflectionUtils.DelegateSwizzle // TypeDefIndex: 3857
{
	// Fields
	public readonly int[] ArgumentsReorder; // 0x10
	public readonly Expression[] Converters; // 0x18
	public readonly Type[] Types; // 0x20

	// Properties
	public bool HasArgumentsReorder { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x674F50 Offset: 0x673550 VA: 0x180674F50
	public bool get_HasArgumentsReorder() { }

	// RVA: 0x674F30 Offset: 0x673530 VA: 0x180674F30
	public int get_Count() { }

	// RVA: 0x674EC0 Offset: 0x6734C0 VA: 0x180674EC0
	public void .ctor(Expression[] converters, Type[] types) { }

	// RVA: 0x674E60 Offset: 0x673460 VA: 0x180674E60
	public void .ctor(int[] argumentsReorder) { }

	// RVA: -1 Offset: -1
	public T[] Swizzle<T>(T[] inputTypes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE5220 Offset: 0xCE3820 VA: 0x180CE5220
	|-ReflectionUtils.DelegateSwizzle.Swizzle<object>
	|
	|-RVA: 0xCE5060 Offset: 0xCE3660 VA: 0x180CE5060
	|-ReflectionUtils.DelegateSwizzle.Swizzle<__Il2CppFullySharedGenericType>
	*/
}
