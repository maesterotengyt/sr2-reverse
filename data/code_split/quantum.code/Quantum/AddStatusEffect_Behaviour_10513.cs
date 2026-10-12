// Namespace: Quantum
[Serializable]
public class AddStatusEffect_Behaviour : StateBehaviour // TypeDefIndex: 10513
{
	// Fields
	public HashString StatusEffectId; // 0x60
	public HashString OriginId; // 0x70
	[Tooltip("If is set to true the status effect can be applied to the entity creating the effect or its partner")]
	public bool AffectOriginEntity; // 0x80
	[Header("Origin entity is taken from the entity that executes this behaviour, not the target entity, in other words from the state machine owner entity")]
	[Tooltip("Origin entity is taken from the entity that executes this behaviour, not the target entity, in other words from the state machine owner entity")]
	public BehaviourTargetEntity OriginEntity; // 0x84
	[DrawIf("OriginEntity", 1, 0, 3)]
	public HashString OriginIndexParameterID; // 0x88

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21AF2A0 Offset: 0x21AD8A0 VA: 0x1821AF2A0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21AF0A0 Offset: 0x21AD6A0 VA: 0x1821AF0A0
	private bool IsOriginEntity(Frame frame, CachedEntityData originEntity, CachedEntityData targetEntityData) { }

	// RVA: 0x21AF580 Offset: 0x21ADB80 VA: 0x1821AF580
	public void .ctor() { }
}
