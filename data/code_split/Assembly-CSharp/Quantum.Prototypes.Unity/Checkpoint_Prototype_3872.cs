// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Checkpoint))]
[Serializable]
public class Checkpoint_Prototype : PrototypeAdapter<Checkpoint_Prototype> // TypeDefIndex: 3872
{
	// Fields
	public QBoolean Active; // 0x10
	public QBoolean StartPoint; // 0x14
	public FP DistanceToFinish; // 0x18
	[LocalReference]
	public EntityPrototype RespawnPoint; // 0x20

	// Methods

	// RVA: 0x672710 Offset: 0x670D10 VA: 0x180672710 Slot: 5
	public sealed override Checkpoint_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6727B0 Offset: 0x670DB0 VA: 0x1806727B0
	public void .ctor() { }
}
