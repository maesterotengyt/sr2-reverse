// Namespace: Quantum.Prototypes
[Prototype(typeof(TargetStatePerEntity))]
[Serializable]
public sealed class TargetStatePerEntity_Prototype : StructPrototype // TypeDefIndex: 10881
{
	// Fields
	public GameEntityType_Prototype EntityType; // 0x10
	[MaxStringByteCount(62, "Unicode")]
	public string TargetState; // 0x18

	// Methods

	// RVA: 0x2113100 Offset: 0x2111700 VA: 0x182113100
	public void Materialize(Frame frame, ref TargetStatePerEntity result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
