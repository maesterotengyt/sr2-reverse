// Namespace: Quantum
[Serializable]
public class SpeedRunnersBaseGameMode : BaseGameMode // TypeDefIndex: 10402
{
	// Fields
	public bool BlastzoneActive; // 0x20
	public bool CheckpointsActive; // 0x21
	public bool UseInitialTimer; // 0x22
	public int InitialTimerFrames; // 0x24
	public FP TotalRespawnLength; // 0x28
	public FP MinRespawnSpacing; // 0x30
	[Header("States")]
	public HashString EntranceState; // 0x38
	public HashString IdleState; // 0x48
	public HashString RespawnState; // 0x58

	// Methods

	// RVA: 0x21ABD60 Offset: 0x21AA360 VA: 0x1821ABD60
	public static bool TryFindInitialWaitTimer(Frame frame, out InitialWaitTimer* initialWaitTimer) { }

	// RVA: 0x21ABD10 Offset: 0x21AA310 VA: 0x1821ABD10
	public void StartInitialTimer(Frame frame) { }

	// RVA: 0x21AA7E0 Offset: 0x21A8DE0 VA: 0x1821AA7E0
	public bool IsInitialCountdownFinished(Frame frame) { }

	// RVA: 0x21AC410 Offset: 0x21AAA10 VA: 0x1821AC410
	public void UpdateInitialCountdown(Frame frame, out bool justFinished) { }

	// RVA: 0x21AB270 Offset: 0x21A9870 VA: 0x1821AB270 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21AA5B0 Offset: 0x21A8BB0 VA: 0x1821AA5B0
	public void CreateBlastzone(Frame frame) { }

	// RVA: 0x21AA790 Offset: 0x21A8D90 VA: 0x1821AA790 Slot: 14
	public override bool IsCharacterAlive(Frame frame, EntityRef characterEntity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 23
	public virtual void OnLapCompleted(Frame frame, EntityRef checkpointEntity, EntityRef characterEntity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 24
	public virtual void OnSuddenDeathStart(Frame frame, bool fromTime = False) { }

	// RVA: 0x21AB250 Offset: 0x21A9850 VA: 0x1821AB250
	public void OnCharacterHurt(Frame frame, EntityRef characterEntity, HashString attackDataID) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 25
	public virtual void OnCharacterHurt(Frame frame, EntityRef characterEntity, int attackDataID) { }

	// RVA: 0x21AA840 Offset: 0x21A8E40 VA: 0x1821AA840 Slot: 26
	public virtual void MovePlayersToRespawnPoints(Frame frame, bool initialSpawn) { }

	// RVA: 0x21ABEB0 Offset: 0x21AA4B0 VA: 0x1821ABEB0 Slot: 18
	public override bool TryGetSpawnPoint(Frame frame, HashString spawnPointID, bool adjustedToFloor, out FPVector2 spawnPosition, out int facingDirection, int spawnOrder = -1, bool random = False) { }

	// RVA: 0x21ABC40 Offset: 0x21AA240 VA: 0x1821ABC40
	protected void StartCharactersEntrance(Frame frame) { }

	// RVA: 0x21AA6C0 Offset: 0x21A8CC0 VA: 0x1821AA6C0
	protected void EndCharactersEntrance(Frame frame) { }

	// RVA: 0x21AC3C0 Offset: 0x21AA9C0 VA: 0x1821AC3C0
	public void UpdateBlastzone(Frame frame) { }

	// RVA: 0x21AA520 Offset: 0x21A8B20 VA: 0x1821AA520
	protected FP CalculateRespawnSpacing(Frame frame) { }

	// RVA: 0x21AC4B0 Offset: 0x21AAAB0 VA: 0x1821AC4B0
	public void .ctor() { }
}
