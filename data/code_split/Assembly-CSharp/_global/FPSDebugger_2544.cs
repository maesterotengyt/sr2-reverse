// Namespace: 
public class FPSDebugger : MonoBehaviour // TypeDefIndex: 2544
{
	// Fields
	public GameObject FPSCounter; // 0x20
	public GameObject FPSSummary; // 0x28
	public TMP_Text FPSText; // 0x30
	public TMP_Text FPSSummaryAverageText; // 0x38
	public TMP_Text FPSSummaryMinMaxText; // 0x40
	private bool fpsActive; // 0x48
	private float deltaTime; // 0x4C
	private float fpsTimer; // 0x50
	private float fpsTimeActive; // 0x54
	private float average; // 0x58
	private float recentAverage; // 0x5C
	private float minAverage; // 0x60
	private float maxAverage; // 0x64
	private float minFPS; // 0x68
	private float maxFPS; // 0x6C
	private List<float> allFrames; // 0x70
	private List<float> recentFrames; // 0x78
	private float recentAverageTimer; // 0x80

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void Update() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void EnableFPSCounter() { }

	// RVA: 0x62E5A0 Offset: 0x62CBA0 VA: 0x18062E5A0
	public void DisableFPSCounter() { }

	// RVA: 0x62DFB0 Offset: 0x62C5B0 VA: 0x18062DFB0
	public void CheckFPS() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void ShowFPSSummary() { }

	// RVA: 0x62E5D0 Offset: 0x62CBD0 VA: 0x18062E5D0
	public void DisableFPSSummary() { }

	// RVA: 0x62E600 Offset: 0x62CC00 VA: 0x18062E600
	public void Disable() { }

	// RVA: 0x62E640 Offset: 0x62CC40 VA: 0x18062E640
	public void .ctor() { }
}
