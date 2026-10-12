// Namespace: 
[Serializable]
public class PlayBasicCharacterAnimationBehaviour : PlayableBehaviour // TypeDefIndex: 3349
{
	// Fields
	[SerializeField]
	protected HashString animationName; // 0x10
	[SerializeField]
	protected bool loop; // 0x20
	[SerializeField]
	protected bool stopAnimationOnBehaviourPause; // 0x21
	protected BasicCharacterCustomAnimator customAnimator; // 0x28
	protected HashString currentPlaying; // 0x30
	protected double startTime; // 0x40
	protected double lastTime; // 0x48
	protected bool firstFrame; // 0x50
	public GameObject boundGameObject; // 0x58

	// Methods

	// RVA: 0x5BBA10 Offset: 0x5BA010 VA: 0x1805BBA10 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x5BB7C0 Offset: 0x5B9DC0 VA: 0x1805BB7C0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x5BB8A0 Offset: 0x5B9EA0 VA: 0x1805BB8A0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x5BBCA0 Offset: 0x5BA2A0 VA: 0x1805BBCA0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x5BBC20 Offset: 0x5BA220 VA: 0x1805BBC20 Slot: 14
	public override void OnGraphStop(Playable playable) { }

	// RVA: 0x5BBD70 Offset: 0x5BA370 VA: 0x1805BBD70
	public void .ctor() { }
}
