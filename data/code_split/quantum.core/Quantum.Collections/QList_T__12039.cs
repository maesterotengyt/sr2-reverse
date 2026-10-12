// Namespace: Quantum.Collections
[DefaultMember("Item")]
public struct QList<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 12039
{
	// Fields
	private QListInternal* _list; // 0x0
	private IFrameHeap _heap; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12522D0 Offset: 0x12508D0 VA: 0x1812522D0
	|-QList<ActionData>.get_Count
	|-QList<AnimationSpeedElement>.get_Count
	|-QList<ChildEntity>.get_Count
	|-QList<EntityRef>.get_Count
	|-QList<ExperienceEventData>.get_Count
	|-QList<FPVector2>.get_Count
	|-QList<GameEntityReference>.get_Count
	|-QList<HitBox>.get_Count
	|-QList<HitEvent>.get_Count
	|-QList<HurtBox>.get_Count
	|-QList<int>.get_Count
	|-QList<ObjectVisibilityData>.get_Count
	|-QList<RuntimeGameSpeedModifier>.get_Count
	|-QList<RuntimeMechanicTutorialGoal>.get_Count
	|-QList<RuntimeStatusEffect>.get_Count
	|-QList<SFXToExecute>.get_Count
	|-QList<ScheduledBehaviour>.get_Count
	|-QList<SlotAttachmentData>.get_Count
	|-QList<StageEntity>.get_Count
	|-QList<StatusEffectAttributeModifier>.get_Count
	|-QList<TargetStatePerEntity>.get_Count
	|-QList<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1252600 Offset: 0x1250C00 VA: 0x181252600
	|-QList<ActionData>.get_Item
	|
	|-RVA: 0x1252590 Offset: 0x1250B90 VA: 0x181252590
	|-QList<AnimationSpeedElement>.get_Item
	|
	|-RVA: 0x1252670 Offset: 0x1250C70 VA: 0x181252670
	|-QList<ChildEntity>.get_Item
	|
	|-RVA: 0x1252360 Offset: 0x1250960 VA: 0x181252360
	|-QList<EntityRef>.get_Item
	|
	|-RVA: 0x12523B0 Offset: 0x12509B0 VA: 0x1812523B0
	|-QList<ExperienceEventData>.get_Item
	|
	|-RVA: 0x12522F0 Offset: 0x12508F0 VA: 0x1812522F0
	|-QList<FPVector2>.get_Item
	|
	|-RVA: 0x1252440 Offset: 0x1250A40 VA: 0x181252440
	|-QList<GameEntityReference>.get_Item
	|
	|-RVA: 0x12524D0 Offset: 0x1250AD0 VA: 0x1812524D0
	|-QList<HitBox>.get_Item
	|
	|-RVA: 0x125E030 Offset: 0x125C630 VA: 0x18125E030
	|-QList<HitEvent>.get_Item
	|
	|-RVA: 0x125DE50 Offset: 0x125C450 VA: 0x18125DE50
	|-QList<HurtBox>.get_Item
	|
	|-RVA: 0x125D8C0 Offset: 0x125BEC0 VA: 0x18125D8C0
	|-QList<int>.get_Item
	|
	|-RVA: 0x125DFC0 Offset: 0x125C5C0 VA: 0x18125DFC0
	|-QList<ObjectVisibilityData>.get_Item
	|
	|-RVA: 0x125DDE0 Offset: 0x125C3E0 VA: 0x18125DDE0
	|-QList<RuntimeGameSpeedModifier>.get_Item
	|
	|-RVA: 0x125D910 Offset: 0x125BF10 VA: 0x18125D910
	|-QList<RuntimeMechanicTutorialGoal>.get_Item
	|
	|-RVA: 0x125DF40 Offset: 0x125C540 VA: 0x18125DF40
	|-QList<RuntimeStatusEffect>.get_Item
	|
	|-RVA: 0x125DC90 Offset: 0x125C290 VA: 0x18125DC90
	|-QList<SFXToExecute>.get_Item
	|
	|-RVA: 0x125DD70 Offset: 0x125C370 VA: 0x18125DD70
	|-QList<ScheduledBehaviour>.get_Item
	|
	|-RVA: 0x125DB60 Offset: 0x125C160 VA: 0x18125DB60
	|-QList<SlotAttachmentData>.get_Item
	|
	|-RVA: 0x125DBD0 Offset: 0x125C1D0 VA: 0x18125DBD0
	|-QList<StageEntity>.get_Item
	|
	|-RVA: 0x125D9F0 Offset: 0x125BFF0 VA: 0x18125D9F0
	|-QList<StatusEffectAttributeModifier>.get_Item
	|
	|-RVA: 0x125D960 Offset: 0x125BF60 VA: 0x18125D960
	|-QList<TargetStatePerEntity>.get_Item
	|
	|-RVA: 0x125DA60 Offset: 0x125C060 VA: 0x18125DA60
	|-QList<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1252AE0 Offset: 0x12510E0 VA: 0x181252AE0
	|-QList<ActionData>.set_Item
	|
	|-RVA: 0x1252DA0 Offset: 0x12513A0 VA: 0x181252DA0
	|-QList<AnimationSpeedElement>.set_Item
	|
	|-RVA: 0x1252C60 Offset: 0x1251260 VA: 0x181252C60
	|-QList<ChildEntity>.set_Item
	|
	|-RVA: 0x1252D40 Offset: 0x1251340 VA: 0x181252D40
	|-QList<EntityRef>.set_Item
	|
	|-RVA: 0x1252E00 Offset: 0x1251400 VA: 0x181252E00
	|-QList<ExperienceEventData>.set_Item
	|
	|-RVA: 0x1252B40 Offset: 0x1251140 VA: 0x181252B40
	|-QList<FPVector2>.set_Item
	|
	|-RVA: 0x1252CC0 Offset: 0x12512C0 VA: 0x181252CC0
	|-QList<GameEntityReference>.set_Item
	|
	|-RVA: 0x1252BA0 Offset: 0x12511A0 VA: 0x181252BA0
	|-QList<HitBox>.set_Item
	|
	|-RVA: 0x125E8E0 Offset: 0x125CEE0 VA: 0x18125E8E0
	|-QList<HitEvent>.set_Item
	|
	|-RVA: 0x125E800 Offset: 0x125CE00 VA: 0x18125E800
	|-QList<HurtBox>.set_Item
	|
	|-RVA: 0x125EBC0 Offset: 0x125D1C0 VA: 0x18125EBC0
	|-QList<int>.set_Item
	|
	|-RVA: 0x125E940 Offset: 0x125CF40 VA: 0x18125E940
	|-QList<ObjectVisibilityData>.set_Item
	|
	|-RVA: 0x125EB60 Offset: 0x125D160 VA: 0x18125EB60
	|-QList<RuntimeGameSpeedModifier>.set_Item
	|
	|-RVA: 0x125E7A0 Offset: 0x125CDA0 VA: 0x18125E7A0
	|-QList<RuntimeMechanicTutorialGoal>.set_Item
	|
	|-RVA: 0x125ECE0 Offset: 0x125D2E0 VA: 0x18125ECE0
	|-QList<RuntimeStatusEffect>.set_Item
	|
	|-RVA: 0x125E9A0 Offset: 0x125CFA0 VA: 0x18125E9A0
	|-QList<SFXToExecute>.set_Item
	|
	|-RVA: 0x125EC80 Offset: 0x125D280 VA: 0x18125EC80
	|-QList<ScheduledBehaviour>.set_Item
	|
	|-RVA: 0x125EE80 Offset: 0x125D480 VA: 0x18125EE80
	|-QList<SlotAttachmentData>.set_Item
	|
	|-RVA: 0x125EDD0 Offset: 0x125D3D0 VA: 0x18125EDD0
	|-QList<StageEntity>.set_Item
	|
	|-RVA: 0x125EC20 Offset: 0x125D220 VA: 0x18125EC20
	|-QList<StatusEffectAttributeModifier>.set_Item
	|
	|-RVA: 0x125ED50 Offset: 0x125D350 VA: 0x18125ED50
	|-QList<TargetStatePerEntity>.set_Item
	|
	|-RVA: 0x125EA70 Offset: 0x125D070 VA: 0x18125EA70
	|-QList<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IFrameHeap heap, QListInternal* list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12522A0 Offset: 0x12508A0 VA: 0x1812522A0
	|-QList<ActionData>..ctor
	|-QList<AnimationSpeedElement>..ctor
	|-QList<ChildEntity>..ctor
	|-QList<EntityRef>..ctor
	|-QList<ExperienceEventData>..ctor
	|-QList<FPVector2>..ctor
	|-QList<GameEntityReference>..ctor
	|-QList<HitBox>..ctor
	|-QList<HitEvent>..ctor
	|-QList<HurtBox>..ctor
	|-QList<int>..ctor
	|-QList<ObjectVisibilityData>..ctor
	|-QList<RuntimeGameSpeedModifier>..ctor
	|-QList<RuntimeMechanicTutorialGoal>..ctor
	|-QList<RuntimeStatusEffect>..ctor
	|-QList<SFXToExecute>..ctor
	|-QList<ScheduledBehaviour>..ctor
	|-QList<SlotAttachmentData>..ctor
	|-QList<StageEntity>..ctor
	|-QList<StatusEffectAttributeModifier>..ctor
	|-QList<TargetStatePerEntity>..ctor
	|-QList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void Free() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124D170 Offset: 0x124B770 VA: 0x18124D170
	|-QList<ActionData>.Free
	|
	|-RVA: 0x124D4B0 Offset: 0x124BAB0 VA: 0x18124D4B0
	|-QList<AnimationSpeedElement>.Free
	|
	|-RVA: 0x124D3E0 Offset: 0x124B9E0 VA: 0x18124D3E0
	|-QList<ChildEntity>.Free
	|
	|-RVA: 0x124CFD0 Offset: 0x124B5D0 VA: 0x18124CFD0
	|-QList<EntityRef>.Free
	|
	|-RVA: 0x124D0A0 Offset: 0x124B6A0 VA: 0x18124D0A0
	|-QList<ExperienceEventData>.Free
	|
	|-RVA: 0x124D240 Offset: 0x124B840 VA: 0x18124D240
	|-QList<FPVector2>.Free
	|
	|-RVA: 0x124D310 Offset: 0x124B910 VA: 0x18124D310
	|-QList<GameEntityReference>.Free
	|
	|-RVA: 0x124D580 Offset: 0x124BB80 VA: 0x18124D580
	|-QList<HitBox>.Free
	|
	|-RVA: 0x12549A0 Offset: 0x1252FA0 VA: 0x1812549A0
	|-QList<HitEvent>.Free
	|
	|-RVA: 0x1254E80 Offset: 0x1253480 VA: 0x181254E80
	|-QList<HurtBox>.Free
	|
	|-RVA: 0x1254800 Offset: 0x1252E00 VA: 0x181254800
	|-QList<int>.Free
	|
	|-RVA: 0x1254590 Offset: 0x1252B90 VA: 0x181254590
	|-QList<ObjectVisibilityData>.Free
	|
	|-RVA: 0x1254CE0 Offset: 0x12532E0 VA: 0x181254CE0
	|-QList<RuntimeGameSpeedModifier>.Free
	|
	|-RVA: 0x1254C10 Offset: 0x1253210 VA: 0x181254C10
	|-QList<RuntimeMechanicTutorialGoal>.Free
	|
	|-RVA: 0x1254730 Offset: 0x1252D30 VA: 0x181254730
	|-QList<RuntimeStatusEffect>.Free
	|
	|-RVA: 0x1254DB0 Offset: 0x12533B0 VA: 0x181254DB0
	|-QList<SFXToExecute>.Free
	|
	|-RVA: 0x1254F50 Offset: 0x1253550 VA: 0x181254F50
	|-QList<ScheduledBehaviour>.Free
	|
	|-RVA: 0x1254B40 Offset: 0x1253140 VA: 0x181254B40
	|-QList<SlotAttachmentData>.Free
	|
	|-RVA: 0x1254A70 Offset: 0x1253070 VA: 0x181254A70
	|-QList<StageEntity>.Free
	|
	|-RVA: 0x1255020 Offset: 0x1253620 VA: 0x181255020
	|-QList<StatusEffectAttributeModifier>.Free
	|
	|-RVA: 0x1254660 Offset: 0x1252C60 VA: 0x181254660
	|-QList<TargetStatePerEntity>.Free
	|
	|-RVA: 0x12548D0 Offset: 0x1252ED0 VA: 0x1812548D0
	|-QList<__Il2CppFullySharedGenericStructType>.Free
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124CF70 Offset: 0x124B570 VA: 0x18124CF70
	|-QList<ActionData>.Clear
	|-QList<AnimationSpeedElement>.Clear
	|-QList<ChildEntity>.Clear
	|-QList<EntityRef>.Clear
	|-QList<ExperienceEventData>.Clear
	|-QList<FPVector2>.Clear
	|-QList<GameEntityReference>.Clear
	|-QList<HitBox>.Clear
	|-QList<HitEvent>.Clear
	|-QList<HurtBox>.Clear
	|-QList<int>.Clear
	|-QList<ObjectVisibilityData>.Clear
	|-QList<RuntimeGameSpeedModifier>.Clear
	|-QList<RuntimeMechanicTutorialGoal>.Clear
	|-QList<RuntimeStatusEffect>.Clear
	|-QList<SFXToExecute>.Clear
	|-QList<ScheduledBehaviour>.Clear
	|-QList<SlotAttachmentData>.Clear
	|-QList<StageEntity>.Clear
	|-QList<StatusEffectAttributeModifier>.Clear
	|-QList<TargetStatePerEntity>.Clear
	|-QList<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124C320 Offset: 0x124A920 VA: 0x18124C320
	|-QList<ActionData>.Add
	|
	|-RVA: 0x124C610 Offset: 0x124AC10 VA: 0x18124C610
	|-QList<AnimationSpeedElement>.Add
	|
	|-RVA: 0x124C910 Offset: 0x124AF10 VA: 0x18124C910
	|-QList<ChildEntity>.Add
	|
	|-RVA: 0x124C4A0 Offset: 0x124AAA0 VA: 0x18124C4A0
	|-QList<EntityRef>.Add
	|
	|-RVA: 0x124C780 Offset: 0x124AD80 VA: 0x18124C780
	|-QList<ExperienceEventData>.Add
	|
	|-RVA: 0x124CC60 Offset: 0x124B260 VA: 0x18124CC60
	|-QList<FPVector2>.Add
	|
	|-RVA: 0x124CDD0 Offset: 0x124B3D0 VA: 0x18124CDD0
	|-QList<GameEntityReference>.Add
	|
	|-RVA: 0x124CA90 Offset: 0x124B090 VA: 0x18124CA90
	|-QList<HitBox>.Add
	|
	|-RVA: 0x1253420 Offset: 0x1251A20 VA: 0x181253420
	|-QList<HitEvent>.Add
	|
	|-RVA: 0x1253B90 Offset: 0x1252190 VA: 0x181253B90
	|-QList<HurtBox>.Add
	|
	|-RVA: 0x1253D90 Offset: 0x1252390 VA: 0x181253D90
	|-QList<int>.Add
	|
	|-RVA: 0x1253A10 Offset: 0x1252010 VA: 0x181253A10
	|-QList<ObjectVisibilityData>.Add
	|
	|-RVA: 0x1254070 Offset: 0x1252670 VA: 0x181254070
	|-QList<RuntimeGameSpeedModifier>.Add
	|
	|-RVA: 0x1253590 Offset: 0x1251B90 VA: 0x181253590
	|-QList<RuntimeMechanicTutorialGoal>.Add
	|
	|-RVA: 0x1253700 Offset: 0x1251D00 VA: 0x181253700
	|-QList<RuntimeStatusEffect>.Add
	|
	|-RVA: 0x1252E80 Offset: 0x1251480 VA: 0x181252E80
	|-QList<SFXToExecute>.Add
	|
	|-RVA: 0x1254420 Offset: 0x1252A20 VA: 0x181254420
	|-QList<ScheduledBehaviour>.Add
	|
	|-RVA: 0x1253890 Offset: 0x1251E90 VA: 0x181253890
	|-QList<SlotAttachmentData>.Add
	|
	|-RVA: 0x1253260 Offset: 0x1251860 VA: 0x181253260
	|-QList<StageEntity>.Add
	|
	|-RVA: 0x1253F00 Offset: 0x1252500 VA: 0x181253F00
	|-QList<StatusEffectAttributeModifier>.Add
	|
	|-RVA: 0x12530D0 Offset: 0x12516D0 VA: 0x1812530D0
	|-QList<TargetStatePerEntity>.Add
	|
	|-RVA: 0x12541F0 Offset: 0x12527F0 VA: 0x1812541F0
	|-QList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1250CF0 Offset: 0x124F2F0 VA: 0x181250CF0
	|-QList<ActionData>.SetCapacity
	|
	|-RVA: 0x1250AE0 Offset: 0x124F0E0 VA: 0x181250AE0
	|-QList<AnimationSpeedElement>.SetCapacity
	|
	|-RVA: 0x1251110 Offset: 0x124F710 VA: 0x181251110
	|-QList<ChildEntity>.SetCapacity
	|
	|-RVA: 0x1250F00 Offset: 0x124F500 VA: 0x181250F00
	|-QList<EntityRef>.SetCapacity
	|
	|-RVA: 0x1251740 Offset: 0x124FD40 VA: 0x181251740
	|-QList<ExperienceEventData>.SetCapacity
	|
	|-RVA: 0x12508D0 Offset: 0x124EED0 VA: 0x1812508D0
	|-QList<FPVector2>.SetCapacity
	|
	|-RVA: 0x1251530 Offset: 0x124FB30 VA: 0x181251530
	|-QList<GameEntityReference>.SetCapacity
	|
	|-RVA: 0x1251320 Offset: 0x124F920 VA: 0x181251320
	|-QList<HitBox>.SetCapacity
	|
	|-RVA: 0x125B3B0 Offset: 0x12599B0 VA: 0x18125B3B0
	|-QList<HitEvent>.SetCapacity
	|
	|-RVA: 0x125C220 Offset: 0x125A820 VA: 0x18125C220
	|-QList<HurtBox>.SetCapacity
	|
	|-RVA: 0x125AD80 Offset: 0x1259380 VA: 0x18125AD80
	|-QList<int>.SetCapacity
	|
	|-RVA: 0x125B5C0 Offset: 0x1259BC0 VA: 0x18125B5C0
	|-QList<ObjectVisibilityData>.SetCapacity
	|
	|-RVA: 0x125C010 Offset: 0x125A610 VA: 0x18125C010
	|-QList<RuntimeGameSpeedModifier>.SetCapacity
	|
	|-RVA: 0x125AF90 Offset: 0x1259590 VA: 0x18125AF90
	|-QList<RuntimeMechanicTutorialGoal>.SetCapacity
	|
	|-RVA: 0x125BBF0 Offset: 0x125A1F0 VA: 0x18125BBF0
	|-QList<RuntimeStatusEffect>.SetCapacity
	|
	|-RVA: 0x125AB70 Offset: 0x1259170 VA: 0x18125AB70
	|-QList<SFXToExecute>.SetCapacity
	|
	|-RVA: 0x125BE00 Offset: 0x125A400 VA: 0x18125BE00
	|-QList<ScheduledBehaviour>.SetCapacity
	|
	|-RVA: 0x125B7D0 Offset: 0x1259DD0 VA: 0x18125B7D0
	|-QList<SlotAttachmentData>.SetCapacity
	|
	|-RVA: 0x125B1A0 Offset: 0x12597A0 VA: 0x18125B1A0
	|-QList<StageEntity>.SetCapacity
	|
	|-RVA: 0x125C640 Offset: 0x125AC40 VA: 0x18125C640
	|-QList<StatusEffectAttributeModifier>.SetCapacity
	|
	|-RVA: 0x125C430 Offset: 0x125AA30 VA: 0x18125C430
	|-QList<TargetStatePerEntity>.SetCapacity
	|
	|-RVA: 0x125B9E0 Offset: 0x1259FE0 VA: 0x18125B9E0
	|-QList<__Il2CppFullySharedGenericStructType>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	public T* GetPointer(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124DD60 Offset: 0x124C360 VA: 0x18124DD60
	|-QList<ActionData>.GetPointer
	|
	|-RVA: 0x124D9A0 Offset: 0x124BFA0 VA: 0x18124D9A0
	|-QList<AnimationSpeedElement>.GetPointer
	|
	|-RVA: 0x124DB80 Offset: 0x124C180 VA: 0x18124DB80
	|-QList<ChildEntity>.GetPointer
	|
	|-RVA: 0x124DC70 Offset: 0x124C270 VA: 0x18124DC70
	|-QList<EntityRef>.GetPointer
	|
	|-RVA: 0x124D8B0 Offset: 0x124BEB0 VA: 0x18124D8B0
	|-QList<ExperienceEventData>.GetPointer
	|
	|-RVA: 0x124DA90 Offset: 0x124C090 VA: 0x18124DA90
	|-QList<FPVector2>.GetPointer
	|
	|-RVA: 0x124D7C0 Offset: 0x124BDC0 VA: 0x18124D7C0
	|-QList<GameEntityReference>.GetPointer
	|
	|-RVA: 0x124DE50 Offset: 0x124C450 VA: 0x18124DE50
	|-QList<HitBox>.GetPointer
	|
	|-RVA: 0x1255900 Offset: 0x1253F00 VA: 0x181255900
	|-QList<HitEvent>.GetPointer
	|
	|-RVA: 0x1255450 Offset: 0x1253A50 VA: 0x181255450
	|-QList<HurtBox>.GetPointer
	|
	|-RVA: 0x1255720 Offset: 0x1253D20 VA: 0x181255720
	|-QList<int>.GetPointer
	|
	|-RVA: 0x1255810 Offset: 0x1253E10 VA: 0x181255810
	|-QList<ObjectVisibilityData>.GetPointer
	|
	|-RVA: 0x1255540 Offset: 0x1253B40 VA: 0x181255540
	|-QList<RuntimeGameSpeedModifier>.GetPointer
	|
	|-RVA: 0x1255180 Offset: 0x1253780 VA: 0x181255180
	|-QList<RuntimeMechanicTutorialGoal>.GetPointer
	|
	|-RVA: 0x1255AE0 Offset: 0x12540E0 VA: 0x181255AE0
	|-QList<RuntimeStatusEffect>.GetPointer
	|
	|-RVA: 0x1255360 Offset: 0x1253960 VA: 0x181255360
	|-QList<SFXToExecute>.GetPointer
	|
	|-RVA: 0x1255DB0 Offset: 0x12543B0 VA: 0x181255DB0
	|-QList<ScheduledBehaviour>.GetPointer
	|
	|-RVA: 0x12559F0 Offset: 0x1253FF0 VA: 0x1812559F0
	|-QList<SlotAttachmentData>.GetPointer
	|
	|-RVA: 0x1255BD0 Offset: 0x12541D0 VA: 0x181255BD0
	|-QList<StageEntity>.GetPointer
	|
	|-RVA: 0x1255630 Offset: 0x1253C30 VA: 0x181255630
	|-QList<StatusEffectAttributeModifier>.GetPointer
	|
	|-RVA: 0x1255CC0 Offset: 0x12542C0 VA: 0x181255CC0
	|-QList<TargetStatePerEntity>.GetPointer
	|
	|-RVA: 0x1255270 Offset: 0x1253870 VA: 0x181255270
	|-QList<__Il2CppFullySharedGenericStructType>.GetPointer
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124F860 Offset: 0x124DE60 VA: 0x18124F860
	|-QList<ActionData>.RemoveAt
	|
	|-RVA: 0x124FA80 Offset: 0x124E080 VA: 0x18124FA80
	|-QList<AnimationSpeedElement>.RemoveAt
	|
	|-RVA: 0x124FCA0 Offset: 0x124E2A0 VA: 0x18124FCA0
	|-QList<ChildEntity>.RemoveAt
	|
	|-RVA: 0x124FDB0 Offset: 0x124E3B0 VA: 0x18124FDB0
	|-QList<EntityRef>.RemoveAt
	|
	|-RVA: 0x124FEC0 Offset: 0x124E4C0 VA: 0x18124FEC0
	|-QList<ExperienceEventData>.RemoveAt
	|
	|-RVA: 0x124FFD0 Offset: 0x124E5D0 VA: 0x18124FFD0
	|-QList<FPVector2>.RemoveAt
	|
	|-RVA: 0x124FB90 Offset: 0x124E190 VA: 0x18124FB90
	|-QList<GameEntityReference>.RemoveAt
	|
	|-RVA: 0x124F970 Offset: 0x124DF70 VA: 0x18124F970
	|-QList<HitBox>.RemoveAt
	|
	|-RVA: 0x1259950 Offset: 0x1257F50 VA: 0x181259950
	|-QList<HitEvent>.RemoveAt
	|
	|-RVA: 0x1259A60 Offset: 0x1258060 VA: 0x181259A60
	|-QList<HurtBox>.RemoveAt
	|
	|-RVA: 0x1258FC0 Offset: 0x12575C0 VA: 0x181258FC0
	|-QList<int>.RemoveAt
	|
	|-RVA: 0x1258DA0 Offset: 0x12573A0 VA: 0x181258DA0
	|-QList<ObjectVisibilityData>.RemoveAt
	|
	|-RVA: 0x1259840 Offset: 0x1257E40 VA: 0x181259840
	|-QList<RuntimeGameSpeedModifier>.RemoveAt
	|
	|-RVA: 0x1259730 Offset: 0x1257D30 VA: 0x181259730
	|-QList<RuntimeMechanicTutorialGoal>.RemoveAt
	|
	|-RVA: 0x12591E0 Offset: 0x12577E0 VA: 0x1812591E0
	|-QList<RuntimeStatusEffect>.RemoveAt
	|
	|-RVA: 0x1258EB0 Offset: 0x12574B0 VA: 0x181258EB0
	|-QList<SFXToExecute>.RemoveAt
	|
	|-RVA: 0x12590D0 Offset: 0x12576D0 VA: 0x1812590D0
	|-QList<ScheduledBehaviour>.RemoveAt
	|
	|-RVA: 0x1259620 Offset: 0x1257C20 VA: 0x181259620
	|-QList<SlotAttachmentData>.RemoveAt
	|
	|-RVA: 0x12592F0 Offset: 0x12578F0 VA: 0x1812592F0
	|-QList<StageEntity>.RemoveAt
	|
	|-RVA: 0x1259B70 Offset: 0x1258170 VA: 0x181259B70
	|-QList<StatusEffectAttributeModifier>.RemoveAt
	|
	|-RVA: 0x1259400 Offset: 0x1257A00 VA: 0x181259400
	|-QList<TargetStatePerEntity>.RemoveAt
	|
	|-RVA: 0x1259510 Offset: 0x1257B10 VA: 0x181259510
	|-QList<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124E740 Offset: 0x124CD40 VA: 0x18124E740
	|-QList<ActionData>.IndexOf
	|
	|-RVA: 0x124F6A0 Offset: 0x124DCA0 VA: 0x18124F6A0
	|-QList<AnimationSpeedElement>.IndexOf
	|
	|-RVA: 0x124EED0 Offset: 0x124D4D0 VA: 0x18124EED0
	|-QList<ChildEntity>.IndexOf
	|
	|-RVA: 0x124ED40 Offset: 0x124D340 VA: 0x18124ED40
	|-QList<EntityRef>.IndexOf
	|
	|-RVA: 0x124EAC0 Offset: 0x124D0C0 VA: 0x18124EAC0
	|-QList<ExperienceEventData>.IndexOf
	|
	|-RVA: 0x124E930 Offset: 0x124CF30 VA: 0x18124E930
	|-QList<FPVector2>.IndexOf
	|
	|-RVA: 0x124F410 Offset: 0x124DA10 VA: 0x18124F410
	|-QList<GameEntityReference>.IndexOf
	|
	|-RVA: 0x124F0C0 Offset: 0x124D6C0 VA: 0x18124F0C0
	|-QList<HitBox>.IndexOf
	|
	|-RVA: 0x1258770 Offset: 0x1256D70 VA: 0x181258770
	|-QList<HitEvent>.IndexOf
	|
	|-RVA: 0x1257730 Offset: 0x1255D30 VA: 0x181257730
	|-QList<HurtBox>.IndexOf
	|
	|-RVA: 0x12572B0 Offset: 0x12558B0 VA: 0x1812572B0
	|-QList<int>.IndexOf
	|
	|-RVA: 0x1258930 Offset: 0x1256F30 VA: 0x181258930
	|-QList<ObjectVisibilityData>.IndexOf
	|
	|-RVA: 0x1258200 Offset: 0x1256800 VA: 0x181258200
	|-QList<RuntimeGameSpeedModifier>.IndexOf
	|
	|-RVA: 0x12583F0 Offset: 0x12569F0 VA: 0x1812583F0
	|-QList<RuntimeMechanicTutorialGoal>.IndexOf
	|
	|-RVA: 0x1256D70 Offset: 0x1255370 VA: 0x181256D70
	|-QList<RuntimeStatusEffect>.IndexOf
	|
	|-RVA: 0x1256FA0 Offset: 0x12555A0 VA: 0x181256FA0
	|-QList<SFXToExecute>.IndexOf
	|
	|-RVA: 0x1258040 Offset: 0x1256640 VA: 0x181258040
	|-QList<ScheduledBehaviour>.IndexOf
	|
	|-RVA: 0x1257E50 Offset: 0x1256450 VA: 0x181257E50
	|-QList<SlotAttachmentData>.IndexOf
	|
	|-RVA: 0x1257AF0 Offset: 0x12560F0 VA: 0x181257AF0
	|-QList<StageEntity>.IndexOf
	|
	|-RVA: 0x12585B0 Offset: 0x1256BB0 VA: 0x1812585B0
	|-QList<StatusEffectAttributeModifier>.IndexOf
	|
	|-RVA: 0x1258B20 Offset: 0x1257120 VA: 0x181258B20
	|-QList<TargetStatePerEntity>.IndexOf
	|
	|-RVA: 0x1257430 Offset: 0x1255A30 VA: 0x181257430
	|-QList<__Il2CppFullySharedGenericStructType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1250330 Offset: 0x124E930 VA: 0x181250330
	|-QList<ActionData>.Remove
	|
	|-RVA: 0x12506D0 Offset: 0x124ECD0 VA: 0x1812506D0
	|-QList<AnimationSpeedElement>.Remove
	|
	|-RVA: 0x12505E0 Offset: 0x124EBE0 VA: 0x1812505E0
	|-QList<ChildEntity>.Remove
	|
	|-RVA: 0x1250500 Offset: 0x124EB00 VA: 0x181250500
	|-QList<EntityRef>.Remove
	|
	|-RVA: 0x12507C0 Offset: 0x124EDC0 VA: 0x1812507C0
	|-QList<ExperienceEventData>.Remove
	|
	|-RVA: 0x1250420 Offset: 0x124EA20 VA: 0x181250420
	|-QList<FPVector2>.Remove
	|
	|-RVA: 0x12500E0 Offset: 0x124E6E0 VA: 0x1812500E0
	|-QList<GameEntityReference>.Remove
	|
	|-RVA: 0x12501F0 Offset: 0x124E7F0 VA: 0x1812501F0
	|-QList<HitBox>.Remove
	|
	|-RVA: 0x1259DD0 Offset: 0x12583D0 VA: 0x181259DD0
	|-QList<HitEvent>.Remove
	|
	|-RVA: 0x125A4C0 Offset: 0x1258AC0 VA: 0x18125A4C0
	|-QList<HurtBox>.Remove
	|
	|-RVA: 0x125A620 Offset: 0x1258C20 VA: 0x18125A620
	|-QList<int>.Remove
	|
	|-RVA: 0x125A290 Offset: 0x1258890 VA: 0x18125A290
	|-QList<ObjectVisibilityData>.Remove
	|
	|-RVA: 0x1259FD0 Offset: 0x12585D0 VA: 0x181259FD0
	|-QList<RuntimeGameSpeedModifier>.Remove
	|
	|-RVA: 0x125A1B0 Offset: 0x12587B0 VA: 0x18125A1B0
	|-QList<RuntimeMechanicTutorialGoal>.Remove
	|
	|-RVA: 0x125A890 Offset: 0x1258E90 VA: 0x18125A890
	|-QList<RuntimeStatusEffect>.Remove
	|
	|-RVA: 0x1259C80 Offset: 0x1258280 VA: 0x181259C80
	|-QList<SFXToExecute>.Remove
	|
	|-RVA: 0x125A990 Offset: 0x1258F90 VA: 0x18125A990
	|-QList<ScheduledBehaviour>.Remove
	|
	|-RVA: 0x125AA80 Offset: 0x1259080 VA: 0x18125AA80
	|-QList<SlotAttachmentData>.Remove
	|
	|-RVA: 0x125A380 Offset: 0x1258980 VA: 0x18125A380
	|-QList<StageEntity>.Remove
	|
	|-RVA: 0x125A0C0 Offset: 0x12586C0 VA: 0x18125A0C0
	|-QList<StatusEffectAttributeModifier>.Remove
	|
	|-RVA: 0x1259EC0 Offset: 0x12584C0 VA: 0x181259EC0
	|-QList<TargetStatePerEntity>.Remove
	|
	|-RVA: 0x125A700 Offset: 0x1258D00 VA: 0x18125A700
	|-QList<__Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public QList.Iterator<T> GetIterator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124D6C0 Offset: 0x124BCC0 VA: 0x18124D6C0
	|-QList<ActionData>.GetIterator
	|-QList<AnimationSpeedElement>.GetIterator
	|-QList<ChildEntity>.GetIterator
	|-QList<EntityRef>.GetIterator
	|-QList<ExperienceEventData>.GetIterator
	|-QList<FPVector2>.GetIterator
	|-QList<GameEntityReference>.GetIterator
	|-QList<HitBox>.GetIterator
	|-QList<HitEvent>.GetIterator
	|-QList<HurtBox>.GetIterator
	|-QList<int>.GetIterator
	|-QList<ObjectVisibilityData>.GetIterator
	|-QList<RuntimeGameSpeedModifier>.GetIterator
	|-QList<RuntimeMechanicTutorialGoal>.GetIterator
	|-QList<RuntimeStatusEffect>.GetIterator
	|-QList<SFXToExecute>.GetIterator
	|-QList<ScheduledBehaviour>.GetIterator
	|-QList<SlotAttachmentData>.GetIterator
	|-QList<StageEntity>.GetIterator
	|-QList<StatusEffectAttributeModifier>.GetIterator
	|-QList<TargetStatePerEntity>.GetIterator
	|-QList<__Il2CppFullySharedGenericStructType>.GetIterator
	*/

	// RVA: -1 Offset: -1
	private void Set(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1251A30 Offset: 0x1250030 VA: 0x181251A30
	|-QList<ActionData>.Set
	|
	|-RVA: 0x1251E40 Offset: 0x1250440 VA: 0x181251E40
	|-QList<AnimationSpeedElement>.Set
	|
	|-RVA: 0x1251D50 Offset: 0x1250350 VA: 0x181251D50
	|-QList<ChildEntity>.Set
	|
	|-RVA: 0x1251950 Offset: 0x124FF50 VA: 0x181251950
	|-QList<EntityRef>.Set
	|
	|-RVA: 0x1251F20 Offset: 0x1250520 VA: 0x181251F20
	|-QList<ExperienceEventData>.Set
	|
	|-RVA: 0x1251C70 Offset: 0x1250270 VA: 0x181251C70
	|-QList<FPVector2>.Set
	|
	|-RVA: 0x1252030 Offset: 0x1250630 VA: 0x181252030
	|-QList<GameEntityReference>.Set
	|
	|-RVA: 0x1251B20 Offset: 0x1250120 VA: 0x181251B20
	|-QList<HitBox>.Set
	|
	|-RVA: 0x125D660 Offset: 0x125BC60 VA: 0x18125D660
	|-QList<HitEvent>.Set
	|
	|-RVA: 0x125CD50 Offset: 0x125B350 VA: 0x18125CD50
	|-QList<HurtBox>.Set
	|
	|-RVA: 0x125CB80 Offset: 0x125B180 VA: 0x18125CB80
	|-QList<int>.Set
	|
	|-RVA: 0x125CA90 Offset: 0x125B090 VA: 0x18125CA90
	|-QList<ObjectVisibilityData>.Set
	|
	|-RVA: 0x125CC60 Offset: 0x125B260 VA: 0x18125CC60
	|-QList<RuntimeGameSpeedModifier>.Set
	|
	|-RVA: 0x125C9B0 Offset: 0x125AFB0 VA: 0x18125C9B0
	|-QList<RuntimeMechanicTutorialGoal>.Set
	|
	|-RVA: 0x125D480 Offset: 0x125BA80 VA: 0x18125D480
	|-QList<RuntimeStatusEffect>.Set
	|
	|-RVA: 0x125C850 Offset: 0x125AE50 VA: 0x18125C850
	|-QList<SFXToExecute>.Set
	|
	|-RVA: 0x125CED0 Offset: 0x125B4D0 VA: 0x18125CED0
	|-QList<ScheduledBehaviour>.Set
	|
	|-RVA: 0x125D570 Offset: 0x125BB70 VA: 0x18125D570
	|-QList<SlotAttachmentData>.Set
	|
	|-RVA: 0x125D1A0 Offset: 0x125B7A0 VA: 0x18125D1A0
	|-QList<StageEntity>.Set
	|
	|-RVA: 0x125CFB0 Offset: 0x125B5B0 VA: 0x18125CFB0
	|-QList<StatusEffectAttributeModifier>.Set
	|
	|-RVA: 0x125D090 Offset: 0x125B690 VA: 0x18125D090
	|-QList<TargetStatePerEntity>.Set
	|
	|-RVA: 0x125D2E0 Offset: 0x125B8E0 VA: 0x18125D2E0
	|-QList<__Il2CppFullySharedGenericStructType>.Set
	*/

	// RVA: -1 Offset: -1
	private T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124E180 Offset: 0x124C780 VA: 0x18124E180
	|-QList<ActionData>.Get
	|
	|-RVA: 0x124E470 Offset: 0x124CA70 VA: 0x18124E470
	|-QList<AnimationSpeedElement>.Get
	|
	|-RVA: 0x124E270 Offset: 0x124C870 VA: 0x18124E270
	|-QList<ChildEntity>.Get
	|
	|-RVA: 0x124DF40 Offset: 0x124C540 VA: 0x18124DF40
	|-QList<EntityRef>.Get
	|
	|-RVA: 0x124E550 Offset: 0x124CB50 VA: 0x18124E550
	|-QList<ExperienceEventData>.Get
	|
	|-RVA: 0x124E660 Offset: 0x124CC60 VA: 0x18124E660
	|-QList<FPVector2>.Get
	|
	|-RVA: 0x124E360 Offset: 0x124C960 VA: 0x18124E360
	|-QList<GameEntityReference>.Get
	|
	|-RVA: 0x124E030 Offset: 0x124C630 VA: 0x18124E030
	|-QList<HitBox>.Get
	|
	|-RVA: 0x1256500 Offset: 0x1254B00 VA: 0x181256500
	|-QList<HitEvent>.Get
	|
	|-RVA: 0x1256820 Offset: 0x1254E20 VA: 0x181256820
	|-QList<HurtBox>.Get
	|
	|-RVA: 0x1256990 Offset: 0x1254F90 VA: 0x181256990
	|-QList<int>.Get
	|
	|-RVA: 0x1255F80 Offset: 0x1254580 VA: 0x181255F80
	|-QList<ObjectVisibilityData>.Get
	|
	|-RVA: 0x1256150 Offset: 0x1254750 VA: 0x181256150
	|-QList<RuntimeGameSpeedModifier>.Get
	|
	|-RVA: 0x1256C80 Offset: 0x1255280 VA: 0x181256C80
	|-QList<RuntimeMechanicTutorialGoal>.Get
	|
	|-RVA: 0x1256720 Offset: 0x1254D20 VA: 0x181256720
	|-QList<RuntimeStatusEffect>.Get
	|
	|-RVA: 0x12563A0 Offset: 0x12549A0 VA: 0x1812563A0
	|-QList<SFXToExecute>.Get
	|
	|-RVA: 0x1256070 Offset: 0x1254670 VA: 0x181256070
	|-QList<ScheduledBehaviour>.Get
	|
	|-RVA: 0x1256A80 Offset: 0x1255080 VA: 0x181256A80
	|-QList<SlotAttachmentData>.Get
	|
	|-RVA: 0x12565E0 Offset: 0x1254BE0 VA: 0x1812565E0
	|-QList<StageEntity>.Get
	|
	|-RVA: 0x1255EA0 Offset: 0x12544A0 VA: 0x181255EA0
	|-QList<StatusEffectAttributeModifier>.Get
	|
	|-RVA: 0x1256B70 Offset: 0x1255170 VA: 0x181256B70
	|-QList<TargetStatePerEntity>.Get
	|
	|-RVA: 0x1256240 Offset: 0x1254840 VA: 0x181256240
	|-QList<__Il2CppFullySharedGenericStructType>.Get
	*/

	// RVA: -1 Offset: -1
	public QList.Iterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124D650 Offset: 0x124BC50 VA: 0x18124D650
	|-QList<ActionData>.GetEnumerator
	|-QList<AnimationSpeedElement>.GetEnumerator
	|-QList<ChildEntity>.GetEnumerator
	|-QList<EntityRef>.GetEnumerator
	|-QList<ExperienceEventData>.GetEnumerator
	|-QList<FPVector2>.GetEnumerator
	|-QList<GameEntityReference>.GetEnumerator
	|-QList<HitBox>.GetEnumerator
	|-QList<HitEvent>.GetEnumerator
	|-QList<HurtBox>.GetEnumerator
	|-QList<int>.GetEnumerator
	|-QList<ObjectVisibilityData>.GetEnumerator
	|-QList<RuntimeGameSpeedModifier>.GetEnumerator
	|-QList<RuntimeMechanicTutorialGoal>.GetEnumerator
	|-QList<RuntimeStatusEffect>.GetEnumerator
	|-QList<SFXToExecute>.GetEnumerator
	|-QList<ScheduledBehaviour>.GetEnumerator
	|-QList<SlotAttachmentData>.GetEnumerator
	|-QList<StageEntity>.GetEnumerator
	|-QList<StatusEffectAttributeModifier>.GetEnumerator
	|-QList<TargetStatePerEntity>.GetEnumerator
	|
	|-RVA: 0x12550F0 Offset: 0x12536F0 VA: 0x1812550F0
	|-QList<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1252140 Offset: 0x1250740 VA: 0x181252140
	|-QList<ActionData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<AnimationSpeedElement>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<ChildEntity>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<EntityRef>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<ExperienceEventData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<FPVector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<GameEntityReference>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<HitBox>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<HitEvent>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<HurtBox>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<ObjectVisibilityData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<RuntimeGameSpeedModifier>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<RuntimeMechanicTutorialGoal>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<RuntimeStatusEffect>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<SFXToExecute>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<ScheduledBehaviour>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<SlotAttachmentData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<StageEntity>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<StatusEffectAttributeModifier>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-QList<TargetStatePerEntity>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x125D740 Offset: 0x125BD40 VA: 0x18125D740
	|-QList<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12521E0 Offset: 0x12507E0 VA: 0x1812521E0
	|-QList<ActionData>.System.Collections.IEnumerable.GetEnumerator
	|-QList<AnimationSpeedElement>.System.Collections.IEnumerable.GetEnumerator
	|-QList<ChildEntity>.System.Collections.IEnumerable.GetEnumerator
	|-QList<EntityRef>.System.Collections.IEnumerable.GetEnumerator
	|-QList<ExperienceEventData>.System.Collections.IEnumerable.GetEnumerator
	|-QList<FPVector2>.System.Collections.IEnumerable.GetEnumerator
	|-QList<GameEntityReference>.System.Collections.IEnumerable.GetEnumerator
	|-QList<HitBox>.System.Collections.IEnumerable.GetEnumerator
	|-QList<HitEvent>.System.Collections.IEnumerable.GetEnumerator
	|-QList<HurtBox>.System.Collections.IEnumerable.GetEnumerator
	|-QList<int>.System.Collections.IEnumerable.GetEnumerator
	|-QList<ObjectVisibilityData>.System.Collections.IEnumerable.GetEnumerator
	|-QList<RuntimeGameSpeedModifier>.System.Collections.IEnumerable.GetEnumerator
	|-QList<RuntimeMechanicTutorialGoal>.System.Collections.IEnumerable.GetEnumerator
	|-QList<RuntimeStatusEffect>.System.Collections.IEnumerable.GetEnumerator
	|-QList<SFXToExecute>.System.Collections.IEnumerable.GetEnumerator
	|-QList<ScheduledBehaviour>.System.Collections.IEnumerable.GetEnumerator
	|-QList<SlotAttachmentData>.System.Collections.IEnumerable.GetEnumerator
	|-QList<StageEntity>.System.Collections.IEnumerable.GetEnumerator
	|-QList<StatusEffectAttributeModifier>.System.Collections.IEnumerable.GetEnumerator
	|-QList<TargetStatePerEntity>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x125D800 Offset: 0x125BE00 VA: 0x18125D800
	|-QList<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public static QList<T> Allocate<THeap>(THeap heap, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF640 Offset: 0x9ADC40 VA: 0x1809AF640
	|-QList<ActionData>.Allocate<object>
	|-QList<ChildEntity>.Allocate<object>
	|-QList<RuntimeGameSpeedModifier>.Allocate<object>
	|
	|-RVA: 0x9AF7C0 Offset: 0x9ADDC0 VA: 0x1809AF7C0
	|-QList<AnimationSpeedElement>.Allocate<object>
	|-QList<FPVector2>.Allocate<object>
	|-QList<HitEvent>.Allocate<object>
	|-QList<ScheduledBehaviour>.Allocate<object>
	|-QList<StatusEffectAttributeModifier>.Allocate<object>
	|
	|-RVA: 0x9AF6C0 Offset: 0x9ADCC0 VA: 0x1809AF6C0
	|-QList<EntityRef>.Allocate<object>
	|-QList<RuntimeMechanicTutorialGoal>.Allocate<object>
	|
	|-RVA: 0x9AFAC0 Offset: 0x9AE0C0 VA: 0x1809AFAC0
	|-QList<ExperienceEventData>.Allocate<object>
	|-QList<TargetStatePerEntity>.Allocate<object>
	|
	|-RVA: 0x9AF5C0 Offset: 0x9ADBC0 VA: 0x1809AF5C0
	|-QList<GameEntityReference>.Allocate<object>
	|
	|-RVA: 0x9AF9C0 Offset: 0x9ADFC0 VA: 0x1809AF9C0
	|-QList<HitBox>.Allocate<object>
	|
	|-RVA: 0x9AF740 Offset: 0x9ADD40 VA: 0x1809AF740
	|-QList<HurtBox>.Allocate<object>
	|
	|-RVA: 0x9AF840 Offset: 0x9ADE40 VA: 0x1809AF840
	|-QList<int>.Allocate<object>
	|
	|-RVA: 0x9AF540 Offset: 0x9ADB40 VA: 0x1809AF540
	|-QList<ObjectVisibilityData>.Allocate<object>
	|-QList<SlotAttachmentData>.Allocate<object>
	|
	|-RVA: 0x9AF8C0 Offset: 0x9ADEC0 VA: 0x1809AF8C0
	|-QList<RuntimeStatusEffect>.Allocate<object>
	|
	|-RVA: 0x9AF940 Offset: 0x9ADF40 VA: 0x1809AF940
	|-QList<SFXToExecute>.Allocate<object>
	|
	|-RVA: 0x9AFA40 Offset: 0x9AE040 VA: 0x1809AFA40
	|-QList<StageEntity>.Allocate<object>
	|
	|-RVA: 0x9B1640 Offset: 0x9AFC40 VA: 0x1809B1640
	|-QList<__Il2CppFullySharedGenericStructType>.Allocate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QListPtr<T> op_Implicit(QList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12529E0 Offset: 0x1250FE0 VA: 0x1812529E0
	|-QList<ActionData>.op_Implicit
	|
	|-RVA: 0x1252860 Offset: 0x1250E60 VA: 0x181252860
	|-QList<AnimationSpeedElement>.op_Implicit
	|
	|-RVA: 0x12526E0 Offset: 0x1250CE0 VA: 0x1812526E0
	|-QList<ChildEntity>.op_Implicit
	|
	|-RVA: 0x1252960 Offset: 0x1250F60 VA: 0x181252960
	|-QList<EntityRef>.op_Implicit
	|
	|-RVA: 0x1252760 Offset: 0x1250D60 VA: 0x181252760
	|-QList<ExperienceEventData>.op_Implicit
	|
	|-RVA: 0x12528E0 Offset: 0x1250EE0 VA: 0x1812528E0
	|-QList<FPVector2>.op_Implicit
	|
	|-RVA: 0x1252A60 Offset: 0x1251060 VA: 0x181252A60
	|-QList<GameEntityReference>.op_Implicit
	|
	|-RVA: 0x12527E0 Offset: 0x1250DE0 VA: 0x1812527E0
	|-QList<HitBox>.op_Implicit
	|
	|-RVA: 0x125E3A0 Offset: 0x125C9A0 VA: 0x18125E3A0
	|-QList<HitEvent>.op_Implicit
	|
	|-RVA: 0x125E120 Offset: 0x125C720 VA: 0x18125E120
	|-QList<HurtBox>.op_Implicit
	|
	|-RVA: 0x125E220 Offset: 0x125C820 VA: 0x18125E220
	|-QList<int>.op_Implicit
	|
	|-RVA: 0x125E720 Offset: 0x125CD20 VA: 0x18125E720
	|-QList<ObjectVisibilityData>.op_Implicit
	|
	|-RVA: 0x125E2A0 Offset: 0x125C8A0 VA: 0x18125E2A0
	|-QList<RuntimeGameSpeedModifier>.op_Implicit
	|
	|-RVA: 0x125E620 Offset: 0x125CC20 VA: 0x18125E620
	|-QList<RuntimeMechanicTutorialGoal>.op_Implicit
	|
	|-RVA: 0x125E520 Offset: 0x125CB20 VA: 0x18125E520
	|-QList<RuntimeStatusEffect>.op_Implicit
	|
	|-RVA: 0x125E4A0 Offset: 0x125CAA0 VA: 0x18125E4A0
	|-QList<SFXToExecute>.op_Implicit
	|
	|-RVA: 0x125E6A0 Offset: 0x125CCA0 VA: 0x18125E6A0
	|-QList<ScheduledBehaviour>.op_Implicit
	|
	|-RVA: 0x125E1A0 Offset: 0x125C7A0 VA: 0x18125E1A0
	|-QList<SlotAttachmentData>.op_Implicit
	|
	|-RVA: 0x125E420 Offset: 0x125CA20 VA: 0x18125E420
	|-QList<StageEntity>.op_Implicit
	|
	|-RVA: 0x125E320 Offset: 0x125C920 VA: 0x18125E320
	|-QList<StatusEffectAttributeModifier>.op_Implicit
	|
	|-RVA: 0x125E5A0 Offset: 0x125CBA0 VA: 0x18125E5A0
	|-QList<TargetStatePerEntity>.op_Implicit
	|
	|-RVA: 0x125E0A0 Offset: 0x125C6A0 VA: 0x18125E0A0
	|-QList<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/
}
