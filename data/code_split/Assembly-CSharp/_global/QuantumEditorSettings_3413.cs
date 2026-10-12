// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Configurations/QuantumEditorSettings", fileName = "QuantumEditorSettings", order = -999)]
public class QuantumEditorSettings : ScriptableObject // TypeDefIndex: 3413
{
	// Fields
	private static QuantumEditorSettings _instance; // 0x0
	[Tooltip("Path to asset resource db file.")]
	public string DefaultAssetResourcesPath; // 0x18
	public QuantumEditorSettings.AssetResourcePath[] AssetResourcesPaths; // 0x20
	[Tooltip("These folders are scanned when creating the AssetResource collection. The first on is the default path for exported assets like map and navmesh.")]
	public string[] AssetSearchPaths; // 0x28
	[Tooltip("Quantum scripts occasionally search for types in the Unity assemblies (e.g. MapDataBakerCallback). When using assembly definitions add them here.")]
	public string[] SearchAssemblies; // 0x30
	[Tooltip("See SearchAssemblies")]
	public string[] SearchEditorAssemblies; // 0x38
	[Header("Map")]
	public Color PhysicsGridColor; // 0x40
	public Color NavMeshGridColor; // 0x50
	[Header("Gizmos")]
	public FP GizmoIconScale; // 0x60
	public float GizmoSelectedBrightness; // 0x68
	[Header("Collider Gizmos")]
	[EnumFlags]
	public QuantumEditorSettings.GizmosMode DrawColliderGizmos; // 0x6C
	public QuantumGizmoStyle ColliderGizmosStyle; // 0x70
	public QuantumGizmoStyle StaticColliderGizmoStyle; // 0x71
	public bool DrawStaticMeshTriangles; // 0x72
	public bool DrawStaticMeshNormals; // 0x73
	public bool DrawSceneMeshCells; // 0x74
	public bool DrawSceneMeshTriangles; // 0x75
	public Color StaticColliderColor; // 0x78
	public Color DynamicColliderColor; // 0x88
	public Color KinematicColliderColor; // 0x98
	public Color CharacterControllerColor; // 0xA8
	public Color AsleepColliderColor; // 0xB8
	public Color DisabledColliderColor; // 0xC8
	[Header("Joint Gizmos")]
	[EnumFlags]
	public QuantumEditorSettings.GizmosMode DrawJointGizmos; // 0xD8
	public QuantumGizmoStyle JointGizmosStyle; // 0xDC
	public Color JointGizmosPrimaryColor; // 0xE0
	public Color JointGizmosSecondaryColor; // 0xF0
	public Color JointGizmosWarningColor; // 0x100
	[Header("Prediction Culling Gizmos")]
	public bool DrawPredictionArea; // 0x110
	public Color PredictionAreaColor; // 0x114
	[Header("Pathfinder Gizmos")]
	public bool DrawPathfinderRawPath; // 0x124
	public bool DrawPathfinderRawTrianglePath; // 0x125
	public bool DrawPathfinderFunnel; // 0x126
	[Header("NavMesh Agent Gizmos")]
	public bool DrawNavMeshAgents; // 0x127
	public Color NavMeshAgentColor; // 0x128
	public Color NavMeshAvoidanceColor; // 0x138
	[Header("NavMesh Gizmos")]
	public bool DrawNavMesh; // 0x148
	public bool DrawNavMeshBorders; // 0x149
	public bool DrawNavMeshTriangleIds; // 0x14A
	public bool DrawNavMeshRegionIds; // 0x14B
	public bool DrawNavMeshVertexNormals; // 0x14C
	public bool DrawNavMeshLinks; // 0x14D
	public Color NavMeshDefaultColor; // 0x150
	public Color NavMeshRegionColor; // 0x160
	[Header("NavMesh Editor")]
	public bool DrawNavMeshDefinitionAlways; // 0x170
	public bool DrawNavMeshDefinitionMesh; // 0x171
	public bool DrawNavMeshDefinitionOptimized; // 0x172
	[Header("Editor Features")]
	[Tooltip("Toggle the Quantum asset inspector. Completely disable it by defining DISABLE_QUANTUM_ASSET_EDITOR.")]
	public bool UseQuantumAssetInspector; // 0x173
	[Tooltip("The post processor enables duplicating Quantum assets and prefabs and make sure a new guid and correct path are set. This can make especially batched processes slow and can be toggled off here.")]
	public bool UseAssetBasePostprocessor; // 0x174
	[Tooltip("If enabled a scene loading dropdown is displayed next to the play button.")]
	public bool UseQuantumToolbarUtilities; // 0x175
	[Tooltip("Toolbar Zone. Requires a domain reload after change.")]
	public QuantumToolbarZone QuantumToolbarZone; // 0x178
	[Tooltip("If enabled a local PhotonPrivateAppVersion scriptable object is created to support the demo menu scene.")]
	public bool UsePhotonAppVersionsPostprocessor; // 0x17C
	[Tooltip("If enabled entity components are displayed inside of EntityPrototype inspector")]
	[FormerlySerializedAs("UseInlineEntityComponents")]
	public QuantumEntityComponentInspectorMode EntityComponentInspectorMode; // 0x180
	[Range(2, 7)]
	[Tooltip("How many decimal places to round to when displaying FPs.")]
	public int FPDisplayPrecision; // 0x184
	[FormerlySerializedAs("MaxInspectableArraySize")]
	[Tooltip("How many elements an array can have to be expandable in the Inspector. Set to a negative value to always allow arrays expansion.")]
	public int MaxArraySizeForInspector; // 0x188
	[EnumFlags]
	[Tooltip("Automatically trigger bake on saving a scene.")]
	public QuantumMapDataBakeFlags AutoBuildOnSceneSave; // 0x18C
	[EnumFlags]
	[Tooltip("If set MapData will be automatically baked on entering play mode, on saving a scene and on building a player.")]
	public QuantumMapDataBakeFlags AutoBuildOnPlaymodeChanged; // 0x190
	[EnumFlags]
	[Tooltip("If set MapData will be automatically baked on entering play mode, on saving a scene and on building a player.")]
	public QuantumMapDataBakeFlags AutoBuildOnBuild; // 0x194
	[Header("Quantum Solution Integration (changes require Unity restart)")]
	[Tooltip("Overwrite to use a different path from the Unity project to the quantum code solution.")]
	public string QuantumSolutionPath; // 0x198
	[Tooltip("If enabled projects from quantum_code.sln will get imported into Unity's generated Visual Studio Solution.")]
	public bool MergeWithVisualStudioSolution; // 0x1A0
	[Tooltip("If enabled rebuilding Quantum will trigger Unity to import resulting DLLs immediately, not waiting for gaining focus.")]
	public bool ImportQuantumLibrariesImmediately; // 0x1A1
	[Tooltip("If enabled any changes in .qtn files in quantum.code will run the codegen immediately.")]
	public bool AutoRunQtnCodeGen; // 0x1A2
	private string databasePathInResources; // 0x1A8

