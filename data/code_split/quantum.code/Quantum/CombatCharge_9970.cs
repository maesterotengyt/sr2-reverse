// Namespace: Quantum
public struct CombatCharge : IComponent // TypeDefIndex: 9970
{
	// Fields
	[HideInInspector]
	public int ChargeAttackMultiplierID; // 0x0
	[HideInInspector]
	public FP ChargeAttackPower; // 0x10
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public QBoolean UseChargeMultiplier; // 0x4

	// Methods

	// RVA: 0x20D3D50 Offset: 0x20D2350 VA: 0x1820D3D50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D3E00 Offset: 0x20D2400 VA: 0x1820D3E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D3DB0 Offset: 0x20D23B0 VA: 0x1820D3DB0
	public FP GetValue(Frame frame, CombatChargeVariable variable) { }

	// RVA: 0x20D3E90 Offset: 0x20D2490 VA: 0x1820D3E90
	public void SetValue(Frame frame, CombatChargeVariable variable, FP value) { }
}
