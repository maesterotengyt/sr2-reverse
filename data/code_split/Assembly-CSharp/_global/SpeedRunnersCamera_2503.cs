// Namespace: 
public class SpeedRunnersCamera : StellarCamera // TypeDefIndex: 2503
{
	// Fields
	public CameraFOVSetting DebugCameraFOV; // 0x70
	public CameraSettingsPreset LowFOVCameraPreset; // 0x74
	public CameraSettingsPreset MediumFOVCameraPreset; // 0x80
	public CameraSettingsPreset HighFOVCameraPreset; // 0x8C
	private Transform cameraEntityTransform; // 0x98
	private bool useProjectionOffset; // 0xA0

	// Properties
	protected SaveManager saveManager { get; }

	// Methods

	// RVA: 0x636D90 Offset: 0x635390 VA: 0x180636D90
	protected SaveManager get_saveManager() { }

	// RVA: 0x636D00 Offset: 0x635300 VA: 0x180636D00
	private void Update() { }

	// RVA: 0x6361A0 Offset: 0x6347A0 VA: 0x1806361A0 Slot: 6
	public override void AdjustToCameraView() { }

	// RVA: 0x6366E0 Offset: 0x634CE0 VA: 0x1806366E0 Slot: 8
	protected virtual void MoveCameraToVirtualView() { }

	// RVA: 0x6365A0 Offset: 0x634BA0 VA: 0x1806365A0 Slot: 4
	public override void Init() { }

	// RVA: 0x636910 Offset: 0x634F10 VA: 0x180636910
	public void PlayCameraShake(int presetID, float force = -1, Nullable<Vector3> velocity) { }

	// RVA: 0x636AA0 Offset: 0x6350A0 VA: 0x180636AA0
	private void PlayCameraShake(EventPlayCameraShake callback) { }

	// RVA: 0x6364E0 Offset: 0x634AE0 VA: 0x1806364E0
	private CameraSettingsPreset GetCurrentCameraPreset() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
