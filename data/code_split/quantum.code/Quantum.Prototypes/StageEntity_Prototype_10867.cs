// Namespace: Quantum.Prototypes
[Prototype(typeof(StageEntity))]
[Serializable]
public sealed class StageEntity_Prototype : StructPrototype // TypeDefIndex: 10867
{
	// Fields
	public MapEntityId Entity; // 0x10
	[MaxStringByteCount(126, "Unicode")]
	public string Id; // 0x18

	// Methods

	// RVA: 0x21107B0 Offset: 0x210EDB0 VA: 0x1821107B0
	public void Materialize(Frame frame, ref StageEntity result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
