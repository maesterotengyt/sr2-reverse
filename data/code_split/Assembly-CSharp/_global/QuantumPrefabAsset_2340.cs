// Namespace: 
public abstract class QuantumPrefabAsset : ScriptableObject // TypeDefIndex: 2340
{
	// Fields
	public string PrefabGuid; // 0x18
	private GameObject _loadedInstance; // 0x20

	// Methods

	// RVA: 0x516C30 Offset: 0x515230 VA: 0x180516C30
	public void Load(QuantumPrefabAsset.IListener listener, bool async = False) { }

	// RVA: 0x517000 Offset: 0x515600 VA: 0x180517000
	public void UnloadInstance() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Load(in QuantumPrefabAsset.LoadContext context);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void Unload();

	// RVA: -1 Offset: -1
	private T EnsureComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1BB60 Offset: 0xC1A160 VA: 0x180C1BB60
	|-QuantumPrefabAsset.EnsureComponent<object>
	*/

	// RVA: 0x516890 Offset: 0x514E90 VA: 0x180516890
	private void LoadFinished(in QuantumPrefabAsset.LoadContext context, GameObject prefab) { }

	// RVA: 0x516AD0 Offset: 0x5150D0 VA: 0x180516AD0
	private void LoadFinished(in QuantumPrefabAsset.LoadContext context, Exception error) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	protected void .ctor() { }
}
