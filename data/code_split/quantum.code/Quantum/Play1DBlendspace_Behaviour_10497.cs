// Namespace: Quantum
[Serializable]
public class Play1DBlendspace_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10497
{
	// Fields
	public AnimationPlayableInfo[] Animations; // 0x68
	public bool ApplyBlendToCurrent; // 0x70
	[DrawIf("ApplyBlendToCurrent", 1, 0, 3)]
	public FP BlendFrames; // 0x78
	[Space(10)]
	[DrawWithLabel]
	public EntityVariable MinInputValue; // 0x80
	[DrawWithLabel]
	public EntityVariable MaxInputValue; // 0x88
	[DrawWithLabel]
	public EntityVariable InputValue; // 0x90

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BB390 Offset: 0x21B9990 VA: 0x1821BB390 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BB7E0 Offset: 0x21B9DE0 VA: 0x1821BB7E0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BB820 Offset: 0x21B9E20 VA: 0x1821BB820 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21BB9E0 Offset: 0x21B9FE0 VA: 0x1821BB9E0
	public void .ctor() { }
}
