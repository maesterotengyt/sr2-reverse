// Namespace: Quantum
[Serializable]
public class Dash_Behaviour : StateBehaviour // TypeDefIndex: 10606
{
	// Fields
	[Space(10)]
	public bool StopCurrentForces; // 0x60
	[Space(10)]
	public FP InitialForce; // 0x68
	public FP MinimumAcceleration; // 0x70
	public FP MaxAcceleration; // 0x78

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B3CE0 Offset: 0x21B22E0 VA: 0x1821B3CE0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B3D90 Offset: 0x21B2390 VA: 0x1821B3D90 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B3E80 Offset: 0x21B2480 VA: 0x1821B3E80 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B3F20 Offset: 0x21B2520 VA: 0x1821B3F20
	private void StartDash(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x21B3FD0 Offset: 0x21B25D0 VA: 0x1821B3FD0
	public void .ctor() { }
}
