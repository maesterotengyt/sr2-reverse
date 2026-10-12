// Namespace: 
public class StellarTileMapEditorData // TypeDefIndex: 3664
{
	// Fields
	public Vector3 LastPaintedCell; // 0x10
	public Vector3 LastErasedCell; // 0x1C
	public Vector3 WorldCursorPosition; // 0x28
	public StellarTileData TileToDraw; // 0x38
	public Vector3 LastCellClicked; // 0x58
	public List<StellarTileMapCellData> SelectedTiles; // 0x68
	public bool LeftClickHold; // 0x70
	public bool RightClickHold; // 0x71
	public bool ShiftHold; // 0x72
	public bool DeleteHold; // 0x73
	public Vector3 BoxSelectionTopLeft; // 0x74
	public Vector3 BoxSelectionBottomRight; // 0x80

	// Methods

	// RVA: 0x61D310 Offset: 0x61B910 VA: 0x18061D310
	public bool IsSelectionBoxValid() { }

	// RVA: 0x61D2D0 Offset: 0x61B8D0 VA: 0x18061D2D0
	public bool IsCellInSelectionBox(Vector3 coordinates) { }

	// RVA: 0x61D360 Offset: 0x61B960 VA: 0x18061D360
	public void .ctor() { }
}
