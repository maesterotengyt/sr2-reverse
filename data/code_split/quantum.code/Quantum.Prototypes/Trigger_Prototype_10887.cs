// Namespace: Quantum.Prototypes
[Prototype(typeof(Trigger))]
[Serializable]
public sealed class Trigger_Prototype : ComponentPrototype<Trigger> // TypeDefIndex: 10887
{
	// Fields
	[HideInInspector]
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	[HideInInspector]
	[DynamicCollection]
	public MapEntityId[] BodiesInTrigger; // 0x20
	[HideInInspector]
	public MapEntityId TriggerEnterEntity; // 0x28
	[HideInInspector]
	public MapEntityId TriggerExitEntity; // 0x2C

	// Methods

	// RVA: 0x21140F0 Offset: 0x21126F0 VA: 0x1821140F0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2114280 Offset: 0x2112880 VA: 0x182114280
	public void Materialize(Frame frame, ref Trigger result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21141F0 Offset: 0x21127F0 VA: 0x1821141F0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2114450 Offset: 0x2112A50 VA: 0x182114450
	public void .ctor() { }
}
