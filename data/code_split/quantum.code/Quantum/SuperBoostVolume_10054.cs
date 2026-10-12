// Namespace: Quantum
public struct SuperBoostVolume : IComponent // TypeDefIndex: 10054
{
	// Fields
	public SuperBoostDirection Direction; // 0x0
	public EntityRef Entity; // 0x8

	// Methods

	// RVA: 0x2134D30 Offset: 0x2133330 VA: 0x182134D30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2134ED0 Offset: 0x21334D0 VA: 0x182134ED0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2134D50 Offset: 0x2133350 VA: 0x182134D50
	public void OnBodyEnter(Frame frame, EntityRef other) { }

	// RVA: 0x2134E20 Offset: 0x2133420 VA: 0x182134E20
	public void OnBodyExit(Frame frame, EntityRef other) { }
}
