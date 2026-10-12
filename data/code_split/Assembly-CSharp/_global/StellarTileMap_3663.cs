// Namespace: 
public class StellarTileMap : MonoBehaviour // TypeDefIndex: 3663
{
	// Fields
	public StellarTileSetData TileSet; // 0x20
	public float GridSize; // 0x28
	private Dictionary<Vector2, StellarTileMapCellData> Tiles; // 0x30

	// Methods

	// RVA: 0x61E0C0 Offset: 0x61C6C0 VA: 0x18061E0C0
	public static Vector3 SnapToGrid(Vector3 position, float gridTileSize) { }

	// RVA: 0x61DB90 Offset: 0x61C190 VA: 0x18061DB90
	public void ReloadTilesData() { }

	// RVA: 0x61D4F0 Offset: 0x61BAF0 VA: 0x18061D4F0
	public List<StellarTileMapCellData> GetUsedTiles() { }

	// RVA: 0x61E190 Offset: 0x61C790 VA: 0x18061E190
	public Vector3 ToLocalCoordinates(Vector3 coordinates) { }

	// RVA: 0x61E120 Offset: 0x61C720 VA: 0x18061E120
	public Vector3 ToGlobalCoordinates(Vector3 coordinates) { }

	// RVA: 0x61D760 Offset: 0x61BD60 VA: 0x18061D760
	public void Paint(Vector2 coordinates, StellarTileData tileData) { }

	// RVA: 0x61D3E0 Offset: 0x61B9E0 VA: 0x18061D3E0
	public void Erase(Vector2 coordinates) { }

	// RVA: 0x61E200 Offset: 0x61C800 VA: 0x18061E200
	public void .ctor() { }
}
