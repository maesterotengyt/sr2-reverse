// Namespace: 
public class MenuPlayersHighlight : MonoBehaviour // TypeDefIndex: 3044
{
	// Fields
	public List<MenuPlayerHighlight> Highlights; // 0x20
	private List<MenuPlayersHighlight.PlayerHighlightData> highlightData; // 0x28

	// Methods

	// RVA: 0x54CD80 Offset: 0x54B380 VA: 0x18054CD80
	public MenuPlayerHighlight GetPlayerHighlight(int playerIndex) { }

	// RVA: 0x54D120 Offset: 0x54B720 VA: 0x18054D120
	public bool MovePlayerHighlight(int playerIndex, RectTransform target) { }

	// RVA: 0x54CFF0 Offset: 0x54B5F0 VA: 0x18054CFF0
	public bool MovePlayerHighlightMarkerPosition(int playerIndex, int markerPosition) { }

	// RVA: 0x54D370 Offset: 0x54B970 VA: 0x18054D370
	public void ToggleAllUsedHighlights(bool show) { }

	// RVA: 0x54CC20 Offset: 0x54B220 VA: 0x18054CC20
	public void CleanHighlights() { }

	// RVA: 0x54C9E0 Offset: 0x54AFE0 VA: 0x18054C9E0
	public void AddPlayerHighlight(int playerIndex) { }

	// RVA: 0x54D1D0 Offset: 0x54B7D0 VA: 0x18054D1D0
	public void RemovePlayerHighlight(int playerIndex) { }

	// RVA: 0x54CEC0 Offset: 0x54B4C0 VA: 0x18054CEC0
	private MenuPlayerHighlight GetUnusedPlayerHighlight() { }

	// RVA: 0x54D4A0 Offset: 0x54BAA0 VA: 0x18054D4A0
	public void .ctor() { }
}
