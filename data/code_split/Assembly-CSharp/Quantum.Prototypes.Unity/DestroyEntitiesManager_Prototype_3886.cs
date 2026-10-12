// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(DestroyEntitiesManager))]
[Serializable]
public class DestroyEntitiesManager_Prototype : PrototypeAdapter<DestroyEntitiesManager_Prototype> // TypeDefIndex: 3886
{
	// Fields
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] EntitiesToDestroy; // 0x10

	// Methods

	// RVA: 0x674F60 Offset: 0x673560 VA: 0x180674F60 Slot: 5
	public sealed override DestroyEntitiesManager_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x675080 Offset: 0x673680 VA: 0x180675080
	public void .ctor() { }
}
