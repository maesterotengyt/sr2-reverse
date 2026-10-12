// Namespace: Photon.Deterministic
[Serializable]
public class DeterministicSessionConfig // TypeDefIndex: 17463
{
	// Fields
	private bool _BW_COMPAT_RunInBackgroundThread; // 0x10
	private ThreadPriority _BW_COMPAT_BackgroundThreadPriority; // 0x14
	private bool _BW_COMPAT_ExposeVerifiedStatusInsideSimulation; // 0x18
	private bool _BW_COMPAT_SkipRollbackWhenPossible; // 0x19
	private int _BW_COMPAT_InputPacking; // 0x1C
	public int PlayerCount; // 0x20
	public bool ChecksumCrossPlatformDeterminism; // 0x24
	public bool LockstepSimulation; // 0x25
	public bool AggressiveSendMode; // 0x26
	public int UpdateFPS; // 0x28
	public int ChecksumInterval; // 0x2C
	public int RollbackWindow; // 0x30
	public int InputHardTolerance; // 0x34
	public int InputRedundancy; // 0x38
	public int InputRepeatMaxDistance; // 0x3C
	public int SessionStartTimeout; // 0x40
	public int TimeCorrectionRate; // 0x44
	public int MinTimeCorrectionFrames; // 0x48
	public int MinOffsetCorrectionDiff; // 0x4C
	public int TimeScaleMin; // 0x50
	public int TimeScalePingMin; // 0x54
	public int TimeScalePingMax; // 0x58
	public int InputDelayMin; // 0x5C
	public int InputDelayMax; // 0x60
	public int InputDelayPingStart; // 0x64
	public bool InputFixedSizeEnabled; // 0x68
	public int InputFixedSize; // 0x6C

	// Methods

	// RVA: 0x20B5080 Offset: 0x20B3680 VA: 0x1820B5080
	public static byte[] ToByteArray(DeterministicSessionConfig instance) { }

	// RVA: 0x20B47F0 Offset: 0x20B2DF0 VA: 0x1820B47F0
	public static DeterministicSessionConfig FromByteArray(byte[] data) { }

	// RVA: 0x20B4910 Offset: 0x20B2F10 VA: 0x1820B4910
	public static void Serialize(Serializer serializer, BitStream stream, ref DeterministicSessionConfig config) { }

	// RVA: 0x20B5160 Offset: 0x20B3760 VA: 0x1820B5160
	public void .ctor() { }
}
