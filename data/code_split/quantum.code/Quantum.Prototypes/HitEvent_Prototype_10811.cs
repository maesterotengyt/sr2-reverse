// Namespace: Quantum.Prototypes
[Prototype(typeof(HitEvent))]
[Serializable]
public sealed class HitEvent_Prototype : StructPrototype // TypeDefIndex: 10811
{
	// Fields
	public HitType_Prototype HitType; // 0x10
	public MapEntityId PlayerOwner; // 0x14

	// Methods

	// RVA: 0x21071B0 Offset: 0x21057B0 VA: 0x1821071B0
	public void Materialize(Frame frame, ref HitEvent result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
