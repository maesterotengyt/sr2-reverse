// Namespace: Photon.Deterministic
public interface IDeterministicInputProvider // TypeDefIndex: 17475
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanSimulate(int frame);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DeterministicFrameInputTemp GetInput(int frame, int player);
}
