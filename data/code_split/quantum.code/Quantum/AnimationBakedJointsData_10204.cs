// Namespace: Quantum
[Serializable]
public class AnimationBakedJointsData : AssetObject // TypeDefIndex: 10204
{
	// Fields
	public AnimationJointsData[] AnimationsJointData; // 0x20

	// Methods

	// RVA: 0x214E6E0 Offset: 0x214CCE0 VA: 0x18214E6E0
	public bool TryGetAnimationKeyFrameData(int clipIndex, int frame, out JointKeyFrame keyFrame) { }

	// RVA: 0x214E740 Offset: 0x214CD40 VA: 0x18214E740
	public bool TryGetAnimationKinematicMotion(int clipIndex, int frame, out FPVector2 kinematicMotionDiff) { }

	// RVA: 0x214E7C0 Offset: 0x214CDC0 VA: 0x18214E7C0
	public void .ctor() { }
}
