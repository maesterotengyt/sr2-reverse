// Namespace: Quantum
public static class PrototypeValidator // TypeDefIndex: 11583
{
	// Methods

	// RVA: 0x21D6CF0 Offset: 0x21D52F0 VA: 0x1821D6CF0
	public static int CheckLength(Array array, int expectedLength, in PrototypeMaterializationContext context) { }

	// RVA: 0x21D6F40 Offset: 0x21D5540 VA: 0x1821D6F40
	public static void ComponentOverwritten(EntityRef entity, ComponentPrototype componentPrototype, in PrototypeMaterializationContext context) { }

	// RVA: 0x21D7110 Offset: 0x21D5710 VA: 0x1821D7110
	public static void FindMapEntity(MapEntityId link, in PrototypeMaterializationContext context, out EntityRef result) { }

	// RVA: -1 Offset: -1
	public static void AssignQStringUtf8<T>(string str, int maxByteLength, in PrototypeMaterializationContext context, out T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC12570 Offset: 0xC10B70 VA: 0x180C12570
	|-PrototypeValidator.AssignQStringUtf8<QStringUtf8_64>
	|
	|-RVA: 0xC12390 Offset: 0xC10990 VA: 0x180C12390
	|-PrototypeValidator.AssignQStringUtf8<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void AssignQString<T>(string str, int maxByteLength, in PrototypeMaterializationContext context, out T qstr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC129B0 Offset: 0xC10FB0 VA: 0x180C129B0
	|-PrototypeValidator.AssignQString<QString128>
	|
	|-RVA: 0xC12C40 Offset: 0xC11240 VA: 0x180C12C40
	|-PrototypeValidator.AssignQString<QString256>
	|
	|-RVA: 0xC12EB0 Offset: 0xC114B0 VA: 0x180C12EB0
	|-PrototypeValidator.AssignQString<QString64>
	|
	|-RVA: 0xC127D0 Offset: 0xC10DD0 VA: 0x180C127D0
	|-PrototypeValidator.AssignQString<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void AddToDictionary<K, V>(QDictionary<K, V> dict, K key, V value, in PrototypeMaterializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC11E00 Offset: 0xC10400 VA: 0x180C11E00
	|-PrototypeValidator.AddToDictionary<int, CustomSubAnimatorPlayableClipInfo>
	|
	|-RVA: 0xC11FD0 Offset: 0xC105D0 VA: 0x180C11FD0
	|-PrototypeValidator.AddToDictionary<int, MoveLimit>
	|
	|-RVA: 0xC12170 Offset: 0xC10770 VA: 0x180C12170
	|-PrototypeValidator.AddToDictionary<QString128, FP>
	|
	|-RVA: 0xC11BD0 Offset: 0xC101D0 VA: 0x180C11BD0
	|-PrototypeValidator.AddToDictionary<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}
