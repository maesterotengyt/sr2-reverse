// Namespace: Quantum
public class EventSetSFXParameter : EventBase // TypeDefIndex: 10158
{
	// Fields
	public QString128 EventID; // 0x40
	public QString128 ParameterID; // 0xC0
	public QString128 ParameterStringValue; // 0x140
	public FP ParameterFloatValue; // 0x1C0
	public EntityRef EntityRef; // 0x1C8
	public QBoolean StringParameter; // 0x1D0
	public QBoolean GlobalParameters; // 0x1D4

	// Methods

	// RVA: 0x213A770 Offset: 0x2138D70 VA: 0x18213A770
	public void .ctor() { }

	// RVA: 0x213A6E0 Offset: 0x2138CE0 VA: 0x18213A6E0 Slot: 2
	public override int GetHashCode() { }
}
