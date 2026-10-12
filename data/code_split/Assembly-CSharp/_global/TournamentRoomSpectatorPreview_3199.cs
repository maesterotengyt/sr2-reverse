// Namespace: 
public class TournamentRoomSpectatorPreview : SRMonoBehaviour // TypeDefIndex: 3199
{
	// Fields
	public List<TournamentRoomSpectatorPreview.PlayerData> PlayersData; // 0x20
	public GameObject SpectateLabel; // 0x28
	public GameObject UnableToSpectateLabel; // 0x30
	public GameObject WaitingLabel; // 0x38
	private List<TournamentPlayer> tournamentPlayers; // 0x40

	// Methods

	// RVA: 0x5931C0 Offset: 0x5917C0 VA: 0x1805931C0
	public void SetRoomData(RoomData roomData, List<TournamentPlayer> tournamentPlayers) { }

	// RVA: 0x592FE0 Offset: 0x5915E0 VA: 0x180592FE0
	private void SetPlayerData(int index, string playerName, BadgeIconData playerIcon) { }

	// RVA: 0x593550 Offset: 0x591B50 VA: 0x180593550
	public void SetSelectedState(bool selected) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
