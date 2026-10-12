// Namespace: Photon.Deterministic
public interface IDeterministicRpcProvider // TypeDefIndex: 17474
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract QTuple<byte[], bool> GetRpc(int frame, int player);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddRpc(int player, byte[] data, bool command);
}
