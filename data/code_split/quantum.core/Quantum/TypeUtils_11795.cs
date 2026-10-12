// Namespace: Quantum
[Extension]
public static class TypeUtils // TypeDefIndex: 11795
{
	// Methods

	[IteratorStateMachine(typeof(TypeUtils.<GetSubClasses>d__0))]
	[Extension]
	// RVA: 0x222E620 Offset: 0x222CC20 VA: 0x18222E620
	public static IEnumerable<Type> GetSubClasses(Type type, string[] assemblies) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC92120 Offset: 0xC90720 VA: 0x180C92120
	|-TypeUtils.GetAttribute<object>
	*/

	// RVA: 0x222E1E0 Offset: 0x222C7E0 VA: 0x18222E1E0
	public static Type FindType(string typeName) { }

	[Extension]
	// RVA: 0x222E460 Offset: 0x222CA60 VA: 0x18222E460
	public static IEnumerable<Type> GetLoadableTypes(Assembly assembly) { }
}
