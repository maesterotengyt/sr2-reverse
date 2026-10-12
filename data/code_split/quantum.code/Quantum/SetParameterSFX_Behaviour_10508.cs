// Namespace: Quantum
[Serializable]
public class SetParameterSFX_Behaviour : StateBehaviour // TypeDefIndex: 10508
{
	// Fields
	public SFXParameterType ParameterType; // 0x60
	public string EventID; // 0x68
	public string ParameterName; // 0x70
	public bool GlobalParamter; // 0x78
	[DrawIf("ParameterType", 1, 0, 3)]
	public string ParameterStringValue; // 0x80
	[DrawIf("ParameterType", 0, 0, 3)]
	public FP ParameterFloatValue; // 0x88

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BF1A0 Offset: 0x21BD7A0 VA: 0x1821BF1A0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
