// Namespace: 
public class StellarDebugSystem : MonoBehaviour // TypeDefIndex: 3554
{
	// Fields
	private bool fpsActive; // 0x20
	private float deltaTime; // 0x24
	private float fpsTimer; // 0x28
	private float fpsTimeActive; // 0x2C
	private float currentFPS; // 0x30
	private float averageFPS; // 0x34
	private List<float> framesPerSecond; // 0x38

	// Methods

	// RVA: 0x5EC2E0 Offset: 0x5EA8E0 VA: 0x1805EC2E0
	public void StartFPSTracking() { }

	// RVA: 0x5EC2F0 Offset: 0x5EA8F0 VA: 0x1805EC2F0
	private void Update() { }

	// RVA: 0x5EC280 Offset: 0x5EA880 VA: 0x1805EC280
	public string GetCurrentFPS() { }

	// RVA: 0x5EC220 Offset: 0x5EA820 VA: 0x1805EC220
	public string GetAverageFPS() { }

	// RVA: 0x5EBFC0 Offset: 0x5EA5C0 VA: 0x1805EBFC0
	private void CheckFPS() { }

	// RVA: 0x5EC300 Offset: 0x5EA900 VA: 0x1805EC300
	public void .ctor() { }
}
