// Namespace: 
public class CharacterViewerCameraControl : StellarMonoBehaviour // TypeDefIndex: 3591
{
	// Fields
	public Transform StillCameraPosition; // 0x20
	public Animator Animator; // 0x28
	public float PixelOffsetScale; // 0x30
	public List<CustomToggleButton> ToggleButtons; // 0x38
	private Vector3 cameraSystemPosition; // 0x40
	private Vector3 startCameraPosition; // 0x4C
	private Vector3 startCameraRotation; // 0x58
	private Vector3 targetCameraPosition; // 0x64
	private Vector3 targetCameraRotation; // 0x70
	private Vector3 pointerStartPosition; // 0x7C
	private int inputIndex; // 0x88
	private TMP_InputField currentInput; // 0x90

	// Methods

	// RVA: 0x603930 Offset: 0x601F30 VA: 0x180603930
	private void Start() { }

	// RVA: 0x602C80 Offset: 0x601280 VA: 0x180602C80
	public void FindCamera() { }

	// RVA: 0x603A90 Offset: 0x602090 VA: 0x180603A90
	public void TogglePanel(bool active) { }

	// RVA: 0x6030A0 Offset: 0x6016A0 VA: 0x1806030A0
	public void OnInitializeDrag(BaseEventData eventData) { }

	// RVA: 0x602E10 Offset: 0x601410 VA: 0x180602E10
	public void OnDrag(BaseEventData eventData) { }

	// RVA: 0x602DF0 Offset: 0x6013F0 VA: 0x180602DF0
	public void OnDragEnd(BaseEventData eventData) { }

	// RVA: 0x602CE0 Offset: 0x6012E0 VA: 0x180602CE0
	private TMP_InputField GetParentInput(GameObject targetObject) { }

	// RVA: 0x603510 Offset: 0x601B10 VA: 0x180603510
	public void SetXPosition(TMP_InputField input) { }

	// RVA: 0x603670 Offset: 0x601C70 VA: 0x180603670
	public void SetYPosition(TMP_InputField input) { }

	// RVA: 0x6037D0 Offset: 0x601DD0 VA: 0x1806037D0
	public void SetZPosition(TMP_InputField input) { }

	// RVA: 0x6035C0 Offset: 0x601BC0 VA: 0x1806035C0
	public void SetXRotation(TMP_InputField input) { }

	// RVA: 0x603720 Offset: 0x601D20 VA: 0x180603720
	public void SetYRotation(TMP_InputField input) { }

	// RVA: 0x603880 Offset: 0x601E80 VA: 0x180603880
	public void SetZRotation(TMP_InputField input) { }

	// RVA: 0x6032C0 Offset: 0x6018C0 VA: 0x1806032C0
	private void SetCameraTransform() { }

	// RVA: 0x603C50 Offset: 0x602250 VA: 0x180603C50
	public void .ctor() { }
}
