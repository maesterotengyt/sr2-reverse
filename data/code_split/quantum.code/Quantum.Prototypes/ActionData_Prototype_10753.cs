// Namespace: Quantum.Prototypes
[Prototype(typeof(ActionData))]
[Serializable]
public sealed class ActionData_Prototype : StructPrototype // TypeDefIndex: 10753
{
	// Fields
	public InputFlag_Prototype Flag; // 0x10
	public FP Frames; // 0x18
	public QBoolean Overriden; // 0x20
	public FP FrameDelay; // 0x28

	// Methods

	// RVA: 0x20FC770 Offset: 0x20FAD70 VA: 0x1820FC770
	public void Materialize(Frame frame, ref ActionData result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
