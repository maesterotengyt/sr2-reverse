// Namespace: Quantum
[Serializable]
public struct PlayerRef // TypeDefIndex: 11773
{
	// Fields
	public const int SIZE = 4;
	public int _index; // 0x0

	// Properties
	public static PlayerRef None { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x81E2E0 Offset: 0x81C8E0 VA: 0x18081E2E0
	public static PlayerRef get_None() { }

	// RVA: 0x21DC760 Offset: 0x21DAD60 VA: 0x1821DC760
	public bool get_IsValid() { }

	// RVA: 0x2227D90 Offset: 0x2226390 VA: 0x182227D90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xB72450 Offset: 0xB70A50 VA: 0x180B72450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2227EB0 Offset: 0x22264B0 VA: 0x182227EB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2227F30 Offset: 0x2226530 VA: 0x182227F30
	public static int op_Implicit(PlayerRef value) { }

	// RVA: 0x21DC600 Offset: 0x21DAC00 VA: 0x1821DC600
	public static PlayerRef op_Implicit(int value) { }

	// RVA: 0x93A650 Offset: 0x938C50 VA: 0x18093A650
	public static bool op_Equality(PlayerRef a, PlayerRef b) { }

	// RVA: 0x21D8280 Offset: 0x21D6880 VA: 0x1821D8280
	public static bool op_Inequality(PlayerRef a, PlayerRef b) { }

	// RVA: 0x2227E10 Offset: 0x2226410 VA: 0x182227E10
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
