// Namespace: Quantum
[Serializable]
public struct EnvironmentCollisionBox // TypeDefIndex: 9921
{
	// Fields
	public FPVector2 Bottom; // 0x8
	public RuntimeECBOffset BottomOffset; // 0x98
	public FPVector2 CacheBottom; // 0x18
	public FPVector2 CacheLeft; // 0x28
	public FPVector2 CacheRight; // 0x38
	public FPVector2 CacheTop; // 0x48
	public FPVector2 Left; // 0x58
	public RuntimeECBOffset LeftOffset; // 0xA8
	public int PresetID; // 0x0
	public FPVector2 PreviousGlobalCenter; // 0x68
	public FPVector2 Right; // 0x78
	public RuntimeECBOffset RightOffset; // 0xB8
	public QBoolean RootAsBottom; // 0x4
	public FPVector2 Top; // 0x88
	public RuntimeECBOffset TopOffset; // 0xC8

	// Methods

	// RVA: 0x20CE850 Offset: 0x20CCE50 VA: 0x1820CE850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CEB20 Offset: 0x20CD120 VA: 0x1820CEB20
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20CEE00 Offset: 0x20CD400 VA: 0x1820CEE00
	public void Update(Frame frame, PhysicsData physicsData, GameEntity* gameEntity, PhysicsBody* physicsBody) { }

	// RVA: 0x20CE060 Offset: 0x20CC660 VA: 0x1820CE060
	public void ClearCache() { }

	// RVA: 0x20CE020 Offset: 0x20CC620 VA: 0x1820CE020
	public FPVector2 Center() { }

	// RVA: 0x20CE9C0 Offset: 0x20CCFC0 VA: 0x1820CE9C0
	public FPVector2 GlobalCenter(Transform2D* transform) { }

	// RVA: 0x20CEAD0 Offset: 0x20CD0D0 VA: 0x1820CEAD0
	public FPVector2 GlobalTop(Transform2D* transform) { }

	// RVA: 0x20CE980 Offset: 0x20CCF80 VA: 0x1820CE980
	public FPVector2 GlobalBottom(Transform2D* transform) { }

	// RVA: 0x20CEA50 Offset: 0x20CD050 VA: 0x1820CEA50
	public FPVector2 GlobalLeft(Transform2D* transform) { }

	// RVA: 0x20CEA90 Offset: 0x20CD090 VA: 0x1820CEA90
	public FPVector2 GlobalRight(Transform2D* transform) { }

	// RVA: 0x20CEDA0 Offset: 0x20CD3A0 VA: 0x1820CEDA0
	public FPVector2 Size() { }

	// RVA: 0x20CE0D0 Offset: 0x20CC6D0 VA: 0x1820CE0D0
	private void ECBFromCache(GameEntity* gameEntity, bool rootAsBottom) { }

	// RVA: 0x20CE2F0 Offset: 0x20CC8F0 VA: 0x1820CE2F0
	private void ECBFromPreset(Frame frame, PhysicsData physicsData, GameEntity* gameEntity, bool rootAsBottom) { }

	// RVA: 0x20CE510 Offset: 0x20CCB10 VA: 0x1820CE510
	public void GenerateECB(int facingDirection, bool rootAsBottom, FP highestX, FP highestY, FP lowestX, FP lowestY) { }

	// RVA: 0x20CDFE0 Offset: 0x20CC5E0 VA: 0x1820CDFE0
	private FP CalculateECBOffset(FP point, RuntimeECBOffset offset, bool inverted = False) { }
}
