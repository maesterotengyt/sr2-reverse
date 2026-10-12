// Namespace: Quantum.Prototypes
[Prototype(typeof(ButtonTimersContainer))]
[Serializable]
public sealed class ButtonTimersContainer_Prototype : StructPrototype // TypeDefIndex: 10760
{
	// Fields
	[ArrayLength(6)]
	public InputTimer_Prototype[] InputButtonTimers; // 0x10
	[ArrayLength(4)]
	public InputTimer_Prototype[] InputDirectionTimers; // 0x18

	// Methods

	// RVA: 0x20FD100 Offset: 0x20FB700 VA: 0x1820FD100
	public void Materialize(Frame frame, ref ButtonTimersContainer result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FD260 Offset: 0x20FB860 VA: 0x1820FD260
	public void .ctor() { }
}
