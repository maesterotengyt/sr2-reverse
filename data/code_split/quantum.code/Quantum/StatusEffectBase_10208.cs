// Namespace: Quantum
[Serializable]
public abstract class StatusEffectBase : AssetObject // TypeDefIndex: 10208
{
	// Fields
	[Tooltip("Removes these types of status when applied")]
	public HashString[] StatusEffectToRemoveByType; // 0x20
	[Tooltip("If the status in the list is active in the entity, this status won't be applied")]
	public HashString[] BlockedByStatusEffectsByType; // 0x28
	[Header("VFX to reproduce when status effect is applied")]
	public HashString OnApplyVFXID; // 0x30
	public VFXPlayAttributes OnApplyPlayAttributes; // 0x40
	[Header("VFX to reproduce when status effect is removed")]
	public HashString OnRemoveVFXID; // 0xD8
	public VFXPlayAttributes OnRemovePlayAttributes; // 0xE8
	[Space(10)]
	[Tooltip("Indetifier of the status effect")]
	public HashString NameId; // 0x180
	[Tooltip("If is not time based the status effect will persist until stopped externally")]
	public bool IsTimeBased; // 0x190
	[DrawIf("IsTimeBased", 1, 0, 2)]
	[Tooltip("How many frames the status effect will affect the character")]
	public FP BaseFrameDuration; // 0x198
	[HideInInspector]
	public bool MashToReduceDuration; // 0x1A0
	[HideInInspector]
	public bool PreserveOnCharacterSwap; // 0x1A1
	public bool RemoveOnRespawn; // 0x1A2
	[HideInInspector]
	public EntityRef originEntity; // 0x1A8

	// Methods

	// RVA: 0x2160250 Offset: 0x215E850 VA: 0x182160250 Slot: 6
	public virtual HashString GetStatusEffectType() { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnApply(Frame frame, EntityRef targetEntity);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnRemove(Frame frame, EntityRef targetEntity);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnUpdate(Frame frame, EntityRef targetEntity);

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void NotifyEvent(Frame frame, StatusEffectEvent eventType, EntityRef entity) { }

	// RVA: 0x21602B0 Offset: 0x215E8B0 VA: 0x1821602B0 Slot: 11
	public virtual void OnReApply(Frame frame, EntityRef targetEntity, StatusEffectBase statusEffect) { }

	// RVA: 0x2160160 Offset: 0x215E760 VA: 0x182160160
	public void Apply(Frame frame, EntityRef targetEntity, EntityRef originEntity) { }

	// RVA: 0x21602D0 Offset: 0x215E8D0 VA: 0x1821602D0
	public void Remove(Frame frame, EntityRef targetEntity) { }

	// RVA: 0x21603D0 Offset: 0x215E9D0 VA: 0x1821603D0
	protected void .ctor() { }
}
