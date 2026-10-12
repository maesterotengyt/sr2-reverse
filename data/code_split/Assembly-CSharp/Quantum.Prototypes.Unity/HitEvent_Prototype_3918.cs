// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(HitEvent))]
[Serializable]
public class HitEvent_Prototype : PrototypeAdapter<HitEvent_Prototype> // TypeDefIndex: 3918
{
	// Fields
	public HitType_Prototype HitType; // 0x10
	[LocalReference]
	public EntityPrototype PlayerOwner; // 0x18

	// Methods

	// RVA: 0x6776E0 Offset: 0x675CE0 VA: 0x1806776E0 Slot: 5
	public sealed override HitEvent_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677770 Offset: 0x675D70 VA: 0x180677770
	public void .ctor() { }
}
