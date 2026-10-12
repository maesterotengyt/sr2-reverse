// Namespace: Quantum
public struct CombatStamina : IComponent // TypeDefIndex: 9974
{
	// Fields
	public FP ExtraDamageForKnockback; // 0x0
	public FP ExtraDamageForKnockbackFrames; // 0x8
	public FP Stamina; // 0x10

	// Methods

	// RVA: 0x20D43E0 Offset: 0x20D29E0 VA: 0x1820D43E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20AA1B0 Offset: 0x20A87B0 VA: 0x1820AA1B0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D4500 Offset: 0x20D2B00 VA: 0x1820D4500
	public void UpdateStamina(Frame frame, EntityRef entity, FP newStaminaValue, bool notifyGameMode = True) { }

	// RVA: 0x20D4430 Offset: 0x20D2A30 VA: 0x1820D4430
	public FP GetValue(Frame frame, CombatStaminaVariable variable) { }

	// RVA: 0x20D4440 Offset: 0x20D2A40 VA: 0x1820D4440
	public void SetValue(Frame frame, EntityRef entity, CombatStaminaVariable variable, FP value) { }
}
