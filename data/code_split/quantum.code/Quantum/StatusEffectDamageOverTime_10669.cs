// Namespace: Quantum
[Serializable]
public class StatusEffectDamageOverTime : StatusEffectBase // TypeDefIndex: 10669
{
	// Fields
	public FP Damage; // 0x1B0
	public FP FrameFrecuency; // 0x1B8
	protected FP FrameCountToNextDamage; // 0x1C0

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnApply(Frame frame, EntityRef targetEntity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnRemove(Frame frame, EntityRef targetEntity) { }

	// RVA: 0x20FA640 Offset: 0x20F8C40 VA: 0x1820FA640 Slot: 9
	public override void OnUpdate(Frame frame, EntityRef targetEntity) { }

	// RVA: 0x20FA770 Offset: 0x20F8D70 VA: 0x1820FA770
	public void .ctor() { }
}
