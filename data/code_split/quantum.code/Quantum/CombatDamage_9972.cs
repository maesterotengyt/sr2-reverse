// Namespace: Quantum
public struct CombatDamage : IComponent // TypeDefIndex: 9972
{
	// Fields
	public FP Damage; // 0x0

	// Methods

	// RVA: 0x20D41A0 Offset: 0x20D27A0 VA: 0x1820D41A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D41D0 Offset: 0x20D27D0 VA: 0x1820D41D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D42B0 Offset: 0x20D28B0 VA: 0x1820D42B0
	public void UpdateDamage(Frame frame, EntityRef entity, FP newDamageValue, bool notifyGameMode = True) { }

	// RVA: 0x20D41C0 Offset: 0x20D27C0 VA: 0x1820D41C0
	public FP GetValue(Frame frame, CombatDamageVariable variable) { }

	// RVA: 0x20D41F0 Offset: 0x20D27F0 VA: 0x1820D41F0
	public void SetValue(Frame frame, EntityRef entity, CombatDamageVariable variable, FP value) { }
}
