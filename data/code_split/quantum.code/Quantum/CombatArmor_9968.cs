// Namespace: Quantum
public struct CombatArmor : IComponent // TypeDefIndex: 9968
{
	// Fields
	[HideInInspector]
	public FP Armor; // 0x10
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public QBoolean SuperArmor; // 0x0

	// Methods

	// RVA: 0x20D39A0 Offset: 0x20D1FA0 VA: 0x1820D39A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D3A20 Offset: 0x20D2020 VA: 0x1820D3A20
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D39E0 Offset: 0x20D1FE0 VA: 0x1820D39E0
	public FP GetValue(Frame frame, CombatArmorVariable variable) { }

	// RVA: 0x20D3A70 Offset: 0x20D2070 VA: 0x1820D3A70
	public void SetValue(Frame frame, CombatArmorVariable variable, FP value) { }
}
