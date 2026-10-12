// Namespace: Photon.Deterministic
public interface IDeterministicCommandPool // TypeDefIndex: 17473
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DeterministicCommand Acquire();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Release(DeterministicCommand cmd);
}
