// Namespace: Quantum
[Serializable]
public class PolygonCollider : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11491
{
	// Fields
	public FPVector2[] Vertices; // 0x20
	public FPVector2[] Normals; // 0x28
	internal FP Radius; // 0x30
	internal FPVector2 Centroid; // 0x38
	internal FPVector2* VerticesBuffer; // 0x48
	internal FPVector2* NormalsBuffer; // 0x50

	// Methods

	// RVA: 0x21D6B70 Offset: 0x21D5170 VA: 0x1821D6B70 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	// RVA: 0x21D6AE0 Offset: 0x21D50E0 VA: 0x1821D6AE0 Slot: 4
	public override void Loaded(IResourceManager assets, Native.Allocator allocator) { }

	// RVA: 0x21D6920 Offset: 0x21D4F20 VA: 0x1821D6920 Slot: 5
	public override void Disposed(IResourceManager assets, Native.Allocator allocator) { }

	// RVA: 0x21D6A20 Offset: 0x21D5020 VA: 0x1821D6A20
	internal void InitializeNativeBuffers(Native.Allocator allocator) { }

	// RVA: 0x21D69A0 Offset: 0x21D4FA0 VA: 0x1821D69A0
	internal void FreeNativeBuffers(Native.Allocator allocator) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
