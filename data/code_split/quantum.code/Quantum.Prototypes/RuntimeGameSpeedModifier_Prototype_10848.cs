// Namespace: Quantum.Prototypes
[Prototype(typeof(RuntimeGameSpeedModifier))]
[Serializable]
public sealed class RuntimeGameSpeedModifier_Prototype : StructPrototype // TypeDefIndex: 10848
{
	// Fields
	public int ID; // 0x10
	public FP Multiplier; // 0x18
	public QBoolean AlterSimulation; // 0x20
	public QBoolean AlterEngine; // 0x24

	// Methods

	// RVA: 0x210DA00 Offset: 0x210C000 VA: 0x18210DA00
	public void Materialize(Frame frame, ref RuntimeGameSpeedModifier result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
