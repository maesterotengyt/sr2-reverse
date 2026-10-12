// Namespace: 
public class MainMenuStreetTexts : SRMonoBehaviour // TypeDefIndex: 3041
{
	// Fields
	public Animator Animator; // 0x20
	public List<TMP_Text> Texts; // 0x28
	public RectTransformAutoRebuild AutoRebuild; // 0x30
	public List<ScrollingRows> ScrollingRows; // 0x38
	[Header("Strings")]
	public LocalizedString LocalVersusString; // 0x40
	public LocalizedString PracticeString; // 0x48
	public LocalizedString QuickString; // 0x50
	public LocalizedString RankedString; // 0x58
	public LocalizedString Ranked1v1String; // 0x60
	public LocalizedString CustomString; // 0x68
	public LocalizedString EightPlayersString; // 0x70
	public LocalizedString PlaygroundString; // 0x78

	// Methods

	[Button("Found Texts")]
	// RVA: 0x54AA10 Offset: 0x549010 VA: 0x18054AA10
	public void FoundTexts() { }

	// RVA: 0x54A650 Offset: 0x548C50 VA: 0x18054A650
	public void AssignLocalVersusTexts() { }

	// RVA: 0x54A740 Offset: 0x548D40 VA: 0x18054A740
	public void AssignPracticeTexts() { }

	// RVA: 0x54A690 Offset: 0x548C90 VA: 0x18054A690
	public void AssignOnlineTexts() { }

	// RVA: 0x54A780 Offset: 0x548D80 VA: 0x18054A780
	public void AssignText(string newText) { }

	// RVA: 0x54AB00 Offset: 0x549100 VA: 0x18054AB00
	public void Show() { }

	// RVA: 0x54AAB0 Offset: 0x5490B0 VA: 0x18054AAB0
	public void Hide() { }

	// RVA: 0x54AB50 Offset: 0x549150 VA: 0x18054AB50
	public void .ctor() { }
}
