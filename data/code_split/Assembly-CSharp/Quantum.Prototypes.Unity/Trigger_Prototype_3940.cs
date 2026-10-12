// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Trigger))]
[Serializable]
public class Trigger_Prototype : PrototypeAdapter<Trigger_Prototype> // TypeDefIndex: 3940
{
	// Fields
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
	[HideInInspector]
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] BodiesInTrigger; // 0x20
	[HideInInspector]
	[LocalReference]
	public EntityPrototype TriggerEnterEntity; // 0x28
	[HideInInspector]
	[LocalReference]
	public EntityPrototype TriggerExitEntity; // 0x30

	// Methods

	// RVA: 0x683AC0 Offset: 0x6820C0 VA: 0x180683AC0 Slot: 5
	public sealed override Trigger_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x683C50 Offset: 0x682250 VA: 0x180683C50
	public void .ctor() { }
}
