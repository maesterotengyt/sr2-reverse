// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(StellarNPC))]
[Serializable]
public class StellarNPC_Prototype : PrototypeAdapter<StellarNPC_Prototype> // TypeDefIndex: 3935
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
	public int Difficulty; // 0x1C

	// Methods

	// RVA: 0x683700 Offset: 0x681D00 VA: 0x180683700 Slot: 5
	public sealed override StellarNPC_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x683790 Offset: 0x681D90 VA: 0x180683790
	public void .ctor() { }
}
