// Namespace: Quantum
public struct VisibilityTarget : IComponent // TypeDefIndex: 10065
{
	// Fields
	public QBoolean AlterCombat; // 0x4
	public QBoolean AlterKinematicBody; // 0x8
	public QBoolean AlterPhysicsBody; // 0xC
	public QBoolean AlterStateMachine; // 0x10
	public QBoolean AlterTrigger; // 0x14
	public SimpleAABB Bounds; // 0x30
	[HideInInspector]
	public QBoolean BoundsInitialized; // 0x18
	[HideInInspector]
	public EntityRef Entity; // 0x28
	public int StateMachineUpdateCooldown; // 0x0
	public QBoolean UseTriggerAsBounds; // 0x1C
	[HideInInspector]
	public QBoolean Visible; // 0x20

	// Methods

	// RVA: 0x214E390 Offset: 0x214C990 VA: 0x18214E390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214E440 Offset: 0x214CA40 VA: 0x18214E440
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
