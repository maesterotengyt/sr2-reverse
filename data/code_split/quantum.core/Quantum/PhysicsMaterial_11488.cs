// Namespace: Quantum
[Serializable]
public class PhysicsMaterial : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11488
{
	// Fields
	public const long DEFAULT_ID = 1;
	public FP Restitution; // 0x20
	public PhysicsCombineFunction RestitutionCombineFunction; // 0x28
	public FP FrictionStatic; // 0x30
	public FP FrictionDynamic; // 0x38
	public PhysicsCombineFunction FrictionCombineFunction; // 0x40

	// Methods

	// RVA: 0x21D6800 Offset: 0x21D4E00 VA: 0x1821D6800 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	// RVA: 0x21D67D0 Offset: 0x21D4DD0 VA: 0x1821D67D0 Slot: 4
	public override void Loaded(IResourceManager assets, Native.Allocator allocator) { }

	// RVA: 0x21D68C0 Offset: 0x21D4EC0 VA: 0x1821D68C0
	public void .ctor() { }
}
