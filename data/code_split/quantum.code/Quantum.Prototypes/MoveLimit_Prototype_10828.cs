// Namespace: Quantum.Prototypes
[Prototype(typeof(MoveLimit))]
[Serializable]
public sealed class MoveLimit_Prototype : StructPrototype // TypeDefIndex: 10828
{
	// Fields
	[HideInInspector]
	public int UsesAvailable; // 0x10
	public int MaxUses; // 0x14
	public QBoolean SpendGrounded; // 0x18
	public QBoolean SpendInAir; // 0x1C
	public QBoolean ResetOnHurt; // 0x20

	// Methods

	// RVA: 0x21096D0 Offset: 0x2107CD0 VA: 0x1821096D0
	public void Materialize(Frame frame, ref MoveLimit result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
