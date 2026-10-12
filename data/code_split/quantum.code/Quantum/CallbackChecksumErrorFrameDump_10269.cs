// Namespace: Quantum
public sealed class CallbackChecksumErrorFrameDump : QuantumGame.CallbackBase // TypeDefIndex: 10269
{
	// Fields
	public const int ID = 9;
	public int ActorId; // 0x20
	public int FrameNumber; // 0x24
	public byte[] FrameData; // 0x28
	public byte[] RuntimeConfigBytes; // 0x30
	public byte[] ExtraBytes; // 0x38
	public DeterministicSessionConfig SessionConfig; // 0x40
	private Frame _frameToOverride; // 0x48
	private byte[] _overridenFrameData; // 0x50
	private SimulationConfig _overridenSimulationConfig; // 0x58
	private DeterministicSessionConfig _overridenSessionConfig; // 0x60
	private RuntimeConfig _overridenRuntimeConfig; // 0x68
	private QTuple<bool, string> _frameDump; // 0x70
	private QTuple<bool, Frame> _frame; // 0x80
	private QTuple<bool, RuntimeConfig> _runtimeConfig; // 0x90
	private QTuple<bool, ChecksumErrorFrameDumpContext> _context; // 0xA0

	// Properties
	public Frame Frame { get; }
	public string FrameDump { get; }
	public RuntimeConfig RuntimeConfig { get; }
	public SimulationConfig SimulationConfig { get; }
	public ChecksumErrorFrameDumpContext Context { get; }

	// Methods

	// RVA: 0x2166450 Offset: 0x2164A50 VA: 0x182166450
	internal void .ctor(QuantumGame game) { }

	// RVA: 0x2166330 Offset: 0x2164930 VA: 0x182166330
	internal void Clear() { }

	// RVA: 0x2166A80 Offset: 0x2165080 VA: 0x182166A80
	public Frame get_Frame() { }

	// RVA: 0x2166630 Offset: 0x2164C30 VA: 0x182166630
	public string get_FrameDump() { }

	// RVA: 0x2166D10 Offset: 0x2165310 VA: 0x182166D10
	public RuntimeConfig get_RuntimeConfig() { }

	// RVA: 0x2166DE0 Offset: 0x21653E0 VA: 0x182166DE0
	public SimulationConfig get_SimulationConfig() { }

	// RVA: 0x58D130 Offset: 0x58B730 VA: 0x18058D130
	internal void Init(Frame frame) { }

	// RVA: 0x2166460 Offset: 0x2164A60 VA: 0x182166460
	public ChecksumErrorFrameDumpContext get_Context() { }
}
