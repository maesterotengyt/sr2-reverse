// Namespace: 
[Serializable]
public class QuantumProfilingClientInfo // TypeDefIndex: 2465
{
	// Fields
	public string ProfilerId; // 0x10
	public DeterministicSessionConfig Config; // 0x18
	public List<QuantumProfilingClientInfo.CustomProperty> Properties; // 0x20

	// Methods

	// RVA: 0x5325B0 Offset: 0x530BB0 VA: 0x1805325B0
	public void .ctor() { }

	// RVA: 0x532630 Offset: 0x530C30 VA: 0x180532630
	public void .ctor(string clientId, DeterministicSessionConfig config, DeterministicPlatformInfo platformInfo) { }

	// RVA: 0x5324B0 Offset: 0x530AB0 VA: 0x1805324B0
	public string GetProperty(string name, string defaultValue = "Unknown") { }

	// RVA: -1 Offset: -1
	private static QuantumProfilingClientInfo.CustomProperty CreateProperty<T>(string name, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1BDA0 Offset: 0xC1A3A0 VA: 0x180C1BDA0
	|-QuantumProfilingClientInfo.CreateProperty<int>
	|
	|-RVA: 0xC1BD20 Offset: 0xC1A320 VA: 0x180C1BD20
	|-QuantumProfilingClientInfo.CreateProperty<Int32Enum>
	|
	|-RVA: 0xC1BC40 Offset: 0xC1A240 VA: 0x180C1BC40
	|-QuantumProfilingClientInfo.CreateProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x532420 Offset: 0x530A20 VA: 0x180532420
	private static QuantumProfilingClientInfo.CustomProperty CreateProperty(string name, string value) { }
}
