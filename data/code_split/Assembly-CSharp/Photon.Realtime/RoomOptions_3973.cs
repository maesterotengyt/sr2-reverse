// Namespace: Photon.Realtime
public class RoomOptions // TypeDefIndex: 3973
{
	// Fields
	private bool isVisible; // 0x10
	private bool isOpen; // 0x11
	public int MaxPlayers; // 0x14
	public int PlayerTtl; // 0x18
	public int EmptyRoomTtl; // 0x1C
	private bool cleanupCacheOnLeave; // 0x20
	public Hashtable CustomRoomProperties; // 0x28
	public string[] CustomRoomPropertiesForLobby; // 0x30
	public string[] Plugins; // 0x38
	[CompilerGenerated]
	private bool <SuppressRoomEvents>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <SuppressPlayerInfo>k__BackingField; // 0x41
	[CompilerGenerated]
	private bool <PublishUserId>k__BackingField; // 0x42
	[CompilerGenerated]
	private bool <DeleteNullProperties>k__BackingField; // 0x43
	private bool broadcastPropsChangeToAll; // 0x44

	// Properties
	public bool IsVisible { get; set; }
	public bool IsOpen { get; set; }
	public bool CleanupCacheOnLeave { get; set; }
	public bool SuppressRoomEvents { get; set; }
	public bool SuppressPlayerInfo { get; set; }
	public bool PublishUserId { get; set; }
	public bool DeleteNullProperties { get; set; }
	public bool BroadcastPropsChangeToAll { get; set; }

	// Methods

	// RVA: 0x537B50 Offset: 0x536150 VA: 0x180537B50
	public bool get_IsVisible() { }

	// RVA: 0x667A30 Offset: 0x666030 VA: 0x180667A30
	public void set_IsVisible(bool value) { }

	// RVA: 0x681160 Offset: 0x67F760 VA: 0x180681160
	public bool get_IsOpen() { }

	// RVA: 0x6811B0 Offset: 0x67F7B0 VA: 0x1806811B0
	public void set_IsOpen(bool value) { }

	// RVA: 0x627880 Offset: 0x625E80 VA: 0x180627880
	public bool get_CleanupCacheOnLeave() { }

	// RVA: 0x4FA000 Offset: 0x4F8600 VA: 0x1804FA000
	public void set_CleanupCacheOnLeave(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5CC0D0 Offset: 0x5CA6D0 VA: 0x1805CC0D0
	public bool get_SuppressRoomEvents() { }

	[CompilerGenerated]
	// RVA: 0x611280 Offset: 0x60F880 VA: 0x180611280
	public void set_SuppressRoomEvents(bool value) { }

	[CompilerGenerated]
	// RVA: 0x681180 Offset: 0x67F780 VA: 0x180681180
	public bool get_SuppressPlayerInfo() { }

	[CompilerGenerated]
	// RVA: 0x6811D0 Offset: 0x67F7D0 VA: 0x1806811D0
	public void set_SuppressPlayerInfo(bool value) { }

	[CompilerGenerated]
	// RVA: 0x681170 Offset: 0x67F770 VA: 0x180681170
	public bool get_PublishUserId() { }

	[CompilerGenerated]
	// RVA: 0x6811C0 Offset: 0x67F7C0 VA: 0x1806811C0
	public void set_PublishUserId(bool value) { }

	[CompilerGenerated]
	// RVA: 0x681150 Offset: 0x67F750 VA: 0x180681150
	public bool get_DeleteNullProperties() { }

	[CompilerGenerated]
	// RVA: 0x6811A0 Offset: 0x67F7A0 VA: 0x1806811A0
	public void set_DeleteNullProperties(bool value) { }

	// RVA: 0x681140 Offset: 0x67F740 VA: 0x180681140
	public bool get_BroadcastPropsChangeToAll() { }

	// RVA: 0x681190 Offset: 0x67F790 VA: 0x180681190
	public void set_BroadcastPropsChangeToAll(bool value) { }

	// RVA: 0x6810E0 Offset: 0x67F6E0 VA: 0x1806810E0
	public void .ctor() { }
}
