// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(VisibilityTarget))]
[Serializable]
public class VisibilityTarget_Prototype : PrototypeAdapter<VisibilityTarget_Prototype> // TypeDefIndex: 3943
{
	// Fields
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public QBoolean Visible; // 0x18
	[HideInInspector]
	public QBoolean BoundsInitialized; // 0x1C
	public SimpleAABB_Prototype Bounds; // 0x20
	public QBoolean UseTriggerAsBounds; // 0x28
	public QBoolean AlterStateMachine; // 0x2C
	public int StateMachineUpdateCooldown; // 0x30
	public QBoolean AlterPhysicsBody; // 0x34
	public QBoolean AlterKinematicBody; // 0x38
	public QBoolean AlterTrigger; // 0x3C
	public QBoolean AlterCombat; // 0x40

	// Methods

	// RVA: 0x684EB0 Offset: 0x6834B0 VA: 0x180684EB0 Slot: 5
	public sealed override VisibilityTarget_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x684F80 Offset: 0x683580 VA: 0x180684F80
	public void .ctor() { }
}
