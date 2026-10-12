// Namespace: 
public class UIWorldOffScreenIndicator : StellarMonoBehaviour // TypeDefIndex: 3710
{
	// Fields
	public RectTransform RectTransform; // 0x20
	public RectTransform RotationTransform; // 0x28
	[Tooltip("Offset calculated based on the current resolution, is a percentaje (0.02 = 2%)")]
	public float BorderOffsetNormalizedX; // 0x30
	[Tooltip("Offset calculated based on the current resolution, is a percentaje (0.02 = 2%)")]
	public float BorderOffsetNormalizedY; // 0x34
	private Transform followPoint; // 0x38
	private Camera currentCamera; // 0x40
	private RectTransform canvasRect; // 0x48
	private RectTransform visibleArea; // 0x50
	private bool isActive; // 0x58
	private Vector3[] corners; // 0x60
	private float minX; // 0x68
	private float maxX; // 0x6C
	private float minY; // 0x70
	private float maxY; // 0x74
	private int lastScreenWidth; // 0x78
	private int lastScreenHeight; // 0x7C

	// Methods

	// RVA: 0x653AA0 Offset: 0x6520A0 VA: 0x180653AA0
	public void Initialize(Transform followPoint, RectTransform canvasRect, RectTransform visibleArea) { }

	// RVA: 0x653D90 Offset: 0x652390 VA: 0x180653D90
	private void Update() { }

	// RVA: 0x653BD0 Offset: 0x6521D0 VA: 0x180653BD0
	public bool IsPositionInVisibleArea(Vector2 worldPosition) { }

	// RVA: 0x653B20 Offset: 0x652120 VA: 0x180653B20
	public bool IsPositionInVisibleArea() { }

	// RVA: 0x581900 Offset: 0x57FF00 VA: 0x180581900
	public void ToggleActiveState(bool isActive) { }

	// RVA: 0x653CB0 Offset: 0x6522B0 VA: 0x180653CB0
	private void UpdateVisibleMinMax() { }

	// RVA: 0x654190 Offset: 0x652790 VA: 0x180654190
	public void .ctor() { }
}
