// Namespace: 
public class RewardUnlockedPopup : SRMonoBehaviour // TypeDefIndex: 3252
{
	// Fields
	public StellarUIAnimator Animator; // 0x20
	public Image RewardImage; // 0x28
	public TMP_Text RewardTextShadow; // 0x30
	public TMP_Text RewardText; // 0x38
	public TMP_Text RewardCount; // 0x40
	public TMP_Text RewardName; // 0x48
	public TMP_Text RewardDescription; // 0x50
	public LocalizedString IconString; // 0x58
	public LocalizedString TitleString; // 0x60
	public LocalizedString CatchPhraseString; // 0x68
	public LocalizedString BackgroundString; // 0x70
	public LocalizedString TrailString; // 0x78
	public LocalizedString SkinString; // 0x80
	public LocalizedString IconDescription; // 0x88
	public LocalizedString TitleDescription; // 0x90
	public LocalizedString CatchPhraseDescription; // 0x98
	public LocalizedString BackgroundDescription; // 0xA0
	public LocalizedString TrailDescription; // 0xA8
	public LocalizedString SkinDescription; // 0xB0
	public LocalizedString ContinueString; // 0xB8
	public LocalizedString PreviousString; // 0xC0
	public LocalizedString ClaimAllString; // 0xC8
	public ScreenFooterButton NextFooterButton; // 0xD0
	public ScreenFooterButton BackFooterButton; // 0xD8
	public ScreenFooterButton SkipFooterButton; // 0xE0
	public RectTransformAutoRebuild ButtonsRebuild; // 0xE8
	public bool IsShowingLastReward; // 0xF0
	public bool Active; // 0xF1
	private int currentIndex; // 0xF4

	// Methods

	// RVA: 0x5A2E70 Offset: 0x5A1470 VA: 0x1805A2E70
	private void Update() { }

	// RVA: 0x5A2CC0 Offset: 0x5A12C0 VA: 0x1805A2CC0
	public void Show() { }

	// RVA: 0x5A1DF0 Offset: 0x5A03F0 VA: 0x1805A1DF0
	public void Hide() { }

	[IteratorStateMachine(typeof(RewardUnlockedPopup.<HideAndDeactivate>d__32))]
	// RVA: 0x5A1D80 Offset: 0x5A0380 VA: 0x1805A1D80
	private IEnumerator HideAndDeactivate() { }

	// RVA: 0x5A1FA0 Offset: 0x5A05A0 VA: 0x1805A1FA0
	public void ShowReward() { }

	// RVA: 0x5A1ED0 Offset: 0x5A04D0 VA: 0x1805A1ED0
	public void NextReward() { }

	// RVA: 0x5A1F30 Offset: 0x5A0530 VA: 0x1805A1F30
	public void PreviousReward() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
