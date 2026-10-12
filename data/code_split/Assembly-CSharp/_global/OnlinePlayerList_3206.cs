// Namespace: 
public class OnlinePlayerList : SRMonoBehaviour // TypeDefIndex: 3206
{
	// Fields
	public PlayerListOptions PlayerListOptionsGO; // 0x20
	public PlayerListOnlineBadge EmptyBadge; // 0x28
	public PlayerListOnlineBadge EmptyBadge2; // 0x30
	public Transform BadgesContainer; // 0x38
	public UINavigator navigator; // 0x40
	private bool isRecentPlayersList; // 0x48

	// Methods

	// RVA: 0x5830B0 Offset: 0x5816B0 VA: 0x1805830B0
	private void OnEnable() { }

	// RVA: 0x582F70 Offset: 0x581570 VA: 0x180582F70
	private void OnDisable() { }

	// RVA: 0x5829C0 Offset: 0x580FC0 VA: 0x1805829C0
	private PlayerListOnlineBadge GetBadge(int badgeIndex) { }

	// RVA: 0x582A30 Offset: 0x581030 VA: 0x180582A30
	public void InitOnlinePlayerList(List<SavedPlayerData> players, bool isRecentList = False) { }

	// RVA: 0x583320 Offset: 0x581920 VA: 0x180583320
	private void PhotonRoomUpdate() { }

	// RVA: 0x583240 Offset: 0x581840 VA: 0x180583240
	public void OpenPlayerListOptions(SavedPlayerData id) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
