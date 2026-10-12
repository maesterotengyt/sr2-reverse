// Namespace: 
[Serializable]
public struct TrajectorySegments // TypeDefIndex: 3532
{
	// Fields
	public Vector3 Position1; // 0x0
	public Vector3 Position2; // 0xC
	public int frames; // 0x18
	public AnimationCurve SegmentCurve; // 0x20
	public bool UseSegmentTangentRotation; // 0x28
	public bool ResetPreviousSegmentRotation; // 0x29
	public float Rotation; // 0x2C
	public bool UsingFold; // 0x30
	public string SegmentName; // 0x38

	// Methods

	// RVA: 0x5F89A0 Offset: 0x5F6FA0 VA: 0x1805F89A0
	public static TrajectorySegments Default() { }
}
