// Namespace: Quantum
public struct CustomAnimatorPlayableClipInfo : IEquatable<CustomAnimatorPlayableClipInfo> // TypeDefIndex: 9916
{
	// Fields
	public int ClipIndex; // 0x0
	public FP EndTime; // 0x18
	public StateGroupExecutionMode GroupExecutionMode; // 0x10
	public int GroupHash; // 0x4
	public QBoolean IsLooping; // 0x8
	public FP RuntimeWeight; // 0x20
	public FP Speed; // 0x28
	public FP StartTime; // 0x30
	public FP Time; // 0x38
	public QBoolean TriggeredEndEvent; // 0xC
	public FP Weight; // 0x40
	[CompilerGenerated]
	private static readonly CustomAnimatorPlayableClipInfo <None>k__BackingField; // 0x0

	// Properties
	public static CustomAnimatorPlayableClipInfo None { get; }
	public FP ClipDuration { get; }

	// Methods

	// RVA: 0x20CD500 Offset: 0x20CBB00 VA: 0x1820CD500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CD5B0 Offset: 0x20CBBB0 VA: 0x1820CD5B0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	[CompilerGenerated]
	// RVA: 0x20CD830 Offset: 0x20CBE30 VA: 0x1820CD830
	public static CustomAnimatorPlayableClipInfo get_None() { }

	// RVA: 0x20CD810 Offset: 0x20CBE10 VA: 0x1820CD810
	public FP get_ClipDuration() { }

	// RVA: 0x20CD6E0 Offset: 0x20CBCE0 VA: 0x1820CD6E0
	public void Update(FP deltaTime, FP totalWeight, FP transitionWeight, out bool notifyFinishEvent) { }

	// RVA: 0x20CD4B0 Offset: 0x20CBAB0 VA: 0x1820CD4B0
	public bool Finished(bool ignoreLoop = True) { }

	// RVA: 0x20CD350 Offset: 0x20CB950 VA: 0x1820CD350 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20CD1C0 Offset: 0x20CB7C0 VA: 0x1820CD1C0 Slot: 4
	public bool Equals(CustomAnimatorPlayableClipInfo other) { }

	// RVA: 0x20CD8A0 Offset: 0x20CBEA0 VA: 0x1820CD8A0
	public static bool op_Equality(CustomAnimatorPlayableClipInfo a, CustomAnimatorPlayableClipInfo b) { }

	// RVA: 0x20CD8F0 Offset: 0x20CBEF0 VA: 0x1820CD8F0
	public static bool op_Inequality(CustomAnimatorPlayableClipInfo a, CustomAnimatorPlayableClipInfo b) { }
}
