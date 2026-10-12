// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(EndlessGameModeManager))]
[Serializable]
public class EndlessGameModeManager_Prototype : PrototypeAdapter<EndlessGameModeManager_Prototype> // TypeDefIndex: 3889
{
	// Fields
	public FP DistanceRunned; // 0x10
	public FP SpawnedPlataforms; // 0x18
	[HideInInspector]
	public FP RandomPlataformIndex; // 0x20
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] Plataforms; // 0x28
	public QBoolean HasDialogue; // 0x30

	// Methods

	// RVA: 0x675220 Offset: 0x673820 VA: 0x180675220 Slot: 5
	public sealed override EndlessGameModeManager_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x675370 Offset: 0x673970 VA: 0x180675370
	public void .ctor() { }
}
