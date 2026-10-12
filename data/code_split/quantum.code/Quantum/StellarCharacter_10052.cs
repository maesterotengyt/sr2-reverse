// Namespace: Quantum
public struct StellarCharacter : IComponent // TypeDefIndex: 10052
{
	// Fields
	public const int SIZE = 160;
	public const int ALIGNMENT = 8;
	public QBoolean Active; // 0x10
	public int CharacterID; // 0x0
	public EntityRef Entity; // 0x18
	public QStringUtf8_64 Nickname; // 0x60
	public int PartnerCharacterIndex; // 0x4
	public QString64 PlayerID; // 0x20
	public PlayerRef PlayerRef; // 0xC
	public int SpawnOrder; // 0x8
	public QBoolean StartDisabled; // 0x14

	// Methods

	// RVA: 0x2134A70 Offset: 0x2133070 VA: 0x182134A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2134B00 Offset: 0x2133100 VA: 0x182134B00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void InitializeCharacter(Frame frame) { }

	// RVA: 0x2134A30 Offset: 0x2133030 VA: 0x182134A30
	public void EnableCharacter(Frame frame, CharacterActivationType activationtype = 1) { }

	// RVA: 0x21349F0 Offset: 0x2132FF0 VA: 0x1821349F0
	public void DisableCharacter(Frame frame) { }
}
