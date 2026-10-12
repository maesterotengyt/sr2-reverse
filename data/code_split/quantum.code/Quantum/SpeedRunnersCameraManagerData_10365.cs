// Namespace: Quantum
[Serializable]
public class SpeedRunnersCameraManagerData : CameraManagerData // TypeDefIndex: 10365
{
	// Methods

	// RVA: 0x21940D0 Offset: 0x21926D0 VA: 0x1821940D0 Slot: 6
	public override SimpleAABB UpdateCameraRect(Frame frame, GlobalCameraSettingsData globalData, bool forceUpdate = False) { }

	// RVA: 0x2192930 Offset: 0x2190F30 VA: 0x182192930
	public SimpleAABB CalculateMultiplayerCameraRect(Frame frame, CameraManager* cameraManager, SpeedRunnersSettingsData speedRunnersSettingsData, GlobalCameraSettingsData globalData, bool forceUpdate = False) { }

	// RVA: 0x2193770 Offset: 0x2191D70 VA: 0x182193770
	public SimpleAABB CalculateSinglePlayerCameraRect(Frame frame, CameraManager* cameraManager, SpeedRunnersSettingsData speedRunnersSettingsData, GlobalCameraSettingsData globalData, bool forceUpdate = False) { }

	// RVA: 0x217EEA0 Offset: 0x217D4A0 VA: 0x18217EEA0
	public static FPVector2 InterpolateCameraToPosition(Frame frame, FPVector2 desiredViewTarget, FPVector2 currentViewTarget, FP interpolationStep) { }

	// RVA: 0x217BAB0 Offset: 0x217A0B0 VA: 0x18217BAB0
	public void .ctor() { }
}
