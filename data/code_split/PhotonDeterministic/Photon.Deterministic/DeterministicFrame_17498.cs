// Namespace: Photon.Deterministic
public abstract class DeterministicFrame // TypeDefIndex: 17498
{
	// Fields
	public const int DumpFlag_NoHeap = 1;
	internal DeterministicFrameInput Input; // 0x10
	internal bool Verified; // 0x18
	public int Number; // 0x1C

	// Properties
	public bool IsVerified { get; }
	public bool IsPredicted { get; }

	// Methods

	// RVA: 0x676D40 Offset: 0x675340 VA: 0x180676D40
	public bool get_IsVerified() { }

	// RVA: 0x20B1910 Offset: 0x20AFF10 VA: 0x1820B1910
	public bool get_IsPredicted() { }

	// RVA: 0x20B1870 Offset: 0x20AFE70 VA: 0x1820B1870
	public void Init(int playerCount, int inputSize, Native.Allocator allocator) { }

	// RVA: 0x20B1740 Offset: 0x20AFD40 VA: 0x1820B1740
	internal DeterministicInputFlags GetPlayerInputFlagsInternal(int player) { }

	// RVA: 0x20B1820 Offset: 0x20AFE20 VA: 0x1820B1820
	public byte[] GetRawRpc(int player) { }

	// RVA: 0x20B17E0 Offset: 0x20AFDE0 VA: 0x1820B17E0
	public byte* GetRawInput(int player) { }

	// RVA: 0x20B1790 Offset: 0x20AFD90 VA: 0x1820B1790
	public DeterministicInputFlags GetPlayerInputFlags(int player) { }

	// RVA: 0x20B16F0 Offset: 0x20AFCF0 VA: 0x1820B16F0
	public DeterministicCommand GetPlayerCommand(int player) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string DumpFrame(int dumpFlags = 0);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ulong CalculateChecksum();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Free();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte[] Serialize(DeterministicFrameSerializeMode mode);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Deserialize(byte[] data);

	// RVA: 0x20B16B0 Offset: 0x20AFCB0 VA: 0x1820B16B0
	public void CopyFrom(DeterministicFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Copy(DeterministicFrame frame);

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
