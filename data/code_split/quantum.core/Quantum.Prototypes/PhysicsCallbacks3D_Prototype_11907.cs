// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsCallbacks3D))]
[Serializable]
public sealed class PhysicsCallbacks3D_Prototype : ComponentPrototype // TypeDefIndex: 11907
{
	// Fields
	public CallbackFlags_Wrapper CallbackFlags; // 0x18

	// Properties
	public override Type ComponentType { get; }

	// Methods

	// RVA: 0x227CC90 Offset: 0x227B290 VA: 0x18227CC90 Slot: 4
	public override Type get_ComponentType() { }

	// RVA: 0x227CAD0 Offset: 0x227B0D0 VA: 0x18227CAD0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227CC60 Offset: 0x227B260 VA: 0x18227CC60 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
