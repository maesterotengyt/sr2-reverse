// Namespace: Quantum
[Serializable]
public abstract class AssetObject // TypeDefIndex: 11514
{
	// Fields
	public AssetObjectIdentifier Identifier; // 0x10

	// Properties
	public AssetGuid Guid { get; }
	public string Path { get; }
	internal bool HasPath { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public AssetGuid get_Guid() { }

	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public string get_Path() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public virtual void Loaded(IResourceManager resourceManager, Native.Allocator allocator) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void Disposed(IResourceManager resourceManager, Native.Allocator allocator) { }

	// RVA: 0x21C4A30 Offset: 0x21C3030 VA: 0x1821C4A30
	internal bool get_HasPath() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
