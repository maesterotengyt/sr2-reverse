// Namespace: Quantum
public interface IResourceManager : IDisposable // TypeDefIndex: 11502
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AssetDB CreateAssetDatabase();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DiposeAssetDatabase(AssetDB db);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool DisposeAsset(AssetGuid guid);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract AssetObject GetAsset(AssetGuid guid, bool mainThread = True);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<AssetObject> LoadAllAssets(bool mainThread);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void MainThreadSimulationEnded();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void MainThreadUpdate(Profiler profiler);
}
