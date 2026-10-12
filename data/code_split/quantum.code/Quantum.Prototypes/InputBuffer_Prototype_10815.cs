// Namespace: Quantum.Prototypes
[Prototype(typeof(InputBuffer))]
[Serializable]
public sealed class InputBuffer_Prototype : ComponentPrototype<InputBuffer> // TypeDefIndex: 10815
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	[HideInInspector]
	public int LastHistoryElementIndex; // 0x20
	[HideInInspector]
	public int BufferHistorySize; // 0x24
	[HideInInspector]
	[ArrayLength(60)]
	public InputValue_Prototype[] BufferHistory; // 0x28
	[HideInInspector]
	public InputFlag_Prototype PreviousInput; // 0x30
	[HideInInspector]
	public FP PreviousLeftStickX; // 0x38
	[HideInInspector]
	public FP PreviousLeftStickY; // 0x40
	[HideInInspector]
	public InputFlag_Prototype CurrentInput; // 0x48
	[HideInInspector]
	public FP CurrentLeftStickX; // 0x50
	[HideInInspector]
	public FP CurrentLeftStickY; // 0x58
	[HideInInspector]
	public AssetRefInputCheck_Behaviour CurrentInputCheckbehaviour; // 0x60
	[HideInInspector]
	public ButtonTimersContainer_Prototype ButtonTimersContainer; // 0x68

	// Methods

	// RVA: 0x21075C0 Offset: 0x2105BC0 VA: 0x1821075C0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2107790 Offset: 0x2105D90 VA: 0x182107790
	public void Materialize(Frame frame, ref InputBuffer result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2107700 Offset: 0x2105D00 VA: 0x182107700 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2107A60 Offset: 0x2106060 VA: 0x182107A60
	public void .ctor() { }
}
