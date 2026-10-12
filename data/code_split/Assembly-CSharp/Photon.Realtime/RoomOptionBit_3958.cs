// Namespace: Photon.Realtime
internal enum RoomOptionBit // TypeDefIndex: 3958
{
	// Fields
	public int value__; // 0x0
	public const RoomOptionBit CheckUserOnJoin = 1;
	public const RoomOptionBit DeleteCacheOnLeave = 2;
	public const RoomOptionBit SuppressRoomEvents = 4;
	public const RoomOptionBit PublishUserId = 8;
	public const RoomOptionBit DeleteNullProps = 16;
	public const RoomOptionBit BroadcastPropsChangeToAll = 32;
	public const RoomOptionBit SuppressPlayerInfo = 64;
}
