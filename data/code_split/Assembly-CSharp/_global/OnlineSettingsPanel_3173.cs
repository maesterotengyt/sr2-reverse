// Namespace: 
public class OnlineSettingsPanel : SettingsSubPanel // TypeDefIndex: 3173
{
	// Fields
	public StellarSelectorOption RegionSelector; // 0x50
	public StellarSelectorOption CrossplaySelector; // 0x58
	public StellarSelectorOption ChatSelector; // 0x60
	public UINavigationElement ClearBlockListNavElement; // 0x68
	public LocalizedString YesString; // 0x70
	public LocalizedString NoString; // 0x78
	public LocalizedString ClearBlocklistString; // 0x80
	public LocalizedString ClearBlocklistDescriptionString; // 0x88
	private bool settingsChanged; // 0x90
	private Coroutine saveCoroutine; // 0x98
	private const float saveDelay = 1.5;
	private bool isCrossplayPrivilegeBlocked; // 0xA0
	private bool isCommunicationsPrivilegeBlocked; // 0xA1

	// Methods

	// RVA: 0x579700 Offset: 0x577D00 VA: 0x180579700 Slot: 7
	protected override void Update() { }

	[IteratorStateMachine(typeof(OnlineSettingsPanel.<SaveSettingsWithDelay>d__14))]
	// RVA: 0x578AC0 Offset: 0x5770C0 VA: 0x180578AC0
	private IEnumerator SaveSettingsWithDelay() { }

	// RVA: 0x578B30 Offset: 0x577130 VA: 0x180578B30 Slot: 5
	public override void Show() { }

	// RVA: 0x578A20 Offset: 0x577020 VA: 0x180578A20
	public void RegionChanged(int option) { }

	// RVA: 0x5785F0 Offset: 0x576BF0 VA: 0x1805785F0
	public void CrossplayChanged(int option) { }

	// RVA: 0x578280 Offset: 0x576880 VA: 0x180578280
	public void ChatEnabledChanged(int option) { }

	// RVA: 0x578800 Offset: 0x576E00 VA: 0x180578800 Slot: 6
	public override void Hide() { }

	// RVA: 0x578460 Offset: 0x576A60 VA: 0x180578460
	public void ClearBlockedList() { }

	// RVA: 0x578880 Offset: 0x576E80 VA: 0x180578880
	private void OnClearBlockedListSelected(string popUpID, int optionIndex) { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x579580 Offset: 0x577B80 VA: 0x180579580
	private void <CrossplayChanged>b__17_0() { }

	[CompilerGenerated]
	// RVA: 0x579420 Offset: 0x577A20 VA: 0x180579420
	private void <ChatEnabledChanged>b__18_0() { }
}
