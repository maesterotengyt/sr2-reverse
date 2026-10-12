// Namespace: Quantum.Prototypes
[Prototype(typeof(MatchTimer))]
[Serializable]
public sealed class MatchTimer_Prototype : ComponentPrototype<MatchTimer> // TypeDefIndex: 10824
{
	// Fields
	public QBoolean Active; // 0x18
	public FP CurrentTime; // 0x20

	// Methods

	// RVA: 0x2108A50 Offset: 0x2107050 VA: 0x182108A50 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108BB0 Offset: 0x21071B0 VA: 0x182108BB0
	public void Materialize(Frame frame, ref MatchTimer result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108B20 Offset: 0x2107120 VA: 0x182108B20 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2108BC0 Offset: 0x21071C0 VA: 0x182108BC0
	public void .ctor() { }
}
