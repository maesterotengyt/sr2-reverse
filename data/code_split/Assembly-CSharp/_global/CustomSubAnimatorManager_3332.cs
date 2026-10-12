// Namespace: 
[Serializable]
public class CustomSubAnimatorManager // TypeDefIndex: 3332
{
	// Fields
	public HashString SubAnimatorID; // 0x10
	public HashString TargetRigID; // 0x20
	public Animator OutputAnimator; // 0x30
	public SubAnimationsPoolData AnimationsPoolData; // 0x38
	public bool LastRigVisibility; // 0x40
	private PlayableGraph graph; // 0x48
	private AnimationMixerPlayable mixerPlayable; // 0x58
	private List<int> activeInputs; // 0x68
	private Dictionary<int, KeyValuePair<int, AnimationClipPlayable>> clips; // 0x70

	// Methods

	// RVA: 0x5B1DD0 Offset: 0x5B03D0 VA: 0x1805B1DD0
	public void RestoreInfluenceOnAnimator() { }

	// RVA: 0x5B1A30 Offset: 0x5B0030 VA: 0x1805B1A30
	public void ClearInfluenceOnAnimator() { }

	// RVA: 0x5B09F0 Offset: 0x5AEFF0 VA: 0x1805B09F0
	public void Animate(Frame frame, CustomAnimator* customAnimator, GameEntityManager gameEntityManager, int facingDirection = 1) { }

	// RVA: 0x5B13A0 Offset: 0x5AF9A0 VA: 0x1805B13A0
	public void Animate(Frame frame, CustomAnimator* customAnimator, GameEntityManager gameEntityManager, CustomSubAnimatorPlayableClipInfo playableClipInfo, int facingDirection = 1) { }

	// RVA: 0x5B1BD0 Offset: 0x5B01D0 VA: 0x1805B1BD0
	private void LoadClipsInGraph() { }

	// RVA: 0x5B1F50 Offset: 0x5B0550 VA: 0x1805B1F50
	public void .ctor() { }
}
