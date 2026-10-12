// Namespace: Photon.Deterministic
public interface IDeterministicGame // TypeDefIndex: 17504
{
	// Properties
	public abstract DeterministicSession Session { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DeterministicSession get_Session();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetInputSerializedFixedSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetInputInMemorySize();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void DeserializeInputInto(int player, byte[] data, byte* buffer);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DeterministicFrameInputTemp OnLocalInput(int frame, int player);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDisposable CreateFrameContext();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract DeterministicFrame CreateFrame(IDisposable context);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DeterministicFrame GetVerifiedFrame(int tick);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract byte[] GetExtraErrorFrameDumpData(DeterministicFrame frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnDestroy();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AssignSession(DeterministicSession session);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnGameStart(DeterministicFrame state);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OnGameResync();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnSimulate(DeterministicFrame state);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnSimulateFinished(DeterministicFrame state);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnUpdateDone();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnChecksumError(DeterministicTickChecksumError error, DeterministicFrame[] frames);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OnChecksumErrorFrameDump(int actorId, int frameNumber, DeterministicSessionConfig sessionConfig, byte[] runtimeConfig, byte[] frameData, byte[] extraData);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void OnInputConfirmed(DeterministicFrameInputTemp input);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void OnChecksumComputed(int frame, ulong checksum);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void OnSimulationEnd();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void OnSimulationBegin();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnPluginDisconnect(string reason);
}
