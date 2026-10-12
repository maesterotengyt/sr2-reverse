// Namespace: Quantum
public struct CombatStocks : IComponent // TypeDefIndex: 9975
{
	// Fields
	public int Stocks; // 0x0

	// Methods

	// RVA: 0x20D45A0 Offset: 0x20D2BA0 VA: 0x1820D45A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D45D0 Offset: 0x20D2BD0 VA: 0x1820D45D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D4680 Offset: 0x20D2C80 VA: 0x1820D4680
	public void UpdateStocks(Frame frame, EntityRef entity, int newStocksValue) { }

	// RVA: 0x20D45C0 Offset: 0x20D2BC0 VA: 0x1820D45C0
	public FP GetValue(Frame frame, CombatStocksVariable variable) { }

	// RVA: 0x20D4640 Offset: 0x20D2C40 VA: 0x1820D4640
	public void SetValue(Frame frame, EntityRef entity, CombatStocksVariable variable, FP value) { }
}
