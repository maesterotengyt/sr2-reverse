// Namespace: BrainFailProductions.PolyFewRuntime
public class UtilityServicesRuntime : MonoBehaviour // TypeDefIndex: 4177
{
	// Methods

	// RVA: 0x6ED400 Offset: 0x6EBA00 VA: 0x1806ED400
	public static Texture2D DuplicateTexture(Texture2D source) { }

	// RVA: 0x6ED5E0 Offset: 0x6EBBE0 VA: 0x1806ED5E0
	public static Renderer[] GetChildRenderersForCombining(GameObject forObject, bool skipInactiveChildObjects) { }

	// RVA: 0x6ED1B0 Offset: 0x6EB7B0 VA: 0x1806ED1B0
	public static MeshRenderer CreateStaticLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials) { }

	// RVA: 0x6ECFC0 Offset: 0x6EB5C0 VA: 0x1806ECFC0
	public static SkinnedMeshRenderer CreateSkinnedLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials, Transform rootBone, Transform[] bones) { }

	// RVA: 0x6ECDC0 Offset: 0x6EB3C0 VA: 0x1806ECDC0
	private static void CollectChildRenderersForCombining(Transform transform, List<Renderer> resultRenderers, bool skipInactiveChildObjects) { }

	// RVA: 0x6D48C0 Offset: 0x6D2EC0 VA: 0x1806D48C0
	private static void ParentAndResetTransform(Transform transform, Transform parentTransform) { }

	// RVA: 0x6D47E0 Offset: 0x6D2DE0 VA: 0x1806D47E0
	public static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
