// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CombatTech))]
[Serializable]
public class CombatTech_Prototype : PrototypeAdapter<CombatTech_Prototype> // TypeDefIndex: 3883
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public QBoolean DetectTechLock; // 0x18
	[HideInInspector]
	public FP TechLockFrames; // 0x20
	[HideInInspector]
	public FP TechBufferFrames; // 0x28

	// Methods

	// RVA: 0x672D10 Offset: 0x671310 VA: 0x180672D10 Slot: 5
	public sealed override CombatTech_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672DB0 Offset: 0x6713B0 VA: 0x180672DB0
	public void .ctor() { }
}
