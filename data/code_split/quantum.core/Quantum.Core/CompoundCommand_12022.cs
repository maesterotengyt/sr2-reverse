// Namespace: Quantum.Core
public class CompoundCommand : DeterministicCommand // TypeDefIndex: 12022
{
	// Fields
	public List<DeterministicCommand> Commands; // 0x28

	// Methods

	// RVA: 0x2207990 Offset: 0x2205F90 VA: 0x182207990 Slot: 7
	public override void Serialize(BitStream stream, DeterministicCommandSerializer cmdSerializer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public override void Serialize(BitStream stream) { }

	// RVA: 0x2207850 Offset: 0x2205E50 VA: 0x182207850 Slot: 10
	public override void Dispose() { }

	// RVA: 0x2207AE0 Offset: 0x22060E0 VA: 0x182207AE0
	public void .ctor() { }
}
