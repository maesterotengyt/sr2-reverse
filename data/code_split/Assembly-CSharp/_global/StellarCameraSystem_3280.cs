// Namespace: 
public class StellarCameraSystem : MonoBehaviour // TypeDefIndex: 3280
{
	// Fields
	public readonly CameraManagerData DefaultCameraData; // 0x20
	public Camera Camera; // 0x28
	public StellarStageCamera StageCamera; // 0x30
	public StellarStillCamera StillCamera; // 0x38
	public CinemachineBrain CinemachineBrain; // 0x40
	private StellarCamera[] customStellarCameras; // 0x48
	private HashString activeCameraID; // 0x50
	private StellarCamera activeCamera; // 0x60

	// Properties
	public HashString StageCameraID { get; }
	public HashString StillCameraID { get; }
	public HashString ActiveCameraID { get; }
	public StellarCamera ActiveCamera { get; }

	// Methods

	// RVA: 0x5A48B0 Offset: 0x5A2EB0 VA: 0x1805A48B0
	public HashString get_StageCameraID() { }

	// RVA: 0x5A48E0 Offset: 0x5A2EE0 VA: 0x1805A48E0
	public HashString get_StillCameraID() { }

	// RVA: 0x5A48A0 Offset: 0x5A2EA0 VA: 0x1805A48A0
	public HashString get_ActiveCameraID() { }

	// RVA: 0x5818A0 Offset: 0x57FEA0 VA: 0x1805818A0
	public StellarCamera get_ActiveCamera() { }

	// RVA: 0x5A4260 Offset: 0x5A2860 VA: 0x1805A4260
	public void Initialize() { }

	// RVA: 0x5A44C0 Offset: 0x5A2AC0 VA: 0x1805A44C0
	public void SetupCameras(StellarCamera[] customStellarCameras) { }

	// RVA: 0x5A4000 Offset: 0x5A2600 VA: 0x1805A4000
	public void EnableStageCamera() { }

	// RVA: 0x5A3BD0 Offset: 0x5A21D0 VA: 0x1805A3BD0
	public void DisableStageCamera() { }

	// RVA: 0x5A4040 Offset: 0x5A2640 VA: 0x1805A4040
	public void EnableStillCamera() { }

	// RVA: 0x5A3CB0 Offset: 0x5A22B0 VA: 0x1805A3CB0
	public void DisableStillCamera() { }

	// RVA: 0x5A4330 Offset: 0x5A2930 VA: 0x1805A4330
	public void SetCameraTransform(HashString cameraID, Transform transform) { }

	// RVA: 0x5A3D90 Offset: 0x5A2390 VA: 0x1805A3D90
	public void EnableCustomCamera(HashString cameraID, bool force = False) { }

	// RVA: 0x5A3A20 Offset: 0x5A2020 VA: 0x1805A3A20
	public void DisableAllCameras() { }

	// RVA: 0x5A3AC0 Offset: 0x5A20C0 VA: 0x1805A3AC0
	public void DisableCustomCamera(HashString cameraID, bool force = False) { }

	// RVA: 0x5A4190 Offset: 0x5A2790 VA: 0x1805A4190
	public StellarCamera GetCamera(HashString cameraID) { }

	// RVA: 0x5A42F0 Offset: 0x5A28F0 VA: 0x1805A42F0
	public void SetCameraBlendStyle(CinemachineBlendDefinition.Style style) { }

	// RVA: 0x5A4310 Offset: 0x5A2910 VA: 0x1805A4310
	public void SetCameraBlendTime(float time) { }

	// RVA: 0x5A4140 Offset: 0x5A2740 VA: 0x1805A4140
	public Vector3 GetCameraPosition() { }

	// RVA: 0x5A4080 Offset: 0x5A2680 VA: 0x1805A4080
	public float GetCameraDistanceToPoint(Vector3 point) { }

	// RVA: 0x5A46D0 Offset: 0x5A2CD0 VA: 0x1805A46D0
	public void UpdateCamera(Frame frame, CameraManager* cameraManager) { }

	// RVA: 0x5A4810 Offset: 0x5A2E10 VA: 0x1805A4810
	public void .ctor() { }
}
