// Namespace: 
public class TournamentMatchResultCharacterSpawner : SRMonoBehaviour // TypeDefIndex: 3188
{
	// Fields
	[CompilerGenerated]
	private TournamentMatchResultCharacterSpawner.CharacterInstanceFinished OnCharacterInstanceFinished; // 0x20
	public Camera CharacterCamera; // 0x28
	public Transform CharacterContainer; // 0x30
	public Animator Animator; // 0x38
	public TournamentMatchResultCharacterFloor CharacterFloor; // 0x40
	private GameObject activeCharacter; // 0x48
	private Animator activeCharacterAnimator; // 0x50
	private bool triggerWinnerAnimation; // 0x58
	private bool triggerEliminatedAnimation; // 0x59
	private string spawnCharacterOperationID; // 0x60
	private int explosionTriggerID; // 0x68
	private int runOutOfScreenTriggerID; // 0x6C
	private int idleTriggerID; // 0x70
	private int runTriggerID; // 0x74
	private int tumbleTriggerID; // 0x78
	private int victoryTriggerID; // 0x7C
	private float explosionTimer; // 0x80
	private bool activeTimer; // 0x84
	private bool exploted; // 0x85

	// Methods

	[CompilerGenerated]
	// RVA: 0x58E750 Offset: 0x58CD50 VA: 0x18058E750
	public void add_OnCharacterInstanceFinished(TournamentMatchResultCharacterSpawner.CharacterInstanceFinished value) { }

	[CompilerGenerated]
	// RVA: 0x58E7F0 Offset: 0x58CDF0 VA: 0x18058E7F0
	public void remove_OnCharacterInstanceFinished(TournamentMatchResultCharacterSpawner.CharacterInstanceFinished value) { }

	// RVA: 0x58E210 Offset: 0x58C810 VA: 0x18058E210
	public void InstanceCharacter(int characterID, int costumeIndex, bool isWinner, bool isEliminated) { }

	// RVA: 0x58E4B0 Offset: 0x58CAB0 VA: 0x18058E4B0
	public void StartExplosionPhase() { }

	// RVA: 0x58E500 Offset: 0x58CB00 VA: 0x18058E500
	public void StartRunOutOfScreenPhase() { }

	// RVA: 0x58E550 Offset: 0x58CB50 VA: 0x18058E550
	public void StartWinnerPhase() { }

	// RVA: 0x58E3F0 Offset: 0x58C9F0 VA: 0x18058E3F0
	public void PlayIdleAnimaion() { }

	// RVA: 0x58E430 Offset: 0x58CA30 VA: 0x18058E430
	public void PlayRunAnimation() { }

	// RVA: 0x58E470 Offset: 0x58CA70 VA: 0x18058E470
	public void PlayTumbleAnimation() { }

	// RVA: 0x58DF30 Offset: 0x58C530 VA: 0x18058DF30
	private void CharacterInstanced(string operationID, GameObject characterGameObject, Animator characterAnimator) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	private void HideFloorExplosion() { }

	// RVA: 0x58E5C0 Offset: 0x58CBC0 VA: 0x18058E5C0
	public void Update() { }

	// RVA: 0x58E0D0 Offset: 0x58C6D0 VA: 0x18058E0D0
	public void Clear() { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670
	public void .ctor() { }
}
