// Namespace: 
public class Letterbox : MonoBehaviour // TypeDefIndex: 3692
{
	// Fields
	public bool ShowBars; // 0x20
	public RectTransform VisibleArea; // 0x28
	[HideInInspector]
	public Vector2 BorderOffset; // 0x30
	private int lastScreenWidth; // 0x38
	private int lastScreenHeight; // 0x3C
	private Dictionary<string, float> corners; // 0x40

	// Methods

	// RVA: 0x617500 Offset: 0x615B00 VA: 0x180617500
	private void OnValidate() { }

	// RVA: 0x617270 Offset: 0x615870 VA: 0x180617270
	private void Awake() { }

	// RVA: 0x617720 Offset: 0x615D20 VA: 0x180617720
	private void Start() { }

	// RVA: 0x617730 Offset: 0x615D30 VA: 0x180617730
	private void ToggleImages(bool enable) { }

	// RVA: 0x6172A0 Offset: 0x6158A0 VA: 0x1806172A0
	private void CalculateCorners() { }

	// RVA: 0x617510 Offset: 0x615B10 VA: 0x180617510
	public bool PositionBehindBars(Vector2 position) { }

	// RVA: 0x6177D0 Offset: 0x615DD0 VA: 0x1806177D0
	public void .ctor() { }
}
