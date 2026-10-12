// Namespace: Quantum
[Serializable]
public class UpdateEnvironmentCollisionBox_Behaviour : StateBehaviour // TypeDefIndex: 10592
{
	// Fields
	public UpdateEnvironmentCollisionBox_Behaviour.ECBUpdateMode UpdateMode; // 0x60
	public bool UseRootAsBottom; // 0x64
	[DrawIf("UpdateMode", 0, 0, 3)]
	public HashString PresetID; // 0x68
	[DrawIf("UpdateMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable Top; // 0x78
	[DrawIf("UpdateMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable Bottom; // 0x80
	[DrawIf("UpdateMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable Left; // 0x88
	[DrawIf("UpdateMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable Right; // 0x90
	public ECBOffset TopOffset; // 0x98
	public ECBOffset BottomOffset; // 0xA8
	public ECBOffset LeftOffset; // 0xB8
	public ECBOffset RightOffset; // 0xC8

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C3390 Offset: 0x21C1990 VA: 0x1821C3390 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C3D50 Offset: 0x21C2350 VA: 0x1821C3D50 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
