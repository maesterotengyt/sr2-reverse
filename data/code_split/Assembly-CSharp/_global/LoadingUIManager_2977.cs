// Namespace: 
public class LoadingUIManager : SRMonoBehaviour // TypeDefIndex: 2977
{
	// Fields
	public SimpleLoadingScreen SimpleLoadingScreen; // 0x20
	public LoadingProgressBar LoadingProgressBar; // 0x28
	[CompilerGenerated]
	private float <LoadingAnimDuration>k__BackingField; // 0x30
	private LoadingScreen currentLoadingScreen; // 0x38

	// Properties
	public float LoadingAnimDuration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x778100 Offset: 0x776700 VA: 0x180778100
	public float get_LoadingAnimDuration() { }

	[CompilerGenerated]
	// RVA: 0x778110 Offset: 0x776710 VA: 0x180778110
	public void set_LoadingAnimDuration(float value) { }

	// RVA: 0x778040 Offset: 0x776640 VA: 0x180778040
	public void ShowLoadingScreen(bool immediate = False) { }

	// RVA: 0x777F40 Offset: 0x776540 VA: 0x180777F40
	public void HideLoadingScreen(bool immediate = False, float delay = 0) { }

	[IteratorStateMachine(typeof(LoadingUIManager.<HideLoadingScreenCoroutine>d__9))]
	// RVA: 0x777EC0 Offset: 0x7764C0 VA: 0x180777EC0
	private IEnumerator HideLoadingScreenCoroutine(float duration, bool immediate = False) { }

	// RVA: 0x778010 Offset: 0x776610 VA: 0x180778010
	public void ReportLoadingProgress(float loadingPercent) { }

	// RVA: 0x7780F0 Offset: 0x7766F0 VA: 0x1807780F0
	public void .ctor() { }
}
