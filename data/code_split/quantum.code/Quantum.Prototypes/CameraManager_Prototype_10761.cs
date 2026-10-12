// Namespace: Quantum.Prototypes
[Prototype(typeof(CameraManager))]
[Serializable]
public sealed class CameraManager_Prototype : ComponentPrototype<CameraManager> // TypeDefIndex: 10761
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	public QBoolean ExcludeAsVisibilitySource; // 0x20
	public AssetRefCameraManagerData CameraManagerData; // 0x28
	public AssetRefGlobalCameraSettingsData GlobalSettingsData; // 0x30
	[HideInInspector]
	public SimpleAABB_Prototype CameraRect; // 0x38
	[HideInInspector]
	public FP Zoom; // 0x40
	[HideInInspector]
	public FPVector2 LookAhead; // 0x48

	// Methods

	// RVA: 0x20FD2E0 Offset: 0x20FB8E0 VA: 0x1820FD2E0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FD4E0 Offset: 0x20FBAE0 VA: 0x1820FD4E0
	public void Materialize(Frame frame, ref CameraManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FD450 Offset: 0x20FBA50 VA: 0x1820FD450 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FD560 Offset: 0x20FBB60 VA: 0x1820FD560
	public void .ctor() { }
}
