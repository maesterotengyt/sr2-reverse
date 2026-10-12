// Namespace: 
public class GameAdjustmentOptions : PauseSubMenu // TypeDefIndex: 3222
{
	// Fields
	[CompilerGenerated]
	private bool <IsInfiniteBoostActive>k__BackingField; // 0x58
	[CompilerGenerated]
	private FP <GameSpeed>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <GameSpeedIndex>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsFrameByFrameActive>k__BackingField; // 0x6C
	[Header("References")]
	public StellarSelectorOption InfiniteBoostSelector; // 0x70
	public StellarSelectorOption GameSpeedSelector; // 0x78
	public StellarSelectorOption FrameByFrameSelector; // 0x80
	public LocalizedString YesString; // 0x88
	public LocalizedString NoString; // 0x90
	private FP[] gameSpeeds; // 0x98

	// Properties
	public bool IsInfiniteBoostActive { get; set; }
	public FP GameSpeed { get; set; }
	public int GameSpeedIndex { get; set; }
	public bool IsFrameByFrameActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5818C0 Offset: 0x57FEC0 VA: 0x1805818C0
	public bool get_IsInfiniteBoostActive() { }

	[CompilerGenerated]
	// RVA: 0x581900 Offset: 0x57FF00 VA: 0x180581900
	public void set_IsInfiniteBoostActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5818A0 Offset: 0x57FEA0 VA: 0x1805818A0
	public FP get_GameSpeed() { }

	[CompilerGenerated]
	// RVA: 0x5818E0 Offset: 0x57FEE0 VA: 0x1805818E0
	public void set_GameSpeed(FP value) { }

	[CompilerGenerated]
	// RVA: 0x581890 Offset: 0x57FE90 VA: 0x180581890
	public int get_GameSpeedIndex() { }

	[CompilerGenerated]
	// RVA: 0x5818D0 Offset: 0x57FED0 VA: 0x1805818D0
	public void set_GameSpeedIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x5818B0 Offset: 0x57FEB0 VA: 0x1805818B0
	public bool get_IsFrameByFrameActive() { }

	[CompilerGenerated]
	// RVA: 0x5818F0 Offset: 0x57FEF0 VA: 0x1805818F0
	public void set_IsFrameByFrameActive(bool value) { }

	// RVA: 0x581170 Offset: 0x57F770 VA: 0x180581170 Slot: 4
	public override void Init(PauseMenu pauseMenu) { }

	// RVA: 0x5816B0 Offset: 0x57FCB0 VA: 0x1805816B0 Slot: 5
	public override void Show(bool inmediate = False) { }

	// RVA: 0x5814D0 Offset: 0x57FAD0 VA: 0x1805814D0
	public void OnInfiniteBoostChange(int option) { }

	// RVA: 0x581490 Offset: 0x57FA90 VA: 0x180581490
	public void OnGameSpeedChange(int option) { }

	// RVA: 0x581480 Offset: 0x57FA80 VA: 0x180581480
	public void OnFrameByFrameChange(int option) { }

	// RVA: 0x5814E0 Offset: 0x57FAE0 VA: 0x1805814E0
	public void ResetToDefaults() { }

	// RVA: 0x581030 Offset: 0x57F630 VA: 0x180581030
	public void ApplyGeneralOptions() { }

	// RVA: 0x5817C0 Offset: 0x57FDC0 VA: 0x1805817C0
	public void .ctor() { }
}
