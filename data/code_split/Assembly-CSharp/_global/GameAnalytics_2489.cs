// Namespace: 
public class GameAnalytics : MonoBehaviour // TypeDefIndex: 2489
{
	// Fields
	public string GameKey; // 0x20
	public string SecretKey; // 0x28
	public string SandboxGameKey; // 0x30
	public string SandboxSecretKey; // 0x38
	[FormerlySerializedAs("useSandBox")]
	[Tooltip("Enable to use analytics in sandbox")]
	public bool UseSandBox; // 0x40
	[Tooltip("If disabled, starts session after initialize")]
	public bool ManualStartSession; // 0x41
	[Tooltip("Enable all prints")]
	public bool Verbose; // 0x42
	public int PendingEventSaveLimit; // 0x44
	public int ResendTries; // 0x48

	// Methods

	// RVA: 0x62E6F0 Offset: 0x62CCF0 VA: 0x18062E6F0
	public void .ctor() { }
}
