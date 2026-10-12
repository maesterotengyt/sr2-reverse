// Namespace: 
public class BettingCharacterContainer : UINavigationElement // TypeDefIndex: 2861
{
	// Fields
	public Image CharacterRender; // 0x98
	public Image Background; // 0xA0
	public UINavigationElement UpNavigator; // 0xA8
	public UINavigationElement DownNavigator; // 0xB0
	public TMP_Text BettedAmount; // 0xB8
	[CompilerGenerated]
	private int <amount>k__BackingField; // 0xC0
	[CompilerGenerated]
	private string <playerNickName>k__BackingField; // 0xC8
	private BettingHUD bettingHUD; // 0xD0

	// Properties
	public int amount { get; set; }
	public string playerNickName { get; set; }
	private OnlineManager onlineManager { get; }
	private FileLoadingManager fileLoadingManager { get; }
	private UIManager uiManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73FD60 Offset: 0x73E360 VA: 0x18073FD60
	public int get_amount() { }

	[CompilerGenerated]
	// RVA: 0x73FE70 Offset: 0x73E470 VA: 0x18073FE70
	public void set_amount(int value) { }

	[CompilerGenerated]
	// RVA: 0x73FE10 Offset: 0x73E410 VA: 0x18073FE10
	public string get_playerNickName() { }

	[CompilerGenerated]
	// RVA: 0x73FE80 Offset: 0x73E480 VA: 0x18073FE80
	public void set_playerNickName(string value) { }

	// RVA: 0x73FDC0 Offset: 0x73E3C0 VA: 0x18073FDC0
	private OnlineManager get_onlineManager() { }

	// RVA: 0x73FD70 Offset: 0x73E370 VA: 0x18073FD70
	private FileLoadingManager get_fileLoadingManager() { }

	// RVA: 0x73FE20 Offset: 0x73E420 VA: 0x18073FE20
	private UIManager get_uiManager() { }

	// RVA: 0x73F520 Offset: 0x73DB20 VA: 0x18073F520
	public void Initialize(int character, string nickName, BettingHUD bettingHUD) { }

	// RVA: 0x73F7C0 Offset: 0x73DDC0 VA: 0x18073F7C0
	public void SetColor(StellarCharacterData characterData) { }

	// RVA: 0x73F970 Offset: 0x73DF70 VA: 0x18073F970
	public void SetData() { }

	// RVA: 0x73FAB0 Offset: 0x73E0B0 VA: 0x18073FAB0
	public void Update() { }

	// RVA: 0x73F2A0 Offset: 0x73D8A0 VA: 0x18073F2A0
	public void IncrementBet() { }

	// RVA: 0x73F6F0 Offset: 0x73DCF0 VA: 0x18073F6F0
	public void Reset() { }

	// RVA: 0x73F0A0 Offset: 0x73D6A0 VA: 0x18073F0A0
	public void DecreaseBet() { }

	// RVA: 0x73EF10 Offset: 0x73D510 VA: 0x18073EF10
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x73FAA0 Offset: 0x73E0A0 VA: 0x18073FAA0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x5596E0 Offset: 0x557CE0 VA: 0x1805596E0 Slot: 4
	public override void ElementSelected(int playerIndex) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
