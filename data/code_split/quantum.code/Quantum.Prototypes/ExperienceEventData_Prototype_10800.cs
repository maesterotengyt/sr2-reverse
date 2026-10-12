// Namespace: Quantum.Prototypes
[Prototype(typeof(ExperienceEventData))]
[Serializable]
public sealed class ExperienceEventData_Prototype : StructPrototype // TypeDefIndex: 10800
{
	// Fields
	public QString64 ID; // 0x10
	[HideInInspector]
	public int Count; // 0x50

	// Methods

	// RVA: 0x2105020 Offset: 0x2103620 VA: 0x182105020
	public void Materialize(Frame frame, ref ExperienceEventData result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
