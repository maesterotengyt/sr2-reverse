// Namespace: Quantum
public struct CameraTarget : IComponent // TypeDefIndex: 9958
{
	// Fields
	public QBoolean Active; // 0x0
	public SimpleAABB BaseFocusRect; // 0x38
	public EntityRef Entity; // 0x10
	[HideInInspector]
	public SimpleAABB FocusRect; // 0x58
	public FP ForwardDistance; // 0x18
	public FP ForwardInterpolationSpeed; // 0x20
	public QBoolean InterpolatePosition; // 0x4
	[HideInInspector]
	public FP Scale; // 0x28
	public FP VerticalOffset; // 0x30
	[PtrQList(typeof(int))]
	private Ptr ViewerIndexesPtr; // 0xC
	public QBoolean Visible; // 0x8
	private static ColorRGBA CameraTargetColor; // 0x0

	// Properties
	public QListPtr<int> ViewerIndexes { get; set; }

	// Methods

	// RVA: 0x20CA720 Offset: 0x20C8D20 VA: 0x1820CA720
	public QListPtr<int> get_ViewerIndexes() { }

	// RVA: 0x1ED2120 Offset: 0x1ED0720 VA: 0x181ED2120
	public void set_ViewerIndexes(QListPtr<int> value) { }

	// RVA: 0x20C9B90 Offset: 0x20C8190 VA: 0x1820C9B90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C9B80 Offset: 0x20C8180 VA: 0x1820C9B80
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20C9DA0 Offset: 0x20C83A0 VA: 0x1820C9DA0
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20C9E40 Offset: 0x20C8440 VA: 0x1820C9E40
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20C9CE0 Offset: 0x20C82E0 VA: 0x1820C9CE0
	public void OnInit(Frame frame, EntityRef entity) { }

	// RVA: 0x20CA200 Offset: 0x20C8800 VA: 0x1820CA200
	public void Update(Frame frame) { }

	// RVA: 0x20C9AB0 Offset: 0x20C80B0 VA: 0x1820C9AB0
	public FPVector2 ClampWithinAABB(FPVector2 position) { }

	// RVA: 0x20CA0B0 Offset: 0x20C86B0 VA: 0x1820CA0B0
	public void UpdateFocusPosition(Frame frame, FPVector2 InterpolatedCenterPosition, FP scale) { }

	// RVA: 0x20C9C90 Offset: 0x20C8290 VA: 0x1820C9C90
	public FP GetValue(Frame frame, CameraTargetVariable variable) { }

	// RVA: 0x20C9FF0 Offset: 0x20C85F0 VA: 0x1820C9FF0
	public void SetValue(Frame frame, CameraTargetVariable variable, FP value) { }

	// RVA: 0x20CA6D0 Offset: 0x20C8CD0 VA: 0x1820CA6D0
	private static void .cctor() { }
}
