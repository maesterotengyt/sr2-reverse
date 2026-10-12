// Namespace: Quantum
[Serializable]
public class InputCheck_Behaviour : StateBehaviour // TypeDefIndex: 10320
{
	// Fields
	public InputTransition Jump; // 0x60
	public InputTransition Hook; // 0x98
	public InputTransition Slide; // 0xD0

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2173130 Offset: 0x2171730 VA: 0x182173130 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21731F0 Offset: 0x21717F0 VA: 0x1821731F0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2173220 Offset: 0x2171820 VA: 0x182173220 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2173090 Offset: 0x2171690 VA: 0x182173090
	private void EvaluateInput(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
