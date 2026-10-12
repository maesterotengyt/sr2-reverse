// Namespace: 
[Serializable]
public class MaterialChangeTransitionClip : PlayableAsset // TypeDefIndex: 3539
{
	// Fields
	public Material TargetMaterial; // 0x18
	public List<ChangeableProperty> ChangeableProperties; // 0x20
	public float TransitionSpeed; // 0x28

	// Methods

	// RVA: 0x5E94D0 Offset: 0x5E7AD0 VA: 0x1805E94D0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x5E9600 Offset: 0x5E7C00 VA: 0x1805E9600
	public void .ctor() { }
}
