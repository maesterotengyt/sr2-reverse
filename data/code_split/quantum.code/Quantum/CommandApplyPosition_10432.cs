// Namespace: Quantum
public class CommandApplyPosition : BaseCommand // TypeDefIndex: 10432
{
	// Fields
	public EntityRef EntityRef; // 0x28
	public FPVector2 Position; // 0x30
	public FPVector2 Velocity; // 0x40
	public int Direction; // 0x50
	public bool DeactivatePhysics; // 0x54

	// Methods

	// RVA: 0x21B2A30 Offset: 0x21B1030 VA: 0x1821B2A30 Slot: 8
	public override void Serialize(BitStream stream) { }

	// RVA: 0x21B2860 Offset: 0x21B0E60 VA: 0x1821B2860 Slot: 11
	public override void Execute(Frame frame) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
