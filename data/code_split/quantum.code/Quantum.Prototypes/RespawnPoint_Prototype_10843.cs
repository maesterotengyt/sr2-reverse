// Namespace: Quantum.Prototypes
[Prototype(typeof(RespawnPoint))]
[Serializable]
public sealed class RespawnPoint_Prototype : ComponentPrototype<RespawnPoint> // TypeDefIndex: 10843
{
	// Fields
	public QBoolean IsInitial; // 0x18
	public RespawnDirection_Prototype Direction; // 0x1C
	[HideInInspector]
	public MapEntityId NextCheckPoint; // 0x20

	// Methods

	// RVA: 0x210D270 Offset: 0x210B870 VA: 0x18210D270 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D3E0 Offset: 0x210B9E0 VA: 0x18210D3E0
	public void Materialize(Frame frame, ref RespawnPoint result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D350 Offset: 0x210B950 VA: 0x18210D350 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210D400 Offset: 0x210BA00 VA: 0x18210D400
	public void .ctor() { }
}
