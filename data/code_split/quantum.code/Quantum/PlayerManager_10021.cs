// Namespace: Quantum
public struct PlayerManager : IComponent // TypeDefIndex: 10021
{
	// Fields
	public QBoolean IsNPC; // 0x8
	public int NPCID; // 0x0
	public PlayerRef PlayerRef; // 0x4

	// Methods

	// RVA: 0x2127890 Offset: 0x2125E90 VA: 0x182127890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2127950 Offset: 0x2125F50 VA: 0x182127950
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2127760 Offset: 0x2125D60 VA: 0x182127760
	public static void Create(Frame frame, PlayerRef playerRef) { }

	// RVA: 0x21277F0 Offset: 0x2125DF0 VA: 0x1821277F0
	public static void Create(Frame frame, int npcID) { }

	// RVA: 0x2127FB0 Offset: 0x21265B0 VA: 0x182127FB0
	public static bool TryFind(Frame frame, string playerID, out PlayerManager* playerManager, out EntityRef entityRef) { }

	// RVA: 0x2127E00 Offset: 0x2126400 VA: 0x182127E00
	public static bool TryFind(Frame frame, PlayerRef playerRef, out PlayerManager* playerManager, out EntityRef entityRef) { }

	// RVA: 0x21279E0 Offset: 0x2125FE0 VA: 0x1821279E0
	public static bool TryFind(Frame frame, int npcID, out PlayerManager* playerManager, out EntityRef entityRef) { }

	// RVA: 0x2127B80 Offset: 0x2126180 VA: 0x182127B80
	public static bool TryFind(Frame frame, EntityRef characterEntity, out PlayerManager* playerManager, out EntityRef entityRef) { }

	// RVA: 0x21278D0 Offset: 0x2125ED0 VA: 0x1821278D0
	public string GetPlayerID() { }
}
