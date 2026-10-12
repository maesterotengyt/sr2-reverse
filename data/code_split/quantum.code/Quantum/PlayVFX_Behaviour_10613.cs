// Namespace: Quantum
[Serializable]
public class PlayVFX_Behaviour : StateBehaviour // TypeDefIndex: 10613
{
	// Fields
	public HashString VFXID; // 0x60
	public VFXPlayAttributes PlayAttributes; // 0x70
	public bool StopOnExit; // 0x108
	[DrawIf("StopOnExit", 1, 0, 3)]
	public VFXStopAttributes StopAttributes; // 0x109

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20F8DF0 Offset: 0x20F73F0 VA: 0x1820F8DF0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20F95C0 Offset: 0x20F7BC0 VA: 0x1820F95C0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
