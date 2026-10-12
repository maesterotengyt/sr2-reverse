// Namespace: Quantum
[Serializable]
public class RotateBasedOnVelocity_Behaviour : StateBehaviour // TypeDefIndex: 10583
{
	// Fields
	public VelocityAxisInfluence AxisInfluence; // 0x60
	[DrawWithLabel]
	public EntityVariable RotationOffset; // 0x68
	[DrawIf("AxisInfluence", 2, 1, 3)]
	public FP MinVelocity; // 0x70
	[DrawIf("AxisInfluence", 2, 1, 3)]
	public FP MaxVelocity; // 0x78
	[DrawIf("AxisInfluence", 2, 1, 3)]
	public FP MinRotation; // 0x80
	[DrawIf("AxisInfluence", 2, 1, 3)]
	public FP MaxRotation; // 0x88
	public bool ResetRotationOnExit; // 0x90

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BE760 Offset: 0x21BCD60 VA: 0x1821BE760 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BE7E0 Offset: 0x21BCDE0 VA: 0x1821BE7E0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BE760 Offset: 0x21BCD60 VA: 0x1821BE760 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21BE810 Offset: 0x21BCE10 VA: 0x1821BE810
	private void SetRotation(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
