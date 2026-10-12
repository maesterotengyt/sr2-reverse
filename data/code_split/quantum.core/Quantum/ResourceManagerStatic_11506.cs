// Namespace: Quantum
public class ResourceManagerStatic : ResourceManagerBase // TypeDefIndex: 11506
{
	// Fields
	private Native.Allocator _allocator; // 0x20

	// Methods

	// RVA: 0x21DADB0 Offset: 0x21D93B0 VA: 0x1821DADB0
	public void .ctor(IEnumerable<AssetObject> assets, Native.Allocator allocator) { }

	// RVA: 0x21DAB10 Offset: 0x21D9110 VA: 0x1821DAB10 Slot: 14
	public override void Dispose() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 17
	protected override void DisposeAsset(AssetResource resource) { }

	// RVA: 0x21DACC0 Offset: 0x21D92C0 VA: 0x1821DACC0 Slot: 18
	public override AssetObject LoadResource(AssetResource resource, bool mainThread) { }
}
