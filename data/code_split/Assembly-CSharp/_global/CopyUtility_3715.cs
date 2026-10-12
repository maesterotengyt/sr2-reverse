// Namespace: 
[Extension]
public static class CopyUtility // TypeDefIndex: 3715
{
	// Fields
	private static readonly MethodInfo CloneMethod; // 0x0

	// Methods

	[Extension]
	// RVA: 0x63DE20 Offset: 0x63C420 VA: 0x18063DE20
	public static bool IsPrimitive(Type type) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T DeepCopy<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAF4540 Offset: 0xAF2B40 VA: 0x180AF4540
	|-CopyUtility.DeepCopy<CharacterViewerAnimationData>
	|
	|-RVA: 0xAF4840 Offset: 0xAF2E40 VA: 0x180AF4840
	|-CopyUtility.DeepCopy<object>
	|
	|-RVA: 0xAF4700 Offset: 0xAF2D00 VA: 0x180AF4700
	|-CopyUtility.DeepCopy<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x63D600 Offset: 0x63BC00 VA: 0x18063D600
	public static object DeepCopy(object originalObject) { }

	// RVA: 0x63D8D0 Offset: 0x63BED0 VA: 0x18063D8D0
	private static object InternalDeepCopy(object originalObject, IDictionary<object, object> visited) { }

	// RVA: 0x63DEB0 Offset: 0x63C4B0 VA: 0x18063DEB0
	private static void RecursiveCopyBaseTypePrivateFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect) { }

	// RVA: 0x63D480 Offset: 0x63BA80 VA: 0x18063D480
	private static void CopyFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect, BindingFlags bindingFlags = 116, Func<FieldInfo, bool> filter) { }

	[Extension]
	// RVA: 0x63D6E0 Offset: 0x63BCE0 VA: 0x18063D6E0
	public static void ForEach(Array array, Action<Array, int[]> action) { }

	// RVA: 0x63E0C0 Offset: 0x63C6C0 VA: 0x18063E0C0
	private static void .cctor() { }
}
