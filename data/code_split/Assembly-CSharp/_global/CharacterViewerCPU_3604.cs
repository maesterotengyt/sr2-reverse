// Namespace: 
public class CharacterViewerCPU : StellarMonoBehaviour // TypeDefIndex: 3604
{
	// Fields
	public CharacterViewer CharacterViewer; // 0x20
	public CharacterViewerCharacterData CharacterData; // 0x28
	public int ActionIndex; // 0x30
	private HashString selectedCPUHashstring; // 0x38
	private StellarCharacterData stellarCharacter; // 0x48
	private int lastLoopFrame; // 0x1C8
	private int loop; // 0x1CC
	private int actionDuration; // 0x1D0
	private CharacterViewerAnimationData actionData; // 0x1D8
	private CharacterViewerAnimationData initialStateData; // 0x280
	private bool activeCPU; // 0x328

	// Methods

	// RVA: 0x602690 Offset: 0x600C90 VA: 0x180602690
	public void SpawnCPU(HashString characterId) { }

	// RVA: 0x6020A0 Offset: 0x6006A0 VA: 0x1806020A0
	public void SetCPUData() { }

	// RVA: 0x601510 Offset: 0x5FFB10 VA: 0x180601510
	public void LoadCharacterData() { }

	// RVA: 0x6027F0 Offset: 0x600DF0 VA: 0x1806027F0
	public void StartState(CharacterViewerAnimationData animationData) { }

	// RVA: 0x601E10 Offset: 0x600410 VA: 0x180601E10
	public void SetActionState(CharacterViewerAnimationData animationData, int actionIndex) { }

	// RVA: 0x601BA0 Offset: 0x6001A0 VA: 0x180601BA0
	public void PlayInitialState() { }

	// RVA: 0x601C50 Offset: 0x600250 VA: 0x180601C50
	public void PlayStartCPUState(CharacterViewerAnimationData animationData, bool inmediateChange = True) { }

	// RVA: 0x601CF0 Offset: 0x6002F0 VA: 0x180601CF0
	public void PlayState(CharacterViewerAnimationData animationData, bool inmediateChange = True) { }

	// RVA: 0x6024E0 Offset: 0x600AE0 VA: 0x1806024E0
	public void SetPosition(CharacterViewerAnimationData animationData) { }

	// RVA: 0x6025E0 Offset: 0x600BE0 VA: 0x1806025E0
	public void SetStartDamage(float damage) { }

	// RVA: 0x601150 Offset: 0x5FF750 VA: 0x180601150
	public void InputAction(CharacterViewerAnimationData animationData, int frame) { }

	// RVA: 0x602B90 Offset: 0x601190 VA: 0x180602B90
	public void ToggleCPU(bool active) { }

	// RVA: 0x6010A0 Offset: 0x5FF6A0 VA: 0x1806010A0
	public void DespawnCPU() { }

	// RVA: 0x601D90 Offset: 0x600390 VA: 0x180601D90
	public void ResetGrab() { }

	// RVA: 0x601140 Offset: 0x5FF740 VA: 0x180601140
	public HashString GetInitialStateHashstring() { }

	// RVA: 0x602C70 Offset: 0x601270 VA: 0x180602C70
	public void .ctor() { }
}
