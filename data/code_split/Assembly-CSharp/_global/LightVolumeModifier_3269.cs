// Namespace: 
[RequireComponent(typeof(Collider2D))]
public class LightVolumeModifier : MonoBehaviour // TypeDefIndex: 3269
{
	// Fields
	[Header("Reference Shader")]
	public Shader ReferenceShader; // 0x20
	[Header("Blending Settings")]
	public float BlendDistance; // 0x28
	[Header("Shader Property Settings")]
	public List<LightVolumeModifier.ShaderProperty> ShaderProperties; // 0x30
	private Dictionary<Renderer, MaterialPropertyBlock> propertyBlocks; // 0x38
	private Dictionary<Renderer, Dictionary<string, object>> originalValues; // 0x40
	private List<Renderer> insideRenderers; // 0x48

	// Methods

	// RVA: 0x59FC70 Offset: 0x59E270 VA: 0x18059FC70
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x59FD40 Offset: 0x59E340 VA: 0x18059FD40
	private void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x59F5A0 Offset: 0x59DBA0 VA: 0x18059F5A0
	private void AddRenderer(Renderer renderer) { }

	// RVA: 0x59FEB0 Offset: 0x59E4B0 VA: 0x18059FEB0
	private void RemoveRenderer(Renderer renderer) { }

	// RVA: 0x5A02B0 Offset: 0x59E8B0 VA: 0x1805A02B0
	private void Update() { }

	// RVA: 0x59FA60 Offset: 0x59E060 VA: 0x18059FA60
	private float CalculateBlendFactor(Renderer renderer) { }

	// RVA: 0x59FE10 Offset: 0x59E410 VA: 0x18059FE10
	private void OnValidate() { }

	// RVA: 0x5A0900 Offset: 0x59EF00 VA: 0x1805A0900
	public void .ctor() { }
}
