// Namespace: Quantum
[Serializable]
public struct FPAnimationCurve // TypeDefIndex: 11762
{
	// Fields
	public FP[] Samples; // 0x0
	public int PreWrapMode; // 0x8
	public int PostWrapMode; // 0xC
	public FP StartTime; // 0x10
	public FP EndTime; // 0x18
	public int Resolution; // 0x20
	public int OriginalPreWrapMode; // 0x24
	public int OriginalPostWrapMode; // 0x28
	public FPAnimationCurve.Keyframe[] Keys; // 0x30

	// Methods

	// RVA: 0x2224500 Offset: 0x2222B00 VA: 0x182224500
	public FP Evaluate(FP time) { }
}
