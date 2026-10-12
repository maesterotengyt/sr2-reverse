// Namespace: 
public class LobbyOption : UINavigationElement // TypeDefIndex: 3123
{
	// Fields
	public TMP_Text LobbyNameText; // 0x98
	public TMP_Text PlayersAmountText; // 0xA0
	public GameObject CPUsContainer; // 0xA8
	public Image CPUsDifficultyBackground; // 0xB0
	public TextProxy CPUsDifficultyText; // 0xB8
	public CPUDifficultyVisualData EasyVisualData; // 0xC0
	public CPUDifficultyVisualData MediumVisualData; // 0xD8
	public CPUDifficultyVisualData HardVisualData; // 0xF0
	public CPUDifficultyVisualData UnfairVisualData; // 0x108
	public CPUDifficultyVisualData RandomVisualData; // 0x120
	private LobbyListWorld lobbyList; // 0x138
	private string lobbyNameString; // 0x140
	private string photonRoomID; // 0x148

	// Properties
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x572D20 Offset: 0x571320 VA: 0x180572D20
	private OnlineManager get_onlineManager() { }

	// RVA: 0x5726A0 Offset: 0x570CA0 VA: 0x1805726A0
	public void Init(LobbyListWorld lobbyList, string lobbyNameString) { }

	// RVA: 0x572720 Offset: 0x570D20 VA: 0x180572720
	public void SetData(RoomInfo roomInfo) { }

	// RVA: 0x5726F0 Offset: 0x570CF0 VA: 0x1805726F0
	public void SelectOption() { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
