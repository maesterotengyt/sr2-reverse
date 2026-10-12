// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PartnersManager))]
[Serializable]
public class PartnersManager_Prototype : PrototypeAdapter<PartnersManager_Prototype> // TypeDefIndex: 3913
{
	// Fields
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] CharacterEntities; // 0x10
	public int CurrentCharacterIndex; // 0x18
	public QBoolean CharacterSwapAllowed; // 0x1C
	public FP CharacterSwapCooldown; // 0x20

	// Methods

	// RVA: 0x67BCD0 Offset: 0x67A2D0 VA: 0x18067BCD0 Slot: 5
	public sealed override PartnersManager_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x67BE10 Offset: 0x67A410 VA: 0x18067BE10
	public void .ctor() { }
}
