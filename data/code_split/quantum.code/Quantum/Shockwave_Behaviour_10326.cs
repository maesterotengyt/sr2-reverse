// Namespace: Quantum
[Serializable]
public class Shockwave_Behaviour : StateBehaviour // TypeDefIndex: 10326
{
	// Fields
	public FP ShockwaveDelay; // 0x60
	public int InterpolationFramesDuration; // 0x68
	public FPAnimationCurve InterpolationCurve; // 0x70

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21772C0 Offset: 0x21758C0 VA: 0x1821772C0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21774D0 Offset: 0x2175AD0 VA: 0x1821774D0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2177680 Offset: 0x2175C80 VA: 0x182177680
	public void .ctor() { }
}
