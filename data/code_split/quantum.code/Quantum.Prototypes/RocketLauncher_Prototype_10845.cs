// Namespace: Quantum.Prototypes
[Prototype(typeof(RocketLauncher))]
[Serializable]
public sealed class RocketLauncher_Prototype : ComponentPrototype<RocketLauncher> // TypeDefIndex: 10845
{
	// Fields
	public MapEntityId Target; // 0x18
	public FP ShootCooldownFrames; // 0x20

	// Methods

	// RVA: 0x210D440 Offset: 0x210BA40 VA: 0x18210D440 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D5B0 Offset: 0x210BBB0 VA: 0x18210D5B0
	public void Materialize(Frame frame, ref RocketLauncher result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D520 Offset: 0x210BB20 VA: 0x18210D520 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210D5D0 Offset: 0x210BBD0 VA: 0x18210D5D0
	public void .ctor() { }
}
