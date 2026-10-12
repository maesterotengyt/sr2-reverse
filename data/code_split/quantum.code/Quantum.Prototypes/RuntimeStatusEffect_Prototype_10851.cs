// Namespace: Quantum.Prototypes
[Prototype(typeof(RuntimeStatusEffect))]
[Serializable]
public sealed class RuntimeStatusEffect_Prototype : StructPrototype // TypeDefIndex: 10851
{
	// Fields
	public MapEntityId OriginEntity; // 0x10
	public int NameId; // 0x14
	public int Type; // 0x18
	public int OriginId; // 0x1C
	public AssetRefStatusEffectBase StatusEffectData; // 0x20
	public FP RemainingFrames; // 0x28

	// Methods

	// RVA: 0x210DB70 Offset: 0x210C170 VA: 0x18210DB70
	public void Materialize(Frame frame, ref RuntimeStatusEffect result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
