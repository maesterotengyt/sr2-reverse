// Namespace: 
public class QuantumMultiClientRunner : MonoBehaviour // TypeDefIndex: 2437
{
	// Fields
	public QuantumMultiClientPlayerView PlayerViewTemplate; // 0x20
	public Button CreatePlayerBtn; // 0x28
	[Tooltip("Quantum scripts in your game scene that are part of the regular setup like EntityViewUpdater, Input and CustomCallbacks need to be disabled when using the MultiClientRunner, add them here.")]
	public List<GameObject> DisableOnStart; // 0x30
	[Tooltip("Optionally provide non-default editor settings for all additional clients after the first one (to change the gizmo colors for example).")]
	public QuantumEditorSettings EditorSettings; // 0x38
	[Tooltip("Optionally provide different non-default server app settings")]
	public PhotonServerSettings ServerSettings; // 0x40
	[Tooltip("Add custom runtime config settings here")]
	public RuntimeConfig RuntimeConfig; // 0x48
	[Tooltip("Set the max player count")]
	public int PlayerCount; // 0x50
	[Tooltip("How many players to start with")]
	public int InitialPlayerCount; // 0x54
	[Tooltip("Add custom runtime player settings here")]
	public RuntimePlayer[] RuntimePlayer; // 0x58
	[Tooltip("Provide a player input template that is instantiated for the clients. A Unity script that has to implement void Unity message PollInput(CallbackPollInput c)")]
	public GameObject PlayerInputTemplate; // 0x60
	[Tooltip("Optionally provide a custom EntityViewUpdater game object template that is instantiated for the clients (otherwise a new instance of EntityViewUpdater is created for each player)")]
	public EntityViewUpdater EntityViewUpdaterTemplate; // 0x68
	private List<QuantumMultiClientPlayer> players; // 0x70

	// Methods

	[IteratorStateMachine(typeof(QuantumMultiClientRunner.<Start>d__12))]
	// RVA: 0x5322E0 Offset: 0x5308E0 VA: 0x1805322E0
	public IEnumerator Start() { }

	// RVA: 0x5320C0 Offset: 0x5306C0 VA: 0x1805320C0
	public void OnEnable() { }

	// RVA: 0x531EA0 Offset: 0x5304A0 VA: 0x180531EA0
	private void OnCallbackPollInput(CallbackPollInput c) { }

	// RVA: 0x532020 Offset: 0x530620 VA: 0x180532020
	public void OnDisable() { }

	// RVA: 0x531E90 Offset: 0x530490 VA: 0x180531E90
	public void CreateNewPlayer() { }

	// RVA: 0x5316A0 Offset: 0x52FCA0 VA: 0x1805316A0
	private QuantumMultiClientPlayer CreateNewPlayerInternal() { }

	// RVA: 0x532250 Offset: 0x530850 VA: 0x180532250
	public void OnPlayerLeft(QuantumMultiClientPlayer player) { }

	// RVA: 0x5321F0 Offset: 0x5307F0 VA: 0x1805321F0
	public void OnPlayerCreated(QuantumMultiClientPlayer player) { }

	// RVA: 0x532350 Offset: 0x530950 VA: 0x180532350
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x531EA0 Offset: 0x5304A0 VA: 0x180531EA0
	private void <OnEnable>b__13_0(CallbackPollInput c) { }
}
