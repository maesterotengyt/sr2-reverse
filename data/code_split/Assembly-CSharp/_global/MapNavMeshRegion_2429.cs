// Namespace: 
public class MapNavMeshRegion : MonoBehaviour // TypeDefIndex: 2429
{
	// Fields
	[Tooltip("All regions with the same id are toggle-able as one region. Check Map.Regions to see the results.")]
	public string Id; // 0x20
	[Tooltip("Set to CastRegion when the region should be casted onto the navmesh. For Links for example chose NoRegion.")]
	public MapNavMeshRegion.RegionCastType CastRegion; // 0x28
	[Tooltip("Cost modifier that is applied to the heuristics of the path finding. Automatically gets the Unity area cost when adding the scripts. Toggle Overwrite to set to a custom value.")]
	public FP Cost; // 0x30
	public bool OverwriteCost; // 0x38

	// Methods

	// RVA: 0x525EE0 Offset: 0x5244E0 VA: 0x180525EE0
	public void .ctor() { }
}
