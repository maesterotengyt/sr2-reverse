// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(FrogmanBossTongue))]
[Serializable]
public class FrogmanBossTongue_Prototype : PrototypeAdapter<FrogmanBossTongue_Prototype> // TypeDefIndex: 3896
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

	// RVA: 0x676D60 Offset: 0x675360 VA: 0x180676D60 Slot: 5
	public sealed override FrogmanBossTongue_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x676E20 Offset: 0x675420 VA: 0x180676E20
	public void .ctor() { }
}
