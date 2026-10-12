// Namespace: Quantum
[Serializable]
public struct AnimationJointsData // TypeDefIndex: 10470
{
	// Fields
	public int ClipIndex; // 0x0
	public JointKeyFrame[] KeyFrames; // 0x8
	public FPVector2[] KinematicMotion; // 0x10

	// Methods

	// RVA: 0x21AFF20 Offset: 0x21AE520 VA: 0x1821AFF20
	public bool TryGetKeyFrame(int frame, out JointKeyFrame keyFrame) { }

	// RVA: 0x21AFFB0 Offset: 0x21AE5B0 VA: 0x1821AFFB0
	public bool TryGetKinematicMotion(int frame, out FPVector2 kinematicMotionDiff) { }
}
