// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CameraManager))]
[Serializable]
public class CameraManager_Prototype : PrototypeAdapter<CameraManager_Prototype> // TypeDefIndex: 3870
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
	public QBoolean ExcludeAsVisibilitySource; // 0x1C
	public AssetRefCameraManagerData CameraManagerData; // 0x20
	public AssetRefGlobalCameraSettingsData GlobalSettingsData; // 0x28
	[HideInInspector]
	public SimpleAABB_Prototype CameraRect; // 0x30
	[HideInInspector]
	public FP Zoom; // 0x38
	[HideInInspector]
	public FPVector2 LookAhead; // 0x40

	// Methods

	// RVA: 0x672260 Offset: 0x670860 VA: 0x180672260 Slot: 5
	public sealed override CameraManager_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672320 Offset: 0x670920 VA: 0x180672320
	public void .ctor() { }
}
