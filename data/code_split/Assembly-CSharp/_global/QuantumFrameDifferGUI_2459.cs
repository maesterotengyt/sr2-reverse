// Namespace: 
public abstract class QuantumFrameDifferGUI // TypeDefIndex: 2459
{
	// Fields
	public int ReferenceActorId; // 0x10
	private string _search; // 0x18
	private string _gameId; // 0x20
	private int _scrollOffset; // 0x28
	protected bool _hidden; // 0x2C
	private const float HeaderHeight = 28;
	[CompilerGenerated]
	private QuantumFrameDifferGUI.FrameDifferState <State>k__BackingField; // 0x30

	// Properties
	public QuantumFrameDifferGUI.FrameDifferState State { get; set; }
	public virtual bool IsEditor { get; }
	public virtual int TextLineHeight { get; }
	public virtual GUIStyle DiffBackground { get; }
	public virtual GUIStyle DiffHeader { get; }
	public virtual GUIStyle DiffHeaderError { get; }
	public virtual GUIStyle DiffLineOverlay { get; }
	public virtual GUIStyle MiniButton { get; }
	public virtual GUIStyle TextLabel { get; }
	public virtual GUIStyle BoldLabel { get; }
	public virtual GUIStyle MiniButtonLeft { get; }
	public virtual GUIStyle MiniButtonRight { get; }
	public abstract Rect Position { get; }
	public virtual float ScrollWidth { get; }
	private StringComparer Comparer { get; }

	// Methods

	// RVA: 0x5290E0 Offset: 0x5276E0 VA: 0x1805290E0
	protected void .ctor(QuantumFrameDifferGUI.FrameDifferState state) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public QuantumFrameDifferGUI.FrameDifferState get_State() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_State(QuantumFrameDifferGUI.FrameDifferState value) { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 4
	public virtual bool get_IsEditor() { }

	// RVA: 0x52CEE0 Offset: 0x52B4E0 VA: 0x18052CEE0 Slot: 5
	public virtual int get_TextLineHeight() { }

	// RVA: 0x52CBD0 Offset: 0x52B1D0 VA: 0x18052CBD0 Slot: 6
	public virtual GUIStyle get_DiffBackground() { }

	// RVA: 0x52CC90 Offset: 0x52B290 VA: 0x18052CC90 Slot: 7
	public virtual GUIStyle get_DiffHeader() { }

	// RVA: 0x52CC30 Offset: 0x52B230 VA: 0x18052CC30 Slot: 8
	public virtual GUIStyle get_DiffHeaderError() { }

	// RVA: 0x52CCF0 Offset: 0x52B2F0 VA: 0x18052CCF0 Slot: 9
	public virtual GUIStyle get_DiffLineOverlay() { }

	// RVA: 0x52CE10 Offset: 0x52B410 VA: 0x18052CE10 Slot: 10
	public virtual GUIStyle get_MiniButton() { }

	// RVA: 0x52CE80 Offset: 0x52B480 VA: 0x18052CE80 Slot: 11
	public virtual GUIStyle get_TextLabel() { }

	// RVA: 0x52CAE0 Offset: 0x52B0E0 VA: 0x18052CAE0 Slot: 12
	public virtual GUIStyle get_BoldLabel() { }

	// RVA: 0x52CD50 Offset: 0x52B350 VA: 0x18052CD50 Slot: 13
	public virtual GUIStyle get_MiniButtonLeft() { }

	// RVA: 0x52CDB0 Offset: 0x52B3B0 VA: 0x18052CDB0 Slot: 14
	public virtual GUIStyle get_MiniButtonRight() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Rect get_Position();

	// RVA: 0x52CE70 Offset: 0x52B470 VA: 0x18052CE70 Slot: 16
	public virtual float get_ScrollWidth() { }

	// RVA: 0x52CB40 Offset: 0x52B140 VA: 0x18052CB40
	private StringComparer get_Comparer() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 17
	public virtual void Repaint() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void DrawHeader();

	// RVA: 0x52CAD0 Offset: 0x52B0D0 VA: 0x18052CAD0
	public void Show() { }

	// RVA: 0x52C730 Offset: 0x52AD30 VA: 0x18052C730
	public void OnGUI() { }

	// RVA: 0x52B9A0 Offset: 0x529FA0 VA: 0x18052B9A0
	private void DrawNoDumps() { }

	// RVA: 0x52BA50 Offset: 0x52A050 VA: 0x18052BA50
	private void DrawSelection() { }

	// RVA: 0x52A070 Offset: 0x528670 VA: 0x18052A070
	private void DrawDiff() { }

	// RVA: 0x5291B0 Offset: 0x5277B0 VA: 0x1805291B0
	private Rect CalculateLineRect(int line, Rect mainRect) { }

	// RVA: 0x529310 Offset: 0x527910 VA: 0x180529310
	private Rect CalculateTopBarRect() { }

	// RVA: 0x529270 Offset: 0x527870 VA: 0x180529270
	private Rect CalculateMainRect(int frameDataCount) { }

	// RVA: 0x52C8E0 Offset: 0x52AEE0 VA: 0x18052C8E0
	private void SearchDiff(QuantumFrameDifferGUI.FrameData frameData, QuantumFrameDifferGUI.FrameData baseFrame, int startIndex, int searchDirection) { }

	// RVA: 0x52CA00 Offset: 0x52B000 VA: 0x18052CA00
	private void Search(QuantumFrameDifferGUI.FrameData frameData, int startIndex, int searchDirection) { }

	// RVA: 0x52C4D0 Offset: 0x52AAD0 VA: 0x18052C4D0
	private Dictionary<int, QuantumFrameDifferGUI.FrameData> GetSelectedFrameData() { }

	// RVA: 0x529350 Offset: 0x527950 VA: 0x180529350
	private void Diff(Dictionary<int, QuantumFrameDifferGUI.FrameData> frames) { }
}
