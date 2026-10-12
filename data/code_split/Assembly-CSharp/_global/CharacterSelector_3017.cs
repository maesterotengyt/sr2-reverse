// Namespace: 
public class CharacterSelector : SRMonoBehaviour // TypeDefIndex: 3017
{
	// Fields
	public static CharacterSelector.OnSelectorActivated SelectorReserved; // 0x0
	public static CharacterSelector.OnSelectorDeactivated SelectorReserveCanceled; // 0x8
	public static CharacterSelector.OnSelectorUpdated SelectorUpdated; // 0x10
	public int SelectorNumber; // 0x20
	[Header("Elements")]
	public CharacterSelectPanel Panel; // 0x28
	public TMP_Text PlayerNameText; // 0x30
	public Image PlayerMarker; // 0x38
	public Image CPUMarker; // 0x40
	public GameObject PlayerNameBackground; // 0x48
	public GameObject PlayerNameBackgroundDisabled; // 0x50
	public CharacterSelectCharacterSpawner CharacterSpawner; // 0x58
	public CharacterSelectCostumeSelector CostumeSelector; // 0x60
	public CharacterSelectWorldBackground WorldBackground; // 0x68
	public List<GameObject> SkinIndicators; // 0x70
	public Transform Indicators; // 0x78
	public RectTransform PanelHighlightRef; // 0x80
	public TMP_Text SelectedCharacterName; // 0x88
	public bool EditingCPUDifficulty; // 0x90
	[Header("Selector Data (Only for visualization)")]
	public bool Enabled; // 0x91
	public bool Reserved; // 0x92
	public bool Ready; // 0x93
	public bool IsCPU; // 0x94
	public int CPUDifficulty; // 0x98
	public int PlayerIndex; // 0x9C
	public int InputDeviceIndex; // 0xA0
	public int PlayerProfileIndex; // 0xA4
	public HashString CharacterID; // 0xA8
	public int CharacterCostume; // 0xB8
	public bool RandomCharacter; // 0xBC
	public CharacterSelectorLocation Location; // 0xC0
	public string Nickname; // 0xC8
	private CharacterSelectBase characterSelect; // 0xD0
	private bool characterSetByRandom; // 0xD8

	// Methods

	// RVA: 0x794770 Offset: 0x792D70 VA: 0x180794770
	public void Clean() { }

	// RVA: 0x794FB0 Offset: 0x7935B0 VA: 0x180794FB0
	public void Init(CharacterSelectBase characterSelect) { }

	// RVA: 0x6230D0 Offset: 0x6216D0 VA: 0x1806230D0
	public void InitDeleteSelector(CharacterSelectBase characterSelect) { }

	// RVA: 0x795BC0 Offset: 0x7941C0 VA: 0x180795BC0
	public void SetEnabled(bool enabled) { }

	// RVA: 0x795810 Offset: 0x793E10 VA: 0x180795810
	public void SetCharacterID(HashString characterID) { }

	// RVA: 0x7956B0 Offset: 0x793CB0 VA: 0x1807956B0
	public void SetCharacterCostume(int costume, bool showVFX = True) { }

	// RVA: 0x795E60 Offset: 0x794460 VA: 0x180795E60
	public void SetRandomCharacter(bool random) { }

	// RVA: 0x795CD0 Offset: 0x7942D0 VA: 0x180795CD0
	public void SetLocation(CharacterSelectorLocation location) { }

	// RVA: 0x796310 Offset: 0x794910 VA: 0x180796310
	public void SetReady(bool ready) { }

	// RVA: 0x795380 Offset: 0x793980 VA: 0x180795380
	public void ReserveSelector(CharacterSelector selector, ReserveSelectorContext context = 0) { }

	// RVA: 0x795D90 Offset: 0x794390 VA: 0x180795D90
	public void SetMarkerColor() { }

	// RVA: 0x7952D0 Offset: 0x7938D0 VA: 0x1807952D0
	public void ReserveSelector(ReserveSelectorContext context = 0) { }

	// RVA: 0x7946E0 Offset: 0x792CE0 VA: 0x1807946E0
	public void CancelReserve() { }

	// RVA: 0x7948E0 Offset: 0x792EE0 VA: 0x1807948E0
	public void EnableCPU() { }

	// RVA: 0x7953E0 Offset: 0x7939E0 VA: 0x1807953E0
	public void SetCPUDifficulty(int difficulty) { }

	// RVA: 0x795C70 Offset: 0x794270 VA: 0x180795C70
	public void SetJoinMode() { }

	// RVA: 0x7950F0 Offset: 0x7936F0 VA: 0x1807950F0
	public void RemoveSelector() { }

	// RVA: 0x7950B0 Offset: 0x7936B0 VA: 0x1807950B0
	public void MovePlayerHighlight(RectTransform target) { }

	// RVA: 0x7959B0 Offset: 0x793FB0 VA: 0x1807959B0
	public void SetCurrentPlayerName() { }

	// RVA: 0x7963F0 Offset: 0x7949F0 VA: 0x1807963F0
	private void TogglePlayerNameBackground(bool enabled) { }

	// RVA: 0x794E10 Offset: 0x793410 VA: 0x180794E10
	public CharacterDetails GetCharacterDetails() { }

	// RVA: 0x794BD0 Offset: 0x7931D0 VA: 0x180794BD0
	public List<CharacterCostumeData> GetCharacterCostumes() { }

	// RVA: 0x794E50 Offset: 0x793450 VA: 0x180794E50
	private int GetPlayerNumber() { }

	// RVA: 0x794850 Offset: 0x792E50 VA: 0x180794850
	public void Disable() { }

	// RVA: 0x7964C0 Offset: 0x794AC0 VA: 0x1807964C0
	public void .ctor() { }
}
