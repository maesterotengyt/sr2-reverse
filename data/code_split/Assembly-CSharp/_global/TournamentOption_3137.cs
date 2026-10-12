// Namespace: 
public class TournamentOption : UINavigationElement // TypeDefIndex: 3137
{
	// Fields
	public TMP_Text PasscodeText; // 0x98
	public TMP_Text PhaseText; // 0xA0
	public TMP_Text RegionText; // 0xA8
	public TMP_Text SpectatorsText; // 0xB0
	private TournamentsListWorld tournamentsList; // 0xB8
	private string tournamentID; // 0xC0

	// Properties
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x57CD00 Offset: 0x57B300 VA: 0x18057CD00
	private OnlineManager get_onlineManager() { }

	// RVA: 0x545940 Offset: 0x543F40 VA: 0x180545940
	public void Init(TournamentsListWorld tournamentsList) { }

	// RVA: 0x57CB60 Offset: 0x57B160 VA: 0x18057CB60
	public void SetData(TournamentData data) { }

	// RVA: 0x57CB30 Offset: 0x57B130 VA: 0x18057CB30
	public void SelectOption() { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
