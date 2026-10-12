// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(StageEntity))]
[Serializable]
public class StageEntity_Prototype : PrototypeAdapter<StageEntity_Prototype> // TypeDefIndex: 3908
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[MaxStringByteCount(126, "Unicode")]
	public string Id; // 0x18

	// Methods

	// RVA: 0x682F70 Offset: 0x681570 VA: 0x180682F70 Slot: 5
	public sealed override StageEntity_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x683010 Offset: 0x681610 VA: 0x180683010
	public void .ctor() { }
}