	// Properties
	public static QuantumEditorSettings Instance { get; }
	public static QuantumEditorSettings InstanceFailSilently { get; }
	[Obsolete("Use DefaultAssetSearchPath instead")]
	public string DatabasePath { get; }
	public string DefaultAssetSearchPath { get; }
	[Obsolete("Use DatabasePathInResources")]
	public string ResourceDatabasePath { get; }
	public string DatabasePathInResources { get; }

	// Methods

	// RVA: 0x5D05A0 Offset: 0x5CEBA0 VA: 0x1805D05A0
	public static QuantumEditorSettings get_Instance() { }

	// RVA: 0x5D04D0 Offset: 0x5CEAD0 VA: 0x1805D04D0
	public static QuantumEditorSettings get_InstanceFailSilently() { }

	// RVA: 0x5D04A0 Offset: 0x5CEAA0 VA: 0x1805D04A0
	public string get_DatabasePath() { }

	// RVA: 0x5D04A0 Offset: 0x5CEAA0 VA: 0x1805D04A0
	public string get_DefaultAssetSearchPath() { }

	// RVA: 0x5CFB70 Offset: 0x5CE170 VA: 0x1805CFB70
	public string GetAssetResourcePath(string filePath, bool useDefaultIfNotFound = True) { }

	// RVA: 0x5CF9F0 Offset: 0x5CDFF0 VA: 0x1805CF9F0
	public List<string> GetAllAssetResourceContainerPaths() { }

	// RVA: 0x5CFE20 Offset: 0x5CE420 VA: 0x1805CFE20
	public List<string> GetPathsFromAssetResourceContainer(string containerPath) { }

	// RVA: 0x5D03B0 Offset: 0x5CE9B0 VA: 0x1805D03B0
	public string get_ResourceDatabasePath() { }

	// RVA: 0x5D03B0 Offset: 0x5CE9B0 VA: 0x1805D03B0
	public string get_DatabasePathInResources() { }

	// RVA: 0x5CFDC0 Offset: 0x5CE3C0 VA: 0x1805CFDC0
	public Color GetNavMeshColor(NavMeshRegionMask regionMask) { }

	// RVA: 0x5CFF50 Offset: 0x5CE550 VA: 0x1805CFF50
	public void .ctor() { }
}
