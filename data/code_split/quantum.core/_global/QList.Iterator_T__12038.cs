// Namespace: 
public struct QList.Iterator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 12038
{
	// Fields
	private T* _current; // 0x0
	private int _index; // 0x0
	private int _count; // 0x0
	private int _offset; // 0x0
	private QBuffer _buffer; // 0x0
	private IFrameHeap _heap; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IFrameHeap heap, QBuffer buffer, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCFF80 Offset: 0xDCE580 VA: 0x180DCFF80
	|-QList.Iterator<ActionData>..ctor
	|-QList.Iterator<AnimationSpeedElement>..ctor
	|-QList.Iterator<ChildEntity>..ctor
	|-QList.Iterator<EntityRef>..ctor
	|-QList.Iterator<ExperienceEventData>..ctor
	|-QList.Iterator<FPVector2>..ctor
	|-QList.Iterator<GameEntityReference>..ctor
	|-QList.Iterator<HitBox>..ctor
	|-QList.Iterator<HitEvent>..ctor
	|-QList.Iterator<HurtBox>..ctor
	|-QList.Iterator<int>..ctor
	|-QList.Iterator<ObjectVisibilityData>..ctor
	|-QList.Iterator<RuntimeGameSpeedModifier>..ctor
	|-QList.Iterator<RuntimeMechanicTutorialGoal>..ctor
	|-QList.Iterator<RuntimeStatusEffect>..ctor
	|-QList.Iterator<SFXToExecute>..ctor
	|-QList.Iterator<ScheduledBehaviour>..ctor
	|-QList.Iterator<SlotAttachmentData>..ctor
	|-QList.Iterator<StageEntity>..ctor
	|-QList.Iterator<StatusEffectAttributeModifier>..ctor
	|-QList.Iterator<TargetStatePerEntity>..ctor
	|-QList.Iterator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCEF50 Offset: 0xDCD550 VA: 0x180DCEF50
	|-QList.Iterator<ActionData>.MoveNext
	|
	|-RVA: 0xDCF190 Offset: 0xDCD790 VA: 0x180DCF190
	|-QList.Iterator<AnimationSpeedElement>.MoveNext
	|
	|-RVA: 0xDCEC80 Offset: 0xDCD280 VA: 0x180DCEC80
	|-QList.Iterator<ChildEntity>.MoveNext
	|
	|-RVA: 0xDCEA40 Offset: 0xDCD040 VA: 0x180DCEA40
	|-QList.Iterator<EntityRef>.MoveNext
	|
	|-RVA: 0xDCF4F0 Offset: 0xDCDAF0 VA: 0x180DCF4F0
	|-QList.Iterator<ExperienceEventData>.MoveNext
	|
	|-RVA: 0xDCEBF0 Offset: 0xDCD1F0 VA: 0x180DCEBF0
	|-QList.Iterator<FPVector2>.MoveNext
	|
	|-RVA: 0xDCEAD0 Offset: 0xDCD0D0 VA: 0x180DCEAD0
	|-QList.Iterator<GameEntityReference>.MoveNext
	|
	|-RVA: 0xDCF2B0 Offset: 0xDCD8B0 VA: 0x180DCF2B0
	|-QList.Iterator<HitBox>.MoveNext
	|
	|-RVA: 0xDCE9B0 Offset: 0xDCCFB0 VA: 0x180DCE9B0
	|-QList.Iterator<HitEvent>.MoveNext
	|
	|-RVA: 0xDCEFE0 Offset: 0xDCD5E0 VA: 0x180DCEFE0
	|-QList.Iterator<HurtBox>.MoveNext
	|
	|-RVA: 0xDCF340 Offset: 0xDCD940 VA: 0x180DCF340
	|-QList.Iterator<int>.MoveNext
	|
	|-RVA: 0xDCE920 Offset: 0xDCCF20 VA: 0x180DCE920
	|-QList.Iterator<ObjectVisibilityData>.MoveNext
	|
	|-RVA: 0xDCF070 Offset: 0xDCD670 VA: 0x180DCF070
	|-QList.Iterator<RuntimeGameSpeedModifier>.MoveNext
	|
	|-RVA: 0xDCF3D0 Offset: 0xDCD9D0 VA: 0x180DCF3D0
	|-QList.Iterator<RuntimeMechanicTutorialGoal>.MoveNext
	|
	|-RVA: 0xDCEB60 Offset: 0xDCD160 VA: 0x180DCEB60
	|-QList.Iterator<RuntimeStatusEffect>.MoveNext
	|
	|-RVA: 0xDCEEC0 Offset: 0xDCD4C0 VA: 0x180DCEEC0
	|-QList.Iterator<SFXToExecute>.MoveNext
	|
	|-RVA: 0xDCF220 Offset: 0xDCD820 VA: 0x180DCF220
	|-QList.Iterator<ScheduledBehaviour>.MoveNext
	|
	|-RVA: 0xDCF460 Offset: 0xDCDA60 VA: 0x180DCF460
	|-QList.Iterator<SlotAttachmentData>.MoveNext
	|
	|-RVA: 0xDCED10 Offset: 0xDCD310 VA: 0x180DCED10
	|-QList.Iterator<StageEntity>.MoveNext
	|
	|-RVA: 0xDCE890 Offset: 0xDCCE90 VA: 0x180DCE890
	|-QList.Iterator<StatusEffectAttributeModifier>.MoveNext
	|
	|-RVA: 0xDCEDA0 Offset: 0xDCD3A0 VA: 0x180DCEDA0
	|-QList.Iterator<TargetStatePerEntity>.MoveNext
	|
	|-RVA: 0xDCF100 Offset: 0xDCD700 VA: 0x180DCF100
	|-QList.Iterator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCF580 Offset: 0xDCDB80 VA: 0x180DCF580
	|-QList.Iterator<ActionData>.Reset
	|-QList.Iterator<AnimationSpeedElement>.Reset
	|-QList.Iterator<ChildEntity>.Reset
	|-QList.Iterator<EntityRef>.Reset
	|-QList.Iterator<ExperienceEventData>.Reset
	|-QList.Iterator<FPVector2>.Reset
	|-QList.Iterator<GameEntityReference>.Reset
	|-QList.Iterator<HitBox>.Reset
	|-QList.Iterator<HitEvent>.Reset
	|-QList.Iterator<HurtBox>.Reset
	|-QList.Iterator<int>.Reset
	|-QList.Iterator<ObjectVisibilityData>.Reset
	|-QList.Iterator<RuntimeGameSpeedModifier>.Reset
	|-QList.Iterator<RuntimeMechanicTutorialGoal>.Reset
	|-QList.Iterator<RuntimeStatusEffect>.Reset
	|-QList.Iterator<SFXToExecute>.Reset
	|-QList.Iterator<ScheduledBehaviour>.Reset
	|-QList.Iterator<SlotAttachmentData>.Reset
	|-QList.Iterator<StageEntity>.Reset
	|-QList.Iterator<StatusEffectAttributeModifier>.Reset
	|-QList.Iterator<TargetStatePerEntity>.Reset
	|-QList.Iterator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD00B0 Offset: 0xDCE6B0 VA: 0x180DD00B0
	|-QList.Iterator<ActionData>.get_Current
	|-QList.Iterator<ChildEntity>.get_Current
	|-QList.Iterator<RuntimeGameSpeedModifier>.get_Current
	|
	|-RVA: 0xDD0050 Offset: 0xDCE650 VA: 0x180DD0050
	|-QList.Iterator<AnimationSpeedElement>.get_Current
	|-QList.Iterator<FPVector2>.get_Current
	|-QList.Iterator<HitEvent>.get_Current
	|-QList.Iterator<ScheduledBehaviour>.get_Current
	|-QList.Iterator<StatusEffectAttributeModifier>.get_Current
	|
	|-RVA: 0xDD0710 Offset: 0xDCED10 VA: 0x180DD0710
	|-QList.Iterator<EntityRef>.get_Current
	|-QList.Iterator<RuntimeMechanicTutorialGoal>.get_Current
	|
	|-RVA: 0xDD0320 Offset: 0xDCE920 VA: 0x180DD0320
	|-QList.Iterator<ExperienceEventData>.get_Current
	|-QList.Iterator<TargetStatePerEntity>.get_Current
	|
	|-RVA: 0xDD0870 Offset: 0xDCEE70 VA: 0x180DD0870
	|-QList.Iterator<GameEntityReference>.get_Current
	|
	|-RVA: 0xDD07C0 Offset: 0xDCEDC0 VA: 0x180DD07C0
	|-QList.Iterator<HitBox>.get_Current
	|
	|-RVA: 0xDD0120 Offset: 0xDCE720 VA: 0x180DD0120
	|-QList.Iterator<HurtBox>.get_Current
	|
	|-RVA: 0xDD03A0 Offset: 0xDCE9A0 VA: 0x180DD03A0
	|-QList.Iterator<int>.get_Current
	|
	|-RVA: 0xDD0530 Offset: 0xDCEB30 VA: 0x180DD0530
	|-QList.Iterator<ObjectVisibilityData>.get_Current
	|-QList.Iterator<SlotAttachmentData>.get_Current
	|
	|-RVA: 0xDCFFE0 Offset: 0xDCE5E0 VA: 0x180DCFFE0
	|-QList.Iterator<RuntimeStatusEffect>.get_Current
	|
	|-RVA: 0xDD08F0 Offset: 0xDCEEF0 VA: 0x180DD08F0
	|-QList.Iterator<SFXToExecute>.get_Current
	|
	|-RVA: 0xDD05E0 Offset: 0xDCEBE0 VA: 0x180DD05E0
	|-QList.Iterator<StageEntity>.get_Current
	|
	|-RVA: 0xDD0200 Offset: 0xDCE800 VA: 0x180DD0200
	|-QList.Iterator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCFC00 Offset: 0xDCE200 VA: 0x180DCFC00
	|-QList.Iterator<ActionData>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<ChildEntity>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<RuntimeGameSpeedModifier>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCFE10 Offset: 0xDCE410 VA: 0x180DCFE10
	|-QList.Iterator<AnimationSpeedElement>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<FPVector2>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<HitEvent>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<ScheduledBehaviour>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<StatusEffectAttributeModifier>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCFCB0 Offset: 0xDCE2B0 VA: 0x180DCFCB0
	|-QList.Iterator<EntityRef>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<RuntimeMechanicTutorialGoal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCFB30 Offset: 0xDCE130 VA: 0x180DCFB30
	|-QList.Iterator<ExperienceEventData>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<TargetStatePerEntity>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCF5A0 Offset: 0xDCDBA0 VA: 0x180DCF5A0
	|-QList.Iterator<GameEntityReference>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCF720 Offset: 0xDCDD20 VA: 0x180DCF720
	|-QList.Iterator<HitBox>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCF810 Offset: 0xDCDE10 VA: 0x180DCF810
	|-QList.Iterator<HurtBox>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCF670 Offset: 0xDCDC70 VA: 0x180DCF670
	|-QList.Iterator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCFD60 Offset: 0xDCE360 VA: 0x180DCFD60
	|-QList.Iterator<ObjectVisibilityData>.System.Collections.IEnumerator.get_Current
	|-QList.Iterator<SlotAttachmentData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCFEC0 Offset: 0xDCE4C0 VA: 0x180DCFEC0
	|-QList.Iterator<RuntimeStatusEffect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCF930 Offset: 0xDCDF30 VA: 0x180DCF930
	|-QList.Iterator<SFXToExecute>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDCFA20 Offset: 0xDCE020 VA: 0x180DCFA20
	|-QList.Iterator<StageEntity>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDC7630 Offset: 0xDC5C30 VA: 0x180DC7630
	|-QList.Iterator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	|-QList.Iterator<ActionData>.Dispose
	|-QList.Iterator<AnimationSpeedElement>.Dispose
	|-QList.Iterator<ChildEntity>.Dispose
	|-QList.Iterator<EntityRef>.Dispose
	|-QList.Iterator<ExperienceEventData>.Dispose
	|-QList.Iterator<FPVector2>.Dispose
	|-QList.Iterator<GameEntityReference>.Dispose
	|-QList.Iterator<HitBox>.Dispose
	|-QList.Iterator<HitEvent>.Dispose
	|-QList.Iterator<HurtBox>.Dispose
	|-QList.Iterator<int>.Dispose
	|-QList.Iterator<ObjectVisibilityData>.Dispose
	|-QList.Iterator<RuntimeGameSpeedModifier>.Dispose
	|-QList.Iterator<RuntimeMechanicTutorialGoal>.Dispose
	|-QList.Iterator<RuntimeStatusEffect>.Dispose
	|-QList.Iterator<SFXToExecute>.Dispose
	|-QList.Iterator<ScheduledBehaviour>.Dispose
	|-QList.Iterator<SlotAttachmentData>.Dispose
	|-QList.Iterator<StageEntity>.Dispose
	|-QList.Iterator<StatusEffectAttributeModifier>.Dispose
	|-QList.Iterator<TargetStatePerEntity>.Dispose
	|-QList.Iterator<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}
