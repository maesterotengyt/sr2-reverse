// Namespace: 
public class BasicCharacterCustomAnimator : MonoBehaviour // TypeDefIndex: 3328
{
	// Fields
	public BasicCharacterCustomAnimator.BasicCharacterAnimatorUpdateMode UpdateMode; // 0x20
	private BasicCharacterCustomAnimator.BasicCharacterAnimData mainAnimData; // 0x28
	private Dictionary<string, BasicCharacterCustomAnimator.BasicCharacterAnimData> subAnimatorsData; // 0x30
	private List<string> subAnimatorsKeys; // 0x38
	private GameEntityObjectsManager gameEntityObjectsManager; // 0x40
	private const float ClipTimeConst = 60;

	// Methods

	// RVA: 0x5AD5B0 Offset: 0x5ABBB0 VA: 0x1805AD5B0
	public void Init(CharacterVisualsData characterVisualsData, GameEntityObjectsManager entityObjectsManager, string characterID = "Not provided") { }

	// RVA: 0x5AE3E0 Offset: 0x5AC9E0 VA: 0x1805AE3E0
	private void Update() { }

	// RVA: 0x5AD280 Offset: 0x5AB880 VA: 0x1805AD280
	public void CustomUpdate(float deltaTime) { }

	// RVA: 0x5ADC20 Offset: 0x5AC220 VA: 0x1805ADC20
	public void Play(string clipName, bool loop = False) { }

	// RVA: 0x5ADBF0 Offset: 0x5AC1F0 VA: 0x1805ADBF0
	public void Play(string clipName, bool loop, float startTime, int blendFrames = 0) { }

	// RVA: 0x5AD210 Offset: 0x5AB810 VA: 0x1805AD210
	public void AddAnimToQueue(string clipName, bool loop = False, bool resumeQueue = False) { }

	// RVA: 0x5AD240 Offset: 0x5AB840 VA: 0x1805AD240
	public void AddAnimToQueue(string clipName, bool loop, int startTime, int blendFrames = 0, bool resumeQueue = False) { }

	// RVA: 0x5AE250 Offset: 0x5AC850 VA: 0x1805AE250
	public bool TryPlaySubAnimation(string subAnimatorKey, string clipName, bool loop = False) { }

	// RVA: 0x5AE280 Offset: 0x5AC880 VA: 0x1805AE280
	public bool TryPlaySubAnimation(string subAnimatorKey, string clipName, bool loop, float startTime, int blendFrames = 0) { }

	// RVA: 0x5AE190 Offset: 0x5AC790 VA: 0x1805AE190
	public bool TryAddSubAnimToQueue(string subAnimatorKey, string clipName, bool loop = False, bool resumeQueue = False) { }

	// RVA: 0x5AE0C0 Offset: 0x5AC6C0 VA: 0x1805AE0C0
	public bool TryAddSubAnimToQueue(string subAnimatorKey, string clipName, bool loop, int startTime, int blendFrames = 0, bool resumeQueue = False) { }

	// RVA: 0x5AE040 Offset: 0x5AC640 VA: 0x1805AE040
	public void Stop() { }

	// RVA: 0x5ADD10 Offset: 0x5AC310 VA: 0x1805ADD10
	public void StopAllSubAnimations() { }

	// RVA: 0x5ADEE0 Offset: 0x5AC4E0 VA: 0x1805ADEE0
	public void StopSubAnimation(string subAnimatorKey) { }

	// RVA: 0x5ADC50 Offset: 0x5AC250 VA: 0x1805ADC50
	public void ResumeQueue() { }

	// RVA: 0x5ADC80 Offset: 0x5AC280 VA: 0x1805ADC80
	public void ResumeSubanimatorQueue(string subAnimatorKey) { }

	// RVA: 0x5ADCF0 Offset: 0x5AC2F0 VA: 0x1805ADCF0
	public void Seek(float frame) { }

	// RVA: 0x5ADA80 Offset: 0x5AC080 VA: 0x1805ADA80
	public void OnDestroy() { }

	// RVA: 0x5AE410 Offset: 0x5ACA10 VA: 0x1805AE410
	public void .ctor() { }
}
