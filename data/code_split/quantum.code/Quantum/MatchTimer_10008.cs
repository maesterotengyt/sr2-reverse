// Namespace: Quantum
public struct MatchTimer : IComponent // TypeDefIndex: 10008
{
	// Fields
	public QBoolean Active; // 0x0
	public FP CurrentTime; // 0x8

	// Methods

	// RVA: 0x2120570 Offset: 0x211EB70 VA: 0x182120570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E2AB0 Offset: 0x20E10B0 VA: 0x1820E2AB0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x21205A0 Offset: 0x211EBA0 VA: 0x1821205A0
	public static bool TryFind(Frame frame, out MatchTimer* matchTimer) { }

	// RVA: 0x21206F0 Offset: 0x211ECF0 VA: 0x1821206F0
	public void Update(Frame frame) { }
}
