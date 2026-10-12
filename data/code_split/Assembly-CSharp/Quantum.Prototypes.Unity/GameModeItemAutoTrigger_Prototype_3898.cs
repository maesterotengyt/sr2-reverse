// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(GameModeItemAutoTrigger))]
[Serializable]
public class GameModeItemAutoTrigger_Prototype : PrototypeAdapter<GameModeItemAutoTrigger_Prototype> // TypeDefIndex: 3898
{
	// Fields
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QString64 ItemToUse; // 0x18

	// Methods

	// RVA: 0x6771A0 Offset: 0x6757A0 VA: 0x1806771A0 Slot: 5
	public sealed override GameModeItemAutoTrigger_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677240 Offset: 0x675840 VA: 0x180677240
	public void .ctor() { }
}
