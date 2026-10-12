// Namespace: BrainFailProductions.PolyFew.AsImpL
[Serializable]
public class ImportOptions // TypeDefIndex: 4081
{
	// Fields
	[Tooltip("load the OBJ file assuming its vertical axis is Z instead of Y")]
	public bool zUp; // 0x10
	[Tooltip("Consider diffuse map as already lit (disable lighting) if no other texture is present")]
	public bool litDiffuse; // 0x11
	[Tooltip("Consider to double-sided (duplicate and flip faces and normals")]
	public bool convertToDoubleSided; // 0x12
	[Tooltip("Rescaling for the model (1 = no rescaling)")]
	public float modelScaling; // 0x14
	[Tooltip("Reuse a model in memory if already loaded")]
	public bool reuseLoaded; // 0x18
	[Tooltip("Inherit parent layer")]
	public bool inheritLayer; // 0x19
	[Tooltip("Generate mesh colliders")]
	public bool buildColliders; // 0x1A
	[Tooltip("Generate convex mesh colliders (only active if buildColliders = true)
Note: it could not work for meshes with too many smooth surface regions.")]
	public bool colliderConvex; // 0x1B
	[Tooltip("Mesh colliders as trigger (only active if colliderConvex = true)")]
	public bool colliderTrigger; // 0x1C
	[Tooltip("Use 32 bit indices when needed, if available")]
	public bool use32bitIndices; // 0x1D
	[Tooltip("Hide the loaded object during the loading process")]
	public bool hideWhileLoading; // 0x1E
	[Header("Local Transform for the imported game object")]
	[Tooltip("Position of the object")]
	public Vector3 localPosition; // 0x20
	[Tooltip("Rotation of the object
(Euler angles)")]
	public Vector3 localEulerAngles; // 0x2C
	[Tooltip("Scaling of the object
([1,1,1] = no rescaling)")]
	public Vector3 localScale; // 0x38

	// Methods

	// RVA: 0x6A8300 Offset: 0x6A6900 VA: 0x1806A8300
	public void .ctor() { }
}
