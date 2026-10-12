// Namespace: 
[Serializable]
public class SimpleCustomAnimator // TypeDefIndex: 3357
{
	// Fields
	public string AnimatorID; // 0x10
	public Animator OutputAnimator; // 0x18
	public bool FullSync; // 0x20
	private PlayableGraph graph; // 0x28
	private SimpleCustomAnimator.CustomAnimatorPlayableInfo previousPlayableInfo; // 0x38
	private SimpleCustomAnimator.CustomAnimatorPlayableInfo currentPlayableInfo; // 0x40
	private AnimationMixerPlayable mixerPlayable; // 0x48
	private List<int> activeInputs; // 0x58
	private bool _initialized; // 0x60
	private float transitionTime; // 0x64

	// Methods

	// RVA: 0x5BCA90 Offset: 0x5BB090 VA: 0x1805BCA90
	public void Init() { }

	// RVA: 0x5BD1A0 Offset: 0x5BB7A0 VA: 0x1805BD1A0
	public void UpdateClip(AnimationClip clip, bool loop = False) { }

	// RVA: 0x5BCFC0 Offset: 0x5BB5C0 VA: 0x1805BCFC0
	public void UpdateClip(AnimationClip clip, float speed, int startFrame, int endFrame, int blendFrames, bool holdLastFramePose, bool loop = False) { }

	// RVA: 0x5BC970 Offset: 0x5BAF70 VA: 0x1805BC970
	public void ClearClip(bool clearPose = False) { }

	// RVA: 0x5BCD60 Offset: 0x5BB360 VA: 0x1805BCD60
	private float SetupPlayable(SimpleCustomAnimator.CustomAnimatorPlayableInfo playableInfo, float weight, float currentTime, bool isPrevious) { }

	// RVA: 0x5BC960 Offset: 0x5BAF60 VA: 0x1805BC960
	public float Animate(double currentTime, double deltaTime) { }

	// RVA: 0x5BC620 Offset: 0x5BAC20 VA: 0x1805BC620
	public float Animate(float currentTime, float deltaTime) { }

	// RVA: 0x5BCA00 Offset: 0x5BB000 VA: 0x1805BCA00
	public void Clear() { }

	// RVA: 0x5BD260 Offset: 0x5BB860 VA: 0x1805BD260
	public void .ctor() { }
}
