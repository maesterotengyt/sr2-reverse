// Namespace: Quantum
[Serializable]
public class MechanicTutorialGameMode : SpeedRunnersBaseGameMode // TypeDefIndex: 10394
{
	// Fields
	public static HashString FreezeAttackData; // 0x0
	public static HashString LethalObstacleAttackData; // 0x10
	public static HashString GoldenHookAttackData; // 0x20
	[Header("Tutorial Data")]
	public HashString LevelToLoad; // 0x68
	public MechanicTutorialSection[] Sections; // 0x78
	public GameSpeedModifier InitialMessageSpeedModifier; // 0x80
	public GameSpeedModifier EndSlowDownSpeedModifier; // 0xA0

	// Methods

	// RVA: 0x21A6120 Offset: 0x21A4720 VA: 0x1821A6120
	public static bool TryFindManager(Frame frame, out MechanicTutorialGameModeManager* tutorialManager) { }

	// RVA: 0x21A5A30 Offset: 0x21A4030 VA: 0x1821A5A30 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21A5D00 Offset: 0x21A4300 VA: 0x1821A5D00 Slot: 13
	public override void OnUpdate(Frame frame) { }

	// RVA: 0x21A5AC0 Offset: 0x21A40C0 VA: 0x1821A5AC0
	public void OnSectionInfoSetup(Frame frame, int currentSectionIndex) { }

	// RVA: 0x21A5980 Offset: 0x21A3F80 VA: 0x1821A5980
	public void OnDialogueFinished(Frame frame) { }

	// RVA: 0x21A5780 Offset: 0x21A3D80 VA: 0x1821A5780 Slot: 25
	public override void OnCharacterHurt(Frame frame, EntityRef characterEntity, int attackDataID) { }

	// RVA: 0x21A5470 Offset: 0x21A3A70 VA: 0x1821A5470
	public void ClearGoal(Frame frame, int goalID) { }

	// RVA: 0x21A6080 Offset: 0x21A4680 VA: 0x1821A6080
	protected void StartMatch(Frame frame) { }

	// RVA: 0x21A56B0 Offset: 0x21A3CB0 VA: 0x1821A56B0
	protected void CompleteSection(Frame frame, MechanicTutorialGameModeManager* tutorialManager) { }

	// RVA: 0x21A6020 Offset: 0x21A4620 VA: 0x1821A6020
	protected void RestartSection(Frame frame, MechanicTutorialGameModeManager* tutorialManager) { }

	// RVA: 0x21A6420 Offset: 0x21A4A20 VA: 0x1821A6420
	public void .ctor() { }

	// RVA: 0x21A62F0 Offset: 0x21A48F0 VA: 0x1821A62F0
	private static void .cctor() { }
}
