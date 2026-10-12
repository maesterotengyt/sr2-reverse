// Namespace: Quantum
[Extension]
public static class ReflectionUtils // TypeDefIndex: 3860
{
	// Fields
	public const BindingFlags DefaultBindingFlags = 60;

	// Methods

	[Extension]
	// RVA: 0x66B710 Offset: 0x669D10 VA: 0x18066B710
	public static Type GetUnityLeafType(Type type) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T CreateMethodDelegate<T>(Type type, string methodName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20E90 Offset: 0xC1F490 VA: 0x180C20E90
	|-ReflectionUtils.CreateMethodDelegate<object>
	*/

	[Extension]
	// RVA: 0x669560 Offset: 0x667B60 VA: 0x180669560
	public static Delegate CreateMethodDelegate(Type type, string methodName, BindingFlags flags, Type delegateType) { }

	// RVA: -1 Offset: -1
	public static T CreateMethodDelegate<T>(Assembly assembly, string typeName, string methodName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20FB0 Offset: 0xC1F5B0 VA: 0x180C20FB0
	|-ReflectionUtils.CreateMethodDelegate<object>
	*/

	// RVA: 0x669570 Offset: 0x667B70 VA: 0x180669570
	public static Delegate CreateMethodDelegate(Assembly assembly, string typeName, string methodName, BindingFlags flags, Type delegateType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T CreateMethodDelegate<T>(Type type, string methodName, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] fallbackSwizzles) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20560 Offset: 0xC1EB60 VA: 0x180C20560
	|-ReflectionUtils.CreateMethodDelegate<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T CreateConstructorDelegate<T>(Type type, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] fallbackSwizzles) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1FBA0 Offset: 0xC1E1A0 VA: 0x180C1FBA0
	|-ReflectionUtils.CreateConstructorDelegate<object>
	*/

	[Extension]
	// RVA: 0x66A500 Offset: 0x668B00 VA: 0x18066A500
	public static FieldInfo GetFieldOrThrow(Type type, string fieldName, BindingFlags flags = 60) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static FieldInfo GetFieldOrThrow<T>(Type type, string fieldName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC22140 Offset: 0xC20740 VA: 0x180C22140
	|-ReflectionUtils.GetFieldOrThrow<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x66A600 Offset: 0x668C00 VA: 0x18066A600
	public static FieldInfo GetFieldOrThrow(Type type, string fieldName, Type fieldType, BindingFlags flags = 60) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static PropertyInfo GetPropertyOrThrow<T>(Type type, string propertyName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC221B0 Offset: 0xC207B0 VA: 0x180C221B0
	|-ReflectionUtils.GetPropertyOrThrow<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x66B4B0 Offset: 0x669AB0 VA: 0x18066B4B0
	public static PropertyInfo GetPropertyOrThrow(Type type, string propertyName, Type propertyType, BindingFlags flags = 60) { }

	[Extension]
	// RVA: 0x669CB0 Offset: 0x6682B0 VA: 0x180669CB0
	public static ConstructorInfo GetConstructorInfoOrThrow(Type type, Type[] types, BindingFlags flags = 60) { }

	[Extension]
	// RVA: 0x66B3A0 Offset: 0x6699A0 VA: 0x18066B3A0
	public static Type GetNestedTypeOrThrow(Type type, string name, BindingFlags flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.InstanceAccessor<FieldType> CreateFieldAccessor<FieldType>(Type type, string fieldName, Type expectedFieldType, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC203F0 Offset: 0xC1E9F0 VA: 0x180C203F0
	|-ReflectionUtils.CreateFieldAccessor<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x6698C0 Offset: 0x667EC0 VA: 0x1806698C0
	public static ReflectionUtils.StaticAccessor<object> CreateStaticFieldAccessor(Type type, string fieldName, Type expectedFieldType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.StaticAccessor<FieldType> CreateStaticFieldAccessor<FieldType>(Type type, string fieldName, Type expectedFieldType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC21BA0 Offset: 0xC201A0 VA: 0x180C21BA0
	|-ReflectionUtils.CreateStaticFieldAccessor<object>
	|
	|-RVA: 0xC21AF0 Offset: 0xC200F0 VA: 0x180C21AF0
	|-ReflectionUtils.CreateStaticFieldAccessor<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.InstanceAccessor<PropertyType> CreatePropertyAccessor<PropertyType>(Type type, string fieldName, Type expectedPropertyType, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC21150 Offset: 0xC1F750 VA: 0x180C21150
	|-ReflectionUtils.CreatePropertyAccessor<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x669930 Offset: 0x667F30 VA: 0x180669930
	public static ReflectionUtils.StaticAccessor<object> CreateStaticPropertyAccessor(Type type, string fieldName, Type expectedFieldType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.StaticAccessor<FieldType> CreateStaticPropertyAccessor<FieldType>(Type type, string fieldName, Type expectedFieldType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC21D00 Offset: 0xC20300 VA: 0x180C21D00
	|-ReflectionUtils.CreateStaticPropertyAccessor<object>
	|
	|-RVA: 0xC21C50 Offset: 0xC20250 VA: 0x180C21C50
	|-ReflectionUtils.CreateStaticPropertyAccessor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static string CreateMethodExceptionMessage<T>(Assembly assembly, string typeName, string methodName, BindingFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC210D0 Offset: 0xC1F6D0 VA: 0x180C210D0
	|-ReflectionUtils.CreateMethodExceptionMessage<object>
	|-ReflectionUtils.CreateMethodExceptionMessage<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x669670 Offset: 0x667C70 VA: 0x180669670
	private static string CreateMethodExceptionMessage(Assembly assembly, string typeName, string methodName, BindingFlags flags, Type delegateType) { }

	// RVA: 0x669270 Offset: 0x667870 VA: 0x180669270
	private static string CreateFieldExceptionMessage(Assembly assembly, string typeName, string fieldName, BindingFlags flags) { }

	// RVA: 0x668EC0 Offset: 0x6674C0 VA: 0x180668EC0
	private static string CreateConstructorExceptionMessage(Assembly assembly, string typeName, BindingFlags flags) { }

	// RVA: 0x668F70 Offset: 0x667570 VA: 0x180668F70
	private static string CreateConstructorExceptionMessage(Assembly assembly, string typeName, Type[] types, BindingFlags flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	private static T CreateMethodDelegateInternal<T>(Type type, string name, BindingFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC204A0 Offset: 0xC1EAA0 VA: 0x180C204A0
	|-ReflectionUtils.CreateMethodDelegateInternal<object>
	*/

	[Extension]
	// RVA: 0x669460 Offset: 0x667A60 VA: 0x180669460
	private static Delegate CreateMethodDelegateInternal(Type type, string name, BindingFlags flags, Type delegateType) { }

	// RVA: 0x66B2B0 Offset: 0x6698B0 VA: 0x18066B2B0
	private static MethodInfo GetMethodOrThrow(Type type, string name, BindingFlags flags, Type delegateType) { }

	// RVA: 0x6699A0 Offset: 0x667FA0 VA: 0x1806699A0
	private static MethodInfo FindMethod(Type type, string name, BindingFlags flags, Type returnType, Type[] parameters) { }

	// RVA: 0x669DF0 Offset: 0x6683F0 VA: 0x180669DF0
	private static ConstructorInfo GetConstructorOrThrow(Type type, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] swizzles, out ReflectionUtils.DelegateSwizzle firstMatchingSwizzle) { }

	// RVA: 0x66A9B0 Offset: 0x668FB0 VA: 0x18066A9B0
	private static MethodInfo GetMethodOrThrow(Type type, string name, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] swizzles, out ReflectionUtils.DelegateSwizzle firstMatchingSwizzle) { }

	[Extension]
	// RVA: 0x66B820 Offset: 0x669E20 VA: 0x18066B820
	public static bool IsArrayOrList(Type listType) { }

	[Extension]
	// RVA: 0x669BA0 Offset: 0x6681A0 VA: 0x180669BA0
	public static Type GetArrayOrListElementType(Type listType) { }

	// RVA: 0x66BAC0 Offset: 0x66A0C0 VA: 0x18066BAC0
	public static Type MakeFuncType(Type[] types) { }

	// RVA: 0x66A870 Offset: 0x668E70 VA: 0x18066A870
	private static Type GetFuncType(int argumentCount) { }

	// RVA: 0x66B8F0 Offset: 0x669EF0 VA: 0x18066B8F0
	public static Type MakeActionType(Type[] types) { }

	// RVA: 0x669A60 Offset: 0x668060 VA: 0x180669A60
	private static Type GetActionType(int argumentCount) { }

	// RVA: -1 Offset: -1
	private static ReflectionUtils.StaticAccessor<T> CreateStaticAccessorInternal<T>(MemberInfo fieldOrProperty) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC21690 Offset: 0xC1FC90 VA: 0x180C21690
	|-ReflectionUtils.CreateStaticAccessorInternal<object>
	|
	|-RVA: 0xC21200 Offset: 0xC1F800 VA: 0x180C21200
	|-ReflectionUtils.CreateStaticAccessorInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static ReflectionUtils.InstanceAccessor<T> CreateAccessorInternal<T>(MemberInfo fieldOrProperty) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1F600 Offset: 0xC1DC00 VA: 0x180C1F600
	|-ReflectionUtils.CreateAccessorInternal<__Il2CppFullySharedGenericType>
	*/
}
