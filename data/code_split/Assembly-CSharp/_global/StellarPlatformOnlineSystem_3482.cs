// Namespace: 
public class StellarPlatformOnlineSystem : StellarMonoBehaviour // TypeDefIndex: 3482
{
	// Methods

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 4
	public virtual bool CheckInternetConnection() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void ConnectOnline() { }

	// RVA: 0x5F2810 Offset: 0x5F0E10 VA: 0x1805F2810 Slot: 6
	public virtual AuthenticationValues SetupPhotonAuthentication() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void CreateOnlineLobby(bool publicLobby) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public virtual void JoinOnlineLobby(string platformLobbyID) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public virtual void LeaveOnlineLobby() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void UpdatePhotonRoomID(string newPhotonRoomID) { }

	// RVA: 0x5F27C0 Offset: 0x5F0DC0 VA: 0x1805F27C0 Slot: 11
	public virtual string GetPhotonRoomID() { }

	// RVA: 0x5F2790 Offset: 0x5F0D90 VA: 0x1805F2790 Slot: 12
	public virtual string GetLobbyRegion() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 13
	public virtual void ShowInvitationMenu() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 14
	public virtual void AuthenticateBraincloud() { }

	// RVA: 0x5F27F0 Offset: 0x5F0DF0 VA: 0x1805F27F0 Slot: 15
	public virtual void RecheckCrossplayWithUI(Action onDone) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
