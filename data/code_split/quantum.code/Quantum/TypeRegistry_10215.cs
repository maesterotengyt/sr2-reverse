// Namespace: Quantum
public class TypeRegistry // TypeDefIndex: 10215
{
	// Fields
	private readonly Dictionary<Type, int> _types; // 0x10

	// Properties
	public ReadOnlyDictionary<Type, int> Types { get; }

	// Methods

	// RVA: 0x2164550 Offset: 0x2162B50 VA: 0x182164550
	public ReadOnlyDictionary<Type, int> get_Types() { }

	// RVA: 0x21644C0 Offset: 0x2162AC0 VA: 0x1821644C0
	public void .ctor() { }

	// RVA: 0x2164430 Offset: 0x2162A30 VA: 0x182164430
	private void Register(Type type, int size) { }

	// RVA: 0x21605A0 Offset: 0x215EBA0 VA: 0x1821605A0
	private void AddBuiltIns() { }

	// RVA: 0x2160C10 Offset: 0x215F210 VA: 0x182160C10
	private void AddGenerated() { }
}
