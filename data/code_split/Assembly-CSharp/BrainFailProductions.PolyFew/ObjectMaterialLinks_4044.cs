// Namespace: BrainFailProductions.PolyFew
[ExecuteInEditMode]
public class ObjectMaterialLinks : MonoBehaviour // TypeDefIndex: 4044
{
	// Fields
	[SerializeField]
	private List<CombiningInformation.MaterialEntity> linkedEntities; // 0x20
	public List<PolyfewRuntime.MaterialProperties> materialsProperties; // 0x28
	public Texture2D linkedAttrImg; // 0x30

	// Properties
	public List<CombiningInformation.MaterialEntity> linkedMaterialEntities { get; set; }

	// Methods

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public List<CombiningInformation.MaterialEntity> get_linkedMaterialEntities() { }

	// RVA: 0x6B0380 Offset: 0x6AE980 VA: 0x1806B0380
	public void set_linkedMaterialEntities(List<CombiningInformation.MaterialEntity> value) { }

	// RVA: 0x6B00A0 Offset: 0x6AE6A0 VA: 0x1806B00A0
	private void Start() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
