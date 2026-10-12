// Namespace: Quantum
internal struct ComponentBlockIterator // TypeDefIndex: 11530
{
	// Fields
	private int _version; // 0x0
	private int _remaining; // 0x4
	private int _currentBlock; // 0x8
	private int _currentBlockOffset; // 0xC
	private ComponentDataBuffer* _buffer; // 0x10

	// Methods

	// RVA: 0x21C6170 Offset: 0x21C4770 VA: 0x1821C6170
	internal void .ctor(ComponentDataBuffer* buffer) { }

	// RVA: 0x21C60D0 Offset: 0x21C46D0 VA: 0x1821C60D0
	internal void ValidateIterator() { }

	// RVA: 0x21C5F70 Offset: 0x21C4570 VA: 0x1821C5F70
	public bool NextBlock(out byte* components, out EntityRef* entities, out int count) { }
}
