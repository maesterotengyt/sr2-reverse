// Namespace: Photon.Deterministic
internal class DeterministicFrameInput // TypeDefIndex: 17445
{
	// Fields
	private int _playerCount; // 0x10
	private int _inputSize; // 0x14
	public byte[][] Rpcs; // 0x18
	public DeterministicCommand[] Cmds; // 0x20
	public DeterministicInputFlags[] Flags; // 0x28
	public byte* Input; // 0x30

	// Properties
	public int PlayerCount { get; }

	// Methods

	// RVA: 0x502900 Offset: 0x500F00 VA: 0x180502900
	public int get_PlayerCount() { }

	// RVA: 0x20B0770 Offset: 0x20AED70 VA: 0x1820B0770
	public void Clear() { }

	// RVA: 0x20B0ED0 Offset: 0x20AF4D0 VA: 0x1820B0ED0
	public byte* GetPlayerInput(int player) { }

	// RVA: 0x20B0EE0 Offset: 0x20AF4E0 VA: 0x1820B0EE0
	public void .ctor(int playerCount, int inputSize, Native.Allocator allocator) { }

	// RVA: 0x20B0BD0 Offset: 0x20AF1D0 VA: 0x1820B0BD0
	public void DeserializeCommands(DeterministicCommandSerializer serializer) { }

	// RVA: 0x20B0620 Offset: 0x20AEC20 VA: 0x1820B0620
	public void Assign(DeterministicFrameInputTemp input, IDeterministicGame sessionGame) { }

	// RVA: 0x20B09F0 Offset: 0x20AEFF0 VA: 0x1820B09F0
	public void CopyFrom(DeterministicFrameInput from) { }

	// RVA: 0x20B0920 Offset: 0x20AEF20 VA: 0x1820B0920
	public void CopyForPrediction(DeterministicFrameInput from, int player) { }

	// RVA: 0x20B0E50 Offset: 0x20AF450 VA: 0x1820B0E50
	public void Free(Native.Allocator allocator) { }
}
