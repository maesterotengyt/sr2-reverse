// Namespace: Quantum
public abstract class AssetResourceInfoGroup // TypeDefIndex: 3861
{
	// Properties
	public abstract IReadOnlyList<AssetResourceInfo> Resources { get; }
	public abstract int SortOrder { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IReadOnlyList<AssetResourceInfo> get_Resources();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_SortOrder();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract UnityResourceLoader.ILoader CreateLoader();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Sort();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Add(AssetResourceInfo info);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Remove(string path);

	// RVA: 0x6719E0 Offset: 0x66FFE0 VA: 0x1806719E0
	public AssetResourceInfo FindResourceInfo(AssetGuid guid) { }

	// RVA: 0x671880 Offset: 0x66FE80 VA: 0x180671880
	private static int BinarySearch(IReadOnlyList<AssetResourceInfo> list, AssetGuid guid) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
