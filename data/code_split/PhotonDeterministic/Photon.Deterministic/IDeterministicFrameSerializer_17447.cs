// Namespace: Photon.Deterministic
public interface IDeterministicFrameSerializer // TypeDefIndex: 17447
{
	// Properties
	public abstract bool Writing { get; }
	public abstract bool Reading { get; }
	public abstract IBitStream Stream { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Writing();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Reading();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IBitStream get_Stream();
}
