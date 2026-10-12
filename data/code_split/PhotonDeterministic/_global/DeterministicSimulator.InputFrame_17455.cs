// Namespace: 
private class DeterministicSimulator.InputFrame // TypeDefIndex: 17455
{
	// Fields
	public DeterministicSimulator.InputFrame Next; // 0x10
	public int Number; // 0x18
	public ulong Verified; // 0x20
	public ulong Predicted; // 0x28
	public DeterministicFrameInput Input; // 0x30

	// Methods

	// RVA: 0x20BE610 Offset: 0x20BCC10 VA: 0x1820BE610
	public void .ctor(int playerCount, int inputSize, Native.Allocator allocator) { }

	// RVA: 0x20BE580 Offset: 0x20BCB80 VA: 0x1820BE580
	public void DeserializeCommands(DeterministicCommandSerializer serializer) { }

	// RVA: 0x20BE5A0 Offset: 0x20BCBA0 VA: 0x1820BE5A0 Slot: 3
	public override string ToString() { }
}
