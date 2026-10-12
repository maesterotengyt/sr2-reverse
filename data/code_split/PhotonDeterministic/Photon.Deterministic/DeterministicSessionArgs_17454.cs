// Namespace: Photon.Deterministic
public struct DeterministicSessionArgs // TypeDefIndex: 17454
{
	// Fields
	public DeterministicGameMode Mode; // 0x0
	public DeterministicSessionConfig SessionConfig; // 0x8
	public IDeterministicGame Game; // 0x10
	public ICommunicator Communicator; // 0x18
	public IDeterministicReplayProvider Replay; // 0x20
	public DeterministicPlatformInfo PlatformInfo; // 0x28
	public int InitialTick; // 0x30
	public bool DisableInterpolatableStates; // 0x34
	public byte[] FrameData; // 0x38
	public byte[] RuntimeConfig; // 0x40
}
