// Namespace: Quantum.Prototypes
[Prototype(typeof(ChildEntity))]
[Serializable]
public sealed class ChildEntity_Prototype : StructPrototype // TypeDefIndex: 10767
{
	// Fields
	public MapEntityId Entity; // 0x10
	[HideInInspector]
	public FPVector2 InitialPosition; // 0x18

	// Methods

	// RVA: 0x20FE7E0 Offset: 0x20FCDE0 VA: 0x1820FE7E0
	public void Materialize(Frame frame, ref ChildEntity result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
