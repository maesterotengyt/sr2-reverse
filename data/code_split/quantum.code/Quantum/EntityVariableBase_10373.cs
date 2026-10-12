// Namespace: Quantum
public abstract class EntityVariableBase // TypeDefIndex: 10373
{
	// Fields
	public BehaviourTargetEntity TargetEntity; // 0x10
	public HashString TargetIndexParameterID; // 0x18
	public int Source; // 0x28
	public int SourceVariableIndex; // 0x2C
	public FP FloatValue; // 0x30
	public HashString ParameterID; // 0x38
	public InputPrerequisiteMode PrerequisiteEvaluation; // 0x48
	public InputBufferEventChecker[] InputActions; // 0x50
	public InputBufferEventChecker[] InputPrerequisites; // 0x58
	public static HashString[] StatusEffectsTypes; // 0x0
	public int SelectedStatusEffectType; // 0x60
	public bool IgnoreOriginEntity; // 0x64
	public BehaviourTargetEntity OriginEntity; // 0x68
	public HashString OriginIndexParameterID; // 0x70

	// Methods

	// RVA: 0x218B490 Offset: 0x2189A90 VA: 0x18218B490
	public void SetValue(Frame frame, CachedEntityData entityData, FP value) { }

	// RVA: 0x2187F60 Offset: 0x2186560 VA: 0x182187F60
	public FP GetValue(Frame frame, CachedEntityData entityData) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EntityVariableBase GetInputA();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract EntityVariableBase GetInputB();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract EntityVariableBase GetInputC();

	// RVA: 0x2187EE0 Offset: 0x21864E0 VA: 0x182187EE0
	private void ExtendedSetValue(Frame frame, CachedEntityData entityData, FP value) { }

	// RVA: 0x2187E60 Offset: 0x2186460 VA: 0x182187E60
	private void ExtendedGetValue(Frame frame, CachedEntityData entityData, ref FP value) { }

	// RVA: 0x218BD10 Offset: 0x218A310 VA: 0x18218BD10
	protected void .ctor() { }

	// RVA: 0x218BC70 Offset: 0x218A270 VA: 0x18218BC70
	private static void .cctor() { }
}
