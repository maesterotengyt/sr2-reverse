// Namespace: 
public class MenuPlayerHighlight : MonoBehaviour // TypeDefIndex: 3042
{
	// Fields
	public float MoveSpeed; // 0x20
	public RectTransform RectTransform; // 0x28
	public Animator Animator; // 0x30
	public GameObject Marker; // 0x38
	public List<Transform> MarkerPlaces; // 0x40
	public Color Color; // 0x48
	public List<Image> ColoredHighlightElements; // 0x58
	[CompilerGenerated]
	private bool <Used>k__BackingField; // 0x60
	private RectTransform currentTarget; // 0x68

	// Properties
	public bool Used { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x54C9C0 Offset: 0x54AFC0 VA: 0x18054C9C0
	public bool get_Used() { }

	[CompilerGenerated]
	// RVA: 0x54C9D0 Offset: 0x54AFD0 VA: 0x18054C9D0
	public void set_Used(bool value) { }

	// RVA: 0x54C4A0 Offset: 0x54AAA0 VA: 0x18054C4A0
	public void MoveToTarget(RectTransform target) { }

	// RVA: 0x54C3E0 Offset: 0x54A9E0 VA: 0x18054C3E0
	public void MoveMarkerPostion(int markerPosition) { }

	// RVA: 0x54C6E0 Offset: 0x54ACE0 VA: 0x18054C6E0
	private void Update() { }

	// RVA: 0x54C4B0 Offset: 0x54AAB0 VA: 0x18054C4B0
	public void Toggle(bool show, bool inmmediate = False) { }

	// RVA: 0x54C3D0 Offset: 0x54A9D0 VA: 0x18054C3D0
	public void Clean() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
