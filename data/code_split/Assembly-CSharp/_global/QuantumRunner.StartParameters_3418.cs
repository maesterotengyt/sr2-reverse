// Namespace: 
public struct QuantumRunner.StartParameters // TypeDefIndex: 3418
{
	// Fields
	public RuntimeConfig RuntimeConfig; // 0x0
	public DeterministicSessionConfig DeterministicConfig; // 0x8
	public IDeterministicReplayProvider ReplayProvider; // 0x10
	public DeterministicGameMode GameMode; // 0x18
	public int InitialFrame; // 0x1C
	public byte[] FrameData; // 0x20
	public string RunnerId; // 0x28
	public QuantumNetworkCommunicator.QuitBehaviour QuitBehaviour; // 0x30
	public int PlayerCount; // 0x34
	public int LocalPlayerCount; // 0x38
	public RecordingFlags RecordingFlags; // 0x3C
	public LoadBalancingClient NetworkClient; // 0x40
	public IResourceManager ResourceManagerOverride; // 0x48
	public InstantReplaySettings InstantReplayConfig; // 0x50
	public int HeapExtraCount; // 0x60
	public DynamicAssetDB InitialDynamicAssets; // 0x68
	[Obsolete("IsRejoin is not used anymore")]
	public bool IsRejoin; // 0x70
	public float StartGameTimeoutInSeconds; // 0x74
	public bool DisableInterpolatableStates; // 0x78
}
