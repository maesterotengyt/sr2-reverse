// Namespace: Quantum.Prototypes
[Prototype(typeof(BossFightGameModeManager))]
[Serializable]
public sealed class BossFightGameModeManager_Prototype : ComponentPrototype<BossFightGameModeManager> // TypeDefIndex: 10758
{
	// Fields
	public BossFightState_Prototype CurrentState; // 0x18
	public FP CurrentCountdown; // 0x20
	public FP CurrentMatchTimer; // 0x28
	public QBoolean IsDialogue; // 0x30
	public QBoolean HasDialogue; // 0x34
	public QBoolean StartedTimer; // 0x38
	public FP PlayerStaminaBeforeHit; // 0x40

	// Methods

	// RVA: 0x20FCCD0 Offset: 0x20FB2D0 VA: 0x1820FCCD0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCE50 Offset: 0x20FB450 VA: 0x1820FCE50
	public void Materialize(Frame frame, ref BossFightGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCDC0 Offset: 0x20FB3C0 VA: 0x1820FCDC0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FCE90 Offset: 0x20FB490 VA: 0x1820FCE90
	public void .ctor() { }
}
