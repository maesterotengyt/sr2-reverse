// Namespace: Quantum
public class ChecksumErrorFrameDumpContext // TypeDefIndex: 10251
{
	// Fields
	public SimulationConfig SimulationConfig; // 0x10
	public QTuple<AssetGuid, ulong>[] AssetDBChecksums; // 0x18

	// Methods

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	private void .ctor() { }

	// RVA: 0x2150390 Offset: 0x214E990 VA: 0x182150390
	public void .ctor(QuantumGame game, Frame frame) { }

	// RVA: 0x21501B0 Offset: 0x214E7B0 VA: 0x1821501B0
	public void Serialize(QuantumGame game, BinaryWriter writer) { }

	// RVA: 0x214FF40 Offset: 0x214E540 VA: 0x18214FF40
	public static ChecksumErrorFrameDumpContext Deserialize(QuantumGame game, BinaryReader reader) { }
}
