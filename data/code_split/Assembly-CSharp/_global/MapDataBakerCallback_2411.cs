// Namespace: 
public abstract class MapDataBakerCallback // TypeDefIndex: 2411
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBeforeBake(MapData data);

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void OnBeforeBake(MapData data, MapDataBaker.BuildTrigger buildTrigger, QuantumMapDataBakeFlags bakeFlags) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnBake(MapData data);

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void OnBeforeBakeNavMesh(MapData data) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public virtual void OnCollectNavMeshBakeData(MapData data, List<MapNavMesh.BakeData> navMeshBakeData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public virtual void OnCollectNavMeshes(MapData data, List<NavMesh> navmeshes) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void OnBakeNavMesh(MapData data) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
