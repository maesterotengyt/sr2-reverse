// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(EntityReferencesHandler))]
[Serializable]
public class EntityReferencesHandler_Prototype : PrototypeAdapter<EntityReferencesHandler_Prototype> // TypeDefIndex: 3894
{
	// Fields
	[DynamicCollection]
	public GameEntityReference_Prototype[] Entities; // 0x10

	// Methods

	// RVA: 0x675720 Offset: 0x673D20 VA: 0x180675720 Slot: 5
	public sealed override EntityReferencesHandler_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x675840 Offset: 0x673E40 VA: 0x180675840
	public void .ctor() { }
}
