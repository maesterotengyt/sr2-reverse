// Namespace: 
public class UIScreen : StellarMonoBehaviour // TypeDefIndex: 3683
{
	// Fields
	public string ScreenID; // 0x20
	public Animator Animator; // 0x28
	public bool LoadRequired; // 0x30
	public string ShowSFX; // 0x38
	public string HideSFX; // 0x40
	public string BackSFX; // 0x48
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <ScreenActive>k__BackingField; // 0x51

	// Properties
	public bool Initialized { get; set; }
	public bool ScreenActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C9FB0 Offset: 0x5C85B0 VA: 0x1805C9FB0
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x626430 Offset: 0x624A30 VA: 0x180626430
	public void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x626420 Offset: 0x624A20 VA: 0x180626420
	public bool get_ScreenActive() { }

	[CompilerGenerated]
	// RVA: 0x626440 Offset: 0x624A40 VA: 0x180626440
	public void set_ScreenActive(bool value) { }

	// RVA: 0x5C9700 Offset: 0x5C7D00 VA: 0x1805C9700 Slot: 4
	public virtual void Initialize() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void Load() { }

	// RVA: 0x503BC0 Offset: 0x5021C0 VA: 0x180503BC0 Slot: 6
	public virtual void LoadFinished() { }

	// RVA: 0x626210 Offset: 0x624810 VA: 0x180626210 Slot: 7
	public virtual void Show() { }

	// RVA: 0x625F10 Offset: 0x624510 VA: 0x180625F10 Slot: 8
	public virtual void Hide() { }

	// RVA: 0x6263A0 Offset: 0x6249A0 VA: 0x1806263A0 Slot: 9
	public virtual void TogglePanel(bool panelEnabled) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void UpdateScreen() { }

	// RVA: 0x626400 Offset: 0x624A00 VA: 0x180626400 Slot: 11
	public virtual void Update() { }

	// RVA: 0x626110 Offset: 0x624710 VA: 0x180626110
	public void PlayBackSound() { }

	[IteratorStateMachine(typeof(UIScreen.<DisableScreen>d__23))]
	// RVA: 0x625E30 Offset: 0x624430 VA: 0x180625E30
	public IEnumerator DisableScreen() { }

	// RVA: 0x625EA0 Offset: 0x6244A0 VA: 0x180625EA0 Slot: 12
	public virtual void Disable() { }

	// RVA: 0x625EC0 Offset: 0x6244C0 VA: 0x180625EC0
	public GameObject GetPanel() { }

	// RVA: 0x616F40 Offset: 0x615540 VA: 0x180616F40
	public void .ctor() { }
}
