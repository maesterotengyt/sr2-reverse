// Namespace: 
public class CharactersSelectorsManager : SRMonoBehaviour // TypeDefIndex: 3031
{
	// Fields
	public List<CharacterSelector> Selectors; // 0x20
	public List<CharacterSelector> DeletePlayerSelectors; // 0x28
	public int CurrentCPUDifficulty; // 0x30
	private CharacterSelectBase characterSelect; // 0x38
	private CharacterSelector ActiveDeleteSelector; // 0x40

	// Methods

	// RVA: 0x797B10 Offset: 0x796110 VA: 0x180797B10
	public void Init(CharacterSelectBase characterSelect) { }

	// RVA: 0x796D90 Offset: 0x795390 VA: 0x180796D90
	public void CreatePlayerSelector(int playerIndex, int inputDeviceIndex, HashString characterID, int costume, bool randomCharacter, string nickName) { }

	// RVA: 0x796970 Offset: 0x794F70 VA: 0x180796970
	public void CreateCPUSelector(CharacterSpawnData npcData) { }

	// RVA: 0x798C70 Offset: 0x797270 VA: 0x180798C70
	private void Update() { }

	// RVA: 0x798490 Offset: 0x796A90 VA: 0x180798490
	public void ReleaseReservedSelectorsByPlayerIndex(int playerIndex) { }

	// RVA: 0x798830 Offset: 0x796E30 VA: 0x180798830
	public void SetDisabledSelectorsInJoinMode() { }

	// RVA: 0x798300 Offset: 0x796900 VA: 0x180798300
	public bool MeetsBotAchievementCriteria(int minimumBots) { }

	// RVA: 0x7979D0 Offset: 0x795FD0 VA: 0x1807979D0
	public CharacterSelector GetUnusedSelector() { }

	// RVA: 0x7985C0 Offset: 0x796BC0 VA: 0x1807985C0
	public bool RemoveCPUSelector() { }

	// RVA: 0x7968E0 Offset: 0x794EE0 VA: 0x1807968E0
	public void ChangeToRightSelector(CharacterSelector currentSelector) { }

	// RVA: 0x796850 Offset: 0x794E50 VA: 0x180796850
	public void ChangeToLeftSelector(CharacterSelector currentSelector) { }

	// RVA: 0x798AC0 Offset: 0x7970C0 VA: 0x180798AC0
	private bool TryGetRightSelector(CharacterSelector currentSelector, out CharacterSelector rightSelector) { }

	// RVA: 0x798950 Offset: 0x796F50 VA: 0x180798950
	private bool TryGetLeftSelector(CharacterSelector currentSelector, out CharacterSelector leftSelector) { }

	// RVA: 0x796670 Offset: 0x794C70 VA: 0x180796670
	private bool CanSelectorBeReserved(CharacterSelector selector, int playerIndex) { }

	// RVA: 0x798770 Offset: 0x796D70 VA: 0x180798770
	private void SelectorReserved(CharacterSelector updatedSelector, ReserveSelectorContext context) { }

	// RVA: 0x7986F0 Offset: 0x796CF0 VA: 0x1807986F0
	private void SelectorReserveCanceled(CharacterSelector updatedSelector) { }

	// RVA: 0x7972A0 Offset: 0x7958A0 VA: 0x1807972A0
	public int GetAmountOfEnabledSelectors() { }

	// RVA: 0x7981B0 Offset: 0x7967B0 VA: 0x1807981B0
	public bool InputDeviceIndexAlreadyOnUse(int inputDeviceIndex) { }

	// RVA: 0x797160 Offset: 0x795760 VA: 0x180797160
	public int GetAmountOfEnabledPlayerSelectors() { }

	// RVA: 0x797690 Offset: 0x795C90 VA: 0x180797690
	public HashString GetUnusedCharacterID() { }

	// RVA: 0x7964F0 Offset: 0x794AF0 VA: 0x1807964F0
	public bool AreAllSelectorsReady() { }

	// RVA: 0x7966C0 Offset: 0x794CC0 VA: 0x1807966C0
	public void CancelReserveOnAllSelectors() { }

	// RVA: 0x797530 Offset: 0x795B30 VA: 0x180797530
	public CharacterSelector GetPlayerDefaultSelector(int playerIndex) { }

	// RVA: 0x7973D0 Offset: 0x7959D0 VA: 0x1807973D0
	public CharacterSelector GetPlayerCurrentSelector(int playerIndex) { }

	// RVA: 0x796FA0 Offset: 0x7955A0 VA: 0x180796FA0
	public void Disable() { }

	// RVA: 0x798F60 Offset: 0x797560 VA: 0x180798F60
	public void .ctor() { }
}
