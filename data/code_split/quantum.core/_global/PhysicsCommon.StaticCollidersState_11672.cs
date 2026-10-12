// Namespace: 
public struct PhysicsCommon.StaticCollidersState // TypeDefIndex: 11672
{
	// Fields
	public const int SIZE = 16;
	private const int STATIC_COLLIDERS_PER_WORD = 64;
	private ushort _disabledStateCollidersCount; // 0x0
	private ushort _disabledStateWordCapacity; // 0x2
	[PtrBuffer(typeof(ulong), "_disabledStateWordCapacity")]
	private Ptr _disabledState; // 0x4
	private AssetRefMap _trackedMap; // 0x8

	// Properties
	public AssetRefMap TrackedMap { get; }

	// Methods

	// RVA: 0x6AB5F0 Offset: 0x6A9BF0 VA: 0x1806AB5F0
	public AssetRefMap get_TrackedMap() { }

	// RVA: 0x220D150 Offset: 0x220B750 VA: 0x18220D150
	private static int GetWordCount(int collidersCount) { }

	// RVA: 0x2220440 Offset: 0x221EA40 VA: 0x182220440
	public void ResetAndEnsureStaticColliderCapacity(IFrameHeap heap, AssetRefMap map, int staticCollidersCount) { }

	// RVA: 0x22201C0 Offset: 0x221E7C0 VA: 0x1822201C0
	public PhysicsCommon.StaticCollidersState.Accessor GetStaticColliderStateAccessor(IFrameHeap heap) { }

	// RVA: 0x22206E0 Offset: 0x221ECE0 VA: 0x1822206E0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2220260 Offset: 0x221E860 VA: 0x182220260
	public static void Print(PhysicsCommon.StaticCollidersState* state, FramePrinter printer) { }
}
