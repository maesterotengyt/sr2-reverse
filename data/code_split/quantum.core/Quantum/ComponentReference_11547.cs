// Namespace: Quantum
public struct ComponentReference : IEquatable<ComponentReference> // TypeDefIndex: 11547
{
	// Fields
	public EntityRef Entity; // 0x0
	public int Component; // 0x8
	private int _padding; // 0xC

	// Methods

	// RVA: 0x21C7590 Offset: 0x21C5B90 VA: 0x1821C7590
	public void .ctor(EntityRef entity, int component) { }

	// RVA: 0x21C7440 Offset: 0x21C5A40 VA: 0x1821C7440 Slot: 4
	public bool Equals(ComponentReference other) { }

	// RVA: 0x21C7460 Offset: 0x21C5A60 VA: 0x1821C7460 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21C74F0 Offset: 0x21C5AF0 VA: 0x1821C74F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21C7510 Offset: 0x21C5B10 VA: 0x1821C7510
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
