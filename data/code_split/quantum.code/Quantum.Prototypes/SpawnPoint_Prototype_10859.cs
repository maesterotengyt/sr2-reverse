// Namespace: Quantum.Prototypes
[Prototype(typeof(SpawnPoint))]
[Serializable]
public sealed class SpawnPoint_Prototype : ComponentPrototype<SpawnPoint> // TypeDefIndex: 10859
{
	// Fields
	[MaxStringByteCount(126, "Unicode")]
	public string ID; // 0x18
	public int Order; // 0x20
	public SpawnPointDirection_Prototype FacingDirection; // 0x24
	[HideInInspector]
	public FPVector2 Position; // 0x28

	// Methods

	// RVA: 0x210E260 Offset: 0x210C860 VA: 0x18210E260 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210E4E0 Offset: 0x210CAE0 VA: 0x18210E4E0
	public void Materialize(Frame frame, ref SpawnPoint result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210E450 Offset: 0x210CA50 VA: 0x18210E450 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210E560 Offset: 0x210CB60 VA: 0x18210E560
	public void .ctor() { }
}
