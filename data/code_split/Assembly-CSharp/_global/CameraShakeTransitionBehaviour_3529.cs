// Namespace: 
public class CameraShakeTransitionBehaviour : PlayableBehaviour // TypeDefIndex: 3529
{
	// Fields
	public int CameraShakePresetID; // 0x10
	public ExposedReference<StellarStageCamera> TargetRef; // 0x18
	private bool hasApplied; // 0x28

	// Methods

	// RVA: 0x5E38F0 Offset: 0x5E1EF0 VA: 0x1805E38F0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x5E38E0 Offset: 0x5E1EE0 VA: 0x1805E38E0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x5E38E0 Offset: 0x5E1EE0 VA: 0x1805E38E0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
