// Namespace: Quantum
public struct StatusEffectsHolder : IComponent // TypeDefIndex: 10050
{
	// Fields
	[HideInInspector]
	[PtrQList(typeof(RuntimeStatusEffect))]
	private Ptr ActiveStatusEffectsPtr; // 0x0
	public EntityRef Entity; // 0x8

	// Properties
	public QListPtr<RuntimeStatusEffect> ActiveStatusEffects { get; set; }

	// Methods

	// RVA: 0x21345F0 Offset: 0x2132BF0 VA: 0x1821345F0
	public QListPtr<RuntimeStatusEffect> get_ActiveStatusEffects() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	public void set_ActiveStatusEffects(QListPtr<RuntimeStatusEffect> value) { }

	// RVA: 0x2133750 Offset: 0x2131D50 VA: 0x182133750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0430 Offset: 0x20DEA30 VA: 0x1820E0430
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2133B70 Offset: 0x2132170 VA: 0x182133B70
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2134160 Offset: 0x2132760 VA: 0x182134160
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2133950 Offset: 0x2131F50 VA: 0x182133950
	public void Init(Frame frame) { }

	// RVA: 0x2133120 Offset: 0x2131720 VA: 0x182133120
	public void AddStatusEffect(Frame frame, HashString nameId, HashString originId, EntityRef originEntity) { }

	// RVA: 0x2133F90 Offset: 0x2132590 VA: 0x182133F90
	public void RemoveStatusEffect(Frame frame, HashString nameId) { }

	// RVA: 0x2133BF0 Offset: 0x21321F0 VA: 0x182133BF0
	public void RemoveStatusEffectByOrigin(Frame frame, HashString originId) { }

	// RVA: 0x2133DC0 Offset: 0x21323C0 VA: 0x182133DC0
	public void RemoveStatusEffectByType(Frame frame, HashString typeId) { }

	// RVA: 0x21343F0 Offset: 0x21329F0 VA: 0x1821343F0
	public void Update(Frame frame) { }

	// RVA: 0x2133990 Offset: 0x2131F90 VA: 0x182133990
	public void NotifyEvent(Frame frame, StatusEffectEvent eventType) { }

	// RVA: 0x21335E0 Offset: 0x2131BE0 VA: 0x1821335E0
	public bool CheckIfStatusEffectsTypeIsActive(Frame frame, HashString[] types) { }

	// RVA: 0x2134210 Offset: 0x2132810 VA: 0x182134210
	private bool TryCreateStatusEffectById(Frame frame, HashString nameId, out AssetRefStatusEffectBase newStatusEffect) { }

	// RVA: 0x21334A0 Offset: 0x2131AA0 VA: 0x1821334A0
	private bool CheckHasStatusEffectByType(Frame frame, HashString typeId, EntityRef originEntity) { }

	// RVA: 0x2133770 Offset: 0x2131D70 VA: 0x182133770
	public FP GetValue(Frame frame, StatusEffectsVariable variable, CachedEntityData entityData, EntityVariableBase entityVariable) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void SetValue(Frame frame, StatusEffectsVariable variable, FP value) { }
}
