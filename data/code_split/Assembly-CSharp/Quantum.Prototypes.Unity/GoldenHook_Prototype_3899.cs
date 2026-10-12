// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(GoldenHook))]
[Serializable]
public class GoldenHook_Prototype : PrototypeAdapter<GoldenHook_Prototype> // TypeDefIndex: 3899
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Hooked; // 0x18
	public FPVector2 LastDirection; // 0x20
	[LocalReference]
	public EntityPrototype TargetEntity; // 0x30
	public FP FramesWithoutTarget; // 0x38
	public FP PullFramesCountdown; // 0x40

	// Methods

	// RVA: 0x677280 Offset: 0x675880 VA: 0x180677280 Slot: 5
	public sealed override GoldenHook_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677340 Offset: 0x675940 VA: 0x180677340
	public void .ctor() { }
}
