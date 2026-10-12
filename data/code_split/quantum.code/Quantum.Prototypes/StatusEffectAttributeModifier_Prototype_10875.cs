// Namespace: Quantum.Prototypes
[Prototype(typeof(StatusEffectAttributeModifier))]
[Serializable]
public sealed class StatusEffectAttributeModifier_Prototype : StructPrototype // TypeDefIndex: 10875
{
	// Fields
	[HideInInspector]
	public int OriginId; // 0x10
	public FP Value; // 0x18
	public StatusEffectModifierOperation_Prototype Operation; // 0x20

	// Methods

	// RVA: 0x2111E90 Offset: 0x2110490 VA: 0x182111E90
	public void Materialize(Frame frame, ref StatusEffectAttributeModifier result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
