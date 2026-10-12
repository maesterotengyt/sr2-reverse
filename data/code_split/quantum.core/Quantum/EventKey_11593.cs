// Namespace: Quantum
[IsReadOnly]
public struct EventKey : IEquatable<EventKey> // TypeDefIndex: 11593
{
	// Fields
	public readonly int Tick; // 0x0
	public readonly int Id; // 0x4
	public readonly int Hash; // 0x8

	// Methods

	// RVA: 0x15CDFE0 Offset: 0x15CC5E0 VA: 0x1815CDFE0
	public void .ctor(int tick, int id, int hash) { }

	// RVA: 0x21CD590 Offset: 0x21CBB90 VA: 0x1821CD590 Slot: 3
	public override string ToString() { }

	// RVA: 0x21CD560 Offset: 0x21CBB60 VA: 0x1821CD560 Slot: 4
	public bool Equals(EventKey other) { }

	// RVA: 0x21CD580 Offset: 0x21CBB80 VA: 0x1821CD580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21CD4D0 Offset: 0x21CBAD0 VA: 0x1821CD4D0 Slot: 0
	public override bool Equals(object obj) { }
}
