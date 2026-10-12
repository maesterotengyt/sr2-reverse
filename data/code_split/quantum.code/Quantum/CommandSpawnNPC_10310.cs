// Namespace: Quantum
public class CommandSpawnNPC : BaseCommand // TypeDefIndex: 10310
{
	// Fields
	public int NPCID; // 0x28
	public FPVector2 SpawnPosition; // 0x30
	public int FacingDirection; // 0x40
	public bool StartDisabled; // 0x44
	public CharacterSpawnData CharacterSpawnData; // 0x48

	// Methods

	// RVA: 0x216A8E0 Offset: 0x2168EE0 VA: 0x18216A8E0 Slot: 8
	public override void Serialize(BitStream stream) { }

	// RVA: 0x216A630 Offset: 0x2168C30 VA: 0x18216A630 Slot: 11
	public override void Execute(Frame frame) { }

	// RVA: 0x216A9E0 Offset: 0x2168FE0 VA: 0x18216A9E0
	public void .ctor() { }
}
