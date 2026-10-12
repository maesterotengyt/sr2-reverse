// Namespace: Photon.Realtime
public class RoomInfo // TypeDefIndex: 3994
{
	// Fields
	public bool RemovedFromList; // 0x10
	private Hashtable customProperties; // 0x18
	protected int maxPlayers; // 0x20
	protected int emptyRoomTtl; // 0x24
	protected int playerTtl; // 0x28
	protected string[] expectedUsers; // 0x30
	protected bool isOpen; // 0x38
	protected bool isVisible; // 0x39
	protected bool autoCleanUp; // 0x3A
	protected string name; // 0x40
	public int masterClientId; // 0x48
	protected string[] propertiesListedInLobby; // 0x50
	[CompilerGenerated]
	private int <PlayerCount>k__BackingField; // 0x58

	// Properties
	public Hashtable CustomProperties { get; }
	public string Name { get; }
	public int PlayerCount { get; set; }
	public int MaxPlayers { get; }
	public bool IsOpen { get; }
	public bool IsVisible { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public Hashtable get_CustomProperties() { }

	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x693B20 Offset: 0x692120 VA: 0x180693B20
	public int get_PlayerCount() { }

	[CompilerGenerated]
	// RVA: 0x693B30 Offset: 0x692130 VA: 0x180693B30
	private void set_PlayerCount(int value) { }

	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_MaxPlayers() { }

	// RVA: 0x670AB0 Offset: 0x66F0B0 VA: 0x180670AB0
	public bool get_IsOpen() { }

	// RVA: 0x682120 Offset: 0x680720 VA: 0x180682120
	public bool get_IsVisible() { }

	// RVA: 0x693A80 Offset: 0x692080 VA: 0x180693A80
	protected internal void .ctor(string roomName, Hashtable roomProperties) { }

	// RVA: 0x692F70 Offset: 0x691570 VA: 0x180692F70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x693000 Offset: 0x691600 VA: 0x180693000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x6937F0 Offset: 0x691DF0 VA: 0x1806937F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x6934F0 Offset: 0x691AF0 VA: 0x1806934F0
	public string ToStringFull() { }

	// RVA: 0x693030 Offset: 0x691630 VA: 0x180693030 Slot: 4
	protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache) { }
}
