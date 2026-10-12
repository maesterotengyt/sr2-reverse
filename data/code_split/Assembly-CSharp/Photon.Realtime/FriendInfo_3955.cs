// Namespace: Photon.Realtime
public class FriendInfo // TypeDefIndex: 3955
{
	// Fields
	[CompilerGenerated]
	private string <UserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsOnline>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Room>k__BackingField; // 0x20

	// Properties
	[Obsolete("Use UserId.")]
	public string Name { get; }
	public string UserId { get; set; }
	public bool IsOnline { get; set; }
	public string Room { get; set; }
	public bool IsInRoom { get; }

	// Methods

	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public string get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	protected internal void set_UserId(string value) { }

	[CompilerGenerated]
	// RVA: 0x676D40 Offset: 0x675340 VA: 0x180676D40
	public bool get_IsOnline() { }

	[CompilerGenerated]
	// RVA: 0x676D50 Offset: 0x675350 VA: 0x180676D50
	protected internal void set_IsOnline(bool value) { }

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public string get_Room() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	protected internal void set_Room(string value) { }

	// RVA: 0x676D10 Offset: 0x675310 VA: 0x180676D10
	public bool get_IsInRoom() { }

	// RVA: 0x676C60 Offset: 0x675260 VA: 0x180676C60 Slot: 3
	public override string ToString() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
