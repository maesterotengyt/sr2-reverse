// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(InputBuffer))]
[Serializable]
public class InputBuffer_Prototype : PrototypeAdapter<InputBuffer_Prototype> // TypeDefIndex: 3903
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
	[HideInInspector]
	public int LastHistoryElementIndex; // 0x1C
	[HideInInspector]
	public int BufferHistorySize; // 0x20
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

	// RVA: 0x6779B0 Offset: 0x675FB0 VA: 0x1806779B0 Slot: 5
	public sealed override InputBuffer_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677AA0 Offset: 0x6760A0 VA: 0x180677AA0
	public void .ctor() { }
}
