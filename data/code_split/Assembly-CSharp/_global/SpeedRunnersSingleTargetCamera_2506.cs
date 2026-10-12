// Namespace: 
public class SpeedRunnersSingleTargetCamera : SpeedRunnersCamera // TypeDefIndex: 2506
{
	// Fields
	private FP Zoom; // 0xA8
	private FPVector2 LookAhead; // 0xB0

	// Methods

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 5
	public override bool HandleCameraViewLocally() { }

	// RVA: 0x63A750 Offset: 0x638D50 VA: 0x18063A750 Slot: 6
	public override void AdjustToCameraView() { }

	// RVA: 0x63B130 Offset: 0x639730 VA: 0x18063B130
	public static FPVector2 InterpolateCameraToPosition(Frame frame, FPVector2 desiredViewTarget, FPVector2 currentViewTarget, FP interpolationStep, FP delta) { }

	// RVA: 0x63B230 Offset: 0x639830 VA: 0x18063B230
	public SimpleAABB UpdateFocusPosition(FPVector2 CenterPosition, SimpleAABB BaseRect) { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
