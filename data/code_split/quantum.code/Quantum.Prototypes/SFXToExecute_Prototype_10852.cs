// Namespace: Quantum.Prototypes
[Prototype(typeof(SFXToExecute))]
[Serializable]
public sealed class SFXToExecute_Prototype : StructPrototype // TypeDefIndex: 10852
{
	// Fields
	[MaxStringByteCount(254, "Unicode")]
	public string EventID; // 0x10
	public FP Delay; // 0x18

	// Methods

	// RVA: 0x210DBC0 Offset: 0x210C1C0 VA: 0x18210DBC0
	public void Materialize(Frame frame, ref SFXToExecute result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
