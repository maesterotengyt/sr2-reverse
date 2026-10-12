// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(SpeedRunnersItem))]
[Serializable]
public class SpeedRunnersItem_Prototype : PrototypeAdapter<SpeedRunnersItem_Prototype> // TypeDefIndex: 3926
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean DestroyOnRoundEnd; // 0x18

	// Methods

	// RVA: 0x682C10 Offset: 0x681210 VA: 0x180682C10 Slot: 5
	public sealed override SpeedRunnersItem_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x682CA0 Offset: 0x6812A0 VA: 0x180682CA0
	public void .ctor() { }
}
