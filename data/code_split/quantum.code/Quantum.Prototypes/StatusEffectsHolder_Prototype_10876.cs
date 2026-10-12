// Namespace: Quantum.Prototypes
[Prototype(typeof(StatusEffectsHolder))]
[Serializable]
public sealed class StatusEffectsHolder_Prototype : ComponentPrototype<StatusEffectsHolder> // TypeDefIndex: 10876
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	[DynamicCollection]
	public RuntimeStatusEffect_Prototype[] ActiveStatusEffects; // 0x20

	// Methods

	// RVA: 0x2111ED0 Offset: 0x21104D0 VA: 0x182111ED0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2112050 Offset: 0x2110650 VA: 0x182112050
	public void Materialize(Frame frame, ref StatusEffectsHolder result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2111FC0 Offset: 0x21105C0 VA: 0x182111FC0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2112260 Offset: 0x2110860 VA: 0x182112260
	public void .ctor() { }
}
