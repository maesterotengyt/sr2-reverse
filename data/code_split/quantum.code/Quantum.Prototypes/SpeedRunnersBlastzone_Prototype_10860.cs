// Namespace: Quantum.Prototypes
[Prototype(typeof(SpeedRunnersBlastzone))]
[Serializable]
public sealed class SpeedRunnersBlastzone_Prototype : ComponentPrototype<SpeedRunnersBlastzone> // TypeDefIndex: 10860
{
	// Fields
	[HideInInspector]
	public QBoolean Active; // 0x18
	[HideInInspector]
	public QBoolean TimerSuddenDeath; // 0x1C
	[HideInInspector]
	public QBoolean IsInSuddenDeath; // 0x20
	[HideInInspector]
	public FP SuddenDeathMultiplier; // 0x28
	[HideInInspector]
	public FP TimeToStartSuddenDeath; // 0x30

	// Methods

	// RVA: 0x210F170 Offset: 0x210D770 VA: 0x18210F170 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210F300 Offset: 0x210D900 VA: 0x18210F300
	public void Materialize(Frame frame, ref SpeedRunnersBlastzone result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210F270 Offset: 0x210D870 VA: 0x18210F270 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210F330 Offset: 0x210D930 VA: 0x18210F330
	public void .ctor() { }
}
