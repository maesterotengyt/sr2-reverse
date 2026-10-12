// Namespace: Photon.Deterministic
public struct DeterministicFrameInputTemp // TypeDefIndex: 17446
{
	// Fields
	public int Frame; // 0x0
	public int Player; // 0x4
	public byte[] Rpc; // 0x8
	public byte[] Data; // 0x10
	public int DataLength; // 0x18
	public bool IsVerified; // 0x1C
	public DeterministicInputFlags Flags; // 0x1D

	// Methods

	// RVA: 0x20B0490 Offset: 0x20AEA90 VA: 0x1820B0490
	public byte[] CloneData() { }

	// RVA: 0x20B0570 Offset: 0x20AEB70 VA: 0x1820B0570
	public static DeterministicFrameInputTemp Verified(int frame, int player, byte[] rpc, byte[] data, int dataLength, DeterministicInputFlags flags) { }

	// RVA: 0x20B0510 Offset: 0x20AEB10 VA: 0x1820B0510
	public static DeterministicFrameInputTemp Predicted(int frame, int player, byte[] data, int dataLength, DeterministicInputFlags flags) { }

	// RVA: 0x20B05D0 Offset: 0x20AEBD0 VA: 0x1820B05D0
	private void .ctor(int frame, int player, byte[] rpc, byte[] data, int dataLength, DeterministicInputFlags flags, bool verified) { }
}
