// Namespace: Quantum.Prototypes
[Prototype(typeof(InputValue))]
[Serializable]
public sealed class InputValue_Prototype : StructPrototype // TypeDefIndex: 10817
{
	// Fields
	public InputFlag_Prototype InputFlag; // 0x10
	public InputFlag_Prototype IgnoreFlag; // 0x14
	public FP LeftStickX; // 0x18
	public QBoolean LeftStickXSpent; // 0x20
	public FP LeftStickY; // 0x28
	public QBoolean LeftStickYSpent; // 0x30

	// Methods

	// RVA: 0x2107AE0 Offset: 0x21060E0 VA: 0x182107AE0
	public void Materialize(Frame frame, ref InputValue result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
