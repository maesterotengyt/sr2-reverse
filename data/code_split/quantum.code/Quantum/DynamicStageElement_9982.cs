// Namespace: Quantum
public struct DynamicStageElement : IComponent // TypeDefIndex: 9982
{
	// Fields
	public QBoolean Active; // 0x4
	public QBoolean BackwardsMode; // 0x8
	public FP CurrentFrame; // 0x18
	public LoopMode LoopMode; // 0x0
	public AssetRefTransformKeyFramesData TransformKeyFramesData; // 0x10

	// Methods

	// RVA: 0x20E0750 Offset: 0x20DED50 VA: 0x1820E0750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E08E0 Offset: 0x20DEEE0 VA: 0x1820E08E0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20E07A0 Offset: 0x20DEDA0 VA: 0x1820E07A0
	public void OnInit(Frame frame, EntityRef entity) { }

	// RVA: 0x20E0EC0 Offset: 0x20DF4C0 VA: 0x1820E0EC0
	public void Update(Frame frame, EntityRef entity) { }

	// RVA: 0x20E0C30 Offset: 0x20DF230 VA: 0x1820E0C30
	public void UpdateTrasfromKeyframeLoopMode(Frame frame, EntityRef entity, FP CurrentFrame, TransformKeyFramesData transformKeyFrames, KinematicBody* kinematicBody) { }

	// RVA: 0x20E0980 Offset: 0x20DEF80 VA: 0x1820E0980
	public void UpdateCurrentFrame(Frame frame) { }

	// RVA: 0x20E09F0 Offset: 0x20DEFF0 VA: 0x1820E09F0
	public void UpdateDynamicElementVelocity(Frame frame, int currentframe, TransformKeyFramesData transformKeyFrames, KinematicBody* kinematicBody, EntityRef entity) { }

	// RVA: 0x20E05B0 Offset: 0x20DEBB0 VA: 0x1820E05B0
	public static DynamicStageElement* GetComponent(Frame frame, CachedEntityData entityData) { }
}
