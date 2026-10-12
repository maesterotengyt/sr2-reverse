// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CombatDI))]
[Serializable]
public class CombatDI_Prototype : PrototypeAdapter<CombatDI_Prototype> // TypeDefIndex: 3882
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public QBoolean CalculateDI; // 0x18
	[HideInInspector]
	public FP DIAngle; // 0x20
	[HideInInspector]
	public FPVector2 SDI; // 0x28
	[HideInInspector]
	public int TriggeredSDIs; // 0x38

	// Methods

	// RVA: 0x672C30 Offset: 0x671230 VA: 0x180672C30 Slot: 5
	public sealed override CombatDI_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672CD0 Offset: 0x6712D0 VA: 0x180672CD0
	public void .ctor() { }
}
