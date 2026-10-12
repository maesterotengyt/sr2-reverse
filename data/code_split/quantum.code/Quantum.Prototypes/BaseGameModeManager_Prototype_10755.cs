// Namespace: Quantum.Prototypes
[Prototype(typeof(BaseGameModeManager))]
[Serializable]
public sealed class BaseGameModeManager_Prototype : ComponentPrototype<BaseGameModeManager> // TypeDefIndex: 10755
{
	// Fields
	public QBoolean MatchEnded; // 0x18

	// Methods

	// RVA: 0x20FC7A0 Offset: 0x20FADA0 VA: 0x1820FC7A0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC8E0 Offset: 0x20FAEE0 VA: 0x1820FC8E0
	public void Materialize(Frame frame, ref BaseGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC850 Offset: 0x20FAE50 VA: 0x1820FC850 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FC8F0 Offset: 0x20FAEF0 VA: 0x1820FC8F0
	public void .ctor() { }
}
