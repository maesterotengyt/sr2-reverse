// Namespace: 
public class MechanicTutorialDialogueHUD : TutorialDialogueHUD // TypeDefIndex: 2956
{
	// Fields
	public GameObject DialoguesPanel; // 0x98
	public GameObject FullScreenVideoPanel; // 0xA0
	public VideoPlayer VideoPlayer; // 0xA8
	public GameObject[] VideoOutputs; // 0xB0
	private MechanicTutorialDialogueHUD.SubScreen activeScreen; // 0xB8
	private AsyncOperationHandle<VideoClip> videoOperationHandle; // 0xC0

	// Methods

	// RVA: 0x778900 Offset: 0x776F00 VA: 0x180778900
	private void OnDestroy() { }

	// RVA: 0x778B00 Offset: 0x777100 VA: 0x180778B00
	private void OnVideoLoaded(AsyncOperationHandle<VideoClip> operation) { }

	// RVA: 0x7788B0 Offset: 0x776EB0 VA: 0x1807788B0
	private void ClearVideos() { }

	// RVA: 0x778C30 Offset: 0x777230 VA: 0x180778C30
	private void ResetVideos() { }

	// RVA: 0x778C80 Offset: 0x777280 VA: 0x180778C80
	private void ToggleVideoOutputs(bool visibleState) { }

	// RVA: 0x7787F0 Offset: 0x776DF0 VA: 0x1807787F0
	private void ChangeSubScreen(MechanicTutorialDialogueHUD.SubScreen targetScreen) { }

	// RVA: 0x778D10 Offset: 0x777310 VA: 0x180778D10
	private void UpdateFullScreenDialoguePanel() { }

	// RVA: 0x778DB0 Offset: 0x7773B0 VA: 0x180778DB0 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x7789B0 Offset: 0x776FB0 VA: 0x1807789B0 Slot: 13
	protected override void OnShowDialogue(TutorialSectionDialogue sectionDialogue) { }

	// RVA: 0x7788B0 Offset: 0x776EB0 VA: 0x1807788B0 Slot: 14
	protected override void OnDialogueEnd() { }

	// RVA: 0x778ED0 Offset: 0x7774D0 VA: 0x180778ED0
	public void .ctor() { }
}
