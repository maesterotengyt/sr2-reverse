// Namespace: Quantum.Prototypes
[Prototype(typeof(CampaignBoss))]
[Serializable]
public sealed class CampaignBoss_Prototype : ComponentPrototype<CampaignBoss> // TypeDefIndex: 10763
{
	// Fields
	public QString64 BossID; // 0x18

	// Methods

	// RVA: 0x20FDA30 Offset: 0x20FC030 VA: 0x1820FDA30 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FDB90 Offset: 0x20FC190 VA: 0x1820FDB90
	public void Materialize(Frame frame, ref CampaignBoss result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FDB00 Offset: 0x20FC100 VA: 0x1820FDB00 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FDBC0 Offset: 0x20FC1C0 VA: 0x1820FDBC0
	public void .ctor() { }
}
