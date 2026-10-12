// Namespace: Quantum
public abstract class AssetResourceInfoGroup<T> : AssetResourceInfoGroup // TypeDefIndex: 3863
{
	// Fields
	[SerializeField]
	private List<T> _resources; // 0x0

	// Properties
	public override IReadOnlyList<AssetResourceInfo> Resources { get; }
	public IReadOnlyList<T> ResourcesT { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override IReadOnlyList<AssetResourceInfo> get_Resources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	|-AssetResourceInfoGroup<object>.get_Resources
	*/

	// RVA: -1 Offset: -1
	public IReadOnlyList<T> get_ResourcesT() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	|-AssetResourceInfoGroup<object>.get_ResourcesT
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D93C0 Offset: 0x13D79C0 VA: 0x1813D93C0
	|-AssetResourceInfoGroup<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D9610 Offset: 0x13D7C10 VA: 0x1813D9610
	|-AssetResourceInfoGroup<object>.Sort
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void Add(AssetResourceInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D92F0 Offset: 0x13D78F0 VA: 0x1813D92F0
	|-AssetResourceInfoGroup<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void Remove(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D9400 Offset: 0x13D7A00 VA: 0x1813D9400
	|-AssetResourceInfoGroup<object>.Remove
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D97D0 Offset: 0x13D7DD0 VA: 0x1813D97D0
	|-AssetResourceInfoGroup<object>..ctor
	*/
}
