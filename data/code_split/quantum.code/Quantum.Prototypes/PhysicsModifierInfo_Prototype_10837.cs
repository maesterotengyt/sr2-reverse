// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsModifierInfo))]
[Serializable]
public sealed class PhysicsModifierInfo_Prototype : StructPrototype // TypeDefIndex: 10837
{
	// Fields
	public FP GravityMultiplier; // 0x10
	public FP AccelerationMultiplier; // 0x18
	public FP DecelerationMultiplier; // 0x20
	public FP VelocityMultiplier; // 0x28

	// Methods

	// RVA: 0x210B280 Offset: 0x2109880 VA: 0x18210B280
	public void Materialize(Frame frame, ref PhysicsModifierInfo result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
