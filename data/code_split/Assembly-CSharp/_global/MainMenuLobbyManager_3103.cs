// Namespace: 
public class MainMenuLobbyManager : SRMonoBehaviour // TypeDefIndex: 3103
{
	// Fields
	public int StartMatchTimer; // 0x20
	public int EightPlayersMatchStartTimer; // 0x24
	public int Ranked1v1StartTimer; // 0x28
	public int StartFullRoomTimer; // 0x2C
	[Header("Menu Data (Only for visualization)")]
	public HashString CharacterID; // 0x30
	public int CharacterCostume; // 0x40
	public bool RandomCharacter; // 0x44
	public TMP_Text PasswordText; // 0x48
	public GameObject PasswordToggle; // 0x50
	public PracticeMenuWorld PracticeMenu; // 0x58
	private MainMenuHub newMainMenu; // 0x60
	private bool passwordHidden; // 0x68
	private bool lastPasswordToggleActive; // 0x69
	private float matchSearchTimer; // 0x6C
	private float startingTimer; // 0x70
	private bool ready; // 0x74
	[CompilerGenerated]
	private bool <Starting>k__BackingField; // 0x75
	[CompilerGenerated]
	private bool <WaitingPlayers>k__BackingField; // 0x76
	public bool Typing; // 0x77
	public bool chatInteraction; // 0x78
	private float stuckAtZeroTimer; // 0x7C

	// Properties
	private StellarOnlineSystem onlineSystem { get; }
	private MainMenu mainMenu { get; }
	private StellarDataSystem dataSystem { get; }
	private StellarPlatformSystem platformSystem { get; }
	public bool Starting { get; set; }
	public bool WaitingPlayers { get; set; }

	// Methods

	// RVA: 0x5645B0 Offset: 0x562BB0 VA: 0x1805645B0
	private StellarOnlineSystem get_onlineSystem() { }

	// RVA: 0x564550 Offset: 0x562B50 VA: 0x180564550
	private MainMenu get_mainMenu() { }

	// RVA: 0x564500 Offset: 0x562B00 VA: 0x180564500
	private StellarDataSystem get_dataSystem() { }

	// RVA: 0x564600 Offset: 0x562C00 VA: 0x180564600
	private StellarPlatformSystem get_platformSystem() { }

	[CompilerGenerated]
	// RVA: 0x5644E0 Offset: 0x562AE0 VA: 0x1805644E0
	public bool get_Starting() { }

	[CompilerGenerated]
	// RVA: 0x564650 Offset: 0x562C50 VA: 0x180564650
	public void set_Starting(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5644F0 Offset: 0x562AF0 VA: 0x1805644F0
	public bool get_WaitingPlayers() { }

	[CompilerGenerated]
	// RVA: 0x564660 Offset: 0x562C60 VA: 0x180564660
	public void set_WaitingPlayers(bool value) { }

	// RVA: 0x55BEB0 Offset: 0x55A4B0 VA: 0x18055BEB0
	public void Initialize(MainMenuHub newMainMenu) { }

	// RVA: 0x55AAC0 Offset: 0x5590C0 VA: 0x18055AAC0
	public bool CheckInvitation() { }

	// RVA: 0x55C3D0 Offset: 0x55A9D0 VA: 0x18055C3D0
	private void JoinLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x561AB0 Offset: 0x5600B0 VA: 0x180561AB0
	public void SearchMatch() { }

	// RVA: 0x55DB00 Offset: 0x55C100 VA: 0x18055DB00
	public void OnGoToTutorialSelected(string popUpID, int optionIndex) { }

	// RVA: 0x563BC0 Offset: 0x5621C0 VA: 0x180563BC0
	public void TogglePassword() { }

	// RVA: 0x563BE0 Offset: 0x5621E0 VA: 0x180563BE0
	public void TogglePassword(bool hidden) { }

	// RVA: 0x5624E0 Offset: 0x560AE0 VA: 0x1805624E0
	public void SearchTournamentFinish(bool success) { }

	// RVA: 0x563E40 Offset: 0x562440 VA: 0x180563E40
	private void UpdateTournamentData() { }

	// RVA: 0x55B6E0 Offset: 0x559CE0 VA: 0x18055B6E0
	public void ConnectOnlineResult(bool success, string errorID) { }

	// RVA: 0x55B540 Offset: 0x559B40 VA: 0x18055B540
	private void ConfirmPressedOnAlert(string popUpID) { }

	// RVA: 0x564050 Offset: 0x562650 VA: 0x180564050
	public void Update() { }

	// RVA: 0x55BD70 Offset: 0x55A370 VA: 0x18055BD70
	public string GetSearchTimer() { }

	// RVA: 0x559D80 Offset: 0x558380 VA: 0x180559D80
	public void CancelSearch(bool force = False) { }

	// RVA: 0x561250 Offset: 0x55F850 VA: 0x180561250
	private void SearchMatchMakingLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x560A30 Offset: 0x55F030 VA: 0x180560A30
	public void ResubscribeToEvents() { }

	// RVA: 0x562AC0 Offset: 0x5610C0 VA: 0x180562AC0
	public void SetupTournamentRoom() { }

	// RVA: 0x562710 Offset: 0x560D10 VA: 0x180562710
	public void SetupRoom() { }

	// RVA: 0x560120 Offset: 0x55E720 VA: 0x180560120
	public void ReadyUpForRematch() { }

	// RVA: 0x563D40 Offset: 0x562340 VA: 0x180563D40
	public void UpdateRoomData() { }

	// RVA: 0x55F4E0 Offset: 0x55DAE0 VA: 0x18055F4E0
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x55E4C0 Offset: 0x55CAC0 VA: 0x18055E4C0
	private void OtherPlayerJoinPhotonRoom(Player otherPlayer) { }

	// RVA: 0x55EB50 Offset: 0x55D150 VA: 0x18055EB50
	private void OtherPlayerLeavePhotonRoom(Player otherPlayer) { }

	// RVA: 0x55CA30 Offset: 0x55B030 VA: 0x18055CA30
	public void LeavingLobbyFinished() { }

	// RVA: 0x55DC80 Offset: 0x55C280 VA: 0x18055DC80
	private void OnMatchStarted() { }

	// RVA: 0x562CD0 Offset: 0x5612D0 VA: 0x180562CD0
	private void StartMatch() { }

	// RVA: 0x5639D0 Offset: 0x561FD0 VA: 0x1805639D0
	public void TimerUpdate(bool active, float currentTime) { }

	// RVA: 0x563860 Offset: 0x561E60 VA: 0x180563860
	public void TimerEnd() { }

	// RVA: 0x55ADB0 Offset: 0x5593B0 VA: 0x18055ADB0
	public void Clear() { }

	// RVA: 0x55D370 Offset: 0x55B970 VA: 0x18055D370
	public void OnDestroy() { }

	// RVA: 0x5644B0 Offset: 0x562AB0 VA: 0x1805644B0
	public void .ctor() { }
}
