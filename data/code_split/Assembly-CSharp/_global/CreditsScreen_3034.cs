// Namespace: 
public class CreditsScreen : MainMenuScreen // TypeDefIndex: 3034
{
	// Fields
	public CreditsData CreditsData; // 0x90
	public Transform ContentParent; // 0x98
	public CreditsSectionTitle SectionTitlePrefab; // 0xA0
	public CreditsRoleGroup RoleGroupPrefab; // 0xA8
	public Transform EndingMarker; // 0xB0
	public Transform EndingMarkerEndPosition; // 0xB8
	public Transform StartSection; // 0xC0
	public Transform EndSection; // 0xC8
	public RectTransformAutoRebuild RectTransformAutoRebuild; // 0xD0
	public LocalizedString SpeedUpString; // 0xD8
	public LocalizedString RewindString; // 0xE0
	private bool starting; // 0xE8
	private float timerForStartScroll; // 0xEC
	private bool scrolling; // 0xF0
	private Vector3 scrollStartingPosition; // 0xF4

	// Properties
	private DataManager dataManager { get; }
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x79A580 Offset: 0x798B80 VA: 0x18079A580
	private DataManager get_dataManager() { }

	// RVA: 0x79A5D0 Offset: 0x798BD0 VA: 0x18079A5D0
	private OnlineManager get_onlineManager() { }

	// RVA: 0x7996D0 Offset: 0x797CD0 VA: 0x1807996D0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x799730 Offset: 0x797D30 VA: 0x180799730 Slot: 5
	public override void Load() { }

	// RVA: 0x799B80 Offset: 0x798180 VA: 0x180799B80 Slot: 7
	public override void Show() { }

	// RVA: 0x799E20 Offset: 0x798420 VA: 0x180799E20 Slot: 10
	public override void UpdateScreen() { }

	[Button("Apply Data")]
	// RVA: 0x7991D0 Offset: 0x7977D0 VA: 0x1807991D0
	public void ApplyData() { }

	// RVA: 0x7998F0 Offset: 0x797EF0 VA: 0x1807998F0
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x7995F0 Offset: 0x797BF0 VA: 0x1807995F0 Slot: 8
	public override void Hide() { }

	[IteratorStateMachine(typeof(CreditsScreen.<ResetWithDelay>d__26))]
	// RVA: 0x799B10 Offset: 0x798110 VA: 0x180799B10
	private IEnumerator ResetWithDelay() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
