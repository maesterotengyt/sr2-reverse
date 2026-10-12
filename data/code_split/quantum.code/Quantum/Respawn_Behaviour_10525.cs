// Namespace: Quantum
[Serializable]
public class Respawn_Behaviour : StateBehaviour // TypeDefIndex: 10525
{
	// Fields
	public ExecuteGroupEvent OnRespawnEndGroup; // 0x60
	public bool UseCustomRespawnPosition; // 0x78
	public HashString RespawnSpawnPointID; // 0x80

	// Methods

	// RVA: 0x21BE340 Offset: 0x21BC940 VA: 0x1821BE340 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BE5D0 Offset: 0x21BCBD0 VA: 0x1821BE5D0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21BDF50 Offset: 0x21BC550 VA: 0x1821BDF50
	private void CheckRespawnEnd(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21BE6D0 Offset: 0x21BCCD0 VA: 0x1821BE6D0
	public void .ctor() { }
}
