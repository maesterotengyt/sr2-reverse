// Namespace: Quantum
[Serializable]
public class CameraManagerData : AssetObject // TypeDefIndex: 10206
{
	// Fields
	[Header("General")]
	public SimpleAABB StageCameraBounds; // 0x20
	public SimpleAABB DefaultViewPort; // 0x40
	public FP MaxHUDMultiplier; // 0x60
	[Header("Offset")]
	public FP VerticalOffset; // 0x68
	public FP HorizontalOffset; // 0x70
	public FP ProjectionOffset; // 0x78
	[Header("Zoom Multiplier")]
	public FP ZoomInMultiplier; // 0x80
	public FP ZoomOutMultiplier; // 0x88
	[Header("Interpolation Multiplier")]
	public bool ApplyInterpolation; // 0x90
	public FP PositionInterpolationSpeed; // 0x98
	public FP ZoomInterpolationSpeed; // 0xA0
	[Header("Tilt Settings")]
	public bool TiltCamera; // 0xA8
	public float TiltXAngle; // 0xAC
	public float TiltMaxAngle; // 0xB0
	public float TiltSpeed; // 0xB4
	public float TiltFactor; // 0xB8

	// Methods

	// RVA: 0x214FC80 Offset: 0x214E280 VA: 0x18214FC80 Slot: 6
	public virtual SimpleAABB UpdateCameraRect(Frame frame, GlobalCameraSettingsData GlobalData, bool forcePosition = False) { }

	// RVA: 0x214FC40 Offset: 0x214E240 VA: 0x18214FC40
	public FP GetSaveHUDSpaceMultiplier(FPVector2 maxPoint, GlobalCameraSettingsData globalData) { }

	// RVA: 0x214F820 Offset: 0x214DE20 VA: 0x18214F820
	public static SimpleAABB GetCameraTargetsBounds(Frame frame, GlobalCameraSettingsData GlobalData, CameraManagerData cameraData, bool excludeCharacter = False) { }

	// RVA: 0x63B230 Offset: 0x639830 VA: 0x18063B230
	public SimpleAABB UpdateFocusPosition(FPVector2 CenterPosition, SimpleAABB BaseRect) { }

	// RVA: 0x214F7B0 Offset: 0x214DDB0 VA: 0x18214F7B0
	public static bool CheckIfCameraTargetIsInsideStageBounds(CameraTarget* target, SimpleAABB StageCameraBounds) { }

	// RVA: 0x214F690 Offset: 0x214DC90 VA: 0x18214F690
	public SimpleAABB AdjustCameraRectInStageBounds(SimpleAABB cameraTargetRect) { }

	// RVA: 0x214FDB0 Offset: 0x214E3B0 VA: 0x18214FDB0
	public void .ctor() { }
}
