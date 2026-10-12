// Namespace: Quantum
[Serializable]
public class RaceTutorialGameMode : RaceGameMode // TypeDefIndex: 10401
{
	// Fields
	[Header("Tutorial Specific")]
	public string InitialMessage; // 0xA0
	public string SuddenDeathMessageID; // 0xA8
	public GameSpeedModifier DialogueSpeedModifier; // 0xB0

	// Methods

	// RVA: 0x21AA280 Offset: 0x21A8880 VA: 0x1821AA280
	public static bool TryFindManager(Frame frame, out RaceTutorialGameModeManager* tutorialManager) { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 27
	protected override bool StartMatchAutomatically() { }

	// RVA: 0x21A9970 Offset: 0x21A7F70 VA: 0x1821A9970 Slot: 28
	protected override void StartMatch(Frame frame) { }

	// RVA: 0x21AA0B0 Offset: 0x21A86B0 VA: 0x1821AA0B0 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21A9FB0 Offset: 0x21A85B0 VA: 0x1821A9FB0 Slot: 23
	public override void OnLapCompleted(Frame frame, EntityRef checkpointEntity, EntityRef characterEntity) { }

	// RVA: 0x21AA140 Offset: 0x21A8740 VA: 0x1821AA140 Slot: 24
	public override void OnSuddenDeathStart(Frame frame, bool fromTime = False) { }

	// RVA: 0x21A9C30 Offset: 0x21A8230 VA: 0x1821A9C30 Slot: 12
	public override bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x21A9D90 Offset: 0x21A8390 VA: 0x1821A9D90
	public void OnDialogueFinished(Frame frame) { }

	// RVA: 0x21A9E50 Offset: 0x21A8450 VA: 0x1821A9E50
	internal void OnInfoSetup(Frame frame, bool isInitialSection) { }

	// RVA: 0x21AA440 Offset: 0x21A8A40 VA: 0x1821AA440
	public void .ctor() { }
}
