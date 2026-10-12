// Namespace: Quantum
public sealed class CallbackChecksumError : QuantumGame.CallbackBase // TypeDefIndex: 10268
{
	// Fields
	public const int ID = 8;
	public DeterministicTickChecksumError Error; // 0x20
	internal DeterministicFrame[] _rawFrames; // 0x28
	internal Frame[] _convertedFrame; // 0x30

	// Properties
	public Frame[] Frames { get; }

	// Methods

	// RVA: 0x2166E00 Offset: 0x2165400 VA: 0x182166E00
	internal void .ctor(QuantumGame game) { }

	// RVA: 0x2166E10 Offset: 0x2165410 VA: 0x182166E10
	public Frame[] get_Frames() { }
}
