// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsCallbacks2D))]
[Serializable]
public sealed class PhysicsCallbacks2D_Prototype : ComponentPrototype // TypeDefIndex: 11906
{
	// Fields
	public CallbackFlags_Wrapper CallbackFlags; // 0x18

	// Properties
	public override Type ComponentType { get; }

	// Methods

	// RVA: 0x227CA80 Offset: 0x227B080 VA: 0x18227CA80 Slot: 4
	public override Type get_ComponentType() { }

	// RVA: 0x227C9F0 Offset: 0x227AFF0 VA: 0x18227C9F0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227CA50 Offset: 0x227B050 VA: 0x18227CA50 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
