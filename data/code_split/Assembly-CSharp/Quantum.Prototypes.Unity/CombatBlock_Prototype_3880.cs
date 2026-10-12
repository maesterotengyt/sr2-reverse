// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CombatBlock))]
[Serializable]
public class CombatBlock_Prototype : PrototypeAdapter<CombatBlock_Prototype> // TypeDefIndex: 3880
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public QBoolean Blocking; // 0x18
	[HideInInspector]
	public FP BlockFrames; // 0x20
	[HideInInspector]
	public FP BlockStamina; // 0x28
	[HideInInspector]
	public FP PerfectBlockLockFrames; // 0x30
	[HideInInspector]
	public FP PerfectBlockBufferFrames; // 0x38

	// Methods

	// RVA: 0x672A60 Offset: 0x671060 VA: 0x180672A60 Slot: 5
	public sealed override CombatBlock_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672B10 Offset: 0x671110 VA: 0x180672B10
	public void .ctor() { }
}
