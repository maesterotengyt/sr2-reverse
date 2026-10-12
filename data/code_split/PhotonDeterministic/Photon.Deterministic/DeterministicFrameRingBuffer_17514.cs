// Namespace: Photon.Deterministic
[DefaultMember("Item")]
public class DeterministicFrameRingBuffer : IDisposable // TypeDefIndex: 17514
{
	// Fields
	private readonly DeterministicFrame[] _data; // 0x10
	private int _tail; // 0x18
	[CompilerGenerated]
	private readonly int <Capacity>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x20

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public DeterministicFrame[] Data { get; }

	// Methods

	// RVA: 0x20B15F0 Offset: 0x20AFBF0 VA: 0x1820B15F0
	public void .ctor(int capacity) { }

	[CompilerGenerated]
	// RVA: 0x6678B0 Offset: 0x665EB0 VA: 0x1806678B0
	public int get_Capacity() { }

	[CompilerGenerated]
	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x667A20 Offset: 0x666020 VA: 0x180667A20
	private void set_Count(int value) { }

	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public DeterministicFrame[] get_Data() { }

	// RVA: 0x20B0FE0 Offset: 0x20AF5E0 VA: 0x1820B0FE0
	public void Clear() { }

	// RVA: 0x20B0FE0 Offset: 0x20AF5E0 VA: 0x1820B0FE0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x20B1090 Offset: 0x20AF690 VA: 0x1820B1090
	public DeterministicFrame Find(int frameNumber, DeterministicFrameSnapshotBufferFindMode findMode = 0) { }

	// RVA: 0x20B1340 Offset: 0x20AF940 VA: 0x1820B1340
	public void PushBack(DeterministicFrame frame, IDeterministicGame game, IDisposable context) { }

	// RVA: 0x20B1490 Offset: 0x20AFA90 VA: 0x1820B1490
	public void PushBack(DeterministicFrame frame, Func<DeterministicFrame> createFrame) { }

	// RVA: 0x20B1250 Offset: 0x20AF850 VA: 0x1820B1250
	public DeterministicFrame PeekBack(int offset = 0) { }

	// RVA: 0x20B1240 Offset: 0x20AF840 VA: 0x1820B1240
	private static int Increment(int i, int capacity, int count = 1) { }

	// RVA: 0x20B1580 Offset: 0x20AFB80 VA: 0x1820B1580
	public static bool TryGetCommonSamplingPattern(int windowA, int samplingA, int windowB, int samplingB, out int commonWindow, out int commonSampling) { }

	// RVA: 0x20B1220 Offset: 0x20AF820 VA: 0x1820B1220
	public static int GetSize(int window, int samplingRate) { }
}
