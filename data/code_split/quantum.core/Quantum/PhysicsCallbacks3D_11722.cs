// Namespace: Quantum
internal struct PhysicsCallbacks3D : IComponent // TypeDefIndex: 11722
{
	// Fields
	public const int SIZE = 16;
	private const int DEFAULT_LIST_CAPACITY = 4;
	public CallbackFlags Flags; // 0x0
	[PtrBuffer(typeof(PhysicsCommon.CollisionCallbackInfo), "_listCount")]
	private Ptr _listBufferPtr; // 0x4
	private int _listCount; // 0x8
	private int _listCapacity; // 0xC

	// Properties
	public int ListCount { get; set; }
	public Ptr ListBufferPtr { get; }

	// Methods

	// RVA: 0x2227220 Offset: 0x2225820 VA: 0x182227220
	private PhysicsCommon.CollisionCallbackInfo* EnsureListCapacity(FrameBase f) { }

	// RVA: 0x221DE60 Offset: 0x221C460 VA: 0x18221DE60
	public bool IsCollidingWith(FrameBase f, EntityRef entity, out int index) { }

	// RVA: 0x221DDE0 Offset: 0x221C3E0 VA: 0x18221DDE0
	public bool IsCollidingWith(FrameBase f, AssetGuid mapGuid, int staticColliderId, out int index) { }

	// RVA: 0x2227150 Offset: 0x2225750 VA: 0x182227150
	public void AddCollision(FrameBase f, EntityRef entity) { }

	// RVA: 0x22271A0 Offset: 0x22257A0 VA: 0x1822271A0
	public void AddCollision(FrameBase f, AssetGuid mapGuid, int staticColliderId, bool isTrigger) { }

	// RVA: 0x2221B10 Offset: 0x2220110 VA: 0x182221B10
	internal void SetEntryIsActive(FrameBase f, int entryIdx, bool isActive) { }

	// RVA: 0xE03F60 Offset: 0xE02560 VA: 0x180E03F60
	public int get_ListCount() { }

	// RVA: 0x1ED2130 Offset: 0x1ED0730 VA: 0x181ED2130
	internal void set_ListCount(int value) { }

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40
	public Ptr get_ListBufferPtr() { }

	// RVA: 0x22273B0 Offset: 0x22259B0 VA: 0x1822273B0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x221DED0 Offset: 0x221C4D0 VA: 0x18221DED0
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x221DEE0 Offset: 0x221C4E0 VA: 0x18221DEE0
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
