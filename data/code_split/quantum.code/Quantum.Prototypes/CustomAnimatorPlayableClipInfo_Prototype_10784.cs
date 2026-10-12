// Namespace: Quantum.Prototypes
[Prototype(typeof(CustomAnimatorPlayableClipInfo))]
[Serializable]
public sealed class CustomAnimatorPlayableClipInfo_Prototype : StructPrototype // TypeDefIndex: 10784
{
	// Fields
	public int ClipIndex; // 0x10
	public FP Time; // 0x18
	public FP RuntimeWeight; // 0x20
	public FP Speed; // 0x28
	public QBoolean TriggeredEndEvent; // 0x30
	public int GroupHash; // 0x34
	public StateGroupExecutionMode_Prototype GroupExecutionMode; // 0x38
	public FP StartTime; // 0x40
	public FP EndTime; // 0x48
	public QBoolean IsLooping; // 0x50
	public FP Weight; // 0x58

	// Methods

	// RVA: 0x21012F0 Offset: 0x20FF8F0 VA: 0x1821012F0
	public void Materialize(Frame frame, ref CustomAnimatorPlayableClipInfo result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
