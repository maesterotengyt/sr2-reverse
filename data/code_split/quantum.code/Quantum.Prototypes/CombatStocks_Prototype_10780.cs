// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatStocks))]
[Serializable]
public sealed class CombatStocks_Prototype : ComponentPrototype<CombatStocks> // TypeDefIndex: 10780
{
	// Fields
	public int Stocks; // 0x18

	// Methods

	// RVA: 0x20FFFA0 Offset: 0x20FE5A0 VA: 0x1820FFFA0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC8E0 Offset: 0x20FAEE0 VA: 0x1820FC8E0
	public void Materialize(Frame frame, ref CombatStocks result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2100050 Offset: 0x20FE650 VA: 0x182100050 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21000E0 Offset: 0x20FE6E0 VA: 0x1821000E0
	public void .ctor() { }
}
