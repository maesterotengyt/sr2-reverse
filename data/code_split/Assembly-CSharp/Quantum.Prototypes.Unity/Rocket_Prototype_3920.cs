// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Rocket))]
[Serializable]
public class Rocket_Prototype : PrototypeAdapter<Rocket_Prototype> // TypeDefIndex: 3920
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[LocalReference]
	public EntityPrototype Target; // 0x18
	public FP ReCheckTargetFrames; // 0x20
	public FP InterpolationSpeed; // 0x28

	// Methods

	// RVA: 0x680F30 Offset: 0x67F530 VA: 0x180680F30 Slot: 5
	public sealed override Rocket_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x680FE0 Offset: 0x67F5E0 VA: 0x180680FE0
	public void .ctor() { }
}
