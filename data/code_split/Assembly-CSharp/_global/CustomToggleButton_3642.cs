// Namespace: 
public class CustomToggleButton : MonoBehaviour // TypeDefIndex: 3642
{
	// Fields
	public GameObject SelectedButton; // 0x20
	public GameObject DeselectedButton; // 0x28
	public bool IsOn; // 0x30
	public bool Interactable; // 0x31
	public UnityEvent OnToggleEvent; // 0x38
	public CustomToggleGroup ToggleGroup; // 0x40
	public int Index; // 0x48
	[SerializeField]
	private CustomToggleButton.AnimationToggle animationToggle; // 0x50
	private bool isGroupToggle; // 0x78
	private bool highlighted; // 0x79

	// Methods

	// RVA: 0x6155F0 Offset: 0x613BF0 VA: 0x1806155F0
	private void OnEnable() { }

	// RVA: 0x6155B0 Offset: 0x613BB0 VA: 0x1806155B0
	public void Init(int index, CustomToggleGroup toggleGroup) { }

	// RVA: 0x615870 Offset: 0x613E70 VA: 0x180615870
	public void UpdateToggleSelection() { }

	// RVA: 0x615680 Offset: 0x613C80 VA: 0x180615680
	public void ToggleInteractable(bool active) { }

	// RVA: 0x615780 Offset: 0x613D80 VA: 0x180615780
	public void UpdateToggleHighlight(bool highlight) { }

	// RVA: 0x615600 Offset: 0x613C00 VA: 0x180615600
	private void ResetTriggers() { }

	// RVA: 0x615720 Offset: 0x613D20 VA: 0x180615720
	public void Toggle(bool selected) { }

	// RVA: 0x615670 Offset: 0x613C70 VA: 0x180615670
	public void Select(int index) { }

	// RVA: 0x6159B0 Offset: 0x613FB0 VA: 0x1806159B0
	public void .ctor() { }
}
