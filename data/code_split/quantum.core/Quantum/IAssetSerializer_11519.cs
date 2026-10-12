// Namespace: Quantum
public interface IAssetSerializer // TypeDefIndex: 11519
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte[] SerializeAssets(IEnumerable<AssetObject> assets);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string PrintAsset(AssetObject asset);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<AssetObject> DeserializeAssets(byte[] data, int index, int count);
}
