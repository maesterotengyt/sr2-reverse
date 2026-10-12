// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(ChildEntity))]
[Serializable]
public class ChildEntity_Prototype : PrototypeAdapter<ChildEntity_Prototype> // TypeDefIndex: 3911
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public FPVector2 InitialPosition; // 0x18

	// Methods

	// RVA: 0x6727F0 Offset: 0x670DF0 VA: 0x1806727F0 Slot: 5
	public sealed override ChildEntity_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672880 Offset: 0x670E80 VA: 0x180672880
	public void .ctor() { }
}
