// Namespace: Quantum
public struct StageTimeline : IComponent // TypeDefIndex: 10045
{
	// Fields
	public FP FrameCheckInterval; // 0x0
	public FP StageFrameTime; // 0x8

	// Methods

	// RVA: 0x2130B90 Offset: 0x212F190 VA: 0x182130B90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20A9200 Offset: 0x20A7800 VA: 0x1820A9200
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2130D20 Offset: 0x212F320 VA: 0x182130D20
	public void Update(Frame frame, EntityRef entity) { }

	// RVA: 0x2130BD0 Offset: 0x212F1D0 VA: 0x182130BD0
	public static bool TryFind(Frame frame, out StageTimeline* stageTimeline) { }
}
