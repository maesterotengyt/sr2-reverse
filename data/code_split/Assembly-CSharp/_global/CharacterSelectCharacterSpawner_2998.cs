// Namespace: 
public class CharacterSelectCharacterSpawner : SRMonoBehaviour // TypeDefIndex: 2998
{
	// Fields
	public Transform CharacterInitalSpot; // 0x20
	public float CharacterRunSpeed; // 0x28
	private string spawnCharacterOperationID; // 0x30
	private GameObject spawnedCharacter; // 0x38
	private GameObject previousCharacter; // 0x40
	private int currentCharacterID; // 0x48
	private int spawnedCharacterID; // 0x4C
	private int currentCharacterCostume; // 0x50
	private int spawnedCharacterCostume; // 0x54
	private bool randomCharacter; // 0x58
	private CharacterSelectCharacterSpawner.CharacterSpawnerState currentState; // 0x5C

	// Methods

	// RVA: 0x773DC0 Offset: 0x7723C0 VA: 0x180773DC0
	public void InstanceCharacter(int characterID, int costume, bool random) { }

	// RVA: 0x7739F0 Offset: 0x771FF0 VA: 0x1807739F0
	private void CharacterInstanced(string operationID, GameObject characterGameObject, Animator characterAnimator) { }

	// RVA: 0x774060 Offset: 0x772660 VA: 0x180774060
	private void Update() { }

	// RVA: 0x773CB0 Offset: 0x7722B0 VA: 0x180773CB0
	public void Disable() { }

	// RVA: 0x774050 Offset: 0x772650 VA: 0x180774050
	private void OnDestroy() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
