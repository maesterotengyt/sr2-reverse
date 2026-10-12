// Namespace: Quantum
[Serializable]
public class UseGroundRotation_Behaviour : StateBehaviour // TypeDefIndex: 10593
{
	// Fields
	[Range(0, 1)]
	public FP FloorRotationInfluence; // 0x60
	public FP InterpolationSpeed; // 0x68
	public bool ForceRotation; // 0x70
	public bool ResetOnExit; // 0x71

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C3EE0 Offset: 0x21C24E0 VA: 0x1821C3EE0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C3F50 Offset: 0x21C2550 VA: 0x1821C3F50 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21C3F90 Offset: 0x21C2590 VA: 0x1821C3F90
	public void .ctor() { }
}
