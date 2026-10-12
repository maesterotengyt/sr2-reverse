// Namespace: Quantum
[Serializable]
public class ExecuteGroupOnLinecastHit_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10558
{
	// Fields
	public ExecuteGroupEvent GroupToExecute; // 0x68
	public ExecuteGroupOnLinecastHit_Behaviour.LinecastConditions LinecastCondition; // 0x80
	[Space(5)]
	public bool LinecastStartUsesFacingDirection; // 0x84
	public bool LinecastStartRelativeToCharacter; // 0x85
	public FPVector2 LinecastStart; // 0x88
	[Space(5)]
	public bool LinecastEndUsesFacingDirection; // 0x98
	public bool LinecastEndRelativeToCharacter; // 0x99
	public FPVector2 LinecastEnd; // 0xA0
	[Space(5)]
	public CollisionLayer[] LinecastLayers; // 0xB0
	[Header("Output Variables")]
	[DrawWithLabel]
	public EntityVariable OutXPosition; // 0xB8
	[DrawWithLabel]
	public EntityVariable OutYPosition; // 0xC0
	[Space(5)]
	public ColorRGBA LinecastColor; // 0xC8

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B5550 Offset: 0x21B3B50 VA: 0x1821B5550 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B5D80 Offset: 0x21B4380 VA: 0x1821B5D80
	public void .ctor() { }
}
