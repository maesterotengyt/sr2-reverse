// Namespace: Quantum
public struct EnergyBar : IComponent // TypeDefIndex: 9985
{
	// Fields
	[HideInInspector]
	public FP CurrentEnergy; // 0x0
	[HideInInspector]
	public FP MaxEnergy; // 0x8

	// Methods

	// RVA: 0x20E1CE0 Offset: 0x20E02E0 VA: 0x1820E1CE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20A9200 Offset: 0x20A7800 VA: 0x1820A9200
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20E1C90 Offset: 0x20E0290 VA: 0x1820E1C90
	public void AddEnergy(Frame frame, EntityRef entity, FP EnergyAmountToChange) { }
}
