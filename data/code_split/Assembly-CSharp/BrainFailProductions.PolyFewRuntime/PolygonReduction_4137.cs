// Namespace: BrainFailProductions.PolyFewRuntime
public class PolygonReduction : MonoBehaviour // TypeDefIndex: 4137
{
	// Fields
	public Slider reductionStrength; // 0x20
	public Slider preservationStrength; // 0x28
	public Toggle preserveUVFoldover; // 0x30
	public Toggle preserveUVSeams; // 0x38
	public Toggle preserveBorders; // 0x40
	public Toggle enableSmartLinking; // 0x48
	public Toggle preserveFace; // 0x50
	public Toggle recalculateNormals; // 0x58
	public Toggle regardCurvature; // 0x60
	public InputField trianglesCount; // 0x68
	public Text message; // 0x70
	public Text progress; // 0x78
	public Button exportButton; // 0x80
	public Button importFromFileSystem; // 0x88
	public Button importFromWeb; // 0x90
	public Slider progressSlider; // 0x98
	public GameObject uninteractivePanel; // 0xA0
	public GameObject targetObject; // 0xA8
	public Transform preservationSphere; // 0xB0
	public EventSystem eventSystem; // 0xB8
	private PolyfewRuntime.ObjectMeshPairs objectMeshPairs; // 0xC0
	private bool didApplyLosslessLast; // 0xC8
	private bool disableTemporary; // 0xC9
	private GameObject barabarianRef; // 0xD0
	private PolyfewRuntime.ReferencedNumeric<float> downloadProgress; // 0xD8
	private bool isImportingFromNetwork; // 0xE0
	private bool isWebGL; // 0xE1

	// Methods

	// RVA: 0x6C1B90 Offset: 0x6C0190 VA: 0x1806C1B90
	private void Start() { }

	// RVA: 0x6C1D30 Offset: 0x6C0330 VA: 0x1806C1D30
	private void Update() { }

	// RVA: 0x6C1020 Offset: 0x6BF620 VA: 0x1806C1020
	public void OnReductionChange(float value) { }

	// RVA: 0x6C1920 Offset: 0x6BFF20 VA: 0x1806C1920
	public void SimplifyLossless() { }

	// RVA: 0x6C0BE0 Offset: 0x6BF1E0 VA: 0x1806C0BE0
	public void ImportOBJ() { }

	// RVA: 0x6C08B0 Offset: 0x6BEEB0 VA: 0x1806C08B0
	public void ImportOBJFromNetwork() { }

	// RVA: 0x6C0570 Offset: 0x6BEB70 VA: 0x1806C0570
	public void ExportGameObjectToOBJ() { }

	// RVA: 0x6C0F50 Offset: 0x6BF550 VA: 0x1806C0F50
	public void OnToggleStateChanged(bool isOn) { }

	// RVA: 0x6C0F50 Offset: 0x6BF550 VA: 0x1806C0F50
	public void OnPreservationStrengthChange(float value) { }

	// RVA: 0x6C1670 Offset: 0x6BFC70 VA: 0x1806C1670
	public void Reset() { }

	// RVA: 0x6C1530 Offset: 0x6BFB30 VA: 0x1806C1530
	public static void OnSliderSelect() { }

	// RVA: 0x6C14F0 Offset: 0x6BFAF0 VA: 0x1806C14F0
	public static void OnSliderDeselect() { }

	// RVA: 0x6C0E90 Offset: 0x6BF490 VA: 0x1806C0E90
	private bool IsMouseOverUI(RectTransform uiElement) { }

	[IteratorStateMachine(typeof(PolygonReduction.<ShowMessage>d__40))]
	// RVA: 0x6C1890 Offset: 0x6BFE90 VA: 0x1806C1890
	private IEnumerator ShowMessage(string message) { }

	// RVA: 0x6C1570 Offset: 0x6BFB70 VA: 0x1806C1570
	private void ResetSettings() { }

	[IteratorStateMachine(typeof(PolygonReduction.<UpdateProgress>d__42))]
	// RVA: 0x6C1CC0 Offset: 0x6C02C0 VA: 0x1806C1CC0
	private IEnumerator UpdateProgress() { }

	// RVA: 0x6C02A0 Offset: 0x6BE8A0 VA: 0x1806C02A0
	private void AssignMeshesFromPairs() { }

	// RVA: 0x6C1EB0 Offset: 0x6C04B0 VA: 0x1806C1EB0
	public void .ctor() { }
}
