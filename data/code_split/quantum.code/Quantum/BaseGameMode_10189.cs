// Namespace: Quantum
[Serializable]
public abstract class BaseGameMode : AssetObject // TypeDefIndex: 10189
{
	// Methods

	// RVA: 0x2138770 Offset: 0x2136D70 VA: 0x182138770 Slot: 6
	public virtual void OnLoadingFinished(Frame frame) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void OnMatchEnd(Frame frame) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public virtual void OnCharacterSpawn(Frame frame, EntityRef entity, CharacterSpawnData characterSpawnData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public virtual void OnCharacterDamageUpdate(Frame frame, EntityRef entity, FP newDamageValue) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void OnCharacterStaminaUpdate(Frame frame, EntityRef entity, FP newStaminaValue) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 11
	public virtual void OnCharacterKnockOut(Frame frame, EntityRef entity) { }

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 12
	public virtual bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 13
	public virtual void OnUpdate(Frame frame) { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 14
	public virtual bool IsCharacterAlive(Frame frame, EntityRef characterEntity) { }

	// RVA: 0x2138310 Offset: 0x2136910 VA: 0x182138310 Slot: 15
	public virtual int GetPlayersAliveAmount(Frame frame) { }

	// RVA: 0x2138460 Offset: 0x2136A60 VA: 0x182138460 Slot: 16
	public virtual int GetTeamsAliveAmount(Frame frame) { }

	// RVA: 0x21385F0 Offset: 0x2136BF0 VA: 0x1821385F0 Slot: 17
	public virtual bool HasMatchEnded(Frame frame) { }

	// RVA: 0x2138920 Offset: 0x2136F20 VA: 0x182138920 Slot: 18
	public virtual bool TryGetSpawnPoint(Frame frame, HashString spawnPointID, bool adjustedToFloor, out FPVector2 spawnPosition, out int facingDirection, int spawnOrder = -1, bool random = False) { }

	// RVA: 0x2137F50 Offset: 0x2136550 VA: 0x182137F50 Slot: 19
	public virtual void EnableCharacters(Frame frame, bool inputEnabled) { }

	// RVA: 0x2137B50 Offset: 0x2136150 VA: 0x182137B50 Slot: 20
	public virtual void CheckAllCharactersAreEnabled(Frame frame) { }

	// RVA: 0x2137EC0 Offset: 0x21364C0 VA: 0x182137EC0 Slot: 21
	public virtual void EnableCharacter(Frame frame, EntityRef characterEntity, bool inputEnabled) { }

	// RVA: 0x2138190 Offset: 0x2136790 VA: 0x182138190 Slot: 22
	public virtual void EnablePlayersInput(Frame frame) { }

	// RVA: 0x2137E00 Offset: 0x2136400 VA: 0x182137E00
	public void DisablePlayersInput(Frame frame) { }

	// RVA: 0x21382D0 Offset: 0x21368D0 VA: 0x1821382D0
	public void FocusCamera(Frame frame) { }

	// RVA: 0x21380D0 Offset: 0x21366D0 VA: 0x1821380D0
	public void EnableNPCs(Frame frame) { }

	// RVA: 0x2137D40 Offset: 0x2136340 VA: 0x182137D40
	public void DisableNPCs(Frame frame) { }

	// RVA: 0x21387D0 Offset: 0x2136DD0 VA: 0x1821387D0
	public static bool TryFindBaseGameModeManager(Frame frame, out BaseGameModeManager* baseGameModeManager) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	protected void .ctor() { }
}
