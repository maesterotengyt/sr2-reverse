// Namespace: Quantum
[Serializable]
public class Reflect_Behaviour : StateBehaviour // TypeDefIndex: 10522
{
	// Fields
	[Header("For this Behaviour it is required to have the following variables in the state machine
You can then use the RedirectionSpeed params to apply the velocity calculated here")]
	[DrawWithLabel]
	public EntityVariable ReflectionVectorX; // 0x60
	[DrawWithLabel]
	public EntityVariable ReflectionVectorY; // 0x68
	[Header("Output Variables")]
	public ReflectionMode ReflectMode; // 0x70
	[DrawWithLabel]
	public EntityVariable OutReflectedFlag; // 0x78
	[DrawIf("ReflectMode", 0, 0, 3)]
	[DrawWithLabel]
	public EntityVariable OutReflectionSpeed; // 0x80
	[DrawIf("ReflectMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable OutReflectionSpeedX; // 0x88
	[DrawIf("ReflectMode", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable OutReflectionSpeedY; // 0x90

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BD590 Offset: 0x21BBB90 VA: 0x1821BD590 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
