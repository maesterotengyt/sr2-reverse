// Namespace: Quantum
public class CommandSpawnPlayerCharacter : BaseCommand // TypeDefIndex: 10446
{
	// Fields
	public PlayerRef PlayerRef; // 0x28
	public FPVector2 SpawnPosition; // 0x30
	public int FacingDirection; // 0x40
	public bool StartDisabled; // 0x44
	public int PartnerCharacterIndex; // 0x48
	public CharacterSpawnData CharacterSpawnData; // 0x50

	// Methods

	// RVA: 0x21B3790 Offset: 0x21B1D90 VA: 0x1821B3790 Slot: 8
	public override void Serialize(BitStream stream) { }

	// RVA: 0x21B35F0 Offset: 0x21B1BF0 VA: 0x1821B35F0 Slot: 11
	public override void Execute(Frame frame) { }

	// RVA: 0x21B38A0 Offset: 0x21B1EA0 VA: 0x1821B38A0
	public void .ctor() { }
}
