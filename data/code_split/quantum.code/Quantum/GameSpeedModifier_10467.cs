// Namespace: Quantum
[Serializable]
public struct GameSpeedModifier // TypeDefIndex: 10467
{
	// Fields
	public HashString ID; // 0x0
	public FP Multiplier; // 0x10
	public bool AlterSimulation; // 0x18
	public bool AlterEngine; // 0x19

	// Methods

	// RVA: 0x21B7360 Offset: 0x21B5960 VA: 0x1821B7360
	public void .ctor(HashString id, FP multiplier, bool alterSimulation, bool alterEngine) { }

	// RVA: 0x21B72F0 Offset: 0x21B58F0 VA: 0x1821B72F0
	public RuntimeGameSpeedModifier AsRuntimeModifier() { }
}
