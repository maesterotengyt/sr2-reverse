// Namespace: Quantum
[Serializable]
public class PlaySFX_Behaviour : StateBehaviour // TypeDefIndex: 10507
{
	// Fields
	public string SFXEventName; // 0x60
	public bool UpdateSoundPosition; // 0x68
	public FP Delay; // 0x70
	[Header("Parameters")]
	public bool SetParameters; // 0x78
	public string ParameterName; // 0x80
	public SFXParameterType ParameterType; // 0x88
	[DrawIf("ParameterType", 0, 0, 3)]
	public string ParameterStringValue; // 0x90
	[DrawIf("ParameterType", 1, 0, 3)]
	public FP ParameterFloatValue; // 0x98

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BBF70 Offset: 0x21BA570 VA: 0x1821BBF70 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21BC750 Offset: 0x21BAD50 VA: 0x1821BC750
	public void .ctor() { }
}
