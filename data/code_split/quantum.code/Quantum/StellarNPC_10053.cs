// Namespace: Quantum
public struct StellarNPC : IComponent // TypeDefIndex: 10053
{
	// Fields
	public QBoolean Active; // 0x4
	public int Difficulty; // 0x0
	public EntityRef Entity; // 0x8

	// Methods

	// RVA: 0x2134C50 Offset: 0x2133250 VA: 0x182134C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2134CA0 Offset: 0x21332A0 VA: 0x182134CA0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2134C90 Offset: 0x2133290 VA: 0x182134C90
	public void Initialize(Frame frame, EntityRef entity, int difficulty) { }

	// RVA: 0x2134C30 Offset: 0x2133230 VA: 0x182134C30
	internal void Enable() { }

	// RVA: 0x2134C10 Offset: 0x2133210 VA: 0x182134C10
	internal void Disable() { }
}
