// Namespace: 
public class SettingsSubPanel : SRMonoBehaviour // TypeDefIndex: 3177
{
	// Fields
	public SettingsSubPanelID ID; // 0x20
	public Animator Animator; // 0x28
	public UINavigator UINavigator; // 0x30
	public LocalizedString TitleString; // 0x38
	protected bool visible; // 0x40
	private SettingsPanelManager panelManager; // 0x48

	// Methods

	// RVA: 0x58D130 Offset: 0x58B730 VA: 0x18058D130 Slot: 4
	public virtual void Init(SettingsPanelManager panelManager) { }

	// RVA: 0x58D140 Offset: 0x58B740 VA: 0x18058D140 Slot: 5
	public virtual void Show() { }

	// RVA: 0x58CF30 Offset: 0x58B530 VA: 0x18058CF30
	protected void ApplyTitleText() { }

	// RVA: 0x58CFE0 Offset: 0x58B5E0 VA: 0x18058CFE0 Slot: 6
	public virtual void Hide() { }

	// RVA: 0x58D290 Offset: 0x58B890 VA: 0x18058D290 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
