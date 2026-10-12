// Namespace: 
public class CharacterViewerPlaylistElement : CharacterViewerAnimationListElement // TypeDefIndex: 3629
{
	// Fields
	public Animator Animator; // 0xD8
	public TMP_Text IndexText; // 0xE0
	public TMP_InputField LabelInput; // 0xE8
	private bool labelActive; // 0xF0
	private bool selected; // 0xF1
	private bool editInput; // 0xF2
	private CharacterViewerPlaylistEditor editor; // 0xF8

	// Methods

	// RVA: 0x60C870 Offset: 0x60AE70 VA: 0x18060C870
	public void Init(CharacterViewerPlaylistEditor editor) { }

	// RVA: 0x60C890 Offset: 0x60AE90 VA: 0x18060C890 Slot: 4
	public override void LoadCharacterData(CharacterViewerAnimationData animationData) { }

	// RVA: 0x60CE20 Offset: 0x60B420 VA: 0x18060CE20 Slot: 5
	public override void Show(int index) { }

	// RVA: 0x60CB80 Offset: 0x60B180 VA: 0x18060CB80
	public void SetLabelText() { }

	// RVA: 0x60CA20 Offset: 0x60B020 VA: 0x18060CA20 Slot: 6
	public override void Select(bool selected) { }

	// RVA: 0x60C790 Offset: 0x60AD90 VA: 0x18060C790 Slot: 7
	public override void Highlight(bool highlighted) { }

	// RVA: 0x60C960 Offset: 0x60AF60 VA: 0x18060C960
	private void ResetTriggers() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x60D020 Offset: 0x60B620 VA: 0x18060D020
	private bool <SetLabelText>b__10_0(CharacterViewerAnimationData x) { }
}
