// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(GameEntityReference))]
[Serializable]
public class GameEntityReference_Prototype : PrototypeAdapter<GameEntityReference_Prototype> // TypeDefIndex: 3895
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QString64 OutputVariableID; // 0x18

	// Methods

	// RVA: 0x676E60 Offset: 0x675460 VA: 0x180676E60 Slot: 5
	public sealed override GameEntityReference_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x676F00 Offset: 0x675500 VA: 0x180676F00
	public void .ctor() { }
}
