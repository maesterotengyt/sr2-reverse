// Namespace: Quantum
public struct EdgeGrabRequest // TypeDefIndex: 10461
{
	// Fields
	public EntityRef GrabberEntity; // 0x0
	public EdgeGrab* Grabber; // 0x8
	public EntityRef EdgeEntity; // 0x10
	public StageEdge* Edge; // 0x18
	public FP Distance; // 0x20

	// Methods

	// RVA: 0x21B5370 Offset: 0x21B3970 VA: 0x1821B5370
	public void .ctor(EntityRef grabberEntity, EdgeGrab* grabber, EntityRef edgeEntity, StageEdge* edge, FP distance) { }
}
