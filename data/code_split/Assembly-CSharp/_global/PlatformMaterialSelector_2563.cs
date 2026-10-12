// Namespace: 
[RequireComponent(typeof(Image))]
public class PlatformMaterialSelector : MonoBehaviour // TypeDefIndex: 2563
{
	// Fields
	[Header("Material Settings")]
	[Tooltip("The default material to use if the current platform isn't in the list below.")]
	[SerializeField]
	private Material defaultMaterial; // 0x20
	[Header("Platform Overrides")]
	[SerializeField]
	private List<PlatformMaterialSelector.PlatformMaterialOverride> platformMaterials; // 0x28

	// Methods

	// RVA: 0x6FF8B0 Offset: 0x6FDEB0 VA: 0x1806FF8B0
	private void Start() { }

	// RVA: 0x6FF5D0 Offset: 0x6FDBD0 VA: 0x1806FF5D0
	private void ApplyPlatformMaterial() { }

	// RVA: 0x6FF8C0 Offset: 0x6FDEC0 VA: 0x1806FF8C0
	public void .ctor() { }
}
