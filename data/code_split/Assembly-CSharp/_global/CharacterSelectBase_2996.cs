// Namespace: 
public class CharacterSelectBase : MainMenuScreen // TypeDefIndex: 2996
{
	// Fields
	public CharactersSelectorsManager SelectorsManager; // 0x90
	public MenuPlayersHighlight PlayerHighlights; // 0x98
	public CancelHoldBar CancelHoldBar; // 0xA0
	public GameObject SkinChangePrompt; // 0xA8
	public LocalizedString PlayerShorteningString; // 0xB0
	public LocalizedString CPUString; // 0xB8
	[CompilerGenerated]
	private bool <ReadyToStart>k__BackingField; // 0xC0
	[CompilerGenerated]
	private bool <EditingCPU>k__BackingField; // 0xC1

	// Properties
	public bool ReadyToStart { get; set; }
	public bool EditingCPU { get; set; }
	protected UIManager uiManager { get; }
	protected AudioManager audioManager { get; }
	protected OnlineManager onlineManager { get; }
	protected SaveManager saveManager { get; }
	protected GameStateManager gameStateManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x773830 Offset: 0x771E30 VA: 0x180773830
	public bool get_ReadyToStart() { }

	[CompilerGenerated]
	// RVA: 0x7739E0 Offset: 0x771FE0 VA: 0x1807739E0
	public void set_ReadyToStart(bool value) { }

	[CompilerGenerated]
	// RVA: 0x773820 Offset: 0x771E20 VA: 0x180773820
	public bool get_EditingCPU() { }

	[CompilerGenerated]
	// RVA: 0x7739D0 Offset: 0x771FD0 VA: 0x1807739D0
	public void set_EditingCPU(bool value) { }

	// RVA: 0x773980 Offset: 0x771F80 VA: 0x180773980
	protected UIManager get_uiManager() { }

	// RVA: 0x773840 Offset: 0x771E40 VA: 0x180773840
	protected AudioManager get_audioManager() { }

	// RVA: 0x7738E0 Offset: 0x771EE0 VA: 0x1807738E0
	protected OnlineManager get_onlineManager() { }

	// RVA: 0x773930 Offset: 0x771F30 VA: 0x180773930
	protected SaveManager get_saveManager() { }

	// RVA: 0x773890 Offset: 0x771E90 VA: 0x180773890
	protected GameStateManager get_gameStateManager() { }

	// RVA: 0x773090 Offset: 0x771690 VA: 0x180773090 Slot: 4
	public override void Initialize() { }

	// RVA: 0x7730D0 Offset: 0x7716D0 VA: 0x1807730D0 Slot: 5
	public override void Load() { }

	// RVA: 0x773640 Offset: 0x771C40 VA: 0x180773640 Slot: 7
	public override void Show() { }

	// RVA: 0x773050 Offset: 0x771650 VA: 0x180773050 Slot: 8
	public override void Hide() { }

	// RVA: 0x772A70 Offset: 0x771070 VA: 0x180772A70
	private void GenerateSelectors() { }

	// RVA: 0x773190 Offset: 0x771790 VA: 0x180773190
	public void ProcessSelectors() { }

	// RVA: 0x773790 Offset: 0x771D90 VA: 0x180773790 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x773600 Offset: 0x771C00 VA: 0x180773600 Slot: 13
	public override void ReturnToPreviousScreen(string screen = "Undefined", string cameraTransition = "") { }

	// RVA: 0x772A40 Offset: 0x771040 VA: 0x180772A40 Slot: 12
	public override void Disable() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
