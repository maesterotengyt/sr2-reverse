// Namespace: Quantum
[Serializable]
public class ReplayFile // TypeDefIndex: 10285
{
	// Fields
	public RuntimeConfig RuntimeConfig; // 0x10
	public DeterministicSessionConfig DeterministicConfig; // 0x18
	public DeterministicTickInputSet[] InputHistory; // 0x20
	public int Length; // 0x28
	public byte[] Frame; // 0x30
	public int InitialFrame; // 0x38
	public byte[] InitialFrameData; // 0x40

	// Methods

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
