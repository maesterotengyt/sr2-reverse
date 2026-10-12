// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PhysicsJoints3D))]
[Serializable]
public class PhysicsJoints3D_Prototype : PrototypeAdapter<PhysicsJoints3D_Prototype> // TypeDefIndex: 3946
{
	// Fields
	[DynamicCollection]
	public Joint3D_Prototype[] JointConfigs; // 0x10

	// Methods

	// RVA: 0x67C600 Offset: 0x67AC00 VA: 0x18067C600 Slot: 5
	public sealed override PhysicsJoints3D_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x67C720 Offset: 0x67AD20 VA: 0x18067C720
	public void .ctor() { }
}
