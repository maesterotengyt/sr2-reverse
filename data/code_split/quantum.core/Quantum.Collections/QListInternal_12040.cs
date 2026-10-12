// Namespace: Quantum.Collections
internal struct QListInternal // TypeDefIndex: 12040
{
	// Fields
	internal int _count; // 0x0
	internal QBuffer _items; // 0x4

	// Methods

	// RVA: -1 Offset: -1
	public static QListInternal* Allocate<T, THeap>(THeap heap, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC196A0 Offset: 0xC17CA0 VA: 0x180C196A0
	|-QListInternal.Allocate<ActionData, object>
	|-QListInternal.Allocate<ChildEntity, object>
	|-QListInternal.Allocate<RuntimeGameSpeedModifier, object>
	|
	|-RVA: 0xC196F0 Offset: 0xC17CF0 VA: 0x180C196F0
	|-QListInternal.Allocate<AnimationSpeedElement, object>
	|-QListInternal.Allocate<FPVector2, object>
	|-QListInternal.Allocate<HitEvent, object>
	|-QListInternal.Allocate<ScheduledBehaviour, object>
	|-QListInternal.Allocate<StatusEffectAttributeModifier, object>
	|
	|-RVA: 0xC19740 Offset: 0xC17D40 VA: 0x180C19740
	|-QListInternal.Allocate<EntityRef, object>
	|-QListInternal.Allocate<RuntimeMechanicTutorialGoal, object>
	|
	|-RVA: 0xC19790 Offset: 0xC17D90 VA: 0x180C19790
	|-QListInternal.Allocate<ExperienceEventData, object>
	|-QListInternal.Allocate<TargetStatePerEntity, object>
	|
	|-RVA: 0xC197E0 Offset: 0xC17DE0 VA: 0x180C197E0
	|-QListInternal.Allocate<GameEntityReference, object>
	|
	|-RVA: 0xC19830 Offset: 0xC17E30 VA: 0x180C19830
	|-QListInternal.Allocate<HitBox, object>
	|
	|-RVA: 0xC19880 Offset: 0xC17E80 VA: 0x180C19880
	|-QListInternal.Allocate<HurtBox, object>
	|
	|-RVA: 0xC19CE0 Offset: 0xC182E0 VA: 0x180C19CE0
	|-QListInternal.Allocate<int, object>
	|
	|-RVA: 0xC19D30 Offset: 0xC18330 VA: 0x180C19D30
	|-QListInternal.Allocate<ObjectVisibilityData, object>
	|-QListInternal.Allocate<SlotAttachmentData, object>
	|
	|-RVA: 0xC19FC0 Offset: 0xC185C0 VA: 0x180C19FC0
	|-QListInternal.Allocate<RuntimeStatusEffect, object>
	|
	|-RVA: 0xC1A010 Offset: 0xC18610 VA: 0x180C1A010
	|-QListInternal.Allocate<SFXToExecute, object>
	|
	|-RVA: 0xC1A060 Offset: 0xC18660 VA: 0x180C1A060
	|-QListInternal.Allocate<StageEntity, object>
	|
	|-RVA: 0xC19BE0 Offset: 0xC181E0 VA: 0x180C19BE0
	|-QListInternal.Allocate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QListInternal* Allocate<THeap>(THeap heap, int capacity, int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC19D80 Offset: 0xC18380 VA: 0x180C19D80
	|-QListInternal.Allocate<object>
	|
	|-RVA: 0xC198D0 Offset: 0xC17ED0 VA: 0x180C198D0
	|-QListInternal.Allocate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QListInternal* Init<THeap>(QListInternal* list, THeap heap, int capacity, int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1A1D0 Offset: 0xC187D0 VA: 0x180C1A1D0
	|-QListInternal.Init<object>
	|
	|-RVA: 0xC1A0B0 Offset: 0xC186B0 VA: 0x180C1A0B0
	|-QListInternal.Init<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22138F0 Offset: 0x2211EF0 VA: 0x1822138F0
	public static void Print(Ptr ptr, FramePrinter printer, Type elementType) { }

	// RVA: 0x2213B40 Offset: 0x2212140 VA: 0x182213B40
	public static void Serialize(Ptr* ptr, FrameSerializer serializer, int itemSize, FrameSerializer.Delegate itemSerializer) { }
}
