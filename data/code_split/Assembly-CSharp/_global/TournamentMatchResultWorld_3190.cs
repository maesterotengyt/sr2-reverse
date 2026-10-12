// Namespace: 
public class TournamentMatchResultWorld : MainMenuWorldScreen // TypeDefIndex: 3190
{
	// Fields
	public OnlineBadgeElement OnlineBadge; // 0x30
	public Animator EliminationPanelAnimator; // 0x38
	public Animator QualifiedPanelAnimator; // 0x40
	public Animator WinnerPanelAnimator; // 0x48
	public LocalizedString EliminationString; // 0x50
	public LocalizedString QualifiedString; // 0x58
	public List<TextProxy> EliminationTextProxy; // 0x60
	public List<TextProxy> QualifiedTextProxy; // 0x68
	private int panelActiveTriggerID; // 0x70
	private int panelInactiveTriggerID; // 0x74
	private int panelShowTriggerID; // 0x78
	private int panelHideTriggerID; // 0x7C

	// Methods

	// RVA: 0x58EB80 Offset: 0x58D180 VA: 0x18058EB80 Slot: 5
	public override void Show() { }

	// RVA: 0x58E920 Offset: 0x58CF20 VA: 0x18058E920
	public void ShowEliminationPanel() { }

	// RVA: 0x58E970 Offset: 0x58CF70 VA: 0x18058E970
	public void ShowQualifiedPanel() { }

	// RVA: 0x58E9C0 Offset: 0x58CFC0 VA: 0x18058E9C0
	public void ShowWinnerPanelAnimator() { }

	// RVA: 0x58E8F0 Offset: 0x58CEF0 VA: 0x18058E8F0
	public void HideElements() { }

	// RVA: 0x58EDB0 Offset: 0x58D3B0 VA: 0x18058EDB0
	public void .ctor() { }
}
