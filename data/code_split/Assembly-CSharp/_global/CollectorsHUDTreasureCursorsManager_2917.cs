// Namespace: 
public class CollectorsHUDTreasureCursorsManager : SRMonoBehaviour // TypeDefIndex: 2917
{
	// Fields
	public CollectorsHUDTreasureCursor[] Cursors; // 0x20
	public RectTransform CanvasRect; // 0x28
	public RectTransform ClampRect; // 0x30
	[Header("Distance Scaling")]
	public float MinScale; // 0x38
	public float MaxScale; // 0x3C
	public float MinDistance; // 0x40
	public float MaxDistance; // 0x44
	private Camera currentCamera; // 0x48
	private Dictionary<EntityRef, CollectorsHUDTreasureCursor> usedCursorsDict; // 0x50

	// Methods

	// RVA: 0x758DD0 Offset: 0x7573D0 VA: 0x180758DD0
	private void Update() { }

	// RVA: 0x758C40 Offset: 0x757240 VA: 0x180758C40
	private Vector2 ClampToRect(Vector2 position, RectTransform rect) { }

	// RVA: 0x758D40 Offset: 0x757340 VA: 0x180758D40
	private bool IsTransformVisible(Vector2 worldPosition) { }

	// RVA: 0x759880 Offset: 0x757E80 VA: 0x180759880
	public void .ctor() { }
}
