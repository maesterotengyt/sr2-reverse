// Namespace: Quantum
public class SpawnUtils // TypeDefIndex: 10694
{
	// Methods

	// RVA: 0x210E5A0 Offset: 0x210CBA0 VA: 0x18210E5A0
	public static EntityRef SpawnCharacter(Frame frame, CharacterSpawnData characterSpawnData, PlayerRef playerRef, FPVector2 spawnPosition, int facingDirection, bool startDisabled, int partnerCharacterIndex = 0, int npcIndex = 0) { }

	// RVA: 0x210EAE0 Offset: 0x210D0E0 VA: 0x18210EAE0
	public static EntityRef SpawnEntity(Frame frame, GameEntityData gameEntityData, GameEntity* spawnerEntity, FPVector2 position, bool positionRelativeToSpawner, int costumeIndex) { }

	// RVA: 0x210EB20 Offset: 0x210D120 VA: 0x18210EB20
	public static EntityRef SpawnEntity(Frame frame, GameEntityData gameEntityData, GameEntity* spawnerEntity, FPVector2 position, bool positionRelativeToSpawner, int costumeIndex, EntityVariable spawnedEntityIndexOutput) { }

	// RVA: 0x210ED70 Offset: 0x210D370 VA: 0x18210ED70
	public static EntityRef SpawnEntity(Frame frame, GameEntityData gameEntityData, FPVector2 position, int costumeIndex) { }

	// RVA: 0x210EE40 Offset: 0x210D440 VA: 0x18210EE40
	public static EntityRef SpawnNPC(Frame frame, CharacterSpawnData characterSpawnData, FPVector2 spawnPosition, int facingDirection, bool startDisabled, int npcID) { }

	// RVA: 0x210EFA0 Offset: 0x210D5A0 VA: 0x18210EFA0
	public static bool TryGetSpawnPoint(Frame frame, HashString spawnPointID, bool adjustedToFloor, out FPVector2 spawnPosition, out int facingDirection) { }

	// RVA: 0x210F080 Offset: 0x210D680 VA: 0x18210F080
	public static bool TryGetSpawnPoint(Frame frame, HashString spawnPointID, int spawnOrder, bool adjustedToFloor, out FPVector2 spawnPosition, out int facingDirection) { }
}
