// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentNavMeshPathfinder : EntityComponentBase<NavMeshPathfinder_Prototype> // TypeDefIndex: 1946
{
	// Fields
	[LocalReference]
	[DrawIf("Prototype.InitialTargetNavMesh.Id.Value", 0, 0, 2)]
	public MapNavMeshDefinition InitialTargetNavMeshReference; // 0x28

	// Methods

	// RVA: 0x50E8D0 Offset: 0x50CED0 VA: 0x18050E8D0 Slot: 5
	public override void Refresh() { }

	// RVA: 0x50E960 Offset: 0x50CF60 VA: 0x18050E960
	public void .ctor() { }
}
