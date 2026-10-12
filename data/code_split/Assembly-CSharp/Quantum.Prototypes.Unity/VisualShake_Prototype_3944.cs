// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(VisualShake))]
[Serializable]
public class VisualShake_Prototype : PrototypeAdapter<VisualShake_Prototype> // TypeDefIndex: 3944
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public FP ShakeFrames; // 0x18
	public FP ShakePower; // 0x20
	public QBoolean ShakeHorizontally; // 0x28
	public QBoolean ShakeVertically; // 0x2C

	// Methods

	// RVA: 0x684FC0 Offset: 0x6835C0 VA: 0x180684FC0 Slot: 5
	public sealed override VisualShake_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x685060 Offset: 0x683660 VA: 0x180685060
	public void .ctor() { }
}
