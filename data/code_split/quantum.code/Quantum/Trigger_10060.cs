// Namespace: Quantum
public struct Trigger : IComponent // TypeDefIndex: 10060
{
	// Fields
	public QBoolean Active; // 0x0
	[HideInInspector]
	[PtrQList(typeof(EntityRef))]
	private Ptr BodiesInTriggerPtr; // 0x4
	[HideInInspector]
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public EntityRef TriggerEnterEntity; // 0x10
	[HideInInspector]
	public EntityRef TriggerExitEntity; // 0x18

	// Properties
	public QListPtr<EntityRef> BodiesInTrigger { get; set; }

	// Methods

	// RVA: 0x2137AA0 Offset: 0x21360A0 VA: 0x182137AA0
	public QListPtr<EntityRef> get_BodiesInTrigger() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_BodiesInTrigger(QListPtr<EntityRef> value) { }

	// RVA: 0x21372D0 Offset: 0x21358D0 VA: 0x1821372D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CCF30 Offset: 0x20CB530 VA: 0x1820CCF30
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2137740 Offset: 0x2135D40 VA: 0x182137740
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x21377C0 Offset: 0x2135DC0 VA: 0x1821377C0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2137310 Offset: 0x2135910 VA: 0x182137310
	internal FP GetValue(Frame frame, TriggerVariable variable) { }

	// RVA: 0x21378A0 Offset: 0x2135EA0 VA: 0x1821378A0
	internal void SetValue(Frame frame, TriggerVariable variable, FP value) { }

	// RVA: 0x2136610 Offset: 0x2134C10 VA: 0x182136610
	internal void Enable(Frame frame) { }

	// RVA: 0x2136560 Offset: 0x2134B60 VA: 0x182136560
	internal void Disable(Frame frame) { }

	// RVA: 0x2137930 Offset: 0x2135F30 VA: 0x182137930
	public void Update(Frame frame, EntityRef triggerEntity, List<PhysicsBodyEntity> activeBodies) { }

	// RVA: 0x2136DA0 Offset: 0x21353A0 VA: 0x182136DA0
	private void EvaluateSphereCollision(Frame frame, EntityRef triggerEntity, TriggerSphereShape* sphereShape, FPVector2 position, FP rotation, List<PhysicsBodyEntity> activeBodies) { }

	// RVA: 0x2136630 Offset: 0x2134C30 VA: 0x182136630
	private void EvaluatePolygonCollision(Frame frame, EntityRef triggerEntity, TriggerPolygonShape* polygonShape, FPVector2 position, FP rotation, List<PhysicsBodyEntity> activeBodies) { }

	// RVA: 0x21360E0 Offset: 0x21346E0 VA: 0x1821360E0
	private void BodyEntered(Frame frame, EntityRef triggerEntity, EntityRef otherEntity) { }

	// RVA: 0x2137340 Offset: 0x2135940 VA: 0x182137340
	private void OnBodyEnter(Frame frame, EntityRef triggerEntity, EntityRef otherEntity) { }

	// RVA: 0x21362D0 Offset: 0x21348D0 VA: 0x1821362D0
	private void BodyExited(Frame frame, EntityRef triggerEntity, EntityRef otherEntity) { }

	// RVA: 0x21376A0 Offset: 0x2135CA0 VA: 0x1821376A0
	private void OnBodyExit(Frame frame, EntityRef triggerEntity, EntityRef otherEntity) { }

	// RVA: 0x21364C0 Offset: 0x2134AC0 VA: 0x1821364C0
	internal void ClearBodies(Frame frame) { }
}
