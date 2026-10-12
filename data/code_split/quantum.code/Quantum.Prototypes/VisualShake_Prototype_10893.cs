// Namespace: Quantum.Prototypes
[Prototype(typeof(VisualShake))]
[Serializable]
public sealed class VisualShake_Prototype : ComponentPrototype<VisualShake> // TypeDefIndex: 10893
{
	// Fields
	public MapEntityId Entity; // 0x18
	public FP ShakeFrames; // 0x20
	public FP ShakePower; // 0x28
	public QBoolean ShakeHorizontally; // 0x30
	public QBoolean ShakeVertically; // 0x34

	// Methods

	// RVA: 0x21197D0 Offset: 0x2117DD0 VA: 0x1821197D0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2119960 Offset: 0x2117F60 VA: 0x182119960
	public void Materialize(Frame frame, ref VisualShake result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21198D0 Offset: 0x2117ED0 VA: 0x1821198D0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21199B0 Offset: 0x2117FB0 VA: 0x1821199B0
	public void .ctor() { }
}
