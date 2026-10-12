// Namespace: Quantum.Prototypes
[Prototype(typeof(RaceGameModeManager))]
[Serializable]
public sealed class RaceGameModeManager_Prototype : ComponentPrototype<RaceGameModeManager> // TypeDefIndex: 10841
{
	// Fields
	public RaceState_Prototype CurrentState; // 0x18
	public FP CurrentCountdown; // 0x20
	public FP CurrentMatchTimer; // 0x28

	// Methods

	// RVA: 0x210CEC0 Offset: 0x210B4C0 VA: 0x18210CEC0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D030 Offset: 0x210B630 VA: 0x18210D030
	public void Materialize(Frame frame, ref RaceGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210CFA0 Offset: 0x210B5A0 VA: 0x18210CFA0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210D050 Offset: 0x210B650 VA: 0x18210D050
	public void .ctor() { }
}
