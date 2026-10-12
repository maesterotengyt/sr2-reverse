// Namespace: Quantum.Prototypes
[Prototype(typeof(PlayerManager))]
[Serializable]
public sealed class PlayerManager_Prototype : ComponentPrototype<PlayerManager> // TypeDefIndex: 10839
{
	// Fields
	public PlayerRef PlayerRef; // 0x18
	public QBoolean IsNPC; // 0x1C
	public int NPCID; // 0x20

	// Methods

	// RVA: 0x210C620 Offset: 0x210AC20 VA: 0x18210C620 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210C780 Offset: 0x210AD80 VA: 0x18210C780
	public void Materialize(Frame frame, ref PlayerManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210C6F0 Offset: 0x210ACF0 VA: 0x18210C6F0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210C7A0 Offset: 0x210ADA0 VA: 0x18210C7A0
	public void .ctor() { }
}
