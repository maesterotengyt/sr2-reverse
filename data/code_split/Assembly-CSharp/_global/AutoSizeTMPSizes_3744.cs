// Namespace: 
[RequireComponent(typeof(TextMeshProUGUI), typeof(LayoutElement))]
public class AutoSizeTMPSizes : MonoBehaviour // TypeDefIndex: 3744
{
	// Fields
	private TextMeshProUGUI tmpText; // 0x20
	private LayoutElement layoutElement; // 0x28
	private RectTransform rectTransform; // 0x30
	private string lastText; // 0x38
	public bool largeCharacters; // 0x40
	[Header("Character Count Thresholds")]
	public int smallThreshold; // 0x44
	public int mediumThreshold; // 0x48
	public int largeCharSmallThreshold; // 0x4C
	public int largeCharMediumThreshold; // 0x50
	[Header("Fixed Sizes (Width, Height)")]
	public Vector2 smallDimensions; // 0x54
	public Vector2 mediumDimensions; // 0x5C
	public Vector2 largeDimensions; // 0x64
	public Vector2 largeCharSmallDimensions; // 0x6C
	public Vector2 largeCharMediumDimensions; // 0x74
	public Vector2 largeCharLargeDimensions; // 0x7C

	// Methods

	// RVA: 0x63D240 Offset: 0x63B840 VA: 0x18063D240
	private void Awake() { }

	// RVA: 0x63D2E0 Offset: 0x63B8E0 VA: 0x18063D2E0
	private void Update() { }

	// RVA: 0x63CFD0 Offset: 0x63B5D0 VA: 0x18063CFD0
	private void AdjustDimensions() { }

	// RVA: 0x63D3B0 Offset: 0x63B9B0 VA: 0x18063D3B0
	public void .ctor() { }
}
