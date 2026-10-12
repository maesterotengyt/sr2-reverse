// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(SuperBoostVolume))]
[Serializable]
public class SuperBoostVolume_Prototype : PrototypeAdapter<SuperBoostVolume_Prototype> // TypeDefIndex: 3936
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public SuperBoostDirection_Prototype Direction; // 0x18

	// Methods

	// RVA: 0x6837D0 Offset: 0x681DD0 VA: 0x1806837D0 Slot: 5
	public sealed override SuperBoostVolume_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x683860 Offset: 0x681E60 VA: 0x180683860
	public void .ctor() { }
}
