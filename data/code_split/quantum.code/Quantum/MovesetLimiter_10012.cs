// Namespace: Quantum
public struct MovesetLimiter : IComponent // TypeDefIndex: 10012
{
	// Fields
	[HideInInspector]
	[PtrQDictionary(typeof(int), typeof(MoveLimit))]
	private Ptr AvailableMovesPtr; // 0x0
	public AssetRefMovesetLimiterData MovesetLimiterData; // 0x8

	// Properties
	public QDictionaryPtr<int, MoveLimit> AvailableMoves { get; set; }

	// Methods

	// RVA: 0x2121400 Offset: 0x211FA00 VA: 0x182121400
	public QDictionaryPtr<int, MoveLimit> get_AvailableMoves() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_AvailableMoves(QDictionaryPtr<int, MoveLimit> value) { }

	// RVA: 0x2120F20 Offset: 0x211F520 VA: 0x182120F20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0430 Offset: 0x20DEA30 VA: 0x1820E0430
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2121030 Offset: 0x211F630 VA: 0x182121030
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2121270 Offset: 0x211F870 VA: 0x182121270
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x21210B0 Offset: 0x211F6B0 VA: 0x1821210B0
	public void Reset(Frame frame, MovesetLimiterResetContext resetContext = 0) { }

	// RVA: 0x2121330 Offset: 0x211F930 VA: 0x182121330
	public void UpdateMoveUses(Frame frame, int moveHash, int value) { }

	// RVA: 0x2120F50 Offset: 0x211F550 VA: 0x182120F50
	public int GetMoveUses(Frame frame, int moveHash) { }
}
