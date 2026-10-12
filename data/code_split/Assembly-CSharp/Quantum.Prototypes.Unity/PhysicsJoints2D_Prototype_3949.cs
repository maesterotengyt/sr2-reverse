// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PhysicsJoints2D))]
[Serializable]
public class PhysicsJoints2D_Prototype : PrototypeAdapter<PhysicsJoints2D_Prototype> // TypeDefIndex: 3949
{
	// Fields
	[DynamicCollection]
	public Joint2D_Prototype[] JointConfigs; // 0x10

	// Methods

	// RVA: 0x67C470 Offset: 0x67AA70 VA: 0x18067C470 Slot: 5
	public sealed override PhysicsJoints2D_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x67C590 Offset: 0x67AB90 VA: 0x18067C590
	public void .ctor() { }
}
