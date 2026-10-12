// Namespace: Photon.Realtime
public enum EventCaching // TypeDefIndex: 3971
{
	// Fields
	public byte value__; // 0x0
	public const EventCaching DoNotCache = 0;
	[Obsolete]
	public const EventCaching MergeCache = 1;
	[Obsolete]
	public const EventCaching ReplaceCache = 2;
	[Obsolete]
	public const EventCaching RemoveCache = 3;
	public const EventCaching AddToRoomCache = 4;
	public const EventCaching AddToRoomCacheGlobal = 5;
	public const EventCaching RemoveFromRoomCache = 6;
	public const EventCaching RemoveFromRoomCacheForActorsLeft = 7;
	public const EventCaching SliceIncreaseIndex = 10;
	public const EventCaching SliceSetIndex = 11;
	public const EventCaching SlicePurgeIndex = 12;
	public const EventCaching SlicePurgeUpToIndex = 13;
}
