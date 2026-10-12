// Namespace: Quantum
public struct BossFightGameModeManager : IComponent // TypeDefIndex: 9955
{
	// Fields
	public FP CurrentCountdown; // 0x10
	public FP CurrentMatchTimer; // 0x18
	public BossFightState CurrentState; // 0x0
	public QBoolean HasDialogue; // 0x4
	public QBoolean IsDialogue; // 0x8
	public FP PlayerStaminaBeforeHit; // 0x20
	public QBoolean StartedTimer; // 0xC

	// Methods

	// RVA: 0x20C8810 Offset: 0x20C6E10 VA: 0x1820C8810 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C8880 Offset: 0x20C6E80 VA: 0x1820C8880
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
