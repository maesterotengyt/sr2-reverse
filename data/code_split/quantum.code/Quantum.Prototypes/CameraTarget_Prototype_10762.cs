// Namespace: Quantum.Prototypes
[Prototype(typeof(CameraTarget))]
[Serializable]
public sealed class CameraTarget_Prototype : ComponentPrototype<CameraTarget> // TypeDefIndex: 10762
{
	// Fields
	public QBoolean Active; // 0x18
	public QBoolean Visible; // 0x1C
	public MapEntityId Entity; // 0x20
	public SimpleAABB_Prototype BaseFocusRect; // 0x28
	[HideInInspector]
	public SimpleAABB_Prototype FocusRect; // 0x30
	[HideInInspector]
	public FP Scale; // 0x38
	public QBoolean InterpolatePosition; // 0x40
	public FP VerticalOffset; // 0x48
	public FP ForwardDistance; // 0x50
	public FP ForwardInterpolationSpeed; // 0x58
	[DynamicCollection]
	public int[] ViewerIndexes; // 0x60

	// Methods

	// RVA: 0x20FD5A0 Offset: 0x20FBBA0 VA: 0x1820FD5A0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FD7B0 Offset: 0x20FBDB0 VA: 0x1820FD7B0
	public void Materialize(Frame frame, ref CameraTarget result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FD720 Offset: 0x20FBD20 VA: 0x1820FD720 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FD9C0 Offset: 0x20FBFC0 VA: 0x1820FD9C0
	public void .ctor() { }
}
