// Namespace: 
public class MainMenuCharacterSpawner : SRMonoBehaviour // TypeDefIndex: 3088
{
	// Fields
	public Transform StartingTransform; // 0x20
	public Transform CharacterSpots; // 0x28
	public GameObject SkinChangeVFX; // 0x30
	public Animator QuestionMarkObject; // 0x38
	private string spawnCharacterOperationID; // 0x40
	private GameObject activeCharacter; // 0x48
	private Animator activeCharacterAnimator; // 0x50
	private int currentCharacterID; // 0x58
	private int spawnedCharacterID; // 0x5C
	private int currentCharacterCostume; // 0x60
	private int spawnedCharacterCostume; // 0x64
	private Coroutine coroutineCharacter; // 0x68
	private bool randomCharacter; // 0x70
	private bool spawning; // 0x71
	private bool readyState; // 0x72
	private bool spawnReady; // 0x73
	private int idleTriggerID; // 0x74
	private int readyIdleTriggerID; // 0x78

	// Methods

	// RVA: 0x54A010 Offset: 0x548610 VA: 0x18054A010
	public void InstanceCharacter(int characterID, int costume, bool random, bool ready = False) { }

	// RVA: 0x549D10 Offset: 0x548310 VA: 0x180549D10
	private void HandleSkinChange() { }

	// RVA: 0x549AB0 Offset: 0x5480B0 VA: 0x180549AB0
	private void HandleCharacterSwap() { }

	// RVA: 0x549700 Offset: 0x547D00 VA: 0x180549700
	private void CharacterInstanced(string operationID, GameObject characterGameObject, Animator characterAnimator) { }

	// RVA: 0x54A300 Offset: 0x548900 VA: 0x18054A300
	private void SkinChangeCharacterInstanced(string operationID, GameObject characterGameObject, Animator characterAnimator) { }

	[IteratorStateMachine(typeof(MainMenuCharacterSpawner.<IdleDelay>d__23))]
	// RVA: 0x549FA0 Offset: 0x5485A0 VA: 0x180549FA0
	private IEnumerator IdleDelay() { }

	// RVA: 0x54A1B0 Offset: 0x5487B0 VA: 0x18054A1B0
	public void PlayIdleAnimaion() { }

	// RVA: 0x54A260 Offset: 0x548860 VA: 0x18054A260
	public void PlayReadyIdleAnimation() { }

	// RVA: 0x549A10 Offset: 0x548010 VA: 0x180549A10
	public void Disable() { }

	// RVA: 0x54A1A0 Offset: 0x5487A0 VA: 0x18054A1A0
	private void OnDestroy() { }

	// RVA: 0x54A5E0 Offset: 0x548BE0 VA: 0x18054A5E0
	public void .ctor() { }
}
