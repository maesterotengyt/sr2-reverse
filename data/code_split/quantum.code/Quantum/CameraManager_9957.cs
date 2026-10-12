// Namespace: Quantum
public struct CameraManager : IComponent // TypeDefIndex: 9957
{
	// Fields
	public QBoolean Active; // 0x0
	public AssetRefCameraManagerData CameraManagerData; // 0x8
	[HideInInspector]
	public SimpleAABB CameraRect; // 0x38
	public EntityRef Entity; // 0x18
	public QBoolean ExcludeAsVisibilitySource; // 0x4
	public AssetRefGlobalCameraSettingsData GlobalSettingsData; // 0x10
	[HideInInspector]
	public FPVector2 LookAhead; // 0x28
	[HideInInspector]
	public FP Zoom; // 0x20

	// Methods

	// RVA: 0x20C9420 Offset: 0x20C7A20 VA: 0x1820C9420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C94F0 Offset: 0x20C7AF0 VA: 0x1820C94F0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20C9600 Offset: 0x20C7C00 VA: 0x1820C9600
	public static bool TryFind(Frame frame, out CameraManager* cameraManager) { }

	// RVA: 0x20C8F90 Offset: 0x20C7590 VA: 0x1820C8F90
	public void CheckInitialSettings(Frame frame) { }

	// RVA: 0x20C9750 Offset: 0x20C7D50 VA: 0x1820C9750
	public void Update(Frame frame) { }

	// RVA: 0x20C90C0 Offset: 0x20C76C0 VA: 0x1820C90C0
	public void ForceUpdate(Frame frame) { }

	// RVA: 0x20C99E0 Offset: 0x20C7FE0 VA: 0x1820C99E0
	public FPVector2 WorldToViewport(FPVector2 vector) { }

	// RVA: 0x20C9930 Offset: 0x20C7F30 VA: 0x1820C9930
	public FPVector2 ViewportToWorld(FPVector2 vector) { }
}
