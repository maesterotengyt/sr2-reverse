// Namespace: Photon.Deterministic
public interface IDeterministicCommandFactory // TypeDefIndex: 17472
{
	// Properties
	public abstract Type CommandType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_CommandType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DeterministicCommand GetCommandInstance();
}
