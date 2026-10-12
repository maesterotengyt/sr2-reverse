// Namespace: 
public class MaterialChangeTransitionBehaviour : PlayableBehaviour // TypeDefIndex: 3538
{
	// Fields
	public Material TargetMaterial; // 0x10
	public List<ChangeableProperty> ChangeableProperties; // 0x18
	public float TransitionSpeed; // 0x20
	private Dictionary<ChangeableProperty, object> startValues; // 0x28
	private Dictionary<ChangeableProperty, object> endValues; // 0x30
	private bool initialized; // 0x38
	private MaterialPropertyBlock mpb; // 0x40

	// Methods

	// RVA: 0x5E8830 Offset: 0x5E6E30 VA: 0x1805E8830 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x5E93B0 Offset: 0x5E79B0 VA: 0x1805E93B0
	public void .ctor() { }
}
