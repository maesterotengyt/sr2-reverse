// Namespace: 
public class CharacterViewerPositionMap : MonoBehaviour // TypeDefIndex: 3632
{
	// Fields
	public RectTransform Content; // 0x20
	public CharacterViewer CharacterViewer; // 0x28
	[Header("Minimap Coordinates")]
	public RectTransform MapZero; // 0x30
	[SerializeField]
	private CharacterViewerPositionMap.RectCoordinates stage; // 0x38
	[SerializeField]
	private CharacterViewerPositionMap.RectCoordinates view; // 0x48
	[SerializeField]
	private List<CharacterViewerPositionMap.RectCoordinates> stageRestrictedAreas; // 0x58

	// Methods

	// RVA: 0x612B90 Offset: 0x611190 VA: 0x180612B90
	public void SetValidPosition(RectTransform target, Vector2 position) { }

	// RVA: 0x612700 Offset: 0x610D00 VA: 0x180612700
	private Vector2 BorderGeometry(CharacterViewerPositionMap.RectCoordinates enviroment, RectTransform target, Vector2 position) { }

	// RVA: 0x612940 Offset: 0x610F40 VA: 0x180612940
	public Vector2 GetProportionalPosition(Vector2 input, bool inWorldPosition = False) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
