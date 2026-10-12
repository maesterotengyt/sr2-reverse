// Namespace: 
public class EulaPopup : UIPopup // TypeDefIndex: 3229
{
	// Fields
	public UINavigator ButtonsNavigator; // 0x38
	public Scrollbar scrollbar; // 0x40
	public UINavigationElement Option1; // 0x48
	public UINavigationElement Option2; // 0x50
	public LocalizedString AcceptString; // 0x58
	public LocalizedString DeclineString; // 0x60
	public Image Option1Icon; // 0x68
	public Image Option2Icon; // 0x70
	[SerializeField]
	private float scrollSpeed; // 0x78
	private bool isAuthenticated; // 0x7C
	private bool scrollEnabled; // 0x7D

	// Methods

	// RVA: 0x580F80 Offset: 0x57F580 VA: 0x180580F80
	private void Update() { }

	// RVA: 0x580830 Offset: 0x57EE30 VA: 0x180580830
	private void HandleScrollInput() { }

	// RVA: 0x580B70 Offset: 0x57F170 VA: 0x180580B70
	public void SetData(bool isAuthenticated) { }

	// RVA: 0x580AD0 Offset: 0x57F0D0 VA: 0x180580AD0
	public void Option1Selected() { }

	// RVA: 0x580B20 Offset: 0x57F120 VA: 0x180580B20
	public void Option2Selected() { }

	// RVA: 0x580DD0 Offset: 0x57F3D0 VA: 0x180580DD0 Slot: 4
	public override void Show() { }

	// RVA: 0x580C50 Offset: 0x57F250 VA: 0x180580C50
	private void SetupNavigatorExtendedCalls() { }

	// RVA: 0x580A50 Offset: 0x57F050 VA: 0x180580A50
	private void OnNavigatorUpOverflow(int playerIndex) { }

	// RVA: 0x5803C0 Offset: 0x57E9C0 VA: 0x1805803C0 Slot: 5
	public override void Hide(bool destroy) { }

	// RVA: 0x581010 Offset: 0x57F610 VA: 0x180581010
	public void .ctor() { }
}
