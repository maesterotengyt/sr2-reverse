// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(RocketLauncher))]
[Serializable]
public class RocketLauncher_Prototype : PrototypeAdapter<RocketLauncher_Prototype> // TypeDefIndex: 3921
{
	// Fields
	[LocalReference]
	public EntityPrototype Target; // 0x10
	public FP ShootCooldownFrames; // 0x18

	// Methods

	// RVA: 0x680E60 Offset: 0x67F460 VA: 0x180680E60 Slot: 5
	public sealed override RocketLauncher_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x680EF0 Offset: 0x67F4F0 VA: 0x180680EF0
	public void .ctor() { }
}
