// Namespace: 
private class BasicCharacterCustomAnimator.BasicCharacterAnimData // TypeDefIndex: 3327
{
	// Fields
	public SimpleCustomAnimator CustomAnimator; // 0x10
	public Dictionary<string, AnimationClipDataAsset> ClipsData; // 0x18
	public List<BasicCharacterCustomAnimator.BasicCharacterAnimData.QueueAnimationElement> AnimationQueue; // 0x20
	public HashString TargetRig; // 0x28
	public float CurrentTime; // 0x38
	public float EndTime; // 0x3C
	public bool IsPlaying; // 0x40
	public AnimationClipDataAsset CurrentClipData; // 0x48

	// Methods

	// RVA: 0x5AC8D0 Offset: 0x5AAED0 VA: 0x1805AC8D0
	public void Init(string animatorID, Animator outputAnimator, HashString targetRig, BasicCharacterData.BasicCharacterClipsData[] animationClips) { }

	// RVA: 0x5ACB10 Offset: 0x5AB110 VA: 0x1805ACB10
	public void PlayAnim(string clipName, bool loop, float startTime, int blendFrames = 0) { }

	// RVA: 0x5AC700 Offset: 0x5AAD00 VA: 0x1805AC700
	public void AddAnimToQueue(string clipName, bool loop, int startTime, int blendFrames = 0, bool resumeQueue = False) { }

	// RVA: 0x5ACD70 Offset: 0x5AB370 VA: 0x1805ACD70
	public void ResumeQueue() { }

	// RVA: 0x5ACD80 Offset: 0x5AB380 VA: 0x1805ACD80
	public bool TryGetNextAnimBlendTime(out float blendTime) { }

	// RVA: 0x5ACCB0 Offset: 0x5AB2B0 VA: 0x1805ACCB0
	public void PlayNextAnimationInQueue() { }

	// RVA: 0x5ACE10 Offset: 0x5AB410 VA: 0x1805ACE10
	public void UpdateAnimation(float deltaTime) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
