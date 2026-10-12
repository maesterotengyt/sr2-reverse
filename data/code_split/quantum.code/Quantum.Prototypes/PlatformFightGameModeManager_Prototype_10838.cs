// Namespace: Quantum.Prototypes
[Prototype(typeof(PlatformFightGameModeManager))]
[Serializable]
public sealed class PlatformFightGameModeManager_Prototype : ComponentPrototype<PlatformFightGameModeManager> // TypeDefIndex: 10838
{
	// Fields
	public PlatformFightState_Prototype CurrentState; // 0x18
	public FP CurrentCountdown; // 0x20

	// Methods

	// RVA: 0x210C480 Offset: 0x210AA80 VA: 0x18210C480 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21051B0 Offset: 0x21037B0 VA: 0x1821051B0
	public void Materialize(Frame frame, ref PlatformFightGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210C550 Offset: 0x210AB50 VA: 0x18210C550 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210C5E0 Offset: 0x210ABE0 VA: 0x18210C5E0
	public void .ctor() { }
}
