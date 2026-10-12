// Namespace: Quantum
public struct ComponentFilterStructMeta // TypeDefIndex: 11538
{
	// Fields
	public const int MAX_COMPONENT_TYPES = 8;
	public ComponentSet Set; // 0x0
	public int EntityOffset; // 0x20
	public int ComponentCount; // 0x24
	[FixedBuffer(typeof(int), 8)]
	public ComponentFilterStructMeta.<ComponentOffsets>e__FixedBuffer ComponentOffsets; // 0x28
	[FixedBuffer(typeof(int), 8)]
	public ComponentFilterStructMeta.<ComponentTypes>e__FixedBuffer ComponentTypes; // 0x48
}
