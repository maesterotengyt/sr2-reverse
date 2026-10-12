// Namespace: 
public class TutorialDialogueHUD : UIScreen // TypeDefIndex: 2972
{
	// Fields
	[CompilerGenerated]
	private TutorialDialogueHUD.DialogueFinished OnDialogueFinished; // 0x58
	public float InitialDialogueSkipCooldown; // 0x60
	public TutorialDialoguesData DialoguesData; // 0x68
	public TextMeshProUGUI DialogueLabel; // 0x70
	public TextMeshProUGUI DialogueTitle; // 0x78
	[CompilerGenerated]
	private bool <IsDialogueActive>k__BackingField; // 0x80
	private Queue<DialogueData> dialoguesQueue; // 0x88
	private float runtimeInitialDialogueSkipCooldown; // 0x90

	// Properties
	public bool IsDialogueActive { get; set; }
	private UIManager uiManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x785570 Offset: 0x783B70 VA: 0x180785570
	public void add_OnDialogueFinished(TutorialDialogueHUD.DialogueFinished value) { }

	[CompilerGenerated]
	// RVA: 0x785660 Offset: 0x783C60 VA: 0x180785660
	public void remove_OnDialogueFinished(TutorialDialogueHUD.DialogueFinished value) { }

	[CompilerGenerated]
	// RVA: 0x5DC870 Offset: 0x5DAE70 VA: 0x1805DC870
	public bool get_IsDialogueActive() { }

	[CompilerGenerated]
	// RVA: 0x5DC950 Offset: 0x5DAF50 VA: 0x1805DC950
	public void set_IsDialogueActive(bool value) { }

	// RVA: 0x785610 Offset: 0x783C10 VA: 0x180785610
	private UIManager get_uiManager() { }

	// RVA: 0x785550 Offset: 0x783B50 VA: 0x180785550 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x7852E0 Offset: 0x7838E0 VA: 0x1807852E0
	protected void UpdateDialoguePanel() { }

	// RVA: 0x785030 Offset: 0x783630 VA: 0x180785030
	public void ShowDialogue(EventShowDialogue callback) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 13
	protected virtual void OnShowDialogue(TutorialSectionDialogue sectionDialogue) { }

	// RVA: 0x784FB0 Offset: 0x7835B0 VA: 0x180784FB0
	private void NextDialogue() { }

	// RVA: 0x784E40 Offset: 0x783440 VA: 0x180784E40
	private void EndDialogue() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 14
	protected virtual void OnDialogueEnd() { }

	// RVA: 0x778ED0 Offset: 0x7774D0 VA: 0x180778ED0
	public void .ctor() { }
}
