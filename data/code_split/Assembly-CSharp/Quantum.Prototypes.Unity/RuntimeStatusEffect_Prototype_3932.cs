// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(RuntimeStatusEffect))]
[Serializable]
public class RuntimeStatusEffect_Prototype : PrototypeAdapter<RuntimeStatusEffect_Prototype> // TypeDefIndex: 3932
{
	// Fields
	[LocalReference]
	public EntityPrototype OriginEntity; // 0x10
	public int NameId; // 0x18
	public int Type; // 0x1C
	public int OriginId; // 0x20
	public AssetRefStatusEffectBase StatusEffectData; // 0x28
	public FP RemainingFrames; // 0x30

	// Methods

	// RVA: 0x682570 Offset: 0x680B70 VA: 0x180682570 Slot: 5
	public sealed override RuntimeStatusEffect_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x682620 Offset: 0x680C20 VA: 0x180682620
	public void .ctor() { }
}
