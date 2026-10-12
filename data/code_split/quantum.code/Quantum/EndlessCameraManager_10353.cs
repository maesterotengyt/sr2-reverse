// Namespace: Quantum
[Serializable]
public class EndlessCameraManager : CameraManagerData // TypeDefIndex: 10353
{
	// Methods

	// RVA: 0x217EFB0 Offset: 0x217D5B0 VA: 0x18217EFB0 Slot: 6
	public override SimpleAABB UpdateCameraRect(Frame frame, GlobalCameraSettingsData globalData, bool forceUpdate = False) { }

	// RVA: 0x217E950 Offset: 0x217CF50 VA: 0x18217E950
	public SimpleAABB CalculateCameraRect(Frame frame, CameraManager* cameraManager, SpeedRunnersSettingsData speedRunnersSettingsData, GlobalCameraSettingsData globalData, bool forceUpdate = False) { }

	// RVA: 0x217EEA0 Offset: 0x217D4A0 VA: 0x18217EEA0
	public static FPVector2 InterpolateCameraToPosition(Frame frame, FPVector2 desiredViewTarget, FPVector2 currentViewTarget, FP interpolationStep) { }

	// RVA: 0x217BAB0 Offset: 0x217A0B0 VA: 0x18217BAB0
	public void .ctor() { }
}
