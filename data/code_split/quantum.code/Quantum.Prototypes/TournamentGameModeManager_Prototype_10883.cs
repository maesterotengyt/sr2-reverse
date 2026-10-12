// Namespace: Quantum.Prototypes
[Prototype(typeof(TournamentGameModeManager))]
[Serializable]
public sealed class TournamentGameModeManager_Prototype : ComponentPrototype<TournamentGameModeManager> // TypeDefIndex: 10883
{
	// Fields
	public FP CurrentRocketsTimer; // 0x18
	public FP RocketsWarningTimer; // 0x20
	public FP ItemSpawnCooldown; // 0x28

	// Methods

	// RVA: 0x21132F0 Offset: 0x21118F0 VA: 0x1821132F0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113450 Offset: 0x2111A50 VA: 0x182113450
	public void Materialize(Frame frame, ref TournamentGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21133C0 Offset: 0x21119C0 VA: 0x1821133C0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2113470 Offset: 0x2111A70 VA: 0x182113470
	public void .ctor() { }
}
