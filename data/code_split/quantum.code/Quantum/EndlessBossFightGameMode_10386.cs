// Namespace: Quantum
[Serializable]
public class EndlessBossFightGameMode : BossFightGameMode // TypeDefIndex: 10386
{
	// Fields
	public List<AssetRefRoomConfig> RoomConfigs; // 0xF8
	public int MaxPlataforms; // 0x100
	public FP PlataformDistance; // 0x108
	public FP SpawnThreshold; // 0x110
	public FP TopBlastzoneBouncePower; // 0x118
	public FP RightBlastzoneBouncePower; // 0x120
	private FPVector2 FirstSpawnPosition; // 0x128

	// Methods

	// RVA: 0x219EF90 Offset: 0x219D590 VA: 0x18219EF90 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x219E0C0 Offset: 0x219C6C0 VA: 0x18219E0C0 Slot: 27
	public override void OnBossFightInfoSetup(Frame frame, bool hasDialogue, int difficulty) { }

	// RVA: 0x219E620 Offset: 0x219CC20 VA: 0x18219E620 Slot: 37
	public override void OnCampaignDialogueFinished(Frame frame) { }

	// RVA: 0x219FB60 Offset: 0x219E160 VA: 0x18219FB60 Slot: 28
	public override void StartMatch(Frame frame) { }

	// RVA: 0x219F1C0 Offset: 0x219D7C0 VA: 0x18219F1C0 Slot: 33
	public override void OnPlayingUpdate(Frame frame, BossFightGameModeManager* raceGameModeManager) { }

	// RVA: 0x219F4D0 Offset: 0x219DAD0 VA: 0x18219F4D0
	private void SpawnNextPlatform(Frame frame, EndlessGameModeManager* endlessManager) { }

	// RVA: 0x219FE60 Offset: 0x219E460 VA: 0x18219FE60
	public static bool TryFindManager(Frame frame, out EndlessGameModeManager* endlessManager) { }

	// RVA: 0x219E820 Offset: 0x219CE20 VA: 0x18219E820 Slot: 12
	public override bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x219DF10 Offset: 0x219C510 VA: 0x18219DF10
	private void DestroyRoom(Frame frame, EntityRef anchorToDestroy) { }

	// RVA: 0x2199A20 Offset: 0x2198020 VA: 0x182199A20
	public void OnCampaignForceWin(Frame frame) { }

	// RVA: 0x219FFB0 Offset: 0x219E5B0 VA: 0x18219FFB0
	public void .ctor() { }
}
