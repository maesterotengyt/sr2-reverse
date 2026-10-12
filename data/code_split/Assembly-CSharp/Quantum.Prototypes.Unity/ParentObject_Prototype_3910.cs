// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(ParentObject))]
[Serializable]
public class ParentObject_Prototype : PrototypeAdapter<ParentObject_Prototype> // TypeDefIndex: 3910
{
	// Fields
	[LocalReference]
	public EntityPrototype ParentEntity; // 0x10
	[DynamicCollection]
	public ChildEntity_Prototype[] ChildEntities; // 0x18

	// Methods

	// RVA: 0x67BB20 Offset: 0x67A120 VA: 0x18067BB20 Slot: 5
	public sealed override ParentObject_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x67BC60 Offset: 0x67A260 VA: 0x18067BC60
	public void .ctor() { }
}
