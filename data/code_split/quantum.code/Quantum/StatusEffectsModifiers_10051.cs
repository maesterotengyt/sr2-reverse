// Namespace: Quantum
public struct StatusEffectsModifiers : IComponent // TypeDefIndex: 10051
{
	// Fields
	public StatusEffectAttribute DamageAttribute; // 0x20
	[PtrQList(typeof(StatusEffectAttributeModifier))]
	private Ptr DamageModifiersPtr; // 0x0
	public EntityRef Entity; // 0x10
	public StatusEffectAttribute KnockbackAttribute; // 0x38
	[PtrQList(typeof(StatusEffectAttributeModifier))]
	private Ptr KnockbackModifiersPtr; // 0x4
	public FP OriginalScale; // 0x18
	public StatusEffectAttribute ScaleAttribute; // 0x50
	[PtrQList(typeof(StatusEffectAttributeModifier))]
	private Ptr ScaleModifiersPtr; // 0x8

	// Properties
	public QListPtr<StatusEffectAttributeModifier> DamageModifiers { get; set; }
	public QListPtr<StatusEffectAttributeModifier> KnockbackModifiers { get; set; }
	public QListPtr<StatusEffectAttributeModifier> ScaleModifiers { get; set; }

	// Methods

	// RVA: 0x2134930 Offset: 0x2132F30 VA: 0x182134930
	public QListPtr<StatusEffectAttributeModifier> get_DamageModifiers() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_DamageModifiers(QListPtr<StatusEffectAttributeModifier> value) { }

	// RVA: 0x2134970 Offset: 0x2132F70 VA: 0x182134970
	public QListPtr<StatusEffectAttributeModifier> get_KnockbackModifiers() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_KnockbackModifiers(QListPtr<StatusEffectAttributeModifier> value) { }

	// RVA: 0x21349B0 Offset: 0x2132FB0 VA: 0x1821349B0
	public QListPtr<StatusEffectAttributeModifier> get_ScaleModifiers() { }

	// RVA: 0x1ED2130 Offset: 0x1ED0730 VA: 0x181ED2130
	public void set_ScaleModifiers(QListPtr<StatusEffectAttributeModifier> value) { }

	// RVA: 0x2134640 Offset: 0x2132C40 VA: 0x182134640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2134630 Offset: 0x2132C30 VA: 0x182134630
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2134730 Offset: 0x2132D30 VA: 0x182134730
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x21347B0 Offset: 0x2132DB0 VA: 0x1821347B0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x21346D0 Offset: 0x2132CD0 VA: 0x1821346D0
	public void Init(Frame frame, EntityRef entity) { }
}
