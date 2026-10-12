// Namespace: 
public class QuantumStats : MonoBehaviour // TypeDefIndex: 2479
{
	// Fields
	public Text FrameVerified; // 0x20
	public Text FramePredicted; // 0x28
	public Text Predicted; // 0x30
	public Text Resimulated; // 0x38
	public Text SimulateTime; // 0x40
	public Text SimulationState; // 0x48
	public Text NetworkPing; // 0x50
	public Text NetworkIn; // 0x58
	public Text NetworkOut; // 0x60
	public Text InputOffset; // 0x68
	public Text ToggleButtonText; // 0x70
	public GameObject[] Toggles; // 0x78
	public bool StartEnabled; // 0x80
	private Stopwatch _networkTimer; // 0x88

	// Methods

	// RVA: 0x632C80 Offset: 0x631280 VA: 0x180632C80
	private void Start() { }

	// RVA: 0x632DB0 Offset: 0x6313B0 VA: 0x180632DB0
	private void Update() { }

	// RVA: 0x632A30 Offset: 0x631030 VA: 0x180632A30
	public void ResetNetworkStats() { }

	// RVA: 0x632B70 Offset: 0x631170 VA: 0x180632B70
	private void SetState(bool state) { }

	// RVA: 0x632D60 Offset: 0x631360 VA: 0x180632D60
	public void Toggle() { }

	// RVA: 0x632C50 Offset: 0x631250 VA: 0x180632C50
	public static void Show() { }

	// RVA: 0x632A00 Offset: 0x631000 VA: 0x180632A00
	public static void Hide() { }

	// RVA: 0x632930 Offset: 0x630F30 VA: 0x180632930
	public static QuantumStats GetObject() { }

	// RVA: 0x6334F0 Offset: 0x631AF0 VA: 0x1806334F0
	public void .ctor() { }
}
