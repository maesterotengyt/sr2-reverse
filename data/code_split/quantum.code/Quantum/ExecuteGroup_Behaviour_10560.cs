// Namespace: Quantum
[Serializable]
public class ExecuteGroup_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10560
{
	// Fields
	[Space(10)]
	public ExecuteGroupEvent GroupToExecute; // 0x68
	[Header("Repeat Properties")]
	public ExecuteGroup_Behaviour.ExecuteGroupRepeatMode RepeatMode; // 0x80
	[DrawIf("RepeatMode", 1, 0, 3)]
	public int FramesInterval; // 0x84
	[DrawIf("RepeatMode", 1, 0, 3)]
	public int RepeatNumber; // 0x88

	// Methods

	// RVA: 0x21B5DE0 Offset: 0x21B43E0 VA: 0x1821B5DE0 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B5DF0 Offset: 0x21B43F0 VA: 0x1821B5DF0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B5E90 Offset: 0x21B4490 VA: 0x1821B5E90 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21AFF10 Offset: 0x21AE510 VA: 0x1821AFF10
	public void .ctor() { }
}
