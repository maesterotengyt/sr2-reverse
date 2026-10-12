// Namespace: Quantum
[Serializable]
public class ChecksumFile // TypeDefIndex: 10281
{
	// Fields
	public const int GrowSize = 3600;
	public ChecksumFile.ChecksumEntry[] Checksums; // 0x10
	private int writeIndex; // 0x18

	// Methods

	// RVA: 0x2168F10 Offset: 0x2167510 VA: 0x182168F10
	internal void RecordChecksum(QuantumGame game, int frame, ulong checksum) { }

	// RVA: 0x2169000 Offset: 0x2167600 VA: 0x182169000
	internal void VerifyChecksum(QuantumGame game, int frame, ulong checksum) { }

	// RVA: 0x2168EA0 Offset: 0x21674A0 VA: 0x182168EA0
	internal void Clear() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
