// Namespace: 
public class StellarSettingsSystem : StellarMonoBehaviour // TypeDefIndex: 3575
{
	// Fields
	public List<Resolution> ScreenResolutions; // 0x20
	private UniversalRenderPipelineAsset renderPipelineAsset; // 0x28

	// Methods

	// RVA: 0x5F5570 Offset: 0x5F3B70 VA: 0x1805F5570
	public void Initialize() { }

	// RVA: 0x5F5450 Offset: 0x5F3A50 VA: 0x1805F5450
	public UniversalRenderPipelineAsset GetPipelineAsset() { }

	// RVA: 0x5F57A0 Offset: 0x5F3DA0 VA: 0x1805F57A0
	public void SetLanguage(string languageCode) { }

	// RVA: 0x5F5070 Offset: 0x5F3670 VA: 0x1805F5070
	public string GetCurrentLanguageCode() { }

	// RVA: 0x5F4FB0 Offset: 0x5F35B0 VA: 0x1805F4FB0
	public void ChangeResolution(int resolutionWidth, int resolutionHeight) { }

	// RVA: 0x5F5990 Offset: 0x5F3F90 VA: 0x1805F5990
	public void SetRenderScale(float renderScale) { }

	// RVA: 0x5F4EF0 Offset: 0x5F34F0 VA: 0x1805F4EF0
	public void ChangeResolution(int resolutionWidth, int resolutionHeight, FullScreenMode fullScreenMode) { }

	// RVA: 0x5F4EE0 Offset: 0x5F34E0 VA: 0x1805F4EE0
	public void ChangeFullscreenMode(FullScreenMode fullScreenMode) { }

	// RVA: 0x5F5230 Offset: 0x5F3830 VA: 0x1805F5230
	public Resolution GetCurrentResolution() { }

	// RVA: 0x5F59E0 Offset: 0x5F3FE0 VA: 0x1805F59E0
	public void SetScreenResolutions() { }

	// RVA: 0x5F5FF0 Offset: 0x5F45F0 VA: 0x1805F5FF0
	public void SetVsync(bool vSyncCount) { }

	// RVA: 0x5F5740 Offset: 0x5F3D40 VA: 0x1805F5740
	public void SetFrameLimit(int framerate) { }

	// RVA: 0x5F5980 Offset: 0x5F3F80 VA: 0x1805F5980
	public void SetQualityLevel(int qualityLevel) { }

	// RVA: 0x5F5710 Offset: 0x5F3D10 VA: 0x1805F5710
	public void SetAntialiasing(int samplesPerPixel) { }

	// RVA: 0x5F4E30 Offset: 0x5F3430 VA: 0x1805F4E30
	public void ChangeAllShadowsMode(LightShadows mode) { }

	// RVA: 0x5F5610 Offset: 0x5F3C10 VA: 0x1805F5610
	public void SendBugReport(string fileName, string logFile, byte[] screenshot, byte[] saveFile) { }

	// RVA: 0x5F6080 Offset: 0x5F4680 VA: 0x1805F6080
	private void UploadFile(string fileName, byte[] bytes) { }

	// RVA: 0x5F6260 Offset: 0x5F4860 VA: 0x1805F6260
	public void .ctor() { }
}
