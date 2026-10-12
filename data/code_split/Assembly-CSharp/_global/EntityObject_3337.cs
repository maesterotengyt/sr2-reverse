// Namespace: 
[Serializable]
public class EntityObject // TypeDefIndex: 3337
{
	// Fields
	public HashString ID; // 0x10
	public GameObject ObjectReference; // 0x20
	public GameObject MirrorObjectReference; // 0x28
	public bool DefaultVisibility; // 0x30
	public SkinnedMeshRenderer SkinnedMeshRendererReference; // 0x38
	public SkinnedMeshRenderer SkinnedMeshRendererMirrorReference; // 0x40
	public HashString[] Blendshapes; // 0x48
	[CompilerGenerated]
	private Dictionary<int, int> <BlendShapesDict>k__BackingField; // 0x50

	// Properties
	public Dictionary<int, int> BlendShapesDict { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5B38B0 Offset: 0x5B1EB0 VA: 0x1805B38B0
	public Dictionary<int, int> get_BlendShapesDict() { }

	[CompilerGenerated]
	// RVA: 0x5B38C0 Offset: 0x5B1EC0 VA: 0x1805B38C0
	public void set_BlendShapesDict(Dictionary<int, int> value) { }

	// RVA: 0x5B3700 Offset: 0x5B1D00 VA: 0x1805B3700
	public void .ctor(string identifier, GameObject objectReference, GameObject mirrorObjectReference, bool defaultVisibility, SkinnedMeshRenderer skinnedMeshRendererReference, SkinnedMeshRenderer skinnedMeshRendererMirrorReference, HashString[] blendshapes) { }

	// RVA: 0x5B3800 Offset: 0x5B1E00 VA: 0x1805B3800
	public void .ctor(string identifier, GameObject objectReference, bool defaultVisibility) { }

	// RVA: 0x5B33C0 Offset: 0x5B19C0 VA: 0x1805B33C0
	public void SetBlendShapeValue(int blendShapeHash, float value, int facingDirection = 1) { }

	// RVA: 0x5B3570 Offset: 0x5B1B70 VA: 0x1805B3570
	public void SetVisibility(bool newVisibility, int facingDirection = 1) { }

	// RVA: 0x5B33B0 Offset: 0x5B19B0 VA: 0x1805B33B0
	public void RestoreDefaultVisibility(int facingDirection) { }
}
