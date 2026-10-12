// Namespace: Photon.Realtime
public class Player // TypeDefIndex: 3983
{
	// Fields
	[CompilerGenerated]
	private Room <RoomReference>k__BackingField; // 0x10
	private int actorNumber; // 0x18
	public readonly bool IsLocal; // 0x1C
	[CompilerGenerated]
	private bool <HasRejoined>k__BackingField; // 0x1D
	private string nickName; // 0x20
	[CompilerGenerated]
	private string <UserId>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsInactive>k__BackingField; // 0x30
	[CompilerGenerated]
	private Hashtable <CustomProperties>k__BackingField; // 0x38
	public object TagObject; // 0x40

	// Properties
	protected internal Room RoomReference { get; set; }
	public int ActorNumber { get; }
	public bool HasRejoined { get; set; }
	public string NickName { get; set; }
	public string UserId { get; set; }
	public bool IsMasterClient { get; }
	public bool IsInactive { get; set; }
	public Hashtable CustomProperties { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	protected internal Room get_RoomReference() { }

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	protected internal void set_RoomReference(Room value) { }

	// RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180
	public int get_ActorNumber() { }

	[CompilerGenerated]
	// RVA: 0x67DD80 Offset: 0x67C380 VA: 0x18067DD80
	public bool get_HasRejoined() { }

	[CompilerGenerated]
	// RVA: 0x67DDB0 Offset: 0x67C3B0 VA: 0x18067DDB0
	internal void set_HasRejoined(bool value) { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public string get_NickName() { }

	// RVA: 0x67DDC0 Offset: 0x67C3C0 VA: 0x18067DDC0
	public void set_NickName(string value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public string get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	internal void set_UserId(string value) { }

	// RVA: 0x67DD90 Offset: 0x67C390 VA: 0x18067DD90
	public bool get_IsMasterClient() { }

	[CompilerGenerated]
	// RVA: 0x5DCA80 Offset: 0x5DB080 VA: 0x1805DCA80
	public bool get_IsInactive() { }

	[CompilerGenerated]
	// RVA: 0x5DCA90 Offset: 0x5DB090 VA: 0x1805DCA90
	protected internal void set_IsInactive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public Hashtable get_CustomProperties() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	public void set_CustomProperties(Hashtable value) { }

	// RVA: 0x67DC80 Offset: 0x67C280 VA: 0x18067DC80
	protected internal void .ctor(string nickName, int actorNumber, bool isLocal) { }

	// RVA: 0x67DB80 Offset: 0x67C180 VA: 0x18067DB80
	protected internal void .ctor(string nickName, int actorNumber, bool isLocal, Hashtable playerProperties) { }

	// RVA: 0x67D3E0 Offset: 0x67B9E0 VA: 0x18067D3E0
	public Player Get(int id) { }

	// RVA: 0x67D3D0 Offset: 0x67B9D0 VA: 0x18067D3D0
	public Player GetNext() { }

	// RVA: 0x67D3B0 Offset: 0x67B9B0 VA: 0x18067D3B0
	public Player GetNextFor(Player currentPlayer) { }

	// RVA: 0x67D190 Offset: 0x67B790 VA: 0x18067D190
	public Player GetNextFor(int currentPlayerId) { }

	// RVA: 0x67D410 Offset: 0x67BA10 VA: 0x18067D410 Slot: 4
	protected internal virtual void InternalCacheProperties(Hashtable properties) { }

	// RVA: 0x67DB20 Offset: 0x67C120 VA: 0x18067DB20 Slot: 3
	public override string ToString() { }

	// RVA: 0x67D8C0 Offset: 0x67BEC0 VA: 0x18067D8C0
	public string ToStringFull() { }

	// RVA: 0x67D0D0 Offset: 0x67B6D0 VA: 0x18067D0D0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x67D0C0 Offset: 0x67B6C0 VA: 0x18067D0C0
	protected internal void ChangeLocalID(int newID) { }

	// RVA: 0x67D610 Offset: 0x67BC10 VA: 0x18067D610
	public bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues, WebFlags webFlags) { }

	// RVA: 0x67D810 Offset: 0x67BE10 VA: 0x18067D810
	private bool SetPlayerNameProperty() { }
}
