// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CameraTarget))]
[Serializable]
public class CameraTarget_Prototype : PrototypeAdapter<CameraTarget_Prototype> // TypeDefIndex: 3871
{
	// Fields
	public QBoolean Active; // 0x10
	public QBoolean Visible; // 0x14
	[LocalReference]
	public EntityPrototype Entity; // 0x18
	public SimpleAABB_Prototype BaseFocusRect; // 0x20
	[HideInInspector]
	public SimpleAABB_Prototype FocusRect; // 0x28
	[HideInInspector]
	public FP Scale; // 0x30
	public QBoolean InterpolatePosition; // 0x38
	public FP VerticalOffset; // 0x40
	public FP ForwardDistance; // 0x48
	public FP ForwardInterpolationSpeed; // 0x50
	[DynamicCollection]
	public int[] ViewerIndexes; // 0x58

	// Methods

	// RVA: 0x672360 Offset: 0x670960 VA: 0x180672360 Slot: 5
	public sealed override CameraTarget_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672450 Offset: 0x670A50 VA: 0x180672450
	public void .ctor() { }
}
