// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CollectorCharacter))]
[Serializable]
public class CollectorCharacter_Prototype : PrototypeAdapter<CollectorCharacter_Prototype> // TypeDefIndex: 3875
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public int Score; // 0x18

	// Methods

	// RVA: 0x6728C0 Offset: 0x670EC0 VA: 0x1806728C0 Slot: 5
	public sealed override CollectorCharacter_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672950 Offset: 0x670F50 VA: 0x180672950
	public void .ctor() { }
}
