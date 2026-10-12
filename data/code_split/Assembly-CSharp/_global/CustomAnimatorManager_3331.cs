// Namespace: 
public class CustomAnimatorManager : MonoBehaviour // TypeDefIndex: 3331
{
	// Fields
	public HashString TargetRigID; // 0x20
	public Animator OutputAnimator; // 0x30
	public AnimationsPoolDataAsset AnimationsPoolData; // 0x38
	public CustomSubAnimatorManager[] SubAnimatorsFullSync; // 0x40
	public CustomSubAnimatorManager[] SubAnimatorsNoFullSync; // 0x48
	private PlayableGraph graph; // 0x50
	private AnimationMixerPlayable mixerPlayable; // 0x60
	private List<int> activeInputs; // 0x70
	private Dictionary<int, KeyValuePair<int, AnimationClipPlayable>> clips; // 0x78

	// Methods

	// RVA: 0x5AFF90 Offset: 0x5AE590 VA: 0x1805AFF90
	private void Awake() { }

	// RVA: 0x5B05C0 Offset: 0x5AEBC0 VA: 0x1805B05C0
	private void OnEnable() { }

	// RVA: 0x5B0500 Offset: 0x5AEB00 VA: 0x1805B0500
	private void OnDisable() { }

	// RVA: 0x5B07C0 Offset: 0x5AEDC0 VA: 0x1805B07C0
	public void RestoreInfluenceOnAnimator() { }

	// RVA: 0x5B00F0 Offset: 0x5AE6F0 VA: 0x1805B00F0
	public void ClearInfluenceOnAnimator() { }

	// RVA: 0x5AF380 Offset: 0x5AD980 VA: 0x1805AF380
	public void Animate(Frame frame, CustomAnimator* customAnimator, GameEntityManager gameEntityManager, int facingDirection = 1) { }

	// RVA: 0x5B0290 Offset: 0x5AE890 VA: 0x1805B0290
	private SubAnimationsPoolData GetSubAnimationsPoolData(int subAnimatorID) { }

	// RVA: 0x5B0300 Offset: 0x5AE900 VA: 0x1805B0300
	private void LoadClipsInGraph() { }

	// RVA: 0x5B0930 Offset: 0x5AEF30 VA: 0x1805B0930
	public void .ctor() { }
}
