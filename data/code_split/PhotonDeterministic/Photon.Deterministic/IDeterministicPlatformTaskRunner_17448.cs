// Namespace: Photon.Deterministic
public interface IDeterministicPlatformTaskRunner // TypeDefIndex: 17448
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Schedule(Action[] delegates);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool PollForComplete();
}
