// Namespace: Quantum.Prototypes
[Prototype(typeof(NavMeshPathfinder))]
[Serializable]
public sealed class NavMeshPathfinder_Prototype : ComponentPrototype<NavMeshPathfinder> // TypeDefIndex: 11904
{
	// Fields
	public AssetRefNavMeshAgentConfig AgentConfig; // 0x18
	[Space(8)]
	public NullableFPVector3 InitialTarget; // 0x20
	public AssetRefNavMesh InitialTargetNavMesh; // 0x40
	[DrawIf("InitialTargetNavMesh.Id.Value", 0, 0, 2)]
	public string InitialTargetNavMeshName; // 0x48

	// Methods

	// RVA: 0x2274920 Offset: 0x2272F20 VA: 0x182274920 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2274C30 Offset: 0x2273230 VA: 0x182274C30
	public void Materialize(FrameBase frame, EntityRef entity, ref NavMeshPathfinder result) { }

	// RVA: 0x2274C00 Offset: 0x2273200 VA: 0x182274C00 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2274E00 Offset: 0x2273400 VA: 0x182274E00
	public void .ctor() { }
}
