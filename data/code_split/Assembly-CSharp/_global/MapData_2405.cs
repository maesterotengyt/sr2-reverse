// Namespace: 
[ExecuteInEditMode]
public class MapData : MonoBehaviour // TypeDefIndex: 2405
{
	// Fields
	public MapAsset Asset; // 0x20
	[EnumFlags]
	public MapData.DrawMode DrawGridMode; // 0x28
	[EnumFlags]
	[HideInInspector]
	public QuantumMapDataBakeFlags BakeAllMode; // 0x2C
	public List<MonoBehaviour> StaticCollider2DReferences; // 0x30
	public List<MonoBehaviour> StaticCollider3DReferences; // 0x38
	public List<EntityView> MapEntityReferences; // 0x40

	// Methods

	// RVA: 0x525630 Offset: 0x523C30 VA: 0x180525630
	private void Update() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnDrawGizmos() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnDrawGizmosSelected() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void DrawGizmos(bool selected) { }

	// RVA: 0x525700 Offset: 0x523D00 VA: 0x180525700
	public void .ctor() { }
}
