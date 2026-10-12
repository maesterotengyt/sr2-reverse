// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(RespawnPoint))]
[Serializable]
public class RespawnPoint_Prototype : PrototypeAdapter<RespawnPoint_Prototype> // TypeDefIndex: 3919
{
	// Fields
	public QBoolean IsInitial; // 0x10
	public RespawnDirection_Prototype Direction; // 0x14
	[HideInInspector]
	[LocalReference]
	public EntityPrototype NextCheckPoint; // 0x18

	// Methods

	// RVA: 0x680D90 Offset: 0x67F390 VA: 0x180680D90 Slot: 5
	public sealed override RespawnPoint_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x680E20 Offset: 0x67F420 VA: 0x180680E20
	public void .ctor() { }
}
