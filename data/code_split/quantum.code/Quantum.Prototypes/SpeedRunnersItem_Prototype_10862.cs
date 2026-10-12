// Namespace: Quantum.Prototypes
[Prototype(typeof(SpeedRunnersItem))]
[Serializable]
public sealed class SpeedRunnersItem_Prototype : ComponentPrototype<SpeedRunnersItem> // TypeDefIndex: 10862
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean DestroyOnRoundEnd; // 0x1C

	// Methods

	// RVA: 0x210FC20 Offset: 0x210E220 VA: 0x18210FC20 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210FD90 Offset: 0x210E390 VA: 0x18210FD90
	public void Materialize(Frame frame, ref SpeedRunnersItem result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210FD00 Offset: 0x210E300 VA: 0x18210FD00 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210FDB0 Offset: 0x210E3B0 VA: 0x18210FDB0
	public void .ctor() { }
}
