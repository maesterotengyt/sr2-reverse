// Namespace: Quantum
[Serializable]
public class SuperSpeedBrosCameraManagerData : CameraManagerData // TypeDefIndex: 10366
{
	// Fields
	[Header("SpeedBros specific Camera Settings")]
	public FP MaxZoom; // 0xC0
	public FP MinZoom; // 0xC8
	public FP ZoomScale; // 0xD0
	public FP MovementSmoothing; // 0xD8

	// Methods

	// RVA: 0x21966D0 Offset: 0x2194CD0 VA: 0x1821966D0 Slot: 6
	public override SimpleAABB UpdateCameraRect(Frame frame, GlobalCameraSettingsData globalData, bool forceUpdate = False) { }

	// RVA: 0x21965C0 Offset: 0x2194BC0 VA: 0x1821965C0
	public static FPVector2 InterpolateCameraToPosition(Frame frame, FPVector2 desiredViewTarget, FPVector2 currentViewTarget, FP interpolationStep) { }

	// RVA: 0x2197080 Offset: 0x2195680 VA: 0x182197080
	public void .ctor() { }
}
