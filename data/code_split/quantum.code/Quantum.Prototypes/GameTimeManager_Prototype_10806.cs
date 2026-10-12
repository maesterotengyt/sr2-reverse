// Namespace: Quantum.Prototypes
[Prototype(typeof(GameTimeManager))]
[Serializable]
public sealed class GameTimeManager_Prototype : ComponentPrototype<GameTimeManager> // TypeDefIndex: 10806
{
	// Fields
	public FP GameSpeed; // 0x18
	public QBoolean Paused; // 0x20
	[DynamicCollection]
	public RuntimeGameSpeedModifier_Prototype[] SpeedModifiers; // 0x28

	// Methods

	// RVA: 0x2105E80 Offset: 0x2104480 VA: 0x182105E80 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2106180 Offset: 0x2104780 VA: 0x182106180
	public void Materialize(Frame frame, ref GameTimeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21060F0 Offset: 0x21046F0 VA: 0x1821060F0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2106340 Offset: 0x2104940 VA: 0x182106340
	public void .ctor() { }
}
