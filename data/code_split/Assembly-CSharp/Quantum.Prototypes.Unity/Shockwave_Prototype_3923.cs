// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Shockwave))]
[Serializable]
public class Shockwave_Prototype : PrototypeAdapter<Shockwave_Prototype> // TypeDefIndex: 3923
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public FPVector2 InitialPosition; // 0x18
	public FPVector2 TargetPosition; // 0x28
	public FP Power; // 0x38

	// Methods

	// RVA: 0x682660 Offset: 0x680C60 VA: 0x180682660 Slot: 5
	public sealed override Shockwave_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x682700 Offset: 0x680D00 VA: 0x180682700
	public void .ctor() { }
}
